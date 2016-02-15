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
	/// A class that represents an abstract entity for table 'INTERVIEWER_INFORMATION'
	/// </summary>
	[Serializable]
	public abstract class InterviewerInformationBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public InterviewerInformationBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.InterviewerInformation)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public InterviewerInformationBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			InterviewerInformationBase.ServiceObject.Fill(this as InterviewerInformation, loanApplicationId);
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
		/// Member that stores the value for the interviewersemployerstreetaddress.
		/// </summary>
		internal System.String _interviewersemployerstreetaddress;
		/// <summary>
		/// Gets and sets the InterviewersEmployerStreetAddress value of the class instance.
		/// </summary>
		public virtual System.String InterviewersEmployerStreetAddress
		{
			get
			{
				return _interviewersemployerstreetaddress;
			}
			set
			{
				_interviewersemployerstreetaddress = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersEmployerStreetAddress value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersEmployerStreetAddressIsNull
		{
			get
			{
				return (_interviewersemployerstreetaddress == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the interviewersemployercity.
		/// </summary>
		internal System.String _interviewersemployercity;
		/// <summary>
		/// Gets and sets the InterviewersEmployerCity value of the class instance.
		/// </summary>
		public virtual System.String InterviewersEmployerCity
		{
			get
			{
				return _interviewersemployercity;
			}
			set
			{
				_interviewersemployercity = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersEmployerCity value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersEmployerCityIsNull
		{
			get
			{
				return (_interviewersemployercity == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the interviewersemployerstate.
		/// </summary>
		internal System.String _interviewersemployerstate;
		/// <summary>
		/// Gets and sets the InterviewersEmployerState value of the class instance.
		/// </summary>
		public virtual System.String InterviewersEmployerState
		{
			get
			{
				return _interviewersemployerstate;
			}
			set
			{
				_interviewersemployerstate = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersEmployerState value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersEmployerStateIsNull
		{
			get
			{
				return (_interviewersemployerstate == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the interviewersemployerpostalcode.
		/// </summary>
		internal System.String _interviewersemployerpostalcode;
		/// <summary>
		/// Gets and sets the InterviewersEmployerPostalCode value of the class instance.
		/// </summary>
		public virtual System.String InterviewersEmployerPostalCode
		{
			get
			{
				return _interviewersemployerpostalcode;
			}
			set
			{
				_interviewersemployerpostalcode = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersEmployerPostalCode value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersEmployerPostalCodeIsNull
		{
			get
			{
				return (_interviewersemployerpostalcode == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the interviewerstelephonenumber.
		/// </summary>
		internal System.String _interviewerstelephonenumber;
		/// <summary>
		/// Gets and sets the InterviewersTelephoneNumber value of the class instance.
		/// </summary>
		public virtual System.String InterviewersTelephoneNumber
		{
			get
			{
				return _interviewerstelephonenumber;
			}
			set
			{
				_interviewerstelephonenumber = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersTelephoneNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersTelephoneNumberIsNull
		{
			get
			{
				return (_interviewerstelephonenumber == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _applicationtakenmethodtype_isnull = true;
		/// <summary>
		/// Member that stores the value for the applicationtakenmethodtype.
		/// </summary>
		internal System.Int16 _applicationtakenmethodtype;
		/// <summary>
		/// Gets and sets the ApplicationTakenMethodType value of the class instance.
		/// </summary>
		public virtual System.Int16 ApplicationTakenMethodType
		{
			get
			{
				return _applicationtakenmethodtype;
			}
			set
			{
				_applicationtakenmethodtype = value;
				_applicationtakenmethodtype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ApplicationTakenMethodType value to see if it was set to null.
		/// </summary>
		public System.Boolean ApplicationTakenMethodTypeIsNull
		{
			get
			{
				return _applicationtakenmethodtype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _interviewerapplicationsigneddate_isnull = true;
		/// <summary>
		/// Member that stores the value for the interviewerapplicationsigneddate.
		/// </summary>
		internal System.DateTime _interviewerapplicationsigneddate;
		/// <summary>
		/// Gets and sets the InterviewerApplicationSignedDate value of the class instance.
		/// </summary>
		public virtual System.DateTime InterviewerApplicationSignedDate
		{
			get
			{
				return _interviewerapplicationsigneddate;
			}
			set
			{
				_interviewerapplicationsigneddate = value;
				_interviewerapplicationsigneddate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the InterviewerApplicationSignedDate value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewerApplicationSignedDateIsNull
		{
			get
			{
				return _interviewerapplicationsigneddate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the interviewersemployername.
		/// </summary>
		internal System.String _interviewersemployername;
		/// <summary>
		/// Gets and sets the InterviewersEmployerName value of the class instance.
		/// </summary>
		public virtual System.String InterviewersEmployerName
		{
			get
			{
				return _interviewersemployername;
			}
			set
			{
				_interviewersemployername = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersEmployerName value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersEmployerNameIsNull
		{
			get
			{
				return (_interviewersemployername == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the interviewersname.
		/// </summary>
		internal System.String _interviewersname;
		/// <summary>
		/// Gets and sets the InterviewersName value of the class instance.
		/// </summary>
		public virtual System.String InterviewersName
		{
			get
			{
				return _interviewersname;
			}
			set
			{
				_interviewersname = value;
			}
		}


		/// <summary>
		/// Checks the InterviewersName value to see if it was set to null.
		/// </summary>
		public System.Boolean InterviewersNameIsNull
		{
			get
			{
				return (_interviewersname == null);
			}
		}


		/// <summary>
		/// Gets the service object for the InterviewerInformationBase.
		/// </summary>
		internal static InterviewerInformationService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(InterviewerInformationService)) as InterviewerInformationService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of InterviewerInformationBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the InterviewersEmployerStreetAddress value as null.
		/// </summary>
		public virtual void SetInterviewersEmployerStreetAddressNull()
		{
			_interviewersemployerstreetaddress = null;
		}


		/// <summary>
		/// Marks the InterviewersEmployerCity value as null.
		/// </summary>
		public virtual void SetInterviewersEmployerCityNull()
		{
			_interviewersemployercity = null;
		}


		/// <summary>
		/// Marks the InterviewersEmployerState value as null.
		/// </summary>
		public virtual void SetInterviewersEmployerStateNull()
		{
			_interviewersemployerstate = null;
		}


		/// <summary>
		/// Marks the InterviewersEmployerPostalCode value as null.
		/// </summary>
		public virtual void SetInterviewersEmployerPostalCodeNull()
		{
			_interviewersemployerpostalcode = null;
		}


		/// <summary>
		/// Marks the InterviewersTelephoneNumber value as null.
		/// </summary>
		public virtual void SetInterviewersTelephoneNumberNull()
		{
			_interviewerstelephonenumber = null;
		}


		/// <summary>
		/// Marks the ApplicationTakenMethodType value as null.
		/// </summary>
		public virtual void SetApplicationTakenMethodTypeNull()
		{
			_applicationtakenmethodtype = 0;
			_applicationtakenmethodtype_isnull = true;
		}


		/// <summary>
		/// Marks the InterviewerApplicationSignedDate value as null.
		/// </summary>
		public virtual void SetInterviewerApplicationSignedDateNull()
		{
			_interviewerapplicationsigneddate = DateTime.MinValue;
			_interviewerapplicationsigneddate_isnull = true;
		}


		/// <summary>
		/// Marks the InterviewersEmployerName value as null.
		/// </summary>
		public virtual void SetInterviewersEmployerNameNull()
		{
			_interviewersemployername = null;
		}


		/// <summary>
		/// Marks the InterviewersName value as null.
		/// </summary>
		public virtual void SetInterviewersNameNull()
		{
			_interviewersname = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref InterviewerInformationBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the InterviewersEmployerStreetAddress data to the class member
			_interviewersemployerstreetaddress = data._interviewersemployerstreetaddress;
			// assigns the InterviewersEmployerCity data to the class member
			_interviewersemployercity = data._interviewersemployercity;
			// assigns the InterviewersEmployerState data to the class member
			_interviewersemployerstate = data._interviewersemployerstate;
			// assigns the InterviewersEmployerPostalCode data to the class member
			_interviewersemployerpostalcode = data._interviewersemployerpostalcode;
			// assigns the InterviewersTelephoneNumber data to the class member
			_interviewerstelephonenumber = data._interviewerstelephonenumber;
			// assigns the ApplicationTakenMethodType data to the class member
			_applicationtakenmethodtype = data._applicationtakenmethodtype;
			_applicationtakenmethodtype_isnull = data._applicationtakenmethodtype_isnull;
			// assigns the InterviewerApplicationSignedDate data to the class member
			_interviewerapplicationsigneddate = data._interviewerapplicationsigneddate;
			_interviewerapplicationsigneddate_isnull = data._interviewerapplicationsigneddate_isnull;
			// assigns the InterviewersEmployerName data to the class member
			_interviewersemployername = data._interviewersemployername;
			// assigns the InterviewersName data to the class member
			_interviewersname = data._interviewersname;


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
			// assigns the InterviewersEmployerStreetAddress data to the class member
			if (data["InterviewersEmployerStreetAddress"] == System.DBNull.Value)
				SetInterviewersEmployerStreetAddressNull();
			else
			{
				_interviewersemployerstreetaddress = Convert.ToString(data["InterviewersEmployerStreetAddress"]);
			}
			// assigns the InterviewersEmployerCity data to the class member
			if (data["InterviewersEmployerCity"] == System.DBNull.Value)
				SetInterviewersEmployerCityNull();
			else
			{
				_interviewersemployercity = Convert.ToString(data["InterviewersEmployerCity"]);
			}
			// assigns the InterviewersEmployerState data to the class member
			if (data["InterviewersEmployerState"] == System.DBNull.Value)
				SetInterviewersEmployerStateNull();
			else
			{
				_interviewersemployerstate = Convert.ToString(data["InterviewersEmployerState"]);
			}
			// assigns the InterviewersEmployerPostalCode data to the class member
			if (data["InterviewersEmployerPostalCode"] == System.DBNull.Value)
				SetInterviewersEmployerPostalCodeNull();
			else
			{
				_interviewersemployerpostalcode = Convert.ToString(data["InterviewersEmployerPostalCode"]);
			}
			// assigns the InterviewersTelephoneNumber data to the class member
			if (data["InterviewersTelephoneNumber"] == System.DBNull.Value)
				SetInterviewersTelephoneNumberNull();
			else
			{
				_interviewerstelephonenumber = Convert.ToString(data["InterviewersTelephoneNumber"]);
			}
			// assigns the ApplicationTakenMethodType data to the class member
			if (data["ApplicationTakenMethodType"] == System.DBNull.Value)
				SetApplicationTakenMethodTypeNull();
			else
			{
				_applicationtakenmethodtype = Convert.ToInt16(data["ApplicationTakenMethodType"]);
				_applicationtakenmethodtype_isnull = false;
			}
			// assigns the InterviewerApplicationSignedDate data to the class member
			if (data["InterviewerApplicationSignedDate"] == System.DBNull.Value)
				SetInterviewerApplicationSignedDateNull();
			else
			{
				_interviewerapplicationsigneddate = Convert.ToDateTime(data["InterviewerApplicationSignedDate"]);
				_interviewerapplicationsigneddate_isnull = false;
			}
			// assigns the InterviewersEmployerName data to the class member
			if (data["InterviewersEmployerName"] == System.DBNull.Value)
				SetInterviewersEmployerNameNull();
			else
			{
				_interviewersemployername = Convert.ToString(data["InterviewersEmployerName"]);
			}
			// assigns the InterviewersName data to the class member
			if (data["InterviewersName"] == System.DBNull.Value)
				SetInterviewersNameNull();
			else
			{
				_interviewersname = Convert.ToString(data["InterviewersName"]);
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
			// assigns the InterviewersEmployerStreetAddress data to the class member
			if (data["InterviewersEmployerStreetAddress"] == System.DBNull.Value)
				SetInterviewersEmployerStreetAddressNull();
			else
			{
				_interviewersemployerstreetaddress = Convert.ToString(data["InterviewersEmployerStreetAddress"]);
			}
			// assigns the InterviewersEmployerCity data to the class member
			if (data["InterviewersEmployerCity"] == System.DBNull.Value)
				SetInterviewersEmployerCityNull();
			else
			{
				_interviewersemployercity = Convert.ToString(data["InterviewersEmployerCity"]);
			}
			// assigns the InterviewersEmployerState data to the class member
			if (data["InterviewersEmployerState"] == System.DBNull.Value)
				SetInterviewersEmployerStateNull();
			else
			{
				_interviewersemployerstate = Convert.ToString(data["InterviewersEmployerState"]);
			}
			// assigns the InterviewersEmployerPostalCode data to the class member
			if (data["InterviewersEmployerPostalCode"] == System.DBNull.Value)
				SetInterviewersEmployerPostalCodeNull();
			else
			{
				_interviewersemployerpostalcode = Convert.ToString(data["InterviewersEmployerPostalCode"]);
			}
			// assigns the InterviewersTelephoneNumber data to the class member
			if (data["InterviewersTelephoneNumber"] == System.DBNull.Value)
				SetInterviewersTelephoneNumberNull();
			else
			{
				_interviewerstelephonenumber = Convert.ToString(data["InterviewersTelephoneNumber"]);
			}
			// assigns the ApplicationTakenMethodType data to the class member
			if (data["ApplicationTakenMethodType"] == System.DBNull.Value)
				SetApplicationTakenMethodTypeNull();
			else
			{
				_applicationtakenmethodtype = Convert.ToInt16(data["ApplicationTakenMethodType"]);
				_applicationtakenmethodtype_isnull = false;
			}
			// assigns the InterviewerApplicationSignedDate data to the class member
			if (data["InterviewerApplicationSignedDate"] == System.DBNull.Value)
				SetInterviewerApplicationSignedDateNull();
			else
			{
				_interviewerapplicationsigneddate = Convert.ToDateTime(data["InterviewerApplicationSignedDate"]);
				_interviewerapplicationsigneddate_isnull = false;
			}
			// assigns the InterviewersEmployerName data to the class member
			if (data["InterviewersEmployerName"] == System.DBNull.Value)
				SetInterviewersEmployerNameNull();
			else
			{
				_interviewersemployername = Convert.ToString(data["InterviewersEmployerName"]);
			}
			// assigns the InterviewersName data to the class member
			if (data["InterviewersName"] == System.DBNull.Value)
				SetInterviewersNameNull();
			else
			{
				_interviewersname = Convert.ToString(data["InterviewersName"]);
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
			InterviewerInformationBase.ServiceObject.Persist(this as InterviewerInformation, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the INTERVIEWER_INFORMATION object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			InterviewerInformationBase.ServiceObject.Delete(this as InterviewerInformation);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the ApplicationMethod relationship.
		/// </summary>
		public ApplicationMethod GetApplicationMethod()
		{
			if (_applicationtakenmethodtype_isnull)
				return null;
			else
				return new ApplicationMethod(_applicationtakenmethodtype);
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
		/// Gets all persisted InterviewerInformation objects
		/// </summary>
		public static InterviewerInformationCollection GetAll()
		{
			// have the service object get the objects
			return InterviewerInformationBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
