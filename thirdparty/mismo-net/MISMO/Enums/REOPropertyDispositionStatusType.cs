using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for REOPropertyDispositionStatusType.
	/// </summary>
	[Serializable()]
	public enum REOPropertyDispositionStatusType : short
	{
		Undefined = 0,
		PendingSale = 1, 
		RetainForRental = 2,
		RetainForPrimaryOrSecondaryResidence = 3, 
		Sold = 4
	}
	
}
