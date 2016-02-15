using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for ARMIndexType.
	/// </summary>
	[Serializable()]
	public enum ARMIndexType : short
	{
		Undefined = 0,
		EleventhDistrictCostOfFunds = 1, 
		OneYearTreasury = 2, 
		ThreeYearTreasury = 3,
		SixMonthTreasury = 4,
		DailyCertificateOfDepositRate = 5, 
		FNM60DayRequiredNetYield = 6,
		FNM_LIBOR = 7, 
		FederalCostOfFunds = 8,
		FRE60DayRequiredNetYield = 9,
		FRE_LIBOR = 10,
		LIBOR = 11,
		MonthlyAverageConstantMaturingTreasury = 12,
		NationalAverageContractRateFHLBB = 13, 
		NationalMonthlyMedianCostOfFunds =14, 
		Other = 15, 
		TreasuryBillDailyValue = 16,
		WallStreetJournalLIBOR = 17,
		WeeklyAverageCertificateOfDepositRate = 18, 
		WeeklyAverageConstantMaturingTreasury = 19,
		WeeklyAveragePrimeRate = 20, 
		WeeklyAverageSecondaryMarketTreasuryBillInvestmentYield = 21, 
		WeeklyAverageTreasuryAuctionAverageBondDiscountYield = 22, 
		WeeklyAverageTreasuryAuctionAverageInvestmentYield = 23
	}
}
