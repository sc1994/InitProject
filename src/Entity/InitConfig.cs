using Newtonsoft.Json;

namespace Entity
{
	public class InitConfig
	{
		public string SolutionPath { get; set; }
		public string DbConnectionStrings { get; set; }
		public string Dbs { get; set; }
		public string Business { get; set; }
		public string Cache { get; set; }
		[JsonProperty("DAL")]
		public string Dal { get; set; }
		public string Common { get; set; }
		public string Entity { get; set; }
		public string Factory { get; set; }
		public string Model { get; set; }
		public string Utilities { get; set; }
		public string Web { get; set; }
	}
}
