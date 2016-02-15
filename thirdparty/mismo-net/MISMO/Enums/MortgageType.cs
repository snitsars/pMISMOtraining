using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for MortgageType.
	/// </summary>
	[Serializable()]
	public enum MortgageType : short
	{
		Undefined = 0,
		Conventional = 1, 
		FarmersHomeAdministration = 2,
		FHA = 3, 
		Other = 4, 
		VA = 5,
		HELOC = 6
	}
}
