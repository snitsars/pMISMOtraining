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
	/// A class that represents an abstract entity for table 'REO_PROPERTY'
	/// </summary>
	[Serializable]
	public abstract class REOPropertyBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public REOPropertyBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.REOProperty)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public REOPropertyBase(System.Int64 id)
		{
			// Fill this instance.
			REOPropertyBase.ServiceObject.Fill(this as REOProperty, id);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanapplicationid_isnull = true;
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
				_loanapplicationid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanApplicationId value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanApplicationIdIsNull
		{
			get
			{
				return _loanapplicationid_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the streetaddress.
		/// </summary>
		internal System.String _streetaddress;
		/// <summary>
		/// Gets and sets the StreetAddress value of the class instance.
		/// </summary>
		public virtual System.String StreetAddress
		{
			get
			{
				return _streetaddress;
			}
			set
			{
				_streetaddress = value;
			}
		}


		/// <summary>
		/// Checks the StreetAddress value to see if it was set to null.
		/// </summary>
		public System.Boolean StreetAddressIsNull
		{
			get
			{
				return (_streetaddress == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the streetaddress2.
		/// </summary>
		internal System.String _streetaddress2;
		/// <summary>
		/// Gets and sets the StreetAddress2 value of the class instance.
		/// </summary>
		public virtual System.String StreetAddress2
		{
			get
			{
				return _streetaddress2;
			}
			set
			{
				_streetaddress2 = value;
			}
		}


		/// <summary>
		/// Checks the StreetAddress2 value to see if it was set to null.
		/// </summary>
		public System.Boolean StreetAddress2IsNull
		{
			get
			{
				return (_streetaddress2 == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the city.
		/// </summary>
		internal System.String _city;
		/// <summary>
		/// Gets and sets the City value of the class instance.
		/// </summary>
		public virtual System.String City
		{
			get
			{
				return _city;
			}
			set
			{
				_city = value;
			}
		}


		/// <summary>
		/// Checks the City value to see if it was set to null.
		/// </summary>
		public System.Boolean CityIsNull
		{
			get
			{
				return (_city == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the state.
		/// </summary>
		internal System.String _state;
		/// <summary>
		/// Gets and sets the State value of the class instance.
		/// </summary>
		public virtual System.String State
		{
			get
			{
				return _state;
			}
			set
			{
				_state = value;
			}
		}


		/// <summary>
		/// Checks the State value to see if it was set to null.
		/// </summary>
		public System.Boolean StateIsNull
		{
			get
			{
				return (_state == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the postalcode.
		/// </summary>
		internal System.String _postalcode;
		/// <summary>
		/// Gets and sets the PostalCode value of the class instance.
		/// </summary>
		public virtual System.String PostalCode
		{
			get
			{
				return _postalcode;
			}
			set
			{
				_postalcode = value;
			}
		}


		/// <summary>
		/// Checks the PostalCode value to see if it was set to null.
		/// </summary>
		public System.Boolean PostalCodeIsNull
		{
			get
			{
				return (_postalcode == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _currentresidenceindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the currentresidenceindicator.
		/// </summary>
		internal System.Boolean _currentresidenceindicator;
		/// <summary>
		/// Gets and sets the CurrentResidenceIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean CurrentResidenceIndicator
		{
			get
			{
				return _currentresidenceindicator;
			}
			set
			{
				_currentresidenceindicator = value;
				_currentresidenceindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _lieninstallmentamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the lieninstallmentamount.
		/// </summary>
		internal System.Decimal _lieninstallmentamount;
		/// <summary>
		/// Gets and sets the LienInstallmentAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal LienInstallmentAmount
		{
			get
			{
				return _lieninstallmentamount;
			}
			set
			{
				_lieninstallmentamount = value;
				_lieninstallmentamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LienInstallmentAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean LienInstallmentAmountIsNull
		{
			get
			{
				return _lieninstallmentamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _lienupbamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the lienupbamount.
		/// </summary>
		internal System.Decimal _lienupbamount;
		/// <summary>
		/// Gets and sets the LienUPBAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal LienUPBAmount
		{
			get
			{
				return _lienupbamount;
			}
			set
			{
				_lienupbamount = value;
				_lienupbamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LienUPBAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean LienUPBAmountIsNull
		{
			get
			{
				return _lienupbamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _maintenanceexpenseamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the maintenanceexpenseamount.
		/// </summary>
		internal System.Decimal _maintenanceexpenseamount;
		/// <summary>
		/// Gets and sets the MaintenanceExpenseAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal MaintenanceExpenseAmount
		{
			get
			{
				return _maintenanceexpenseamount;
			}
			set
			{
				_maintenanceexpenseamount = value;
				_maintenanceexpenseamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MaintenanceExpenseAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean MaintenanceExpenseAmountIsNull
		{
			get
			{
				return _maintenanceexpenseamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _marketvalueamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the marketvalueamount.
		/// </summary>
		internal System.Decimal _marketvalueamount;
		/// <summary>
		/// Gets and sets the MarketValueAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal MarketValueAmount
		{
			get
			{
				return _marketvalueamount;
			}
			set
			{
				_marketvalueamount = value;
				_marketvalueamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MarketValueAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean MarketValueAmountIsNull
		{
			get
			{
				return _marketvalueamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _rentalincomegrossamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the rentalincomegrossamount.
		/// </summary>
		internal System.Decimal _rentalincomegrossamount;
		/// <summary>
		/// Gets and sets the RentalIncomeGrossAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal RentalIncomeGrossAmount
		{
			get
			{
				return _rentalincomegrossamount;
			}
			set
			{
				_rentalincomegrossamount = value;
				_rentalincomegrossamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RentalIncomeGrossAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean RentalIncomeGrossAmountIsNull
		{
			get
			{
				return _rentalincomegrossamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _rentalincomenetamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the rentalincomenetamount.
		/// </summary>
		internal System.Decimal _rentalincomenetamount;
		/// <summary>
		/// Gets and sets the RentalIncomeNetAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal RentalIncomeNetAmount
		{
			get
			{
				return _rentalincomenetamount;
			}
			set
			{
				_rentalincomenetamount = value;
				_rentalincomenetamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RentalIncomeNetAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean RentalIncomeNetAmountIsNull
		{
			get
			{
				return _rentalincomenetamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _subjectindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the subjectindicator.
		/// </summary>
		internal System.Boolean _subjectindicator;
		/// <summary>
		/// Gets and sets the SubjectIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean SubjectIndicator
		{
			get
			{
				return _subjectindicator;
			}
			set
			{
				_subjectindicator = value;
				_subjectindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerid_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerid.
		/// </summary>
		internal System.Int64 _borrowerid;
		/// <summary>
		/// Gets and sets the BorrowerID value of the class instance.
		/// </summary>
		public virtual System.Int64 BorrowerID
		{
			get
			{
				return _borrowerid;
			}
			set
			{
				_borrowerid = value;
				_borrowerid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerID value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerIDIsNull
		{
			get
			{
				return _borrowerid_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _liabilityid_isnull = true;
		/// <summary>
		/// Member that stores the value for the liabilityid.
		/// </summary>
		internal System.Int64 _liabilityid;
		/// <summary>
		/// Gets and sets the LiabilityID value of the class instance.
		/// </summary>
		public virtual System.Int64 LiabilityID
		{
			get
			{
				return _liabilityid;
			}
			set
			{
				_liabilityid = value;
				_liabilityid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LiabilityID value to see if it was set to null.
		/// </summary>
		public System.Boolean LiabilityIDIsNull
		{
			get
			{
				return _liabilityid_isnull;
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
		internal bool _dispositionstatustype_isnull = true;
		/// <summary>
		/// Member that stores the value for the dispositionstatustype.
		/// </summary>
		internal System.Int16 _dispositionstatustype;
		/// <summary>
		/// Gets and sets the DispositionStatusType value of the class instance.
		/// </summary>
		public virtual System.Int16 DispositionStatusType
		{
			get
			{
				return _dispositionstatustype;
			}
			set
			{
				_dispositionstatustype = value;
				_dispositionstatustype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the DispositionStatusType value to see if it was set to null.
		/// </summary>
		public System.Boolean DispositionStatusTypeIsNull
		{
			get
			{
				return _dispositionstatustype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the REOPropertyBase.
		/// </summary>
		internal static REOPropertyService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(REOPropertyService)) as REOPropertyService;
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




				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the LoanApplicationId value as null.
		/// </summary>
		public virtual void SetLoanApplicationIdNull()
		{
			_loanapplicationid = 0;
			_loanapplicationid_isnull = true;
		}


		/// <summary>
		/// Marks the StreetAddress value as null.
		/// </summary>
		public virtual void SetStreetAddressNull()
		{
			_streetaddress = null;
		}


		/// <summary>
		/// Marks the StreetAddress2 value as null.
		/// </summary>
		public virtual void SetStreetAddress2Null()
		{
			_streetaddress2 = null;
		}


		/// <summary>
		/// Marks the City value as null.
		/// </summary>
		public virtual void SetCityNull()
		{
			_city = null;
		}


		/// <summary>
		/// Marks the State value as null.
		/// </summary>
		public virtual void SetStateNull()
		{
			_state = null;
		}


		/// <summary>
		/// Marks the PostalCode value as null.
		/// </summary>
		public virtual void SetPostalCodeNull()
		{
			_postalcode = null;
		}


		/// <summary>
		/// Marks the LienInstallmentAmount value as null.
		/// </summary>
		public virtual void SetLienInstallmentAmountNull()
		{
			_lieninstallmentamount = 0;
			_lieninstallmentamount_isnull = true;
		}


		/// <summary>
		/// Marks the LienUPBAmount value as null.
		/// </summary>
		public virtual void SetLienUPBAmountNull()
		{
			_lienupbamount = 0;
			_lienupbamount_isnull = true;
		}


		/// <summary>
		/// Marks the MaintenanceExpenseAmount value as null.
		/// </summary>
		public virtual void SetMaintenanceExpenseAmountNull()
		{
			_maintenanceexpenseamount = 0;
			_maintenanceexpenseamount_isnull = true;
		}


		/// <summary>
		/// Marks the MarketValueAmount value as null.
		/// </summary>
		public virtual void SetMarketValueAmountNull()
		{
			_marketvalueamount = 0;
			_marketvalueamount_isnull = true;
		}


		/// <summary>
		/// Marks the RentalIncomeGrossAmount value as null.
		/// </summary>
		public virtual void SetRentalIncomeGrossAmountNull()
		{
			_rentalincomegrossamount = 0;
			_rentalincomegrossamount_isnull = true;
		}


		/// <summary>
		/// Marks the RentalIncomeNetAmount value as null.
		/// </summary>
		public virtual void SetRentalIncomeNetAmountNull()
		{
			_rentalincomenetamount = 0;
			_rentalincomenetamount_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerID value as null.
		/// </summary>
		public virtual void SetBorrowerIDNull()
		{
			_borrowerid = 0;
			_borrowerid_isnull = true;
		}


		/// <summary>
		/// Marks the LiabilityID value as null.
		/// </summary>
		public virtual void SetLiabilityIDNull()
		{
			_liabilityid = 0;
			_liabilityid_isnull = true;
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
		/// Marks the DispositionStatusType value as null.
		/// </summary>
		public virtual void SetDispositionStatusTypeNull()
		{
			_dispositionstatustype = 0;
			_dispositionstatustype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref REOPropertyBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_isnull = data._loanapplicationid_isnull;
			// assigns the StreetAddress data to the class member
			_streetaddress = data._streetaddress;
			// assigns the StreetAddress2 data to the class member
			_streetaddress2 = data._streetaddress2;
			// assigns the City data to the class member
			_city = data._city;
			// assigns the State data to the class member
			_state = data._state;
			// assigns the PostalCode data to the class member
			_postalcode = data._postalcode;
			// assigns the CurrentResidenceIndicator data to the class member
			_currentresidenceindicator = data._currentresidenceindicator;
			_currentresidenceindicator_assigned = data._currentresidenceindicator_assigned;
			// assigns the LienInstallmentAmount data to the class member
			_lieninstallmentamount = data._lieninstallmentamount;
			_lieninstallmentamount_isnull = data._lieninstallmentamount_isnull;
			// assigns the LienUPBAmount data to the class member
			_lienupbamount = data._lienupbamount;
			_lienupbamount_isnull = data._lienupbamount_isnull;
			// assigns the MaintenanceExpenseAmount data to the class member
			_maintenanceexpenseamount = data._maintenanceexpenseamount;
			_maintenanceexpenseamount_isnull = data._maintenanceexpenseamount_isnull;
			// assigns the MarketValueAmount data to the class member
			_marketvalueamount = data._marketvalueamount;
			_marketvalueamount_isnull = data._marketvalueamount_isnull;
			// assigns the RentalIncomeGrossAmount data to the class member
			_rentalincomegrossamount = data._rentalincomegrossamount;
			_rentalincomegrossamount_isnull = data._rentalincomegrossamount_isnull;
			// assigns the RentalIncomeNetAmount data to the class member
			_rentalincomenetamount = data._rentalincomenetamount;
			_rentalincomenetamount_isnull = data._rentalincomenetamount_isnull;
			// assigns the SubjectIndicator data to the class member
			_subjectindicator = data._subjectindicator;
			_subjectindicator_assigned = data._subjectindicator_assigned;
			// assigns the BorrowerID data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_isnull = data._borrowerid_isnull;
			// assigns the LiabilityID data to the class member
			_liabilityid = data._liabilityid;
			_liabilityid_isnull = data._liabilityid_isnull;
			// assigns the GSEPropertyType data to the class member
			_gsepropertytype = data._gsepropertytype;
			_gsepropertytype_isnull = data._gsepropertytype_isnull;
			// assigns the DispositionStatusType data to the class member
			_dispositionstatustype = data._dispositionstatustype;
			_dispositionstatustype_isnull = data._dispositionstatustype_isnull;


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
			if (data["LoanApplicationId"] == System.DBNull.Value)
				SetLoanApplicationIdNull();
			else
			{
				_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
				_loanapplicationid_isnull = false;
			}
			// assigns the StreetAddress data to the class member
			if (data["StreetAddress"] == System.DBNull.Value)
				SetStreetAddressNull();
			else
			{
				_streetaddress = Convert.ToString(data["StreetAddress"]);
			}
			// assigns the StreetAddress2 data to the class member
			if (data["StreetAddress2"] == System.DBNull.Value)
				SetStreetAddress2Null();
			else
			{
				_streetaddress2 = Convert.ToString(data["StreetAddress2"]);
			}
			// assigns the City data to the class member
			if (data["City"] == System.DBNull.Value)
				SetCityNull();
			else
			{
				_city = Convert.ToString(data["City"]);
			}
			// assigns the State data to the class member
			if (data["State"] == System.DBNull.Value)
				SetStateNull();
			else
			{
				_state = Convert.ToString(data["State"]);
			}
			// assigns the PostalCode data to the class member
			if (data["PostalCode"] == System.DBNull.Value)
				SetPostalCodeNull();
			else
			{
				_postalcode = Convert.ToString(data["PostalCode"]);
			}
			// assigns the CurrentResidenceIndicator data to the class member
			_currentresidenceindicator = Convert.ToBoolean(data["CurrentResidenceIndicator"]);
			_currentresidenceindicator_assigned = true;
			// assigns the LienInstallmentAmount data to the class member
			if (data["LienInstallmentAmount"] == System.DBNull.Value)
				SetLienInstallmentAmountNull();
			else
			{
				_lieninstallmentamount = Convert.ToDecimal(data["LienInstallmentAmount"]);
				_lieninstallmentamount_isnull = false;
			}
			// assigns the LienUPBAmount data to the class member
			if (data["LienUPBAmount"] == System.DBNull.Value)
				SetLienUPBAmountNull();
			else
			{
				_lienupbamount = Convert.ToDecimal(data["LienUPBAmount"]);
				_lienupbamount_isnull = false;
			}
			// assigns the MaintenanceExpenseAmount data to the class member
			if (data["MaintenanceExpenseAmount"] == System.DBNull.Value)
				SetMaintenanceExpenseAmountNull();
			else
			{
				_maintenanceexpenseamount = Convert.ToDecimal(data["MaintenanceExpenseAmount"]);
				_maintenanceexpenseamount_isnull = false;
			}
			// assigns the MarketValueAmount data to the class member
			if (data["MarketValueAmount"] == System.DBNull.Value)
				SetMarketValueAmountNull();
			else
			{
				_marketvalueamount = Convert.ToDecimal(data["MarketValueAmount"]);
				_marketvalueamount_isnull = false;
			}
			// assigns the RentalIncomeGrossAmount data to the class member
			if (data["RentalIncomeGrossAmount"] == System.DBNull.Value)
				SetRentalIncomeGrossAmountNull();
			else
			{
				_rentalincomegrossamount = Convert.ToDecimal(data["RentalIncomeGrossAmount"]);
				_rentalincomegrossamount_isnull = false;
			}
			// assigns the RentalIncomeNetAmount data to the class member
			if (data["RentalIncomeNetAmount"] == System.DBNull.Value)
				SetRentalIncomeNetAmountNull();
			else
			{
				_rentalincomenetamount = Convert.ToDecimal(data["RentalIncomeNetAmount"]);
				_rentalincomenetamount_isnull = false;
			}
			// assigns the SubjectIndicator data to the class member
			_subjectindicator = Convert.ToBoolean(data["SubjectIndicator"]);
			_subjectindicator_assigned = true;
			// assigns the BorrowerID data to the class member
			if (data["BorrowerID"] == System.DBNull.Value)
				SetBorrowerIDNull();
			else
			{
				_borrowerid = Convert.ToInt64(data["BorrowerID"]);
				_borrowerid_isnull = false;
			}
			// assigns the LiabilityID data to the class member
			if (data["LiabilityID"] == System.DBNull.Value)
				SetLiabilityIDNull();
			else
			{
				_liabilityid = Convert.ToInt64(data["LiabilityID"]);
				_liabilityid_isnull = false;
			}
			// assigns the GSEPropertyType data to the class member
			if (data["GSEPropertyType"] == System.DBNull.Value)
				SetGSEPropertyTypeNull();
			else
			{
				_gsepropertytype = Convert.ToInt16(data["GSEPropertyType"]);
				_gsepropertytype_isnull = false;
			}
			// assigns the DispositionStatusType data to the class member
			if (data["DispositionStatusType"] == System.DBNull.Value)
				SetDispositionStatusTypeNull();
			else
			{
				_dispositionstatustype = Convert.ToInt16(data["DispositionStatusType"]);
				_dispositionstatustype_isnull = false;
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
			if (data["LoanApplicationId"] == System.DBNull.Value)
				SetLoanApplicationIdNull();
			else
			{
				_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
				_loanapplicationid_isnull = false;
			}
			// assigns the StreetAddress data to the class member
			if (data["StreetAddress"] == System.DBNull.Value)
				SetStreetAddressNull();
			else
			{
				_streetaddress = Convert.ToString(data["StreetAddress"]);
			}
			// assigns the StreetAddress2 data to the class member
			if (data["StreetAddress2"] == System.DBNull.Value)
				SetStreetAddress2Null();
			else
			{
				_streetaddress2 = Convert.ToString(data["StreetAddress2"]);
			}
			// assigns the City data to the class member
			if (data["City"] == System.DBNull.Value)
				SetCityNull();
			else
			{
				_city = Convert.ToString(data["City"]);
			}
			// assigns the State data to the class member
			if (data["State"] == System.DBNull.Value)
				SetStateNull();
			else
			{
				_state = Convert.ToString(data["State"]);
			}
			// assigns the PostalCode data to the class member
			if (data["PostalCode"] == System.DBNull.Value)
				SetPostalCodeNull();
			else
			{
				_postalcode = Convert.ToString(data["PostalCode"]);
			}
			// assigns the CurrentResidenceIndicator data to the class member
			_currentresidenceindicator = Convert.ToBoolean(data["CurrentResidenceIndicator"]);
			_currentresidenceindicator_assigned = true;
			// assigns the LienInstallmentAmount data to the class member
			if (data["LienInstallmentAmount"] == System.DBNull.Value)
				SetLienInstallmentAmountNull();
			else
			{
				_lieninstallmentamount = Convert.ToDecimal(data["LienInstallmentAmount"]);
				_lieninstallmentamount_isnull = false;
			}
			// assigns the LienUPBAmount data to the class member
			if (data["LienUPBAmount"] == System.DBNull.Value)
				SetLienUPBAmountNull();
			else
			{
				_lienupbamount = Convert.ToDecimal(data["LienUPBAmount"]);
				_lienupbamount_isnull = false;
			}
			// assigns the MaintenanceExpenseAmount data to the class member
			if (data["MaintenanceExpenseAmount"] == System.DBNull.Value)
				SetMaintenanceExpenseAmountNull();
			else
			{
				_maintenanceexpenseamount = Convert.ToDecimal(data["MaintenanceExpenseAmount"]);
				_maintenanceexpenseamount_isnull = false;
			}
			// assigns the MarketValueAmount data to the class member
			if (data["MarketValueAmount"] == System.DBNull.Value)
				SetMarketValueAmountNull();
			else
			{
				_marketvalueamount = Convert.ToDecimal(data["MarketValueAmount"]);
				_marketvalueamount_isnull = false;
			}
			// assigns the RentalIncomeGrossAmount data to the class member
			if (data["RentalIncomeGrossAmount"] == System.DBNull.Value)
				SetRentalIncomeGrossAmountNull();
			else
			{
				_rentalincomegrossamount = Convert.ToDecimal(data["RentalIncomeGrossAmount"]);
				_rentalincomegrossamount_isnull = false;
			}
			// assigns the RentalIncomeNetAmount data to the class member
			if (data["RentalIncomeNetAmount"] == System.DBNull.Value)
				SetRentalIncomeNetAmountNull();
			else
			{
				_rentalincomenetamount = Convert.ToDecimal(data["RentalIncomeNetAmount"]);
				_rentalincomenetamount_isnull = false;
			}
			// assigns the SubjectIndicator data to the class member
			_subjectindicator = Convert.ToBoolean(data["SubjectIndicator"]);
			_subjectindicator_assigned = true;
			// assigns the BorrowerID data to the class member
			if (data["BorrowerID"] == System.DBNull.Value)
				SetBorrowerIDNull();
			else
			{
				_borrowerid = Convert.ToInt64(data["BorrowerID"]);
				_borrowerid_isnull = false;
			}
			// assigns the LiabilityID data to the class member
			if (data["LiabilityID"] == System.DBNull.Value)
				SetLiabilityIDNull();
			else
			{
				_liabilityid = Convert.ToInt64(data["LiabilityID"]);
				_liabilityid_isnull = false;
			}
			// assigns the GSEPropertyType data to the class member
			if (data["GSEPropertyType"] == System.DBNull.Value)
				SetGSEPropertyTypeNull();
			else
			{
				_gsepropertytype = Convert.ToInt16(data["GSEPropertyType"]);
				_gsepropertytype_isnull = false;
			}
			// assigns the DispositionStatusType data to the class member
			if (data["DispositionStatusType"] == System.DBNull.Value)
				SetDispositionStatusTypeNull();
			else
			{
				_dispositionstatustype = Convert.ToInt16(data["DispositionStatusType"]);
				_dispositionstatustype_isnull = false;
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
			REOPropertyBase.ServiceObject.Persist(this as REOProperty, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the REO_PROPERTY object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			REOPropertyBase.ServiceObject.Delete(this as REOProperty);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the BORROWER relationship.
		/// </summary>
		public Borrower GetBorrower()
		{
			if (_borrowerid_isnull)
				return null;
			else
				return new Borrower(_borrowerid);
		}


		/// <summary>
		/// Gets the single object for the DispositionStatusType relationship.
		/// </summary>
		public DispositionStatusType GetDispositionStatusType()
		{
			if (_dispositionstatustype_isnull)
				return null;
			else
				return new DispositionStatusType(_dispositionstatustype);
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
		/// Gets the single object for the LIABILITY relationship.
		/// </summary>
		public Liability GetLiability()
		{
			if (_liabilityid_isnull)
				return null;
			else
				return new Liability(_liabilityid);
		}


		/// <summary>
		/// Gets the single object for the LOAN_APPLICATION relationship.
		/// </summary>
		public LoanApplication GetLoanApplication()
		{
			if (_loanapplicationid_isnull)
				return null;
			else
				return new LoanApplication(_loanapplicationid);
		}


		/// <summary>
		/// Gets all persisted REOProperty objects
		/// </summary>
		public static REOProperties GetAll()
		{
			// have the service object get the objects
			return REOPropertyBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
