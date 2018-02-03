using System;
using Entity;
using Utilities;

namespace UserConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			RefSet.SetPackage(ProjectEnum.Web, PackageEnum.Autofac);
			RefSet.SetReference(ProjectEnum.Cache, ProjectEnum.Web);


			Console.ReadLine();
		}
	}
}
