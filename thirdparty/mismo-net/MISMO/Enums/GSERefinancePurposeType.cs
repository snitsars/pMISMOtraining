using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for GSERefinancePurposeType.
	/// </summary>
	[Serializable()]
	public enum GSERefinancePurposeType : short
	{
		Undefined = 0,
		CashOutDebtConsolidation = 1, 
		CashOutHomeImprovement = 2, 
		CashOutLimited = 3,	
		CashOutOther = 4,
		NoCashOutFHAStreamlinedRefinance = 5, 
		NoCashOutFREOwnedRefinance = 6,
		NoCashOutOther = 7,
		NoCashOutStreamlinedRefinance = 8,
		ChangeInRateTerm = 9
	}
}
