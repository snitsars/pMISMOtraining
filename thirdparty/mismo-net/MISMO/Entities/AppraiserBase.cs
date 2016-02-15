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
	/// A class that represents an abstract entity for table 'APPRAISER'
	/// </summary>
	[Serializable]
	public abstract class AppraiserBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AppraiserBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Appraiser)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public AppraiserBase(System.Int32 id)
		{
			// Fill this instance.
			AppraiserBase.ServiceObject.Fill(this as Appraiser, id);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the value for the id.
		/// </summary>
		internal System.Int32 _id;
		/// <summary>
		/// Gets the Id value of the class instance.
		/// </summary>
		public virtual System.Int32 Id
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
		/// Member that stores the value for the companyname.
		/// </summary>
		internal System.String _companyname;
		/// <summary>
		/// Gets and sets the CompanyName value of the class instance.
		/// </summary>
		public virtual System.String CompanyName
		{
			get
			{
				return _companyname;
			}
			set
			{
				_companyname = value;
			}
		}


		/// <summary>
		/// Checks the CompanyName value to see if it was set to null.
		/// </summary>
		public System.Boolean CompanyNameIsNull
		{
			get
			{
				return (_companyname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the licenseidentifier.
		/// </summary>
		internal System.String _licenseidentifier;
		/// <summary>
		/// Gets and sets the LicenseIdentifier value of the class instance.
		/// </summary>
		public virtual System.String LicenseIdentifier
		{
			get
			{
				return _licenseidentifier;
			}
			set
			{
				_licenseidentifier = value;
			}
		}


		/// <summary>
		/// Checks the LicenseIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean LicenseIdentifierIsNull
		{
			get
			{
				return (_licenseidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the licensestate.
		/// </summary>
		internal System.String _licensestate;
		/// <summary>
		/// Gets and sets the LicenseState value of the class instance.
		/// </summary>
		public virtual System.String LicenseState
		{
			get
			{
				return _licensestate;
			}
			set
			{
				_licensestate = value;
			}
		}


		/// <summary>
		/// Checks the LicenseState value to see if it was set to null.
		/// </summary>
		public System.Boolean LicenseStateIsNull
		{
			get
			{
				return (_licensestate == null);
			}
		}


		/// <summary>
		/// Gets the service object for the AppraiserBase.
		/// </summary>
		internal static AppraiserService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(AppraiserService)) as AppraiserService;
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
		/// Marks the Name value as null.
		/// </summary>
		public virtual void SetNameNull()
		{
			_name = null;
		}


		/// <summary>
		/// Marks the CompanyName value as null.
		/// </summary>
		public virtual void SetCompanyNameNull()
		{
			_companyname = null;
		}


		/// <summary>
		/// Marks the LicenseIdentifier value as null.
		/// </summary>
		public virtual void SetLicenseIdentifierNull()
		{
			_licenseidentifier = null;
		}


		/// <summary>
		/// Marks the LicenseState value as null.
		/// </summary>
		public virtual void SetLicenseStateNull()
		{
			_licensestate = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref AppraiserBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the Name data to the class member
			_name = data._name;
			// assigns the CompanyName data to the class member
			_companyname = data._companyname;
			// assigns the LicenseIdentifier data to the class member
			_licenseidentifier = data._licenseidentifier;
			// assigns the LicenseState data to the class member
			_licensestate = data._licensestate;


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
			_id = Convert.ToInt32(data["Id"]);
			// assigns the Name data to the class member
			if (data["Name"] == System.DBNull.Value)
				SetNameNull();
			else
			{
				_name = Convert.ToString(data["Name"]);
			}
			// assigns the CompanyName data to the class member
			if (data["CompanyName"] == System.DBNull.Value)
				SetCompanyNameNull();
			else
			{
				_companyname = Convert.ToString(data["CompanyName"]);
			}
			// assigns the LicenseIdentifier data to the class member
			if (data["LicenseIdentifier"] == System.DBNull.Value)
				SetLicenseIdentifierNull();
			else
			{
				_licenseidentifier = Convert.ToString(data["LicenseIdentifier"]);
			}
			// assigns the LicenseState data to the class member
			if (data["LicenseState"] == System.DBNull.Value)
				SetLicenseStateNull();
			else
			{
				_licensestate = Convert.ToString(data["LicenseState"]);
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
			_id = Convert.ToInt32(data["Id"]);
			// assigns the Name data to the class member
			if (data["Name"] == System.DBNull.Value)
				SetNameNull();
			else
			{
				_name = Convert.ToString(data["Name"]);
			}
			// assigns the CompanyName data to the class member
			if (data["CompanyName"] == System.DBNull.Value)
				SetCompanyNameNull();
			else
			{
				_companyname = Convert.ToString(data["CompanyName"]);
			}
			// assigns the LicenseIdentifier data to the class member
			if (data["LicenseIdentifier"] == System.DBNull.Value)
				SetLicenseIdentifierNull();
			else
			{
				_licenseidentifier = Convert.ToString(data["LicenseIdentifier"]);
			}
			// assigns the LicenseState data to the class member
			if (data["LicenseState"] == System.DBNull.Value)
				SetLicenseStateNull();
			else
			{
				_licensestate = Convert.ToString(data["LicenseState"]);
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
			AppraiserBase.ServiceObject.Persist(this as Appraiser, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the APPRAISER object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			AppraiserBase.ServiceObject.Delete(this as Appraiser);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the VALUATION relationship.
		/// </summary>
		public Valuations GetValuations()
		{
			Valuations valuations = new Valuations();


			ValuationBase.ServiceObject.FillByAppraiser(valuations, _id);
			return valuations;
		}


		/// <summary>
		/// Gets all persisted Appraiser objects
		/// </summary>
		public static Appraisers GetAll()
		{
			// have the service object get the objects
			return AppraiserBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
