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
	/// A class that represents an abstract entity for table 'VA_LOAN'
	/// </summary>
	[Serializable]
	public abstract class VALoanBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VALoanBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.VALoan)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public VALoanBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			VALoanBase.ServiceObject.Fill(this as VALoan, loanApplicationId);
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
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _vaborrowercoborrowermarriedindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the vaborrowercoborrowermarriedindicator.
		/// </summary>
		internal System.Boolean _vaborrowercoborrowermarriedindicator;
		/// <summary>
		/// Gets and sets the VABorrowerCoBorrowerMarriedIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean VABorrowerCoBorrowerMarriedIndicator
		{
			get
			{
				return _vaborrowercoborrowermarriedindicator;
			}
			set
			{
				_vaborrowercoborrowermarriedindicator = value;
				_vaborrowercoborrowermarriedindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerfundingfeepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerfundingfeepercent.
		/// </summary>
		internal System.Decimal _borrowerfundingfeepercent;
		/// <summary>
		/// Gets and sets the BorrowerFundingFeePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerFundingFeePercent
		{
			get
			{
				return _borrowerfundingfeepercent;
			}
			set
			{
				_borrowerfundingfeepercent = value;
				_borrowerfundingfeepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerFundingFeePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerFundingFeePercentIsNull
		{
			get
			{
				return _borrowerfundingfeepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vaentitlementamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vaentitlementamount.
		/// </summary>
		internal System.Decimal _vaentitlementamount;
		/// <summary>
		/// Gets and sets the VAEntitlementAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAEntitlementAmount
		{
			get
			{
				return _vaentitlementamount;
			}
			set
			{
				_vaentitlementamount = value;
				_vaentitlementamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAEntitlementAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAEntitlementAmountIsNull
		{
			get
			{
				return _vaentitlementamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vamaintenanceexpensemonthlyamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vamaintenanceexpensemonthlyamount.
		/// </summary>
		internal System.Decimal _vamaintenanceexpensemonthlyamount;
		/// <summary>
		/// Gets and sets the VAMaintenanceExpenseMonthlyAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAMaintenanceExpenseMonthlyAmount
		{
			get
			{
				return _vamaintenanceexpensemonthlyamount;
			}
			set
			{
				_vamaintenanceexpensemonthlyamount = value;
				_vamaintenanceexpensemonthlyamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAMaintenanceExpenseMonthlyAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAMaintenanceExpenseMonthlyAmountIsNull
		{
			get
			{
				return _vamaintenanceexpensemonthlyamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _varesidualincomeamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the varesidualincomeamount.
		/// </summary>
		internal System.Decimal _varesidualincomeamount;
		/// <summary>
		/// Gets and sets the VAResidualIncomeAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAResidualIncomeAmount
		{
			get
			{
				return _varesidualincomeamount;
			}
			set
			{
				_varesidualincomeamount = value;
				_varesidualincomeamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAResidualIncomeAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAResidualIncomeAmountIsNull
		{
			get
			{
				return _varesidualincomeamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vautilityexpensemonthlyamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vautilityexpensemonthlyamount.
		/// </summary>
		internal System.Decimal _vautilityexpensemonthlyamount;
		/// <summary>
		/// Gets and sets the VAUtilityExpenseMonthlyAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAUtilityExpenseMonthlyAmount
		{
			get
			{
				return _vautilityexpensemonthlyamount;
			}
			set
			{
				_vautilityexpensemonthlyamount = value;
				_vautilityexpensemonthlyamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAUtilityExpenseMonthlyAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAUtilityExpenseMonthlyAmountIsNull
		{
			get
			{
				return _vautilityexpensemonthlyamount_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the VALoanBase.
		/// </summary>
		internal static VALoanService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(VALoanService)) as VALoanService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of VALoanBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the BorrowerFundingFeePercent value as null.
		/// </summary>
		public virtual void SetBorrowerFundingFeePercentNull()
		{
			_borrowerfundingfeepercent = 0;
			_borrowerfundingfeepercent_isnull = true;
		}


		/// <summary>
		/// Marks the VAEntitlementAmount value as null.
		/// </summary>
		public virtual void SetVAEntitlementAmountNull()
		{
			_vaentitlementamount = 0;
			_vaentitlementamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAMaintenanceExpenseMonthlyAmount value as null.
		/// </summary>
		public virtual void SetVAMaintenanceExpenseMonthlyAmountNull()
		{
			_vamaintenanceexpensemonthlyamount = 0;
			_vamaintenanceexpensemonthlyamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAResidualIncomeAmount value as null.
		/// </summary>
		public virtual void SetVAResidualIncomeAmountNull()
		{
			_varesidualincomeamount = 0;
			_varesidualincomeamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAUtilityExpenseMonthlyAmount value as null.
		/// </summary>
		public virtual void SetVAUtilityExpenseMonthlyAmountNull()
		{
			_vautilityexpensemonthlyamount = 0;
			_vautilityexpensemonthlyamount_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref VALoanBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the VABorrowerCoBorrowerMarriedIndicator data to the class member
			_vaborrowercoborrowermarriedindicator = data._vaborrowercoborrowermarriedindicator;
			_vaborrowercoborrowermarriedindicator_assigned = data._vaborrowercoborrowermarriedindicator_assigned;
			// assigns the BorrowerFundingFeePercent data to the class member
			_borrowerfundingfeepercent = data._borrowerfundingfeepercent;
			_borrowerfundingfeepercent_isnull = data._borrowerfundingfeepercent_isnull;
			// assigns the VAEntitlementAmount data to the class member
			_vaentitlementamount = data._vaentitlementamount;
			_vaentitlementamount_isnull = data._vaentitlementamount_isnull;
			// assigns the VAMaintenanceExpenseMonthlyAmount data to the class member
			_vamaintenanceexpensemonthlyamount = data._vamaintenanceexpensemonthlyamount;
			_vamaintenanceexpensemonthlyamount_isnull = data._vamaintenanceexpensemonthlyamount_isnull;
			// assigns the VAResidualIncomeAmount data to the class member
			_varesidualincomeamount = data._varesidualincomeamount;
			_varesidualincomeamount_isnull = data._varesidualincomeamount_isnull;
			// assigns the VAUtilityExpenseMonthlyAmount data to the class member
			_vautilityexpensemonthlyamount = data._vautilityexpensemonthlyamount;
			_vautilityexpensemonthlyamount_isnull = data._vautilityexpensemonthlyamount_isnull;


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
			// assigns the VABorrowerCoBorrowerMarriedIndicator data to the class member
			_vaborrowercoborrowermarriedindicator = Convert.ToBoolean(data["VABorrowerCoBorrowerMarriedIndicator"]);
			_vaborrowercoborrowermarriedindicator_assigned = true;
			// assigns the BorrowerFundingFeePercent data to the class member
			if (data["BorrowerFundingFeePercent"] == System.DBNull.Value)
				SetBorrowerFundingFeePercentNull();
			else
			{
				_borrowerfundingfeepercent = Convert.ToDecimal(data["BorrowerFundingFeePercent"]);
				_borrowerfundingfeepercent_isnull = false;
			}
			// assigns the VAEntitlementAmount data to the class member
			if (data["VAEntitlementAmount"] == System.DBNull.Value)
				SetVAEntitlementAmountNull();
			else
			{
				_vaentitlementamount = Convert.ToDecimal(data["VAEntitlementAmount"]);
				_vaentitlementamount_isnull = false;
			}
			// assigns the VAMaintenanceExpenseMonthlyAmount data to the class member
			if (data["VAMaintenanceExpenseMonthlyAmount"] == System.DBNull.Value)
				SetVAMaintenanceExpenseMonthlyAmountNull();
			else
			{
				_vamaintenanceexpensemonthlyamount = Convert.ToDecimal(data["VAMaintenanceExpenseMonthlyAmount"]);
				_vamaintenanceexpensemonthlyamount_isnull = false;
			}
			// assigns the VAResidualIncomeAmount data to the class member
			if (data["VAResidualIncomeAmount"] == System.DBNull.Value)
				SetVAResidualIncomeAmountNull();
			else
			{
				_varesidualincomeamount = Convert.ToDecimal(data["VAResidualIncomeAmount"]);
				_varesidualincomeamount_isnull = false;
			}
			// assigns the VAUtilityExpenseMonthlyAmount data to the class member
			if (data["VAUtilityExpenseMonthlyAmount"] == System.DBNull.Value)
				SetVAUtilityExpenseMonthlyAmountNull();
			else
			{
				_vautilityexpensemonthlyamount = Convert.ToDecimal(data["VAUtilityExpenseMonthlyAmount"]);
				_vautilityexpensemonthlyamount_isnull = false;
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
			// assigns the VABorrowerCoBorrowerMarriedIndicator data to the class member
			_vaborrowercoborrowermarriedindicator = Convert.ToBoolean(data["VABorrowerCoBorrowerMarriedIndicator"]);
			_vaborrowercoborrowermarriedindicator_assigned = true;
			// assigns the BorrowerFundingFeePercent data to the class member
			if (data["BorrowerFundingFeePercent"] == System.DBNull.Value)
				SetBorrowerFundingFeePercentNull();
			else
			{
				_borrowerfundingfeepercent = Convert.ToDecimal(data["BorrowerFundingFeePercent"]);
				_borrowerfundingfeepercent_isnull = false;
			}
			// assigns the VAEntitlementAmount data to the class member
			if (data["VAEntitlementAmount"] == System.DBNull.Value)
				SetVAEntitlementAmountNull();
			else
			{
				_vaentitlementamount = Convert.ToDecimal(data["VAEntitlementAmount"]);
				_vaentitlementamount_isnull = false;
			}
			// assigns the VAMaintenanceExpenseMonthlyAmount data to the class member
			if (data["VAMaintenanceExpenseMonthlyAmount"] == System.DBNull.Value)
				SetVAMaintenanceExpenseMonthlyAmountNull();
			else
			{
				_vamaintenanceexpensemonthlyamount = Convert.ToDecimal(data["VAMaintenanceExpenseMonthlyAmount"]);
				_vamaintenanceexpensemonthlyamount_isnull = false;
			}
			// assigns the VAResidualIncomeAmount data to the class member
			if (data["VAResidualIncomeAmount"] == System.DBNull.Value)
				SetVAResidualIncomeAmountNull();
			else
			{
				_varesidualincomeamount = Convert.ToDecimal(data["VAResidualIncomeAmount"]);
				_varesidualincomeamount_isnull = false;
			}
			// assigns the VAUtilityExpenseMonthlyAmount data to the class member
			if (data["VAUtilityExpenseMonthlyAmount"] == System.DBNull.Value)
				SetVAUtilityExpenseMonthlyAmountNull();
			else
			{
				_vautilityexpensemonthlyamount = Convert.ToDecimal(data["VAUtilityExpenseMonthlyAmount"]);
				_vautilityexpensemonthlyamount_isnull = false;
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
			VALoanBase.ServiceObject.Persist(this as VALoan, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the VA_LOAN object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			VALoanBase.ServiceObject.Delete(this as VALoan);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the GOVERNMENT_LOAN relationship.
		/// </summary>
		public GovernmentLoan GetGovernmentLoan()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new GovernmentLoan(_loanapplicationid);
		}


		/// <summary>
		/// Gets all persisted VALoan objects
		/// </summary>
		public static VALoans GetAll()
		{
			// have the service object get the objects
			return VALoanBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
