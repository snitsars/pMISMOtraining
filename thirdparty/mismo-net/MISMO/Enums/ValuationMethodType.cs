using System;

namespace MISMO.Enums
{
	/// <summary>
	/// An enumeration for ValuationMethodType.
	/// </summary>
	[Serializable()]
	public enum ValuationMethodType : short
	{
		Undefined = 0,
		FNM1004 = 1, 
		EmployeeRelocationCouncil2001 = 2,
		FNM1073 = 3,
		FNM1025 = 4,
		FNM2055Exterior = 5, 
		FNM2065 = 6, 
		FRE2070Interior = 7, 
		FRE2070Exterior = 8, 
		FNM2075 = 9,
		BrokerPriceOpinion = 10,
		AutomatedValuationModel = 11, 
		TaxValuation = 12, 
		DriveBy = 13,
		FullAppraisal = 14, 
		None = 15, 
		FNM2055InteriorAndExterior = 16, 
		FNM2095Exterior = 17, 
		FNM2095InteriorAndExterior = 18,
		PriorAppraisalUsed = 19, 
		Form261805 = 20, 
		Form268712 = 21, 
		Other = 22
	}
}
