using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'PROPERTY'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class Property : PropertyBase, OrcaLogic.Xml.IXmlFactoryElement
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Property() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public Property(System.Int64 loanApplicationId) : base(loanApplicationId)
		{
		}



		#endregion Constructors

		#region IXmlFactoryElement Members

		bool IXmlFactoryElement.ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			return ProcessAttribute(ref attributeEntry);
		}

		System.Collections.Specialized.NameValueCollection IXmlFactoryElement.AdditionalAttributes
		{
			get
			{
				return AdditionalAttributes;
			}
		}

		string OrcaLogic.Xml.IXmlFactoryElement.ElementName
		{
			get
			{
				return "PROPERTY";
			}
		}


		#endregion

		#region Overrides for IXmlFactoryElement

		protected virtual System.Collections.Specialized.NameValueCollection AdditionalAttributes
		{
			get { return null; }
		}

		protected virtual bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			string key = attributeEntry.Key as string;
			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			if (key == "StructureBuiltYear")
				attributeEntry.Value = ((DateTime) attributeEntry.Value).Year.ToString();

			switch(key)
			{
				case "GSEPropertyType":
				{
					return false; // not rendered in AUS 2.3.1
				}
				case "StreetAddress":
				case "StreetAddress2":
				case "City":
				case "State":
				case "County":
				case "PostalCode":
				case "FinancedNumberOfUnits":
				case "StructureBuiltYear":
				case "AcquiredDate":
				case "AcreageNumber":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "BuildingStatusType":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.BuildingStatusType) attributeEntry.Value));
					break;
				}
			}
			return true;
		}

		#endregion Overrides for IXmlFactoryElement
	}
}
