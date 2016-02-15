using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'CONTACT_POINT'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class ContactPoint : ContactPointBase, OrcaLogic.Xml.IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ContactPoint() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ContactPoint(System.Int64 id) : base(id)
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
				return "CONTACT_POINT";
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
				case "RoleType":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.ContactPointRoleType) attributeEntry.Value));
					break;
				}
				case "Type":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.ContactPointType) attributeEntry.Value));
					break;
				}
				case "TypeOtherDescription":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "Value":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "PreferenceIndicator":
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
