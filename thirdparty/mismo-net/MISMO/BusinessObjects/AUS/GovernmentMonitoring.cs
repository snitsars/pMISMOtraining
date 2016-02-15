using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a government monitoring instance.
	/// </summary>
	[Serializable]
	public class GovernmentMonitoring : MISMO.BusinessObjects.GovernmentMonitoring
	{
		public GovernmentMonitoring()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#region Properties

		/// <summary>
		/// Member that stores a reference to the HMDA race collection.
		/// </summary>
		protected MISMO.BusinessObjects.HMDARaces _hmdaraces = new HMDARaces();
		/// <summary>
		/// Gets the HMDA race collection for the government's instance.
		/// </summary>
		public MISMO.BusinessObjects.HMDARaces HMDARaces
		{
			get { return _hmdaraces; }
		}

		#endregion Properties


		#region Methods

		/// <summary>
		/// Persist the object instance to the database with the specified transaction object.
		/// </summary>
		/// <param name="sqlTrans">The sql Transaction object.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// first make a call to the base
			base.Persist (sqlTrans);

			// persist the HMDA races
			for(int i = 0, j = _hmdaraces.Count; i<j; i++)
			{
				_hmdaraces[i].BorrowerId = _borrowerid;
				_hmdaraces[i].Persist(sqlTrans);
			}

			// refactor the checksum
			RecalculateChecksum();
		}


		#endregion Methods
	}
}
