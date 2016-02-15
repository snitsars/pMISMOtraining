using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'FullPrepaymentPenaltyOptionType'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class FullPrepaymentPenaltyOptionType : FullPrepaymentPenaltyOptionTypeBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FullPrepaymentPenaltyOptionType() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FullPrepaymentPenaltyOptionType(System.Int16 id) : base(id)
		{
		}



		#endregion Constructors

	}
}
