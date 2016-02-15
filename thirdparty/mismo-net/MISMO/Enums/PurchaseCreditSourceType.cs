using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for PurchaseCreditSourceType.
	/// </summary>
	[Serializable()]
	public enum PurchaseCreditSourceType : short
	{
		Undefined = 0,
		EarnestMoney = 1,
		RelocationFunds = 2,
		EmployerAssistedHousing = 3, 
		LeasePurchaseFund = 4,
		Other = 5
	}
}
