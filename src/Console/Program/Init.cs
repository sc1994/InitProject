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
            if (Config.Business.IsNullOrEmpty() ||
                Config.Dal.IsNullOrEmpty() ||
                Config.Model.IsNullOrEmpty() ||
                Config.SolutionPath.IsNullOrEmpty() ||
                Config.Cache.IsNullOrEmpty() ||
                Config.DbConnectionStrings.IsNullOrEmpty() ||
                Config.Dbs.IsNullOrEmpty() ||
                Config.Entity.IsNullOrEmpty() ||
                Config.Web.IsNullOrEmpty() ||
                Config.Factory.IsNullOrEmpty() ||
                Config.Utilities.IsNullOrEmpty() ||
                Config.Common.IsNullOrEmpty())
            {
                "请确保InifConfig.json 中的配置齐全".WriteError();
            }
        }

        private static InitConfig GetConfig()
        {
            InitConfig result = new InitConfig();
            var path = "../../InitConfig.json";
            try
            {
                var a = Convert.ToInt16("asd");
                var json = File.ReadAllText(path);
                result = json.JsonToObject<InitConfig>();
            }
            catch
            {
                $"配置有误请检查配置文件: {Path.GetFullPath(path)}".WriteError();
            }
            return result;
        }
    }
}
