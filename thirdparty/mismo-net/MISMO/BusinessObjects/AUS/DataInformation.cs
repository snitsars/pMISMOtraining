using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a data information object.
	/// </summary>
	[Serializable]
	public class DataInformation : MISMO.BusinessObjects.DataInformation
	{
		#region Constructors

		public DataInformation()
		{

		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the collectino of data version for the data information instance.
		/// </summary>
		protected MISMO.BusinessObjects.DataVersions _dataversions = new MISMO.BusinessObjects.DataVersions();
		/// <summary>
		/// Gets the data versions for the data information instance.
		/// </summary>
		public MISMO.BusinessObjects.DataVersions DataVersions
		{
			get { return _dataversions; }
		}

		#endregion Properties

		#region Methods

		internal override void SetMembers(ref MISMO.Entities.DataInformationBase data)
		{
			// call up to the base first
			base.SetMembers (ref data);

			// load up the data versions
			_dataversions = this.GetDataVersions();
			if (_dataversions == null) _dataversions = new DataVersions();

			// recalculate the checksum
			RecalculateChecksum();
		}


		/// <summary>
		/// Persist the object and its sub object to the database via a specified transaction.
		/// </summary>
		/// <param name="sqlTrans">A transaction object that manages the transaction.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// call up to the base to do its persist first
			base.Persist(sqlTrans);

			for(int i = 0, j = _dataversions.Count; i<j; i++)
			{
				_dataversions[i].LoanApplicationId = this.LoanApplicationId;
				_dataversions[i].Persist(sqlTrans);
			}

			// refactor the checksum
			RecalculateChecksum();
		}


		#endregion Methods
	}
}
