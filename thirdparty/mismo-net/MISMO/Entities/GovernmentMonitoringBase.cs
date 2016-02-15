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
	/// A class that represents an abstract entity for table 'GOVERNMENT_MONITORING'
	/// </summary>
	[Serializable]
	public abstract class GovernmentMonitoringBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentMonitoringBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.GovernmentMonitoring)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public GovernmentMonitoringBase(System.Int64 borrowerId)
		{
			// Fill this instance.
			GovernmentMonitoringBase.ServiceObject.Fill(this as GovernmentMonitoring, borrowerId);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _gendertype_isnull = true;
		/// <summary>
		/// Member that stores the value for the gendertype.
		/// </summary>
		internal System.Int16 _gendertype;
		/// <summary>
		/// Gets and sets the GenderType value of the class instance.
		/// </summary>
		public virtual System.Int16 GenderType
		{
			get
			{
				return _gendertype;
			}
			set
			{
				_gendertype = value;
				_gendertype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the GenderType value to see if it was set to null.
		/// </summary>
		public System.Boolean GenderTypeIsNull
		{
			get
			{
				return _gendertype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the otherracenationalorigindescription.
		/// </summary>
		internal System.String _otherracenationalorigindescription;
		/// <summary>
		/// Gets and sets the OtherRaceNationalOriginDescription value of the class instance.
		/// </summary>
		public virtual System.String OtherRaceNationalOriginDescription
		{
			get
			{
				return _otherracenationalorigindescription;
			}
			set
			{
				_otherracenationalorigindescription = value;
			}
		}


		/// <summary>
		/// Checks the OtherRaceNationalOriginDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherRaceNationalOriginDescriptionIsNull
		{
			get
			{
				return (_otherracenationalorigindescription == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _racenationaloriginrefusalindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the racenationaloriginrefusalindicator.
		/// </summary>
		internal System.Boolean _racenationaloriginrefusalindicator;
		/// <summary>
		/// Gets and sets the RaceNationalOriginRefusalIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean RaceNationalOriginRefusalIndicator
		{
			get
			{
				return _racenationaloriginrefusalindicator;
			}
			set
			{
				_racenationaloriginrefusalindicator = value;
				_racenationaloriginrefusalindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _racenationalorigintype_isnull = true;
		/// <summary>
		/// Member that stores the value for the racenationalorigintype.
		/// </summary>
		internal System.Int16 _racenationalorigintype;
		/// <summary>
		/// Gets and sets the RaceNationalOriginType value of the class instance.
		/// </summary>
		public virtual System.Int16 RaceNationalOriginType
		{
			get
			{
				return _racenationalorigintype;
			}
			set
			{
				_racenationalorigintype = value;
				_racenationalorigintype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RaceNationalOriginType value to see if it was set to null.
		/// </summary>
		public System.Boolean RaceNationalOriginTypeIsNull
		{
			get
			{
				return _racenationalorigintype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hmdaethnicitytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the hmdaethnicitytype.
		/// </summary>
		internal System.Int16 _hmdaethnicitytype;
		/// <summary>
		/// Gets and sets the HMDAEthnicityType value of the class instance.
		/// </summary>
		public virtual System.Int16 HMDAEthnicityType
		{
			get
			{
				return _hmdaethnicitytype;
			}
			set
			{
				_hmdaethnicitytype = value;
				_hmdaethnicitytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HMDAEthnicityType value to see if it was set to null.
		/// </summary>
		public System.Boolean HMDAEthnicityTypeIsNull
		{
			get
			{
				return _hmdaethnicitytype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the GovernmentMonitoringBase.
		/// </summary>
		internal static GovernmentMonitoringService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(GovernmentMonitoringService)) as GovernmentMonitoringService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of GovernmentMonitoringBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the GenderType value as null.
		/// </summary>
		public virtual void SetGenderTypeNull()
		{
			_gendertype = 0;
			_gendertype_isnull = true;
		}


		/// <summary>
		/// Marks the OtherRaceNationalOriginDescription value as null.
		/// </summary>
		public virtual void SetOtherRaceNationalOriginDescriptionNull()
		{
			_otherracenationalorigindescription = null;
		}


		/// <summary>
		/// Marks the RaceNationalOriginType value as null.
		/// </summary>
		public virtual void SetRaceNationalOriginTypeNull()
		{
			_racenationalorigintype = 0;
			_racenationalorigintype_isnull = true;
		}


		/// <summary>
		/// Marks the HMDAEthnicityType value as null.
		/// </summary>
		public virtual void SetHMDAEthnicityTypeNull()
		{
			_hmdaethnicitytype = 0;
			_hmdaethnicitytype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref GovernmentMonitoringBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the GenderType data to the class member
			_gendertype = data._gendertype;
			_gendertype_isnull = data._gendertype_isnull;
			// assigns the OtherRaceNationalOriginDescription data to the class member
			_otherracenationalorigindescription = data._otherracenationalorigindescription;
			// assigns the RaceNationalOriginRefusalIndicator data to the class member
			_racenationaloriginrefusalindicator = data._racenationaloriginrefusalindicator;
			_racenationaloriginrefusalindicator_assigned = data._racenationaloriginrefusalindicator_assigned;
			// assigns the RaceNationalOriginType data to the class member
			_racenationalorigintype = data._racenationalorigintype;
			_racenationalorigintype_isnull = data._racenationalorigintype_isnull;
			// assigns the HMDAEthnicityType data to the class member
			_hmdaethnicitytype = data._hmdaethnicitytype;
			_hmdaethnicitytype_isnull = data._hmdaethnicitytype_isnull;


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
			// assigns the GenderType data to the class member
			if (data["GenderType"] == System.DBNull.Value)
				SetGenderTypeNull();
			else
			{
				_gendertype = Convert.ToInt16(data["GenderType"]);
				_gendertype_isnull = false;
			}
			// assigns the OtherRaceNationalOriginDescription data to the class member
			if (data["OtherRaceNationalOriginDescription"] == System.DBNull.Value)
				SetOtherRaceNationalOriginDescriptionNull();
			else
			{
				_otherracenationalorigindescription = Convert.ToString(data["OtherRaceNationalOriginDescription"]);
			}
			// assigns the RaceNationalOriginRefusalIndicator data to the class member
			_racenationaloriginrefusalindicator = Convert.ToBoolean(data["RaceNationalOriginRefusalIndicator"]);
			_racenationaloriginrefusalindicator_assigned = true;
			// assigns the RaceNationalOriginType data to the class member
			if (data["RaceNationalOriginType"] == System.DBNull.Value)
				SetRaceNationalOriginTypeNull();
			else
			{
				_racenationalorigintype = Convert.ToInt16(data["RaceNationalOriginType"]);
				_racenationalorigintype_isnull = false;
			}
			// assigns the HMDAEthnicityType data to the class member
			if (data["HMDAEthnicityType"] == System.DBNull.Value)
				SetHMDAEthnicityTypeNull();
			else
			{
				_hmdaethnicitytype = Convert.ToInt16(data["HMDAEthnicityType"]);
				_hmdaethnicitytype_isnull = false;
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
			// assigns the GenderType data to the class member
			if (data["GenderType"] == System.DBNull.Value)
				SetGenderTypeNull();
			else
			{
				_gendertype = Convert.ToInt16(data["GenderType"]);
				_gendertype_isnull = false;
			}
			// assigns the OtherRaceNationalOriginDescription data to the class member
			if (data["OtherRaceNationalOriginDescription"] == System.DBNull.Value)
				SetOtherRaceNationalOriginDescriptionNull();
			else
			{
				_otherracenationalorigindescription = Convert.ToString(data["OtherRaceNationalOriginDescription"]);
			}
			// assigns the RaceNationalOriginRefusalIndicator data to the class member
			_racenationaloriginrefusalindicator = Convert.ToBoolean(data["RaceNationalOriginRefusalIndicator"]);
			_racenationaloriginrefusalindicator_assigned = true;
			// assigns the RaceNationalOriginType data to the class member
			if (data["RaceNationalOriginType"] == System.DBNull.Value)
				SetRaceNationalOriginTypeNull();
			else
			{
				_racenationalorigintype = Convert.ToInt16(data["RaceNationalOriginType"]);
				_racenationalorigintype_isnull = false;
			}
			// assigns the HMDAEthnicityType data to the class member
			if (data["HMDAEthnicityType"] == System.DBNull.Value)
				SetHMDAEthnicityTypeNull();
			else
			{
				_hmdaethnicitytype = Convert.ToInt16(data["HMDAEthnicityType"]);
				_hmdaethnicitytype_isnull = false;
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
			GovernmentMonitoringBase.ServiceObject.Persist(this as GovernmentMonitoring, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the GOVERNMENT_MONITORING object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			GovernmentMonitoringBase.ServiceObject.Delete(this as GovernmentMonitoring);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the HMDA_RACE relationship.
		/// </summary>
		public HMDARaces GetHMDARaces()
		{
			HMDARaces hmdaraces = new HMDARaces();


			HMDARaceBase.ServiceObject.FillByGovernmentMonitoring(hmdaraces, _borrowerid);
			return hmdaraces;
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
		/// Gets the single object for the GenderType relationship.
		/// </summary>
		public GenderType GetGenderType()
		{
			if (_gendertype_isnull)
				return null;
			else
				return new GenderType(_gendertype);
		}


		/// <summary>
		/// Gets the single object for the HMDAEthnicityType relationship.
		/// </summary>
		public HMDAEthnicityType GetHMDAEthnicityType()
		{
			if (_hmdaethnicitytype_isnull)
				return null;
			else
				return new HMDAEthnicityType(_hmdaethnicitytype);
		}


		/// <summary>
		/// Gets the single object for the RaceNationalOriginType relationship.
		/// </summary>
		public RaceNationalOriginType GetRaceNationalOriginType()
		{
			if (_racenationalorigintype_isnull)
				return null;
			else
				return new RaceNationalOriginType(_racenationalorigintype);
		}


		/// <summary>
		/// Gets all persisted GovernmentMonitoring objects
		/// </summary>
		public static GovernmentMonitoringCollection GetAll()
		{
			// have the service object get the objects
			return GovernmentMonitoringBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
