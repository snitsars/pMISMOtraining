using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for CaseStateType.
	/// </summary>
	[Serializable()] 
	public enum CaseStateType : short
	{
		Undefined = 0,
		Application = 1,
		FinalDisposition = 2,
		PostClosingQualityControl = 3,
		Prequalification = 4,
		Underwriting = 5
	}
}
