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
	/// A class that represents an abstract entity for table 'LIABILITY'
	/// </summary>
	[Serializable]
	public abstract class LiabilityBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LiabilityBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Liability)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LiabilityBase(System.Int64 id)
		{
			// Fill this instance.
			LiabilityBase.ServiceObject.Fill(this as Liability, id);
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
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _borrowerid_assigned = false;
		/// <summary>
		/// Member that stores the value for the borrowerid.
		/// </summary>
		internal System.Int64 _borrowerid;
		/// <summary>
		/// Gets and sets the BorrowerId value of the class instance.
		/// </summary>
		public virtual System.Int64 BorrowerId
		{
			get
			{
				return _borrowerid;
			}
			set
			{
				_borrowerid = value;
				_borrowerid_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the reo_id.
		/// </summary>
		internal System.String _reo_id;
		/// <summary>
		/// Gets and sets the REO_ID value of the class instance.
		/// </summary>
		public virtual System.String REO_ID
		{
			get
			{
				return _reo_id;
			}
			set
			{
				_reo_id = value;
			}
		}


		/// <summary>
		/// Checks the REO_ID value to see if it was set to null.
		/// </summary>
		public System.Boolean REO_IDIsNull
		{
			get
			{
				return (_reo_id == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the holderstreetaddress.
		/// </summary>
		internal System.String _holderstreetaddress;
		/// <summary>
		/// Gets and sets the HolderStreetAddress value of the class instance.
		/// </summary>
		public virtual System.String HolderStreetAddress
		{
			get
			{
				return _holderstreetaddress;
			}
			set
			{
				_holderstreetaddress = value;
			}
		}


		/// <summary>
		/// Checks the HolderStreetAddress value to see if it was set to null.
		/// </summary>
		public System.Boolean HolderStreetAddressIsNull
		{
			get
			{
				return (_holderstreetaddress == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the holdercity.
		/// </summary>
		internal System.String _holdercity;
		/// <summary>
		/// Gets and sets the HolderCity value of the class instance.
		/// </summary>
		public virtual System.String HolderCity
		{
			get
			{
				return _holdercity;
			}
			set
			{
				_holdercity = value;
			}
		}


		/// <summary>
		/// Checks the HolderCity value to see if it was set to null.
		/// </summary>
		public System.Boolean HolderCityIsNull
		{
			get
			{
				return (_holdercity == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the holderstate.
		/// </summary>
		internal System.String _holderstate;
		/// <summary>
		/// Gets and sets the HolderState value of the class instance.
		/// </summary>
		public virtual System.String HolderState
		{
			get
			{
				return _holderstate;
			}
			set
			{
				_holderstate = value;
			}
		}


		/// <summary>
		/// Checks the HolderState value to see if it was set to null.
		/// </summary>
		public System.Boolean HolderStateIsNull
		{
			get
			{
				return (_holderstate == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the holderpostalcode.
		/// </summary>
		internal System.String _holderpostalcode;
		/// <summary>
		/// Gets and sets the HolderPostalCode value of the class instance.
		/// </summary>
		public virtual System.String HolderPostalCode
		{
			get
			{
				return _holderpostalcode;
			}
			set
			{
				_holderpostalcode = value;
			}
		}


		/// <summary>
		/// Checks the HolderPostalCode value to see if it was set to null.
		/// </summary>
		public System.Boolean HolderPostalCodeIsNull
		{
			get
			{
				return (_holderpostalcode == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the alimonyowedtoname.
		/// </summary>
		internal System.String _alimonyowedtoname;
		/// <summary>
		/// Gets and sets the AlimonyOwedToName value of the class instance.
		/// </summary>
		public virtual System.String AlimonyOwedToName
		{
			get
			{
				return _alimonyowedtoname;
			}
			set
			{
				_alimonyowedtoname = value;
			}
		}


		/// <summary>
		/// Checks the AlimonyOwedToName value to see if it was set to null.
		/// </summary>
		public System.Boolean AlimonyOwedToNameIsNull
		{
			get
			{
				return (_alimonyowedtoname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the accountidentifier.
		/// </summary>
		internal System.String _accountidentifier;
		/// <summary>
		/// Gets and sets the AccountIdentifier value of the class instance.
		/// </summary>
		public virtual System.String AccountIdentifier
		{
			get
			{
				return _accountidentifier;
			}
			set
			{
				_accountidentifier = value;
			}
		}


		/// <summary>
		/// Checks the AccountIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean AccountIdentifierIsNull
		{
			get
			{
				return (_accountidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _exclusionindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the exclusionindicator.
		/// </summary>
		internal System.Boolean _exclusionindicator;
		/// <summary>
		/// Gets and sets the ExclusionIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean ExclusionIndicator
		{
			get
			{
				return _exclusionindicator;
			}
			set
			{
				_exclusionindicator = value;
				_exclusionindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the holdername.
		/// </summary>
		internal System.String _holdername;
		/// <summary>
		/// Gets and sets the HolderName value of the class instance.
		/// </summary>
		public virtual System.String HolderName
		{
			get
			{
				return _holdername;
			}
			set
			{
				_holdername = value;
			}
		}


		/// <summary>
		/// Checks the HolderName value to see if it was set to null.
		/// </summary>
		public System.Boolean HolderNameIsNull
		{
			get
			{
				return (_holdername == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _monthlypaymentamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the monthlypaymentamount.
		/// </summary>
		internal System.Decimal _monthlypaymentamount;
		/// <summary>
		/// Gets and sets the MonthlyPaymentAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal MonthlyPaymentAmount
		{
			get
			{
				return _monthlypaymentamount;
			}
			set
			{
				_monthlypaymentamount = value;
				_monthlypaymentamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MonthlyPaymentAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean MonthlyPaymentAmountIsNull
		{
			get
			{
				return _monthlypaymentamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _payoffstatusindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the payoffstatusindicator.
		/// </summary>
		internal System.Boolean _payoffstatusindicator;
		/// <summary>
		/// Gets and sets the PayoffStatusIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PayoffStatusIndicator
		{
			get
			{
				return _payoffstatusindicator;
			}
			set
			{
				_payoffstatusindicator = value;
				_payoffstatusindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _payoffwithcurrentassetsindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the payoffwithcurrentassetsindicator.
		/// </summary>
		internal System.Boolean _payoffwithcurrentassetsindicator;
		/// <summary>
		/// Gets and sets the PayoffWithCurrentAssetsIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PayoffWithCurrentAssetsIndicator
		{
			get
			{
				return _payoffwithcurrentassetsindicator;
			}
			set
			{
				_payoffwithcurrentassetsindicator = value;
				_payoffwithcurrentassetsindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _remainingtermmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the remainingtermmonths.
		/// </summary>
		internal System.Decimal _remainingtermmonths;
		/// <summary>
		/// Gets and sets the RemainingTermMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal RemainingTermMonths
		{
			get
			{
				return _remainingtermmonths;
			}
			set
			{
				_remainingtermmonths = value;
				_remainingtermmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RemainingTermMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean RemainingTermMonthsIsNull
		{
			get
			{
				return _remainingtermmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _type_assigned = false;
		/// <summary>
		/// Member that stores the value for the type.
		/// </summary>
		internal System.Int16 _type;
		/// <summary>
		/// Gets and sets the Type value of the class instance.
		/// </summary>
		public virtual System.Int16 Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
				_type_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _unpaidbalanceamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the unpaidbalanceamount.
		/// </summary>
		internal System.Decimal _unpaidbalanceamount;
		/// <summary>
		/// Gets and sets the UnpaidBalanceAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal UnpaidBalanceAmount
		{
			get
			{
				return _unpaidbalanceamount;
			}
			set
			{
				_unpaidbalanceamount = value;
				_unpaidbalanceamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the UnpaidBalanceAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean UnpaidBalanceAmountIsNull
		{
			get
			{
				return _unpaidbalanceamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _subjectloanresubordinationindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the subjectloanresubordinationindicator.
		/// </summary>
		internal System.Boolean _subjectloanresubordinationindicator;
		/// <summary>
		/// Gets and sets the SubjectLoanResubordinationIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean SubjectLoanResubordinationIndicator
		{
			get
			{
				return _subjectloanresubordinationindicator;
			}
			set
			{
				_subjectloanresubordinationindicator = value;
				_subjectloanresubordinationindicator_assigned = true;
			}
		}


		/// <summary>
		/// Gets the service object for the LiabilityBase.
		/// </summary>
		internal static LiabilityService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(LiabilityService)) as LiabilityService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of LiabilityBase. The value has not been explicitly assigned.", exceptions);
				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of LiabilityBase. The value has not been explicitly assigned.", exceptions);
				if (!_type_assigned) exceptions = BusinessLogic.ChainException("Type is a required value of LiabilityBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the REO_ID value as null.
		/// </summary>
		public virtual void SetREO_IDNull()
		{
			_reo_id = null;
		}


		/// <summary>
		/// Marks the HolderStreetAddress value as null.
		/// </summary>
		public virtual void SetHolderStreetAddressNull()
		{
			_holderstreetaddress = null;
		}


		/// <summary>
		/// Marks the HolderCity value as null.
		/// </summary>
		public virtual void SetHolderCityNull()
		{
			_holdercity = null;
		}


		/// <summary>
		/// Marks the HolderState value as null.
		/// </summary>
		public virtual void SetHolderStateNull()
		{
			_holderstate = null;
		}


		/// <summary>
		/// Marks the HolderPostalCode value as null.
		/// </summary>
		public virtual void SetHolderPostalCodeNull()
		{
			_holderpostalcode = null;
		}


		/// <summary>
		/// Marks the AlimonyOwedToName value as null.
		/// </summary>
		public virtual void SetAlimonyOwedToNameNull()
		{
			_alimonyowedtoname = null;
		}


		/// <summary>
		/// Marks the AccountIdentifier value as null.
		/// </summary>
		public virtual void SetAccountIdentifierNull()
		{
			_accountidentifier = null;
		}


		/// <summary>
		/// Marks the HolderName value as null.
		/// </summary>
		public virtual void SetHolderNameNull()
		{
			_holdername = null;
		}


		/// <summary>
		/// Marks the MonthlyPaymentAmount value as null.
		/// </summary>
		public virtual void SetMonthlyPaymentAmountNull()
		{
			_monthlypaymentamount = 0;
			_monthlypaymentamount_isnull = true;
		}


		/// <summary>
		/// Marks the RemainingTermMonths value as null.
		/// </summary>
		public virtual void SetRemainingTermMonthsNull()
		{
			_remainingtermmonths = 0;
			_remainingtermmonths_isnull = true;
		}


		/// <summary>
		/// Marks the UnpaidBalanceAmount value as null.
		/// </summary>
		public virtual void SetUnpaidBalanceAmountNull()
		{
			_unpaidbalanceamount = 0;
			_unpaidbalanceamount_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref LiabilityBase data)
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
			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the REO_ID data to the class member
			_reo_id = data._reo_id;
			// assigns the HolderStreetAddress data to the class member
			_holderstreetaddress = data._holderstreetaddress;
			// assigns the HolderCity data to the class member
			_holdercity = data._holdercity;
			// assigns the HolderState data to the class member
			_holderstate = data._holderstate;
			// assigns the HolderPostalCode data to the class member
			_holderpostalcode = data._holderpostalcode;
			// assigns the AlimonyOwedToName data to the class member
			_alimonyowedtoname = data._alimonyowedtoname;
			// assigns the AccountIdentifier data to the class member
			_accountidentifier = data._accountidentifier;
			// assigns the ExclusionIndicator data to the class member
			_exclusionindicator = data._exclusionindicator;
			_exclusionindicator_assigned = data._exclusionindicator_assigned;
			// assigns the HolderName data to the class member
			_holdername = data._holdername;
			// assigns the MonthlyPaymentAmount data to the class member
			_monthlypaymentamount = data._monthlypaymentamount;
			_monthlypaymentamount_isnull = data._monthlypaymentamount_isnull;
			// assigns the PayoffStatusIndicator data to the class member
			_payoffstatusindicator = data._payoffstatusindicator;
			_payoffstatusindicator_assigned = data._payoffstatusindicator_assigned;
			// assigns the PayoffWithCurrentAssetsIndicator data to the class member
			_payoffwithcurrentassetsindicator = data._payoffwithcurrentassetsindicator;
			_payoffwithcurrentassetsindicator_assigned = data._payoffwithcurrentassetsindicator_assigned;
			// assigns the RemainingTermMonths data to the class member
			_remainingtermmonths = data._remainingtermmonths;
			_remainingtermmonths_isnull = data._remainingtermmonths_isnull;
			// assigns the Type data to the class member
			_type = data._type;
			_type_assigned = data._type_assigned;
			// assigns the UnpaidBalanceAmount data to the class member
			_unpaidbalanceamount = data._unpaidbalanceamount;
			_unpaidbalanceamount_isnull = data._unpaidbalanceamount_isnull;
			// assigns the SubjectLoanResubordinationIndicator data to the class member
			_subjectloanresubordinationindicator = data._subjectloanresubordinationindicator;
			_subjectloanresubordinationindicator_assigned = data._subjectloanresubordinationindicator_assigned;


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
			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the REO_ID data to the class member
			if (data["REO_ID"] == System.DBNull.Value)
				SetREO_IDNull();
			else
			{
				_reo_id = Convert.ToString(data["REO_ID"]);
			}
			// assigns the HolderStreetAddress data to the class member
			if (data["HolderStreetAddress"] == System.DBNull.Value)
				SetHolderStreetAddressNull();
			else
			{
				_holderstreetaddress = Convert.ToString(data["HolderStreetAddress"]);
			}
			// assigns the HolderCity data to the class member
			if (data["HolderCity"] == System.DBNull.Value)
				SetHolderCityNull();
			else
			{
				_holdercity = Convert.ToString(data["HolderCity"]);
			}
			// assigns the HolderState data to the class member
			if (data["HolderState"] == System.DBNull.Value)
				SetHolderStateNull();
			else
			{
				_holderstate = Convert.ToString(data["HolderState"]);
			}
			// assigns the HolderPostalCode data to the class member
			if (data["HolderPostalCode"] == System.DBNull.Value)
				SetHolderPostalCodeNull();
			else
			{
				_holderpostalcode = Convert.ToString(data["HolderPostalCode"]);
			}
			// assigns the AlimonyOwedToName data to the class member
			if (data["AlimonyOwedToName"] == System.DBNull.Value)
				SetAlimonyOwedToNameNull();
			else
			{
				_alimonyowedtoname = Convert.ToString(data["AlimonyOwedToName"]);
			}
			// assigns the AccountIdentifier data to the class member
			if (data["AccountIdentifier"] == System.DBNull.Value)
				SetAccountIdentifierNull();
			else
			{
				_accountidentifier = Convert.ToString(data["AccountIdentifier"]);
			}
			// assigns the ExclusionIndicator data to the class member
			_exclusionindicator = Convert.ToBoolean(data["ExclusionIndicator"]);
			_exclusionindicator_assigned = true;
			// assigns the HolderName data to the class member
			if (data["HolderName"] == System.DBNull.Value)
				SetHolderNameNull();
			else
			{
				_holdername = Convert.ToString(data["HolderName"]);
			}
			// assigns the MonthlyPaymentAmount data to the class member
			if (data["MonthlyPaymentAmount"] == System.DBNull.Value)
				SetMonthlyPaymentAmountNull();
			else
			{
				_monthlypaymentamount = Convert.ToDecimal(data["MonthlyPaymentAmount"]);
				_monthlypaymentamount_isnull = false;
			}
			// assigns the PayoffStatusIndicator data to the class member
			_payoffstatusindicator = Convert.ToBoolean(data["PayoffStatusIndicator"]);
			_payoffstatusindicator_assigned = true;
			// assigns the PayoffWithCurrentAssetsIndicator data to the class member
			_payoffwithcurrentassetsindicator = Convert.ToBoolean(data["PayoffWithCurrentAssetsIndicator"]);
			_payoffwithcurrentassetsindicator_assigned = true;
			// assigns the RemainingTermMonths data to the class member
			if (data["RemainingTermMonths"] == System.DBNull.Value)
				SetRemainingTermMonthsNull();
			else
			{
				_remainingtermmonths = Convert.ToDecimal(data["RemainingTermMonths"]);
				_remainingtermmonths_isnull = false;
			}
			// assigns the Type data to the class member
			_type = Convert.ToInt16(data["Type"]);
			_type_assigned = true;
			// assigns the UnpaidBalanceAmount data to the class member
			if (data["UnpaidBalanceAmount"] == System.DBNull.Value)
				SetUnpaidBalanceAmountNull();
			else
			{
				_unpaidbalanceamount = Convert.ToDecimal(data["UnpaidBalanceAmount"]);
				_unpaidbalanceamount_isnull = false;
			}
			// assigns the SubjectLoanResubordinationIndicator data to the class member
			_subjectloanresubordinationindicator = Convert.ToBoolean(data["SubjectLoanResubordinationIndicator"]);
			_subjectloanresubordinationindicator_assigned = true;


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
			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the REO_ID data to the class member
			if (data["REO_ID"] == System.DBNull.Value)
				SetREO_IDNull();
			else
			{
				_reo_id = Convert.ToString(data["REO_ID"]);
			}
			// assigns the HolderStreetAddress data to the class member
			if (data["HolderStreetAddress"] == System.DBNull.Value)
				SetHolderStreetAddressNull();
			else
			{
				_holderstreetaddress = Convert.ToString(data["HolderStreetAddress"]);
			}
			// assigns the HolderCity data to the class member
			if (data["HolderCity"] == System.DBNull.Value)
				SetHolderCityNull();
			else
			{
				_holdercity = Convert.ToString(data["HolderCity"]);
			}
			// assigns the HolderState data to the class member
			if (data["HolderState"] == System.DBNull.Value)
				SetHolderStateNull();
			else
			{
				_holderstate = Convert.ToString(data["HolderState"]);
			}
			// assigns the HolderPostalCode data to the class member
			if (data["HolderPostalCode"] == System.DBNull.Value)
				SetHolderPostalCodeNull();
			else
			{
				_holderpostalcode = Convert.ToString(data["HolderPostalCode"]);
			}
			// assigns the AlimonyOwedToName data to the class member
			if (data["AlimonyOwedToName"] == System.DBNull.Value)
				SetAlimonyOwedToNameNull();
			else
			{
				_alimonyowedtoname = Convert.ToString(data["AlimonyOwedToName"]);
			}
			// assigns the AccountIdentifier data to the class member
			if (data["AccountIdentifier"] == System.DBNull.Value)
				SetAccountIdentifierNull();
			else
			{
				_accountidentifier = Convert.ToString(data["AccountIdentifier"]);
			}
			// assigns the ExclusionIndicator data to the class member
			_exclusionindicator = Convert.ToBoolean(data["ExclusionIndicator"]);
			_exclusionindicator_assigned = true;
			// assigns the HolderName data to the class member
			if (data["HolderName"] == System.DBNull.Value)
				SetHolderNameNull();
			else
			{
				_holdername = Convert.ToString(data["HolderName"]);
			}
			// assigns the MonthlyPaymentAmount data to the class member
			if (data["MonthlyPaymentAmount"] == System.DBNull.Value)
				SetMonthlyPaymentAmountNull();
			else
			{
				_monthlypaymentamount = Convert.ToDecimal(data["MonthlyPaymentAmount"]);
				_monthlypaymentamount_isnull = false;
			}
			// assigns the PayoffStatusIndicator data to the class member
			_payoffstatusindicator = Convert.ToBoolean(data["PayoffStatusIndicator"]);
			_payoffstatusindicator_assigned = true;
			// assigns the PayoffWithCurrentAssetsIndicator data to the class member
			_payoffwithcurrentassetsindicator = Convert.ToBoolean(data["PayoffWithCurrentAssetsIndicator"]);
			_payoffwithcurrentassetsindicator_assigned = true;
			// assigns the RemainingTermMonths data to the class member
			if (data["RemainingTermMonths"] == System.DBNull.Value)
				SetRemainingTermMonthsNull();
			else
			{
				_remainingtermmonths = Convert.ToDecimal(data["RemainingTermMonths"]);
				_remainingtermmonths_isnull = false;
			}
			// assigns the Type data to the class member
			_type = Convert.ToInt16(data["Type"]);
			_type_assigned = true;
			// assigns the UnpaidBalanceAmount data to the class member
			if (data["UnpaidBalanceAmount"] == System.DBNull.Value)
				SetUnpaidBalanceAmountNull();
			else
			{
				_unpaidbalanceamount = Convert.ToDecimal(data["UnpaidBalanceAmount"]);
				_unpaidbalanceamount_isnull = false;
			}
			// assigns the SubjectLoanResubordinationIndicator data to the class member
			_subjectloanresubordinationindicator = Convert.ToBoolean(data["SubjectLoanResubordinationIndicator"]);
			_subjectloanresubordinationindicator_assigned = true;


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
			LiabilityBase.ServiceObject.Persist(this as Liability, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the LIABILITY object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			LiabilityBase.ServiceObject.Delete(this as Liability);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the REO_PROPERTY relationship.
		/// </summary>
		public REOProperties GetREOProperties()
		{
			REOProperties reoproperties = new REOProperties();


			REOPropertyBase.ServiceObject.FillByLiability(reoproperties, _id);
			return reoproperties;
		}


		/// <summary>
		/// Gets the single object for the BORROWER relationship.
		/// </summary>
		public Borrower GetBorrower()
		{
			if (_borrowerid_assigned)
				return null;
			else
				return new Borrower(_borrowerid);
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
		/// Gets the single object for the LiabilityType relationship.
		/// </summary>
		public LiabilityType GetLiabilityType()
		{
			if (_type_assigned)
				return null;
			else
				return new LiabilityType(_type);
		}


		/// <summary>
		/// Gets all persisted Liability objects
		/// </summary>
		public static Liabilities GetAll()
		{
			// have the service object get the objects
			return LiabilityBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
