using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for MortgageHolderType.
	/// </summary>
	[Serializable()]
	public enum MortgageHolderType : short
	{
		Undefined = 0,
		FNM = 1,
		FRE = 2,
		Other = 3,
		Unknown = 4
	}
}
