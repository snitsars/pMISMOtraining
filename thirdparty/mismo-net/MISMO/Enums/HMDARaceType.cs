using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for HMDARaceType.
	/// </summary>
	[Serializable()]
	public enum HMDARaceType : short
	{
		Undefined = 0,
		AmericanIndianOrAlaskaNative = 1, 
		Asian = 2,
		BlackOrAfricanAmerican = 3,
		NativeHawaiianOrOtherPacificIslander = 4,
		White = 5,
		InformationNotProvidedByApplicantInMailInternetOrTelephoneApplication = 6, 
		NotApplicable = 7
	}
}
