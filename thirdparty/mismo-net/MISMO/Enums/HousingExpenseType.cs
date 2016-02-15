using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for HousingExpenseType.
	/// </summary>
	[Serializable()]
	public enum HousingExpenseType : short
	{
		Undefined = 0,
		FirstMortgagePrincipalAndInterest = 1, 
		GroundRent = 2, 
		HazardInsurance = 3, 
		HomeownersAssociationDuesAndCondominiumFees = 4, 
		MI = 5, 
		OtherHousingExpense = 6, 
		OtherMortgageLoanPrincipalAndInterest = 7,
		RealEstateTax = 8
	}
}
