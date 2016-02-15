using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for LoanRepaymentType.
	/// </summary>
	[Serializable()]
	public enum LoanRepaymentType : short
	{
		Undefined = 0,
		InterestOnly = 1, 
		NoNegativeAmortization = 2, 
		PotentialNegativeAmortization = 3, 
		ScheduledAmortization = 4, 
		ScheduledNegativeAmortization = 5
	}
}
