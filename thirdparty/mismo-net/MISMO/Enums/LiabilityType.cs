using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for LiabilityType.
	/// </summary>
	[Serializable()]
	public enum LiabilityType : short
	{
		Undefined = 0,
		Alimony = 1,
		ChildCare = 2, 
		ChildSupport = 3, 
		CollectionsJudgementsAndLiens = 4,
		HELOC = 5,
		Installment = 6,
		JobRelatedExpenses = 7,
		LeasePayments = 8,
		MortgageLoan = 9,	
		Open30DayChargeAccount = 10,
		OtherLiability = 11, 
		Revolving = 12,
		SeparateMaintenanceExpense = 13,
		OtherExpense = 14,
		Taxes = 15
	}
}
