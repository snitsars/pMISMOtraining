using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'VA_LOAN'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class VALoan : VALoanBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VALoan() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public VALoan(System.Int64 governmentLoanAppId) : base(governmentLoanAppId)
		{
		}



		#endregion Constructors

	}
}
