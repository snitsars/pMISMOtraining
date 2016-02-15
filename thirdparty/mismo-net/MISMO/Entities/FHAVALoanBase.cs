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
	/// A class that represents an abstract entity for table 'FHA_VA_LOAN'
	/// </summary>
	[Serializable]
	public abstract class FHAVALoanBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVALoanBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.FHAVALoan)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FHAVALoanBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			FHAVALoanBase.ServiceObject.Fill(this as FHAVALoan, loanApplicationId);
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
		internal bool _borrowerpaidfha_vaclosingcostsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerpaidfha_vaclosingcostsamount.
		/// </summary>
		internal System.Decimal _borrowerpaidfha_vaclosingcostsamount;
		/// <summary>
		/// Gets and sets the BorrowerPaidFHA_VAClosingCostsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerPaidFHA_VAClosingCostsAmount
		{
			get
			{
				return _borrowerpaidfha_vaclosingcostsamount;
			}
			set
			{
				_borrowerpaidfha_vaclosingcostsamount = value;
				_borrowerpaidfha_vaclosingcostsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerPaidFHA_VAClosingCostsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerPaidFHA_VAClosingCostsAmountIsNull
		{
			get
			{
				return _borrowerpaidfha_vaclosingcostsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerpaidfha_vaclosingcostspercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerpaidfha_vaclosingcostspercent.
		/// </summary>
		internal System.Decimal _borrowerpaidfha_vaclosingcostspercent;
		/// <summary>
		/// Gets and sets the BorrowerPaidFHA_VAClosingCostsPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerPaidFHA_VAClosingCostsPercent
		{
			get
			{
				return _borrowerpaidfha_vaclosingcostspercent;
			}
			set
			{
				_borrowerpaidfha_vaclosingcostspercent = value;
				_borrowerpaidfha_vaclosingcostspercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerPaidFHA_VAClosingCostsPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerPaidFHA_VAClosingCostsPercentIsNull
		{
			get
			{
				return _borrowerpaidfha_vaclosingcostspercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _governmentmortgagecreditcertificateamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the governmentmortgagecreditcertificateamount.
		/// </summary>
		internal System.Decimal _governmentmortgagecreditcertificateamount;
		/// <summary>
		/// Gets and sets the GovernmentMortgageCreditCertificateAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal GovernmentMortgageCreditCertificateAmount
		{
			get
			{
				return _governmentmortgagecreditcertificateamount;
			}
			set
			{
				_governmentmortgagecreditcertificateamount = value;
				_governmentmortgagecreditcertificateamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the GovernmentMortgageCreditCertificateAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean GovernmentMortgageCreditCertificateAmountIsNull
		{
			get
			{
				return _governmentmortgagecreditcertificateamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _governmentrefinancetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the governmentrefinancetype.
		/// </summary>
		internal System.Int16 _governmentrefinancetype;
		/// <summary>
		/// Gets and sets the GovernmentRefinanceType value of the class instance.
		/// </summary>
		public virtual System.Int16 GovernmentRefinanceType
		{
			get
			{
				return _governmentrefinancetype;
			}
			set
			{
				_governmentrefinancetype = value;
				_governmentrefinancetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the GovernmentRefinanceType value to see if it was set to null.
		/// </summary>
		public System.Boolean GovernmentRefinanceTypeIsNull
		{
			get
			{
				return _governmentrefinancetype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _otherpartypaidfha_vaclosingcostsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the otherpartypaidfha_vaclosingcostsamount.
		/// </summary>
		internal System.Decimal _otherpartypaidfha_vaclosingcostsamount;
		/// <summary>
		/// Gets and sets the OtherPartyPaidFHA_VAClosingCostsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal OtherPartyPaidFHA_VAClosingCostsAmount
		{
			get
			{
				return _otherpartypaidfha_vaclosingcostsamount;
			}
			set
			{
				_otherpartypaidfha_vaclosingcostsamount = value;
				_otherpartypaidfha_vaclosingcostsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the OtherPartyPaidFHA_VAClosingCostsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherPartyPaidFHA_VAClosingCostsAmountIsNull
		{
			get
			{
				return _otherpartypaidfha_vaclosingcostsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _otherpartypaidfha_vaclosingcostspercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the otherpartypaidfha_vaclosingcostspercent.
		/// </summary>
		internal System.Decimal _otherpartypaidfha_vaclosingcostspercent;
		/// <summary>
		/// Gets and sets the OtherPartyPaidFHA_VAClosingCostsPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal OtherPartyPaidFHA_VAClosingCostsPercent
		{
			get
			{
				return _otherpartypaidfha_vaclosingcostspercent;
			}
			set
			{
				_otherpartypaidfha_vaclosingcostspercent = value;
				_otherpartypaidfha_vaclosingcostspercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the OtherPartyPaidFHA_VAClosingCostsPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherPartyPaidFHA_VAClosingCostsPercentIsNull
		{
			get
			{
				return _otherpartypaidfha_vaclosingcostspercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyenergyefficienthomeindicator_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyenergyefficienthomeindicator.
		/// </summary>
		internal System.Boolean _propertyenergyefficienthomeindicator;
		/// <summary>
		/// Gets and sets the PropertyEnergyEfficientHomeIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PropertyEnergyEfficientHomeIndicator
		{
			get
			{
				return _propertyenergyefficienthomeindicator;
			}
			set
			{
				_propertyenergyefficienthomeindicator = value;
				_propertyenergyefficienthomeindicator_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyEnergyEfficientHomeIndicator value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyEnergyEfficientHomeIndicatorIsNull
		{
			get
			{
				return _propertyenergyefficienthomeindicator_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _sellerpaidfha_vaclosingcostspercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the sellerpaidfha_vaclosingcostspercent.
		/// </summary>
		internal System.Decimal _sellerpaidfha_vaclosingcostspercent;
		/// <summary>
		/// Gets and sets the SellerPaidFHA_VAClosingCostsPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal SellerPaidFHA_VAClosingCostsPercent
		{
			get
			{
				return _sellerpaidfha_vaclosingcostspercent;
			}
			set
			{
				_sellerpaidfha_vaclosingcostspercent = value;
				_sellerpaidfha_vaclosingcostspercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SellerPaidFHA_VAClosingCostsPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean SellerPaidFHA_VAClosingCostsPercentIsNull
		{
			get
			{
				return _sellerpaidfha_vaclosingcostspercent_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the FHAVALoanBase.
		/// </summary>
		internal static FHAVALoanService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(FHAVALoanService)) as FHAVALoanService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of FHAVALoanBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the BorrowerPaidFHA_VAClosingCostsAmount value as null.
		/// </summary>
		public virtual void SetBorrowerPaidFHA_VAClosingCostsAmountNull()
		{
			_borrowerpaidfha_vaclosingcostsamount = 0;
			_borrowerpaidfha_vaclosingcostsamount_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerPaidFHA_VAClosingCostsPercent value as null.
		/// </summary>
		public virtual void SetBorrowerPaidFHA_VAClosingCostsPercentNull()
		{
			_borrowerpaidfha_vaclosingcostspercent = 0;
			_borrowerpaidfha_vaclosingcostspercent_isnull = true;
		}


		/// <summary>
		/// Marks the GovernmentMortgageCreditCertificateAmount value as null.
		/// </summary>
		public virtual void SetGovernmentMortgageCreditCertificateAmountNull()
		{
			_governmentmortgagecreditcertificateamount = 0;
			_governmentmortgagecreditcertificateamount_isnull = true;
		}


		/// <summary>
		/// Marks the GovernmentRefinanceType value as null.
		/// </summary>
		public virtual void SetGovernmentRefinanceTypeNull()
		{
			_governmentrefinancetype = 0;
			_governmentrefinancetype_isnull = true;
		}


		/// <summary>
		/// Marks the OtherPartyPaidFHA_VAClosingCostsAmount value as null.
		/// </summary>
		public virtual void SetOtherPartyPaidFHA_VAClosingCostsAmountNull()
		{
			_otherpartypaidfha_vaclosingcostsamount = 0;
			_otherpartypaidfha_vaclosingcostsamount_isnull = true;
		}


		/// <summary>
		/// Marks the OtherPartyPaidFHA_VAClosingCostsPercent value as null.
		/// </summary>
		public virtual void SetOtherPartyPaidFHA_VAClosingCostsPercentNull()
		{
			_otherpartypaidfha_vaclosingcostspercent = 0;
			_otherpartypaidfha_vaclosingcostspercent_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyEnergyEfficientHomeIndicator value as null.
		/// </summary>
		public virtual void SetPropertyEnergyEfficientHomeIndicatorNull()
		{
			_propertyenergyefficienthomeindicator = false;
			_propertyenergyefficienthomeindicator_isnull = true;
		}


		/// <summary>
		/// Marks the SellerPaidFHA_VAClosingCostsPercent value as null.
		/// </summary>
		public virtual void SetSellerPaidFHA_VAClosingCostsPercentNull()
		{
			_sellerpaidfha_vaclosingcostspercent = 0;
			_sellerpaidfha_vaclosingcostspercent_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref FHAVALoanBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the BorrowerPaidFHA_VAClosingCostsAmount data to the class member
			_borrowerpaidfha_vaclosingcostsamount = data._borrowerpaidfha_vaclosingcostsamount;
			_borrowerpaidfha_vaclosingcostsamount_isnull = data._borrowerpaidfha_vaclosingcostsamount_isnull;
			// assigns the BorrowerPaidFHA_VAClosingCostsPercent data to the class member
			_borrowerpaidfha_vaclosingcostspercent = data._borrowerpaidfha_vaclosingcostspercent;
			_borrowerpaidfha_vaclosingcostspercent_isnull = data._borrowerpaidfha_vaclosingcostspercent_isnull;
			// assigns the GovernmentMortgageCreditCertificateAmount data to the class member
			_governmentmortgagecreditcertificateamount = data._governmentmortgagecreditcertificateamount;
			_governmentmortgagecreditcertificateamount_isnull = data._governmentmortgagecreditcertificateamount_isnull;
			// assigns the GovernmentRefinanceType data to the class member
			_governmentrefinancetype = data._governmentrefinancetype;
			_governmentrefinancetype_isnull = data._governmentrefinancetype_isnull;
			// assigns the OtherPartyPaidFHA_VAClosingCostsAmount data to the class member
			_otherpartypaidfha_vaclosingcostsamount = data._otherpartypaidfha_vaclosingcostsamount;
			_otherpartypaidfha_vaclosingcostsamount_isnull = data._otherpartypaidfha_vaclosingcostsamount_isnull;
			// assigns the OtherPartyPaidFHA_VAClosingCostsPercent data to the class member
			_otherpartypaidfha_vaclosingcostspercent = data._otherpartypaidfha_vaclosingcostspercent;
			_otherpartypaidfha_vaclosingcostspercent_isnull = data._otherpartypaidfha_vaclosingcostspercent_isnull;
			// assigns the PropertyEnergyEfficientHomeIndicator data to the class member
			_propertyenergyefficienthomeindicator = data._propertyenergyefficienthomeindicator;
			_propertyenergyefficienthomeindicator_isnull = data._propertyenergyefficienthomeindicator_isnull;
			// assigns the SellerPaidFHA_VAClosingCostsPercent data to the class member
			_sellerpaidfha_vaclosingcostspercent = data._sellerpaidfha_vaclosingcostspercent;
			_sellerpaidfha_vaclosingcostspercent_isnull = data._sellerpaidfha_vaclosingcostspercent_isnull;


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
			// assigns the BorrowerPaidFHA_VAClosingCostsAmount data to the class member
			if (data["BorrowerPaidFHA_VAClosingCostsAmount"] == System.DBNull.Value)
				SetBorrowerPaidFHA_VAClosingCostsAmountNull();
			else
			{
				_borrowerpaidfha_vaclosingcostsamount = Convert.ToDecimal(data["BorrowerPaidFHA_VAClosingCostsAmount"]);
				_borrowerpaidfha_vaclosingcostsamount_isnull = false;
			}
			// assigns the BorrowerPaidFHA_VAClosingCostsPercent data to the class member
			if (data["BorrowerPaidFHA_VAClosingCostsPercent"] == System.DBNull.Value)
				SetBorrowerPaidFHA_VAClosingCostsPercentNull();
			else
			{
				_borrowerpaidfha_vaclosingcostspercent = Convert.ToDecimal(data["BorrowerPaidFHA_VAClosingCostsPercent"]);
				_borrowerpaidfha_vaclosingcostspercent_isnull = false;
			}
			// assigns the GovernmentMortgageCreditCertificateAmount data to the class member
			if (data["GovernmentMortgageCreditCertificateAmount"] == System.DBNull.Value)
				SetGovernmentMortgageCreditCertificateAmountNull();
			else
			{
				_governmentmortgagecreditcertificateamount = Convert.ToDecimal(data["GovernmentMortgageCreditCertificateAmount"]);
				_governmentmortgagecreditcertificateamount_isnull = false;
			}
			// assigns the GovernmentRefinanceType data to the class member
			if (data["GovernmentRefinanceType"] == System.DBNull.Value)
				SetGovernmentRefinanceTypeNull();
			else
			{
				_governmentrefinancetype = Convert.ToInt16(data["GovernmentRefinanceType"]);
				_governmentrefinancetype_isnull = false;
			}
			// assigns the OtherPartyPaidFHA_VAClosingCostsAmount data to the class member
			if (data["OtherPartyPaidFHA_VAClosingCostsAmount"] == System.DBNull.Value)
				SetOtherPartyPaidFHA_VAClosingCostsAmountNull();
			else
			{
				_otherpartypaidfha_vaclosingcostsamount = Convert.ToDecimal(data["OtherPartyPaidFHA_VAClosingCostsAmount"]);
				_otherpartypaidfha_vaclosingcostsamount_isnull = false;
			}
			// assigns the OtherPartyPaidFHA_VAClosingCostsPercent data to the class member
			if (data["OtherPartyPaidFHA_VAClosingCostsPercent"] == System.DBNull.Value)
				SetOtherPartyPaidFHA_VAClosingCostsPercentNull();
			else
			{
				_otherpartypaidfha_vaclosingcostspercent = Convert.ToDecimal(data["OtherPartyPaidFHA_VAClosingCostsPercent"]);
				_otherpartypaidfha_vaclosingcostspercent_isnull = false;
			}
			// assigns the PropertyEnergyEfficientHomeIndicator data to the class member
			if (data["PropertyEnergyEfficientHomeIndicator"] == System.DBNull.Value)
				SetPropertyEnergyEfficientHomeIndicatorNull();
			else
			{
				_propertyenergyefficienthomeindicator = Convert.ToBoolean(data["PropertyEnergyEfficientHomeIndicator"]);
				_propertyenergyefficienthomeindicator_isnull = false;
			}
			// assigns the SellerPaidFHA_VAClosingCostsPercent data to the class member
			if (data["SellerPaidFHA_VAClosingCostsPercent"] == System.DBNull.Value)
				SetSellerPaidFHA_VAClosingCostsPercentNull();
			else
			{
				_sellerpaidfha_vaclosingcostspercent = Convert.ToDecimal(data["SellerPaidFHA_VAClosingCostsPercent"]);
				_sellerpaidfha_vaclosingcostspercent_isnull = false;
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
			// assigns the BorrowerPaidFHA_VAClosingCostsAmount data to the class member
			if (data["BorrowerPaidFHA_VAClosingCostsAmount"] == System.DBNull.Value)
				SetBorrowerPaidFHA_VAClosingCostsAmountNull();
			else
			{
				_borrowerpaidfha_vaclosingcostsamount = Convert.ToDecimal(data["BorrowerPaidFHA_VAClosingCostsAmount"]);
				_borrowerpaidfha_vaclosingcostsamount_isnull = false;
			}
			// assigns the BorrowerPaidFHA_VAClosingCostsPercent data to the class member
			if (data["BorrowerPaidFHA_VAClosingCostsPercent"] == System.DBNull.Value)
				SetBorrowerPaidFHA_VAClosingCostsPercentNull();
			else
			{
				_borrowerpaidfha_vaclosingcostspercent = Convert.ToDecimal(data["BorrowerPaidFHA_VAClosingCostsPercent"]);
				_borrowerpaidfha_vaclosingcostspercent_isnull = false;
			}
			// assigns the GovernmentMortgageCreditCertificateAmount data to the class member
			if (data["GovernmentMortgageCreditCertificateAmount"] == System.DBNull.Value)
				SetGovernmentMortgageCreditCertificateAmountNull();
			else
			{
				_governmentmortgagecreditcertificateamount = Convert.ToDecimal(data["GovernmentMortgageCreditCertificateAmount"]);
				_governmentmortgagecreditcertificateamount_isnull = false;
			}
			// assigns the GovernmentRefinanceType data to the class member
			if (data["GovernmentRefinanceType"] == System.DBNull.Value)
				SetGovernmentRefinanceTypeNull();
			else
			{
				_governmentrefinancetype = Convert.ToInt16(data["GovernmentRefinanceType"]);
				_governmentrefinancetype_isnull = false;
			}
			// assigns the OtherPartyPaidFHA_VAClosingCostsAmount data to the class member
			if (data["OtherPartyPaidFHA_VAClosingCostsAmount"] == System.DBNull.Value)
				SetOtherPartyPaidFHA_VAClosingCostsAmountNull();
			else
			{
				_otherpartypaidfha_vaclosingcostsamount = Convert.ToDecimal(data["OtherPartyPaidFHA_VAClosingCostsAmount"]);
				_otherpartypaidfha_vaclosingcostsamount_isnull = false;
			}
			// assigns the OtherPartyPaidFHA_VAClosingCostsPercent data to the class member
			if (data["OtherPartyPaidFHA_VAClosingCostsPercent"] == System.DBNull.Value)
				SetOtherPartyPaidFHA_VAClosingCostsPercentNull();
			else
			{
				_otherpartypaidfha_vaclosingcostspercent = Convert.ToDecimal(data["OtherPartyPaidFHA_VAClosingCostsPercent"]);
				_otherpartypaidfha_vaclosingcostspercent_isnull = false;
			}
			// assigns the PropertyEnergyEfficientHomeIndicator data to the class member
			if (data["PropertyEnergyEfficientHomeIndicator"] == System.DBNull.Value)
				SetPropertyEnergyEfficientHomeIndicatorNull();
			else
			{
				_propertyenergyefficienthomeindicator = Convert.ToBoolean(data["PropertyEnergyEfficientHomeIndicator"]);
				_propertyenergyefficienthomeindicator_isnull = false;
			}
			// assigns the SellerPaidFHA_VAClosingCostsPercent data to the class member
			if (data["SellerPaidFHA_VAClosingCostsPercent"] == System.DBNull.Value)
				SetSellerPaidFHA_VAClosingCostsPercentNull();
			else
			{
				_sellerpaidfha_vaclosingcostspercent = Convert.ToDecimal(data["SellerPaidFHA_VAClosingCostsPercent"]);
				_sellerpaidfha_vaclosingcostspercent_isnull = false;
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
			FHAVALoanBase.ServiceObject.Persist(this as FHAVALoan, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the FHA_VA_LOAN object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			FHAVALoanBase.ServiceObject.Delete(this as FHAVALoan);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the GovernmentRefinanceType relationship.
		/// </summary>
		public GovernmentRefinanceType GetGovernmentRefinanceType()
		{
			if (_governmentrefinancetype_isnull)
				return null;
			else
				return new GovernmentRefinanceType(_governmentrefinancetype);
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
		/// Gets all persisted FHAVALoan objects
		/// </summary>
		public static FHAVALoans GetAll()
		{
			// have the service object get the objects
			return FHAVALoanBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
