using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'CREDIT_SCORE'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class CreditScore : CreditScoreBase, IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditScore() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public CreditScore(System.Int32 creditScoreID) : base(creditScoreID)
		{
		}



		#endregion Constructors

		#region IXmlFactoryElement Members


		/// <summary>
		/// Method executed by the xml factory.
		/// </summary>
		/// <param name="attributeEntry">The key-value pair of the element's attribute.</param>
		/// <returns>True if the factory should continue processing and false otherwise</returns>
		bool IXmlFactoryElement.ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			return this.ProcessAttribute(ref attributeEntry);
		}

		/// <summary>
		/// Gets any additional attributes to be processed by the xml factory.
		/// </summary>
		System.Collections.Specialized.NameValueCollection IXmlFactoryElement.AdditionalAttributes
		{
			get
			{
				return this.AdditionalAttributes;
			}
		}


		/// <summary>
		/// Gets the element name of the xml factory object.
		/// </summary>
		string IXmlFactoryElement.ElementName
		{
			get
			{
				return this.ElementName;
			}
		}

		/// <summary>
		/// Gets any additional attributes for the credit score object.
		/// </summary>
		protected virtual System.Collections.Specialized.NameValueCollection AdditionalAttributes
		{
			get { return null; }
		}

		/// <summary>
		/// Method executed by the xml factory.
		/// </summary>
		/// <param name="attributeEntry">The key-value pair of the element's attribute.</param>
		/// <returns>True if the factory should continue processing and false otherwise</returns>
		protected virtual bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			string key = attributeEntry.Key as string;
			
			switch(key)
			{
				case "CreditScoreID":
				{
					attributeEntry.Value = GetIDREF();
					break;
				}
				case "CreditRepositorySourceType":
				{
					attributeEntry.Value = string.Format("{0}", ((Enums.CreditRepositorySourceType) Convert.ToInt32(attributeEntry.Value)));
					break;
				}
				case "CreditScoreExclusionReasonType":
				{
					attributeEntry.Value = string.Format("{0}", ((Enums.CreditScoreExclusionReasonType) attributeEntry.Value));
					break;
				}
				case "CreditScoreModelNameType":
				{
					// TODO: research why the following enumeration has to be casted to int32 where others do not have to.
					attributeEntry.Value = string.Format("{0}", ((MISMO.Enums.CreditScoreModelNameType) Convert.ToInt32(attributeEntry.Value)));
					break;
				}	
			}

			return true;
		}

		/// <summary>
		/// Gets the element name of the xml factory object.
		/// </summary>
		protected virtual string ElementName
		{
			get
			{
				return "CREDIT_SCORE";
			}
		}

		#endregion IXmlFactoryElement Interface

		#region Methods

		/// <summary>
		/// Generates the xml for the object instance.
		/// </summary>
		/// <param name="parentElement">The parent element of this object instance.</param>
		/// <returns>A valid xml element.</returns>
		public virtual System.Xml.XmlElement ToXml(System.Xml.XmlElement parentElement)
		{
			return XmlFactory.GenerateElement(parentElement, this);
		}

		/// <summary>
		/// Gets the IDREF used in XML processing for the current object instance.
		/// </summary>
		/// <returns>The id ref for the object instance.</returns>
		protected string GetIDREF()
		{
			if (!this.Persisted)
				return string.Format("Score{0:000000000}", this.GetHashCode());
			else
				return string.Format("Score{0:000000000}", _creditscoreid);
		}

		#endregion Methods
	}
}
