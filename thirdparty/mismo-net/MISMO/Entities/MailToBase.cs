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
	/// A class that represents an abstract entity for table 'MAIL_TO'
	/// </summary>
	[Serializable]
	public abstract class MailToBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MailToBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.MailTo)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public MailToBase(System.Int64 borrowerId)
		{
			// Fill this instance.
			MailToBase.ServiceObject.Fill(this as MailTo, borrowerId);
		}



		#endregion Constructors


		#region Properties

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
		/// Gets the service object for the MailToBase.
		/// </summary>
		internal static MailToService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(MailToService)) as MailToService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of MailToBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

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
		/// Marks the Country value as null.
		/// </summary>
		public virtual void SetCountryNull()
		{
			_country = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref MailToBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
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
			// assigns the Country data to the class member
			_country = data._country;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.SqlClient.SqlDataReader data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
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
			// assigns the Country data to the class member
			if (data["Country"] == System.DBNull.Value)
				SetCountryNull();
			else
			{
				_country = Convert.ToString(data["Country"]);
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


			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
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
			// assigns the Country data to the class member
			if (data["Country"] == System.DBNull.Value)
				SetCountryNull();
			else
			{
				_country = Convert.ToString(data["Country"]);
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
			MailToBase.ServiceObject.Persist(this as MailTo, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the MAIL_TO object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			MailToBase.ServiceObject.Delete(this as MailTo);


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
		/// Gets all persisted MailTo objects
		/// </summary>
		public static MailToCollection GetAll()
		{
			// have the service object get the objects
			return MailToBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
