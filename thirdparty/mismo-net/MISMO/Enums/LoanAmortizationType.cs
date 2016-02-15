using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for LoanAmortizationType.
	/// </summary>
	[Serializable()]
	public enum LoanAmortizationType : short
	{
		Undefined = 0,
		AdjustableRate = 1,
		Fixed = 2, 
		GraduatedPaymentMortgage = 3, 
		GrowingEquityMortgage = 4, 
		OtherAmortizationType = 5
	}
}
