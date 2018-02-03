using System;
using Entity;
using Utilities;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UserConsole
{
	public class RefSet
	{
		private static readonly Dictionary<PackageEnum, string> PackageDictionary = new Dictionary<PackageEnum, string>
																					{
																						{PackageEnum.StackExchangeRedis, "1.2.6"},
																						{PackageEnum.Dapper, "1.50.4"},
																						{PackageEnum.LogNet, "2.0.8"},
																						{PackageEnum.TinyMapper, "2.0.8"},
																						{PackageEnum.Autofac, "4.6.2"},
																						{PackageEnum.AutofacMvc5, "4.0.2"}
																					};

		private static readonly Dictionary<ProjectEnum, string> ProjectDictionary = new Dictionary<ProjectEnum, string>
																					{
																						{ProjectEnum.Business, Init.Config.Business},
																						{ProjectEnum.Cache, Init.Config.Cache},
																						{ProjectEnum.Common, Init.Config.Common},
																						{ProjectEnum.Dal, Init.Config.Dal},
																						{ProjectEnum.Entity, Init.Config.Entity},
																						{ProjectEnum.Factory, Init.Config.Factory},
																						{ProjectEnum.Model, Init.Config.Model},
																						{ProjectEnum.Utilities, Init.Config.Utilities},
																						{ProjectEnum.Web, Init.Config.Web}
																					};

		/// <summary>
		/// 给某个项目配置某种包
		/// </summary>
		/// <param name="projectEnum">某个项目</param>
		/// <param name="packageEnum">某个包</param>
		public static void SetPackage(ProjectEnum projectEnum, PackageEnum packageEnum)
		{
			var project = ProjectDictionary[projectEnum];
			var package = packageEnum.ToDescription();
			var load = new Random().Next(1, 4);
			var isSuccess = false;

			Parallel.Invoke(
				() =>
				{
					$"正在配置 : \"{package}\"--到--\"{project}\"".WriteWait(load, false);
				},
				() =>
				{
					#region package
					var packagesPath = Path.Combine(Init.Config.SolutionPath, project, "packages.config");
					var packages =
							File.Exists(packagesPath)
								? File.ReadAllText(packagesPath).XmlToObject<packages>()
								: new packages();
					if (packages.package.All(x => x.id != package))
					{
						packages.package.Add(new packagesPackage
						{
							id = package,
							version = PackageDictionary[packageEnum]
						});
						File.WriteAllText(packagesPath, packages.ToXml<packages>());
						isSuccess = true;
					}
					#endregion

					#region csproj
					var csprojPath = Path.Combine(Init.Config.SolutionPath, project, $"{project}.csproj");
					if (!File.Exists(csprojPath))
					{
						Thread.Sleep(load * 950);
						$"不存在文件\"{project}.csproj\"".WriteError();
						"即将结束本程序".WriteWait(5);
					}
					var csproj = File.ReadAllText(csprojPath).XmlToObject<Project>();
					foreach (var item in csproj.Items)
					{
						if (item is ProjectItemGroup itemGroup)
						{
							var exit = itemGroup.Items.Any(x =>
							{
								if (x is ProjectItemGroupReference reference)
								{
									return reference.Include == package;
								}
								return false;
							});
							if (!exit)
							{
								itemGroup.Items.Add(new ProjectItemGroupReference
								{
									Include = package,
									HintPath = $"..\\packages\\{package}.{PackageDictionary[packageEnum]}\\lib\\net45\\{package}.dll"
								});
								File.WriteAllText(csprojPath, csproj.ToXml<Project>());
								isSuccess = true;
							}
						}
					}
					#endregion
				});

			if (isSuccess)
			{
				"配置成功~".WritrSuccess();
			}
			else
			{
				$"跳过: \"{project}\"已存在对\"{package}\"的引用".WriteColor(ConsoleColor.DarkGreen);
			}
		}

		/// <summary>
		/// 给某个项目设置引用
		/// </summary>
		public static void SetReference(ProjectEnum fromProjectEnum, ProjectEnum toProjectEnum)
		{
			var toProject = ProjectDictionary[toProjectEnum];
			var fromProject = ProjectDictionary[fromProjectEnum];
			var load = new Random().Next(1, 4);
			var isSuccess = false;

			Parallel.Invoke(
				() =>
				{
					$"正在配置 : \"{fromProject}\"--到--\"{toProject}\"".WriteWait(load, false);
				},
				() =>
				{
					var projectPath = Path.Combine(Init.Config.SolutionPath, toProject, $"{toProject}.csproj");
					if (!File.Exists(projectPath))
					{
						Thread.Sleep(load * 950);
						$"不存在文件\"{toProject}.csproj\"".WriteError();
						"即将结束本程序".WriteWait(5);
					}
					var project = File.ReadAllText(projectPath).XmlToObject<Project>();
					foreach (var item in project.Items)
					{
						if (item is ProjectItemGroup group)
						{
							if (group.Items.Any(g => g is ProjectItemGroupProjectReference))
							{
								var exit = group.Items.Any(g =>
													  {
														  if (g is ProjectItemGroupProjectReference reference)
														  {
															  return reference.Name == fromProject;
														  }
														  return false;
													  });
								if (!exit)
								{
									group.Items.Add(new ProjectItemGroupProjectReference
									{
										Name = fromProject,
										Include = $"..\\{fromProject}\\{fromProject}.csproj"
									});
									File.WriteAllText(projectPath, project.ToXml<Project>());
									isSuccess = true;
								}
							}
						}
					}
				});
			if (isSuccess)
			{
				if (isSuccess)
				{
					"配置成功~".WritrSuccess();
				}
				else
				{
					$"跳过: \"{toProject}\"已存在对\"{fromProject}\"的引用".WriteColor(ConsoleColor.DarkGreen);
				}
			}
		}
	}
}
