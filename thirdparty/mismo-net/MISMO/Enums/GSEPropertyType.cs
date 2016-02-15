using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for GSEPropertyType.
	/// </summary>
	[Serializable()]
	public enum GSEPropertyType : short
	{
		Undefined = 0,
		Attached = 1, 
		Condominium = 2,
		Cooperative = 3, 
		Detached = 4, 
		HighRiseCondominium = 5,
		ManufacturedHousing = 6,
		Modular = 7,
		PUD = 8, 
		ManufacturedHousingSingleWide = 9,
		ManufacturedHousingDoubleWide = 10,
		DetachedCondominium = 11,
		ManufacturedHomeCondominium = 12, 
		ManufacturedHousingMultiWide = 13, 
		ManufacturedHomeCondominiumOrPUDOrCooperative = 14
	}
}
