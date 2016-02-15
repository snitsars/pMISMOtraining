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
	/// A class that represents an abstract entity for table 'ARM'
	/// </summary>
	[Serializable]
	public abstract class ARMBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ARMBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.ARM)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ARMBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			ARMBase.ServiceObject.Fill(this as ARM, loanApplicationId);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _indexcurrentvaluepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the indexcurrentvaluepercent.
		/// </summary>
		internal System.Decimal _indexcurrentvaluepercent;
		/// <summary>
		/// Gets and sets the IndexCurrentValuePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal IndexCurrentValuePercent
		{
			get
			{
				return _indexcurrentvaluepercent;
			}
			set
			{
				_indexcurrentvaluepercent = value;
				_indexcurrentvaluepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the IndexCurrentValuePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean IndexCurrentValuePercentIsNull
		{
			get
			{
				return _indexcurrentvaluepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _indexmarginpercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the indexmarginpercent.
		/// </summary>
		internal System.Decimal _indexmarginpercent;
		/// <summary>
		/// Gets and sets the IndexMarginPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal IndexMarginPercent
		{
			get
			{
				return _indexmarginpercent;
			}
			set
			{
				_indexmarginpercent = value;
				_indexmarginpercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the IndexMarginPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean IndexMarginPercentIsNull
		{
			get
			{
				return _indexmarginpercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _indextype_isnull = true;
		/// <summary>
		/// Member that stores the value for the indextype.
		/// </summary>
		internal System.Int16 _indextype;
		/// <summary>
		/// Gets and sets the IndexType value of the class instance.
		/// </summary>
		public virtual System.Int16 IndexType
		{
			get
			{
				return _indextype;
			}
			set
			{
				_indextype = value;
				_indextype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the IndexType value to see if it was set to null.
		/// </summary>
		public System.Boolean IndexTypeIsNull
		{
			get
			{
				return _indextype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _qualifyingratepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the qualifyingratepercent.
		/// </summary>
		internal System.Decimal _qualifyingratepercent;
		/// <summary>
		/// Gets and sets the QualifyingRatePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal QualifyingRatePercent
		{
			get
			{
				return _qualifyingratepercent;
			}
			set
			{
				_qualifyingratepercent = value;
				_qualifyingratepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the QualifyingRatePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean QualifyingRatePercentIsNull
		{
			get
			{
				return _qualifyingratepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _conversionoptionindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the conversionoptionindicator.
		/// </summary>
		internal System.Boolean _conversionoptionindicator;
		/// <summary>
		/// Gets and sets the ConversionOptionIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean ConversionOptionIndicator
		{
			get
			{
				return _conversionoptionindicator;
			}
			set
			{
				_conversionoptionindicator = value;
				_conversionoptionindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _paymentadjustmentlifetimecapamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the paymentadjustmentlifetimecapamount.
		/// </summary>
		internal System.Decimal _paymentadjustmentlifetimecapamount;
		/// <summary>
		/// Gets and sets the PaymentAdjustmentLifetimeCapAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PaymentAdjustmentLifetimeCapAmount
		{
			get
			{
				return _paymentadjustmentlifetimecapamount;
			}
			set
			{
				_paymentadjustmentlifetimecapamount = value;
				_paymentadjustmentlifetimecapamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PaymentAdjustmentLifetimeCapAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PaymentAdjustmentLifetimeCapAmountIsNull
		{
			get
			{
				return _paymentadjustmentlifetimecapamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _paymentadjustmentlifetimecappercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the paymentadjustmentlifetimecappercent.
		/// </summary>
		internal System.Decimal _paymentadjustmentlifetimecappercent;
		/// <summary>
		/// Gets and sets the PaymentAdjustmentLifetimeCapPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal PaymentAdjustmentLifetimeCapPercent
		{
			get
			{
				return _paymentadjustmentlifetimecappercent;
			}
			set
			{
				_paymentadjustmentlifetimecappercent = value;
				_paymentadjustmentlifetimecappercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PaymentAdjustmentLifetimeCapPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean PaymentAdjustmentLifetimeCapPercentIsNull
		{
			get
			{
				return _paymentadjustmentlifetimecappercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _rateadjustmentlifetimecappercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the rateadjustmentlifetimecappercent.
		/// </summary>
		internal System.Decimal _rateadjustmentlifetimecappercent;
		/// <summary>
		/// Gets and sets the RateAdjustmentLifetimeCapPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal RateAdjustmentLifetimeCapPercent
		{
			get
			{
				return _rateadjustmentlifetimecappercent;
			}
			set
			{
				_rateadjustmentlifetimecappercent = value;
				_rateadjustmentlifetimecappercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RateAdjustmentLifetimeCapPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean RateAdjustmentLifetimeCapPercentIsNull
		{
			get
			{
				return _rateadjustmentlifetimecappercent_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the ARMBase.
		/// </summary>
		internal static ARMService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(ARMService)) as ARMService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of ARMBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the IndexCurrentValuePercent value as null.
		/// </summary>
		public virtual void SetIndexCurrentValuePercentNull()
		{
			_indexcurrentvaluepercent = 0;
			_indexcurrentvaluepercent_isnull = true;
		}


		/// <summary>
		/// Marks the IndexMarginPercent value as null.
		/// </summary>
		public virtual void SetIndexMarginPercentNull()
		{
			_indexmarginpercent = 0;
			_indexmarginpercent_isnull = true;
		}


		/// <summary>
		/// Marks the IndexType value as null.
		/// </summary>
		public virtual void SetIndexTypeNull()
		{
			_indextype = 0;
			_indextype_isnull = true;
		}


		/// <summary>
		/// Marks the QualifyingRatePercent value as null.
		/// </summary>
		public virtual void SetQualifyingRatePercentNull()
		{
			_qualifyingratepercent = 0;
			_qualifyingratepercent_isnull = true;
		}


		/// <summary>
		/// Marks the PaymentAdjustmentLifetimeCapAmount value as null.
		/// </summary>
		public virtual void SetPaymentAdjustmentLifetimeCapAmountNull()
		{
			_paymentadjustmentlifetimecapamount = 0;
			_paymentadjustmentlifetimecapamount_isnull = true;
		}


		/// <summary>
		/// Marks the PaymentAdjustmentLifetimeCapPercent value as null.
		/// </summary>
		public virtual void SetPaymentAdjustmentLifetimeCapPercentNull()
		{
			_paymentadjustmentlifetimecappercent = 0;
			_paymentadjustmentlifetimecappercent_isnull = true;
		}


		/// <summary>
		/// Marks the RateAdjustmentLifetimeCapPercent value as null.
		/// </summary>
		public virtual void SetRateAdjustmentLifetimeCapPercentNull()
		{
			_rateadjustmentlifetimecappercent = 0;
			_rateadjustmentlifetimecappercent_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref ARMBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the IndexCurrentValuePercent data to the class member
			_indexcurrentvaluepercent = data._indexcurrentvaluepercent;
			_indexcurrentvaluepercent_isnull = data._indexcurrentvaluepercent_isnull;
			// assigns the IndexMarginPercent data to the class member
			_indexmarginpercent = data._indexmarginpercent;
			_indexmarginpercent_isnull = data._indexmarginpercent_isnull;
			// assigns the IndexType data to the class member
			_indextype = data._indextype;
			_indextype_isnull = data._indextype_isnull;
			// assigns the QualifyingRatePercent data to the class member
			_qualifyingratepercent = data._qualifyingratepercent;
			_qualifyingratepercent_isnull = data._qualifyingratepercent_isnull;
			// assigns the ConversionOptionIndicator data to the class member
			_conversionoptionindicator = data._conversionoptionindicator;
			_conversionoptionindicator_assigned = data._conversionoptionindicator_assigned;
			// assigns the PaymentAdjustmentLifetimeCapAmount data to the class member
			_paymentadjustmentlifetimecapamount = data._paymentadjustmentlifetimecapamount;
			_paymentadjustmentlifetimecapamount_isnull = data._paymentadjustmentlifetimecapamount_isnull;
			// assigns the PaymentAdjustmentLifetimeCapPercent data to the class member
			_paymentadjustmentlifetimecappercent = data._paymentadjustmentlifetimecappercent;
			_paymentadjustmentlifetimecappercent_isnull = data._paymentadjustmentlifetimecappercent_isnull;
			// assigns the RateAdjustmentLifetimeCapPercent data to the class member
			_rateadjustmentlifetimecappercent = data._rateadjustmentlifetimecappercent;
			_rateadjustmentlifetimecappercent_isnull = data._rateadjustmentlifetimecappercent_isnull;


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
			// assigns the IndexCurrentValuePercent data to the class member
			if (data["IndexCurrentValuePercent"] == System.DBNull.Value)
				SetIndexCurrentValuePercentNull();
			else
			{
				_indexcurrentvaluepercent = Convert.ToDecimal(data["IndexCurrentValuePercent"]);
				_indexcurrentvaluepercent_isnull = false;
			}
			// assigns the IndexMarginPercent data to the class member
			if (data["IndexMarginPercent"] == System.DBNull.Value)
				SetIndexMarginPercentNull();
			else
			{
				_indexmarginpercent = Convert.ToDecimal(data["IndexMarginPercent"]);
				_indexmarginpercent_isnull = false;
			}
			// assigns the IndexType data to the class member
			if (data["IndexType"] == System.DBNull.Value)
				SetIndexTypeNull();
			else
			{
				_indextype = Convert.ToInt16(data["IndexType"]);
				_indextype_isnull = false;
			}
			// assigns the QualifyingRatePercent data to the class member
			if (data["QualifyingRatePercent"] == System.DBNull.Value)
				SetQualifyingRatePercentNull();
			else
			{
				_qualifyingratepercent = Convert.ToDecimal(data["QualifyingRatePercent"]);
				_qualifyingratepercent_isnull = false;
			}
			// assigns the ConversionOptionIndicator data to the class member
			_conversionoptionindicator = Convert.ToBoolean(data["ConversionOptionIndicator"]);
			_conversionoptionindicator_assigned = true;
			// assigns the PaymentAdjustmentLifetimeCapAmount data to the class member
			if (data["PaymentAdjustmentLifetimeCapAmount"] == System.DBNull.Value)
				SetPaymentAdjustmentLifetimeCapAmountNull();
			else
			{
				_paymentadjustmentlifetimecapamount = Convert.ToDecimal(data["PaymentAdjustmentLifetimeCapAmount"]);
				_paymentadjustmentlifetimecapamount_isnull = false;
			}
			// assigns the PaymentAdjustmentLifetimeCapPercent data to the class member
			if (data["PaymentAdjustmentLifetimeCapPercent"] == System.DBNull.Value)
				SetPaymentAdjustmentLifetimeCapPercentNull();
			else
			{
				_paymentadjustmentlifetimecappercent = Convert.ToDecimal(data["PaymentAdjustmentLifetimeCapPercent"]);
				_paymentadjustmentlifetimecappercent_isnull = false;
			}
			// assigns the RateAdjustmentLifetimeCapPercent data to the class member
			if (data["RateAdjustmentLifetimeCapPercent"] == System.DBNull.Value)
				SetRateAdjustmentLifetimeCapPercentNull();
			else
			{
				_rateadjustmentlifetimecappercent = Convert.ToDecimal(data["RateAdjustmentLifetimeCapPercent"]);
				_rateadjustmentlifetimecappercent_isnull = false;
			}


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
			// assigns the IndexCurrentValuePercent data to the class member
			if (data["IndexCurrentValuePercent"] == System.DBNull.Value)
				SetIndexCurrentValuePercentNull();
			else
			{
				_indexcurrentvaluepercent = Convert.ToDecimal(data["IndexCurrentValuePercent"]);
				_indexcurrentvaluepercent_isnull = false;
			}
			// assigns the IndexMarginPercent data to the class member
			if (data["IndexMarginPercent"] == System.DBNull.Value)
				SetIndexMarginPercentNull();
			else
			{
				_indexmarginpercent = Convert.ToDecimal(data["IndexMarginPercent"]);
				_indexmarginpercent_isnull = false;
			}
			// assigns the IndexType data to the class member
			if (data["IndexType"] == System.DBNull.Value)
				SetIndexTypeNull();
			else
			{
				_indextype = Convert.ToInt16(data["IndexType"]);
				_indextype_isnull = false;
			}
			// assigns the QualifyingRatePercent data to the class member
			if (data["QualifyingRatePercent"] == System.DBNull.Value)
				SetQualifyingRatePercentNull();
			else
			{
				_qualifyingratepercent = Convert.ToDecimal(data["QualifyingRatePercent"]);
				_qualifyingratepercent_isnull = false;
			}
			// assigns the ConversionOptionIndicator data to the class member
			_conversionoptionindicator = Convert.ToBoolean(data["ConversionOptionIndicator"]);
			_conversionoptionindicator_assigned = true;
			// assigns the PaymentAdjustmentLifetimeCapAmount data to the class member
			if (data["PaymentAdjustmentLifetimeCapAmount"] == System.DBNull.Value)
				SetPaymentAdjustmentLifetimeCapAmountNull();
			else
			{
				_paymentadjustmentlifetimecapamount = Convert.ToDecimal(data["PaymentAdjustmentLifetimeCapAmount"]);
				_paymentadjustmentlifetimecapamount_isnull = false;
			}
			// assigns the PaymentAdjustmentLifetimeCapPercent data to the class member
			if (data["PaymentAdjustmentLifetimeCapPercent"] == System.DBNull.Value)
				SetPaymentAdjustmentLifetimeCapPercentNull();
			else
			{
				_paymentadjustmentlifetimecappercent = Convert.ToDecimal(data["PaymentAdjustmentLifetimeCapPercent"]);
				_paymentadjustmentlifetimecappercent_isnull = false;
			}
			// assigns the RateAdjustmentLifetimeCapPercent data to the class member
			if (data["RateAdjustmentLifetimeCapPercent"] == System.DBNull.Value)
				SetRateAdjustmentLifetimeCapPercentNull();
			else
			{
				_rateadjustmentlifetimecappercent = Convert.ToDecimal(data["RateAdjustmentLifetimeCapPercent"]);
				_rateadjustmentlifetimecappercent_isnull = false;
			}


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
			ARMBase.ServiceObject.Persist(this as ARM, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the ARM object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			ARMBase.ServiceObject.Delete(this as ARM);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the InterestRateIndex relationship.
		/// </summary>
		public InterestRateIndex GetInterestRateIndex()
		{
			if (_indextype_isnull)
				return null;
			else
				return new InterestRateIndex(_indextype);
		}


		/// <summary>
		/// Gets the single object for the LOAN_PRODUCT_DATA relationship.
		/// </summary>
		public LoanProductData GetLoanProductData()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new LoanProductData(_loanapplicationid);
		}


		/// <summary>
		/// Gets all persisted ARM objects
		/// </summary>
		public static ARMCollection GetAll()
		{
			// have the service object get the objects
			return ARMBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
