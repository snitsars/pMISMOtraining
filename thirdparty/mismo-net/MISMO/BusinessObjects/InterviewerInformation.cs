using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'INTERVIEWER_INFORMATION'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class InterviewerInformation : InterviewerInformationBase, OrcaLogic.Xml.IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public InterviewerInformation() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public InterviewerInformation(System.Int64 loanApplicationId) : base(loanApplicationId)
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
				return "INTERVIEWER_INFORMATION";
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
				case "ApplicationTakenMethodType":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.ApplicationTakenMethodType) attributeEntry.Value));
					break;
				}
			}

			return true;
		}

		#endregion Overrides for IXmlFactoryElement
	}
}
