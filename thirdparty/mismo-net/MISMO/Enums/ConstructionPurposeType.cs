using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for ConstructionPurposeType.
	/// </summary>
	[Serializable()]
	public enum ConstructionPurposeType : short
	{
		Undefined = 0,
		ConstructionOnly = 1, 
		ConstructionToPermanent = 2
	}
}
