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
	/// A class that represents an abstract entity for table 'RESIDENCE'
	/// </summary>
	[Serializable]
	public abstract class ResidenceBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ResidenceBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Residence)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ResidenceBase(System.Int64 id)
		{
			// Fill this instance.
			ResidenceBase.ServiceObject.Fill(this as Residence, id);
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
		internal bool _borrowerid_isnull = true;
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
				_borrowerid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerId value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerIdIsNull
		{
			get
			{
				return _borrowerid_isnull;
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
		/// Member that stores the value for the country.
		/// </summary>
		internal System.String _country;
		/// <summary>
		/// Gets and sets the Country value of the class instance.
		/// </summary>
		public virtual System.String Country
		{
			get
			{
				return _country;
			}
			set
			{
				_country = value;
			}
		}


		/// <summary>
		/// Checks the Country value to see if it was set to null.
		/// </summary>
		public System.Boolean CountryIsNull
		{
			get
			{
				return (_country == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerresidencydurationmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerresidencydurationmonths.
		/// </summary>
		internal System.Decimal _borrowerresidencydurationmonths;
		/// <summary>
		/// Gets and sets the BorrowerResidencyDurationMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerResidencyDurationMonths
		{
			get
			{
				return _borrowerresidencydurationmonths;
			}
			set
			{
				_borrowerresidencydurationmonths = value;
				_borrowerresidencydurationmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerResidencyDurationMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerResidencyDurationMonthsIsNull
		{
			get
			{
				return _borrowerresidencydurationmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerresidencydurationyears_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerresidencydurationyears.
		/// </summary>
		internal System.Decimal _borrowerresidencydurationyears;
		/// <summary>
		/// Gets and sets the BorrowerResidencyDurationYears value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerResidencyDurationYears
		{
			get
			{
				return _borrowerresidencydurationyears;
			}
			set
			{
				_borrowerresidencydurationyears = value;
				_borrowerresidencydurationyears_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerResidencyDurationYears value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerResidencyDurationYearsIsNull
		{
			get
			{
				return _borrowerresidencydurationyears_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerresidencybasistype_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerresidencybasistype.
		/// </summary>
		internal System.Int16 _borrowerresidencybasistype;
		/// <summary>
		/// Gets and sets the BorrowerResidencyBasisType value of the class instance.
		/// </summary>
		public virtual System.Int16 BorrowerResidencyBasisType
		{
			get
			{
				return _borrowerresidencybasistype;
			}
			set
			{
				_borrowerresidencybasistype = value;
				_borrowerresidencybasistype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerResidencyBasisType value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerResidencyBasisTypeIsNull
		{
			get
			{
				return _borrowerresidencybasistype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _borrowerresidencytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerresidencytype.
		/// </summary>
		internal System.Int16 _borrowerresidencytype;
		/// <summary>
		/// Gets and sets the BorrowerResidencyType value of the class instance.
		/// </summary>
		public virtual System.Int16 BorrowerResidencyType
		{
			get
			{
				return _borrowerresidencytype;
			}
			set
			{
				_borrowerresidencytype = value;
				_borrowerresidencytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerResidencyType value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerResidencyTypeIsNull
		{
			get
			{
				return _borrowerresidencytype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the ResidenceBase.
		/// </summary>
		internal static ResidenceService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(ResidenceService)) as ResidenceService;
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
		/// Marks the BorrowerId value as null.
		/// </summary>
		public virtual void SetBorrowerIdNull()
		{
			_borrowerid = 0;
			_borrowerid_isnull = true;
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
		/// Marks the Country value as null.
		/// </summary>
		public virtual void SetCountryNull()
		{
			_country = null;
		}


		/// <summary>
		/// Marks the BorrowerResidencyDurationMonths value as null.
		/// </summary>
		public virtual void SetBorrowerResidencyDurationMonthsNull()
		{
			_borrowerresidencydurationmonths = 0;
			_borrowerresidencydurationmonths_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerResidencyDurationYears value as null.
		/// </summary>
		public virtual void SetBorrowerResidencyDurationYearsNull()
		{
			_borrowerresidencydurationyears = 0;
			_borrowerresidencydurationyears_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerResidencyBasisType value as null.
		/// </summary>
		public virtual void SetBorrowerResidencyBasisTypeNull()
		{
			_borrowerresidencybasistype = 0;
			_borrowerresidencybasistype_isnull = true;
		}


		/// <summary>
		/// Marks the BorrowerResidencyType value as null.
		/// </summary>
		public virtual void SetBorrowerResidencyTypeNull()
		{
			_borrowerresidencytype = 0;
			_borrowerresidencytype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref ResidenceBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_isnull = data._borrowerid_isnull;
			// assigns the StreetAddress data to the class member
			_streetaddress = data._streetaddress;
			// assigns the City data to the class member
			_city = data._city;
			// assigns the State data to the class member
			_state = data._state;
			// assigns the PostalCode data to the class member
			_postalcode = data._postalcode;
			// assigns the Country data to the class member
			_country = data._country;
			// assigns the BorrowerResidencyDurationMonths data to the class member
			_borrowerresidencydurationmonths = data._borrowerresidencydurationmonths;
			_borrowerresidencydurationmonths_isnull = data._borrowerresidencydurationmonths_isnull;
			// assigns the BorrowerResidencyDurationYears data to the class member
			_borrowerresidencydurationyears = data._borrowerresidencydurationyears;
			_borrowerresidencydurationyears_isnull = data._borrowerresidencydurationyears_isnull;
			// assigns the BorrowerResidencyBasisType data to the class member
			_borrowerresidencybasistype = data._borrowerresidencybasistype;
			_borrowerresidencybasistype_isnull = data._borrowerresidencybasistype_isnull;
			// assigns the BorrowerResidencyType data to the class member
			_borrowerresidencytype = data._borrowerresidencytype;
			_borrowerresidencytype_isnull = data._borrowerresidencytype_isnull;


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
			if (data["BorrowerId"] == System.DBNull.Value)
				SetBorrowerIdNull();
			else
			{
				_borrowerid = Convert.ToInt64(data["BorrowerId"]);
				_borrowerid_isnull = false;
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
			// assigns the Country data to the class member
			if (data["Country"] == System.DBNull.Value)
				SetCountryNull();
			else
			{
				_country = Convert.ToString(data["Country"]);
			}
			// assigns the BorrowerResidencyDurationMonths data to the class member
			if (data["BorrowerResidencyDurationMonths"] == System.DBNull.Value)
				SetBorrowerResidencyDurationMonthsNull();
			else
			{
				_borrowerresidencydurationmonths = Convert.ToDecimal(data["BorrowerResidencyDurationMonths"]);
				_borrowerresidencydurationmonths_isnull = false;
			}
			// assigns the BorrowerResidencyDurationYears data to the class member
			if (data["BorrowerResidencyDurationYears"] == System.DBNull.Value)
				SetBorrowerResidencyDurationYearsNull();
			else
			{
				_borrowerresidencydurationyears = Convert.ToDecimal(data["BorrowerResidencyDurationYears"]);
				_borrowerresidencydurationyears_isnull = false;
			}
			// assigns the BorrowerResidencyBasisType data to the class member
			if (data["BorrowerResidencyBasisType"] == System.DBNull.Value)
				SetBorrowerResidencyBasisTypeNull();
			else
			{
				_borrowerresidencybasistype = Convert.ToInt16(data["BorrowerResidencyBasisType"]);
				_borrowerresidencybasistype_isnull = false;
			}
			// assigns the BorrowerResidencyType data to the class member
			if (data["BorrowerResidencyType"] == System.DBNull.Value)
				SetBorrowerResidencyTypeNull();
			else
			{
				_borrowerresidencytype = Convert.ToInt16(data["BorrowerResidencyType"]);
				_borrowerresidencytype_isnull = false;
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
			if (data["BorrowerId"] == System.DBNull.Value)
				SetBorrowerIdNull();
			else
			{
				_borrowerid = Convert.ToInt64(data["BorrowerId"]);
				_borrowerid_isnull = false;
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
			// assigns the Country data to the class member
			if (data["Country"] == System.DBNull.Value)
				SetCountryNull();
			else
			{
				_country = Convert.ToString(data["Country"]);
			}
			// assigns the BorrowerResidencyDurationMonths data to the class member
			if (data["BorrowerResidencyDurationMonths"] == System.DBNull.Value)
				SetBorrowerResidencyDurationMonthsNull();
			else
			{
				_borrowerresidencydurationmonths = Convert.ToDecimal(data["BorrowerResidencyDurationMonths"]);
				_borrowerresidencydurationmonths_isnull = false;
			}
			// assigns the BorrowerResidencyDurationYears data to the class member
			if (data["BorrowerResidencyDurationYears"] == System.DBNull.Value)
				SetBorrowerResidencyDurationYearsNull();
			else
			{
				_borrowerresidencydurationyears = Convert.ToDecimal(data["BorrowerResidencyDurationYears"]);
				_borrowerresidencydurationyears_isnull = false;
			}
			// assigns the BorrowerResidencyBasisType data to the class member
			if (data["BorrowerResidencyBasisType"] == System.DBNull.Value)
				SetBorrowerResidencyBasisTypeNull();
			else
			{
				_borrowerresidencybasistype = Convert.ToInt16(data["BorrowerResidencyBasisType"]);
				_borrowerresidencybasistype_isnull = false;
			}
			// assigns the BorrowerResidencyType data to the class member
			if (data["BorrowerResidencyType"] == System.DBNull.Value)
				SetBorrowerResidencyTypeNull();
			else
			{
				_borrowerresidencytype = Convert.ToInt16(data["BorrowerResidencyType"]);
				_borrowerresidencytype_isnull = false;
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
			ResidenceBase.ServiceObject.Persist(this as Residence, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the RESIDENCE object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			ResidenceBase.ServiceObject.Delete(this as Residence);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the BorrowerResidencyType relationship.
		/// </summary>
		public BorrowerResidencyType GetBorrowerResidencyType()
		{
			if (_borrowerresidencytype_isnull)
				return null;
			else
				return new BorrowerResidencyType(_borrowerresidencytype);
		}


		/// <summary>
		/// Gets the single object for the BorrowerResidencyBasisType relationship.
		/// </summary>
		public BorrowerResidencyBasisType GetBorrowerResidencyBasisType()
		{
			if (_borrowerresidencybasistype_isnull)
				return null;
			else
				return new BorrowerResidencyBasisType(_borrowerresidencybasistype);
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
		/// Gets all persisted Residence objects
		/// </summary>
		public static Residences GetAll()
		{
			// have the service object get the objects
			return ResidenceBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
