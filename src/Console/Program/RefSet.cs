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
		private static readonly Dictionary<string, string> PackageDictionary = new Dictionary<string, string>
		{
			{ "StackExchange.Redis","1.2.6"},
			{ "Dapper","1.50.4"},
			{ "log4net","2.0.8"},
			{ "TinyMapper","2.0.8"},
			{ "Autofac","4.6.2"},
			{ "Autofac.Mvc5","4.0.2"}
		};

		private static readonly List<string> ProjectReferences = new List<string>();

		public void InitProjectReferences(InitConfig config)
		{
			ProjectReferences.Add(config.Business);
			ProjectReferences.Add(config.Cache);
			ProjectReferences.Add(config.Common);
			ProjectReferences.Add(config.Dal);
			ProjectReferences.Add(config.Entity);
			ProjectReferences.Add(config.Factory);
			ProjectReferences.Add(config.Model);
			ProjectReferences.Add(config.Utilities);
		}

		/// <summary>
		/// 给某个项目配置某种包
		/// </summary>
		/// <param name="project">某个项目</param>
		/// <param name="packageEnum">某个包</param>
		public static void SetPackage(string project, PackageEnum packageEnum)
		{
			var package = packageEnum.ToDescription();
			var load = new Random().Next(1, 4);
			Parallel.Invoke(
				() =>
				{
					$"正在配置\"{package}\"--到--\"{project}\"".WriteWait(load, false);
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
							version = PackageDictionary[package]
						});
						File.WriteAllText(packagesPath, packages.ToXml<packages>());
					}
					else
					{
						Thread.Sleep(load * 950);
						$"\"{project}\"已存在对\"{package}\"的引用".WriteColor(ConsoleColor.DarkGreen);
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
									HintPath = $"..\\packages\\{package}.{PackageDictionary[package]}\\lib\\net45\\{package}.dll"
								});
								File.WriteAllText(csprojPath, csproj.ToXml<Project>());
							}
						}
					}
					#endregion
				});
		}
	}
}
