using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for MaritalStatusType.
	/// </summary>
	[Serializable()]
	public enum MaritalStatusType : short
	{
		NotProvided = 0, 
		Married = 1, 
		Separated = 2, 
		Unknown = 3,
		Unmarried = 4
	}
}
