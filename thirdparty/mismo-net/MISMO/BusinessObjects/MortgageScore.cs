using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'MORTGAGE_SCORE'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class MortgageScore : MortgageScoreBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageScore() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public MortgageScore(System.Int64 id) : base(id)
		{
		}



		#endregion Constructors

	}
}
