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
	/// A class that represents an abstract entity for table 'MORTGAGE_TERMS'
	/// </summary>
	[Serializable]
	public abstract class MortgageTermsBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageTermsBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.MortgageTerms)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public MortgageTermsBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			MortgageTermsBase.ServiceObject.Fill(this as MortgageTerms, loanApplicationId);
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
		/// Member that stores the value for the agencycaseidentifier.
		/// </summary>
		internal System.String _agencycaseidentifier;
		/// <summary>
		/// Gets and sets the AgencyCaseIdentifier value of the class instance.
		/// </summary>
		public virtual System.String AgencyCaseIdentifier
		{
			get
			{
				return _agencycaseidentifier;
			}
			set
			{
				_agencycaseidentifier = value;
			}
		}


		/// <summary>
		/// Checks the AgencyCaseIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean AgencyCaseIdentifierIsNull
		{
			get
			{
				return (_agencycaseidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the armtypedescription.
		/// </summary>
		internal System.String _armtypedescription;
		/// <summary>
		/// Gets and sets the ARMTypeDescription value of the class instance.
		/// </summary>
		public virtual System.String ARMTypeDescription
		{
			get
			{
				return _armtypedescription;
			}
			set
			{
				_armtypedescription = value;
			}
		}


		/// <summary>
		/// Checks the ARMTypeDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean ARMTypeDescriptionIsNull
		{
			get
			{
				return (_armtypedescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _baseloanamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the baseloanamount.
		/// </summary>
		internal System.Decimal _baseloanamount;
		/// <summary>
		/// Gets and sets the BaseLoanAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal BaseLoanAmount
		{
			get
			{
				return _baseloanamount;
			}
			set
			{
				_baseloanamount = value;
				_baseloanamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BaseLoanAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean BaseLoanAmountIsNull
		{
			get
			{
				return _baseloanamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerrequestedloanamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerrequestedloanamount.
		/// </summary>
		internal System.Decimal _borrowerrequestedloanamount;
		/// <summary>
		/// Gets and sets the BorrowerRequestedLoanAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerRequestedLoanAmount
		{
			get
			{
				return _borrowerrequestedloanamount;
			}
			set
			{
				_borrowerrequestedloanamount = value;
				_borrowerrequestedloanamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerRequestedLoanAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerRequestedLoanAmountIsNull
		{
			get
			{
				return _borrowerrequestedloanamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the lendercaseidentifier.
		/// </summary>
		internal System.String _lendercaseidentifier;
		/// <summary>
		/// Gets and sets the LenderCaseIdentifier value of the class instance.
		/// </summary>
		public virtual System.String LenderCaseIdentifier
		{
			get
			{
				return _lendercaseidentifier;
			}
			set
			{
				_lendercaseidentifier = value;
			}
		}


		/// <summary>
		/// Checks the LenderCaseIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean LenderCaseIdentifierIsNull
		{
			get
			{
				return (_lendercaseidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanamortizationtermmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the loanamortizationtermmonths.
		/// </summary>
		internal System.Decimal _loanamortizationtermmonths;
		/// <summary>
		/// Gets and sets the LoanAmortizationTermMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal LoanAmortizationTermMonths
		{
			get
			{
				return _loanamortizationtermmonths;
			}
			set
			{
				_loanamortizationtermmonths = value;
				_loanamortizationtermmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanAmortizationTermMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanAmortizationTermMonthsIsNull
		{
			get
			{
				return _loanamortizationtermmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the othermortgagetypedescription.
		/// </summary>
		internal System.String _othermortgagetypedescription;
		/// <summary>
		/// Gets and sets the OtherMortgageTypeDescription value of the class instance.
		/// </summary>
		public virtual System.String OtherMortgageTypeDescription
		{
			get
			{
				return _othermortgagetypedescription;
			}
			set
			{
				_othermortgagetypedescription = value;
			}
		}


		/// <summary>
		/// Checks the OtherMortgageTypeDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherMortgageTypeDescriptionIsNull
		{
			get
			{
				return (_othermortgagetypedescription == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the otheramortizationtypedescription.
		/// </summary>
		internal System.String _otheramortizationtypedescription;
		/// <summary>
		/// Gets and sets the OtherAmortizationTypeDescription value of the class instance.
		/// </summary>
		public virtual System.String OtherAmortizationTypeDescription
		{
			get
			{
				return _otheramortizationtypedescription;
			}
			set
			{
				_otheramortizationtypedescription = value;
			}
		}


		/// <summary>
		/// Checks the OtherAmortizationTypeDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherAmortizationTypeDescriptionIsNull
		{
			get
			{
				return (_otheramortizationtypedescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _requestedinterestratepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the requestedinterestratepercent.
		/// </summary>
		internal System.Decimal _requestedinterestratepercent;
		/// <summary>
		/// Gets and sets the RequestedInterestRatePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal RequestedInterestRatePercent
		{
			get
			{
				return _requestedinterestratepercent;
			}
			set
			{
				_requestedinterestratepercent = value;
				_requestedinterestratepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RequestedInterestRatePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean RequestedInterestRatePercentIsNull
		{
			get
			{
				return _requestedinterestratepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanamortizationtype_isnull = true;
		/// <summary>
		/// Member that stores the value for the loanamortizationtype.
		/// </summary>
		internal System.Int16 _loanamortizationtype;
		/// <summary>
		/// Gets and sets the LoanAmortizationType value of the class instance.
		/// </summary>
		public virtual System.Int16 LoanAmortizationType
		{
			get
			{
				return _loanamortizationtype;
			}
			set
			{
				_loanamortizationtype = value;
				_loanamortizationtype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanAmortizationType value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanAmortizationTypeIsNull
		{
			get
			{
				return _loanamortizationtype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _mortgagetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the mortgagetype.
		/// </summary>
		internal System.Int16 _mortgagetype;
		/// <summary>
		/// Gets and sets the MortgageType value of the class instance.
		/// </summary>
		public virtual System.Int16 MortgageType
		{
			get
			{
				return _mortgagetype;
			}
			set
			{
				_mortgagetype = value;
				_mortgagetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MortgageType value to see if it was set to null.
		/// </summary>
		public System.Boolean MortgageTypeIsNull
		{
			get
			{
				return _mortgagetype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the MortgageTermsBase.
		/// </summary>
		internal static MortgageTermsService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(MortgageTermsService)) as MortgageTermsService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of MortgageTermsBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the AgencyCaseIdentifier value as null.
		/// </summary>
		public virtual void SetAgencyCaseIdentifierNull()
		{
			_agencycaseidentifier = null;
		}


		/// <summary>
		/// Marks the ARMTypeDescription value as null.
		/// </summary>
		public virtual void SetARMTypeDescriptionNull()
		{
			_armtypedescription = null;
		}


		/// <summary>
		/// Marks the BaseLoanAmount value as null.
		/// </summary>
		public virtual void SetBaseLoanAmountNull()
		{
			_baseloanamount = 0;
			_baseloanamount_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerRequestedLoanAmount value as null.
		/// </summary>
		public virtual void SetBorrowerRequestedLoanAmountNull()
		{
			_borrowerrequestedloanamount = 0;
			_borrowerrequestedloanamount_isnull = true;
		}


		/// <summary>
		/// Marks the LenderCaseIdentifier value as null.
		/// </summary>
		public virtual void SetLenderCaseIdentifierNull()
		{
			_lendercaseidentifier = null;
		}


		/// <summary>
		/// Marks the LoanAmortizationTermMonths value as null.
		/// </summary>
		public virtual void SetLoanAmortizationTermMonthsNull()
		{
			_loanamortizationtermmonths = 0;
			_loanamortizationtermmonths_isnull = true;
		}


		/// <summary>
		/// Marks the OtherMortgageTypeDescription value as null.
		/// </summary>
		public virtual void SetOtherMortgageTypeDescriptionNull()
		{
			_othermortgagetypedescription = null;
		}


		/// <summary>
		/// Marks the OtherAmortizationTypeDescription value as null.
		/// </summary>
		public virtual void SetOtherAmortizationTypeDescriptionNull()
		{
			_otheramortizationtypedescription = null;
		}


		/// <summary>
		/// Marks the RequestedInterestRatePercent value as null.
		/// </summary>
		public virtual void SetRequestedInterestRatePercentNull()
		{
			_requestedinterestratepercent = 0;
			_requestedinterestratepercent_isnull = true;
		}


		/// <summary>
		/// Marks the LoanAmortizationType value as null.
		/// </summary>
		public virtual void SetLoanAmortizationTypeNull()
		{
			_loanamortizationtype = 0;
			_loanamortizationtype_isnull = true;
		}


		/// <summary>
		/// Marks the MortgageType value as null.
		/// </summary>
		public virtual void SetMortgageTypeNull()
		{
			_mortgagetype = 0;
			_mortgagetype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref MortgageTermsBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the AgencyCaseIdentifier data to the class member
			_agencycaseidentifier = data._agencycaseidentifier;
			// assigns the ARMTypeDescription data to the class member
			_armtypedescription = data._armtypedescription;
			// assigns the BaseLoanAmount data to the class member
			_baseloanamount = data._baseloanamount;
			_baseloanamount_isnull = data._baseloanamount_isnull;
			// assigns the BorrowerRequestedLoanAmount data to the class member
			_borrowerrequestedloanamount = data._borrowerrequestedloanamount;
			_borrowerrequestedloanamount_isnull = data._borrowerrequestedloanamount_isnull;
			// assigns the LenderCaseIdentifier data to the class member
			_lendercaseidentifier = data._lendercaseidentifier;
			// assigns the LoanAmortizationTermMonths data to the class member
			_loanamortizationtermmonths = data._loanamortizationtermmonths;
			_loanamortizationtermmonths_isnull = data._loanamortizationtermmonths_isnull;
			// assigns the OtherMortgageTypeDescription data to the class member
			_othermortgagetypedescription = data._othermortgagetypedescription;
			// assigns the OtherAmortizationTypeDescription data to the class member
			_otheramortizationtypedescription = data._otheramortizationtypedescription;
			// assigns the RequestedInterestRatePercent data to the class member
			_requestedinterestratepercent = data._requestedinterestratepercent;
			_requestedinterestratepercent_isnull = data._requestedinterestratepercent_isnull;
			// assigns the LoanAmortizationType data to the class member
			_loanamortizationtype = data._loanamortizationtype;
			_loanamortizationtype_isnull = data._loanamortizationtype_isnull;
			// assigns the MortgageType data to the class member
			_mortgagetype = data._mortgagetype;
			_mortgagetype_isnull = data._mortgagetype_isnull;


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
			// assigns the AgencyCaseIdentifier data to the class member
			if (data["AgencyCaseIdentifier"] == System.DBNull.Value)
				SetAgencyCaseIdentifierNull();
			else
			{
				_agencycaseidentifier = Convert.ToString(data["AgencyCaseIdentifier"]);
			}
			// assigns the ARMTypeDescription data to the class member
			if (data["ARMTypeDescription"] == System.DBNull.Value)
				SetARMTypeDescriptionNull();
			else
			{
				_armtypedescription = Convert.ToString(data["ARMTypeDescription"]);
			}
			// assigns the BaseLoanAmount data to the class member
			if (data["BaseLoanAmount"] == System.DBNull.Value)
				SetBaseLoanAmountNull();
			else
			{
				_baseloanamount = Convert.ToDecimal(data["BaseLoanAmount"]);
				_baseloanamount_isnull = false;
			}
			// assigns the BorrowerRequestedLoanAmount data to the class member
			if (data["BorrowerRequestedLoanAmount"] == System.DBNull.Value)
				SetBorrowerRequestedLoanAmountNull();
			else
			{
				_borrowerrequestedloanamount = Convert.ToDecimal(data["BorrowerRequestedLoanAmount"]);
				_borrowerrequestedloanamount_isnull = false;
			}
			// assigns the LenderCaseIdentifier data to the class member
			if (data["LenderCaseIdentifier"] == System.DBNull.Value)
				SetLenderCaseIdentifierNull();
			else
			{
				_lendercaseidentifier = Convert.ToString(data["LenderCaseIdentifier"]);
			}
			// assigns the LoanAmortizationTermMonths data to the class member
			if (data["LoanAmortizationTermMonths"] == System.DBNull.Value)
				SetLoanAmortizationTermMonthsNull();
			else
			{
				_loanamortizationtermmonths = Convert.ToDecimal(data["LoanAmortizationTermMonths"]);
				_loanamortizationtermmonths_isnull = false;
			}
			// assigns the OtherMortgageTypeDescription data to the class member
			if (data["OtherMortgageTypeDescription"] == System.DBNull.Value)
				SetOtherMortgageTypeDescriptionNull();
			else
			{
				_othermortgagetypedescription = Convert.ToString(data["OtherMortgageTypeDescription"]);
			}
			// assigns the OtherAmortizationTypeDescription data to the class member
			if (data["OtherAmortizationTypeDescription"] == System.DBNull.Value)
				SetOtherAmortizationTypeDescriptionNull();
			else
			{
				_otheramortizationtypedescription = Convert.ToString(data["OtherAmortizationTypeDescription"]);
			}
			// assigns the RequestedInterestRatePercent data to the class member
			if (data["RequestedInterestRatePercent"] == System.DBNull.Value)
				SetRequestedInterestRatePercentNull();
			else
			{
				_requestedinterestratepercent = Convert.ToDecimal(data["RequestedInterestRatePercent"]);
				_requestedinterestratepercent_isnull = false;
			}
			// assigns the LoanAmortizationType data to the class member
			if (data["LoanAmortizationType"] == System.DBNull.Value)
				SetLoanAmortizationTypeNull();
			else
			{
				_loanamortizationtype = Convert.ToInt16(data["LoanAmortizationType"]);
				_loanamortizationtype_isnull = false;
			}
			// assigns the MortgageType data to the class member
			if (data["MortgageType"] == System.DBNull.Value)
				SetMortgageTypeNull();
			else
			{
				_mortgagetype = Convert.ToInt16(data["MortgageType"]);
				_mortgagetype_isnull = false;
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
			// assigns the AgencyCaseIdentifier data to the class member
			if (data["AgencyCaseIdentifier"] == System.DBNull.Value)
				SetAgencyCaseIdentifierNull();
			else
			{
				_agencycaseidentifier = Convert.ToString(data["AgencyCaseIdentifier"]);
			}
			// assigns the ARMTypeDescription data to the class member
			if (data["ARMTypeDescription"] == System.DBNull.Value)
				SetARMTypeDescriptionNull();
			else
			{
				_armtypedescription = Convert.ToString(data["ARMTypeDescription"]);
			}
			// assigns the BaseLoanAmount data to the class member
			if (data["BaseLoanAmount"] == System.DBNull.Value)
				SetBaseLoanAmountNull();
			else
			{
				_baseloanamount = Convert.ToDecimal(data["BaseLoanAmount"]);
				_baseloanamount_isnull = false;
			}
			// assigns the BorrowerRequestedLoanAmount data to the class member
			if (data["BorrowerRequestedLoanAmount"] == System.DBNull.Value)
				SetBorrowerRequestedLoanAmountNull();
			else
			{
				_borrowerrequestedloanamount = Convert.ToDecimal(data["BorrowerRequestedLoanAmount"]);
				_borrowerrequestedloanamount_isnull = false;
			}
			// assigns the LenderCaseIdentifier data to the class member
			if (data["LenderCaseIdentifier"] == System.DBNull.Value)
				SetLenderCaseIdentifierNull();
			else
			{
				_lendercaseidentifier = Convert.ToString(data["LenderCaseIdentifier"]);
			}
			// assigns the LoanAmortizationTermMonths data to the class member
			if (data["LoanAmortizationTermMonths"] == System.DBNull.Value)
				SetLoanAmortizationTermMonthsNull();
			else
			{
				_loanamortizationtermmonths = Convert.ToDecimal(data["LoanAmortizationTermMonths"]);
				_loanamortizationtermmonths_isnull = false;
			}
			// assigns the OtherMortgageTypeDescription data to the class member
			if (data["OtherMortgageTypeDescription"] == System.DBNull.Value)
				SetOtherMortgageTypeDescriptionNull();
			else
			{
				_othermortgagetypedescription = Convert.ToString(data["OtherMortgageTypeDescription"]);
			}
			// assigns the OtherAmortizationTypeDescription data to the class member
			if (data["OtherAmortizationTypeDescription"] == System.DBNull.Value)
				SetOtherAmortizationTypeDescriptionNull();
			else
			{
				_otheramortizationtypedescription = Convert.ToString(data["OtherAmortizationTypeDescription"]);
			}
			// assigns the RequestedInterestRatePercent data to the class member
			if (data["RequestedInterestRatePercent"] == System.DBNull.Value)
				SetRequestedInterestRatePercentNull();
			else
			{
				_requestedinterestratepercent = Convert.ToDecimal(data["RequestedInterestRatePercent"]);
				_requestedinterestratepercent_isnull = false;
			}
			// assigns the LoanAmortizationType data to the class member
			if (data["LoanAmortizationType"] == System.DBNull.Value)
				SetLoanAmortizationTypeNull();
			else
			{
				_loanamortizationtype = Convert.ToInt16(data["LoanAmortizationType"]);
				_loanamortizationtype_isnull = false;
			}
			// assigns the MortgageType data to the class member
			if (data["MortgageType"] == System.DBNull.Value)
				SetMortgageTypeNull();
			else
			{
				_mortgagetype = Convert.ToInt16(data["MortgageType"]);
				_mortgagetype_isnull = false;
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
			MortgageTermsBase.ServiceObject.Persist(this as MortgageTerms, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the MORTGAGE_TERMS object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			MortgageTermsBase.ServiceObject.Delete(this as MortgageTerms);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the LoanAmortizationType relationship.
		/// </summary>
		public LoanAmortizationType GetLoanAmortizationType()
		{
			if (_loanamortizationtype_isnull)
				return null;
			else
				return new LoanAmortizationType(_loanamortizationtype);
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
		/// Gets the single object for the MortgageType relationship.
		/// </summary>
		public MortgageType GetMortgageType()
		{
			if (_mortgagetype_isnull)
				return null;
			else
				return new MortgageType(_mortgagetype);
		}


		/// <summary>
		/// Gets all persisted MortgageTerms objects
		/// </summary>
		public static MortgageTermsCollection GetAll()
		{
			// have the service object get the objects
			return MortgageTermsBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
