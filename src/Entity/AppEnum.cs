using System.ComponentModel;

namespace Entity
{
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
        Utilities,
		Web
    }
}
