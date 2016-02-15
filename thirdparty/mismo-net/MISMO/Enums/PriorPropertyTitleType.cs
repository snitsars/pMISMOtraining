using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for PriorPropertyTitleType.
	/// </summary>
	[Serializable()]
	public enum PriorPropertyTitleType : short
	{
		Undefined = 0,
		Sole = 1, 
		JointWithSpouse = 2, 
		JointWithOtherThanSpouse = 3
	}
}
