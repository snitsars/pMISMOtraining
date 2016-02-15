using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'DATA_INFORMATION'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class DataInformation : DataInformationBase, OrcaLogic.Xml.IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DataInformation() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public DataInformation(System.Int64 loanApplicationId) : base(loanApplicationId)
		{
		}



		#endregion Constructors

		#region IXmlFactoryElement Members

		bool OrcaLogic.Xml.IXmlFactoryElement.ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;
			return true;
		}

		System.Collections.Specialized.NameValueCollection OrcaLogic.Xml.IXmlFactoryElement.AdditionalAttributes
		{
			get
			{
				// nothing else to add...return null
				return null;
			}
		}

		string OrcaLogic.Xml.IXmlFactoryElement.ElementName
		{
			get
			{
				return "_DATA_INFORMATION";
			}
		}

		#endregion
	}
}
