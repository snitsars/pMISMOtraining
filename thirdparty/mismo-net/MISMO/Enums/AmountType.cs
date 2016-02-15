using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for AmountType.
	/// </summary>
	[Serializable()]
	public enum AmountType : short
	{
		Undefined = 0,
		TotalMonthlyIncomeNotIncludingNetRentalIncome = 1, 
		SubtotalLiabilitiesPaidByClosingNotIncludingSubjectPropertyLiensBalance = 2, 
		TotalPresentHousingExpense = 3, 
		TotalLiabilitesBalance = 4, 
		SubtotalLiabilitesMonthlyPayment = 5, 
		SubtotalOmittedLiabilitesBalance = 6, 
		SubtotalOmittedLiabilitiesMonthlyPayment = 7, 
		SubtotalLiabilitiesPaidByClosingNotIncludingSubjectPropertyLiensMonthlyPayment = 8,
		SubtotalResubordinatedLiabilitesMonthlyPaymentForSubjectProperty = 9,
		SubtotalSubjectPropertyLiensPaidByClosingBalance = 10,
		SubtotalSubjectPropertyLiensPaidByClosingMonthlyPayment = 11, 
		SubtotalLiabilitiesForRentalPropertyBalance = 12, 
		SubtotalLiabilitiesForRentalPropertyMonthlyPayment = 13, 
		SubtotalResubordinatedLiabilitiesBalanceForSubjectProperty = 14, 
		SubtotalLiquidAssetsNotIncludingGift = 15,
		SubtotalNonLiquidAssets = 16,
		TotalLiabilitiesBalance = 17, 
		SubtotalLiabilitiesMonthlyPayment = 18, 
		SubtotalOmittedLiabilitiesBalance = 19, 
		SubtotalResubordinatedLiabilitiesMonthlyPaymentForSubjectProperty = 20, 
		UndrawnHELOC = 21
	}
}
