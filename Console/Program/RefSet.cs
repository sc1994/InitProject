using System.Collections.Generic;
using System.ComponentModel;
using Entity;

namespace Console.Program
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

		public void SetPackage(ProjectEnum project, PackageEnum package)
		{

		}
	}

	public enum PackageEnum
	{
		[Description("StackExchange.Redis")]
		StackExchangeRedis,
		[Description("Dapper")]
		Dapper,
		[Description("log4net")]
		LogNet,
		[Description("TinyMapper")]
		TinyMapper,
		[Description("Autofac")]
		Autofac,
		[Description("Autofac.Mvc5")]
		AutofacMvc5
	}

	public enum ProjectEnum
	{
		Business,
		Cache,
		Common,
		Dal,
		Entity,
		Factory,
		Model,
		Utilities
	}
}
