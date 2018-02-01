﻿namespace Entity
{
	/// <summary>
	/// web.config 对应实体
	/// </summary>
	[System.Serializable]
	[System.ComponentModel.DesignerCategory("code")]
	[System.Xml.Serialization.XmlType(AnonymousType = true)]
	[System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
	public class configuration
	{

		private configurationConfigSections configSectionsField;

		private configurationAdd[] connectionStringsField;

		private configurationAdd1[] appSettingsField;

		private configurationSystemweb systemwebField;

		private configurationRuntime runtimeField;

		private configurationSystemwebServer systemwebServerField;

		private configurationSystemcodedom systemcodedomField;

		/// <remarks/>
		public configurationConfigSections configSections
		{
			get
			{
				return this.configSectionsField;
			}
			set
			{
				this.configSectionsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
		public configurationAdd[] connectionStrings
		{
			get
			{
				return this.connectionStringsField;
			}
			set
			{
				this.connectionStringsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("add", IsNullable = false)]
		public configurationAdd1[] appSettings
		{
			get
			{
				return this.appSettingsField;
			}
			set
			{
				this.appSettingsField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("system.web")]
		public configurationSystemweb systemweb
		{
			get
			{
				return this.systemwebField;
			}
			set
			{
				this.systemwebField = value;
			}
		}

		/// <remarks/>
		public configurationRuntime runtime
		{
			get
			{
				return this.runtimeField;
			}
			set
			{
				this.runtimeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("system.webServer")]
		public configurationSystemwebServer systemwebServer
		{
			get
			{
				return this.systemwebServerField;
			}
			set
			{
				this.systemwebServerField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("system.codedom")]
		public configurationSystemcodedom systemcodedom
		{
			get
			{
				return this.systemcodedomField;
			}
			set
			{
				this.systemcodedomField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationConfigSections
	{

		private configurationConfigSectionsSection sectionField;

		/// <remarks/>
		public configurationConfigSectionsSection section
		{
			get
			{
				return this.sectionField;
			}
			set
			{
				this.sectionField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationConfigSectionsSection
	{

		private string nameField;

		private string typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationAdd
	{

		private string nameField;

		private string connectionStringField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string connectionString
		{
			get
			{
				return this.connectionStringField;
			}
			set
			{
				this.connectionStringField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationAdd1
	{

		private string keyField;

		private string valueField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string key
		{
			get
			{
				return this.keyField;
			}
			set
			{
				this.keyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string value
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
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemweb
	{

		private configurationSystemwebCompilation compilationField;

		private configurationSystemwebHttpRuntime httpRuntimeField;

		private configurationSystemwebHttpModules httpModulesField;

		/// <remarks/>
		public configurationSystemwebCompilation compilation
		{
			get
			{
				return this.compilationField;
			}
			set
			{
				this.compilationField = value;
			}
		}

		/// <remarks/>
		public configurationSystemwebHttpRuntime httpRuntime
		{
			get
			{
				return this.httpRuntimeField;
			}
			set
			{
				this.httpRuntimeField = value;
			}
		}

		/// <remarks/>
		public configurationSystemwebHttpModules httpModules
		{
			get
			{
				return this.httpModulesField;
			}
			set
			{
				this.httpModulesField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebCompilation
	{

		private bool debugField;

		private string targetFrameworkField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool debug
		{
			get
			{
				return this.debugField;
			}
			set
			{
				this.debugField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebHttpRuntime
	{

		private string targetFrameworkField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebHttpModules
	{

		private configurationSystemwebHttpModulesAdd addField;

		/// <remarks/>
		public configurationSystemwebHttpModulesAdd add
		{
			get
			{
				return this.addField;
			}
			set
			{
				this.addField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebHttpModulesAdd
	{

		private string nameField;

		private string typeField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationRuntime
	{

		private assemblyBindingDependentAssembly[] assemblyBindingField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:schemas-microsoft-com:asm.v1")]
		[System.Xml.Serialization.XmlArrayItemAttribute("dependentAssembly", IsNullable = false)]
		public assemblyBindingDependentAssembly[] assemblyBinding
		{
			get
			{
				return this.assemblyBindingField;
			}
			set
			{
				this.assemblyBindingField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:asm.v1")]
	public partial class assemblyBindingDependentAssembly
	{

		private assemblyBindingDependentAssemblyAssemblyIdentity assemblyIdentityField;

		private assemblyBindingDependentAssemblyBindingRedirect bindingRedirectField;

		/// <remarks/>
		public assemblyBindingDependentAssemblyAssemblyIdentity assemblyIdentity
		{
			get
			{
				return this.assemblyIdentityField;
			}
			set
			{
				this.assemblyIdentityField = value;
			}
		}

		/// <remarks/>
		public assemblyBindingDependentAssemblyBindingRedirect bindingRedirect
		{
			get
			{
				return this.bindingRedirectField;
			}
			set
			{
				this.bindingRedirectField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:asm.v1")]
	public partial class assemblyBindingDependentAssemblyAssemblyIdentity
	{

		private string nameField;

		private string cultureField;

		private string publicKeyTokenField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string culture
		{
			get
			{
				return this.cultureField;
			}
			set
			{
				this.cultureField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string publicKeyToken
		{
			get
			{
				return this.publicKeyTokenField;
			}
			set
			{
				this.publicKeyTokenField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:asm.v1")]
	public partial class assemblyBindingDependentAssemblyBindingRedirect
	{

		private string oldVersionField;

		private string newVersionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string oldVersion
		{
			get
			{
				return this.oldVersionField;
			}
			set
			{
				this.oldVersionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string newVersion
		{
			get
			{
				return this.newVersionField;
			}
			set
			{
				this.newVersionField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebServer
	{

		private configurationSystemwebServerValidation validationField;

		private configurationSystemwebServerModules modulesField;

		/// <remarks/>
		public configurationSystemwebServerValidation validation
		{
			get
			{
				return this.validationField;
			}
			set
			{
				this.validationField = value;
			}
		}

		/// <remarks/>
		public configurationSystemwebServerModules modules
		{
			get
			{
				return this.modulesField;
			}
			set
			{
				this.modulesField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebServerValidation
	{

		private bool validateIntegratedModeConfigurationField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool validateIntegratedModeConfiguration
		{
			get
			{
				return this.validateIntegratedModeConfigurationField;
			}
			set
			{
				this.validateIntegratedModeConfigurationField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebServerModules
	{

		private object[] itemsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("add", typeof(configurationSystemwebServerModulesAdd))]
		[System.Xml.Serialization.XmlElementAttribute("remove", typeof(configurationSystemwebServerModulesRemove))]
		public object[] Items
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
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebServerModulesAdd
	{

		private string nameField;

		private string typeField;

		private string preConditionField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string preCondition
		{
			get
			{
				return this.preConditionField;
			}
			set
			{
				this.preConditionField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemwebServerModulesRemove
	{

		private string nameField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string name
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
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemcodedom
	{

		private configurationSystemcodedomCompiler[] compilersField;

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayItemAttribute("compiler", IsNullable = false)]
		public configurationSystemcodedomCompiler[] compilers
		{
			get
			{
				return this.compilersField;
			}
			set
			{
				this.compilersField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class configurationSystemcodedomCompiler
	{

		private string languageField;

		private string extensionField;

		private string typeField;

		private byte warningLevelField;

		private string compilerOptionsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string extension
		{
			get
			{
				return this.extensionField;
			}
			set
			{
				this.extensionField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte warningLevel
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
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string compilerOptions
		{
			get
			{
				return this.compilerOptionsField;
			}
			set
			{
				this.compilerOptionsField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:schemas-microsoft-com:asm.v1")]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:schemas-microsoft-com:asm.v1", IsNullable = false)]
	public partial class assemblyBinding
	{

		private assemblyBindingDependentAssembly[] dependentAssemblyField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("dependentAssembly")]
		public assemblyBindingDependentAssembly[] dependentAssembly
		{
			get
			{
				return this.dependentAssemblyField;
			}
			set
			{
				this.dependentAssemblyField = value;
			}
		}
	}


}
