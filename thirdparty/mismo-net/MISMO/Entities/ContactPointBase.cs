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
	/// A class that represents an abstract entity for table 'CONTACT_POINT'
	/// </summary>
	[Serializable]
	public abstract class ContactPointBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ContactPointBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.ContactPoint)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ContactPointBase(System.Int64 id)
		{
			// Fill this instance.
			ContactPointBase.ServiceObject.Fill(this as ContactPoint, id);
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
		/// Member that stores the value for the typeotherdescription.
		/// </summary>
		internal System.String _typeotherdescription;
		/// <summary>
		/// Gets and sets the TypeOtherDescription value of the class instance.
		/// </summary>
		public virtual System.String TypeOtherDescription
		{
			get
			{
				return _typeotherdescription;
			}
			set
			{
				_typeotherdescription = value;
			}
		}


		/// <summary>
		/// Checks the TypeOtherDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean TypeOtherDescriptionIsNull
		{
			get
			{
				return (_typeotherdescription == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the value.
		/// </summary>
		internal System.String _value;
		/// <summary>
		/// Gets and sets the Value value of the class instance.
		/// </summary>
		public virtual System.String Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
			}
		}


		/// <summary>
		/// Checks the Value value to see if it was set to null.
		/// </summary>
		public System.Boolean ValueIsNull
		{
			get
			{
				return (_value == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _preferenceindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the preferenceindicator.
		/// </summary>
		internal System.Boolean _preferenceindicator;
		/// <summary>
		/// Gets and sets the PreferenceIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PreferenceIndicator
		{
			get
			{
				return _preferenceindicator;
			}
			set
			{
				_preferenceindicator = value;
				_preferenceindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _roletype_isnull = true;
		/// <summary>
		/// Member that stores the value for the roletype.
		/// </summary>
		internal System.Int16 _roletype;
		/// <summary>
		/// Gets and sets the RoleType value of the class instance.
		/// </summary>
		public virtual System.Int16 RoleType
		{
			get
			{
				return _roletype;
			}
			set
			{
				_roletype = value;
				_roletype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RoleType value to see if it was set to null.
		/// </summary>
		public System.Boolean RoleTypeIsNull
		{
			get
			{
				return _roletype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _type_isnull = true;
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
				_type_isnull = false;
			}
		}


		/// <summary>
		/// Checks the Type value to see if it was set to null.
		/// </summary>
		public System.Boolean TypeIsNull
		{
			get
			{
				return _type_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the ContactPointBase.
		/// </summary>
		internal static ContactPointService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(ContactPointService)) as ContactPointService;
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
		/// Marks the TypeOtherDescription value as null.
		/// </summary>
		public virtual void SetTypeOtherDescriptionNull()
		{
			_typeotherdescription = null;
		}


		/// <summary>
		/// Marks the Value value as null.
		/// </summary>
		public virtual void SetValueNull()
		{
			_value = null;
		}


		/// <summary>
		/// Marks the RoleType value as null.
		/// </summary>
		public virtual void SetRoleTypeNull()
		{
			_roletype = 0;
			_roletype_isnull = true;
		}


		/// <summary>
		/// Marks the Type value as null.
		/// </summary>
		public virtual void SetTypeNull()
		{
			_type = 0;
			_type_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref ContactPointBase data)
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
			// assigns the TypeOtherDescription data to the class member
			_typeotherdescription = data._typeotherdescription;
			// assigns the Value data to the class member
			_value = data._value;
			// assigns the PreferenceIndicator data to the class member
			_preferenceindicator = data._preferenceindicator;
			_preferenceindicator_assigned = data._preferenceindicator_assigned;
			// assigns the RoleType data to the class member
			_roletype = data._roletype;
			_roletype_isnull = data._roletype_isnull;
			// assigns the Type data to the class member
			_type = data._type;
			_type_isnull = data._type_isnull;


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
			// assigns the TypeOtherDescription data to the class member
			if (data["TypeOtherDescription"] == System.DBNull.Value)
				SetTypeOtherDescriptionNull();
			else
			{
				_typeotherdescription = Convert.ToString(data["TypeOtherDescription"]);
			}
			// assigns the Value data to the class member
			if (data["Value"] == System.DBNull.Value)
				SetValueNull();
			else
			{
				_value = Convert.ToString(data["Value"]);
			}
			// assigns the PreferenceIndicator data to the class member
			_preferenceindicator = Convert.ToBoolean(data["PreferenceIndicator"]);
			_preferenceindicator_assigned = true;
			// assigns the RoleType data to the class member
			if (data["RoleType"] == System.DBNull.Value)
				SetRoleTypeNull();
			else
			{
				_roletype = Convert.ToInt16(data["RoleType"]);
				_roletype_isnull = false;
			}
			// assigns the Type data to the class member
			if (data["Type"] == System.DBNull.Value)
				SetTypeNull();
			else
			{
				_type = Convert.ToInt16(data["Type"]);
				_type_isnull = false;
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
			// assigns the TypeOtherDescription data to the class member
			if (data["TypeOtherDescription"] == System.DBNull.Value)
				SetTypeOtherDescriptionNull();
			else
			{
				_typeotherdescription = Convert.ToString(data["TypeOtherDescription"]);
			}
			// assigns the Value data to the class member
			if (data["Value"] == System.DBNull.Value)
				SetValueNull();
			else
			{
				_value = Convert.ToString(data["Value"]);
			}
			// assigns the PreferenceIndicator data to the class member
			_preferenceindicator = Convert.ToBoolean(data["PreferenceIndicator"]);
			_preferenceindicator_assigned = true;
			// assigns the RoleType data to the class member
			if (data["RoleType"] == System.DBNull.Value)
				SetRoleTypeNull();
			else
			{
				_roletype = Convert.ToInt16(data["RoleType"]);
				_roletype_isnull = false;
			}
			// assigns the Type data to the class member
			if (data["Type"] == System.DBNull.Value)
				SetTypeNull();
			else
			{
				_type = Convert.ToInt16(data["Type"]);
				_type_isnull = false;
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
			ContactPointBase.ServiceObject.Persist(this as ContactPoint, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the CONTACT_POINT object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			ContactPointBase.ServiceObject.Delete(this as ContactPoint);


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
		/// Gets the single object for the ContactPointRoleType relationship.
		/// </summary>
		public ContactPointRoleType GetContactPointRoleType()
		{
			if (_roletype_isnull)
				return null;
			else
				return new ContactPointRoleType(_roletype);
		}


		/// <summary>
		/// Gets the single object for the ContactPointType relationship.
		/// </summary>
		public ContactPointType GetContactPointType()
		{
			if (_type_isnull)
				return null;
			else
				return new ContactPointType(_type);
		}


		/// <summary>
		/// Gets all persisted ContactPoint objects
		/// </summary>
		public static ContactPointCollection GetAll()
		{
			// have the service object get the objects
			return ContactPointBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
