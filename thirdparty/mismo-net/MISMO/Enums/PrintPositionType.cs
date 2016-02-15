using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration of print position types.
	/// </summary>
	/// <remarks>
	/// Indicates whether the individual filled out the loan application under the “Borrower” or “ Co-Borrower” sections of the paper URLA form. Used only to determine the print position on the paper form.
	/// </remarks>
	[Serializable()]
	public enum PrintPositionType : short
	{
		Undefined = 0,
		Borrower = 1,
		CoBorrower = 2
	}
}
