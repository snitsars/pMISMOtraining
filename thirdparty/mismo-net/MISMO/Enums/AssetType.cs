using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for asset types.
	/// </summary>
	[Serializable()]
	public enum AssetType : short
	{
		Undefined = 0,
		Automobile = 1,
		Bond = 2,
		BridgeLoanNotDeposited = 3,
		CashOnHand = 4,
		CertificateOfDepositTimeDeposit = 5,
		CheckingAccount = 6,
		EarnestMoneyCashDepositTowardPurchase = 7,
		GiftsTotal = 8, 
		GiftsNotDeposited = 9, 
		LifeInsurance = 10,
		MoneyMarketFund = 11, 
		MutualFund = 12, 
		NetWorthOfBusinessOwned = 13, 
		OtherLiquidAssets = 14,
		OtherNonLiquidAssets = 15,
		PendingNetSaleProceedsFromRealEstateAssets = 16, 
		RelocationMoney = 17,
		RetirementFund = 18,
		SaleOtherAssets = 19,
		SavingsAccount = 20,
		SecuredBorrowedFundsNotDeposited = 21,
		Stock = 22,
		TrustAccount = 23
	}
}
