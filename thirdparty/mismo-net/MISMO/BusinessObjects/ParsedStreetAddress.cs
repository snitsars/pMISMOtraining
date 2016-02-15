using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'PARSED_STREET_ADDRESS'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class ParsedStreetAddress : ParsedStreetAddressBase, OrcaLogic.Xml.IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ParsedStreetAddress() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ParsedStreetAddress(System.Int64 loanApplicationId) : base(loanApplicationId)
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
				return "PARSED_STREET_ADDRESS";
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

			switch(key)
			{
				case "ApartmentOrUnit":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "DirectionPrefix":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "DirectionSuffix":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "BuildingNumber":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HouseNumber":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "Military_APO_FPO":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "PostOfficeBox":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "RuralRoute":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "StreetName":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "StreetSuffix":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
			}
			return true;
		}

		#endregion Overrides for IXmlFactoryElement
	}
}
