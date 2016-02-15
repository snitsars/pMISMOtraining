using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for BuildingStatusType.
	/// </summary>
	[Serializable()]
	public enum BuildingStatusType : short
	{
		Undefined = 0,
		Existing = 1, 
		Proposed = 2, 
		SubjectToAlterationImprovementRepairAndRehabilitation = 3, 
		SubstantiallyRehabilitated = 4, 
		UnderConstruction = 5
	}
}
