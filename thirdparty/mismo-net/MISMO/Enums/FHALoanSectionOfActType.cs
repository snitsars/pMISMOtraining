using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for FHALoanSectionOfActType.
	/// </summary>
	[Serializable()]
	public enum FHALoanSectionOfActType : short
	{
		Undefined = 0,
		FHA_ACT_TYPE_203B = 1, 
		FHA_ACT_TYPE_203B251 = 2,
		FHA_ACT_TYPE_203B2 = 3,
		FHA_ACT_TYPE_203K = 4,
		FHA_ACT_TYPE_203K251 = 5,
		FHA_ACT_TYPE_221D2 = 6,
		FHA_ACT_TYPE_221D2251 = 7,	
		FHA_ACT_TYPE_234C = 8,
		FHA_ACT_TYPE_234C251 = 9
	}
}
