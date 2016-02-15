using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for HMDAEthnicityType.
	/// </summary>
	[Serializable()]
	public enum HMDAEthnicityType : short
	{
		Undefined = 0,
		HispanicOrLatino = 1, 
		NotHispanicOrLatino = 2, 
		InformationNotProvidedByApplicantInMailInternetOrTelephoneApplication = 3,
		NotApplicable = 4
	}
}
