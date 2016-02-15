using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'HMDAPurposeOfLoanType'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class HMDAPurposeOfLoanType : HMDAPurposeOfLoanTypeBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HMDAPurposeOfLoanType() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public HMDAPurposeOfLoanType(System.Int16 id) : base(id)
		{
		}



		#endregion Constructors

	}
}
