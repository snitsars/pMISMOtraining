using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for RateAdjustmentCalculationType.
	/// </summary>
	[Serializable()]
	public enum RateAdjustmentCalculationType : short
	{
		Undefined = 0,
		AddPercentToCurrentRate = 1, 
		AddPercentToOriginalRate = 2, 
		IndexPlusMargin = 3
	}
}
