using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for FHAVALoanGovernmentRefinanceType.
	/// </summary>
	[Serializable()]
	public enum FHAVALoanGovernmentRefinanceType : short
	{
		Undefined = 0,
		FullDocumentation = 1,
		InterestRateReductionRefinanceLoan = 2, 
		StreamlineWithAppraisal = 3,
		StreamlineWithoutAppraisal = 4
	}
}
