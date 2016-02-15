using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for LoanDocumentationType.
	/// </summary>
	[Serializable()]
	public enum LoanDocumentationType : short
	{
		Undefined = 0,
		Alternative = 1, 
		FullDocumentation = 2, 
		NoDepositVerification = 3, 
		NoDepositVerificationEmploymentVerificationOrIncomeVerification = 4, 
		NoDocumentation = 5,
		NoEmploymentVerificationOrIncomeVerification = 6, 
		Reduced = 7, 
		StreamlineRefinance = 8,
		NoRatio = 9, 
		NoIncomeNoEmploymentNoAssetsOn1003 = 10, 
		NoIncomeOn1003 = 11, 
		NoVerificationOfStatedIncomeEmploymentOrAssets = 12, 
		NoVerificationOfStatedIncomeOrAssests = 13,
		NoVerificationOfStatedAssets = 14,
		NoVerificationOfStatedIncomeOrEmployment = 15,
		NoVerificationOfStatedIncome = 16, 
		VerbalVerificationOfEmployment = 17, 
		OnePaystub = 18, 
		OnePaystubAndVerbalVerificationOfEmployment = 19,
		OnePaystubAndOneW2AndVerbalVerificationOfEmploymentOrOneYear1040 = 20
	}
}
