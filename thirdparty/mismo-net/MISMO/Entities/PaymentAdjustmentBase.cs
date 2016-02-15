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
	/// A class that represents an abstract entity for table 'PAYMENT_ADJUSTMENT'
	/// </summary>
	[Serializable]
	public abstract class PaymentAdjustmentBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PaymentAdjustmentBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.PaymentAdjustment)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public PaymentAdjustmentBase(System.Int64 id)
		{
			// Fill this instance.
			PaymentAdjustmentBase.ServiceObject.Fill(this as PaymentAdjustment, id);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the value for the id.
		/// </summary>
		internal System.Int64 _id;
		/// <summary>
		/// Gets the Id value of the class instance.
		/// </summary>
		public virtual System.Int64 Id
		{
			get
			{
				return _id;
			}
			set
			{
				throw new System.NotImplementedException("The class property Id is a read-only property.");
			}
		}


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
		internal bool _firstpaymentadjustmentmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the firstpaymentadjustmentmonths.
		/// </summary>
		internal System.Decimal _firstpaymentadjustmentmonths;
		/// <summary>
		/// Gets and sets the FirstPaymentAdjustmentMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal FirstPaymentAdjustmentMonths
		{
			get
			{
				return _firstpaymentadjustmentmonths;
			}
			set
			{
				_firstpaymentadjustmentmonths = value;
				_firstpaymentadjustmentmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FirstPaymentAdjustmentMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean FirstPaymentAdjustmentMonthsIsNull
		{
			get
			{
				return _firstpaymentadjustmentmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _amount_isnull = true;
		/// <summary>
		/// Member that stores the value for the amount.
		/// </summary>
		internal System.Decimal _amount;
		/// <summary>
		/// Gets and sets the Amount value of the class instance.
		/// </summary>
		public virtual System.Decimal Amount
		{
			get
			{
				return _amount;
			}
			set
			{
				_amount = value;
				_amount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the Amount value to see if it was set to null.
		/// </summary>
		public System.Boolean AmountIsNull
		{
			get
			{
				return _amount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _calculationtype_assigned = false;
		/// <summary>
		/// Member that stores the value for the calculationtype.
		/// </summary>
		internal System.Int16 _calculationtype;
		/// <summary>
		/// Gets and sets the CalculationType value of the class instance.
		/// </summary>
		public virtual System.Int16 CalculationType
		{
			get
			{
				return _calculationtype;
			}
			set
			{
				_calculationtype = value;
				_calculationtype_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _durationmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the durationmonths.
		/// </summary>
		internal System.Decimal _durationmonths;
		/// <summary>
		/// Gets and sets the DurationMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal DurationMonths
		{
			get
			{
				return _durationmonths;
			}
			set
			{
				_durationmonths = value;
				_durationmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the DurationMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean DurationMonthsIsNull
		{
			get
			{
				return _durationmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _percent_isnull = true;
		/// <summary>
		/// Member that stores the value for the percent.
		/// </summary>
		internal System.Decimal _percent;
		/// <summary>
		/// Gets and sets the Percent value of the class instance.
		/// </summary>
		public virtual System.Decimal Percent
		{
			get
			{
				return _percent;
			}
			set
			{
				_percent = value;
				_percent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the Percent value to see if it was set to null.
		/// </summary>
		public System.Boolean PercentIsNull
		{
			get
			{
				return _percent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _periodiccapamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the periodiccapamount.
		/// </summary>
		internal System.Decimal _periodiccapamount;
		/// <summary>
		/// Gets and sets the PeriodicCapAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PeriodicCapAmount
		{
			get
			{
				return _periodiccapamount;
			}
			set
			{
				_periodiccapamount = value;
				_periodiccapamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PeriodicCapAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PeriodicCapAmountIsNull
		{
			get
			{
				return _periodiccapamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _periodiccappercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the periodiccappercent.
		/// </summary>
		internal System.Decimal _periodiccappercent;
		/// <summary>
		/// Gets and sets the PeriodicCapPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal PeriodicCapPercent
		{
			get
			{
				return _periodiccappercent;
			}
			set
			{
				_periodiccappercent = value;
				_periodiccappercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PeriodicCapPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean PeriodicCapPercentIsNull
		{
			get
			{
				return _periodiccappercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the periodnumber.
		/// </summary>
		internal System.String _periodnumber;
		/// <summary>
		/// Gets and sets the PeriodNumber value of the class instance.
		/// </summary>
		public virtual System.String PeriodNumber
		{
			get
			{
				return _periodnumber;
			}
			set
			{
				_periodnumber = value;
			}
		}


		/// <summary>
		/// Checks the PeriodNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean PeriodNumberIsNull
		{
			get
			{
				return (_periodnumber == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _subsequentpaymentadjustmentmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the subsequentpaymentadjustmentmonths.
		/// </summary>
		internal System.Decimal _subsequentpaymentadjustmentmonths;
		/// <summary>
		/// Gets and sets the SubsequentPaymentAdjustmentMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal SubsequentPaymentAdjustmentMonths
		{
			get
			{
				return _subsequentpaymentadjustmentmonths;
			}
			set
			{
				_subsequentpaymentadjustmentmonths = value;
				_subsequentpaymentadjustmentmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SubsequentPaymentAdjustmentMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean SubsequentPaymentAdjustmentMonthsIsNull
		{
			get
			{
				return _subsequentpaymentadjustmentmonths_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the PaymentAdjustmentBase.
		/// </summary>
		internal static PaymentAdjustmentService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(PaymentAdjustmentService)) as PaymentAdjustmentService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of PaymentAdjustmentBase. The value has not been explicitly assigned.", exceptions);
				if (!_calculationtype_assigned) exceptions = BusinessLogic.ChainException("CalculationType is a required value of PaymentAdjustmentBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the FirstPaymentAdjustmentMonths value as null.
		/// </summary>
		public virtual void SetFirstPaymentAdjustmentMonthsNull()
		{
			_firstpaymentadjustmentmonths = 0;
			_firstpaymentadjustmentmonths_isnull = true;
		}


		/// <summary>
		/// Marks the Amount value as null.
		/// </summary>
		public virtual void SetAmountNull()
		{
			_amount = 0;
			_amount_isnull = true;
		}


		/// <summary>
		/// Marks the DurationMonths value as null.
		/// </summary>
		public virtual void SetDurationMonthsNull()
		{
			_durationmonths = 0;
			_durationmonths_isnull = true;
		}


		/// <summary>
		/// Marks the Percent value as null.
		/// </summary>
		public virtual void SetPercentNull()
		{
			_percent = 0;
			_percent_isnull = true;
		}


		/// <summary>
		/// Marks the PeriodicCapAmount value as null.
		/// </summary>
		public virtual void SetPeriodicCapAmountNull()
		{
			_periodiccapamount = 0;
			_periodiccapamount_isnull = true;
		}


		/// <summary>
		/// Marks the PeriodicCapPercent value as null.
		/// </summary>
		public virtual void SetPeriodicCapPercentNull()
		{
			_periodiccappercent = 0;
			_periodiccappercent_isnull = true;
		}


		/// <summary>
		/// Marks the PeriodNumber value as null.
		/// </summary>
		public virtual void SetPeriodNumberNull()
		{
			_periodnumber = null;
		}


		/// <summary>
		/// Marks the SubsequentPaymentAdjustmentMonths value as null.
		/// </summary>
		public virtual void SetSubsequentPaymentAdjustmentMonthsNull()
		{
			_subsequentpaymentadjustmentmonths = 0;
			_subsequentpaymentadjustmentmonths_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref PaymentAdjustmentBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the FirstPaymentAdjustmentMonths data to the class member
			_firstpaymentadjustmentmonths = data._firstpaymentadjustmentmonths;
			_firstpaymentadjustmentmonths_isnull = data._firstpaymentadjustmentmonths_isnull;
			// assigns the Amount data to the class member
			_amount = data._amount;
			_amount_isnull = data._amount_isnull;
			// assigns the CalculationType data to the class member
			_calculationtype = data._calculationtype;
			_calculationtype_assigned = data._calculationtype_assigned;
			// assigns the DurationMonths data to the class member
			_durationmonths = data._durationmonths;
			_durationmonths_isnull = data._durationmonths_isnull;
			// assigns the Percent data to the class member
			_percent = data._percent;
			_percent_isnull = data._percent_isnull;
			// assigns the PeriodicCapAmount data to the class member
			_periodiccapamount = data._periodiccapamount;
			_periodiccapamount_isnull = data._periodiccapamount_isnull;
			// assigns the PeriodicCapPercent data to the class member
			_periodiccappercent = data._periodiccappercent;
			_periodiccappercent_isnull = data._periodiccappercent_isnull;
			// assigns the PeriodNumber data to the class member
			_periodnumber = data._periodnumber;
			// assigns the SubsequentPaymentAdjustmentMonths data to the class member
			_subsequentpaymentadjustmentmonths = data._subsequentpaymentadjustmentmonths;
			_subsequentpaymentadjustmentmonths_isnull = data._subsequentpaymentadjustmentmonths_isnull;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.SqlClient.SqlDataReader data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the Id data to the class member
			_id = Convert.ToInt64(data["Id"]);
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the FirstPaymentAdjustmentMonths data to the class member
			if (data["FirstPaymentAdjustmentMonths"] == System.DBNull.Value)
				SetFirstPaymentAdjustmentMonthsNull();
			else
			{
				_firstpaymentadjustmentmonths = Convert.ToDecimal(data["FirstPaymentAdjustmentMonths"]);
				_firstpaymentadjustmentmonths_isnull = false;
			}
			// assigns the Amount data to the class member
			if (data["Amount"] == System.DBNull.Value)
				SetAmountNull();
			else
			{
				_amount = Convert.ToDecimal(data["Amount"]);
				_amount_isnull = false;
			}
			// assigns the CalculationType data to the class member
			_calculationtype = Convert.ToInt16(data["CalculationType"]);
			_calculationtype_assigned = true;
			// assigns the DurationMonths data to the class member
			if (data["DurationMonths"] == System.DBNull.Value)
				SetDurationMonthsNull();
			else
			{
				_durationmonths = Convert.ToDecimal(data["DurationMonths"]);
				_durationmonths_isnull = false;
			}
			// assigns the Percent data to the class member
			if (data["Percent"] == System.DBNull.Value)
				SetPercentNull();
			else
			{
				_percent = Convert.ToDecimal(data["Percent"]);
				_percent_isnull = false;
			}
			// assigns the PeriodicCapAmount data to the class member
			if (data["PeriodicCapAmount"] == System.DBNull.Value)
				SetPeriodicCapAmountNull();
			else
			{
				_periodiccapamount = Convert.ToDecimal(data["PeriodicCapAmount"]);
				_periodiccapamount_isnull = false;
			}
			// assigns the PeriodicCapPercent data to the class member
			if (data["PeriodicCapPercent"] == System.DBNull.Value)
				SetPeriodicCapPercentNull();
			else
			{
				_periodiccappercent = Convert.ToDecimal(data["PeriodicCapPercent"]);
				_periodiccappercent_isnull = false;
			}
			// assigns the PeriodNumber data to the class member
			if (data["PeriodNumber"] == System.DBNull.Value)
				SetPeriodNumberNull();
			else
			{
				_periodnumber = Convert.ToString(data["PeriodNumber"]);
			}
			// assigns the SubsequentPaymentAdjustmentMonths data to the class member
			if (data["SubsequentPaymentAdjustmentMonths"] == System.DBNull.Value)
				SetSubsequentPaymentAdjustmentMonthsNull();
			else
			{
				_subsequentpaymentadjustmentmonths = Convert.ToDecimal(data["SubsequentPaymentAdjustmentMonths"]);
				_subsequentpaymentadjustmentmonths_isnull = false;
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


			// assigns the Id data to the class member
			_id = Convert.ToInt64(data["Id"]);
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the FirstPaymentAdjustmentMonths data to the class member
			if (data["FirstPaymentAdjustmentMonths"] == System.DBNull.Value)
				SetFirstPaymentAdjustmentMonthsNull();
			else
			{
				_firstpaymentadjustmentmonths = Convert.ToDecimal(data["FirstPaymentAdjustmentMonths"]);
				_firstpaymentadjustmentmonths_isnull = false;
			}
			// assigns the Amount data to the class member
			if (data["Amount"] == System.DBNull.Value)
				SetAmountNull();
			else
			{
				_amount = Convert.ToDecimal(data["Amount"]);
				_amount_isnull = false;
			}
			// assigns the CalculationType data to the class member
			_calculationtype = Convert.ToInt16(data["CalculationType"]);
			_calculationtype_assigned = true;
			// assigns the DurationMonths data to the class member
			if (data["DurationMonths"] == System.DBNull.Value)
				SetDurationMonthsNull();
			else
			{
				_durationmonths = Convert.ToDecimal(data["DurationMonths"]);
				_durationmonths_isnull = false;
			}
			// assigns the Percent data to the class member
			if (data["Percent"] == System.DBNull.Value)
				SetPercentNull();
			else
			{
				_percent = Convert.ToDecimal(data["Percent"]);
				_percent_isnull = false;
			}
			// assigns the PeriodicCapAmount data to the class member
			if (data["PeriodicCapAmount"] == System.DBNull.Value)
				SetPeriodicCapAmountNull();
			else
			{
				_periodiccapamount = Convert.ToDecimal(data["PeriodicCapAmount"]);
				_periodiccapamount_isnull = false;
			}
			// assigns the PeriodicCapPercent data to the class member
			if (data["PeriodicCapPercent"] == System.DBNull.Value)
				SetPeriodicCapPercentNull();
			else
			{
				_periodiccappercent = Convert.ToDecimal(data["PeriodicCapPercent"]);
				_periodiccappercent_isnull = false;
			}
			// assigns the PeriodNumber data to the class member
			if (data["PeriodNumber"] == System.DBNull.Value)
				SetPeriodNumberNull();
			else
			{
				_periodnumber = Convert.ToString(data["PeriodNumber"]);
			}
			// assigns the SubsequentPaymentAdjustmentMonths data to the class member
			if (data["SubsequentPaymentAdjustmentMonths"] == System.DBNull.Value)
				SetSubsequentPaymentAdjustmentMonthsNull();
			else
			{
				_subsequentpaymentadjustmentmonths = Convert.ToDecimal(data["SubsequentPaymentAdjustmentMonths"]);
				_subsequentpaymentadjustmentmonths_isnull = false;
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
			PaymentAdjustmentBase.ServiceObject.Persist(this as PaymentAdjustment, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the PAYMENT_ADJUSTMENT object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			PaymentAdjustmentBase.ServiceObject.Delete(this as PaymentAdjustment);


			// Now call the base for it to do its own thing
			base.Delete();
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
		/// Gets all persisted PaymentAdjustment objects
		/// </summary>
		public static PaymentAdjustments GetAll()
		{
			// have the service object get the objects
			return PaymentAdjustmentBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
