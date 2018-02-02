using System.Collections.Generic;

namespace Entity
{

	// 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	[System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.microsoft.com/developer/msbuild/2003", IsNullable = false)]
	public class Project
	{

		private List<object> itemsField;

		private decimal toolsVersionField;

		private string defaultTargetsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElement("Import", typeof(ProjectImport))]
		[System.Xml.Serialization.XmlElement("ItemGroup", typeof(ProjectItemGroup))]
		[System.Xml.Serialization.XmlElement("ProjectExtensions", typeof(ProjectProjectExtensions))]
		[System.Xml.Serialization.XmlElement("PropertyGroup", typeof(ProjectPropertyGroup))]
		[System.Xml.Serialization.XmlElement("Target", typeof(ProjectTarget))]
		public List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public decimal ToolsVersion
		{
			get
			{
				return this.toolsVersionField;
			}
			set
			{
				this.toolsVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string DefaultTargets
		{
			get
			{
				return this.defaultTargetsField;
			}
			set
			{
				this.defaultTargetsField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectImport
	{

		private string projectField;

		private string conditionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroup
	{

		private List<object> itemsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElement("Compile", typeof(ProjectItemGroupCompile))]
		[System.Xml.Serialization.XmlElement("Content", typeof(ProjectItemGroupContent))]
		[System.Xml.Serialization.XmlElement("Folder", typeof(ProjectItemGroupFolder))]
		[System.Xml.Serialization.XmlElement("None", typeof(ProjectItemGroupNone))]
		[System.Xml.Serialization.XmlElement("ProjectReference", typeof(ProjectItemGroupProjectReference))]
		[System.Xml.Serialization.XmlElement("Reference", typeof(ProjectItemGroupReference))]
		[System.Xml.Serialization.XmlElement("Service", typeof(ProjectItemGroupService))]
		[System.Xml.Serialization.XmlElement("TypeScriptCompile", typeof(ProjectItemGroupTypeScriptCompile))]
		public List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupCompile
	{

		private string dependentUponField;

		private string includeField;

		/// <remarks/>
		public string DependentUpon
		{
			get
			{
				return this.dependentUponField;
			}
			set
			{
				this.dependentUponField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupContent
	{

		private string dependentUponField;

		private string copyToOutputDirectoryField;

		private string includeField;

		/// <remarks/>
		public string DependentUpon
		{
			get
			{
				return this.dependentUponField;
			}
			set
			{
				this.dependentUponField = value;
			}
		}

		/// <remarks/>
		public string CopyToOutputDirectory
		{
			get
			{
				return this.copyToOutputDirectoryField;
			}
			set
			{
				this.copyToOutputDirectoryField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupFolder
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupNone
	{

		private string subTypeField;

		private string includeField;

		/// <remarks/>
		public string SubType
		{
			get
			{
				return this.subTypeField;
			}
			set
			{
				this.subTypeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupProjectReference
	{

		private string projectField;

		private string nameField;

		private string includeField;

		/// <remarks/>
		public string Project
		{
			get
			{
				return this.projectField;
			}
			set
			{
				this.projectField = value;
			}
		}

		/// <remarks/>
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupReference
	{

		private string privateField;

		private string hintPathField;

		private string includeField;

		/// <remarks/>
		public string Private
		{
			get
			{
				return this.privateField;
			}
			set
			{
				this.privateField = value;
			}
		}

		/// <remarks/>
		public string HintPath
		{
			get
			{
				return this.hintPathField;
			}
			set
			{
				this.hintPathField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupService
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectItemGroupTypeScriptCompile
	{

		private string includeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Include
		{
			get
			{
				return this.includeField;
			}
			set
			{
				this.includeField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectProjectExtensions
	{

		private ProjectProjectExtensionsVisualStudio visualStudioField;

		/// <remarks/>
		public ProjectProjectExtensionsVisualStudio VisualStudio
		{
			get
			{
				return this.visualStudioField;
			}
			set
			{
				this.visualStudioField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectProjectExtensionsVisualStudio
	{

		private ProjectProjectExtensionsVisualStudioFlavorProperties flavorPropertiesField;

		/// <remarks/>
		public ProjectProjectExtensionsVisualStudioFlavorProperties FlavorProperties
		{
			get
			{
				return this.flavorPropertiesField;
			}
			set
			{
				this.flavorPropertiesField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectProjectExtensionsVisualStudioFlavorProperties
	{

		private ProjectProjectExtensionsVisualStudioFlavorPropertiesWebProjectProperties webProjectPropertiesField;

		private string gUIDField;

		/// <remarks/>
		public ProjectProjectExtensionsVisualStudioFlavorPropertiesWebProjectProperties WebProjectProperties
		{
			get
			{
				return this.webProjectPropertiesField;
			}
			set
			{
				this.webProjectPropertiesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string GUID
		{
			get
			{
				return this.gUIDField;
			}
			set
			{
				this.gUIDField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectProjectExtensionsVisualStudioFlavorPropertiesWebProjectProperties
	{

		private string useIISField;

		private string autoAssignPortField;

		private ushort developmentServerPortField;

		private string developmentServerVPathField;

		private string iISUrlField;

		private string nTLMAuthenticationField;

		private string useCustomServerField;

		private object customServerUrlField;

		private string saveServerSettingsInUserFileField;

		/// <remarks/>
		public string UseIIS
		{
			get
			{
				return this.useIISField;
			}
			set
			{
				this.useIISField = value;
			}
		}

		/// <remarks/>
		public string AutoAssignPort
		{
			get
			{
				return this.autoAssignPortField;
			}
			set
			{
				this.autoAssignPortField = value;
			}
		}

		/// <remarks/>
		public ushort DevelopmentServerPort
		{
			get
			{
				return this.developmentServerPortField;
			}
			set
			{
				this.developmentServerPortField = value;
			}
		}

		/// <remarks/>
		public string DevelopmentServerVPath
		{
			get
			{
				return this.developmentServerVPathField;
			}
			set
			{
				this.developmentServerVPathField = value;
			}
		}

		/// <remarks/>
		public string IISUrl
		{
			get
			{
				return this.iISUrlField;
			}
			set
			{
				this.iISUrlField = value;
			}
		}

		/// <remarks/>
		public string NTLMAuthentication
		{
			get
			{
				return this.nTLMAuthenticationField;
			}
			set
			{
				this.nTLMAuthenticationField = value;
			}
		}

		/// <remarks/>
		public string UseCustomServer
		{
			get
			{
				return this.useCustomServerField;
			}
			set
			{
				this.useCustomServerField = value;
			}
		}

		/// <remarks/>
		public object CustomServerUrl
		{
			get
			{
				return this.customServerUrlField;
			}
			set
			{
				this.customServerUrlField = value;
			}
		}

		/// <remarks/>
		public string SaveServerSettingsInUserFile
		{
			get
			{
				return this.saveServerSettingsInUserFileField;
			}
			set
			{
				this.saveServerSettingsInUserFileField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectPropertyGroup
	{

		private ProjectPropertyGroupVisualStudioVersion visualStudioVersionField;

		private ProjectPropertyGroupVSToolsPath vSToolsPathField;

		private bool debugSymbolsField;

		private bool debugSymbolsFieldSpecified;

		private string debugTypeField;

		private bool optimizeField;

		private bool optimizeFieldSpecified;

		private string outputPathField;

		private string defineConstantsField;

		private string errorReportField;

		private byte warningLevelField;

		private bool warningLevelFieldSpecified;

		private ProjectPropertyGroupConfiguration configurationField;

		private ProjectPropertyGroupPlatform platformField;

		private object productVersionField;

		private decimal schemaVersionField;

		private bool schemaVersionFieldSpecified;

		private string projectGuidField;

		private string projectTypeGuidsField;

		private string outputTypeField;

		private string appDesignerFolderField;

		private string rootNamespaceField;

		private string assemblyNameField;

		private string targetFrameworkVersionField;

		private bool mvcBuildViewsField;

		private bool mvcBuildViewsFieldSpecified;

		private bool useIISExpressField;

		private bool useIISExpressFieldSpecified;

		private object use64BitIISExpressField;

		private object iISExpressSSLPortField;

		private object iISExpressAnonymousAuthenticationField;

		private object iISExpressWindowsAuthenticationField;

		private object iISExpressUseClassicPipelineModeField;

		private object useGlobalApplicationHostFileField;

		private object nuGetPackageImportStampField;

		private decimal typeScriptToolsVersionField;

		private bool typeScriptToolsVersionFieldSpecified;

		private string conditionField;

		/// <remarks/>
		public ProjectPropertyGroupVisualStudioVersion VisualStudioVersion
		{
			get
			{
				return this.visualStudioVersionField;
			}
			set
			{
				this.visualStudioVersionField = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupVSToolsPath VSToolsPath
		{
			get
			{
				return this.vSToolsPathField;
			}
			set
			{
				this.vSToolsPathField = value;
			}
		}

		/// <remarks/>
		public bool DebugSymbols
		{
			get
			{
				return this.debugSymbolsField;
			}
			set
			{
				this.debugSymbolsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool DebugSymbolsSpecified
		{
			get
			{
				return this.debugSymbolsFieldSpecified;
			}
			set
			{
				this.debugSymbolsFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string DebugType
		{
			get
			{
				return this.debugTypeField;
			}
			set
			{
				this.debugTypeField = value;
			}
		}

		/// <remarks/>
		public bool Optimize
		{
			get
			{
				return this.optimizeField;
			}
			set
			{
				this.optimizeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool OptimizeSpecified
		{
			get
			{
				return this.optimizeFieldSpecified;
			}
			set
			{
				this.optimizeFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string OutputPath
		{
			get
			{
				return this.outputPathField;
			}
			set
			{
				this.outputPathField = value;
			}
		}

		/// <remarks/>
		public string DefineConstants
		{
			get
			{
				return this.defineConstantsField;
			}
			set
			{
				this.defineConstantsField = value;
			}
		}

		/// <remarks/>
		public string ErrorReport
		{
			get
			{
				return this.errorReportField;
			}
			set
			{
				this.errorReportField = value;
			}
		}

		/// <remarks/>
		public byte WarningLevel
		{
			get
			{
				return this.warningLevelField;
			}
			set
			{
				this.warningLevelField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool WarningLevelSpecified
		{
			get
			{
				return this.warningLevelFieldSpecified;
			}
			set
			{
				this.warningLevelFieldSpecified = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupConfiguration Configuration
		{
			get
			{
				return this.configurationField;
			}
			set
			{
				this.configurationField = value;
			}
		}

		/// <remarks/>
		public ProjectPropertyGroupPlatform Platform
		{
			get
			{
				return this.platformField;
			}
			set
			{
				this.platformField = value;
			}
		}

		/// <remarks/>
		public object ProductVersion
		{
			get
			{
				return this.productVersionField;
			}
			set
			{
				this.productVersionField = value;
			}
		}

		/// <remarks/>
		public decimal SchemaVersion
		{
			get
			{
				return this.schemaVersionField;
			}
			set
			{
				this.schemaVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool SchemaVersionSpecified
		{
			get
			{
				return this.schemaVersionFieldSpecified;
			}
			set
			{
				this.schemaVersionFieldSpecified = value;
			}
		}

		/// <remarks/>
		public string ProjectGuid
		{
			get
			{
				return this.projectGuidField;
			}
			set
			{
				this.projectGuidField = value;
			}
		}

		/// <remarks/>
		public string ProjectTypeGuids
		{
			get
			{
				return this.projectTypeGuidsField;
			}
			set
			{
				this.projectTypeGuidsField = value;
			}
		}

		/// <remarks/>
		public string OutputType
		{
			get
			{
				return this.outputTypeField;
			}
			set
			{
				this.outputTypeField = value;
			}
		}

		/// <remarks/>
		public string AppDesignerFolder
		{
			get
			{
				return this.appDesignerFolderField;
			}
			set
			{
				this.appDesignerFolderField = value;
			}
		}

		/// <remarks/>
		public string RootNamespace
		{
			get
			{
				return this.rootNamespaceField;
			}
			set
			{
				this.rootNamespaceField = value;
			}
		}

		/// <remarks/>
		public string AssemblyName
		{
			get
			{
				return this.assemblyNameField;
			}
			set
			{
				this.assemblyNameField = value;
			}
		}

		/// <remarks/>
		public string TargetFrameworkVersion
		{
			get
			{
				return this.targetFrameworkVersionField;
			}
			set
			{
				this.targetFrameworkVersionField = value;
			}
		}

		/// <remarks/>
		public bool MvcBuildViews
		{
			get
			{
				return this.mvcBuildViewsField;
			}
			set
			{
				this.mvcBuildViewsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool MvcBuildViewsSpecified
		{
			get
			{
				return this.mvcBuildViewsFieldSpecified;
			}
			set
			{
				this.mvcBuildViewsFieldSpecified = value;
			}
		}

		/// <remarks/>
		public bool UseIISExpress
		{
			get
			{
				return this.useIISExpressField;
			}
			set
			{
				this.useIISExpressField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool UseIISExpressSpecified
		{
			get
			{
				return this.useIISExpressFieldSpecified;
			}
			set
			{
				this.useIISExpressFieldSpecified = value;
			}
		}

		/// <remarks/>
		public object Use64BitIISExpress
		{
			get
			{
				return this.use64BitIISExpressField;
			}
			set
			{
				this.use64BitIISExpressField = value;
			}
		}

		/// <remarks/>
		public object IISExpressSSLPort
		{
			get
			{
				return this.iISExpressSSLPortField;
			}
			set
			{
				this.iISExpressSSLPortField = value;
			}
		}

		/// <remarks/>
		public object IISExpressAnonymousAuthentication
		{
			get
			{
				return this.iISExpressAnonymousAuthenticationField;
			}
			set
			{
				this.iISExpressAnonymousAuthenticationField = value;
			}
		}

		/// <remarks/>
		public object IISExpressWindowsAuthentication
		{
			get
			{
				return this.iISExpressWindowsAuthenticationField;
			}
			set
			{
				this.iISExpressWindowsAuthenticationField = value;
			}
		}

		/// <remarks/>
		public object IISExpressUseClassicPipelineMode
		{
			get
			{
				return this.iISExpressUseClassicPipelineModeField;
			}
			set
			{
				this.iISExpressUseClassicPipelineModeField = value;
			}
		}

		/// <remarks/>
		public object UseGlobalApplicationHostFile
		{
			get
			{
				return this.useGlobalApplicationHostFileField;
			}
			set
			{
				this.useGlobalApplicationHostFileField = value;
			}
		}

		/// <remarks/>
		public object NuGetPackageImportStamp
		{
			get
			{
				return this.nuGetPackageImportStampField;
			}
			set
			{
				this.nuGetPackageImportStampField = value;
			}
		}

		/// <remarks/>
		public decimal TypeScriptToolsVersion
		{
			get
			{
				return this.typeScriptToolsVersionField;
			}
			set
			{
				this.typeScriptToolsVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnore]
		public bool TypeScriptToolsVersionSpecified
		{
			get
			{
				return this.typeScriptToolsVersionFieldSpecified;
			}
			set
			{
				this.typeScriptToolsVersionFieldSpecified = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectPropertyGroupVisualStudioVersion
	{

		private string conditionField;

		private decimal valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlText]
		public decimal Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectPropertyGroupVSToolsPath
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectPropertyGroupConfiguration
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectPropertyGroupPlatform
	{

		private string conditionField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlText]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectTarget
	{

		private ProjectTargetPropertyGroup propertyGroupField;

		private ProjectTargetError[] errorField;

		private ProjectTargetAspNetCompiler aspNetCompilerField;

		private string nameField;

		private string afterTargetsField;

		private string conditionField;

		private string beforeTargetsField;

		/// <remarks/>
		public ProjectTargetPropertyGroup PropertyGroup
		{
			get
			{
				return this.propertyGroupField;
			}
			set
			{
				this.propertyGroupField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElement("Error")]
		public ProjectTargetError[] Error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}

		/// <remarks/>
		public ProjectTargetAspNetCompiler AspNetCompiler
		{
			get
			{
				return this.aspNetCompilerField;
			}
			set
			{
				this.aspNetCompilerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string AfterTargets
		{
			get
			{
				return this.afterTargetsField;
			}
			set
			{
				this.afterTargetsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string BeforeTargets
		{
			get
			{
				return this.beforeTargetsField;
			}
			set
			{
				this.beforeTargetsField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectTargetPropertyGroup
	{

		private string errorTextField;

		/// <remarks/>
		public string ErrorText
		{
			get
			{
				return this.errorTextField;
			}
			set
			{
				this.errorTextField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectTargetError
	{

		private string conditionField;

		private string textField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Condition
		{
			get
			{
				return this.conditionField;
			}
			set
			{
				this.conditionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
			}
		}
	}

	/// <remarks/>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/msbuild/2003")]
	public class ProjectTargetAspNetCompiler
	{

		private string virtualPathField;

		private string physicalPathField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string VirtualPath
		{
			get
			{
				return this.virtualPathField;
			}
			set
			{
				this.virtualPathField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttribute]
		public string PhysicalPath
		{
			get
			{
				return this.physicalPathField;
			}
			set
			{
				this.physicalPathField = value;
			}
		}
	}


}
