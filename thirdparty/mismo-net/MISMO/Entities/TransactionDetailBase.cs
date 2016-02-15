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
	/// A class that represents an abstract entity for table 'TRANSACTION_DETAIL'
	/// </summary>
	[Serializable]
	public abstract class TransactionDetailBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransactionDetailBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.TransactionDetail)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public TransactionDetailBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			TransactionDetailBase.ServiceObject.Fill(this as TransactionDetail, loanApplicationId);
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
		internal bool _alterationsimprovementsandrepairsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the alterationsimprovementsandrepairsamount.
		/// </summary>
		internal System.Decimal _alterationsimprovementsandrepairsamount;
		/// <summary>
		/// Gets and sets the AlterationsImprovementsAndRepairsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal AlterationsImprovementsAndRepairsAmount
		{
			get
			{
				return _alterationsimprovementsandrepairsamount;
			}
			set
			{
				_alterationsimprovementsandrepairsamount = value;
				_alterationsimprovementsandrepairsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AlterationsImprovementsAndRepairsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean AlterationsImprovementsAndRepairsAmountIsNull
		{
			get
			{
				return _alterationsimprovementsandrepairsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerpaiddiscountpointstotalamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerpaiddiscountpointstotalamount.
		/// </summary>
		internal System.Decimal _borrowerpaiddiscountpointstotalamount;
		/// <summary>
		/// Gets and sets the BorrowerPaidDiscountPointsTotalAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerPaidDiscountPointsTotalAmount
		{
			get
			{
				return _borrowerpaiddiscountpointstotalamount;
			}
			set
			{
				_borrowerpaiddiscountpointstotalamount = value;
				_borrowerpaiddiscountpointstotalamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerPaidDiscountPointsTotalAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerPaidDiscountPointsTotalAmountIsNull
		{
			get
			{
				return _borrowerpaiddiscountpointstotalamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _estimatedclosingcostsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the estimatedclosingcostsamount.
		/// </summary>
		internal System.Decimal _estimatedclosingcostsamount;
		/// <summary>
		/// Gets and sets the EstimatedClosingCostsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal EstimatedClosingCostsAmount
		{
			get
			{
				return _estimatedclosingcostsamount;
			}
			set
			{
				_estimatedclosingcostsamount = value;
				_estimatedclosingcostsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the EstimatedClosingCostsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean EstimatedClosingCostsAmountIsNull
		{
			get
			{
				return _estimatedclosingcostsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _miandfundingfeefinancedamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the miandfundingfeefinancedamount.
		/// </summary>
		internal System.Decimal _miandfundingfeefinancedamount;
		/// <summary>
		/// Gets and sets the MIAndFundingFeeFinancedAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal MIAndFundingFeeFinancedAmount
		{
			get
			{
				return _miandfundingfeefinancedamount;
			}
			set
			{
				_miandfundingfeefinancedamount = value;
				_miandfundingfeefinancedamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MIAndFundingFeeFinancedAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean MIAndFundingFeeFinancedAmountIsNull
		{
			get
			{
				return _miandfundingfeefinancedamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _miandfundingfeetotalamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the miandfundingfeetotalamount.
		/// </summary>
		internal System.Decimal _miandfundingfeetotalamount;
		/// <summary>
		/// Gets and sets the MIAndFundingFeeTotalAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal MIAndFundingFeeTotalAmount
		{
			get
			{
				return _miandfundingfeetotalamount;
			}
			set
			{
				_miandfundingfeetotalamount = value;
				_miandfundingfeetotalamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MIAndFundingFeeTotalAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean MIAndFundingFeeTotalAmountIsNull
		{
			get
			{
				return _miandfundingfeetotalamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _prepaiditemsestimatedamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the prepaiditemsestimatedamount.
		/// </summary>
		internal System.Decimal _prepaiditemsestimatedamount;
		/// <summary>
		/// Gets and sets the PrepaidItemsEstimatedAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PrepaidItemsEstimatedAmount
		{
			get
			{
				return _prepaiditemsestimatedamount;
			}
			set
			{
				_prepaiditemsestimatedamount = value;
				_prepaiditemsestimatedamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PrepaidItemsEstimatedAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PrepaidItemsEstimatedAmountIsNull
		{
			get
			{
				return _prepaiditemsestimatedamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _purchasepriceamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the purchasepriceamount.
		/// </summary>
		internal System.Decimal _purchasepriceamount;
		/// <summary>
		/// Gets and sets the PurchasePriceAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PurchasePriceAmount
		{
			get
			{
				return _purchasepriceamount;
			}
			set
			{
				_purchasepriceamount = value;
				_purchasepriceamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PurchasePriceAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PurchasePriceAmountIsNull
		{
			get
			{
				return _purchasepriceamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _refinanceincludingdebtstobepaidoffamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the refinanceincludingdebtstobepaidoffamount.
		/// </summary>
		internal System.Decimal _refinanceincludingdebtstobepaidoffamount;
		/// <summary>
		/// Gets and sets the RefinanceIncludingDebtsToBePaidOffAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal RefinanceIncludingDebtsToBePaidOffAmount
		{
			get
			{
				return _refinanceincludingdebtstobepaidoffamount;
			}
			set
			{
				_refinanceincludingdebtstobepaidoffamount = value;
				_refinanceincludingdebtstobepaidoffamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RefinanceIncludingDebtsToBePaidOffAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean RefinanceIncludingDebtsToBePaidOffAmountIsNull
		{
			get
			{
				return _refinanceincludingdebtstobepaidoffamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _salesconcessionamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the salesconcessionamount.
		/// </summary>
		internal System.Decimal _salesconcessionamount;
		/// <summary>
		/// Gets and sets the SalesConcessionAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal SalesConcessionAmount
		{
			get
			{
				return _salesconcessionamount;
			}
			set
			{
				_salesconcessionamount = value;
				_salesconcessionamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SalesConcessionAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean SalesConcessionAmountIsNull
		{
			get
			{
				return _salesconcessionamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _sellerpaidclosingcostsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the sellerpaidclosingcostsamount.
		/// </summary>
		internal System.Decimal _sellerpaidclosingcostsamount;
		/// <summary>
		/// Gets and sets the SellerPaidClosingCostsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal SellerPaidClosingCostsAmount
		{
			get
			{
				return _sellerpaidclosingcostsamount;
			}
			set
			{
				_sellerpaidclosingcostsamount = value;
				_sellerpaidclosingcostsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SellerPaidClosingCostsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean SellerPaidClosingCostsAmountIsNull
		{
			get
			{
				return _sellerpaidclosingcostsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _subordinatelienamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the subordinatelienamount.
		/// </summary>
		internal System.Decimal _subordinatelienamount;
		/// <summary>
		/// Gets and sets the SubordinateLienAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal SubordinateLienAmount
		{
			get
			{
				return _subordinatelienamount;
			}
			set
			{
				_subordinatelienamount = value;
				_subordinatelienamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SubordinateLienAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean SubordinateLienAmountIsNull
		{
			get
			{
				return _subordinatelienamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _subordinatelienhelocamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the subordinatelienhelocamount.
		/// </summary>
		internal System.Decimal _subordinatelienhelocamount;
		/// <summary>
		/// Gets and sets the SubordinateLienHELOCAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal SubordinateLienHELOCAmount
		{
			get
			{
				return _subordinatelienhelocamount;
			}
			set
			{
				_subordinatelienhelocamount = value;
				_subordinatelienhelocamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SubordinateLienHELOCAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean SubordinateLienHELOCAmountIsNull
		{
			get
			{
				return _subordinatelienhelocamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _frereserveamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the frereserveamount.
		/// </summary>
		internal System.Decimal _frereserveamount;
		/// <summary>
		/// Gets and sets the FREReserveAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal FREReserveAmount
		{
			get
			{
				return _frereserveamount;
			}
			set
			{
				_frereserveamount = value;
				_frereserveamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FREReserveAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean FREReserveAmountIsNull
		{
			get
			{
				return _frereserveamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _frereservesamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the frereservesamount.
		/// </summary>
		internal System.Decimal _frereservesamount;
		/// <summary>
		/// Gets and sets the FREReservesAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal FREReservesAmount
		{
			get
			{
				return _frereservesamount;
			}
			set
			{
				_frereservesamount = value;
				_frereservesamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FREReservesAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean FREReservesAmountIsNull
		{
			get
			{
				return _frereservesamount_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the TransactionDetailBase.
		/// </summary>
		internal static TransactionDetailService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(TransactionDetailService)) as TransactionDetailService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of TransactionDetailBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the AlterationsImprovementsAndRepairsAmount value as null.
		/// </summary>
		public virtual void SetAlterationsImprovementsAndRepairsAmountNull()
		{
			_alterationsimprovementsandrepairsamount = 0;
			_alterationsimprovementsandrepairsamount_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerPaidDiscountPointsTotalAmount value as null.
		/// </summary>
		public virtual void SetBorrowerPaidDiscountPointsTotalAmountNull()
		{
			_borrowerpaiddiscountpointstotalamount = 0;
			_borrowerpaiddiscountpointstotalamount_isnull = true;
		}


		/// <summary>
		/// Marks the EstimatedClosingCostsAmount value as null.
		/// </summary>
		public virtual void SetEstimatedClosingCostsAmountNull()
		{
			_estimatedclosingcostsamount = 0;
			_estimatedclosingcostsamount_isnull = true;
		}


		/// <summary>
		/// Marks the MIAndFundingFeeFinancedAmount value as null.
		/// </summary>
		public virtual void SetMIAndFundingFeeFinancedAmountNull()
		{
			_miandfundingfeefinancedamount = 0;
			_miandfundingfeefinancedamount_isnull = true;
		}


		/// <summary>
		/// Marks the MIAndFundingFeeTotalAmount value as null.
		/// </summary>
		public virtual void SetMIAndFundingFeeTotalAmountNull()
		{
			_miandfundingfeetotalamount = 0;
			_miandfundingfeetotalamount_isnull = true;
		}


		/// <summary>
		/// Marks the PrepaidItemsEstimatedAmount value as null.
		/// </summary>
		public virtual void SetPrepaidItemsEstimatedAmountNull()
		{
			_prepaiditemsestimatedamount = 0;
			_prepaiditemsestimatedamount_isnull = true;
		}


		/// <summary>
		/// Marks the PurchasePriceAmount value as null.
		/// </summary>
		public virtual void SetPurchasePriceAmountNull()
		{
			_purchasepriceamount = 0;
			_purchasepriceamount_isnull = true;
		}


		/// <summary>
		/// Marks the RefinanceIncludingDebtsToBePaidOffAmount value as null.
		/// </summary>
		public virtual void SetRefinanceIncludingDebtsToBePaidOffAmountNull()
		{
			_refinanceincludingdebtstobepaidoffamount = 0;
			_refinanceincludingdebtstobepaidoffamount_isnull = true;
		}


		/// <summary>
		/// Marks the SalesConcessionAmount value as null.
		/// </summary>
		public virtual void SetSalesConcessionAmountNull()
		{
			_salesconcessionamount = 0;
			_salesconcessionamount_isnull = true;
		}


		/// <summary>
		/// Marks the SellerPaidClosingCostsAmount value as null.
		/// </summary>
		public virtual void SetSellerPaidClosingCostsAmountNull()
		{
			_sellerpaidclosingcostsamount = 0;
			_sellerpaidclosingcostsamount_isnull = true;
		}


		/// <summary>
		/// Marks the SubordinateLienAmount value as null.
		/// </summary>
		public virtual void SetSubordinateLienAmountNull()
		{
			_subordinatelienamount = 0;
			_subordinatelienamount_isnull = true;
		}


		/// <summary>
		/// Marks the SubordinateLienHELOCAmount value as null.
		/// </summary>
		public virtual void SetSubordinateLienHELOCAmountNull()
		{
			_subordinatelienhelocamount = 0;
			_subordinatelienhelocamount_isnull = true;
		}


		/// <summary>
		/// Marks the FREReserveAmount value as null.
		/// </summary>
		public virtual void SetFREReserveAmountNull()
		{
			_frereserveamount = 0;
			_frereserveamount_isnull = true;
		}


		/// <summary>
		/// Marks the FREReservesAmount value as null.
		/// </summary>
		public virtual void SetFREReservesAmountNull()
		{
			_frereservesamount = 0;
			_frereservesamount_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref TransactionDetailBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the AlterationsImprovementsAndRepairsAmount data to the class member
			_alterationsimprovementsandrepairsamount = data._alterationsimprovementsandrepairsamount;
			_alterationsimprovementsandrepairsamount_isnull = data._alterationsimprovementsandrepairsamount_isnull;
			// assigns the BorrowerPaidDiscountPointsTotalAmount data to the class member
			_borrowerpaiddiscountpointstotalamount = data._borrowerpaiddiscountpointstotalamount;
			_borrowerpaiddiscountpointstotalamount_isnull = data._borrowerpaiddiscountpointstotalamount_isnull;
			// assigns the EstimatedClosingCostsAmount data to the class member
			_estimatedclosingcostsamount = data._estimatedclosingcostsamount;
			_estimatedclosingcostsamount_isnull = data._estimatedclosingcostsamount_isnull;
			// assigns the MIAndFundingFeeFinancedAmount data to the class member
			_miandfundingfeefinancedamount = data._miandfundingfeefinancedamount;
			_miandfundingfeefinancedamount_isnull = data._miandfundingfeefinancedamount_isnull;
			// assigns the MIAndFundingFeeTotalAmount data to the class member
			_miandfundingfeetotalamount = data._miandfundingfeetotalamount;
			_miandfundingfeetotalamount_isnull = data._miandfundingfeetotalamount_isnull;
			// assigns the PrepaidItemsEstimatedAmount data to the class member
			_prepaiditemsestimatedamount = data._prepaiditemsestimatedamount;
			_prepaiditemsestimatedamount_isnull = data._prepaiditemsestimatedamount_isnull;
			// assigns the PurchasePriceAmount data to the class member
			_purchasepriceamount = data._purchasepriceamount;
			_purchasepriceamount_isnull = data._purchasepriceamount_isnull;
			// assigns the RefinanceIncludingDebtsToBePaidOffAmount data to the class member
			_refinanceincludingdebtstobepaidoffamount = data._refinanceincludingdebtstobepaidoffamount;
			_refinanceincludingdebtstobepaidoffamount_isnull = data._refinanceincludingdebtstobepaidoffamount_isnull;
			// assigns the SalesConcessionAmount data to the class member
			_salesconcessionamount = data._salesconcessionamount;
			_salesconcessionamount_isnull = data._salesconcessionamount_isnull;
			// assigns the SellerPaidClosingCostsAmount data to the class member
			_sellerpaidclosingcostsamount = data._sellerpaidclosingcostsamount;
			_sellerpaidclosingcostsamount_isnull = data._sellerpaidclosingcostsamount_isnull;
			// assigns the SubordinateLienAmount data to the class member
			_subordinatelienamount = data._subordinatelienamount;
			_subordinatelienamount_isnull = data._subordinatelienamount_isnull;
			// assigns the SubordinateLienHELOCAmount data to the class member
			_subordinatelienhelocamount = data._subordinatelienhelocamount;
			_subordinatelienhelocamount_isnull = data._subordinatelienhelocamount_isnull;
			// assigns the FREReserveAmount data to the class member
			_frereserveamount = data._frereserveamount;
			_frereserveamount_isnull = data._frereserveamount_isnull;
			// assigns the FREReservesAmount data to the class member
			_frereservesamount = data._frereservesamount;
			_frereservesamount_isnull = data._frereservesamount_isnull;


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
			// assigns the AlterationsImprovementsAndRepairsAmount data to the class member
			if (data["AlterationsImprovementsAndRepairsAmount"] == System.DBNull.Value)
				SetAlterationsImprovementsAndRepairsAmountNull();
			else
			{
				_alterationsimprovementsandrepairsamount = Convert.ToDecimal(data["AlterationsImprovementsAndRepairsAmount"]);
				_alterationsimprovementsandrepairsamount_isnull = false;
			}
			// assigns the BorrowerPaidDiscountPointsTotalAmount data to the class member
			if (data["BorrowerPaidDiscountPointsTotalAmount"] == System.DBNull.Value)
				SetBorrowerPaidDiscountPointsTotalAmountNull();
			else
			{
				_borrowerpaiddiscountpointstotalamount = Convert.ToDecimal(data["BorrowerPaidDiscountPointsTotalAmount"]);
				_borrowerpaiddiscountpointstotalamount_isnull = false;
			}
			// assigns the EstimatedClosingCostsAmount data to the class member
			if (data["EstimatedClosingCostsAmount"] == System.DBNull.Value)
				SetEstimatedClosingCostsAmountNull();
			else
			{
				_estimatedclosingcostsamount = Convert.ToDecimal(data["EstimatedClosingCostsAmount"]);
				_estimatedclosingcostsamount_isnull = false;
			}
			// assigns the MIAndFundingFeeFinancedAmount data to the class member
			if (data["MIAndFundingFeeFinancedAmount"] == System.DBNull.Value)
				SetMIAndFundingFeeFinancedAmountNull();
			else
			{
				_miandfundingfeefinancedamount = Convert.ToDecimal(data["MIAndFundingFeeFinancedAmount"]);
				_miandfundingfeefinancedamount_isnull = false;
			}
			// assigns the MIAndFundingFeeTotalAmount data to the class member
			if (data["MIAndFundingFeeTotalAmount"] == System.DBNull.Value)
				SetMIAndFundingFeeTotalAmountNull();
			else
			{
				_miandfundingfeetotalamount = Convert.ToDecimal(data["MIAndFundingFeeTotalAmount"]);
				_miandfundingfeetotalamount_isnull = false;
			}
			// assigns the PrepaidItemsEstimatedAmount data to the class member
			if (data["PrepaidItemsEstimatedAmount"] == System.DBNull.Value)
				SetPrepaidItemsEstimatedAmountNull();
			else
			{
				_prepaiditemsestimatedamount = Convert.ToDecimal(data["PrepaidItemsEstimatedAmount"]);
				_prepaiditemsestimatedamount_isnull = false;
			}
			// assigns the PurchasePriceAmount data to the class member
			if (data["PurchasePriceAmount"] == System.DBNull.Value)
				SetPurchasePriceAmountNull();
			else
			{
				_purchasepriceamount = Convert.ToDecimal(data["PurchasePriceAmount"]);
				_purchasepriceamount_isnull = false;
			}
			// assigns the RefinanceIncludingDebtsToBePaidOffAmount data to the class member
			if (data["RefinanceIncludingDebtsToBePaidOffAmount"] == System.DBNull.Value)
				SetRefinanceIncludingDebtsToBePaidOffAmountNull();
			else
			{
				_refinanceincludingdebtstobepaidoffamount = Convert.ToDecimal(data["RefinanceIncludingDebtsToBePaidOffAmount"]);
				_refinanceincludingdebtstobepaidoffamount_isnull = false;
			}
			// assigns the SalesConcessionAmount data to the class member
			if (data["SalesConcessionAmount"] == System.DBNull.Value)
				SetSalesConcessionAmountNull();
			else
			{
				_salesconcessionamount = Convert.ToDecimal(data["SalesConcessionAmount"]);
				_salesconcessionamount_isnull = false;
			}
			// assigns the SellerPaidClosingCostsAmount data to the class member
			if (data["SellerPaidClosingCostsAmount"] == System.DBNull.Value)
				SetSellerPaidClosingCostsAmountNull();
			else
			{
				_sellerpaidclosingcostsamount = Convert.ToDecimal(data["SellerPaidClosingCostsAmount"]);
				_sellerpaidclosingcostsamount_isnull = false;
			}
			// assigns the SubordinateLienAmount data to the class member
			if (data["SubordinateLienAmount"] == System.DBNull.Value)
				SetSubordinateLienAmountNull();
			else
			{
				_subordinatelienamount = Convert.ToDecimal(data["SubordinateLienAmount"]);
				_subordinatelienamount_isnull = false;
			}
			// assigns the SubordinateLienHELOCAmount data to the class member
			if (data["SubordinateLienHELOCAmount"] == System.DBNull.Value)
				SetSubordinateLienHELOCAmountNull();
			else
			{
				_subordinatelienhelocamount = Convert.ToDecimal(data["SubordinateLienHELOCAmount"]);
				_subordinatelienhelocamount_isnull = false;
			}
			// assigns the FREReserveAmount data to the class member
			if (data["FREReserveAmount"] == System.DBNull.Value)
				SetFREReserveAmountNull();
			else
			{
				_frereserveamount = Convert.ToDecimal(data["FREReserveAmount"]);
				_frereserveamount_isnull = false;
			}
			// assigns the FREReservesAmount data to the class member
			if (data["FREReservesAmount"] == System.DBNull.Value)
				SetFREReservesAmountNull();
			else
			{
				_frereservesamount = Convert.ToDecimal(data["FREReservesAmount"]);
				_frereservesamount_isnull = false;
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
			// assigns the AlterationsImprovementsAndRepairsAmount data to the class member
			if (data["AlterationsImprovementsAndRepairsAmount"] == System.DBNull.Value)
				SetAlterationsImprovementsAndRepairsAmountNull();
			else
			{
				_alterationsimprovementsandrepairsamount = Convert.ToDecimal(data["AlterationsImprovementsAndRepairsAmount"]);
				_alterationsimprovementsandrepairsamount_isnull = false;
			}
			// assigns the BorrowerPaidDiscountPointsTotalAmount data to the class member
			if (data["BorrowerPaidDiscountPointsTotalAmount"] == System.DBNull.Value)
				SetBorrowerPaidDiscountPointsTotalAmountNull();
			else
			{
				_borrowerpaiddiscountpointstotalamount = Convert.ToDecimal(data["BorrowerPaidDiscountPointsTotalAmount"]);
				_borrowerpaiddiscountpointstotalamount_isnull = false;
			}
			// assigns the EstimatedClosingCostsAmount data to the class member
			if (data["EstimatedClosingCostsAmount"] == System.DBNull.Value)
				SetEstimatedClosingCostsAmountNull();
			else
			{
				_estimatedclosingcostsamount = Convert.ToDecimal(data["EstimatedClosingCostsAmount"]);
				_estimatedclosingcostsamount_isnull = false;
			}
			// assigns the MIAndFundingFeeFinancedAmount data to the class member
			if (data["MIAndFundingFeeFinancedAmount"] == System.DBNull.Value)
				SetMIAndFundingFeeFinancedAmountNull();
			else
			{
				_miandfundingfeefinancedamount = Convert.ToDecimal(data["MIAndFundingFeeFinancedAmount"]);
				_miandfundingfeefinancedamount_isnull = false;
			}
			// assigns the MIAndFundingFeeTotalAmount data to the class member
			if (data["MIAndFundingFeeTotalAmount"] == System.DBNull.Value)
				SetMIAndFundingFeeTotalAmountNull();
			else
			{
				_miandfundingfeetotalamount = Convert.ToDecimal(data["MIAndFundingFeeTotalAmount"]);
				_miandfundingfeetotalamount_isnull = false;
			}
			// assigns the PrepaidItemsEstimatedAmount data to the class member
			if (data["PrepaidItemsEstimatedAmount"] == System.DBNull.Value)
				SetPrepaidItemsEstimatedAmountNull();
			else
			{
				_prepaiditemsestimatedamount = Convert.ToDecimal(data["PrepaidItemsEstimatedAmount"]);
				_prepaiditemsestimatedamount_isnull = false;
			}
			// assigns the PurchasePriceAmount data to the class member
			if (data["PurchasePriceAmount"] == System.DBNull.Value)
				SetPurchasePriceAmountNull();
			else
			{
				_purchasepriceamount = Convert.ToDecimal(data["PurchasePriceAmount"]);
				_purchasepriceamount_isnull = false;
			}
			// assigns the RefinanceIncludingDebtsToBePaidOffAmount data to the class member
			if (data["RefinanceIncludingDebtsToBePaidOffAmount"] == System.DBNull.Value)
				SetRefinanceIncludingDebtsToBePaidOffAmountNull();
			else
			{
				_refinanceincludingdebtstobepaidoffamount = Convert.ToDecimal(data["RefinanceIncludingDebtsToBePaidOffAmount"]);
				_refinanceincludingdebtstobepaidoffamount_isnull = false;
			}
			// assigns the SalesConcessionAmount data to the class member
			if (data["SalesConcessionAmount"] == System.DBNull.Value)
				SetSalesConcessionAmountNull();
			else
			{
				_salesconcessionamount = Convert.ToDecimal(data["SalesConcessionAmount"]);
				_salesconcessionamount_isnull = false;
			}
			// assigns the SellerPaidClosingCostsAmount data to the class member
			if (data["SellerPaidClosingCostsAmount"] == System.DBNull.Value)
				SetSellerPaidClosingCostsAmountNull();
			else
			{
				_sellerpaidclosingcostsamount = Convert.ToDecimal(data["SellerPaidClosingCostsAmount"]);
				_sellerpaidclosingcostsamount_isnull = false;
			}
			// assigns the SubordinateLienAmount data to the class member
			if (data["SubordinateLienAmount"] == System.DBNull.Value)
				SetSubordinateLienAmountNull();
			else
			{
				_subordinatelienamount = Convert.ToDecimal(data["SubordinateLienAmount"]);
				_subordinatelienamount_isnull = false;
			}
			// assigns the SubordinateLienHELOCAmount data to the class member
			if (data["SubordinateLienHELOCAmount"] == System.DBNull.Value)
				SetSubordinateLienHELOCAmountNull();
			else
			{
				_subordinatelienhelocamount = Convert.ToDecimal(data["SubordinateLienHELOCAmount"]);
				_subordinatelienhelocamount_isnull = false;
			}
			// assigns the FREReserveAmount data to the class member
			if (data["FREReserveAmount"] == System.DBNull.Value)
				SetFREReserveAmountNull();
			else
			{
				_frereserveamount = Convert.ToDecimal(data["FREReserveAmount"]);
				_frereserveamount_isnull = false;
			}
			// assigns the FREReservesAmount data to the class member
			if (data["FREReservesAmount"] == System.DBNull.Value)
				SetFREReservesAmountNull();
			else
			{
				_frereservesamount = Convert.ToDecimal(data["FREReservesAmount"]);
				_frereservesamount_isnull = false;
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
			TransactionDetailBase.ServiceObject.Persist(this as TransactionDetail, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the TRANSACTION_DETAIL object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			TransactionDetailBase.ServiceObject.Delete(this as TransactionDetail);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the PURCHASE_CREDIT relationship.
		/// </summary>
		public PurchaseCreditCollection GetPurchaseCreditCollection()
		{
			PurchaseCreditCollection purchasecreditcollection = new PurchaseCreditCollection();


			PurchaseCreditBase.ServiceObject.FillByTransactionDetail(purchasecreditcollection, _loanapplicationid);
			return purchasecreditcollection;
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
		/// Gets all persisted TransactionDetail objects
		/// </summary>
		public static TransactionDetails GetAll()
		{
			// have the service object get the objects
			return TransactionDetailBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
