using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for ContactPointType.
	/// </summary>
	[Serializable()]
	public enum ContactPointType : short
	{
		Undefined = 0,
		Email = 1,
		Fax = 2,
		Other = 3,
		Phone = 4
	}
}
