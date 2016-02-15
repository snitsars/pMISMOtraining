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
	/// A class that represents an abstract entity for table 'EMPLOYER'
	/// </summary>
	[Serializable]
	public abstract class EmployerBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public EmployerBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Employer)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public EmployerBase(System.Int64 id)
		{
			// Fill this instance.
			EmployerBase.ServiceObject.Fill(this as Employer, id);
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
		/// Member that stores the value for the name.
		/// </summary>
		internal System.String _name;
		/// <summary>
		/// Gets and sets the Name value of the class instance.
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}


		/// <summary>
		/// Checks the Name value to see if it was set to null.
		/// </summary>
		public System.Boolean NameIsNull
		{
			get
			{
				return (_name == null);
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
		/// Member that stores the value for the telephonenumber.
		/// </summary>
		internal System.String _telephonenumber;
		/// <summary>
		/// Gets and sets the TelephoneNumber value of the class instance.
		/// </summary>
		public virtual System.String TelephoneNumber
		{
			get
			{
				return _telephonenumber;
			}
			set
			{
				_telephonenumber = value;
			}
		}


		/// <summary>
		/// Checks the TelephoneNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean TelephoneNumberIsNull
		{
			get
			{
				return (_telephonenumber == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _currentemploymentmonthsonjob_isnull = true;
		/// <summary>
		/// Member that stores the value for the currentemploymentmonthsonjob.
		/// </summary>
		internal System.Decimal _currentemploymentmonthsonjob;
		/// <summary>
		/// Gets and sets the CurrentEmploymentMonthsOnJob value of the class instance.
		/// </summary>
		public virtual System.Decimal CurrentEmploymentMonthsOnJob
		{
			get
			{
				return _currentemploymentmonthsonjob;
			}
			set
			{
				_currentemploymentmonthsonjob = value;
				_currentemploymentmonthsonjob_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CurrentEmploymentMonthsOnJob value to see if it was set to null.
		/// </summary>
		public System.Boolean CurrentEmploymentMonthsOnJobIsNull
		{
			get
			{
				return _currentemploymentmonthsonjob_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _currentemploymenttimeinlineofworkyears_isnull = true;
		/// <summary>
		/// Member that stores the value for the currentemploymenttimeinlineofworkyears.
		/// </summary>
		internal System.Decimal _currentemploymenttimeinlineofworkyears;
		/// <summary>
		/// Gets and sets the CurrentEmploymentTimeInLineOfWorkYears value of the class instance.
		/// </summary>
		public virtual System.Decimal CurrentEmploymentTimeInLineOfWorkYears
		{
			get
			{
				return _currentemploymenttimeinlineofworkyears;
			}
			set
			{
				_currentemploymenttimeinlineofworkyears = value;
				_currentemploymenttimeinlineofworkyears_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CurrentEmploymentTimeInLineOfWorkYears value to see if it was set to null.
		/// </summary>
		public System.Boolean CurrentEmploymentTimeInLineOfWorkYearsIsNull
		{
			get
			{
				return _currentemploymenttimeinlineofworkyears_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _currentemploymentyearsonjob_isnull = true;
		/// <summary>
		/// Member that stores the value for the currentemploymentyearsonjob.
		/// </summary>
		internal System.Decimal _currentemploymentyearsonjob;
		/// <summary>
		/// Gets and sets the CurrentEmploymentYearsOnJob value of the class instance.
		/// </summary>
		public virtual System.Decimal CurrentEmploymentYearsOnJob
		{
			get
			{
				return _currentemploymentyearsonjob;
			}
			set
			{
				_currentemploymentyearsonjob = value;
				_currentemploymentyearsonjob_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CurrentEmploymentYearsOnJob value to see if it was set to null.
		/// </summary>
		public System.Boolean CurrentEmploymentYearsOnJobIsNull
		{
			get
			{
				return _currentemploymentyearsonjob_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _employmentborrowerselfemployedindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the employmentborrowerselfemployedindicator.
		/// </summary>
		internal System.Boolean _employmentborrowerselfemployedindicator;
		/// <summary>
		/// Gets and sets the EmploymentBorrowerSelfEmployedIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean EmploymentBorrowerSelfEmployedIndicator
		{
			get
			{
				return _employmentborrowerselfemployedindicator;
			}
			set
			{
				_employmentborrowerselfemployedindicator = value;
				_employmentborrowerselfemployedindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _employmentcurrentindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the employmentcurrentindicator.
		/// </summary>
		internal System.Boolean _employmentcurrentindicator;
		/// <summary>
		/// Gets and sets the EmploymentCurrentIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean EmploymentCurrentIndicator
		{
			get
			{
				return _employmentcurrentindicator;
			}
			set
			{
				_employmentcurrentindicator = value;
				_employmentcurrentindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the employmentpositiondescription.
		/// </summary>
		internal System.String _employmentpositiondescription;
		/// <summary>
		/// Gets and sets the EmploymentPositionDescription value of the class instance.
		/// </summary>
		public virtual System.String EmploymentPositionDescription
		{
			get
			{
				return _employmentpositiondescription;
			}
			set
			{
				_employmentpositiondescription = value;
			}
		}


		/// <summary>
		/// Checks the EmploymentPositionDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean EmploymentPositionDescriptionIsNull
		{
			get
			{
				return (_employmentpositiondescription == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _employmentprimaryindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the employmentprimaryindicator.
		/// </summary>
		internal System.Boolean _employmentprimaryindicator;
		/// <summary>
		/// Gets and sets the EmploymentPrimaryIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean EmploymentPrimaryIndicator
		{
			get
			{
				return _employmentprimaryindicator;
			}
			set
			{
				_employmentprimaryindicator = value;
				_employmentprimaryindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _incomeemploymentmonthlyamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the incomeemploymentmonthlyamount.
		/// </summary>
		internal System.Decimal _incomeemploymentmonthlyamount;
		/// <summary>
		/// Gets and sets the IncomeEmploymentMonthlyAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal IncomeEmploymentMonthlyAmount
		{
			get
			{
				return _incomeemploymentmonthlyamount;
			}
			set
			{
				_incomeemploymentmonthlyamount = value;
				_incomeemploymentmonthlyamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the IncomeEmploymentMonthlyAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean IncomeEmploymentMonthlyAmountIsNull
		{
			get
			{
				return _incomeemploymentmonthlyamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _previousemploymentenddate_isnull = true;
		/// <summary>
		/// Member that stores the value for the previousemploymentenddate.
		/// </summary>
		internal System.DateTime _previousemploymentenddate;
		/// <summary>
		/// Gets and sets the PreviousEmploymentEndDate value of the class instance.
		/// </summary>
		public virtual System.DateTime PreviousEmploymentEndDate
		{
			get
			{
				return _previousemploymentenddate;
			}
			set
			{
				_previousemploymentenddate = value;
				_previousemploymentenddate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PreviousEmploymentEndDate value to see if it was set to null.
		/// </summary>
		public System.Boolean PreviousEmploymentEndDateIsNull
		{
			get
			{
				return _previousemploymentenddate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _previousemploymentstartdate_isnull = true;
		/// <summary>
		/// Member that stores the value for the previousemploymentstartdate.
		/// </summary>
		internal System.DateTime _previousemploymentstartdate;
		/// <summary>
		/// Gets and sets the PreviousEmploymentStartDate value of the class instance.
		/// </summary>
		public virtual System.DateTime PreviousEmploymentStartDate
		{
			get
			{
				return _previousemploymentstartdate;
			}
			set
			{
				_previousemploymentstartdate = value;
				_previousemploymentstartdate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PreviousEmploymentStartDate value to see if it was set to null.
		/// </summary>
		public System.Boolean PreviousEmploymentStartDateIsNull
		{
			get
			{
				return _previousemploymentstartdate_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the EmployerBase.
		/// </summary>
		internal static EmployerService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(EmployerService)) as EmployerService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of EmployerBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the Name value as null.
		/// </summary>
		public virtual void SetNameNull()
		{
			_name = null;
		}


		/// <summary>
		/// Marks the StreetAddress value as null.
		/// </summary>
		public virtual void SetStreetAddressNull()
		{
			_streetaddress = null;
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
		/// Marks the TelephoneNumber value as null.
		/// </summary>
		public virtual void SetTelephoneNumberNull()
		{
			_telephonenumber = null;
		}


		/// <summary>
		/// Marks the CurrentEmploymentMonthsOnJob value as null.
		/// </summary>
		public virtual void SetCurrentEmploymentMonthsOnJobNull()
		{
			_currentemploymentmonthsonjob = 0;
			_currentemploymentmonthsonjob_isnull = true;
		}


		/// <summary>
		/// Marks the CurrentEmploymentTimeInLineOfWorkYears value as null.
		/// </summary>
		public virtual void SetCurrentEmploymentTimeInLineOfWorkYearsNull()
		{
			_currentemploymenttimeinlineofworkyears = 0;
			_currentemploymenttimeinlineofworkyears_isnull = true;
		}


		/// <summary>
		/// Marks the CurrentEmploymentYearsOnJob value as null.
		/// </summary>
		public virtual void SetCurrentEmploymentYearsOnJobNull()
		{
			_currentemploymentyearsonjob = 0;
			_currentemploymentyearsonjob_isnull = true;
		}


		/// <summary>
		/// Marks the EmploymentPositionDescription value as null.
		/// </summary>
		public virtual void SetEmploymentPositionDescriptionNull()
		{
			_employmentpositiondescription = null;
		}


		/// <summary>
		/// Marks the IncomeEmploymentMonthlyAmount value as null.
		/// </summary>
		public virtual void SetIncomeEmploymentMonthlyAmountNull()
		{
			_incomeemploymentmonthlyamount = 0;
			_incomeemploymentmonthlyamount_isnull = true;
		}


		/// <summary>
		/// Marks the PreviousEmploymentEndDate value as null.
		/// </summary>
		public virtual void SetPreviousEmploymentEndDateNull()
		{
			_previousemploymentenddate = DateTime.MinValue;
			_previousemploymentenddate_isnull = true;
		}


		/// <summary>
		/// Marks the PreviousEmploymentStartDate value as null.
		/// </summary>
		public virtual void SetPreviousEmploymentStartDateNull()
		{
			_previousemploymentstartdate = DateTime.MinValue;
			_previousemploymentstartdate_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref EmployerBase data)
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
			// assigns the Name data to the class member
			_name = data._name;
			// assigns the StreetAddress data to the class member
			_streetaddress = data._streetaddress;
			// assigns the City data to the class member
			_city = data._city;
			// assigns the State data to the class member
			_state = data._state;
			// assigns the PostalCode data to the class member
			_postalcode = data._postalcode;
			// assigns the TelephoneNumber data to the class member
			_telephonenumber = data._telephonenumber;
			// assigns the CurrentEmploymentMonthsOnJob data to the class member
			_currentemploymentmonthsonjob = data._currentemploymentmonthsonjob;
			_currentemploymentmonthsonjob_isnull = data._currentemploymentmonthsonjob_isnull;
			// assigns the CurrentEmploymentTimeInLineOfWorkYears data to the class member
			_currentemploymenttimeinlineofworkyears = data._currentemploymenttimeinlineofworkyears;
			_currentemploymenttimeinlineofworkyears_isnull = data._currentemploymenttimeinlineofworkyears_isnull;
			// assigns the CurrentEmploymentYearsOnJob data to the class member
			_currentemploymentyearsonjob = data._currentemploymentyearsonjob;
			_currentemploymentyearsonjob_isnull = data._currentemploymentyearsonjob_isnull;
			// assigns the EmploymentBorrowerSelfEmployedIndicator data to the class member
			_employmentborrowerselfemployedindicator = data._employmentborrowerselfemployedindicator;
			_employmentborrowerselfemployedindicator_assigned = data._employmentborrowerselfemployedindicator_assigned;
			// assigns the EmploymentCurrentIndicator data to the class member
			_employmentcurrentindicator = data._employmentcurrentindicator;
			_employmentcurrentindicator_assigned = data._employmentcurrentindicator_assigned;
			// assigns the EmploymentPositionDescription data to the class member
			_employmentpositiondescription = data._employmentpositiondescription;
			// assigns the EmploymentPrimaryIndicator data to the class member
			_employmentprimaryindicator = data._employmentprimaryindicator;
			_employmentprimaryindicator_assigned = data._employmentprimaryindicator_assigned;
			// assigns the IncomeEmploymentMonthlyAmount data to the class member
			_incomeemploymentmonthlyamount = data._incomeemploymentmonthlyamount;
			_incomeemploymentmonthlyamount_isnull = data._incomeemploymentmonthlyamount_isnull;
			// assigns the PreviousEmploymentEndDate data to the class member
			_previousemploymentenddate = data._previousemploymentenddate;
			_previousemploymentenddate_isnull = data._previousemploymentenddate_isnull;
			// assigns the PreviousEmploymentStartDate data to the class member
			_previousemploymentstartdate = data._previousemploymentstartdate;
			_previousemploymentstartdate_isnull = data._previousemploymentstartdate_isnull;


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
			// assigns the Name data to the class member
			if (data["Name"] == System.DBNull.Value)
				SetNameNull();
			else
			{
				_name = Convert.ToString(data["Name"]);
			}
			// assigns the StreetAddress data to the class member
			if (data["StreetAddress"] == System.DBNull.Value)
				SetStreetAddressNull();
			else
			{
				_streetaddress = Convert.ToString(data["StreetAddress"]);
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
			// assigns the TelephoneNumber data to the class member
			if (data["TelephoneNumber"] == System.DBNull.Value)
				SetTelephoneNumberNull();
			else
			{
				_telephonenumber = Convert.ToString(data["TelephoneNumber"]);
			}
			// assigns the CurrentEmploymentMonthsOnJob data to the class member
			if (data["CurrentEmploymentMonthsOnJob"] == System.DBNull.Value)
				SetCurrentEmploymentMonthsOnJobNull();
			else
			{
				_currentemploymentmonthsonjob = Convert.ToDecimal(data["CurrentEmploymentMonthsOnJob"]);
				_currentemploymentmonthsonjob_isnull = false;
			}
			// assigns the CurrentEmploymentTimeInLineOfWorkYears data to the class member
			if (data["CurrentEmploymentTimeInLineOfWorkYears"] == System.DBNull.Value)
				SetCurrentEmploymentTimeInLineOfWorkYearsNull();
			else
			{
				_currentemploymenttimeinlineofworkyears = Convert.ToDecimal(data["CurrentEmploymentTimeInLineOfWorkYears"]);
				_currentemploymenttimeinlineofworkyears_isnull = false;
			}
			// assigns the CurrentEmploymentYearsOnJob data to the class member
			if (data["CurrentEmploymentYearsOnJob"] == System.DBNull.Value)
				SetCurrentEmploymentYearsOnJobNull();
			else
			{
				_currentemploymentyearsonjob = Convert.ToDecimal(data["CurrentEmploymentYearsOnJob"]);
				_currentemploymentyearsonjob_isnull = false;
			}
			// assigns the EmploymentBorrowerSelfEmployedIndicator data to the class member
			_employmentborrowerselfemployedindicator = Convert.ToBoolean(data["EmploymentBorrowerSelfEmployedIndicator"]);
			_employmentborrowerselfemployedindicator_assigned = true;
			// assigns the EmploymentCurrentIndicator data to the class member
			_employmentcurrentindicator = Convert.ToBoolean(data["EmploymentCurrentIndicator"]);
			_employmentcurrentindicator_assigned = true;
			// assigns the EmploymentPositionDescription data to the class member
			if (data["EmploymentPositionDescription"] == System.DBNull.Value)
				SetEmploymentPositionDescriptionNull();
			else
			{
				_employmentpositiondescription = Convert.ToString(data["EmploymentPositionDescription"]);
			}
			// assigns the EmploymentPrimaryIndicator data to the class member
			_employmentprimaryindicator = Convert.ToBoolean(data["EmploymentPrimaryIndicator"]);
			_employmentprimaryindicator_assigned = true;
			// assigns the IncomeEmploymentMonthlyAmount data to the class member
			if (data["IncomeEmploymentMonthlyAmount"] == System.DBNull.Value)
				SetIncomeEmploymentMonthlyAmountNull();
			else
			{
				_incomeemploymentmonthlyamount = Convert.ToDecimal(data["IncomeEmploymentMonthlyAmount"]);
				_incomeemploymentmonthlyamount_isnull = false;
			}
			// assigns the PreviousEmploymentEndDate data to the class member
			if (data["PreviousEmploymentEndDate"] == System.DBNull.Value)
				SetPreviousEmploymentEndDateNull();
			else
			{
				_previousemploymentenddate = Convert.ToDateTime(data["PreviousEmploymentEndDate"]);
				_previousemploymentenddate_isnull = false;
			}
			// assigns the PreviousEmploymentStartDate data to the class member
			if (data["PreviousEmploymentStartDate"] == System.DBNull.Value)
				SetPreviousEmploymentStartDateNull();
			else
			{
				_previousemploymentstartdate = Convert.ToDateTime(data["PreviousEmploymentStartDate"]);
				_previousemploymentstartdate_isnull = false;
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
			// assigns the Name data to the class member
			if (data["Name"] == System.DBNull.Value)
				SetNameNull();
			else
			{
				_name = Convert.ToString(data["Name"]);
			}
			// assigns the StreetAddress data to the class member
			if (data["StreetAddress"] == System.DBNull.Value)
				SetStreetAddressNull();
			else
			{
				_streetaddress = Convert.ToString(data["StreetAddress"]);
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
			// assigns the TelephoneNumber data to the class member
			if (data["TelephoneNumber"] == System.DBNull.Value)
				SetTelephoneNumberNull();
			else
			{
				_telephonenumber = Convert.ToString(data["TelephoneNumber"]);
			}
			// assigns the CurrentEmploymentMonthsOnJob data to the class member
			if (data["CurrentEmploymentMonthsOnJob"] == System.DBNull.Value)
				SetCurrentEmploymentMonthsOnJobNull();
			else
			{
				_currentemploymentmonthsonjob = Convert.ToDecimal(data["CurrentEmploymentMonthsOnJob"]);
				_currentemploymentmonthsonjob_isnull = false;
			}
			// assigns the CurrentEmploymentTimeInLineOfWorkYears data to the class member
			if (data["CurrentEmploymentTimeInLineOfWorkYears"] == System.DBNull.Value)
				SetCurrentEmploymentTimeInLineOfWorkYearsNull();
			else
			{
				_currentemploymenttimeinlineofworkyears = Convert.ToDecimal(data["CurrentEmploymentTimeInLineOfWorkYears"]);
				_currentemploymenttimeinlineofworkyears_isnull = false;
			}
			// assigns the CurrentEmploymentYearsOnJob data to the class member
			if (data["CurrentEmploymentYearsOnJob"] == System.DBNull.Value)
				SetCurrentEmploymentYearsOnJobNull();
			else
			{
				_currentemploymentyearsonjob = Convert.ToDecimal(data["CurrentEmploymentYearsOnJob"]);
				_currentemploymentyearsonjob_isnull = false;
			}
			// assigns the EmploymentBorrowerSelfEmployedIndicator data to the class member
			_employmentborrowerselfemployedindicator = Convert.ToBoolean(data["EmploymentBorrowerSelfEmployedIndicator"]);
			_employmentborrowerselfemployedindicator_assigned = true;
			// assigns the EmploymentCurrentIndicator data to the class member
			_employmentcurrentindicator = Convert.ToBoolean(data["EmploymentCurrentIndicator"]);
			_employmentcurrentindicator_assigned = true;
			// assigns the EmploymentPositionDescription data to the class member
			if (data["EmploymentPositionDescription"] == System.DBNull.Value)
				SetEmploymentPositionDescriptionNull();
			else
			{
				_employmentpositiondescription = Convert.ToString(data["EmploymentPositionDescription"]);
			}
			// assigns the EmploymentPrimaryIndicator data to the class member
			_employmentprimaryindicator = Convert.ToBoolean(data["EmploymentPrimaryIndicator"]);
			_employmentprimaryindicator_assigned = true;
			// assigns the IncomeEmploymentMonthlyAmount data to the class member
			if (data["IncomeEmploymentMonthlyAmount"] == System.DBNull.Value)
				SetIncomeEmploymentMonthlyAmountNull();
			else
			{
				_incomeemploymentmonthlyamount = Convert.ToDecimal(data["IncomeEmploymentMonthlyAmount"]);
				_incomeemploymentmonthlyamount_isnull = false;
			}
			// assigns the PreviousEmploymentEndDate data to the class member
			if (data["PreviousEmploymentEndDate"] == System.DBNull.Value)
				SetPreviousEmploymentEndDateNull();
			else
			{
				_previousemploymentenddate = Convert.ToDateTime(data["PreviousEmploymentEndDate"]);
				_previousemploymentenddate_isnull = false;
			}
			// assigns the PreviousEmploymentStartDate data to the class member
			if (data["PreviousEmploymentStartDate"] == System.DBNull.Value)
				SetPreviousEmploymentStartDateNull();
			else
			{
				_previousemploymentstartdate = Convert.ToDateTime(data["PreviousEmploymentStartDate"]);
				_previousemploymentstartdate_isnull = false;
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
			EmployerBase.ServiceObject.Persist(this as Employer, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the EMPLOYER object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			EmployerBase.ServiceObject.Delete(this as Employer);


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
		/// Gets all persisted Employer objects
		/// </summary>
		public static Employers GetAll()
		{
			// have the service object get the objects
			return EmployerBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
