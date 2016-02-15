using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for ApplicationTakenMethodType.
	/// </summary>
	[Serializable()]
	public enum ApplicationTakenMethodType : short
	{
		Undefined = 0,
		FaceToFace = 1, 
		Mail = 2,
		Telephone = 3, 
		Internet = 4
	}
}
