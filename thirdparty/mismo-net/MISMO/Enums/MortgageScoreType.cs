using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for MortgageScoreType.
	/// </summary>
	[Serializable()]
	public enum MortgageScoreType : short
	{
		Undefined = 0,
		GE_IQScore = 1,
		Other = 2,
		PMIAuraAQIScore = 3,
		UGIAccuscore = 4
	}
}
