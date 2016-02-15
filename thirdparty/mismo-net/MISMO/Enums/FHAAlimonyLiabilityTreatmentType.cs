using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for FHAAlimonyLiabilityTreatmentType.
	/// </summary>
	[Serializable()]
	public enum FHAAlimonyLiabilityTreatmentType : short
	{
		Undefined = 0,
		AdditionToDebt = 1,
		ReductionToIncome = 2
	}
}
