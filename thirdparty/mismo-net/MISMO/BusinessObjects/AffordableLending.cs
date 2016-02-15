using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'AFFORDABLE_LENDING'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class AffordableLending : AffordableLendingBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AffordableLending() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public AffordableLending(System.Int64 loanApplicationId) : base(loanApplicationId)
		{
		}



		#endregion Constructors

	}
}
