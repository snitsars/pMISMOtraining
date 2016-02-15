using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for MICertificationStatusType.
	/// </summary>
	[Serializable()]
	public enum MICertificationStatusType : short
	{
		Undefined = 0,
		LenderToObtain = 1,
		SellerOfLoanToObtain = 2
	}
}
