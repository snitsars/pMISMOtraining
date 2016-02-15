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
	/// A class that represents an abstract entity for table 'ASSET'
	/// </summary>
	[Serializable]
	public abstract class AssetBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AssetBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Asset)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public AssetBase(System.Int64 id)
		{
			// Fill this instance.
			AssetBase.ServiceObject.Fill(this as Asset, id);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _cashormarketvalueamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the cashormarketvalueamount.
		/// </summary>
		internal System.Decimal _cashormarketvalueamount;
		/// <summary>
		/// Gets and sets the CashOrMarketValueAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal CashOrMarketValueAmount
		{
			get
			{
				return _cashormarketvalueamount;
			}
			set
			{
				_cashormarketvalueamount = value;
				_cashormarketvalueamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CashOrMarketValueAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean CashOrMarketValueAmountIsNull
		{
			get
			{
				return _cashormarketvalueamount_isnull;
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
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _verifiedindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the verifiedindicator.
		/// </summary>
		internal System.Boolean _verifiedindicator;
		/// <summary>
		/// Gets and sets the VerifiedIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean VerifiedIndicator
		{
			get
			{
				return _verifiedindicator;
			}
			set
			{
				_verifiedindicator = value;
				_verifiedindicator_assigned = true;
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
		/// Member that stores the value for the automobilemakedescription.
		/// </summary>
		internal System.String _automobilemakedescription;
		/// <summary>
		/// Gets and sets the AutomobileMakeDescription value of the class instance.
		/// </summary>
		public virtual System.String AutomobileMakeDescription
		{
			get
			{
				return _automobilemakedescription;
			}
			set
			{
				_automobilemakedescription = value;
			}
		}


		/// <summary>
		/// Checks the AutomobileMakeDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean AutomobileMakeDescriptionIsNull
		{
			get
			{
				return (_automobilemakedescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _automobilemodelyear_isnull = true;
		/// <summary>
		/// Member that stores the value for the automobilemodelyear.
		/// </summary>
		internal System.DateTime _automobilemodelyear;
		/// <summary>
		/// Gets and sets the AutomobileModelYear value of the class instance.
		/// </summary>
		public virtual System.DateTime AutomobileModelYear
		{
			get
			{
				return _automobilemodelyear;
			}
			set
			{
				_automobilemodelyear = value;
				_automobilemodelyear_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AutomobileModelYear value to see if it was set to null.
		/// </summary>
		public System.Boolean AutomobileModelYearIsNull
		{
			get
			{
				return _automobilemodelyear_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _lifeinsurancefacevalueamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the lifeinsurancefacevalueamount.
		/// </summary>
		internal System.Decimal _lifeinsurancefacevalueamount;
		/// <summary>
		/// Gets and sets the LifeInsuranceFaceValueAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal LifeInsuranceFaceValueAmount
		{
			get
			{
				return _lifeinsurancefacevalueamount;
			}
			set
			{
				_lifeinsurancefacevalueamount = value;
				_lifeinsurancefacevalueamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LifeInsuranceFaceValueAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean LifeInsuranceFaceValueAmountIsNull
		{
			get
			{
				return _lifeinsurancefacevalueamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the otherassettypedescription.
		/// </summary>
		internal System.String _otherassettypedescription;
		/// <summary>
		/// Gets and sets the OtherAssetTypeDescription value of the class instance.
		/// </summary>
		public virtual System.String OtherAssetTypeDescription
		{
			get
			{
				return _otherassettypedescription;
			}
			set
			{
				_otherassettypedescription = value;
			}
		}


		/// <summary>
		/// Checks the OtherAssetTypeDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherAssetTypeDescriptionIsNull
		{
			get
			{
				return (_otherassettypedescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _stockbondmutualfundsharecount_isnull = true;
		/// <summary>
		/// Member that stores the value for the stockbondmutualfundsharecount.
		/// </summary>
		internal System.Decimal _stockbondmutualfundsharecount;
		/// <summary>
		/// Gets and sets the StockBondMutualFundShareCount value of the class instance.
		/// </summary>
		public virtual System.Decimal StockBondMutualFundShareCount
		{
			get
			{
				return _stockbondmutualfundsharecount;
			}
			set
			{
				_stockbondmutualfundsharecount = value;
				_stockbondmutualfundsharecount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the StockBondMutualFundShareCount value to see if it was set to null.
		/// </summary>
		public System.Boolean StockBondMutualFundShareCountIsNull
		{
			get
			{
				return _stockbondmutualfundsharecount_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the AssetBase.
		/// </summary>
		internal static AssetService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(AssetService)) as AssetService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of AssetBase. The value has not been explicitly assigned.", exceptions);
				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of AssetBase. The value has not been explicitly assigned.", exceptions);
				if (!_type_assigned) exceptions = BusinessLogic.ChainException("Type is a required value of AssetBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the AccountIdentifier value as null.
		/// </summary>
		public virtual void SetAccountIdentifierNull()
		{
			_accountidentifier = null;
		}


		/// <summary>
		/// Marks the CashOrMarketValueAmount value as null.
		/// </summary>
		public virtual void SetCashOrMarketValueAmountNull()
		{
			_cashormarketvalueamount = 0;
			_cashormarketvalueamount_isnull = true;
		}


		/// <summary>
		/// Marks the HolderName value as null.
		/// </summary>
		public virtual void SetHolderNameNull()
		{
			_holdername = null;
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
		/// Marks the AutomobileMakeDescription value as null.
		/// </summary>
		public virtual void SetAutomobileMakeDescriptionNull()
		{
			_automobilemakedescription = null;
		}


		/// <summary>
		/// Marks the AutomobileModelYear value as null.
		/// </summary>
		public virtual void SetAutomobileModelYearNull()
		{
			_automobilemodelyear = DateTime.MinValue;
			_automobilemodelyear_isnull = true;
		}


		/// <summary>
		/// Marks the LifeInsuranceFaceValueAmount value as null.
		/// </summary>
		public virtual void SetLifeInsuranceFaceValueAmountNull()
		{
			_lifeinsurancefacevalueamount = 0;
			_lifeinsurancefacevalueamount_isnull = true;
		}


		/// <summary>
		/// Marks the OtherAssetTypeDescription value as null.
		/// </summary>
		public virtual void SetOtherAssetTypeDescriptionNull()
		{
			_otherassettypedescription = null;
		}


		/// <summary>
		/// Marks the StockBondMutualFundShareCount value as null.
		/// </summary>
		public virtual void SetStockBondMutualFundShareCountNull()
		{
			_stockbondmutualfundsharecount = 0;
			_stockbondmutualfundsharecount_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref AssetBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the AccountIdentifier data to the class member
			_accountidentifier = data._accountidentifier;
			// assigns the CashOrMarketValueAmount data to the class member
			_cashormarketvalueamount = data._cashormarketvalueamount;
			_cashormarketvalueamount_isnull = data._cashormarketvalueamount_isnull;
			// assigns the Type data to the class member
			_type = data._type;
			_type_assigned = data._type_assigned;
			// assigns the VerifiedIndicator data to the class member
			_verifiedindicator = data._verifiedindicator;
			_verifiedindicator_assigned = data._verifiedindicator_assigned;
			// assigns the HolderName data to the class member
			_holdername = data._holdername;
			// assigns the HolderStreetAddress data to the class member
			_holderstreetaddress = data._holderstreetaddress;
			// assigns the HolderCity data to the class member
			_holdercity = data._holdercity;
			// assigns the HolderState data to the class member
			_holderstate = data._holderstate;
			// assigns the HolderPostalCode data to the class member
			_holderpostalcode = data._holderpostalcode;
			// assigns the AutomobileMakeDescription data to the class member
			_automobilemakedescription = data._automobilemakedescription;
			// assigns the AutomobileModelYear data to the class member
			_automobilemodelyear = data._automobilemodelyear;
			_automobilemodelyear_isnull = data._automobilemodelyear_isnull;
			// assigns the LifeInsuranceFaceValueAmount data to the class member
			_lifeinsurancefacevalueamount = data._lifeinsurancefacevalueamount;
			_lifeinsurancefacevalueamount_isnull = data._lifeinsurancefacevalueamount_isnull;
			// assigns the OtherAssetTypeDescription data to the class member
			_otherassettypedescription = data._otherassettypedescription;
			// assigns the StockBondMutualFundShareCount data to the class member
			_stockbondmutualfundsharecount = data._stockbondmutualfundsharecount;
			_stockbondmutualfundsharecount_isnull = data._stockbondmutualfundsharecount_isnull;


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
			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the AccountIdentifier data to the class member
			if (data["AccountIdentifier"] == System.DBNull.Value)
				SetAccountIdentifierNull();
			else
			{
				_accountidentifier = Convert.ToString(data["AccountIdentifier"]);
			}
			// assigns the CashOrMarketValueAmount data to the class member
			if (data["CashOrMarketValueAmount"] == System.DBNull.Value)
				SetCashOrMarketValueAmountNull();
			else
			{
				_cashormarketvalueamount = Convert.ToDecimal(data["CashOrMarketValueAmount"]);
				_cashormarketvalueamount_isnull = false;
			}
			// assigns the Type data to the class member
			_type = Convert.ToInt16(data["Type"]);
			_type_assigned = true;
			// assigns the VerifiedIndicator data to the class member
			_verifiedindicator = Convert.ToBoolean(data["VerifiedIndicator"]);
			_verifiedindicator_assigned = true;
			// assigns the HolderName data to the class member
			if (data["HolderName"] == System.DBNull.Value)
				SetHolderNameNull();
			else
			{
				_holdername = Convert.ToString(data["HolderName"]);
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
			// assigns the AutomobileMakeDescription data to the class member
			if (data["AutomobileMakeDescription"] == System.DBNull.Value)
				SetAutomobileMakeDescriptionNull();
			else
			{
				_automobilemakedescription = Convert.ToString(data["AutomobileMakeDescription"]);
			}
			// assigns the AutomobileModelYear data to the class member
			if (data["AutomobileModelYear"] == System.DBNull.Value)
				SetAutomobileModelYearNull();
			else
			{
				_automobilemodelyear = Convert.ToDateTime(data["AutomobileModelYear"]);
				_automobilemodelyear_isnull = false;
			}
			// assigns the LifeInsuranceFaceValueAmount data to the class member
			if (data["LifeInsuranceFaceValueAmount"] == System.DBNull.Value)
				SetLifeInsuranceFaceValueAmountNull();
			else
			{
				_lifeinsurancefacevalueamount = Convert.ToDecimal(data["LifeInsuranceFaceValueAmount"]);
				_lifeinsurancefacevalueamount_isnull = false;
			}
			// assigns the OtherAssetTypeDescription data to the class member
			if (data["OtherAssetTypeDescription"] == System.DBNull.Value)
				SetOtherAssetTypeDescriptionNull();
			else
			{
				_otherassettypedescription = Convert.ToString(data["OtherAssetTypeDescription"]);
			}
			// assigns the StockBondMutualFundShareCount data to the class member
			if (data["StockBondMutualFundShareCount"] == System.DBNull.Value)
				SetStockBondMutualFundShareCountNull();
			else
			{
				_stockbondmutualfundsharecount = Convert.ToDecimal(data["StockBondMutualFundShareCount"]);
				_stockbondmutualfundsharecount_isnull = false;
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
			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the AccountIdentifier data to the class member
			if (data["AccountIdentifier"] == System.DBNull.Value)
				SetAccountIdentifierNull();
			else
			{
				_accountidentifier = Convert.ToString(data["AccountIdentifier"]);
			}
			// assigns the CashOrMarketValueAmount data to the class member
			if (data["CashOrMarketValueAmount"] == System.DBNull.Value)
				SetCashOrMarketValueAmountNull();
			else
			{
				_cashormarketvalueamount = Convert.ToDecimal(data["CashOrMarketValueAmount"]);
				_cashormarketvalueamount_isnull = false;
			}
			// assigns the Type data to the class member
			_type = Convert.ToInt16(data["Type"]);
			_type_assigned = true;
			// assigns the VerifiedIndicator data to the class member
			_verifiedindicator = Convert.ToBoolean(data["VerifiedIndicator"]);
			_verifiedindicator_assigned = true;
			// assigns the HolderName data to the class member
			if (data["HolderName"] == System.DBNull.Value)
				SetHolderNameNull();
			else
			{
				_holdername = Convert.ToString(data["HolderName"]);
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
			// assigns the AutomobileMakeDescription data to the class member
			if (data["AutomobileMakeDescription"] == System.DBNull.Value)
				SetAutomobileMakeDescriptionNull();
			else
			{
				_automobilemakedescription = Convert.ToString(data["AutomobileMakeDescription"]);
			}
			// assigns the AutomobileModelYear data to the class member
			if (data["AutomobileModelYear"] == System.DBNull.Value)
				SetAutomobileModelYearNull();
			else
			{
				_automobilemodelyear = Convert.ToDateTime(data["AutomobileModelYear"]);
				_automobilemodelyear_isnull = false;
			}
			// assigns the LifeInsuranceFaceValueAmount data to the class member
			if (data["LifeInsuranceFaceValueAmount"] == System.DBNull.Value)
				SetLifeInsuranceFaceValueAmountNull();
			else
			{
				_lifeinsurancefacevalueamount = Convert.ToDecimal(data["LifeInsuranceFaceValueAmount"]);
				_lifeinsurancefacevalueamount_isnull = false;
			}
			// assigns the OtherAssetTypeDescription data to the class member
			if (data["OtherAssetTypeDescription"] == System.DBNull.Value)
				SetOtherAssetTypeDescriptionNull();
			else
			{
				_otherassettypedescription = Convert.ToString(data["OtherAssetTypeDescription"]);
			}
			// assigns the StockBondMutualFundShareCount data to the class member
			if (data["StockBondMutualFundShareCount"] == System.DBNull.Value)
				SetStockBondMutualFundShareCountNull();
			else
			{
				_stockbondmutualfundsharecount = Convert.ToDecimal(data["StockBondMutualFundShareCount"]);
				_stockbondmutualfundsharecount_isnull = false;
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
			AssetBase.ServiceObject.Persist(this as Asset, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the ASSET object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			AssetBase.ServiceObject.Delete(this as Asset);


			// Now call the base for it to do its own thing
			base.Delete();
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
		/// Gets the single object for the AssetType relationship.
		/// </summary>
		public AssetType GetAssetType()
		{
			if (_type_assigned)
				return null;
			else
				return new AssetType(_type);
		}


		/// <summary>
		/// Gets all persisted Asset objects
		/// </summary>
		public static Assets GetAll()
		{
			// have the service object get the objects
			return AssetBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
