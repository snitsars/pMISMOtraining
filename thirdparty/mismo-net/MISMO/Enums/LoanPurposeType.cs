using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for LoanPurposeType.
	/// </summary>
	[Serializable()]
	public enum LoanPurposeType : short
	{
		Undefined = 0,
		ConstructionOnly = 1, 
		ConstructionToPermanent = 2, 
		Other = 3,
		Purchase = 4,
		Refinance = 5
	}
}
