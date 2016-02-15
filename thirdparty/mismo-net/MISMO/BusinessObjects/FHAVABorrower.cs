using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'FHA_VA_BORROWER'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class FHAVABorrower : FHAVABorrowerBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVABorrower() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FHAVABorrower(System.Int64 borrowerId) : base(borrowerId)
		{
		}



		#endregion Constructors

	}
}
