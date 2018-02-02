using System.Collections.Generic;

namespace Entity
{
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true)]
	[System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
	public class packages
	{

		private List<packagesPackage> packageField = new List<packagesPackage>();

		/// <remarks/>
		[System.Xml.Serialization.XmlElement("package")]
		public List<packagesPackage> package
		{
			get
			{
				return this.packageField;
			}
			set
			{
				this.packageField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true)]
	public class packagesPackage
	{

		private string idField;

		private string versionField;

		private string targetFrameworkField = "net461"; // todo 目前是默认, 发现问题的在做兼容

		private bool developmentDependencyField;

		private bool developmentDependencyFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string targetFramework
		{
			get
			{
				return this.targetFrameworkField;
			}
			set
			{
				this.targetFrameworkField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public bool developmentDependency
		{
			get
			{
				return this.developmentDependencyField;
			}
			set
			{
				this.developmentDependencyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool developmentDependencySpecified
		{
			get
			{
				return this.developmentDependencyFieldSpecified;
			}
			set
			{
				this.developmentDependencyFieldSpecified = value;
			}
		}
	}


}
