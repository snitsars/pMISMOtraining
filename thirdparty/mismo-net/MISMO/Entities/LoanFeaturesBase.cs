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
	/// A class that represents an abstract entity for table 'LOAN_FEATURES'
	/// </summary>
	[Serializable]
	public abstract class LoanFeaturesBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanFeaturesBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.LoanFeatures)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanFeaturesBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			LoanFeaturesBase.ServiceObject.Fill(this as LoanFeatures, loanApplicationId);
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
		internal bool _assumabilityindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the assumabilityindicator.
		/// </summary>
		internal System.Boolean _assumabilityindicator;
		/// <summary>
		/// Gets and sets the AssumabilityIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean AssumabilityIndicator
		{
			get
			{
				return _assumabilityindicator;
			}
			set
			{
				_assumabilityindicator = value;
				_assumabilityindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _balloonindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the balloonindicator.
		/// </summary>
		internal System.Boolean _balloonindicator;
		/// <summary>
		/// Gets and sets the BalloonIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean BalloonIndicator
		{
			get
			{
				return _balloonindicator;
			}
			set
			{
				_balloonindicator = value;
				_balloonindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _balloonloanmaturitytermmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the balloonloanmaturitytermmonths.
		/// </summary>
		internal System.Decimal _balloonloanmaturitytermmonths;
		/// <summary>
		/// Gets and sets the BalloonLoanMaturityTermMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal BalloonLoanMaturityTermMonths
		{
			get
			{
				return _balloonloanmaturitytermmonths;
			}
			set
			{
				_balloonloanmaturitytermmonths = value;
				_balloonloanmaturitytermmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BalloonLoanMaturityTermMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean BalloonLoanMaturityTermMonthsIsNull
		{
			get
			{
				return _balloonloanmaturitytermmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _buydowntemporarysubsidyindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the buydowntemporarysubsidyindicator.
		/// </summary>
		internal System.Boolean _buydowntemporarysubsidyindicator;
		/// <summary>
		/// Gets and sets the BuydownTemporarySubsidyIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean BuydownTemporarySubsidyIndicator
		{
			get
			{
				return _buydowntemporarysubsidyindicator;
			}
			set
			{
				_buydowntemporarysubsidyindicator = value;
				_buydowntemporarysubsidyindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _counselingconfirmationindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the counselingconfirmationindicator.
		/// </summary>
		internal System.Boolean _counselingconfirmationindicator;
		/// <summary>
		/// Gets and sets the CounselingConfirmationIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean CounselingConfirmationIndicator
		{
			get
			{
				return _counselingconfirmationindicator;
			}
			set
			{
				_counselingconfirmationindicator = value;
				_counselingconfirmationindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _escrowwaiverindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the escrowwaiverindicator.
		/// </summary>
		internal System.Boolean _escrowwaiverindicator;
		/// <summary>
		/// Gets and sets the EscrowWaiverIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean EscrowWaiverIndicator
		{
			get
			{
				return _escrowwaiverindicator;
			}
			set
			{
				_escrowwaiverindicator = value;
				_escrowwaiverindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the freofferingidentifier.
		/// </summary>
		internal System.String _freofferingidentifier;
		/// <summary>
		/// Gets and sets the FREOfferingIdentifier value of the class instance.
		/// </summary>
		public virtual System.String FREOfferingIdentifier
		{
			get
			{
				return _freofferingidentifier;
			}
			set
			{
				_freofferingidentifier = value;
			}
		}


		/// <summary>
		/// Checks the FREOfferingIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean FREOfferingIdentifierIsNull
		{
			get
			{
				return (_freofferingidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the fnmproductplanidentifier.
		/// </summary>
		internal System.String _fnmproductplanidentifier;
		/// <summary>
		/// Gets and sets the FNMProductPlanIdentifier value of the class instance.
		/// </summary>
		public virtual System.String FNMProductPlanIdentifier
		{
			get
			{
				return _fnmproductplanidentifier;
			}
			set
			{
				_fnmproductplanidentifier = value;
			}
		}


		/// <summary>
		/// Checks the FNMProductPlanIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMProductPlanIdentifierIsNull
		{
			get
			{
				return (_fnmproductplanidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the fnmproductplanindentifier.
		/// </summary>
		internal System.String _fnmproductplanindentifier;
		/// <summary>
		/// Gets and sets the FNMProductPlanIndentifier value of the class instance.
		/// </summary>
		public virtual System.String FNMProductPlanIndentifier
		{
			get
			{
				return _fnmproductplanindentifier;
			}
			set
			{
				_fnmproductplanindentifier = value;
			}
		}


		/// <summary>
		/// Checks the FNMProductPlanIndentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMProductPlanIndentifierIsNull
		{
			get
			{
				return (_fnmproductplanindentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _helocmaximumbalanceamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the helocmaximumbalanceamount.
		/// </summary>
		internal System.Decimal _helocmaximumbalanceamount;
		/// <summary>
		/// Gets and sets the HELOCMaximumBalanceAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal HELOCMaximumBalanceAmount
		{
			get
			{
				return _helocmaximumbalanceamount;
			}
			set
			{
				_helocmaximumbalanceamount = value;
				_helocmaximumbalanceamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HELOCMaximumBalanceAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean HELOCMaximumBalanceAmountIsNull
		{
			get
			{
				return _helocmaximumbalanceamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _helocinitialadvanceamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the helocinitialadvanceamount.
		/// </summary>
		internal System.Decimal _helocinitialadvanceamount;
		/// <summary>
		/// Gets and sets the HELOCInitialAdvanceAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal HELOCInitialAdvanceAmount
		{
			get
			{
				return _helocinitialadvanceamount;
			}
			set
			{
				_helocinitialadvanceamount = value;
				_helocinitialadvanceamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HELOCInitialAdvanceAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean HELOCInitialAdvanceAmountIsNull
		{
			get
			{
				return _helocinitialadvanceamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _interestonlyterm_isnull = true;
		/// <summary>
		/// Member that stores the value for the interestonlyterm.
		/// </summary>
		internal System.Decimal _interestonlyterm;
		/// <summary>
		/// Gets and sets the InterestOnlyTerm value of the class instance.
		/// </summary>
		public virtual System.Decimal InterestOnlyTerm
		{
			get
			{
				return _interestonlyterm;
			}
			set
			{
				_interestonlyterm = value;
				_interestonlyterm_isnull = false;
			}
		}


		/// <summary>
		/// Checks the InterestOnlyTerm value to see if it was set to null.
		/// </summary>
		public System.Boolean InterestOnlyTermIsNull
		{
			get
			{
				return _interestonlyterm_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _lenderselfinsuredindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the lenderselfinsuredindicator.
		/// </summary>
		internal System.Boolean _lenderselfinsuredindicator;
		/// <summary>
		/// Gets and sets the LenderSelfInsuredIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean LenderSelfInsuredIndicator
		{
			get
			{
				return _lenderselfinsuredindicator;
			}
			set
			{
				_lenderselfinsuredindicator = value;
				_lenderselfinsuredindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanscheduledclosingdate_isnull = true;
		/// <summary>
		/// Member that stores the value for the loanscheduledclosingdate.
		/// </summary>
		internal System.DateTime _loanscheduledclosingdate;
		/// <summary>
		/// Gets and sets the LoanScheduledClosingDate value of the class instance.
		/// </summary>
		public virtual System.DateTime LoanScheduledClosingDate
		{
			get
			{
				return _loanscheduledclosingdate;
			}
			set
			{
				_loanscheduledclosingdate = value;
				_loanscheduledclosingdate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanScheduledClosingDate value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanScheduledClosingDateIsNull
		{
			get
			{
				return _loanscheduledclosingdate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _micoveragepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the micoveragepercent.
		/// </summary>
		internal System.Decimal _micoveragepercent;
		/// <summary>
		/// Gets and sets the MICoveragePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal MICoveragePercent
		{
			get
			{
				return _micoveragepercent;
			}
			set
			{
				_micoveragepercent = value;
				_micoveragepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MICoveragePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean MICoveragePercentIsNull
		{
			get
			{
				return _micoveragepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _negativeamortizationlimitpercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the negativeamortizationlimitpercent.
		/// </summary>
		internal System.Decimal _negativeamortizationlimitpercent;
		/// <summary>
		/// Gets and sets the NegativeAmortizationLimitPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal NegativeAmortizationLimitPercent
		{
			get
			{
				return _negativeamortizationlimitpercent;
			}
			set
			{
				_negativeamortizationlimitpercent = value;
				_negativeamortizationlimitpercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the NegativeAmortizationLimitPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean NegativeAmortizationLimitPercentIsNull
		{
			get
			{
				return _negativeamortizationlimitpercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _prepaymentpenaltyindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the prepaymentpenaltyindicator.
		/// </summary>
		internal System.Boolean _prepaymentpenaltyindicator;
		/// <summary>
		/// Gets and sets the PrepaymentPenaltyIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PrepaymentPenaltyIndicator
		{
			get
			{
				return _prepaymentpenaltyindicator;
			}
			set
			{
				_prepaymentpenaltyindicator = value;
				_prepaymentpenaltyindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _prepaymentpenaltytermmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the prepaymentpenaltytermmonths.
		/// </summary>
		internal System.Decimal _prepaymentpenaltytermmonths;
		/// <summary>
		/// Gets and sets the PrepaymentPenaltyTermMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal PrepaymentPenaltyTermMonths
		{
			get
			{
				return _prepaymentpenaltytermmonths;
			}
			set
			{
				_prepaymentpenaltytermmonths = value;
				_prepaymentpenaltytermmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PrepaymentPenaltyTermMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean PrepaymentPenaltyTermMonthsIsNull
		{
			get
			{
				return _prepaymentpenaltytermmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _prepaymentrestrictionindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the prepaymentrestrictionindicator.
		/// </summary>
		internal System.Boolean _prepaymentrestrictionindicator;
		/// <summary>
		/// Gets and sets the PrepaymentRestrictionIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PrepaymentRestrictionIndicator
		{
			get
			{
				return _prepaymentrestrictionindicator;
			}
			set
			{
				_prepaymentrestrictionindicator = value;
				_prepaymentrestrictionindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the productdescription.
		/// </summary>
		internal System.String _productdescription;
		/// <summary>
		/// Gets and sets the ProductDescription value of the class instance.
		/// </summary>
		public virtual System.String ProductDescription
		{
			get
			{
				return _productdescription;
			}
			set
			{
				_productdescription = value;
			}
		}


		/// <summary>
		/// Checks the ProductDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean ProductDescriptionIsNull
		{
			get
			{
				return (_productdescription == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the productname.
		/// </summary>
		internal System.String _productname;
		/// <summary>
		/// Gets and sets the ProductName value of the class instance.
		/// </summary>
		public virtual System.String ProductName
		{
			get
			{
				return _productname;
			}
			set
			{
				_productname = value;
			}
		}


		/// <summary>
		/// Checks the ProductName value to see if it was set to null.
		/// </summary>
		public System.Boolean ProductNameIsNull
		{
			get
			{
				return (_productname == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _scheduledfirstpaymentdate_isnull = true;
		/// <summary>
		/// Member that stores the value for the scheduledfirstpaymentdate.
		/// </summary>
		internal System.DateTime _scheduledfirstpaymentdate;
		/// <summary>
		/// Gets and sets the ScheduledFirstPaymentDate value of the class instance.
		/// </summary>
		public virtual System.DateTime ScheduledFirstPaymentDate
		{
			get
			{
				return _scheduledfirstpaymentdate;
			}
			set
			{
				_scheduledfirstpaymentdate = value;
				_scheduledfirstpaymentdate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ScheduledFirstPaymentDate value to see if it was set to null.
		/// </summary>
		public System.Boolean ScheduledFirstPaymentDateIsNull
		{
			get
			{
				return _scheduledfirstpaymentdate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _namedocumentsdrawnintype_isnull = true;
		/// <summary>
		/// Member that stores the value for the namedocumentsdrawnintype.
		/// </summary>
		internal System.Int16 _namedocumentsdrawnintype;
		/// <summary>
		/// Gets and sets the NameDocumentsDrawnInType value of the class instance.
		/// </summary>
		public virtual System.Int16 NameDocumentsDrawnInType
		{
			get
			{
				return _namedocumentsdrawnintype;
			}
			set
			{
				_namedocumentsdrawnintype = value;
				_namedocumentsdrawnintype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the NameDocumentsDrawnInType value to see if it was set to null.
		/// </summary>
		public System.Boolean NameDocumentsDrawnInTypeIsNull
		{
			get
			{
				return _namedocumentsdrawnintype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _gseprojectclassificationtype_isnull = true;
		/// <summary>
		/// Member that stores the value for the gseprojectclassificationtype.
		/// </summary>
		internal System.Int16 _gseprojectclassificationtype;
		/// <summary>
		/// Gets and sets the GSEProjectClassificationType value of the class instance.
		/// </summary>
		public virtual System.Int16 GSEProjectClassificationType
		{
			get
			{
				return _gseprojectclassificationtype;
			}
			set
			{
				_gseprojectclassificationtype = value;
				_gseprojectclassificationtype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the GSEProjectClassificationType value to see if it was set to null.
		/// </summary>
		public System.Boolean GSEProjectClassificationTypeIsNull
		{
			get
			{
				return _gseprojectclassificationtype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _gsepropertytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the gsepropertytype.
		/// </summary>
		internal System.Int16 _gsepropertytype;
		/// <summary>
		/// Gets and sets the GSEPropertyType value of the class instance.
		/// </summary>
		public virtual System.Int16 GSEPropertyType
		{
			get
			{
				return _gsepropertytype;
			}
			set
			{
				_gsepropertytype = value;
				_gsepropertytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the GSEPropertyType value to see if it was set to null.
		/// </summary>
		public System.Boolean GSEPropertyTypeIsNull
		{
			get
			{
				return _gsepropertytype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _lienprioritytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the lienprioritytype.
		/// </summary>
		internal System.Int16 _lienprioritytype;
		/// <summary>
		/// Gets and sets the LienPriorityType value of the class instance.
		/// </summary>
		public virtual System.Int16 LienPriorityType
		{
			get
			{
				return _lienprioritytype;
			}
			set
			{
				_lienprioritytype = value;
				_lienprioritytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LienPriorityType value to see if it was set to null.
		/// </summary>
		public System.Boolean LienPriorityTypeIsNull
		{
			get
			{
				return _lienprioritytype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loandocumentationtype_isnull = true;
		/// <summary>
		/// Member that stores the value for the loandocumentationtype.
		/// </summary>
		internal System.Int16 _loandocumentationtype;
		/// <summary>
		/// Gets and sets the LoanDocumentationType value of the class instance.
		/// </summary>
		public virtual System.Int16 LoanDocumentationType
		{
			get
			{
				return _loandocumentationtype;
			}
			set
			{
				_loandocumentationtype = value;
				_loandocumentationtype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanDocumentationType value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanDocumentationTypeIsNull
		{
			get
			{
				return _loandocumentationtype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanrepaymenttype_isnull = true;
		/// <summary>
		/// Member that stores the value for the loanrepaymenttype.
		/// </summary>
		internal System.Int16 _loanrepaymenttype;
		/// <summary>
		/// Gets and sets the LoanRepaymentType value of the class instance.
		/// </summary>
		public virtual System.Int16 LoanRepaymentType
		{
			get
			{
				return _loanrepaymenttype;
			}
			set
			{
				_loanrepaymenttype = value;
				_loanrepaymenttype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanRepaymentType value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanRepaymentTypeIsNull
		{
			get
			{
				return _loanrepaymenttype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _micertificationstatustype_isnull = true;
		/// <summary>
		/// Member that stores the value for the micertificationstatustype.
		/// </summary>
		internal System.Int16 _micertificationstatustype;
		/// <summary>
		/// Gets and sets the MICertificationStatusType value of the class instance.
		/// </summary>
		public virtual System.Int16 MICertificationStatusType
		{
			get
			{
				return _micertificationstatustype;
			}
			set
			{
				_micertificationstatustype = value;
				_micertificationstatustype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MICertificationStatusType value to see if it was set to null.
		/// </summary>
		public System.Boolean MICertificationStatusTypeIsNull
		{
			get
			{
				return _micertificationstatustype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _micompanynametype_isnull = true;
		/// <summary>
		/// Member that stores the value for the micompanynametype.
		/// </summary>
		internal System.Int16 _micompanynametype;
		/// <summary>
		/// Gets and sets the MICompanyNameType value of the class instance.
		/// </summary>
		public virtual System.Int16 MICompanyNameType
		{
			get
			{
				return _micompanynametype;
			}
			set
			{
				_micompanynametype = value;
				_micompanynametype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MICompanyNameType value to see if it was set to null.
		/// </summary>
		public System.Boolean MICompanyNameTypeIsNull
		{
			get
			{
				return _micompanynametype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _paymentfrequencytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the paymentfrequencytype.
		/// </summary>
		internal System.Int16 _paymentfrequencytype;
		/// <summary>
		/// Gets and sets the PaymentFrequencyType value of the class instance.
		/// </summary>
		public virtual System.Int16 PaymentFrequencyType
		{
			get
			{
				return _paymentfrequencytype;
			}
			set
			{
				_paymentfrequencytype = value;
				_paymentfrequencytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PaymentFrequencyType value to see if it was set to null.
		/// </summary>
		public System.Boolean PaymentFrequencyTypeIsNull
		{
			get
			{
				return _paymentfrequencytype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fullprepaymentpenaltyoptiontype_isnull = true;
		/// <summary>
		/// Member that stores the value for the fullprepaymentpenaltyoptiontype.
		/// </summary>
		internal System.Int16 _fullprepaymentpenaltyoptiontype;
		/// <summary>
		/// Gets and sets the FullPrepaymentPenaltyOptionType value of the class instance.
		/// </summary>
		public virtual System.Int16 FullPrepaymentPenaltyOptionType
		{
			get
			{
				return _fullprepaymentpenaltyoptiontype;
			}
			set
			{
				_fullprepaymentpenaltyoptiontype = value;
				_fullprepaymentpenaltyoptiontype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FullPrepaymentPenaltyOptionType value to see if it was set to null.
		/// </summary>
		public System.Boolean FullPrepaymentPenaltyOptionTypeIsNull
		{
			get
			{
				return _fullprepaymentpenaltyoptiontype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanclosingstatustype_isnull = true;
		/// <summary>
		/// Member that stores the value for the loanclosingstatustype.
		/// </summary>
		internal System.Int16 _loanclosingstatustype;
		/// <summary>
		/// Gets and sets the LoanClosingStatusType value of the class instance.
		/// </summary>
		public virtual System.Int16 LoanClosingStatusType
		{
			get
			{
				return _loanclosingstatustype;
			}
			set
			{
				_loanclosingstatustype = value;
				_loanclosingstatustype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanClosingStatusType value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanClosingStatusTypeIsNull
		{
			get
			{
				return _loanclosingstatustype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _servicingtransferstatustype_isnull = true;
		/// <summary>
		/// Member that stores the value for the servicingtransferstatustype.
		/// </summary>
		internal System.Int16 _servicingtransferstatustype;
		/// <summary>
		/// Gets and sets the ServicingTransferStatusType value of the class instance.
		/// </summary>
		public virtual System.Int16 ServicingTransferStatusType
		{
			get
			{
				return _servicingtransferstatustype;
			}
			set
			{
				_servicingtransferstatustype = value;
				_servicingtransferstatustype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ServicingTransferStatusType value to see if it was set to null.
		/// </summary>
		public System.Boolean ServicingTransferStatusTypeIsNull
		{
			get
			{
				return _servicingtransferstatustype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the LoanFeaturesBase.
		/// </summary>
		internal static LoanFeaturesService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(LoanFeaturesService)) as LoanFeaturesService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of LoanFeaturesBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the BalloonLoanMaturityTermMonths value as null.
		/// </summary>
		public virtual void SetBalloonLoanMaturityTermMonthsNull()
		{
			_balloonloanmaturitytermmonths = 0;
			_balloonloanmaturitytermmonths_isnull = true;
		}


		/// <summary>
		/// Marks the FREOfferingIdentifier value as null.
		/// </summary>
		public virtual void SetFREOfferingIdentifierNull()
		{
			_freofferingidentifier = null;
		}


		/// <summary>
		/// Marks the FNMProductPlanIdentifier value as null.
		/// </summary>
		public virtual void SetFNMProductPlanIdentifierNull()
		{
			_fnmproductplanidentifier = null;
		}


		/// <summary>
		/// Marks the FNMProductPlanIndentifier value as null.
		/// </summary>
		public virtual void SetFNMProductPlanIndentifierNull()
		{
			_fnmproductplanindentifier = null;
		}


		/// <summary>
		/// Marks the HELOCMaximumBalanceAmount value as null.
		/// </summary>
		public virtual void SetHELOCMaximumBalanceAmountNull()
		{
			_helocmaximumbalanceamount = 0;
			_helocmaximumbalanceamount_isnull = true;
		}


		/// <summary>
		/// Marks the HELOCInitialAdvanceAmount value as null.
		/// </summary>
		public virtual void SetHELOCInitialAdvanceAmountNull()
		{
			_helocinitialadvanceamount = 0;
			_helocinitialadvanceamount_isnull = true;
		}


		/// <summary>
		/// Marks the InterestOnlyTerm value as null.
		/// </summary>
		public virtual void SetInterestOnlyTermNull()
		{
			_interestonlyterm = 0;
			_interestonlyterm_isnull = true;
		}


		/// <summary>
		/// Marks the LoanScheduledClosingDate value as null.
		/// </summary>
		public virtual void SetLoanScheduledClosingDateNull()
		{
			_loanscheduledclosingdate = DateTime.MinValue;
			_loanscheduledclosingdate_isnull = true;
		}


		/// <summary>
		/// Marks the MICoveragePercent value as null.
		/// </summary>
		public virtual void SetMICoveragePercentNull()
		{
			_micoveragepercent = 0;
			_micoveragepercent_isnull = true;
		}


		/// <summary>
		/// Marks the NegativeAmortizationLimitPercent value as null.
		/// </summary>
		public virtual void SetNegativeAmortizationLimitPercentNull()
		{
			_negativeamortizationlimitpercent = 0;
			_negativeamortizationlimitpercent_isnull = true;
		}


		/// <summary>
		/// Marks the PrepaymentPenaltyTermMonths value as null.
		/// </summary>
		public virtual void SetPrepaymentPenaltyTermMonthsNull()
		{
			_prepaymentpenaltytermmonths = 0;
			_prepaymentpenaltytermmonths_isnull = true;
		}


		/// <summary>
		/// Marks the ProductDescription value as null.
		/// </summary>
		public virtual void SetProductDescriptionNull()
		{
			_productdescription = null;
		}


		/// <summary>
		/// Marks the ProductName value as null.
		/// </summary>
		public virtual void SetProductNameNull()
		{
			_productname = null;
		}


		/// <summary>
		/// Marks the ScheduledFirstPaymentDate value as null.
		/// </summary>
		public virtual void SetScheduledFirstPaymentDateNull()
		{
			_scheduledfirstpaymentdate = DateTime.MinValue;
			_scheduledfirstpaymentdate_isnull = true;
		}


		/// <summary>
		/// Marks the NameDocumentsDrawnInType value as null.
		/// </summary>
		public virtual void SetNameDocumentsDrawnInTypeNull()
		{
			_namedocumentsdrawnintype = 0;
			_namedocumentsdrawnintype_isnull = true;
		}


		/// <summary>
		/// Marks the GSEProjectClassificationType value as null.
		/// </summary>
		public virtual void SetGSEProjectClassificationTypeNull()
		{
			_gseprojectclassificationtype = 0;
			_gseprojectclassificationtype_isnull = true;
		}


		/// <summary>
		/// Marks the GSEPropertyType value as null.
		/// </summary>
		public virtual void SetGSEPropertyTypeNull()
		{
			_gsepropertytype = 0;
			_gsepropertytype_isnull = true;
		}


		/// <summary>
		/// Marks the LienPriorityType value as null.
		/// </summary>
		public virtual void SetLienPriorityTypeNull()
		{
			_lienprioritytype = 0;
			_lienprioritytype_isnull = true;
		}


		/// <summary>
		/// Marks the LoanDocumentationType value as null.
		/// </summary>
		public virtual void SetLoanDocumentationTypeNull()
		{
			_loandocumentationtype = 0;
			_loandocumentationtype_isnull = true;
		}


		/// <summary>
		/// Marks the LoanRepaymentType value as null.
		/// </summary>
		public virtual void SetLoanRepaymentTypeNull()
		{
			_loanrepaymenttype = 0;
			_loanrepaymenttype_isnull = true;
		}


		/// <summary>
		/// Marks the MICertificationStatusType value as null.
		/// </summary>
		public virtual void SetMICertificationStatusTypeNull()
		{
			_micertificationstatustype = 0;
			_micertificationstatustype_isnull = true;
		}


		/// <summary>
		/// Marks the MICompanyNameType value as null.
		/// </summary>
		public virtual void SetMICompanyNameTypeNull()
		{
			_micompanynametype = 0;
			_micompanynametype_isnull = true;
		}


		/// <summary>
		/// Marks the PaymentFrequencyType value as null.
		/// </summary>
		public virtual void SetPaymentFrequencyTypeNull()
		{
			_paymentfrequencytype = 0;
			_paymentfrequencytype_isnull = true;
		}


		/// <summary>
		/// Marks the FullPrepaymentPenaltyOptionType value as null.
		/// </summary>
		public virtual void SetFullPrepaymentPenaltyOptionTypeNull()
		{
			_fullprepaymentpenaltyoptiontype = 0;
			_fullprepaymentpenaltyoptiontype_isnull = true;
		}


		/// <summary>
		/// Marks the LoanClosingStatusType value as null.
		/// </summary>
		public virtual void SetLoanClosingStatusTypeNull()
		{
			_loanclosingstatustype = 0;
			_loanclosingstatustype_isnull = true;
		}


		/// <summary>
		/// Marks the ServicingTransferStatusType value as null.
		/// </summary>
		public virtual void SetServicingTransferStatusTypeNull()
		{
			_servicingtransferstatustype = 0;
			_servicingtransferstatustype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref LoanFeaturesBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the AssumabilityIndicator data to the class member
			_assumabilityindicator = data._assumabilityindicator;
			_assumabilityindicator_assigned = data._assumabilityindicator_assigned;
			// assigns the BalloonIndicator data to the class member
			_balloonindicator = data._balloonindicator;
			_balloonindicator_assigned = data._balloonindicator_assigned;
			// assigns the BalloonLoanMaturityTermMonths data to the class member
			_balloonloanmaturitytermmonths = data._balloonloanmaturitytermmonths;
			_balloonloanmaturitytermmonths_isnull = data._balloonloanmaturitytermmonths_isnull;
			// assigns the BuydownTemporarySubsidyIndicator data to the class member
			_buydowntemporarysubsidyindicator = data._buydowntemporarysubsidyindicator;
			_buydowntemporarysubsidyindicator_assigned = data._buydowntemporarysubsidyindicator_assigned;
			// assigns the CounselingConfirmationIndicator data to the class member
			_counselingconfirmationindicator = data._counselingconfirmationindicator;
			_counselingconfirmationindicator_assigned = data._counselingconfirmationindicator_assigned;
			// assigns the EscrowWaiverIndicator data to the class member
			_escrowwaiverindicator = data._escrowwaiverindicator;
			_escrowwaiverindicator_assigned = data._escrowwaiverindicator_assigned;
			// assigns the FREOfferingIdentifier data to the class member
			_freofferingidentifier = data._freofferingidentifier;
			// assigns the FNMProductPlanIdentifier data to the class member
			_fnmproductplanidentifier = data._fnmproductplanidentifier;
			// assigns the FNMProductPlanIndentifier data to the class member
			_fnmproductplanindentifier = data._fnmproductplanindentifier;
			// assigns the HELOCMaximumBalanceAmount data to the class member
			_helocmaximumbalanceamount = data._helocmaximumbalanceamount;
			_helocmaximumbalanceamount_isnull = data._helocmaximumbalanceamount_isnull;
			// assigns the HELOCInitialAdvanceAmount data to the class member
			_helocinitialadvanceamount = data._helocinitialadvanceamount;
			_helocinitialadvanceamount_isnull = data._helocinitialadvanceamount_isnull;
			// assigns the InterestOnlyTerm data to the class member
			_interestonlyterm = data._interestonlyterm;
			_interestonlyterm_isnull = data._interestonlyterm_isnull;
			// assigns the LenderSelfInsuredIndicator data to the class member
			_lenderselfinsuredindicator = data._lenderselfinsuredindicator;
			_lenderselfinsuredindicator_assigned = data._lenderselfinsuredindicator_assigned;
			// assigns the LoanScheduledClosingDate data to the class member
			_loanscheduledclosingdate = data._loanscheduledclosingdate;
			_loanscheduledclosingdate_isnull = data._loanscheduledclosingdate_isnull;
			// assigns the MICoveragePercent data to the class member
			_micoveragepercent = data._micoveragepercent;
			_micoveragepercent_isnull = data._micoveragepercent_isnull;
			// assigns the NegativeAmortizationLimitPercent data to the class member
			_negativeamortizationlimitpercent = data._negativeamortizationlimitpercent;
			_negativeamortizationlimitpercent_isnull = data._negativeamortizationlimitpercent_isnull;
			// assigns the PrepaymentPenaltyIndicator data to the class member
			_prepaymentpenaltyindicator = data._prepaymentpenaltyindicator;
			_prepaymentpenaltyindicator_assigned = data._prepaymentpenaltyindicator_assigned;
			// assigns the PrepaymentPenaltyTermMonths data to the class member
			_prepaymentpenaltytermmonths = data._prepaymentpenaltytermmonths;
			_prepaymentpenaltytermmonths_isnull = data._prepaymentpenaltytermmonths_isnull;
			// assigns the PrepaymentRestrictionIndicator data to the class member
			_prepaymentrestrictionindicator = data._prepaymentrestrictionindicator;
			_prepaymentrestrictionindicator_assigned = data._prepaymentrestrictionindicator_assigned;
			// assigns the ProductDescription data to the class member
			_productdescription = data._productdescription;
			// assigns the ProductName data to the class member
			_productname = data._productname;
			// assigns the ScheduledFirstPaymentDate data to the class member
			_scheduledfirstpaymentdate = data._scheduledfirstpaymentdate;
			_scheduledfirstpaymentdate_isnull = data._scheduledfirstpaymentdate_isnull;
			// assigns the NameDocumentsDrawnInType data to the class member
			_namedocumentsdrawnintype = data._namedocumentsdrawnintype;
			_namedocumentsdrawnintype_isnull = data._namedocumentsdrawnintype_isnull;
			// assigns the GSEProjectClassificationType data to the class member
			_gseprojectclassificationtype = data._gseprojectclassificationtype;
			_gseprojectclassificationtype_isnull = data._gseprojectclassificationtype_isnull;
			// assigns the GSEPropertyType data to the class member
			_gsepropertytype = data._gsepropertytype;
			_gsepropertytype_isnull = data._gsepropertytype_isnull;
			// assigns the LienPriorityType data to the class member
			_lienprioritytype = data._lienprioritytype;
			_lienprioritytype_isnull = data._lienprioritytype_isnull;
			// assigns the LoanDocumentationType data to the class member
			_loandocumentationtype = data._loandocumentationtype;
			_loandocumentationtype_isnull = data._loandocumentationtype_isnull;
			// assigns the LoanRepaymentType data to the class member
			_loanrepaymenttype = data._loanrepaymenttype;
			_loanrepaymenttype_isnull = data._loanrepaymenttype_isnull;
			// assigns the MICertificationStatusType data to the class member
			_micertificationstatustype = data._micertificationstatustype;
			_micertificationstatustype_isnull = data._micertificationstatustype_isnull;
			// assigns the MICompanyNameType data to the class member
			_micompanynametype = data._micompanynametype;
			_micompanynametype_isnull = data._micompanynametype_isnull;
			// assigns the PaymentFrequencyType data to the class member
			_paymentfrequencytype = data._paymentfrequencytype;
			_paymentfrequencytype_isnull = data._paymentfrequencytype_isnull;
			// assigns the FullPrepaymentPenaltyOptionType data to the class member
			_fullprepaymentpenaltyoptiontype = data._fullprepaymentpenaltyoptiontype;
			_fullprepaymentpenaltyoptiontype_isnull = data._fullprepaymentpenaltyoptiontype_isnull;
			// assigns the LoanClosingStatusType data to the class member
			_loanclosingstatustype = data._loanclosingstatustype;
			_loanclosingstatustype_isnull = data._loanclosingstatustype_isnull;
			// assigns the ServicingTransferStatusType data to the class member
			_servicingtransferstatustype = data._servicingtransferstatustype;
			_servicingtransferstatustype_isnull = data._servicingtransferstatustype_isnull;


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
			// assigns the AssumabilityIndicator data to the class member
			_assumabilityindicator = Convert.ToBoolean(data["AssumabilityIndicator"]);
			_assumabilityindicator_assigned = true;
			// assigns the BalloonIndicator data to the class member
			_balloonindicator = Convert.ToBoolean(data["BalloonIndicator"]);
			_balloonindicator_assigned = true;
			// assigns the BalloonLoanMaturityTermMonths data to the class member
			if (data["BalloonLoanMaturityTermMonths"] == System.DBNull.Value)
				SetBalloonLoanMaturityTermMonthsNull();
			else
			{
				_balloonloanmaturitytermmonths = Convert.ToDecimal(data["BalloonLoanMaturityTermMonths"]);
				_balloonloanmaturitytermmonths_isnull = false;
			}
			// assigns the BuydownTemporarySubsidyIndicator data to the class member
			_buydowntemporarysubsidyindicator = Convert.ToBoolean(data["BuydownTemporarySubsidyIndicator"]);
			_buydowntemporarysubsidyindicator_assigned = true;
			// assigns the CounselingConfirmationIndicator data to the class member
			_counselingconfirmationindicator = Convert.ToBoolean(data["CounselingConfirmationIndicator"]);
			_counselingconfirmationindicator_assigned = true;
			// assigns the EscrowWaiverIndicator data to the class member
			_escrowwaiverindicator = Convert.ToBoolean(data["EscrowWaiverIndicator"]);
			_escrowwaiverindicator_assigned = true;
			// assigns the FREOfferingIdentifier data to the class member
			if (data["FREOfferingIdentifier"] == System.DBNull.Value)
				SetFREOfferingIdentifierNull();
			else
			{
				_freofferingidentifier = Convert.ToString(data["FREOfferingIdentifier"]);
			}
			// assigns the FNMProductPlanIdentifier data to the class member
			if (data["FNMProductPlanIdentifier"] == System.DBNull.Value)
				SetFNMProductPlanIdentifierNull();
			else
			{
				_fnmproductplanidentifier = Convert.ToString(data["FNMProductPlanIdentifier"]);
			}
			// assigns the FNMProductPlanIndentifier data to the class member
			if (data["FNMProductPlanIndentifier"] == System.DBNull.Value)
				SetFNMProductPlanIndentifierNull();
			else
			{
				_fnmproductplanindentifier = Convert.ToString(data["FNMProductPlanIndentifier"]);
			}
			// assigns the HELOCMaximumBalanceAmount data to the class member
			if (data["HELOCMaximumBalanceAmount"] == System.DBNull.Value)
				SetHELOCMaximumBalanceAmountNull();
			else
			{
				_helocmaximumbalanceamount = Convert.ToDecimal(data["HELOCMaximumBalanceAmount"]);
				_helocmaximumbalanceamount_isnull = false;
			}
			// assigns the HELOCInitialAdvanceAmount data to the class member
			if (data["HELOCInitialAdvanceAmount"] == System.DBNull.Value)
				SetHELOCInitialAdvanceAmountNull();
			else
			{
				_helocinitialadvanceamount = Convert.ToDecimal(data["HELOCInitialAdvanceAmount"]);
				_helocinitialadvanceamount_isnull = false;
			}
			// assigns the InterestOnlyTerm data to the class member
			if (data["InterestOnlyTerm"] == System.DBNull.Value)
				SetInterestOnlyTermNull();
			else
			{
				_interestonlyterm = Convert.ToDecimal(data["InterestOnlyTerm"]);
				_interestonlyterm_isnull = false;
			}
			// assigns the LenderSelfInsuredIndicator data to the class member
			_lenderselfinsuredindicator = Convert.ToBoolean(data["LenderSelfInsuredIndicator"]);
			_lenderselfinsuredindicator_assigned = true;
			// assigns the LoanScheduledClosingDate data to the class member
			if (data["LoanScheduledClosingDate"] == System.DBNull.Value)
				SetLoanScheduledClosingDateNull();
			else
			{
				_loanscheduledclosingdate = Convert.ToDateTime(data["LoanScheduledClosingDate"]);
				_loanscheduledclosingdate_isnull = false;
			}
			// assigns the MICoveragePercent data to the class member
			if (data["MICoveragePercent"] == System.DBNull.Value)
				SetMICoveragePercentNull();
			else
			{
				_micoveragepercent = Convert.ToDecimal(data["MICoveragePercent"]);
				_micoveragepercent_isnull = false;
			}
			// assigns the NegativeAmortizationLimitPercent data to the class member
			if (data["NegativeAmortizationLimitPercent"] == System.DBNull.Value)
				SetNegativeAmortizationLimitPercentNull();
			else
			{
				_negativeamortizationlimitpercent = Convert.ToDecimal(data["NegativeAmortizationLimitPercent"]);
				_negativeamortizationlimitpercent_isnull = false;
			}
			// assigns the PrepaymentPenaltyIndicator data to the class member
			_prepaymentpenaltyindicator = Convert.ToBoolean(data["PrepaymentPenaltyIndicator"]);
			_prepaymentpenaltyindicator_assigned = true;
			// assigns the PrepaymentPenaltyTermMonths data to the class member
			if (data["PrepaymentPenaltyTermMonths"] == System.DBNull.Value)
				SetPrepaymentPenaltyTermMonthsNull();
			else
			{
				_prepaymentpenaltytermmonths = Convert.ToDecimal(data["PrepaymentPenaltyTermMonths"]);
				_prepaymentpenaltytermmonths_isnull = false;
			}
			// assigns the PrepaymentRestrictionIndicator data to the class member
			_prepaymentrestrictionindicator = Convert.ToBoolean(data["PrepaymentRestrictionIndicator"]);
			_prepaymentrestrictionindicator_assigned = true;
			// assigns the ProductDescription data to the class member
			if (data["ProductDescription"] == System.DBNull.Value)
				SetProductDescriptionNull();
			else
			{
				_productdescription = Convert.ToString(data["ProductDescription"]);
			}
			// assigns the ProductName data to the class member
			if (data["ProductName"] == System.DBNull.Value)
				SetProductNameNull();
			else
			{
				_productname = Convert.ToString(data["ProductName"]);
			}
			// assigns the ScheduledFirstPaymentDate data to the class member
			if (data["ScheduledFirstPaymentDate"] == System.DBNull.Value)
				SetScheduledFirstPaymentDateNull();
			else
			{
				_scheduledfirstpaymentdate = Convert.ToDateTime(data["ScheduledFirstPaymentDate"]);
				_scheduledfirstpaymentdate_isnull = false;
			}
			// assigns the NameDocumentsDrawnInType data to the class member
			if (data["NameDocumentsDrawnInType"] == System.DBNull.Value)
				SetNameDocumentsDrawnInTypeNull();
			else
			{
				_namedocumentsdrawnintype = Convert.ToInt16(data["NameDocumentsDrawnInType"]);
				_namedocumentsdrawnintype_isnull = false;
			}
			// assigns the GSEProjectClassificationType data to the class member
			if (data["GSEProjectClassificationType"] == System.DBNull.Value)
				SetGSEProjectClassificationTypeNull();
			else
			{
				_gseprojectclassificationtype = Convert.ToInt16(data["GSEProjectClassificationType"]);
				_gseprojectclassificationtype_isnull = false;
			}
			// assigns the GSEPropertyType data to the class member
			if (data["GSEPropertyType"] == System.DBNull.Value)
				SetGSEPropertyTypeNull();
			else
			{
				_gsepropertytype = Convert.ToInt16(data["GSEPropertyType"]);
				_gsepropertytype_isnull = false;
			}
			// assigns the LienPriorityType data to the class member
			if (data["LienPriorityType"] == System.DBNull.Value)
				SetLienPriorityTypeNull();
			else
			{
				_lienprioritytype = Convert.ToInt16(data["LienPriorityType"]);
				_lienprioritytype_isnull = false;
			}
			// assigns the LoanDocumentationType data to the class member
			if (data["LoanDocumentationType"] == System.DBNull.Value)
				SetLoanDocumentationTypeNull();
			else
			{
				_loandocumentationtype = Convert.ToInt16(data["LoanDocumentationType"]);
				_loandocumentationtype_isnull = false;
			}
			// assigns the LoanRepaymentType data to the class member
			if (data["LoanRepaymentType"] == System.DBNull.Value)
				SetLoanRepaymentTypeNull();
			else
			{
				_loanrepaymenttype = Convert.ToInt16(data["LoanRepaymentType"]);
				_loanrepaymenttype_isnull = false;
			}
			// assigns the MICertificationStatusType data to the class member
			if (data["MICertificationStatusType"] == System.DBNull.Value)
				SetMICertificationStatusTypeNull();
			else
			{
				_micertificationstatustype = Convert.ToInt16(data["MICertificationStatusType"]);
				_micertificationstatustype_isnull = false;
			}
			// assigns the MICompanyNameType data to the class member
			if (data["MICompanyNameType"] == System.DBNull.Value)
				SetMICompanyNameTypeNull();
			else
			{
				_micompanynametype = Convert.ToInt16(data["MICompanyNameType"]);
				_micompanynametype_isnull = false;
			}
			// assigns the PaymentFrequencyType data to the class member
			if (data["PaymentFrequencyType"] == System.DBNull.Value)
				SetPaymentFrequencyTypeNull();
			else
			{
				_paymentfrequencytype = Convert.ToInt16(data["PaymentFrequencyType"]);
				_paymentfrequencytype_isnull = false;
			}
			// assigns the FullPrepaymentPenaltyOptionType data to the class member
			if (data["FullPrepaymentPenaltyOptionType"] == System.DBNull.Value)
				SetFullPrepaymentPenaltyOptionTypeNull();
			else
			{
				_fullprepaymentpenaltyoptiontype = Convert.ToInt16(data["FullPrepaymentPenaltyOptionType"]);
				_fullprepaymentpenaltyoptiontype_isnull = false;
			}
			// assigns the LoanClosingStatusType data to the class member
			if (data["LoanClosingStatusType"] == System.DBNull.Value)
				SetLoanClosingStatusTypeNull();
			else
			{
				_loanclosingstatustype = Convert.ToInt16(data["LoanClosingStatusType"]);
				_loanclosingstatustype_isnull = false;
			}
			// assigns the ServicingTransferStatusType data to the class member
			if (data["ServicingTransferStatusType"] == System.DBNull.Value)
				SetServicingTransferStatusTypeNull();
			else
			{
				_servicingtransferstatustype = Convert.ToInt16(data["ServicingTransferStatusType"]);
				_servicingtransferstatustype_isnull = false;
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
			// assigns the AssumabilityIndicator data to the class member
			_assumabilityindicator = Convert.ToBoolean(data["AssumabilityIndicator"]);
			_assumabilityindicator_assigned = true;
			// assigns the BalloonIndicator data to the class member
			_balloonindicator = Convert.ToBoolean(data["BalloonIndicator"]);
			_balloonindicator_assigned = true;
			// assigns the BalloonLoanMaturityTermMonths data to the class member
			if (data["BalloonLoanMaturityTermMonths"] == System.DBNull.Value)
				SetBalloonLoanMaturityTermMonthsNull();
			else
			{
				_balloonloanmaturitytermmonths = Convert.ToDecimal(data["BalloonLoanMaturityTermMonths"]);
				_balloonloanmaturitytermmonths_isnull = false;
			}
			// assigns the BuydownTemporarySubsidyIndicator data to the class member
			_buydowntemporarysubsidyindicator = Convert.ToBoolean(data["BuydownTemporarySubsidyIndicator"]);
			_buydowntemporarysubsidyindicator_assigned = true;
			// assigns the CounselingConfirmationIndicator data to the class member
			_counselingconfirmationindicator = Convert.ToBoolean(data["CounselingConfirmationIndicator"]);
			_counselingconfirmationindicator_assigned = true;
			// assigns the EscrowWaiverIndicator data to the class member
			_escrowwaiverindicator = Convert.ToBoolean(data["EscrowWaiverIndicator"]);
			_escrowwaiverindicator_assigned = true;
			// assigns the FREOfferingIdentifier data to the class member
			if (data["FREOfferingIdentifier"] == System.DBNull.Value)
				SetFREOfferingIdentifierNull();
			else
			{
				_freofferingidentifier = Convert.ToString(data["FREOfferingIdentifier"]);
			}
			// assigns the FNMProductPlanIdentifier data to the class member
			if (data["FNMProductPlanIdentifier"] == System.DBNull.Value)
				SetFNMProductPlanIdentifierNull();
			else
			{
				_fnmproductplanidentifier = Convert.ToString(data["FNMProductPlanIdentifier"]);
			}
			// assigns the FNMProductPlanIndentifier data to the class member
			if (data["FNMProductPlanIndentifier"] == System.DBNull.Value)
				SetFNMProductPlanIndentifierNull();
			else
			{
				_fnmproductplanindentifier = Convert.ToString(data["FNMProductPlanIndentifier"]);
			}
			// assigns the HELOCMaximumBalanceAmount data to the class member
			if (data["HELOCMaximumBalanceAmount"] == System.DBNull.Value)
				SetHELOCMaximumBalanceAmountNull();
			else
			{
				_helocmaximumbalanceamount = Convert.ToDecimal(data["HELOCMaximumBalanceAmount"]);
				_helocmaximumbalanceamount_isnull = false;
			}
			// assigns the HELOCInitialAdvanceAmount data to the class member
			if (data["HELOCInitialAdvanceAmount"] == System.DBNull.Value)
				SetHELOCInitialAdvanceAmountNull();
			else
			{
				_helocinitialadvanceamount = Convert.ToDecimal(data["HELOCInitialAdvanceAmount"]);
				_helocinitialadvanceamount_isnull = false;
			}
			// assigns the InterestOnlyTerm data to the class member
			if (data["InterestOnlyTerm"] == System.DBNull.Value)
				SetInterestOnlyTermNull();
			else
			{
				_interestonlyterm = Convert.ToDecimal(data["InterestOnlyTerm"]);
				_interestonlyterm_isnull = false;
			}
			// assigns the LenderSelfInsuredIndicator data to the class member
			_lenderselfinsuredindicator = Convert.ToBoolean(data["LenderSelfInsuredIndicator"]);
			_lenderselfinsuredindicator_assigned = true;
			// assigns the LoanScheduledClosingDate data to the class member
			if (data["LoanScheduledClosingDate"] == System.DBNull.Value)
				SetLoanScheduledClosingDateNull();
			else
			{
				_loanscheduledclosingdate = Convert.ToDateTime(data["LoanScheduledClosingDate"]);
				_loanscheduledclosingdate_isnull = false;
			}
			// assigns the MICoveragePercent data to the class member
			if (data["MICoveragePercent"] == System.DBNull.Value)
				SetMICoveragePercentNull();
			else
			{
				_micoveragepercent = Convert.ToDecimal(data["MICoveragePercent"]);
				_micoveragepercent_isnull = false;
			}
			// assigns the NegativeAmortizationLimitPercent data to the class member
			if (data["NegativeAmortizationLimitPercent"] == System.DBNull.Value)
				SetNegativeAmortizationLimitPercentNull();
			else
			{
				_negativeamortizationlimitpercent = Convert.ToDecimal(data["NegativeAmortizationLimitPercent"]);
				_negativeamortizationlimitpercent_isnull = false;
			}
			// assigns the PrepaymentPenaltyIndicator data to the class member
			_prepaymentpenaltyindicator = Convert.ToBoolean(data["PrepaymentPenaltyIndicator"]);
			_prepaymentpenaltyindicator_assigned = true;
			// assigns the PrepaymentPenaltyTermMonths data to the class member
			if (data["PrepaymentPenaltyTermMonths"] == System.DBNull.Value)
				SetPrepaymentPenaltyTermMonthsNull();
			else
			{
				_prepaymentpenaltytermmonths = Convert.ToDecimal(data["PrepaymentPenaltyTermMonths"]);
				_prepaymentpenaltytermmonths_isnull = false;
			}
			// assigns the PrepaymentRestrictionIndicator data to the class member
			_prepaymentrestrictionindicator = Convert.ToBoolean(data["PrepaymentRestrictionIndicator"]);
			_prepaymentrestrictionindicator_assigned = true;
			// assigns the ProductDescription data to the class member
			if (data["ProductDescription"] == System.DBNull.Value)
				SetProductDescriptionNull();
			else
			{
				_productdescription = Convert.ToString(data["ProductDescription"]);
			}
			// assigns the ProductName data to the class member
			if (data["ProductName"] == System.DBNull.Value)
				SetProductNameNull();
			else
			{
				_productname = Convert.ToString(data["ProductName"]);
			}
			// assigns the ScheduledFirstPaymentDate data to the class member
			if (data["ScheduledFirstPaymentDate"] == System.DBNull.Value)
				SetScheduledFirstPaymentDateNull();
			else
			{
				_scheduledfirstpaymentdate = Convert.ToDateTime(data["ScheduledFirstPaymentDate"]);
				_scheduledfirstpaymentdate_isnull = false;
			}
			// assigns the NameDocumentsDrawnInType data to the class member
			if (data["NameDocumentsDrawnInType"] == System.DBNull.Value)
				SetNameDocumentsDrawnInTypeNull();
			else
			{
				_namedocumentsdrawnintype = Convert.ToInt16(data["NameDocumentsDrawnInType"]);
				_namedocumentsdrawnintype_isnull = false;
			}
			// assigns the GSEProjectClassificationType data to the class member
			if (data["GSEProjectClassificationType"] == System.DBNull.Value)
				SetGSEProjectClassificationTypeNull();
			else
			{
				_gseprojectclassificationtype = Convert.ToInt16(data["GSEProjectClassificationType"]);
				_gseprojectclassificationtype_isnull = false;
			}
			// assigns the GSEPropertyType data to the class member
			if (data["GSEPropertyType"] == System.DBNull.Value)
				SetGSEPropertyTypeNull();
			else
			{
				_gsepropertytype = Convert.ToInt16(data["GSEPropertyType"]);
				_gsepropertytype_isnull = false;
			}
			// assigns the LienPriorityType data to the class member
			if (data["LienPriorityType"] == System.DBNull.Value)
				SetLienPriorityTypeNull();
			else
			{
				_lienprioritytype = Convert.ToInt16(data["LienPriorityType"]);
				_lienprioritytype_isnull = false;
			}
			// assigns the LoanDocumentationType data to the class member
			if (data["LoanDocumentationType"] == System.DBNull.Value)
				SetLoanDocumentationTypeNull();
			else
			{
				_loandocumentationtype = Convert.ToInt16(data["LoanDocumentationType"]);
				_loandocumentationtype_isnull = false;
			}
			// assigns the LoanRepaymentType data to the class member
			if (data["LoanRepaymentType"] == System.DBNull.Value)
				SetLoanRepaymentTypeNull();
			else
			{
				_loanrepaymenttype = Convert.ToInt16(data["LoanRepaymentType"]);
				_loanrepaymenttype_isnull = false;
			}
			// assigns the MICertificationStatusType data to the class member
			if (data["MICertificationStatusType"] == System.DBNull.Value)
				SetMICertificationStatusTypeNull();
			else
			{
				_micertificationstatustype = Convert.ToInt16(data["MICertificationStatusType"]);
				_micertificationstatustype_isnull = false;
			}
			// assigns the MICompanyNameType data to the class member
			if (data["MICompanyNameType"] == System.DBNull.Value)
				SetMICompanyNameTypeNull();
			else
			{
				_micompanynametype = Convert.ToInt16(data["MICompanyNameType"]);
				_micompanynametype_isnull = false;
			}
			// assigns the PaymentFrequencyType data to the class member
			if (data["PaymentFrequencyType"] == System.DBNull.Value)
				SetPaymentFrequencyTypeNull();
			else
			{
				_paymentfrequencytype = Convert.ToInt16(data["PaymentFrequencyType"]);
				_paymentfrequencytype_isnull = false;
			}
			// assigns the FullPrepaymentPenaltyOptionType data to the class member
			if (data["FullPrepaymentPenaltyOptionType"] == System.DBNull.Value)
				SetFullPrepaymentPenaltyOptionTypeNull();
			else
			{
				_fullprepaymentpenaltyoptiontype = Convert.ToInt16(data["FullPrepaymentPenaltyOptionType"]);
				_fullprepaymentpenaltyoptiontype_isnull = false;
			}
			// assigns the LoanClosingStatusType data to the class member
			if (data["LoanClosingStatusType"] == System.DBNull.Value)
				SetLoanClosingStatusTypeNull();
			else
			{
				_loanclosingstatustype = Convert.ToInt16(data["LoanClosingStatusType"]);
				_loanclosingstatustype_isnull = false;
			}
			// assigns the ServicingTransferStatusType data to the class member
			if (data["ServicingTransferStatusType"] == System.DBNull.Value)
				SetServicingTransferStatusTypeNull();
			else
			{
				_servicingtransferstatustype = Convert.ToInt16(data["ServicingTransferStatusType"]);
				_servicingtransferstatustype_isnull = false;
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
			LoanFeaturesBase.ServiceObject.Persist(this as LoanFeatures, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the LOAN_FEATURES object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			LoanFeaturesBase.ServiceObject.Delete(this as LoanFeatures);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the FullPrepaymentPenaltyOptionType relationship.
		/// </summary>
		public FullPrepaymentPenaltyOptionType GetFullPrepaymentPenaltyOptionType()
		{
			if (_fullprepaymentpenaltyoptiontype_isnull)
				return null;
			else
				return new FullPrepaymentPenaltyOptionType(_fullprepaymentpenaltyoptiontype);
		}


		/// <summary>
		/// Gets the single object for the GSEProjectClassificationType relationship.
		/// </summary>
		public GSEProjectClassificationType GetGSEProjectClassificationType()
		{
			if (_gseprojectclassificationtype_isnull)
				return null;
			else
				return new GSEProjectClassificationType(_gseprojectclassificationtype);
		}


		/// <summary>
		/// Gets the single object for the GSEPropertyType relationship.
		/// </summary>
		public GSEPropertyType GetGSEPropertyType()
		{
			if (_gsepropertytype_isnull)
				return null;
			else
				return new GSEPropertyType(_gsepropertytype);
		}


		/// <summary>
		/// Gets the single object for the LienPriorityType relationship.
		/// </summary>
		public LienPriorityType GetLienPriorityType()
		{
			if (_lienprioritytype_isnull)
				return null;
			else
				return new LienPriorityType(_lienprioritytype);
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
		/// Gets the single object for the LoanClosingStatusType relationship.
		/// </summary>
		public LoanClosingStatusType GetLoanClosingStatusType()
		{
			if (_loanclosingstatustype_isnull)
				return null;
			else
				return new LoanClosingStatusType(_loanclosingstatustype);
		}


		/// <summary>
		/// Gets the single object for the LoanDocumentationType relationship.
		/// </summary>
		public LoanDocumentationType GetLoanDocumentationType()
		{
			if (_loandocumentationtype_isnull)
				return null;
			else
				return new LoanDocumentationType(_loandocumentationtype);
		}


		/// <summary>
		/// Gets the single object for the LoanRepaymentType relationship.
		/// </summary>
		public LoanRepaymentType GetLoanRepaymentType()
		{
			if (_loanrepaymenttype_isnull)
				return null;
			else
				return new LoanRepaymentType(_loanrepaymenttype);
		}


		/// <summary>
		/// Gets the single object for the MICertificationStatusType relationship.
		/// </summary>
		public MICertificationStatusType GetMICertificationStatusType()
		{
			if (_micertificationstatustype_isnull)
				return null;
			else
				return new MICertificationStatusType(_micertificationstatustype);
		}


		/// <summary>
		/// Gets the single object for the MICompanyNameType relationship.
		/// </summary>
		public MICompanyNameType GetMICompanyNameType()
		{
			if (_micompanynametype_isnull)
				return null;
			else
				return new MICompanyNameType(_micompanynametype);
		}


		/// <summary>
		/// Gets the single object for the NameDocumentsDrawnInType relationship.
		/// </summary>
		public NameDocumentsDrawnInType GetNameDocumentsDrawnInType()
		{
			if (_namedocumentsdrawnintype_isnull)
				return null;
			else
				return new NameDocumentsDrawnInType(_namedocumentsdrawnintype);
		}


		/// <summary>
		/// Gets the single object for the PaymentFrequencyType relationship.
		/// </summary>
		public PaymentFrequencyType GetPaymentFrequencyType()
		{
			if (_paymentfrequencytype_isnull)
				return null;
			else
				return new PaymentFrequencyType(_paymentfrequencytype);
		}


		/// <summary>
		/// Gets the single object for the ServicingTransferStatusType relationship.
		/// </summary>
		public ServicingTransferStatusType GetServicingTransferStatusType()
		{
			if (_servicingtransferstatustype_isnull)
				return null;
			else
				return new ServicingTransferStatusType(_servicingtransferstatustype);
		}


		/// <summary>
		/// Gets all persisted LoanFeatures objects
		/// </summary>
		public static LoanFeaturesCollection GetAll()
		{
			// have the service object get the objects
			return LoanFeaturesBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
