using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'FHAAlimonyLiabilityTreatmentType'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class FHAAlimonyLiabilityTreatmentType : FHAAlimonyLiabilityTreatmentTypeBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAAlimonyLiabilityTreatmentType() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FHAAlimonyLiabilityTreatmentType(System.Int16 id) : base(id)
		{
		}



		#endregion Constructors

	}
}
