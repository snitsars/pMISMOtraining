using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'LEGAL_DESCRIPTION'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class LegalDescription : LegalDescriptionBase, OrcaLogic.Xml.IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LegalDescription() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LegalDescription(System.Int64 loanApplicationId) : base(loanApplicationId)
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
				return "_LEGAL_DESCRIPTION";
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
				case "TextDescription":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "Type":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.LegalDescriptionType) attributeEntry.Value));
					break;
				}
			}
			return true;
		}

		#endregion Overrides for IXmlFactoryElement
	}
}
