using System;
using OrcaLogic.Xml;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// Summary description for AdditionalCaseData.
	/// </summary>
	[Serializable]
	public class AdditionalCaseData : MISMO.BusinessObjects.AdditionalCaseData
	{
		public AdditionalCaseData() : base()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#region Methods

		/// <summary>
		/// Set the members of the class with information from a compatible instance.
		/// </summary>
		/// <param name="data">The object to set members with.</param>
		internal override void SetMembers(ref MISMO.Entities.AdditionalCaseDataBase data)
		{
			// make a call to the base first.
			base.SetMembers (ref data);

			// load up the transmittal data
			MISMO.BusinessObjects.TransmittalDataCollection transcol = this.GetTransmittalDataCollection();
			if (transcol != null && transcol.Count > 0)
				_transmitdata = transcol[0];

			// load up the mortgage scores
			_mortgagescores = this.GetMortgageScores();

			// refactor the checksum
			RecalculateChecksum();
		}

		/// <summary>
		/// Persist the object and its sub object to the database via a specified transaction.
		/// </summary>
		/// <param name="sqlTrans">A transaction object that manages the transaction.</param>			
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// first call up to base
			base.Persist (sqlTrans);

			if (_transmitdata != null)
			{
				_transmitdata.LoanApplicationId = _loanapplicationid;
				_transmitdata.Persist(sqlTrans);
			}

			for(int i = 0, j = _mortgagescores.Count; i<j; i++)
			{
				_mortgagescores[i].LoanApplicationId = _loanapplicationid;
				_mortgagescores[i].Persist(sqlTrans);
			}

			// refactor checksum
			RecalculateChecksum();
		}

		#endregion Methods

		#region Properties

		/// <summary>
		/// Member that stores the transmittal data for the additional case data instance.
		/// </summary>
		internal MISMO.BusinessObjects.TransmittalData _transmitdata = null;
		/// <summary>
		/// Gets the transmittal data for the additional case data instance.
		/// </summary>
		public MISMO.BusinessObjects.TransmittalData TransmittalData
		{
			get { return _transmitdata; } 
		}

		/// <summary>
		/// Member that stores the mortgage scores for the additional case instance.
		/// </summary>
		protected MISMO.BusinessObjects.MortgageScores _mortgagescores = new MortgageScores();
		/// <summary>
		/// Gets the mortgage scores collection for the current additional case instance.
		/// </summary>
		public MISMO.BusinessObjects.MortgageScores MortgageScores
		{
			get { return _mortgagescores; }
		}

		#endregion Properties

	}
}
