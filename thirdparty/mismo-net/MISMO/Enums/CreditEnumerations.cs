using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for credit repository sources.
	/// </summary>
	public enum CreditRepositorySourceType
	{
		Undefined = 0,
		Equifax = 1,
		Experian = 2, 
		MergedData = 3, 
		Other = 4,
		TransUnion = 5
	}

	/// <summary>
	/// An enumeration for credit score exclusion reasons.
	/// </summary>
	public enum CreditScoreExclusionReasonType
	{
		Undefined = 0,
		InvalidScoreRequest = 1,
		NotScoredCreditDataNotAvailable = 2,
		NotScoredFileIsUnderReview = 3,
		NotScoredFileTooLong = 4,
		NotScoredInsufficientCredit = 5,
		NotScoredNoQualifyingAccount = 6,
		NotScoredNoRecentAccountInformation = 7,
		NotScoredSubjectDeceased = 8,
		ScoringNotAvailable = 9,
		UnauthorizedScoreRequest
	}

	/// <summary>
	/// An enumeration of credit score model name types.
	/// </summary>
	public enum CreditScoreModelNameType
	{
		Undefined = 0,
		EquifaxBeacon = 1,
		EquifaxBeaconAuto = 2,
		EquifaxBeaconBankcard = 3,
		EquifaxBeaconInstallment = 4,
		EquifaxBeaconPersonalFinance = 5,
		EquifaxDAS = 6,
		EquifaxEnhancedBeacon = 7,
		EquifaxEnhancedDAS = 8,
		EquifaxMarketMax = 9,
		EquifaxMortgageScore = 10,
		EquifaxPinnacle = 11,
		ExperianFairIsaac = 12,
		ExperianFairIsaacAuto = 13,
		ExperianFairIsaacBankcard = 14,
		ExperianFairIsaacInstallment = 15,
		ExperianFairIsaacPersonalFinance = 16,
		ExperianMDSBankruptcyII = 17,
		ExperianNewNationalEquivalency = 18,
		ExperianNewNationalRisk = 19,
		ExperianOldNationalRisk = 20,
		Other = 21,
		TransUnionDelphi = 22,
		TransUnionEmpirica = 23,
		TransUnionEmpiricaAuto = 24,
		TransUnionEmpiricaBankcard = 25,
		TransUnionEmpiricaInstallment = 26,
		TransUnionEmpiricaPersonalFinance = 27,
		TransUnionNewDelphi = 28
	}
}
