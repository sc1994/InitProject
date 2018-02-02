using System;
using Entity;
using Utilities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace UserConsole
{
	public class RefSet
	{
		private readonly Dictionary<string, string> PackageDictionary = new Dictionary<string, string>
		{
			{ "StackExchange.Redis","1.2.6"},
			{ "Dapper","1.50.4"},
			{ "log4net","2.0.8"},
			{ "TinyMapper","2.0.8"},
			{ "Autofac","4.6.2"},
			{ "Autofac.Mvc5","4.0.2"}
		};

		private readonly List<string> _projectReferences = new List<string>();

		public void InitProjectReferences(InitConfig config)
		{
			_projectReferences.Add(config.Business);
			_projectReferences.Add(config.Cache);
			_projectReferences.Add(config.Common);
			_projectReferences.Add(config.Dal);
			_projectReferences.Add(config.Entity);
			_projectReferences.Add(config.Factory);
			_projectReferences.Add(config.Model);
			_projectReferences.Add(config.Utilities);
		}

		/// <summary>
		/// 给某个项目配置某种包
		/// </summary>
		/// <param name="project">某个项目</param>
		/// <param name="package">某个包</param>
		public static void SetPackage(string project, PackageEnum package)
		{
			Parallel.Invoke(
				() =>
				{
					$"正在配置\"{package.ToDescription()}\"--到--\"{project}\"".WriteWait(new Random().Next(1, 4));
				},
				() =>
				{
					var projectPath = Path.Combine(Init.Config.SolutionPath, project);

				});
		}
	}


}
