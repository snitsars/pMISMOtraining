using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for LoanClosingStatusType.
	/// </summary>
	[Serializable()]
	public enum LoanClosingStatusType : short
	{
		Undefined = 0,
		Closed =1,
		TableFunded = 2
	}
}
