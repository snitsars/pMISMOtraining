using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for GSEProjectClassificationType.
	/// </summary>
	[Serializable()]
	public enum GSEProjectClassificationType : short
	{
		Undefined = 0,
		A_IIICondominium = 1, 
		ApprovedFHA_VACondominiumProjectOrSpotLoan = 2,
		B_IICondominium = 3, 
		C_ICondominium = 4, 
		OneCooperative = 5, 
		TwoCooperative = 6, 
		E_PUD = 7,
		F_PUD = 8, 
		III_PUD = 9
	}
}
