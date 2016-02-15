using System;
using OrcaLogic.Xml;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents an asset.
	/// </summary>
	[Serializable]
	public class Asset : MISMO.BusinessObjects.Asset, OrcaLogic.Xml.IXmlFactoryElement
	{
		#region Member Fields

		/// <summary>
		/// Gets or sets the borrower reference for the asset instance.
		/// </summary>
		internal Borrower _borrower = null;

		#endregion Member Fields

		#region Constructors

		public Asset() : base()
		{

		}

		#endregion Constructors

		#region IXmlFactoryElement Members

		bool IXmlFactoryElement.ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			string key = attributeEntry.Key as string;

			if (key != "BorrowerId" && !MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			switch(key)
			{
				case "BorrowerId":
				{
					if (this.Persisted)
						attributeEntry.Value = string.Format("Borr{0:000000000}", attributeEntry.Value);
					else
						attributeEntry.Value = string.Format("Borr{0:000000000}", _borrower.GetHashCode());

					// break out
					break;
				}
				case "AccountIdentifier":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "Type":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					attributeEntry.Value = string.Format("{0}", ((Enums.AssetType) attributeEntry.Value));
					break;
				}
				case "CashOrMarketValueAmount":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "VerifiedIndicator":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
					break;
				}
				case "HolderName":
				{
					attributeEntry.Key = string.Format("_{0}", attributeEntry.Key);
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
				case "AutomobileMakeDescription":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "AutomobileModelYear":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "LifeInsuranceFaceValueAmount":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "OtherAssetTypeDescription":
				{
					attributeEntry.Key = string.Format("{0}", attributeEntry.Key);
					break;
				}
				case "StockBondMutualFundShareCount":
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
//				System.Collections.Specialized.NameValueCollection added = new System.Collections.Specialized.NameValueCollection();
//				//added.Add("Automobile", string.Format("{0}", this.));

				return null;
			}
		}

		string IXmlFactoryElement.ElementName
		{
			get
			{
				return base.ElementName;
			}
		}

		#endregion
	}
}
