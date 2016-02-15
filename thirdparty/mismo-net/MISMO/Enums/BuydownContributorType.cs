using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for BuydownContributorType.
	/// </summary>
	[Serializable()]
	public enum BuydownContributorType : short
	{
		Undefined = 0,
		Borrower = 1, 
		Other = 2, 
		LenderPremiumFinanced = 3,
		Seller = 4, 
		Builder = 5
	}
}
