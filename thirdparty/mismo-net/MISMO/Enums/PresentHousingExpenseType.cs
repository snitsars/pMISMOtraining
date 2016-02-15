using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for PresentHousingExpenseType.
	/// </summary>
	[Serializable()]
	public enum PresentHousingExpenseType : short
	{
		Undefined = 0,
		FirstMortgagePrincipalAndInterest = 1, 
		HazardInsurance = 2, 
		HomeownersAssociationDuesAndCondominiumFees = 3, 
		MI = 4, 
		OtherHousingExpense = 5, 
		OtherMortgageLoanPrincipalAndInterest = 6, 
		RealEstateTax = 7,
		Rent = 8
	}
}
