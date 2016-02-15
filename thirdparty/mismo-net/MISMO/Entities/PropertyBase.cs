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
	/// A class that represents an abstract entity for table 'PROPERTY'
	/// </summary>
	[Serializable]
	public abstract class PropertyBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PropertyBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Property)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public PropertyBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			PropertyBase.ServiceObject.Fill(this as Property, loanApplicationId);
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
		/// Member that stores the value for the county.
		/// </summary>
		internal System.String _county;
		/// <summary>
		/// Gets and sets the County value of the class instance.
		/// </summary>
		public virtual System.String County
		{
			get
			{
				return _county;
			}
			set
			{
				_county = value;
			}
		}


		/// <summary>
		/// Checks the County value to see if it was set to null.
		/// </summary>
		public System.Boolean CountyIsNull
		{
			get
			{
				return (_county == null);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _financednumberofunits_isnull = true;
		/// <summary>
		/// Member that stores the value for the financednumberofunits.
		/// </summary>
		internal System.Int32 _financednumberofunits;
		/// <summary>
		/// Gets and sets the FinancedNumberOfUnits value of the class instance.
		/// </summary>
		public virtual System.Int32 FinancedNumberOfUnits
		{
			get
			{
				return _financednumberofunits;
			}
			set
			{
				_financednumberofunits = value;
				_financednumberofunits_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FinancedNumberOfUnits value to see if it was set to null.
		/// </summary>
		public System.Boolean FinancedNumberOfUnitsIsNull
		{
			get
			{
				return _financednumberofunits_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _structurebuiltyear_isnull = true;
		/// <summary>
		/// Member that stores the value for the structurebuiltyear.
		/// </summary>
		internal System.DateTime _structurebuiltyear;
		/// <summary>
		/// Gets and sets the StructureBuiltYear value of the class instance.
		/// </summary>
		public virtual System.DateTime StructureBuiltYear
		{
			get
			{
				return _structurebuiltyear;
			}
			set
			{
				_structurebuiltyear = value;
				_structurebuiltyear_isnull = false;
			}
		}


		/// <summary>
		/// Checks the StructureBuiltYear value to see if it was set to null.
		/// </summary>
		public System.Boolean StructureBuiltYearIsNull
		{
			get
			{
				return _structurebuiltyear_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _acquireddate_isnull = true;
		/// <summary>
		/// Member that stores the value for the acquireddate.
		/// </summary>
		internal System.DateTime _acquireddate;
		/// <summary>
		/// Gets and sets the AcquiredDate value of the class instance.
		/// </summary>
		public virtual System.DateTime AcquiredDate
		{
			get
			{
				return _acquireddate;
			}
			set
			{
				_acquireddate = value;
				_acquireddate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AcquiredDate value to see if it was set to null.
		/// </summary>
		public System.Boolean AcquiredDateIsNull
		{
			get
			{
				return _acquireddate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _plannedunitdevelopmentindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the plannedunitdevelopmentindicator.
		/// </summary>
		internal System.Boolean _plannedunitdevelopmentindicator;
		/// <summary>
		/// Gets and sets the PlannedUnitDevelopmentIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PlannedUnitDevelopmentIndicator
		{
			get
			{
				return _plannedunitdevelopmentindicator;
			}
			set
			{
				_plannedunitdevelopmentindicator = value;
				_plannedunitdevelopmentindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _acreagenumber_isnull = true;
		/// <summary>
		/// Member that stores the value for the acreagenumber.
		/// </summary>
		internal System.Decimal _acreagenumber;
		/// <summary>
		/// Gets and sets the AcreageNumber value of the class instance.
		/// </summary>
		public virtual System.Decimal AcreageNumber
		{
			get
			{
				return _acreagenumber;
			}
			set
			{
				_acreagenumber = value;
				_acreagenumber_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AcreageNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean AcreageNumberIsNull
		{
			get
			{
				return _acreagenumber_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _buildingstatustype_isnull = true;
		/// <summary>
		/// Member that stores the value for the buildingstatustype.
		/// </summary>
		internal System.Int16 _buildingstatustype;
		/// <summary>
		/// Gets and sets the BuildingStatusType value of the class instance.
		/// </summary>
		public virtual System.Int16 BuildingStatusType
		{
			get
			{
				return _buildingstatustype;
			}
			set
			{
				_buildingstatustype = value;
				_buildingstatustype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BuildingStatusType value to see if it was set to null.
		/// </summary>
		public System.Boolean BuildingStatusTypeIsNull
		{
			get
			{
				return _buildingstatustype_isnull;
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
		/// Gets the service object for the PropertyBase.
		/// </summary>
		internal static PropertyService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(PropertyService)) as PropertyService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of PropertyBase. The value has not been explicitly assigned.", exceptions);


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
		/// Marks the County value as null.
		/// </summary>
		public virtual void SetCountyNull()
		{
			_county = null;
		}


		/// <summary>
		/// Marks the PostalCode value as null.
		/// </summary>
		public virtual void SetPostalCodeNull()
		{
			_postalcode = null;
		}


		/// <summary>
		/// Marks the FinancedNumberOfUnits value as null.
		/// </summary>
		public virtual void SetFinancedNumberOfUnitsNull()
		{
			_financednumberofunits = 0;
			_financednumberofunits_isnull = true;
		}


		/// <summary>
		/// Marks the StructureBuiltYear value as null.
		/// </summary>
		public virtual void SetStructureBuiltYearNull()
		{
			_structurebuiltyear = DateTime.MinValue;
			_structurebuiltyear_isnull = true;
		}


		/// <summary>
		/// Marks the AcquiredDate value as null.
		/// </summary>
		public virtual void SetAcquiredDateNull()
		{
			_acquireddate = DateTime.MinValue;
			_acquireddate_isnull = true;
		}


		/// <summary>
		/// Marks the AcreageNumber value as null.
		/// </summary>
		public virtual void SetAcreageNumberNull()
		{
			_acreagenumber = 0;
			_acreagenumber_isnull = true;
		}


		/// <summary>
		/// Marks the BuildingStatusType value as null.
		/// </summary>
		public virtual void SetBuildingStatusTypeNull()
		{
			_buildingstatustype = 0;
			_buildingstatustype_isnull = true;
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
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref PropertyBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the StreetAddress data to the class member
			_streetaddress = data._streetaddress;
			// assigns the StreetAddress2 data to the class member
			_streetaddress2 = data._streetaddress2;
			// assigns the City data to the class member
			_city = data._city;
			// assigns the State data to the class member
			_state = data._state;
			// assigns the County data to the class member
			_county = data._county;
			// assigns the PostalCode data to the class member
			_postalcode = data._postalcode;
			// assigns the FinancedNumberOfUnits data to the class member
			_financednumberofunits = data._financednumberofunits;
			_financednumberofunits_isnull = data._financednumberofunits_isnull;
			// assigns the StructureBuiltYear data to the class member
			_structurebuiltyear = data._structurebuiltyear;
			_structurebuiltyear_isnull = data._structurebuiltyear_isnull;
			// assigns the AcquiredDate data to the class member
			_acquireddate = data._acquireddate;
			_acquireddate_isnull = data._acquireddate_isnull;
			// assigns the PlannedUnitDevelopmentIndicator data to the class member
			_plannedunitdevelopmentindicator = data._plannedunitdevelopmentindicator;
			_plannedunitdevelopmentindicator_assigned = data._plannedunitdevelopmentindicator_assigned;
			// assigns the AcreageNumber data to the class member
			_acreagenumber = data._acreagenumber;
			_acreagenumber_isnull = data._acreagenumber_isnull;
			// assigns the BuildingStatusType data to the class member
			_buildingstatustype = data._buildingstatustype;
			_buildingstatustype_isnull = data._buildingstatustype_isnull;
			// assigns the GSEPropertyType data to the class member
			_gsepropertytype = data._gsepropertytype;
			_gsepropertytype_isnull = data._gsepropertytype_isnull;


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
			// assigns the County data to the class member
			if (data["County"] == System.DBNull.Value)
				SetCountyNull();
			else
			{
				_county = Convert.ToString(data["County"]);
			}
			// assigns the PostalCode data to the class member
			if (data["PostalCode"] == System.DBNull.Value)
				SetPostalCodeNull();
			else
			{
				_postalcode = Convert.ToString(data["PostalCode"]);
			}
			// assigns the FinancedNumberOfUnits data to the class member
			if (data["FinancedNumberOfUnits"] == System.DBNull.Value)
				SetFinancedNumberOfUnitsNull();
			else
			{
				_financednumberofunits = Convert.ToInt32(data["FinancedNumberOfUnits"]);
				_financednumberofunits_isnull = false;
			}
			// assigns the StructureBuiltYear data to the class member
			if (data["StructureBuiltYear"] == System.DBNull.Value)
				SetStructureBuiltYearNull();
			else
			{
				_structurebuiltyear = Convert.ToDateTime(data["StructureBuiltYear"]);
				_structurebuiltyear_isnull = false;
			}
			// assigns the AcquiredDate data to the class member
			if (data["AcquiredDate"] == System.DBNull.Value)
				SetAcquiredDateNull();
			else
			{
				_acquireddate = Convert.ToDateTime(data["AcquiredDate"]);
				_acquireddate_isnull = false;
			}
			// assigns the PlannedUnitDevelopmentIndicator data to the class member
			_plannedunitdevelopmentindicator = Convert.ToBoolean(data["PlannedUnitDevelopmentIndicator"]);
			_plannedunitdevelopmentindicator_assigned = true;
			// assigns the AcreageNumber data to the class member
			if (data["AcreageNumber"] == System.DBNull.Value)
				SetAcreageNumberNull();
			else
			{
				_acreagenumber = Convert.ToDecimal(data["AcreageNumber"]);
				_acreagenumber_isnull = false;
			}
			// assigns the BuildingStatusType data to the class member
			if (data["BuildingStatusType"] == System.DBNull.Value)
				SetBuildingStatusTypeNull();
			else
			{
				_buildingstatustype = Convert.ToInt16(data["BuildingStatusType"]);
				_buildingstatustype_isnull = false;
			}
			// assigns the GSEPropertyType data to the class member
			if (data["GSEPropertyType"] == System.DBNull.Value)
				SetGSEPropertyTypeNull();
			else
			{
				_gsepropertytype = Convert.ToInt16(data["GSEPropertyType"]);
				_gsepropertytype_isnull = false;
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
			// assigns the County data to the class member
			if (data["County"] == System.DBNull.Value)
				SetCountyNull();
			else
			{
				_county = Convert.ToString(data["County"]);
			}
			// assigns the PostalCode data to the class member
			if (data["PostalCode"] == System.DBNull.Value)
				SetPostalCodeNull();
			else
			{
				_postalcode = Convert.ToString(data["PostalCode"]);
			}
			// assigns the FinancedNumberOfUnits data to the class member
			if (data["FinancedNumberOfUnits"] == System.DBNull.Value)
				SetFinancedNumberOfUnitsNull();
			else
			{
				_financednumberofunits = Convert.ToInt32(data["FinancedNumberOfUnits"]);
				_financednumberofunits_isnull = false;
			}
			// assigns the StructureBuiltYear data to the class member
			if (data["StructureBuiltYear"] == System.DBNull.Value)
				SetStructureBuiltYearNull();
			else
			{
				_structurebuiltyear = Convert.ToDateTime(data["StructureBuiltYear"]);
				_structurebuiltyear_isnull = false;
			}
			// assigns the AcquiredDate data to the class member
			if (data["AcquiredDate"] == System.DBNull.Value)
				SetAcquiredDateNull();
			else
			{
				_acquireddate = Convert.ToDateTime(data["AcquiredDate"]);
				_acquireddate_isnull = false;
			}
			// assigns the PlannedUnitDevelopmentIndicator data to the class member
			_plannedunitdevelopmentindicator = Convert.ToBoolean(data["PlannedUnitDevelopmentIndicator"]);
			_plannedunitdevelopmentindicator_assigned = true;
			// assigns the AcreageNumber data to the class member
			if (data["AcreageNumber"] == System.DBNull.Value)
				SetAcreageNumberNull();
			else
			{
				_acreagenumber = Convert.ToDecimal(data["AcreageNumber"]);
				_acreagenumber_isnull = false;
			}
			// assigns the BuildingStatusType data to the class member
			if (data["BuildingStatusType"] == System.DBNull.Value)
				SetBuildingStatusTypeNull();
			else
			{
				_buildingstatustype = Convert.ToInt16(data["BuildingStatusType"]);
				_buildingstatustype_isnull = false;
			}
			// assigns the GSEPropertyType data to the class member
			if (data["GSEPropertyType"] == System.DBNull.Value)
				SetGSEPropertyTypeNull();
			else
			{
				_gsepropertytype = Convert.ToInt16(data["GSEPropertyType"]);
				_gsepropertytype_isnull = false;
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
			PropertyBase.ServiceObject.Persist(this as Property, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the PROPERTY object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			PropertyBase.ServiceObject.Delete(this as Property);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the LEGAL_DESCRIPTION relationship.
		/// </summary>
		public LegalDescriptions GetLegalDescriptions()
		{
			LegalDescriptions legaldescriptions = new LegalDescriptions();


			LegalDescriptionBase.ServiceObject.FillByProperty(legaldescriptions, _loanapplicationid);
			return legaldescriptions;
		}


		/// <summary>
		/// Gets the objects for the PARSED_STREET_ADDRESS relationship.
		/// </summary>
		public ParsedStreetAddresses GetParsedStreetAddresses()
		{
			ParsedStreetAddresses parsedstreetaddresses = new ParsedStreetAddresses();


			ParsedStreetAddressBase.ServiceObject.FillByProperty(parsedstreetaddresses, _loanapplicationid);
			return parsedstreetaddresses;
		}


		/// <summary>
		/// Gets the objects for the VALUATION relationship.
		/// </summary>
		public Valuations GetValuations()
		{
			Valuations valuations = new Valuations();


			ValuationBase.ServiceObject.FillByProperty(valuations, _loanapplicationid);
			return valuations;
		}


		/// <summary>
		/// Gets the single object for the BuildingStatusType relationship.
		/// </summary>
		public BuildingStatusType GetBuildingStatusType()
		{
			if (_buildingstatustype_isnull)
				return null;
			else
				return new BuildingStatusType(_buildingstatustype);
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
		/// Gets all persisted Property objects
		/// </summary>
		public static Properties GetAll()
		{
			// have the service object get the objects
			return PropertyBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
