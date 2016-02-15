using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for BuydownBaseDataType.
	/// </summary>
	[Serializable()]
	public enum BuydownBaseDataType : short
	{
		Undefined = 0,
		NoteDate = 1,
		FirstPaymentDate = 2,
		LastPaymentDate = 3
	}
}
