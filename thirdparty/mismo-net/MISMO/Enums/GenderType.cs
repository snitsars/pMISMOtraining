using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for GenderType.
	/// </summary>
	[Serializable()]
	public enum GenderType : short
	{
		Undefined = 0,
		Female = 1,
		InformationNotProvidedUnknown = 2, 
		Male = 3,
		NotApplicable = 4
	}
}
