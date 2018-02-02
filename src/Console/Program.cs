using System;
using Entity;
using Utilities;

namespace UserConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			RefSet.SetPackage(Init.Config.Business, PackageEnum.Autofac);
		}
	}
}
