using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for BorrowerResidencyBasisType.
	/// </summary>
	[Serializable()]
	public enum BorrowerResidencyBasisType : short
	{
		Undefined = 0,
		LivingRentFree = 1,
		Own = 2,
		Rent = 3
	}
}
