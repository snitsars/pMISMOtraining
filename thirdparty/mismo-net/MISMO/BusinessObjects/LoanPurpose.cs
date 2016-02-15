using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;

namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'LOAN_PURPOSE'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class LoanPurpose : LoanPurposeBase, IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanPurpose() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanPurpose(System.Int64 loanApplicationId) : base(loanApplicationId)
		{
		}



		#endregion Constructors

		#region IXmlFactoryElement Members

		/// <summary>
		/// Analyzes the processing of a particular attribute.
		/// </summary>
		/// <param name="attributeEntry">The attribute to analyze.</param>
		/// <returns>True if we want to continue processing and false otherwise.</returns>
		bool IXmlFactoryElement.ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			return this.ProcessAttribute(ref attributeEntry);
		}

		/// <summary>
		/// Analyzes the processing of a particular attribute.
		/// </summary>
		/// <param name="attributeEntry">The attribute to analyze.</param>
		/// <returns>True if we want to continue processing and false otherwise.</returns>
		protected virtual bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			string key = attributeEntry.Key as string;

			switch(key)
			{
				case "Type":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", (MISMO.Enums.LoanPurposeType) attributeEntry.Value);
					break;
				}
				case "PropertyRightsType":
				{
					attributeEntry.Value = string.Format("{0}", (MISMO.Enums.PropertyRightsType) attributeEntry.Value);
					break;
				}
				case "PropertyUsageType":
				{
					attributeEntry.Value = string.Format("{0}", (MISMO.Enums.PropertyUsageType) attributeEntry.Value);
					break;
				}
			}

			return true;
		}

		/// <summary>
		/// Gets or sets any additional Xml rendering
		/// </summary>
		System.Collections.Specialized.NameValueCollection IXmlFactoryElement.AdditionalAttributes
		{
			get
			{
				return this.AdditionalAttributes;
			}
		}

		/// <summary>
		/// Gets or sets any additional Xml rendering
		/// </summary>
		protected virtual System.Collections.Specialized.NameValueCollection AdditionalAttributes
		{
			get { return null; }
		}

		/// <summary>
		/// The name of the Xml element.
		/// </summary>
		string IXmlFactoryElement.ElementName
		{
			get
			{
				return this.ElementName;
			}
		}

		/// <summary>
		/// The name of the Xml element.
		/// </summary>
		protected virtual string ElementName
		{
			get
			{
				return "LOAN_PURPOSE";
			}
		}

		#endregion IXmlFactoryElement Members
	}
}
