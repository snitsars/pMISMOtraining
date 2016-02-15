using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'BORROWER'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class Borrower : BorrowerBase, IXmlFactoryElement
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Borrower() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public Borrower(System.Int64 id) : base(id)
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
		/// Method executed by the xml factory.
		/// </summary>
		/// <param name="attributeEntry">The key-value pair of the element's attribute.</param>
		/// <returns>True if the factory should continue processing and false otherwise</returns>
		protected virtual bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			string key = attributeEntry.Key as string;

			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			switch(key)
			{
				case "Id":
				{
					attributeEntry.Key = "BorrowerId";

					if (!this.Persisted)
						attributeEntry.Value = string.Format("Borr{0:000000000}", this.GetHashCode());
					else
						attributeEntry.Value = string.Format("Borr{0:000000000}", attributeEntry.Value);
					break;
				}
				case "JointAssetBorrowerID":
				{
					attributeEntry.Value = string.Format("Borr{0:000000000}", attributeEntry.Value);
					break;
				}
				case "FirstName":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "MiddleName":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "LastName":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "NameSuffix":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "AgeAtApplicationYears":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "BirthDate":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "ApplicationSignedDate":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HomeTelephoneNumber":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "PrintPositionType":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.PrintPositionType) attributeEntry.Value));
					break;
				}
				case "SSN":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "DependentCount":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "JointAssetLiabilityReportingType":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.JointAssetLiabilityReportingType) attributeEntry.Value));
					break;
				}
				case "MaritalStatusType":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.MaritalStatusType) attributeEntry.Value));
					break;
				}
				case "SchoolingYears":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "CreditReportIdentifier":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
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
			get 
			{
				System.Collections.Specialized.NameValueCollection addattrib = new System.Collections.Specialized.NameValueCollection();

				addattrib.Add("BorrowerID", GetIDREF());

				return addattrib;
			}
		}

		/// <summary>
		/// Gets the element name of the xml factory object.
		/// </summary>
		protected virtual string ElementName
		{
			get
			{
				return "BORROWER";
			}
		}

		#endregion IXmlFactoryElement Interface

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


		/// <summary>
		/// Gets the IDREF of the borrower object for use in XML.
		/// </summary>
		/// <returns>The IDREF of the object instance.</returns>
		public string GetIDREF()
		{
			if (!this.Persisted)
				return string.Format("Borr{0:000000000}", this.GetHashCode());
			else
				return string.Format("Borr{0:000000000}", _id);
		}

		#endregion Methods
	}
}
