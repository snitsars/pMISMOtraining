using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for CitizenshipResidencyType.
	/// </summary>
	[Serializable()]
	public enum CitizenshipResidencyType : short
	{
		Undefined = 0,
		USCitizen = 1, 
		PermanentResidentAlien = 2, 
		NonPermanentResidentAlien = 3,
		NonResidentAlien = 4, 
		Unknown = 5
	}
}
