// ******************************************************************************************************************
//  OrcaLogic, Inc - http://www.OrcaLogic.com
//  Copyright (c) 2004
// 
//  OrcaLogic, Inc. is a consulting company specializing in delivering custom software solutions.  Please contact
//  OrcaLogic Inc. for details on this, other open source projects, or to inquire about consulting services.
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
//  documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
//  the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
//  to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all copies or substantial portions 
//  of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
//  TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
//  THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
//  CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
//  DEALINGS IN THE SOFTWARE.
// ******************************************************************************************************************
using System;
using System.Runtime.Serialization;
using System.Data;
using System.Data.SqlClient;
using OrcaLogic;
using MISMO.DAL;
using MISMO.EnterpriseCode;
using MISMO.BusinessObjects;


namespace MISMO.Entities
{
	/// <summary>
	/// A class that represents an abstract entity for table 'LOAN_PRODUCT_DATA'
	/// </summary>
	[Serializable]
	public abstract class LoanProductDataBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanProductDataBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.LoanProductData)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanProductDataBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			LoanProductDataBase.ServiceObject.Fill(this as LoanProductData, loanApplicationId);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _loanapplicationid_assigned = false;
		/// <summary>
		/// Member that stores the value for the loanapplicationid.
		/// </summary>
		internal System.Int64 _loanapplicationid;
		/// <summary>
		/// Gets and sets the LoanApplicationId value of the class instance.
		/// </summary>
		public virtual System.Int64 LoanApplicationId
		{
			get
			{
				return _loanapplicationid;
			}
			set
			{
				_loanapplicationid = value;
				_loanapplicationid_assigned = true;
			}
		}


		/// <summary>
		/// Gets the service object for the LoanProductDataBase.
		/// </summary>
		internal static LoanProductDataService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(LoanProductDataService)) as LoanProductDataService;
			}
		}


		/// <summary>
		/// The business exceptions of this object instance.
		/// </summary>
		public override RuleViolationException BusinessExceptions
		{
			get
			{
				// get the base's exception first
				RuleViolationException exceptions = base.BusinessExceptions;


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of LoanProductDataBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref LoanProductDataBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.SqlClient.SqlDataReader data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.DataRow data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Gets the connection string for the object instance. (Override if necessary)
		/// </summary>
		internal static System.String GetConnectionString()
		{


			// Simply return the DAL's static property.
			return Connection.String;


		}


		/// <summary>
		/// Method to persist object.
		/// </summary>
		public override void Persist()
		{
			Persist(null);
		}


		/// <summary>
		/// Method to persist object with the specified connection.
		/// </summary>
		internal virtual void Persist(SqlTransaction sqlTrans)
		{
			// make a call to the base method first
			base.Persist(sqlTrans);


			// call the persist method off the DAL service layer to persist the object instance
			LoanProductDataBase.ServiceObject.Persist(this as LoanProductData, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the LOAN_PRODUCT_DATA object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			LoanProductDataBase.ServiceObject.Delete(this as LoanProductData);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the ARM relationship.
		/// </summary>
		public ARMCollection GetARMCollection()
		{
			ARMCollection armcollection = new ARMCollection();


			ARMBase.ServiceObject.FillByLoanProductData(armcollection, _loanapplicationid);
			return armcollection;
		}


		/// <summary>
		/// Gets the objects for the BUYDOWN relationship.
		/// </summary>
		public BuydownCollection GetBuydownCollection()
		{
			BuydownCollection buydowncollection = new BuydownCollection();


			BuydownBase.ServiceObject.FillByLoanProductData(buydowncollection, _loanapplicationid);
			return buydowncollection;
		}


		/// <summary>
		/// Gets the objects for the LOAN_FEATURES relationship.
		/// </summary>
		public LoanFeaturesCollection GetLoanFeaturesCollection()
		{
			LoanFeaturesCollection loanfeaturescollection = new LoanFeaturesCollection();


			LoanFeaturesBase.ServiceObject.FillByLoanProductData(loanfeaturescollection, _loanapplicationid);
			return loanfeaturescollection;
		}


		/// <summary>
		/// Gets the objects for the PAYMENT_ADJUSTMENT relationship.
		/// </summary>
		public PaymentAdjustments GetPaymentAdjustments()
		{
			PaymentAdjustments paymentadjustments = new PaymentAdjustments();


			PaymentAdjustmentBase.ServiceObject.FillByLoanProductData(paymentadjustments, _loanapplicationid);
			return paymentadjustments;
		}


		/// <summary>
		/// Gets the objects for the RATE_ADJUSTMENT relationship.
		/// </summary>
		public RateAdjustments GetRateAdjustments()
		{
			RateAdjustments rateadjustments = new RateAdjustments();


			RateAdjustmentBase.ServiceObject.FillByLoanProductData(rateadjustments, _loanapplicationid);
			return rateadjustments;
		}


		/// <summary>
		/// Gets the single object for the LOAN_APPLICATION relationship.
		/// </summary>
		public LoanApplication GetLoanApplication()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new LoanApplication(_loanapplicationid);
		}


		/// <summary>
		/// Gets all persisted LoanProductData objects
		/// </summary>
		public static LoanProductDataCollection GetAll()
		{
			// have the service object get the objects
			return LoanProductDataBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
