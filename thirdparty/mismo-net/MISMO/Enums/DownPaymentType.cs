using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for DownPaymentType.
	/// </summary>
	[Serializable()]
	public enum DownPaymentType : short
	{
		Undefined = 0,
		BridgeLoan = 1,
		CashOnHand = 2, 
		CheckingSavings = 3,
		DepositOnSalesContract = 4,
		EquityOnPendingSale = 5, 
		EquityOnSoldProperty = 6,
		EquityOnSubjectProperty = 7,
		GiftFunds = 8,
		LifeInsuranceCashValue = 9,
		LotEquity = 10,
		OtherTypeOfDownPayment = 11,
		RentWithOptionToPurchase = 12,
		RetirementFunds = 13,
		SaleOfChattel = 14,
		SecuredBorrowedFunds = 15,
		StocksAndBonds = 16,
		SweatEquity = 17,
		TradeEquity = 18,
		TrustFunds = 19,
		UnsecuredBorrowedFunds = 20
	}
}
