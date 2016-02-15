using System;

namespace MISMO.Enums
{
	/// <summary>
	/// Summary description for HMDAPreapprovalType.
	/// </summary>
	[Serializable()]
	public enum HMDAPreapprovalType : short
	{
		Undefined = 0,
		PreapprovalWasRequested = 1,
		PreapprovalWasNotRequested = 2, 
		NotApplicable = 3
	}
}
