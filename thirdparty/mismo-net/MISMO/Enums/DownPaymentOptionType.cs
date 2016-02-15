using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for DownPaymentOptionType.
	/// </summary>
	[Serializable()]
	public enum DownPaymentOptionType : short
	{
		Undefined = 0,
		ThreeTwoOption = 1,
		FivePercentOption = 2, 
		FNM97Option = 3
	}
}
