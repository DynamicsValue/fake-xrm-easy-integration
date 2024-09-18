#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataverseEntities
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum dv_test_dv_choice
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Option1 = 121940000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Option2 = 121940001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Option3 = 121940002,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum dv_test_dv_choice_multiple
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Option1 = 121940000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Option2 = 121940001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Option3 = 121940002,
	}
	
	/// <summary>
	/// Status of the DV Test Table
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum dv_test_statecode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Reason for the status of the DV Test Table
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public enum dv_test_statuscode
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 2,
	}
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dv_test")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.6")]
	public partial class dv_test : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Available fields, a the time of codegen, for the dv_test entity
		/// </summary>
		public partial class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyname";
			public const string CreatedByYomiName = "createdbyyominame";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyname";
			public const string CreatedOnBehalfByYomiName = "createdonbehalfbyyominame";
			public const string dv_accountid = "dv_accountid";
			public const string dv_accountidName = "dv_accountidname";
			public const string dv_accountidYomiName = "dv_accountidyominame";
			public const string dv_bool = "dv_bool";
			public const string dv_boolName = "dv_boolname";
			public const string dv_choice = "dv_choice";
			public const string dv_choice_multiple = "dv_choice_multiple";
			public const string dv_choice_multipleName = "dv_choice_multiplename";
			public const string dv_choiceName = "dv_choicename";
			public const string dv_code = "dv_code";
			public const string dv_currency = "dv_currency";
			public const string dv_currency_Base = "dv_currency_base";
			public const string dv_customerid = "dv_customerid";
			public const string dv_customeridName = "dv_customeridname";
			public const string dv_customeridYomiName = "dv_customeridyominame";
			public const string dv_date_only = "dv_date_only";
			public const string dv_date_time = "dv_date_time";
			public const string dv_decimal = "dv_decimal";
			public const string dv_duration = "dv_duration";
			public const string dv_email = "dv_email";
			public const string dv_file = "dv_file";
			public const string dv_file_Name = "dv_file_name";
			public const string dv_float = "dv_float";
			public const string dv_fullimage = "dv_fullimage";
			public const string dv_fullimage_Timestamp = "dv_fullimage_timestamp";
			public const string dv_fullimage_URL = "dv_fullimage_url";
			public const string dv_fullimageId = "dv_fullimageid";
			public const string dv_image = "dv_image";
			public const string dv_image_Timestamp = "dv_image_timestamp";
			public const string dv_image_URL = "dv_image_url";
			public const string dv_imageId = "dv_imageid";
			public const string dv_int = "dv_int";
			public const string dv_language_code = "dv_language_code";
			public const string dv_phone_number = "dv_phone_number";
			public const string dv_string = "dv_string";
			public const string dv_testId = "dv_testid";
			public const string Id = "dv_testid";
			public const string dv_text_area = "dv_text_area";
			public const string dv_ticker_symbol = "dv_ticker_symbol";
			public const string dv_time_zone = "dv_time_zone";
			public const string dv_url = "dv_url";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyname";
			public const string ModifiedByYomiName = "modifiedbyyominame";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwnerIdName = "owneridname";
			public const string OwnerIdYomiName = "owneridyominame";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningBusinessUnitName = "owningbusinessunitname";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string statecode = "statecode";
			public const string statecodeName = "statecodename";
			public const string statuscode = "statuscode";
			public const string statuscodeName = "statuscodename";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TransactionCurrencyIdName = "transactioncurrencyidname";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string dv_test_FileAttachments = "dv_test_FileAttachments";
			public const string dv_test_Contact_Contact = "dv_test_Contact_Contact";
			public const string dv_account_dv_test_365 = "dv_account_dv_test_365";
			public const string dv_contact_dv_test_365 = "dv_contact_dv_test_365";
			public const string dv_test_accountid_account = "dv_test_accountid_account";
			public const string FileAttachment_dv_test_dv_file = "FileAttachment_dv_test_dv_file";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public dv_test() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "dv_test";
		
		public const string EntityLogicalCollectionName = "dv_tests";
		
		public const string EntitySetName = "dv_tests";
		
		public const int EntityTypeCode = 10319;
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyname")]
		public string CreatedByName
		{
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyyominame")]
		public string CreatedByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("createdby"))
				{
					return this.FormattedValues["createdby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyname")]
		public string CreatedOnBehalfByName
		{
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfbyyominame")]
		public string CreatedOnBehalfByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("createdonbehalfby"))
				{
					return this.FormattedValues["createdonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_accountid")]
		public Microsoft.Xrm.Sdk.EntityReference dv_accountid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dv_accountid");
			}
			set
			{
				this.SetAttributeValue("dv_accountid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_accountidname")]
		public string dv_accountidName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_accountid"))
				{
					return this.FormattedValues["dv_accountid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_accountidyominame")]
		public string dv_accountidYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_accountid"))
				{
					return this.FormattedValues["dv_accountid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_bool")]
		public System.Nullable<bool> dv_bool
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("dv_bool");
			}
			set
			{
				this.SetAttributeValue("dv_bool", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_boolname")]
		public string dv_boolName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_bool"))
				{
					return this.FormattedValues["dv_bool"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_choice")]
		public virtual dv_test_dv_choice? dv_choice
		{
			get
			{
				return ((dv_test_dv_choice?)(EntityOptionSetEnum.GetEnum(this, "dv_choice")));
			}
			set
			{
				this.SetAttributeValue("dv_choice", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		#if FAKE_XRM_EASY_9
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_choice_multiple")]
		public virtual System.Collections.Generic.IEnumerable<dv_test_dv_choice_multiple> dv_choice_multiple
		{
			get
			{
				return EntityOptionSetEnum.GetMultiEnum<dv_test_dv_choice_multiple>(this, "dv_choice_multiple");
			}
			set
			{
				this.SetAttributeValue("dv_choice_multiple", EntityOptionSetEnum.GetMultiEnum(this, "dv_choice_multiple", value));
			}
		}
		
		#endif
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_choice_multiplename")]
		public string dv_choice_multipleName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_choice_multiple"))
				{
					return this.FormattedValues["dv_choice_multiple"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_choicename")]
		public string dv_choiceName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_choice"))
				{
					return this.FormattedValues["dv_choice"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_code")]
		public string dv_code
		{
			get
			{
				return this.GetAttributeValue<string>("dv_code");
			}
			set
			{
				this.SetAttributeValue("dv_code", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_currency")]
		public Microsoft.Xrm.Sdk.Money dv_currency
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("dv_currency");
			}
			set
			{
				this.SetAttributeValue("dv_currency", value);
			}
		}
		
		/// <summary>
		/// Value of the currency in base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_currency_base")]
		public Microsoft.Xrm.Sdk.Money dv_currency_Base
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("dv_currency_base");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_customerid")]
		public Microsoft.Xrm.Sdk.EntityReference dv_customerid
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dv_customerid");
			}
			set
			{
				this.SetAttributeValue("dv_customerid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_customeridname")]
		public string dv_customeridName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_customerid"))
				{
					return this.FormattedValues["dv_customerid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_customeridyominame")]
		public string dv_customeridYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("dv_customerid"))
				{
					return this.FormattedValues["dv_customerid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_date_only")]
		public System.Nullable<System.DateTime> dv_date_only
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("dv_date_only");
			}
			set
			{
				this.SetAttributeValue("dv_date_only", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_date_time")]
		public System.Nullable<System.DateTime> dv_date_time
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("dv_date_time");
			}
			set
			{
				this.SetAttributeValue("dv_date_time", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_decimal")]
		public System.Nullable<decimal> dv_decimal
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("dv_decimal");
			}
			set
			{
				this.SetAttributeValue("dv_decimal", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_duration")]
		public System.Nullable<int> dv_duration
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dv_duration");
			}
			set
			{
				this.SetAttributeValue("dv_duration", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_email")]
		public string dv_email
		{
			get
			{
				return this.GetAttributeValue<string>("dv_email");
			}
			set
			{
				this.SetAttributeValue("dv_email", value);
			}
		}
		
		#if FAKE_XRM_EASY_9 
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_file")]
		public object dv_file
		{
			get
			{
				return this.GetAttributeValue<object>("dv_file");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_file_name")]
		public string dv_file_Name
		{
			get
			{
				if (this.FormattedValues.Contains("dv_file"))
				{
					return this.FormattedValues["dv_file"];
				}
				else
				{
					return default(string);
				}
			}
		}
		#endif
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_float")]
		public System.Nullable<double> dv_float
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<double>>("dv_float");
			}
			set
			{
				this.SetAttributeValue("dv_float", value);
			}
		}
		
		/// <summary>
		/// An image column that can store full images
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_fullimage")]
		public byte[] dv_fullimage
		{
			get
			{
				return this.GetAttributeValue<byte[]>("dv_fullimage");
			}
			set
			{
				this.SetAttributeValue("dv_fullimage", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_fullimage_timestamp")]
		public System.Nullable<long> dv_fullimage_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("dv_fullimage_timestamp");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_fullimage_url")]
		public string dv_fullimage_URL
		{
			get
			{
				return this.GetAttributeValue<string>("dv_fullimage_url");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_fullimageid")]
		public System.Nullable<System.Guid> dv_fullimageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dv_fullimageid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_image")]
		public byte[] dv_image
		{
			get
			{
				return this.GetAttributeValue<byte[]>("dv_image");
			}
			set
			{
				this.SetAttributeValue("dv_image", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_image_timestamp")]
		public System.Nullable<long> dv_image_Timestamp
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("dv_image_timestamp");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_image_url")]
		public string dv_image_URL
		{
			get
			{
				return this.GetAttributeValue<string>("dv_image_url");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_imageid")]
		public System.Nullable<System.Guid> dv_imageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dv_imageid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_int")]
		public System.Nullable<int> dv_int
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dv_int");
			}
			set
			{
				this.SetAttributeValue("dv_int", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_language_code")]
		public System.Nullable<int> dv_language_code
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dv_language_code");
			}
			set
			{
				this.SetAttributeValue("dv_language_code", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_phone_number")]
		public string dv_phone_number
		{
			get
			{
				return this.GetAttributeValue<string>("dv_phone_number");
			}
			set
			{
				this.SetAttributeValue("dv_phone_number", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_string")]
		public string dv_string
		{
			get
			{
				return this.GetAttributeValue<string>("dv_string");
			}
			set
			{
				this.SetAttributeValue("dv_string", value);
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_testid")]
		public System.Nullable<System.Guid> dv_testId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("dv_testid");
			}
			set
			{
				this.SetAttributeValue("dv_testid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_testid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.dv_testId = value;
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_text_area")]
		public string dv_text_area
		{
			get
			{
				return this.GetAttributeValue<string>("dv_text_area");
			}
			set
			{
				this.SetAttributeValue("dv_text_area", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_ticker_symbol")]
		public string dv_ticker_symbol
		{
			get
			{
				return this.GetAttributeValue<string>("dv_ticker_symbol");
			}
			set
			{
				this.SetAttributeValue("dv_ticker_symbol", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_time_zone")]
		public System.Nullable<int> dv_time_zone
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("dv_time_zone");
			}
			set
			{
				this.SetAttributeValue("dv_time_zone", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_url")]
		public string dv_url
		{
			get
			{
				return this.GetAttributeValue<string>("dv_url");
			}
			set
			{
				this.SetAttributeValue("dv_url", value);
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the entity with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			set
			{
				this.SetAttributeValue("importsequencenumber", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyname")]
		public string ModifiedByName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyyominame")]
		public string ModifiedByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedby"))
				{
					return this.FormattedValues["modifiedby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyname")]
		public string ModifiedOnBehalfByName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfbyyominame")]
		public string ModifiedOnBehalfByYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("modifiedonbehalfby"))
				{
					return this.FormattedValues["modifiedonbehalfby"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			set
			{
				this.SetAttributeValue("overriddencreatedon", value);
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			set
			{
				this.SetAttributeValue("ownerid", value);
			}
		}
		
		/// <summary>
		/// Name of the owner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owneridname")]
		public string OwnerIdName
		{
			get
			{
				if (this.FormattedValues.Contains("ownerid"))
				{
					return this.FormattedValues["ownerid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Yomi name of the owner
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owneridyominame")]
		public string OwnerIdYomiName
		{
			get
			{
				if (this.FormattedValues.Contains("ownerid"))
				{
					return this.FormattedValues["ownerid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunitname")]
		public string OwningBusinessUnitName
		{
			get
			{
				if (this.FormattedValues.Contains("owningbusinessunit"))
				{
					return this.FormattedValues["owningbusinessunit"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the DV Test Table
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public virtual dv_test_statecode? statecode
		{
			get
			{
				return ((dv_test_statecode?)(EntityOptionSetEnum.GetEnum(this, "statecode")));
			}
			set
			{
				this.SetAttributeValue("statecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecodename")]
		public string statecodeName
		{
			get
			{
				if (this.FormattedValues.Contains("statecode"))
				{
					return this.FormattedValues["statecode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the DV Test Table
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual dv_test_statuscode? statuscode
		{
			get
			{
				return ((dv_test_statuscode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			set
			{
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscodename")]
		public string statuscodeName
		{
			get
			{
				if (this.FormattedValues.Contains("statuscode"))
				{
					return this.FormattedValues["statuscode"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			set
			{
				this.SetAttributeValue("timezoneruleversionnumber", value);
			}
		}
		
		/// <summary>
		/// Unique identifier of the currency associated with the entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			set
			{
				this.SetAttributeValue("transactioncurrencyid", value);
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyidname")]
		public string TransactionCurrencyIdName
		{
			get
			{
				if (this.FormattedValues.Contains("transactioncurrencyid"))
				{
					return this.FormattedValues["transactioncurrencyid"];
				}
				else
				{
					return default(string);
				}
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			set
			{
				this.SetAttributeValue("utcconversiontimezonecode", value);
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N dv_test_FileAttachments
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dv_test_FileAttachments")]
		public System.Collections.Generic.IEnumerable<DataverseEntities.FileAttachment> dv_test_FileAttachments
		{
			get
			{
				return this.GetRelatedEntities<DataverseEntities.FileAttachment>("dv_test_FileAttachments", null);
			}
			set
			{
				this.SetRelatedEntities<DataverseEntities.FileAttachment>("dv_test_FileAttachments", null, value);
			}
		}
		
		/// <summary>
		/// N:N dv_test_Contact_Contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dv_test_Contact_Contact")]
		public System.Collections.Generic.IEnumerable<DataverseEntities.Contact> dv_test_Contact_Contact
		{
			get
			{
				return this.GetRelatedEntities<DataverseEntities.Contact>("dv_test_Contact_Contact", null);
			}
			set
			{
				this.SetRelatedEntities<DataverseEntities.Contact>("dv_test_Contact_Contact", null, value);
			}
		}
		
		/// <summary>
		/// N:1 dv_account_dv_test_365
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dv_account_dv_test_365")]
		public DataverseEntities.Account dv_account_dv_test_365
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Account>("dv_account_dv_test_365", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Account>("dv_account_dv_test_365", null, value);
			}
		}
		
		/// <summary>
		/// N:1 dv_contact_dv_test_365
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_customerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dv_contact_dv_test_365")]
		public DataverseEntities.Contact dv_contact_dv_test_365
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Contact>("dv_contact_dv_test_365", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Contact>("dv_contact_dv_test_365", null, value);
			}
		}
		
		/// <summary>
		/// N:1 dv_test_accountid_account
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_accountid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dv_test_accountid_account")]
		public DataverseEntities.Account dv_test_accountid_account
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.Account>("dv_test_accountid_account", null);
			}
			set
			{
				this.SetRelatedEntity<DataverseEntities.Account>("dv_test_accountid_account", null, value);
			}
		}
		
		/// <summary>
		/// N:1 FileAttachment_dv_test_dv_file
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dv_file")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FileAttachment_dv_test_dv_file")]
		public DataverseEntities.FileAttachment FileAttachment_dv_test_dv_file
		{
			get
			{
				return this.GetRelatedEntity<DataverseEntities.FileAttachment>("FileAttachment_dv_test_dv_file", null);
			}
		}
	}
}
#pragma warning restore CS1591
