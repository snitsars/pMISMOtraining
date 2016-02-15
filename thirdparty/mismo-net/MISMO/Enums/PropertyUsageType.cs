using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for PropertyUsageType.
	/// </summary>
	[Serializable()]
	public enum PropertyUsageType : short
	{
		Undefined = 0,
		Investor = 1,
		PrimaryResidence = 2,
		SecondHome = 3
	}
}
