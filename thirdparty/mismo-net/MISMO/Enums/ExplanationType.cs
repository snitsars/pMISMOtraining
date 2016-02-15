using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for ExplanationType.
	/// </summary>
	[Serializable()]
	public enum ExplanationType : short
	{
		Undefined = 0,
		AlimonyChildSupport = 1, 
		BorrowedDownPayment = 2,
		CoMakerEndorserOnNote = 3, 
		DeclaredBankruptcyPastSevenYears = 4, 
		DelinquencyOrDefault = 5, 
		DirectIndirectForeclosedPropertyPastSevenYears = 6, 
		ObligatedOnLoanForeclosedOrDeedInLieuOfJudgement = 7, 
		OutstandingJudgments = 8, 
		PartyToLawsuit = 9
	}
}
