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
	/// A class that represents an abstract entity for table 'ALIAS'
	/// </summary>
	[Serializable]
	public abstract class AliasBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AliasBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Alias)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public AliasBase(System.Int64 id)
		{
			// Fill this instance.
			AliasBase.ServiceObject.Fill(this as Alias, id);
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
		/// Member that stores the value for the firstname.
		/// </summary>
		internal System.String _firstname;
		/// <summary>
		/// Gets and sets the FirstName value of the class instance.
		/// </summary>
		public virtual System.String FirstName
		{
			get
			{
				return _firstname;
			}
			set
			{
				_firstname = value;
			}
		}


		/// <summary>
		/// Checks the FirstName value to see if it was set to null.
		/// </summary>
		public System.Boolean FirstNameIsNull
		{
			get
			{
				return (_firstname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the lastname.
		/// </summary>
		internal System.String _lastname;
		/// <summary>
		/// Gets and sets the LastName value of the class instance.
		/// </summary>
		public virtual System.String LastName
		{
			get
			{
				return _lastname;
			}
			set
			{
				_lastname = value;
			}
		}


		/// <summary>
		/// Checks the LastName value to see if it was set to null.
		/// </summary>
		public System.Boolean LastNameIsNull
		{
			get
			{
				return (_lastname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the middlename.
		/// </summary>
		internal System.String _middlename;
		/// <summary>
		/// Gets and sets the MiddleName value of the class instance.
		/// </summary>
		public virtual System.String MiddleName
		{
			get
			{
				return _middlename;
			}
			set
			{
				_middlename = value;
			}
		}


		/// <summary>
		/// Checks the MiddleName value to see if it was set to null.
		/// </summary>
		public System.Boolean MiddleNameIsNull
		{
			get
			{
				return (_middlename == null);
			}
		}


		/// <summary>
		/// Gets the service object for the AliasBase.
		/// </summary>
		internal static AliasService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(AliasService)) as AliasService;
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
		/// Marks the FirstName value as null.
		/// </summary>
		public virtual void SetFirstNameNull()
		{
			_firstname = null;
		}


		/// <summary>
		/// Marks the LastName value as null.
		/// </summary>
		public virtual void SetLastNameNull()
		{
			_lastname = null;
		}


		/// <summary>
		/// Marks the MiddleName value as null.
		/// </summary>
		public virtual void SetMiddleNameNull()
		{
			_middlename = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref AliasBase data)
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
			// assigns the FirstName data to the class member
			_firstname = data._firstname;
			// assigns the LastName data to the class member
			_lastname = data._lastname;
			// assigns the MiddleName data to the class member
			_middlename = data._middlename;


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
			// assigns the FirstName data to the class member
			if (data["FirstName"] == System.DBNull.Value)
				SetFirstNameNull();
			else
			{
				_firstname = Convert.ToString(data["FirstName"]);
			}
			// assigns the LastName data to the class member
			if (data["LastName"] == System.DBNull.Value)
				SetLastNameNull();
			else
			{
				_lastname = Convert.ToString(data["LastName"]);
			}
			// assigns the MiddleName data to the class member
			if (data["MiddleName"] == System.DBNull.Value)
				SetMiddleNameNull();
			else
			{
				_middlename = Convert.ToString(data["MiddleName"]);
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
			// assigns the FirstName data to the class member
			if (data["FirstName"] == System.DBNull.Value)
				SetFirstNameNull();
			else
			{
				_firstname = Convert.ToString(data["FirstName"]);
			}
			// assigns the LastName data to the class member
			if (data["LastName"] == System.DBNull.Value)
				SetLastNameNull();
			else
			{
				_lastname = Convert.ToString(data["LastName"]);
			}
			// assigns the MiddleName data to the class member
			if (data["MiddleName"] == System.DBNull.Value)
				SetMiddleNameNull();
			else
			{
				_middlename = Convert.ToString(data["MiddleName"]);
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
			AliasBase.ServiceObject.Persist(this as Alias, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the ALIAS object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			AliasBase.ServiceObject.Delete(this as Alias);


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
		/// Gets all persisted Alias objects
		/// </summary>
		public static Aliases GetAll()
		{
			// have the service object get the objects
			return AliasBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
