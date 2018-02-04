using System;
using Entity;
using Utilities;
using System.IO;

namespace UserConsole
{
	public class Init
	{
		public static InitConfig Config = GetConfig();

		public static void ShowConfig()
		{
			var config = "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n" +
						 $"+  链接到的数据库: {Config.DbConnectionStrings}  \r\n" +
						 $"+  目标库: {Config.Dbs}  \r\n" +
						 $"+  目标项目: {Config.SolutionPath}  \r\n" +
						 $"+  Business: {Config.Business}  \r\n" +
						 $"+  Cache: {Config.Cache}  \r\n" +
						 $"+  Common: {Config.Common}  \r\n" +
						 $"+  DAL: {Config.Dal}  \r\n" +
						 $"+  Entity: {Config.Entity}  \r\n" +
						 $"+  Factory: {Config.Factory}  \r\n" +
						 $"+  Model: {Config.Model}  \r\n" +
						 $"+  Utilites: {Config.Utilities}  \r\n" +
						 $"+  Web: {Config.Web}  \r\n" +
						 "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n";
			config.WriteMajor(true);
		}

		public static void VerifyConfig()
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
