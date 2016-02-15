using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for REOPropertyGSEPropertyType.
	/// </summary>
	[Serializable()]
	public enum REOPropertyGSEPropertyType : short
	{
		Undefined = 0,
		SingleFamily = 1, 
		Condominium = 2, 
		Townhouse = 3, 
		Cooperative = 4, 
		TwoToFourUnitProperty = 5, 
		MultifamilyMoreThanFourUnits = 6, 
		ManufacturedMobileHome = 7,
		CommercialNonResidential = 8,
		MixedUseResidential = 9, 
		Farm = 10, 
		HomeAndBusinessCombined = 11,
		Land = 12
	}
}
