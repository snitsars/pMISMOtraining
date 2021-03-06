using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'PROPOSED_HOUSING_EXPENSE'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class ProposedHousingExpense : ProposedHousingExpenseBase, OrcaLogic.Xml.IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProposedHousingExpense() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ProposedHousingExpense(System.Int64 id) : base(id)
		{
		}



		#endregion Constructors

		#region Properties

		/// <summary>
		/// Gets the core MISMO element name for the ProposedHousingExpenses object.
		/// </summary>
		protected string ElementName
		{
			get { return "PROPOSED_HOUSING_EXPENSE"; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Generates the xml for the object instance.
		/// </summary>
		/// <param name="parentElement">The parent element of this object instance.</param>
		/// <returns>A valid xml element.</returns>
		internal virtual System.Xml.XmlElement ToXml(System.Xml.XmlElement parentElement)
		{
			return XmlFactory.GenerateElement(parentElement, this);
		}
		
		#endregion Methods

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
				return "PROPOSED_HOUSING_EXPENSE";
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
				case "PaymentAmount":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HousingExpenseType":
				{
					attributeEntry.Value = string.Format("{0}", ((Enums.HousingExpenseType) attributeEntry.Value));
					break;
				}
			}
			return true;
		}

		#endregion Overrides for IXmlFactoryElement
	}
}
