using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;

namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'ARM'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class ARM : ARMBase, IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ARM() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ARM(System.Int64 productDataId) : base(productDataId)
		{
		}



		#endregion Constructors

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
		/// Method executed by the xml factory.
		/// </summary>
		/// <param name="attributeEntry">The key-value pair of the element's attribute.</param>
		/// <returns>True if the factory should continue processing and false otherwise</returns>
		protected virtual bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			string key = attributeEntry.Key as string;

			if (key != "PaymentAdjustmentLifetimeCapAmount" ||
				key != "PaymentAdjustmentLifetimeCapPercent" ||
				key != "RateAdjustmentLifetimeCapPercent")
				attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);

			// convert the percent numeric (8,7) back to whole percents
			switch(key)
			{
				case "IndexCurrentValuePercent":
				case "IndexMarginPercent":
				case "QualifyingRatePercent":
				case "PaymentAdjustmentLifetimeCapPercent":
				case "RateAdjustmentLifetimeCapPercent":
				{
					attributeEntry.Value = ((Decimal)attributeEntry.Value) * 100;
					break;
				}
			}

			return true;
		}

		/// <summary>
		/// Gets any additional attributes to be processed by the xml factory.
		/// </summary>
		protected virtual System.Collections.Specialized.NameValueCollection AdditionalAttributes
		{
			get { return null; }
		}

		/// <summary>
		/// Gets the element name of the xml factory object.
		/// </summary>
		protected virtual string ElementName
		{
			get
			{
				return "ARM";
			}
		}

		#endregion IXmlFactoryElement Interface
	}
}
