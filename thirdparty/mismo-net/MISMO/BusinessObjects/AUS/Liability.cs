using System;
using OrcaLogic.Xml;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// Summary description for Liability.
	/// </summary>
	[Serializable]
	public class Liability : BusinessObjects.Liability, OrcaLogic.Xml.IXmlFactoryElement	
	{

		#region Member Fields

		/// <summary>
		/// Gets or sets the borrower reference for the liability instance.
		/// </summary>
		internal Borrower _borrower = null;

		#endregion Member Fields

		#region Constructors

		public Liability() : base()
		{
	
		}

		#endregion Constructors

		#region IXmlFactoryElement Members

		public bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			string key = attributeEntry.Key as string;

			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			switch(key)
			{
				case "Id":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "BorrowerID":
				{
					if (this.Persisted)
						attributeEntry.Value = string.Format("Borr{0:000000000}", attributeEntry.Value);
					else
						attributeEntry.Value = string.Format("Borr{0:000000000}", _borrower.GetHashCode());

					// break out
					break;
				}
				case "Reo_Id":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "HolderStreetAddress":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HolderCity":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HolderState":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HolderPostalCode":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "AlimonyOwedToName":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "AccountIdentifier":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "ExclusionIndicator":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HolderName":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "MonthlyPaymentAmount":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "PayoffStatusIndicator":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "PayoffWithCurrentAssetsIndicator":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "RemainingTermMonths":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "Type":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.LiabilityType)attributeEntry.Value));
					break;
				}
				case "UnpaidBalanceAmount":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "SubjectLoanResubordinationIndicator":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
			}
			return true;
		}

		System.Collections.Specialized.NameValueCollection IXmlFactoryElement.AdditionalAttributes
		{
			get
			{
				// TODO:  Add Liability.AdditionalAttributes getter implementation
				return null;
			}
		}

		string IXmlFactoryElement.ElementName
		{
			get
			{
				// TODO:  Add Liability.ElementName getter implementation
				//return null;
				return base.ElementName;
			}
		}

		#endregion
	}
}
