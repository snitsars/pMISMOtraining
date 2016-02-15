using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for FNMCommunityLendingProductType.
	/// </summary>
	[Serializable()]
	public enum FNMCommunityLendingProductType : short
	{
		Undefined = 0,
		CommunityHomeBuyerProgram = 1, 
		Fannie97 = 2,
		Fannie32 = 3,
		MyCommunityMortgage = 4,
		Other = 5
	}
}
