using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a loan purpose.
	/// </summary>
	[Serializable]
	public class LoanPurpose : MISMO.BusinessObjects.LoanPurpose
	{
		#region Constructors

		public LoanPurpose() : base()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the construction refinance data.
		/// </summary>
		internal MISMO.BusinessObjects.ConstructionRefinanceData _consrefidata = null;
		/// <summary>
		/// Gets the construction refinance data associated with the loan purpose.
		/// </summary>
		public MISMO.BusinessObjects.ConstructionRefinanceData ConstructionRefinanceData
		{
			get 
			{ 
				return _consrefidata; 
			}
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Persists an object instance with the following sql transaction.
		/// </summary>
		/// <param name="sqlTrans">The transaction to use in the persist.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// let the base do its work first.
			base.Persist(sqlTrans);

			// persist the construction refi data.
			if (_consrefidata != null)
			{
				_consrefidata.LoanApplicationId = _loanapplicationid;
				_consrefidata.Persist(sqlTrans);
			}

			// refactor the checksum
			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the internal members with data from a compatible instance.
		/// </summary>
		/// <param name="data">The compatible object type.</param>
		internal override void SetMembers(ref MISMO.Entities.LoanPurposeBase data)
		{
			// first call up to base
			base.SetMembers (ref data);

			MISMO.BusinessObjects.ConstructionRefinanceDataCollection conscol = this.GetConstructionRefinanceDataCollection();
			if (conscol != null && conscol.Count > 0)
			{
				_consrefidata = conscol[0];
			}

			// now recalculate the checksum
			RecalculateChecksum();
		}


		#endregion Methods
	}
}
