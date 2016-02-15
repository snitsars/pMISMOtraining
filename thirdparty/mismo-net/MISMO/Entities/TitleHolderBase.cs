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
	/// A class that represents an abstract entity for table 'TITLE_HOLDER'
	/// </summary>
	[Serializable]
	public abstract class TitleHolderBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TitleHolderBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.TitleHolder)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public TitleHolderBase(System.Int64 id)
		{
			// Fill this instance.
			TitleHolderBase.ServiceObject.Fill(this as TitleHolder, id);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _landtrusttype_isnull = true;
		/// <summary>
		/// Member that stores the value for the landtrusttype.
		/// </summary>
		internal System.Int16 _landtrusttype;
		/// <summary>
		/// Gets and sets the LandTrustType value of the class instance.
		/// </summary>
		public virtual System.Int16 LandTrustType
		{
			get
			{
				return _landtrusttype;
			}
			set
			{
				_landtrusttype = value;
				_landtrusttype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LandTrustType value to see if it was set to null.
		/// </summary>
		public System.Boolean LandTrustTypeIsNull
		{
			get
			{
				return _landtrusttype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the TitleHolderBase.
		/// </summary>
		internal static TitleHolderService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(TitleHolderService)) as TitleHolderService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of TitleHolderBase. The value has not been explicitly assigned.", exceptions);


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
		/// Marks the LandTrustType value as null.
		/// </summary>
		public virtual void SetLandTrustTypeNull()
		{
			_landtrusttype = 0;
			_landtrusttype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref TitleHolderBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the Id data to the class member
			_id = data._id;
			// assigns the Name data to the class member
			_name = data._name;
			// assigns the LandTrustType data to the class member
			_landtrusttype = data._landtrusttype;
			_landtrusttype_isnull = data._landtrusttype_isnull;


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
			// assigns the Id data to the class member
			_id = Convert.ToInt64(data["Id"]);
			// assigns the Name data to the class member
			if (data["Name"] == System.DBNull.Value)
				SetNameNull();
			else
			{
				_name = Convert.ToString(data["Name"]);
			}
			// assigns the LandTrustType data to the class member
			if (data["LandTrustType"] == System.DBNull.Value)
				SetLandTrustTypeNull();
			else
			{
				_landtrusttype = Convert.ToInt16(data["LandTrustType"]);
				_landtrusttype_isnull = false;
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
			// assigns the Id data to the class member
			_id = Convert.ToInt64(data["Id"]);
			// assigns the Name data to the class member
			if (data["Name"] == System.DBNull.Value)
				SetNameNull();
			else
			{
				_name = Convert.ToString(data["Name"]);
			}
			// assigns the LandTrustType data to the class member
			if (data["LandTrustType"] == System.DBNull.Value)
				SetLandTrustTypeNull();
			else
			{
				_landtrusttype = Convert.ToInt16(data["LandTrustType"]);
				_landtrusttype_isnull = false;
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
			TitleHolderBase.ServiceObject.Persist(this as TitleHolder, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the TITLE_HOLDER object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			TitleHolderBase.ServiceObject.Delete(this as TitleHolder);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the LandTrustType relationship.
		/// </summary>
		public LandTrustType GetLandTrustType()
		{
			if (_landtrusttype_isnull)
				return null;
			else
				return new LandTrustType(_landtrusttype);
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
		/// Gets all persisted TitleHolder objects
		/// </summary>
		public static TitleHolders GetAll()
		{
			// have the service object get the objects
			return TitleHolderBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
