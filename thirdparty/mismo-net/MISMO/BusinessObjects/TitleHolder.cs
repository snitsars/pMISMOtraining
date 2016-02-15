using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'TITLE_HOLDER'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class TitleHolder : TitleHolderBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TitleHolder() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public TitleHolder(System.Int64 loanApplicationId) : base(loanApplicationId)
		{
		}



		#endregion Constructors

	}
}
