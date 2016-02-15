using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a MISMO AUS transaction detail.
	/// </summary>
	[Serializable]
	public class TransactionDetail : MISMO.BusinessObjects.TransactionDetail
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransactionDetail() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public TransactionDetail(System.Int64 loanApplicationId) : base(loanApplicationId)
		{
			if (this.Persisted)
			{
				_purchasecreditcol = this.GetPurchaseCreditCollection();
			}

			if (this.GetType() == typeof(MISMO.BusinessObjects.AUS.TransactionDetail))
			{
				this.RecalculateChecksum();
			}
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the collection of purchase credits.
		/// </summary>
		protected MISMO.BusinessObjects.PurchaseCreditCollection _purchasecreditcol = new PurchaseCreditCollection();
		/// <summary>
		/// Gets the collection of purchase credits.
		/// </summary>
		public MISMO.BusinessObjects.PurchaseCreditCollection PurchaseCreditCollection
		{
			get { return _purchasecreditcol; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Gets the xml object representation of this object instance.
		/// </summary>
		/// <param name="parentElement">The parent element to nest the element structure under.</param>
		/// <returns>A reference to the element created.</returns>
		internal override System.Xml.XmlElement ToXml(System.Xml.XmlElement parentElement)
		{
			System.Xml.XmlElement thiselement = base.ToXml(parentElement);
			
			for(int i = 0, j = _purchasecreditcol.Count; i<j; i++)
			{
				_purchasecreditcol[i].ToXml(thiselement);
			}

			return thiselement;
		}

		/// <summary>
		/// Sets the internal members with the data from a compatible type obect.
		/// </summary>
		/// <param name="data">The data to set internally.</param>
		internal override void SetMembers(ref MISMO.Entities.TransactionDetailBase data)
		{
			// first let the base do its work.
			base.SetMembers(ref data);

			// load up the purchase credit data
			_purchasecreditcol = this.GetPurchaseCreditCollection();

			// refactor the checksum
			RecalculateChecksum();
		}


		/// <summary>
		/// Persist the object and its sub object to the database via a specified transaction.
		/// </summary>
		/// <param name="sqlTrans">A transaction object that manages the transaction.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// first call up to the base
			base.Persist(sqlTrans);

			// persist the purchase creid items.
			for(int i = 0, j = _purchasecreditcol.Count; i<j; i++)
			{
				_purchasecreditcol[i].LoanApplicationId = this.LoanApplicationId;
				_purchasecreditcol[i].Persist(sqlTrans);
			}

			// refactor the checksum for this object.
			RecalculateChecksum();
		}


		#endregion Methods
	}
}
