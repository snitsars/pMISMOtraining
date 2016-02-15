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
	/// A class that represents an abstract entity for table 'TRANSMITTAL_DATA'
	/// </summary>
	[Serializable]
	public abstract class TransmittalDataBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransmittalDataBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.TransmittalData)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public TransmittalDataBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			TransmittalDataBase.ServiceObject.Fill(this as TransmittalData, loanApplicationId);
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
		internal bool _armslengthindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the armslengthindicator.
		/// </summary>
		internal System.Boolean _armslengthindicator;
		/// <summary>
		/// Gets and sets the ArmsLengthIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean ArmsLengthIndicator
		{
			get
			{
				return _armslengthindicator;
			}
			set
			{
				_armslengthindicator = value;
				_armslengthindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _belowmarketsubordinatefinancingindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the belowmarketsubordinatefinancingindicator.
		/// </summary>
		internal System.Boolean _belowmarketsubordinatefinancingindicator;
		/// <summary>
		/// Gets and sets the BelowMarketSubordinateFinancingIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean BelowMarketSubordinateFinancingIndicator
		{
			get
			{
				return _belowmarketsubordinatefinancingindicator;
			}
			set
			{
				_belowmarketsubordinatefinancingindicator = value;
				_belowmarketsubordinatefinancingindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _buydownratepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the buydownratepercent.
		/// </summary>
		internal System.Decimal _buydownratepercent;
		/// <summary>
		/// Gets and sets the BuydownRatePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal BuydownRatePercent
		{
			get
			{
				return _buydownratepercent;
			}
			set
			{
				_buydownratepercent = value;
				_buydownratepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BuydownRatePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean BuydownRatePercentIsNull
		{
			get
			{
				return _buydownratepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _creditreportauthorizationindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the creditreportauthorizationindicator.
		/// </summary>
		internal System.Boolean _creditreportauthorizationindicator;
		/// <summary>
		/// Gets and sets the CreditReportAuthorizationIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean CreditReportAuthorizationIndicator
		{
			get
			{
				return _creditreportauthorizationindicator;
			}
			set
			{
				_creditreportauthorizationindicator = value;
				_creditreportauthorizationindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the lenderbranchidentifier.
		/// </summary>
		internal System.String _lenderbranchidentifier;
		/// <summary>
		/// Gets and sets the LenderBranchIdentifier value of the class instance.
		/// </summary>
		public virtual System.String LenderBranchIdentifier
		{
			get
			{
				return _lenderbranchidentifier;
			}
			set
			{
				_lenderbranchidentifier = value;
			}
		}


		/// <summary>
		/// Checks the LenderBranchIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean LenderBranchIdentifierIsNull
		{
			get
			{
				return (_lenderbranchidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the lenderregistrationidentifier.
		/// </summary>
		internal System.String _lenderregistrationidentifier;
		/// <summary>
		/// Gets and sets the LenderRegistrationIdentifier value of the class instance.
		/// </summary>
		public virtual System.String LenderRegistrationIdentifier
		{
			get
			{
				return _lenderregistrationidentifier;
			}
			set
			{
				_lenderregistrationidentifier = value;
			}
		}


		/// <summary>
		/// Checks the LenderRegistrationIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean LenderRegistrationIdentifierIsNull
		{
			get
			{
				return (_lenderregistrationidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyappraisedvalueamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyappraisedvalueamount.
		/// </summary>
		internal System.Decimal _propertyappraisedvalueamount;
		/// <summary>
		/// Gets and sets the PropertyAppraisedValueAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PropertyAppraisedValueAmount
		{
			get
			{
				return _propertyappraisedvalueamount;
			}
			set
			{
				_propertyappraisedvalueamount = value;
				_propertyappraisedvalueamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyAppraisedValueAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyAppraisedValueAmountIsNull
		{
			get
			{
				return _propertyappraisedvalueamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyestimatedvalueamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyestimatedvalueamount.
		/// </summary>
		internal System.Decimal _propertyestimatedvalueamount;
		/// <summary>
		/// Gets and sets the PropertyEstimatedValueAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PropertyEstimatedValueAmount
		{
			get
			{
				return _propertyestimatedvalueamount;
			}
			set
			{
				_propertyestimatedvalueamount = value;
				_propertyestimatedvalueamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyEstimatedValueAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyEstimatedValueAmountIsNull
		{
			get
			{
				return _propertyestimatedvalueamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the investorloanidentifier.
		/// </summary>
		internal System.String _investorloanidentifier;
		/// <summary>
		/// Gets and sets the InvestorLoanIdentifier value of the class instance.
		/// </summary>
		public virtual System.String InvestorLoanIdentifier
		{
			get
			{
				return _investorloanidentifier;
			}
			set
			{
				_investorloanidentifier = value;
			}
		}


		/// <summary>
		/// Checks the InvestorLoanIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean InvestorLoanIdentifierIsNull
		{
			get
			{
				return (_investorloanidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the investorinstitutionidentifier.
		/// </summary>
		internal System.String _investorinstitutionidentifier;
		/// <summary>
		/// Gets and sets the InvestorInstitutionIdentifier value of the class instance.
		/// </summary>
		public virtual System.String InvestorInstitutionIdentifier
		{
			get
			{
				return _investorinstitutionidentifier;
			}
			set
			{
				_investorinstitutionidentifier = value;
			}
		}


		/// <summary>
		/// Checks the InvestorInstitutionIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean InvestorInstitutionIdentifierIsNull
		{
			get
			{
				return (_investorinstitutionidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the commitmentreferenceidentifier.
		/// </summary>
		internal System.String _commitmentreferenceidentifier;
		/// <summary>
		/// Gets and sets the CommitmentReferenceIdentifier value of the class instance.
		/// </summary>
		public virtual System.String CommitmentReferenceIdentifier
		{
			get
			{
				return _commitmentreferenceidentifier;
			}
			set
			{
				_commitmentreferenceidentifier = value;
			}
		}


		/// <summary>
		/// Checks the CommitmentReferenceIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean CommitmentReferenceIdentifierIsNull
		{
			get
			{
				return (_commitmentreferenceidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _concurrentoriginationindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the concurrentoriginationindicator.
		/// </summary>
		internal System.Boolean _concurrentoriginationindicator;
		/// <summary>
		/// Gets and sets the ConcurrentOriginationIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean ConcurrentOriginationIndicator
		{
			get
			{
				return _concurrentoriginationindicator;
			}
			set
			{
				_concurrentoriginationindicator = value;
				_concurrentoriginationindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _concurrentoriginationlenderindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the concurrentoriginationlenderindicator.
		/// </summary>
		internal System.Boolean _concurrentoriginationlenderindicator;
		/// <summary>
		/// Gets and sets the ConcurrentOriginationLenderIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean ConcurrentOriginationLenderIndicator
		{
			get
			{
				return _concurrentoriginationlenderindicator;
			}
			set
			{
				_concurrentoriginationlenderindicator = value;
				_concurrentoriginationlenderindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _ratelockperioddays_isnull = true;
		/// <summary>
		/// Member that stores the value for the ratelockperioddays.
		/// </summary>
		internal System.Int16 _ratelockperioddays;
		/// <summary>
		/// Gets and sets the RateLockPeriodDays value of the class instance.
		/// </summary>
		public virtual System.Int16 RateLockPeriodDays
		{
			get
			{
				return _ratelockperioddays;
			}
			set
			{
				_ratelockperioddays = value;
				_ratelockperioddays_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RateLockPeriodDays value to see if it was set to null.
		/// </summary>
		public System.Boolean RateLockPeriodDaysIsNull
		{
			get
			{
				return _ratelockperioddays_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _ratelockrequestedextensiondays_isnull = true;
		/// <summary>
		/// Member that stores the value for the ratelockrequestedextensiondays.
		/// </summary>
		internal System.Int16 _ratelockrequestedextensiondays;
		/// <summary>
		/// Gets and sets the RateLockRequestedExtensionDays value of the class instance.
		/// </summary>
		public virtual System.Int16 RateLockRequestedExtensionDays
		{
			get
			{
				return _ratelockrequestedextensiondays;
			}
			set
			{
				_ratelockrequestedextensiondays = value;
				_ratelockrequestedextensiondays_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RateLockRequestedExtensionDays value to see if it was set to null.
		/// </summary>
		public System.Boolean RateLockRequestedExtensionDaysIsNull
		{
			get
			{
				return _ratelockrequestedextensiondays_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _casestatetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the casestatetype.
		/// </summary>
		internal System.Int16 _casestatetype;
		/// <summary>
		/// Gets and sets the CaseStateType value of the class instance.
		/// </summary>
		public virtual System.Int16 CaseStateType
		{
			get
			{
				return _casestatetype;
			}
			set
			{
				_casestatetype = value;
				_casestatetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CaseStateType value to see if it was set to null.
		/// </summary>
		public System.Boolean CaseStateTypeIsNull
		{
			get
			{
				return _casestatetype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _ratelocktype_isnull = true;
		/// <summary>
		/// Member that stores the value for the ratelocktype.
		/// </summary>
		internal System.Int16 _ratelocktype;
		/// <summary>
		/// Gets and sets the RateLockType value of the class instance.
		/// </summary>
		public virtual System.Int16 RateLockType
		{
			get
			{
				return _ratelocktype;
			}
			set
			{
				_ratelocktype = value;
				_ratelocktype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RateLockType value to see if it was set to null.
		/// </summary>
		public System.Boolean RateLockTypeIsNull
		{
			get
			{
				return _ratelocktype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _currentfirstmortgageholdertype_isnull = true;
		/// <summary>
		/// Member that stores the value for the currentfirstmortgageholdertype.
		/// </summary>
		internal System.Int16 _currentfirstmortgageholdertype;
		/// <summary>
		/// Gets and sets the CurrentFirstMortgageHolderType value of the class instance.
		/// </summary>
		public virtual System.Int16 CurrentFirstMortgageHolderType
		{
			get
			{
				return _currentfirstmortgageholdertype;
			}
			set
			{
				_currentfirstmortgageholdertype = value;
				_currentfirstmortgageholdertype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CurrentFirstMortgageHolderType value to see if it was set to null.
		/// </summary>
		public System.Boolean CurrentFirstMortgageHolderTypeIsNull
		{
			get
			{
				return _currentfirstmortgageholdertype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the TransmittalDataBase.
		/// </summary>
		internal static TransmittalDataService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(TransmittalDataService)) as TransmittalDataService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of TransmittalDataBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the BuydownRatePercent value as null.
		/// </summary>
		public virtual void SetBuydownRatePercentNull()
		{
			_buydownratepercent = 0;
			_buydownratepercent_isnull = true;
		}


		/// <summary>
		/// Marks the LenderBranchIdentifier value as null.
		/// </summary>
		public virtual void SetLenderBranchIdentifierNull()
		{
			_lenderbranchidentifier = null;
		}


		/// <summary>
		/// Marks the LenderRegistrationIdentifier value as null.
		/// </summary>
		public virtual void SetLenderRegistrationIdentifierNull()
		{
			_lenderregistrationidentifier = null;
		}


		/// <summary>
		/// Marks the PropertyAppraisedValueAmount value as null.
		/// </summary>
		public virtual void SetPropertyAppraisedValueAmountNull()
		{
			_propertyappraisedvalueamount = 0;
			_propertyappraisedvalueamount_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyEstimatedValueAmount value as null.
		/// </summary>
		public virtual void SetPropertyEstimatedValueAmountNull()
		{
			_propertyestimatedvalueamount = 0;
			_propertyestimatedvalueamount_isnull = true;
		}


		/// <summary>
		/// Marks the InvestorLoanIdentifier value as null.
		/// </summary>
		public virtual void SetInvestorLoanIdentifierNull()
		{
			_investorloanidentifier = null;
		}


		/// <summary>
		/// Marks the InvestorInstitutionIdentifier value as null.
		/// </summary>
		public virtual void SetInvestorInstitutionIdentifierNull()
		{
			_investorinstitutionidentifier = null;
		}


		/// <summary>
		/// Marks the CommitmentReferenceIdentifier value as null.
		/// </summary>
		public virtual void SetCommitmentReferenceIdentifierNull()
		{
			_commitmentreferenceidentifier = null;
		}


		/// <summary>
		/// Marks the RateLockPeriodDays value as null.
		/// </summary>
		public virtual void SetRateLockPeriodDaysNull()
		{
			_ratelockperioddays = 0;
			_ratelockperioddays_isnull = true;
		}


		/// <summary>
		/// Marks the RateLockRequestedExtensionDays value as null.
		/// </summary>
		public virtual void SetRateLockRequestedExtensionDaysNull()
		{
			_ratelockrequestedextensiondays = 0;
			_ratelockrequestedextensiondays_isnull = true;
		}


		/// <summary>
		/// Marks the CaseStateType value as null.
		/// </summary>
		public virtual void SetCaseStateTypeNull()
		{
			_casestatetype = 0;
			_casestatetype_isnull = true;
		}


		/// <summary>
		/// Marks the RateLockType value as null.
		/// </summary>
		public virtual void SetRateLockTypeNull()
		{
			_ratelocktype = 0;
			_ratelocktype_isnull = true;
		}


		/// <summary>
		/// Marks the CurrentFirstMortgageHolderType value as null.
		/// </summary>
		public virtual void SetCurrentFirstMortgageHolderTypeNull()
		{
			_currentfirstmortgageholdertype = 0;
			_currentfirstmortgageholdertype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref TransmittalDataBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the ArmsLengthIndicator data to the class member
			_armslengthindicator = data._armslengthindicator;
			_armslengthindicator_assigned = data._armslengthindicator_assigned;
			// assigns the BelowMarketSubordinateFinancingIndicator data to the class member
			_belowmarketsubordinatefinancingindicator = data._belowmarketsubordinatefinancingindicator;
			_belowmarketsubordinatefinancingindicator_assigned = data._belowmarketsubordinatefinancingindicator_assigned;
			// assigns the BuydownRatePercent data to the class member
			_buydownratepercent = data._buydownratepercent;
			_buydownratepercent_isnull = data._buydownratepercent_isnull;
			// assigns the CreditReportAuthorizationIndicator data to the class member
			_creditreportauthorizationindicator = data._creditreportauthorizationindicator;
			_creditreportauthorizationindicator_assigned = data._creditreportauthorizationindicator_assigned;
			// assigns the LenderBranchIdentifier data to the class member
			_lenderbranchidentifier = data._lenderbranchidentifier;
			// assigns the LenderRegistrationIdentifier data to the class member
			_lenderregistrationidentifier = data._lenderregistrationidentifier;
			// assigns the PropertyAppraisedValueAmount data to the class member
			_propertyappraisedvalueamount = data._propertyappraisedvalueamount;
			_propertyappraisedvalueamount_isnull = data._propertyappraisedvalueamount_isnull;
			// assigns the PropertyEstimatedValueAmount data to the class member
			_propertyestimatedvalueamount = data._propertyestimatedvalueamount;
			_propertyestimatedvalueamount_isnull = data._propertyestimatedvalueamount_isnull;
			// assigns the InvestorLoanIdentifier data to the class member
			_investorloanidentifier = data._investorloanidentifier;
			// assigns the InvestorInstitutionIdentifier data to the class member
			_investorinstitutionidentifier = data._investorinstitutionidentifier;
			// assigns the CommitmentReferenceIdentifier data to the class member
			_commitmentreferenceidentifier = data._commitmentreferenceidentifier;
			// assigns the ConcurrentOriginationIndicator data to the class member
			_concurrentoriginationindicator = data._concurrentoriginationindicator;
			_concurrentoriginationindicator_assigned = data._concurrentoriginationindicator_assigned;
			// assigns the ConcurrentOriginationLenderIndicator data to the class member
			_concurrentoriginationlenderindicator = data._concurrentoriginationlenderindicator;
			_concurrentoriginationlenderindicator_assigned = data._concurrentoriginationlenderindicator_assigned;
			// assigns the RateLockPeriodDays data to the class member
			_ratelockperioddays = data._ratelockperioddays;
			_ratelockperioddays_isnull = data._ratelockperioddays_isnull;
			// assigns the RateLockRequestedExtensionDays data to the class member
			_ratelockrequestedextensiondays = data._ratelockrequestedextensiondays;
			_ratelockrequestedextensiondays_isnull = data._ratelockrequestedextensiondays_isnull;
			// assigns the CaseStateType data to the class member
			_casestatetype = data._casestatetype;
			_casestatetype_isnull = data._casestatetype_isnull;
			// assigns the RateLockType data to the class member
			_ratelocktype = data._ratelocktype;
			_ratelocktype_isnull = data._ratelocktype_isnull;
			// assigns the CurrentFirstMortgageHolderType data to the class member
			_currentfirstmortgageholdertype = data._currentfirstmortgageholdertype;
			_currentfirstmortgageholdertype_isnull = data._currentfirstmortgageholdertype_isnull;


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
			// assigns the ArmsLengthIndicator data to the class member
			_armslengthindicator = Convert.ToBoolean(data["ArmsLengthIndicator"]);
			_armslengthindicator_assigned = true;
			// assigns the BelowMarketSubordinateFinancingIndicator data to the class member
			_belowmarketsubordinatefinancingindicator = Convert.ToBoolean(data["BelowMarketSubordinateFinancingIndicator"]);
			_belowmarketsubordinatefinancingindicator_assigned = true;
			// assigns the BuydownRatePercent data to the class member
			if (data["BuydownRatePercent"] == System.DBNull.Value)
				SetBuydownRatePercentNull();
			else
			{
				_buydownratepercent = Convert.ToDecimal(data["BuydownRatePercent"]);
				_buydownratepercent_isnull = false;
			}
			// assigns the CreditReportAuthorizationIndicator data to the class member
			_creditreportauthorizationindicator = Convert.ToBoolean(data["CreditReportAuthorizationIndicator"]);
			_creditreportauthorizationindicator_assigned = true;
			// assigns the LenderBranchIdentifier data to the class member
			if (data["LenderBranchIdentifier"] == System.DBNull.Value)
				SetLenderBranchIdentifierNull();
			else
			{
				_lenderbranchidentifier = Convert.ToString(data["LenderBranchIdentifier"]);
			}
			// assigns the LenderRegistrationIdentifier data to the class member
			if (data["LenderRegistrationIdentifier"] == System.DBNull.Value)
				SetLenderRegistrationIdentifierNull();
			else
			{
				_lenderregistrationidentifier = Convert.ToString(data["LenderRegistrationIdentifier"]);
			}
			// assigns the PropertyAppraisedValueAmount data to the class member
			if (data["PropertyAppraisedValueAmount"] == System.DBNull.Value)
				SetPropertyAppraisedValueAmountNull();
			else
			{
				_propertyappraisedvalueamount = Convert.ToDecimal(data["PropertyAppraisedValueAmount"]);
				_propertyappraisedvalueamount_isnull = false;
			}
			// assigns the PropertyEstimatedValueAmount data to the class member
			if (data["PropertyEstimatedValueAmount"] == System.DBNull.Value)
				SetPropertyEstimatedValueAmountNull();
			else
			{
				_propertyestimatedvalueamount = Convert.ToDecimal(data["PropertyEstimatedValueAmount"]);
				_propertyestimatedvalueamount_isnull = false;
			}
			// assigns the InvestorLoanIdentifier data to the class member
			if (data["InvestorLoanIdentifier"] == System.DBNull.Value)
				SetInvestorLoanIdentifierNull();
			else
			{
				_investorloanidentifier = Convert.ToString(data["InvestorLoanIdentifier"]);
			}
			// assigns the InvestorInstitutionIdentifier data to the class member
			if (data["InvestorInstitutionIdentifier"] == System.DBNull.Value)
				SetInvestorInstitutionIdentifierNull();
			else
			{
				_investorinstitutionidentifier = Convert.ToString(data["InvestorInstitutionIdentifier"]);
			}
			// assigns the CommitmentReferenceIdentifier data to the class member
			if (data["CommitmentReferenceIdentifier"] == System.DBNull.Value)
				SetCommitmentReferenceIdentifierNull();
			else
			{
				_commitmentreferenceidentifier = Convert.ToString(data["CommitmentReferenceIdentifier"]);
			}
			// assigns the ConcurrentOriginationIndicator data to the class member
			_concurrentoriginationindicator = Convert.ToBoolean(data["ConcurrentOriginationIndicator"]);
			_concurrentoriginationindicator_assigned = true;
			// assigns the ConcurrentOriginationLenderIndicator data to the class member
			_concurrentoriginationlenderindicator = Convert.ToBoolean(data["ConcurrentOriginationLenderIndicator"]);
			_concurrentoriginationlenderindicator_assigned = true;
			// assigns the RateLockPeriodDays data to the class member
			if (data["RateLockPeriodDays"] == System.DBNull.Value)
				SetRateLockPeriodDaysNull();
			else
			{
				_ratelockperioddays = Convert.ToInt16(data["RateLockPeriodDays"]);
				_ratelockperioddays_isnull = false;
			}
			// assigns the RateLockRequestedExtensionDays data to the class member
			if (data["RateLockRequestedExtensionDays"] == System.DBNull.Value)
				SetRateLockRequestedExtensionDaysNull();
			else
			{
				_ratelockrequestedextensiondays = Convert.ToInt16(data["RateLockRequestedExtensionDays"]);
				_ratelockrequestedextensiondays_isnull = false;
			}
			// assigns the CaseStateType data to the class member
			if (data["CaseStateType"] == System.DBNull.Value)
				SetCaseStateTypeNull();
			else
			{
				_casestatetype = Convert.ToInt16(data["CaseStateType"]);
				_casestatetype_isnull = false;
			}
			// assigns the RateLockType data to the class member
			if (data["RateLockType"] == System.DBNull.Value)
				SetRateLockTypeNull();
			else
			{
				_ratelocktype = Convert.ToInt16(data["RateLockType"]);
				_ratelocktype_isnull = false;
			}
			// assigns the CurrentFirstMortgageHolderType data to the class member
			if (data["CurrentFirstMortgageHolderType"] == System.DBNull.Value)
				SetCurrentFirstMortgageHolderTypeNull();
			else
			{
				_currentfirstmortgageholdertype = Convert.ToInt16(data["CurrentFirstMortgageHolderType"]);
				_currentfirstmortgageholdertype_isnull = false;
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
			// assigns the ArmsLengthIndicator data to the class member
			_armslengthindicator = Convert.ToBoolean(data["ArmsLengthIndicator"]);
			_armslengthindicator_assigned = true;
			// assigns the BelowMarketSubordinateFinancingIndicator data to the class member
			_belowmarketsubordinatefinancingindicator = Convert.ToBoolean(data["BelowMarketSubordinateFinancingIndicator"]);
			_belowmarketsubordinatefinancingindicator_assigned = true;
			// assigns the BuydownRatePercent data to the class member
			if (data["BuydownRatePercent"] == System.DBNull.Value)
				SetBuydownRatePercentNull();
			else
			{
				_buydownratepercent = Convert.ToDecimal(data["BuydownRatePercent"]);
				_buydownratepercent_isnull = false;
			}
			// assigns the CreditReportAuthorizationIndicator data to the class member
			_creditreportauthorizationindicator = Convert.ToBoolean(data["CreditReportAuthorizationIndicator"]);
			_creditreportauthorizationindicator_assigned = true;
			// assigns the LenderBranchIdentifier data to the class member
			if (data["LenderBranchIdentifier"] == System.DBNull.Value)
				SetLenderBranchIdentifierNull();
			else
			{
				_lenderbranchidentifier = Convert.ToString(data["LenderBranchIdentifier"]);
			}
			// assigns the LenderRegistrationIdentifier data to the class member
			if (data["LenderRegistrationIdentifier"] == System.DBNull.Value)
				SetLenderRegistrationIdentifierNull();
			else
			{
				_lenderregistrationidentifier = Convert.ToString(data["LenderRegistrationIdentifier"]);
			}
			// assigns the PropertyAppraisedValueAmount data to the class member
			if (data["PropertyAppraisedValueAmount"] == System.DBNull.Value)
				SetPropertyAppraisedValueAmountNull();
			else
			{
				_propertyappraisedvalueamount = Convert.ToDecimal(data["PropertyAppraisedValueAmount"]);
				_propertyappraisedvalueamount_isnull = false;
			}
			// assigns the PropertyEstimatedValueAmount data to the class member
			if (data["PropertyEstimatedValueAmount"] == System.DBNull.Value)
				SetPropertyEstimatedValueAmountNull();
			else
			{
				_propertyestimatedvalueamount = Convert.ToDecimal(data["PropertyEstimatedValueAmount"]);
				_propertyestimatedvalueamount_isnull = false;
			}
			// assigns the InvestorLoanIdentifier data to the class member
			if (data["InvestorLoanIdentifier"] == System.DBNull.Value)
				SetInvestorLoanIdentifierNull();
			else
			{
				_investorloanidentifier = Convert.ToString(data["InvestorLoanIdentifier"]);
			}
			// assigns the InvestorInstitutionIdentifier data to the class member
			if (data["InvestorInstitutionIdentifier"] == System.DBNull.Value)
				SetInvestorInstitutionIdentifierNull();
			else
			{
				_investorinstitutionidentifier = Convert.ToString(data["InvestorInstitutionIdentifier"]);
			}
			// assigns the CommitmentReferenceIdentifier data to the class member
			if (data["CommitmentReferenceIdentifier"] == System.DBNull.Value)
				SetCommitmentReferenceIdentifierNull();
			else
			{
				_commitmentreferenceidentifier = Convert.ToString(data["CommitmentReferenceIdentifier"]);
			}
			// assigns the ConcurrentOriginationIndicator data to the class member
			_concurrentoriginationindicator = Convert.ToBoolean(data["ConcurrentOriginationIndicator"]);
			_concurrentoriginationindicator_assigned = true;
			// assigns the ConcurrentOriginationLenderIndicator data to the class member
			_concurrentoriginationlenderindicator = Convert.ToBoolean(data["ConcurrentOriginationLenderIndicator"]);
			_concurrentoriginationlenderindicator_assigned = true;
			// assigns the RateLockPeriodDays data to the class member
			if (data["RateLockPeriodDays"] == System.DBNull.Value)
				SetRateLockPeriodDaysNull();
			else
			{
				_ratelockperioddays = Convert.ToInt16(data["RateLockPeriodDays"]);
				_ratelockperioddays_isnull = false;
			}
			// assigns the RateLockRequestedExtensionDays data to the class member
			if (data["RateLockRequestedExtensionDays"] == System.DBNull.Value)
				SetRateLockRequestedExtensionDaysNull();
			else
			{
				_ratelockrequestedextensiondays = Convert.ToInt16(data["RateLockRequestedExtensionDays"]);
				_ratelockrequestedextensiondays_isnull = false;
			}
			// assigns the CaseStateType data to the class member
			if (data["CaseStateType"] == System.DBNull.Value)
				SetCaseStateTypeNull();
			else
			{
				_casestatetype = Convert.ToInt16(data["CaseStateType"]);
				_casestatetype_isnull = false;
			}
			// assigns the RateLockType data to the class member
			if (data["RateLockType"] == System.DBNull.Value)
				SetRateLockTypeNull();
			else
			{
				_ratelocktype = Convert.ToInt16(data["RateLockType"]);
				_ratelocktype_isnull = false;
			}
			// assigns the CurrentFirstMortgageHolderType data to the class member
			if (data["CurrentFirstMortgageHolderType"] == System.DBNull.Value)
				SetCurrentFirstMortgageHolderTypeNull();
			else
			{
				_currentfirstmortgageholdertype = Convert.ToInt16(data["CurrentFirstMortgageHolderType"]);
				_currentfirstmortgageholdertype_isnull = false;
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
			TransmittalDataBase.ServiceObject.Persist(this as TransmittalData, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the TRANSMITTAL_DATA object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			TransmittalDataBase.ServiceObject.Delete(this as TransmittalData);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the CaseStateType relationship.
		/// </summary>
		public CaseStateType GetCaseStateType()
		{
			if (_casestatetype_isnull)
				return null;
			else
				return new CaseStateType(_casestatetype);
		}


		/// <summary>
		/// Gets the single object for the MortgageHolderType relationship.
		/// </summary>
		public MortgageHolderType GetMortgageHolderType()
		{
			if (_currentfirstmortgageholdertype_isnull)
				return null;
			else
				return new MortgageHolderType(_currentfirstmortgageholdertype);
		}


		/// <summary>
		/// Gets the single object for the ADDITIONAL_CASE_DATA relationship.
		/// </summary>
		public AdditionalCaseData GetAdditionalCaseData()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new AdditionalCaseData(_loanapplicationid);
		}


		/// <summary>
		/// Gets the single object for the RateLockType relationship.
		/// </summary>
		public RateLockType GetRateLockType()
		{
			if (_ratelocktype_isnull)
				return null;
			else
				return new RateLockType(_ratelocktype);
		}


		/// <summary>
		/// Gets all persisted TransmittalData objects
		/// </summary>
		public static TransmittalDataCollection GetAll()
		{
			// have the service object get the objects
			return TransmittalDataBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
