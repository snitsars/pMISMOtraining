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
	/// A class that represents an abstract entity for table 'VALUATION'
	/// </summary>
	[Serializable]
	public abstract class ValuationBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ValuationBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Valuation)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ValuationBase(System.Int64 id)
		{
			// Fill this instance.
			ValuationBase.ServiceObject.Fill(this as Valuation, id);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _appraiserid_isnull = true;
		/// <summary>
		/// Member that stores the value for the appraiserid.
		/// </summary>
		internal System.Int32 _appraiserid;
		/// <summary>
		/// Gets and sets the AppraiserId value of the class instance.
		/// </summary>
		public virtual System.Int32 AppraiserId
		{
			get
			{
				return _appraiserid;
			}
			set
			{
				_appraiserid = value;
				_appraiserid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AppraiserId value to see if it was set to null.
		/// </summary>
		public System.Boolean AppraiserIdIsNull
		{
			get
			{
				return _appraiserid_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the methodtypeotherdescription.
		/// </summary>
		internal System.String _methodtypeotherdescription;
		/// <summary>
		/// Gets and sets the MethodTypeOtherDescription value of the class instance.
		/// </summary>
		public virtual System.String MethodTypeOtherDescription
		{
			get
			{
				return _methodtypeotherdescription;
			}
			set
			{
				_methodtypeotherdescription = value;
			}
		}


		/// <summary>
		/// Checks the MethodTypeOtherDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean MethodTypeOtherDescriptionIsNull
		{
			get
			{
				return (_methodtypeotherdescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _methodtype_isnull = true;
		/// <summary>
		/// Member that stores the value for the methodtype.
		/// </summary>
		internal System.Int16 _methodtype;
		/// <summary>
		/// Gets and sets the MethodType value of the class instance.
		/// </summary>
		public virtual System.Int16 MethodType
		{
			get
			{
				return _methodtype;
			}
			set
			{
				_methodtype = value;
				_methodtype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MethodType value to see if it was set to null.
		/// </summary>
		public System.Boolean MethodTypeIsNull
		{
			get
			{
				return _methodtype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the ValuationBase.
		/// </summary>
		internal static ValuationService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(ValuationService)) as ValuationService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of ValuationBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the AppraiserId value as null.
		/// </summary>
		public virtual void SetAppraiserIdNull()
		{
			_appraiserid = 0;
			_appraiserid_isnull = true;
		}


		/// <summary>
		/// Marks the MethodTypeOtherDescription value as null.
		/// </summary>
		public virtual void SetMethodTypeOtherDescriptionNull()
		{
			_methodtypeotherdescription = null;
		}


		/// <summary>
		/// Marks the MethodType value as null.
		/// </summary>
		public virtual void SetMethodTypeNull()
		{
			_methodtype = 0;
			_methodtype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref ValuationBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the AppraiserId data to the class member
			_appraiserid = data._appraiserid;
			_appraiserid_isnull = data._appraiserid_isnull;
			// assigns the MethodTypeOtherDescription data to the class member
			_methodtypeotherdescription = data._methodtypeotherdescription;
			// assigns the MethodType data to the class member
			_methodtype = data._methodtype;
			_methodtype_isnull = data._methodtype_isnull;


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
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the AppraiserId data to the class member
			if (data["AppraiserId"] == System.DBNull.Value)
				SetAppraiserIdNull();
			else
			{
				_appraiserid = Convert.ToInt32(data["AppraiserId"]);
				_appraiserid_isnull = false;
			}
			// assigns the MethodTypeOtherDescription data to the class member
			if (data["MethodTypeOtherDescription"] == System.DBNull.Value)
				SetMethodTypeOtherDescriptionNull();
			else
			{
				_methodtypeotherdescription = Convert.ToString(data["MethodTypeOtherDescription"]);
			}
			// assigns the MethodType data to the class member
			if (data["MethodType"] == System.DBNull.Value)
				SetMethodTypeNull();
			else
			{
				_methodtype = Convert.ToInt16(data["MethodType"]);
				_methodtype_isnull = false;
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
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the AppraiserId data to the class member
			if (data["AppraiserId"] == System.DBNull.Value)
				SetAppraiserIdNull();
			else
			{
				_appraiserid = Convert.ToInt32(data["AppraiserId"]);
				_appraiserid_isnull = false;
			}
			// assigns the MethodTypeOtherDescription data to the class member
			if (data["MethodTypeOtherDescription"] == System.DBNull.Value)
				SetMethodTypeOtherDescriptionNull();
			else
			{
				_methodtypeotherdescription = Convert.ToString(data["MethodTypeOtherDescription"]);
			}
			// assigns the MethodType data to the class member
			if (data["MethodType"] == System.DBNull.Value)
				SetMethodTypeNull();
			else
			{
				_methodtype = Convert.ToInt16(data["MethodType"]);
				_methodtype_isnull = false;
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
			ValuationBase.ServiceObject.Persist(this as Valuation, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the VALUATION object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			ValuationBase.ServiceObject.Delete(this as Valuation);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the APPRAISER relationship.
		/// </summary>
		public Appraiser GetAppraiser()
		{
			if (_appraiserid_isnull)
				return null;
			else
				return new Appraiser(_appraiserid);
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
		/// Gets the single object for the PropertyValuationMethodType relationship.
		/// </summary>
		public PropertyValuationMethodType GetPropertyValuationMethodType()
		{
			if (_methodtype_isnull)
				return null;
			else
				return new PropertyValuationMethodType(_methodtype);
		}


		/// <summary>
		/// Gets all persisted Valuation objects
		/// </summary>
		public static Valuations GetAll()
		{
			// have the service object get the objects
			return ValuationBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
