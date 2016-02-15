using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'FHA_VA_LOAN'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class FHAVALoan : FHAVALoanBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVALoan() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FHAVALoan(System.Int64 governmentLoanAppId) : base(governmentLoanAppId)
		{
		}



		#endregion Constructors

	}
}
