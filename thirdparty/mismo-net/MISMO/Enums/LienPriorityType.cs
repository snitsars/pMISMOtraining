using System;

namespace MISMO.Enums
{
	/// <summary>
	/// Summary description for LienPriorityType.
	/// </summary>
	[Serializable()]
	public enum LienPriorityType : short
	{
		Undefined = 0,
		FirstLien = 1,
		Other = 2,
		SecondLien = 3
	}
}
