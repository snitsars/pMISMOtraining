using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for RateLockType.
	/// </summary>
	[Serializable()]
	public enum RateLockType : short
	{
		Undefined = 0,
		BestEfforts =1,
		Mandatory = 2
	}
}
