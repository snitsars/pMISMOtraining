using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a loan product set of data.
	/// </summary>
	[Serializable]
	public class LoanProductData : MISMO.BusinessObjects.LoanProductData
	{
		#region Constructors

		public LoanProductData()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the arm object for the loan product instance.
		/// </summary>
		internal MISMO.BusinessObjects.ARM _arm = null;
		/// <summary>
		/// Gets the ARM object for the product instance.
		/// </summary>
		public MISMO.BusinessObjects.ARM ARM 
		{
			get 
			{ 
				return _arm; 
			}
		}


		/// <summary>
		/// Member that stores the buydowns for the loan product instance.
		/// </summary>
		internal MISMO.BusinessObjects.BuydownCollection _buydowns = new BuydownCollection();
		/// <summary>
		/// Gets the buydown collection for the loan product instance.
		/// </summary>
		public MISMO.BusinessObjects.BuydownCollection Buydowns
		{
			get { return _buydowns; }
		}

		/// <summary>
		/// Gets the loan features object of the product data instance.
		/// </summary>
		internal MISMO.BusinessObjects.LoanFeatures _loanfeatures = null;
		/// <summary>
		/// Gets the loan features of the product data instance.
		/// </summary>
		public MISMO.BusinessObjects.LoanFeatures LoanFeatures
		{
			get 
			{
				return _loanfeatures;
			}
		}

		/// <summary>
		/// Member that stores the payment adjustments for the product data instace.
		/// </summary>
		internal MISMO.BusinessObjects.PaymentAdjustments _paymentadjustments = new MISMO.BusinessObjects.PaymentAdjustments();
		/// <summary>
		/// Gets the payment adjustment collection for the product data instance.
		/// </summary>
		public MISMO.BusinessObjects.PaymentAdjustments PaymentAdjustments
		{
			get { return _paymentadjustments; }
		}


		/// <summary>
		/// Member that stores the rate adjustments for the product data instace.
		/// </summary>
		internal MISMO.BusinessObjects.RateAdjustments _rateadjustments = new MISMO.BusinessObjects.RateAdjustments();
		/// <summary>
		/// Gets the rate adjustment collection for the product data instance.
		/// </summary>
		public MISMO.BusinessObjects.RateAdjustments RateAdjustments
		{
			get { return _rateadjustments; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Persist the current object via a specified transaction.
		/// </summary>
		/// <param name="sqlTrans">The transaction responsible for persisting an object.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// let the base do its work first.
			base.Persist(sqlTrans);

			// persist the arm data
			if (_arm != null)
			{
				_arm.LoanApplicationId = _loanapplicationid;
				_arm.Persist(sqlTrans);
			}

			// persist the buydowns
			for(int i = 0, j = _buydowns.Count; i<j; i++)
			{
				_buydowns[i].LoanApplicationId = _loanapplicationid;
				_buydowns[i].Persist(sqlTrans);
			}

			// persist the loan features
			if (_loanfeatures != null)
			{
				_loanfeatures.LoanApplicationId = _loanapplicationid;
				_loanfeatures.Persist(sqlTrans);
			}

			// persist the payment adjustments
			for(int i = 0, j = _paymentadjustments.Count; i<j; i++)
			{
				_paymentadjustments[i].LoanApplicationId = _loanapplicationid;
				_paymentadjustments[i].Persist(sqlTrans);
			}

			// persist the rate adjustments
			for(int i = 0, j = _rateadjustments.Count; i<j; i++)
			{
				_rateadjustments[i].LoanApplicationId = _loanapplicationid;
				_rateadjustments[i].Persist(sqlTrans);
			}

			// refactor the checksum
			RecalculateChecksum();
		}




		/// <summary>
		/// Sets the internal base members with data from the specified compatible object.
		/// </summary>
		/// <param name="data">The data to set members with.</param>
		internal override void SetMembers(ref MISMO.Entities.LoanProductDataBase data)
		{
			// let the base do its work first
			base.SetMembers(ref data);

			// get the ARM object
			MISMO.BusinessObjects.ARMCollection arms = this.GetARMCollection();
			if (arms != null && arms.Count > 0)
				_arm = arms[0];

			// get the buydowns
			_buydowns = this.GetBuydownCollection();

			// get the loan feature
			MISMO.BusinessObjects.LoanFeaturesCollection loanfcol = this.GetLoanFeaturesCollection();
			if (loanfcol != null && loanfcol.Count > 0)
				_loanfeatures = loanfcol[0];

			// get the payment adjustments
			_paymentadjustments = this.GetPaymentAdjustments();

			// get the rate adjustments
			_rateadjustments = this.GetRateAdjustments();

			// refactor the checksum
			RecalculateChecksum();
		}



		/// <summary>
		/// Creates the current instance's xml element object.
		/// </summary>
		/// <param name="parentElement">The container element to create and add the instance to.</param>
		/// <returns>The new xml element.</returns>
		internal override System.Xml.XmlElement ToXml(System.Xml.XmlElement parentElement)
		{
			System.Xml.XmlElement thiselement = base.ToXml(parentElement);
			
			if (_arm != null) _arm.ToXml(thiselement);


			for(int i = 0, j = _buydowns.Count; i<j; i++)
			{
				_buydowns[i].ToXml(thiselement);
			}

			if (_loanfeatures != null) _loanfeatures.ToXml(thiselement);

			for(int i = 0, j = _paymentadjustments.Count; i<j; i++)
			{
				_paymentadjustments[i].ToXml(thiselement);
			}

			for(int i = 0, j = _rateadjustments.Count; i<j; i++)
			{
				_rateadjustments[i].ToXml(thiselement);
			}

			return thiselement;
		}


		#endregion Methods
	}
}
