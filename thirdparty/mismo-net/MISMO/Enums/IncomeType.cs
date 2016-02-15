using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for IncomeType.
	/// </summary>
	[Serializable()]
	public enum IncomeType : short
	{
		Undefined = 0,
		AlimonyChildSupport = 1, 
		AutomobileExpenseAccount = 2,
		Base = 3,
		Bonus = 4, 
		Commissions = 5, 
		DividendsInterest = 6, 
		FosterCare = 7,
		NetRentalIncome = 8, 
		NotesReceivableInstallment = 9, 
		OtherTypesOfIncome = 10,
		Overtime = 11,
		Pension = 12, 
		SocialSecurity = 13, 
		SubjectPropertyNetCashFlow = 14, 
		Trust = 15, 
		Unemployment = 16, 
		PublicAssistance = 17, 
		VABenefitsNonEducational = 18,
		MortgageDifferential = 19, 
		MilitaryBasePay =20, 
		MilitaryRationsAllowance = 21,
		MilitaryFlightPay = 22,
		MilitaryHazardPay = 23,
		MilitaryClothesAllowance = 24,
		MilitaryQuartersAllowance = 25,
		MilitaryPropPay = 26,
		MilitaryOverseasPay = 27, 
		MilitaryCombatPay = 28, 
		MilitaryVariableHousingAllowance = 29
	}
}
