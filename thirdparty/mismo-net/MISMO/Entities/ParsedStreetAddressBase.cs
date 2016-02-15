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
	/// A class that represents an abstract entity for table 'PARSED_STREET_ADDRESS'
	/// </summary>
	[Serializable]
	public abstract class ParsedStreetAddressBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ParsedStreetAddressBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.ParsedStreetAddress)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ParsedStreetAddressBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			ParsedStreetAddressBase.ServiceObject.Fill(this as ParsedStreetAddress, loanApplicationId);
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
		/// Member that stores the value for the apartmentorunit.
		/// </summary>
		internal System.String _apartmentorunit;
		/// <summary>
		/// Gets and sets the ApartmentOrUnit value of the class instance.
		/// </summary>
		public virtual System.String ApartmentOrUnit
		{
			get
			{
				return _apartmentorunit;
			}
			set
			{
				_apartmentorunit = value;
			}
		}


		/// <summary>
		/// Checks the ApartmentOrUnit value to see if it was set to null.
		/// </summary>
		public System.Boolean ApartmentOrUnitIsNull
		{
			get
			{
				return (_apartmentorunit == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the directionprefix.
		/// </summary>
		internal System.String _directionprefix;
		/// <summary>
		/// Gets and sets the DirectionPrefix value of the class instance.
		/// </summary>
		public virtual System.String DirectionPrefix
		{
			get
			{
				return _directionprefix;
			}
			set
			{
				_directionprefix = value;
			}
		}


		/// <summary>
		/// Checks the DirectionPrefix value to see if it was set to null.
		/// </summary>
		public System.Boolean DirectionPrefixIsNull
		{
			get
			{
				return (_directionprefix == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the directionsuffix.
		/// </summary>
		internal System.String _directionsuffix;
		/// <summary>
		/// Gets and sets the DirectionSuffix value of the class instance.
		/// </summary>
		public virtual System.String DirectionSuffix
		{
			get
			{
				return _directionsuffix;
			}
			set
			{
				_directionsuffix = value;
			}
		}


		/// <summary>
		/// Checks the DirectionSuffix value to see if it was set to null.
		/// </summary>
		public System.Boolean DirectionSuffixIsNull
		{
			get
			{
				return (_directionsuffix == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the buildingnumber.
		/// </summary>
		internal System.String _buildingnumber;
		/// <summary>
		/// Gets and sets the BuildingNumber value of the class instance.
		/// </summary>
		public virtual System.String BuildingNumber
		{
			get
			{
				return _buildingnumber;
			}
			set
			{
				_buildingnumber = value;
			}
		}


		/// <summary>
		/// Checks the BuildingNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean BuildingNumberIsNull
		{
			get
			{
				return (_buildingnumber == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the housenumber.
		/// </summary>
		internal System.String _housenumber;
		/// <summary>
		/// Gets and sets the HouseNumber value of the class instance.
		/// </summary>
		public virtual System.String HouseNumber
		{
			get
			{
				return _housenumber;
			}
			set
			{
				_housenumber = value;
			}
		}


		/// <summary>
		/// Checks the HouseNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean HouseNumberIsNull
		{
			get
			{
				return (_housenumber == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the military_apo_fpo.
		/// </summary>
		internal System.String _military_apo_fpo;
		/// <summary>
		/// Gets and sets the Military_APO_FPO value of the class instance.
		/// </summary>
		public virtual System.String Military_APO_FPO
		{
			get
			{
				return _military_apo_fpo;
			}
			set
			{
				_military_apo_fpo = value;
			}
		}


		/// <summary>
		/// Checks the Military_APO_FPO value to see if it was set to null.
		/// </summary>
		public System.Boolean Military_APO_FPOIsNull
		{
			get
			{
				return (_military_apo_fpo == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the postofficebox.
		/// </summary>
		internal System.String _postofficebox;
		/// <summary>
		/// Gets and sets the PostOfficeBox value of the class instance.
		/// </summary>
		public virtual System.String PostOfficeBox
		{
			get
			{
				return _postofficebox;
			}
			set
			{
				_postofficebox = value;
			}
		}


		/// <summary>
		/// Checks the PostOfficeBox value to see if it was set to null.
		/// </summary>
		public System.Boolean PostOfficeBoxIsNull
		{
			get
			{
				return (_postofficebox == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the ruralroute.
		/// </summary>
		internal System.String _ruralroute;
		/// <summary>
		/// Gets and sets the RuralRoute value of the class instance.
		/// </summary>
		public virtual System.String RuralRoute
		{
			get
			{
				return _ruralroute;
			}
			set
			{
				_ruralroute = value;
			}
		}


		/// <summary>
		/// Checks the RuralRoute value to see if it was set to null.
		/// </summary>
		public System.Boolean RuralRouteIsNull
		{
			get
			{
				return (_ruralroute == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the streetname.
		/// </summary>
		internal System.String _streetname;
		/// <summary>
		/// Gets and sets the StreetName value of the class instance.
		/// </summary>
		public virtual System.String StreetName
		{
			get
			{
				return _streetname;
			}
			set
			{
				_streetname = value;
			}
		}


		/// <summary>
		/// Checks the StreetName value to see if it was set to null.
		/// </summary>
		public System.Boolean StreetNameIsNull
		{
			get
			{
				return (_streetname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the streetsuffix.
		/// </summary>
		internal System.String _streetsuffix;
		/// <summary>
		/// Gets and sets the StreetSuffix value of the class instance.
		/// </summary>
		public virtual System.String StreetSuffix
		{
			get
			{
				return _streetsuffix;
			}
			set
			{
				_streetsuffix = value;
			}
		}


		/// <summary>
		/// Checks the StreetSuffix value to see if it was set to null.
		/// </summary>
		public System.Boolean StreetSuffixIsNull
		{
			get
			{
				return (_streetsuffix == null);
			}
		}


		/// <summary>
		/// Gets the service object for the ParsedStreetAddressBase.
		/// </summary>
		internal static ParsedStreetAddressService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(ParsedStreetAddressService)) as ParsedStreetAddressService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of ParsedStreetAddressBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the ApartmentOrUnit value as null.
		/// </summary>
		public virtual void SetApartmentOrUnitNull()
		{
			_apartmentorunit = null;
		}


		/// <summary>
		/// Marks the DirectionPrefix value as null.
		/// </summary>
		public virtual void SetDirectionPrefixNull()
		{
			_directionprefix = null;
		}


		/// <summary>
		/// Marks the DirectionSuffix value as null.
		/// </summary>
		public virtual void SetDirectionSuffixNull()
		{
			_directionsuffix = null;
		}


		/// <summary>
		/// Marks the BuildingNumber value as null.
		/// </summary>
		public virtual void SetBuildingNumberNull()
		{
			_buildingnumber = null;
		}


		/// <summary>
		/// Marks the HouseNumber value as null.
		/// </summary>
		public virtual void SetHouseNumberNull()
		{
			_housenumber = null;
		}


		/// <summary>
		/// Marks the Military_APO_FPO value as null.
		/// </summary>
		public virtual void SetMilitary_APO_FPONull()
		{
			_military_apo_fpo = null;
		}


		/// <summary>
		/// Marks the PostOfficeBox value as null.
		/// </summary>
		public virtual void SetPostOfficeBoxNull()
		{
			_postofficebox = null;
		}


		/// <summary>
		/// Marks the RuralRoute value as null.
		/// </summary>
		public virtual void SetRuralRouteNull()
		{
			_ruralroute = null;
		}


		/// <summary>
		/// Marks the StreetName value as null.
		/// </summary>
		public virtual void SetStreetNameNull()
		{
			_streetname = null;
		}


		/// <summary>
		/// Marks the StreetSuffix value as null.
		/// </summary>
		public virtual void SetStreetSuffixNull()
		{
			_streetsuffix = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref ParsedStreetAddressBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the ApartmentOrUnit data to the class member
			_apartmentorunit = data._apartmentorunit;
			// assigns the DirectionPrefix data to the class member
			_directionprefix = data._directionprefix;
			// assigns the DirectionSuffix data to the class member
			_directionsuffix = data._directionsuffix;
			// assigns the BuildingNumber data to the class member
			_buildingnumber = data._buildingnumber;
			// assigns the HouseNumber data to the class member
			_housenumber = data._housenumber;
			// assigns the Military_APO_FPO data to the class member
			_military_apo_fpo = data._military_apo_fpo;
			// assigns the PostOfficeBox data to the class member
			_postofficebox = data._postofficebox;
			// assigns the RuralRoute data to the class member
			_ruralroute = data._ruralroute;
			// assigns the StreetName data to the class member
			_streetname = data._streetname;
			// assigns the StreetSuffix data to the class member
			_streetsuffix = data._streetsuffix;


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
			// assigns the ApartmentOrUnit data to the class member
			if (data["ApartmentOrUnit"] == System.DBNull.Value)
				SetApartmentOrUnitNull();
			else
			{
				_apartmentorunit = Convert.ToString(data["ApartmentOrUnit"]);
			}
			// assigns the DirectionPrefix data to the class member
			if (data["DirectionPrefix"] == System.DBNull.Value)
				SetDirectionPrefixNull();
			else
			{
				_directionprefix = Convert.ToString(data["DirectionPrefix"]);
			}
			// assigns the DirectionSuffix data to the class member
			if (data["DirectionSuffix"] == System.DBNull.Value)
				SetDirectionSuffixNull();
			else
			{
				_directionsuffix = Convert.ToString(data["DirectionSuffix"]);
			}
			// assigns the BuildingNumber data to the class member
			if (data["BuildingNumber"] == System.DBNull.Value)
				SetBuildingNumberNull();
			else
			{
				_buildingnumber = Convert.ToString(data["BuildingNumber"]);
			}
			// assigns the HouseNumber data to the class member
			if (data["HouseNumber"] == System.DBNull.Value)
				SetHouseNumberNull();
			else
			{
				_housenumber = Convert.ToString(data["HouseNumber"]);
			}
			// assigns the Military_APO_FPO data to the class member
			if (data["Military_APO_FPO"] == System.DBNull.Value)
				SetMilitary_APO_FPONull();
			else
			{
				_military_apo_fpo = Convert.ToString(data["Military_APO_FPO"]);
			}
			// assigns the PostOfficeBox data to the class member
			if (data["PostOfficeBox"] == System.DBNull.Value)
				SetPostOfficeBoxNull();
			else
			{
				_postofficebox = Convert.ToString(data["PostOfficeBox"]);
			}
			// assigns the RuralRoute data to the class member
			if (data["RuralRoute"] == System.DBNull.Value)
				SetRuralRouteNull();
			else
			{
				_ruralroute = Convert.ToString(data["RuralRoute"]);
			}
			// assigns the StreetName data to the class member
			if (data["StreetName"] == System.DBNull.Value)
				SetStreetNameNull();
			else
			{
				_streetname = Convert.ToString(data["StreetName"]);
			}
			// assigns the StreetSuffix data to the class member
			if (data["StreetSuffix"] == System.DBNull.Value)
				SetStreetSuffixNull();
			else
			{
				_streetsuffix = Convert.ToString(data["StreetSuffix"]);
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
			// assigns the ApartmentOrUnit data to the class member
			if (data["ApartmentOrUnit"] == System.DBNull.Value)
				SetApartmentOrUnitNull();
			else
			{
				_apartmentorunit = Convert.ToString(data["ApartmentOrUnit"]);
			}
			// assigns the DirectionPrefix data to the class member
			if (data["DirectionPrefix"] == System.DBNull.Value)
				SetDirectionPrefixNull();
			else
			{
				_directionprefix = Convert.ToString(data["DirectionPrefix"]);
			}
			// assigns the DirectionSuffix data to the class member
			if (data["DirectionSuffix"] == System.DBNull.Value)
				SetDirectionSuffixNull();
			else
			{
				_directionsuffix = Convert.ToString(data["DirectionSuffix"]);
			}
			// assigns the BuildingNumber data to the class member
			if (data["BuildingNumber"] == System.DBNull.Value)
				SetBuildingNumberNull();
			else
			{
				_buildingnumber = Convert.ToString(data["BuildingNumber"]);
			}
			// assigns the HouseNumber data to the class member
			if (data["HouseNumber"] == System.DBNull.Value)
				SetHouseNumberNull();
			else
			{
				_housenumber = Convert.ToString(data["HouseNumber"]);
			}
			// assigns the Military_APO_FPO data to the class member
			if (data["Military_APO_FPO"] == System.DBNull.Value)
				SetMilitary_APO_FPONull();
			else
			{
				_military_apo_fpo = Convert.ToString(data["Military_APO_FPO"]);
			}
			// assigns the PostOfficeBox data to the class member
			if (data["PostOfficeBox"] == System.DBNull.Value)
				SetPostOfficeBoxNull();
			else
			{
				_postofficebox = Convert.ToString(data["PostOfficeBox"]);
			}
			// assigns the RuralRoute data to the class member
			if (data["RuralRoute"] == System.DBNull.Value)
				SetRuralRouteNull();
			else
			{
				_ruralroute = Convert.ToString(data["RuralRoute"]);
			}
			// assigns the StreetName data to the class member
			if (data["StreetName"] == System.DBNull.Value)
				SetStreetNameNull();
			else
			{
				_streetname = Convert.ToString(data["StreetName"]);
			}
			// assigns the StreetSuffix data to the class member
			if (data["StreetSuffix"] == System.DBNull.Value)
				SetStreetSuffixNull();
			else
			{
				_streetsuffix = Convert.ToString(data["StreetSuffix"]);
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
			ParsedStreetAddressBase.ServiceObject.Persist(this as ParsedStreetAddress, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the PARSED_STREET_ADDRESS object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			ParsedStreetAddressBase.ServiceObject.Delete(this as ParsedStreetAddress);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the PROPERTY relationship.
		/// </summary>
		public Property GetProperty()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new Property(_loanapplicationid);
		}


		/// <summary>
		/// Gets all persisted ParsedStreetAddress objects
		/// </summary>
		public static ParsedStreetAddresses GetAll()
		{
			// have the service object get the objects
			return ParsedStreetAddressBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
