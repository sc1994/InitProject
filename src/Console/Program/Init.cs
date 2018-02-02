using System;
using Entity;
using Utilities;
using System.IO;

namespace UserConsole
{
	public class Init
	{
		public static InitConfig Config = GetConfig();

		public void Start()
		{

		}

		private static InitConfig GetConfig()
		{
			var json = File.ReadAllText("../../InitConfig.json");
			var result = json.JsonToObject<InitConfig>();
			if (result.Business.IsNullOrEmpty() ||
			    result.Dal.IsNullOrEmpty() ||
			    result.Model.IsNullOrEmpty() ||
			    result.SolutionPath.IsNullOrEmpty() ||
			    result.Cache.IsNullOrEmpty() ||
			    result.DbConnectionStrings.IsNullOrEmpty() ||
			    result.Dbs.IsNullOrEmpty() ||
			    result.Entity.IsNullOrEmpty() ||
			    result.Web.IsNullOrEmpty() ||
			    result.Factory.IsNullOrEmpty() ||
			    result.Utilities.IsNullOrEmpty() ||
			    result.Common.IsNullOrEmpty())
			{
				"请确保InifConfig.json 中的配置齐全".WriteError();
				"系统即将关闭".WriteWait(5);
			}

			return result;
		}
	}
}
