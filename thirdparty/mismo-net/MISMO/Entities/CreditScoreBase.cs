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
	/// A class that represents an abstract entity for table 'CREDIT_SCORE'
	/// </summary>
	[Serializable]
	public abstract class CreditScoreBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditScoreBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.CreditScore)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public CreditScoreBase(System.Int64 creditScoreID)
		{
			// Fill this instance.
			CreditScoreBase.ServiceObject.Fill(this as CreditScore, creditScoreID);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the value for the creditscoreid.
		/// </summary>
		internal System.Int64 _creditscoreid;
		/// <summary>
		/// Gets the CreditScoreID value of the class instance.
		/// </summary>
		public virtual System.Int64 CreditScoreID
		{
			get
			{
				return _creditscoreid;
			}
			set
			{
				throw new System.NotImplementedException("The class property CreditScoreID is a read-only property.");
			}
		}


		/// <summary>
		/// Member that stores the value for the creditreportidentifier.
		/// </summary>
		internal System.String _creditreportidentifier;
		/// <summary>
		/// Gets and sets the CreditReportIdentifier value of the class instance.
		/// </summary>
		public virtual System.String CreditReportIdentifier
		{
			get
			{
				return _creditreportidentifier;
			}
			set
			{
				_creditreportidentifier = value;
			}
		}


		/// <summary>
		/// Checks the CreditReportIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditReportIdentifierIsNull
		{
			get
			{
				return (_creditreportidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _creditscoredate_isnull = true;
		/// <summary>
		/// Member that stores the value for the creditscoredate.
		/// </summary>
		internal System.DateTime _creditscoredate;
		/// <summary>
		/// Gets and sets the CreditScoreDate value of the class instance.
		/// </summary>
		public virtual System.DateTime CreditScoreDate
		{
			get
			{
				return _creditscoredate;
			}
			set
			{
				_creditscoredate = value;
				_creditscoredate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CreditScoreDate value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditScoreDateIsNull
		{
			get
			{
				return _creditscoredate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the creditscoremodelnametypeotherdescription.
		/// </summary>
		internal System.String _creditscoremodelnametypeotherdescription;
		/// <summary>
		/// Gets and sets the CreditScoreModelNameTypeOtherDescription value of the class instance.
		/// </summary>
		public virtual System.String CreditScoreModelNameTypeOtherDescription
		{
			get
			{
				return _creditscoremodelnametypeotherdescription;
			}
			set
			{
				_creditscoremodelnametypeotherdescription = value;
			}
		}


		/// <summary>
		/// Checks the CreditScoreModelNameTypeOtherDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditScoreModelNameTypeOtherDescriptionIsNull
		{
			get
			{
				return (_creditscoremodelnametypeotherdescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _creditscorevalue_isnull = true;
		/// <summary>
		/// Member that stores the value for the creditscorevalue.
		/// </summary>
		internal System.Int16 _creditscorevalue;
		/// <summary>
		/// Gets and sets the CreditScoreValue value of the class instance.
		/// </summary>
		public virtual System.Int16 CreditScoreValue
		{
			get
			{
				return _creditscorevalue;
			}
			set
			{
				_creditscorevalue = value;
				_creditscorevalue_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CreditScoreValue value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditScoreValueIsNull
		{
			get
			{
				return _creditscorevalue_isnull;
			}
		}


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
		internal bool _creditrepositorysourcetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the creditrepositorysourcetype.
		/// </summary>
		internal System.Int16 _creditrepositorysourcetype;
		/// <summary>
		/// Gets and sets the CreditRepositorySourceType value of the class instance.
		/// </summary>
		public virtual System.Int16 CreditRepositorySourceType
		{
			get
			{
				return _creditrepositorysourcetype;
			}
			set
			{
				_creditrepositorysourcetype = value;
				_creditrepositorysourcetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CreditRepositorySourceType value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditRepositorySourceTypeIsNull
		{
			get
			{
				return _creditrepositorysourcetype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _creditscoreexclusiontype_isnull = true;
		/// <summary>
		/// Member that stores the value for the creditscoreexclusiontype.
		/// </summary>
		internal System.Int16 _creditscoreexclusiontype;
		/// <summary>
		/// Gets and sets the CreditScoreExclusionType value of the class instance.
		/// </summary>
		public virtual System.Int16 CreditScoreExclusionType
		{
			get
			{
				return _creditscoreexclusiontype;
			}
			set
			{
				_creditscoreexclusiontype = value;
				_creditscoreexclusiontype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CreditScoreExclusionType value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditScoreExclusionTypeIsNull
		{
			get
			{
				return _creditscoreexclusiontype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _creditscoremodelnametype_isnull = true;
		/// <summary>
		/// Member that stores the value for the creditscoremodelnametype.
		/// </summary>
		internal System.Int16 _creditscoremodelnametype;
		/// <summary>
		/// Gets and sets the CreditScoreModelNameType value of the class instance.
		/// </summary>
		public virtual System.Int16 CreditScoreModelNameType
		{
			get
			{
				return _creditscoremodelnametype;
			}
			set
			{
				_creditscoremodelnametype = value;
				_creditscoremodelnametype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CreditScoreModelNameType value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditScoreModelNameTypeIsNull
		{
			get
			{
				return _creditscoremodelnametype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the CreditScoreBase.
		/// </summary>
		internal static CreditScoreService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(CreditScoreService)) as CreditScoreService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of CreditScoreBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the CreditReportIdentifier value as null.
		/// </summary>
		public virtual void SetCreditReportIdentifierNull()
		{
			_creditreportidentifier = null;
		}


		/// <summary>
		/// Marks the CreditScoreDate value as null.
		/// </summary>
		public virtual void SetCreditScoreDateNull()
		{
			_creditscoredate = DateTime.MinValue;
			_creditscoredate_isnull = true;
		}


		/// <summary>
		/// Marks the CreditScoreModelNameTypeOtherDescription value as null.
		/// </summary>
		public virtual void SetCreditScoreModelNameTypeOtherDescriptionNull()
		{
			_creditscoremodelnametypeotherdescription = null;
		}


		/// <summary>
		/// Marks the CreditScoreValue value as null.
		/// </summary>
		public virtual void SetCreditScoreValueNull()
		{
			_creditscorevalue = 0;
			_creditscorevalue_isnull = true;
		}


		/// <summary>
		/// Marks the CreditRepositorySourceType value as null.
		/// </summary>
		public virtual void SetCreditRepositorySourceTypeNull()
		{
			_creditrepositorysourcetype = 0;
			_creditrepositorysourcetype_isnull = true;
		}


		/// <summary>
		/// Marks the CreditScoreExclusionType value as null.
		/// </summary>
		public virtual void SetCreditScoreExclusionTypeNull()
		{
			_creditscoreexclusiontype = 0;
			_creditscoreexclusiontype_isnull = true;
		}


		/// <summary>
		/// Marks the CreditScoreModelNameType value as null.
		/// </summary>
		public virtual void SetCreditScoreModelNameTypeNull()
		{
			_creditscoremodelnametype = 0;
			_creditscoremodelnametype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref CreditScoreBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the CreditScoreID data to the class member
			_creditscoreid = data._creditscoreid;
			// assigns the CreditReportIdentifier data to the class member
			_creditreportidentifier = data._creditreportidentifier;
			// assigns the CreditScoreDate data to the class member
			_creditscoredate = data._creditscoredate;
			_creditscoredate_isnull = data._creditscoredate_isnull;
			// assigns the CreditScoreModelNameTypeOtherDescription data to the class member
			_creditscoremodelnametypeotherdescription = data._creditscoremodelnametypeotherdescription;
			// assigns the CreditScoreValue data to the class member
			_creditscorevalue = data._creditscorevalue;
			_creditscorevalue_isnull = data._creditscorevalue_isnull;
			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the CreditRepositorySourceType data to the class member
			_creditrepositorysourcetype = data._creditrepositorysourcetype;
			_creditrepositorysourcetype_isnull = data._creditrepositorysourcetype_isnull;
			// assigns the CreditScoreExclusionType data to the class member
			_creditscoreexclusiontype = data._creditscoreexclusiontype;
			_creditscoreexclusiontype_isnull = data._creditscoreexclusiontype_isnull;
			// assigns the CreditScoreModelNameType data to the class member
			_creditscoremodelnametype = data._creditscoremodelnametype;
			_creditscoremodelnametype_isnull = data._creditscoremodelnametype_isnull;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.SqlClient.SqlDataReader data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the CreditScoreID data to the class member
			_creditscoreid = Convert.ToInt64(data["CreditScoreID"]);
			// assigns the CreditReportIdentifier data to the class member
			if (data["CreditReportIdentifier"] == System.DBNull.Value)
				SetCreditReportIdentifierNull();
			else
			{
				_creditreportidentifier = Convert.ToString(data["CreditReportIdentifier"]);
			}
			// assigns the CreditScoreDate data to the class member
			if (data["CreditScoreDate"] == System.DBNull.Value)
				SetCreditScoreDateNull();
			else
			{
				_creditscoredate = Convert.ToDateTime(data["CreditScoreDate"]);
				_creditscoredate_isnull = false;
			}
			// assigns the CreditScoreModelNameTypeOtherDescription data to the class member
			if (data["CreditScoreModelNameTypeOtherDescription"] == System.DBNull.Value)
				SetCreditScoreModelNameTypeOtherDescriptionNull();
			else
			{
				_creditscoremodelnametypeotherdescription = Convert.ToString(data["CreditScoreModelNameTypeOtherDescription"]);
			}
			// assigns the CreditScoreValue data to the class member
			if (data["CreditScoreValue"] == System.DBNull.Value)
				SetCreditScoreValueNull();
			else
			{
				_creditscorevalue = Convert.ToInt16(data["CreditScoreValue"]);
				_creditscorevalue_isnull = false;
			}
			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the CreditRepositorySourceType data to the class member
			if (data["CreditRepositorySourceType"] == System.DBNull.Value)
				SetCreditRepositorySourceTypeNull();
			else
			{
				_creditrepositorysourcetype = Convert.ToInt16(data["CreditRepositorySourceType"]);
				_creditrepositorysourcetype_isnull = false;
			}
			// assigns the CreditScoreExclusionType data to the class member
			if (data["CreditScoreExclusionType"] == System.DBNull.Value)
				SetCreditScoreExclusionTypeNull();
			else
			{
				_creditscoreexclusiontype = Convert.ToInt16(data["CreditScoreExclusionType"]);
				_creditscoreexclusiontype_isnull = false;
			}
			// assigns the CreditScoreModelNameType data to the class member
			if (data["CreditScoreModelNameType"] == System.DBNull.Value)
				SetCreditScoreModelNameTypeNull();
			else
			{
				_creditscoremodelnametype = Convert.ToInt16(data["CreditScoreModelNameType"]);
				_creditscoremodelnametype_isnull = false;
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


			// assigns the CreditScoreID data to the class member
			_creditscoreid = Convert.ToInt64(data["CreditScoreID"]);
			// assigns the CreditReportIdentifier data to the class member
			if (data["CreditReportIdentifier"] == System.DBNull.Value)
				SetCreditReportIdentifierNull();
			else
			{
				_creditreportidentifier = Convert.ToString(data["CreditReportIdentifier"]);
			}
			// assigns the CreditScoreDate data to the class member
			if (data["CreditScoreDate"] == System.DBNull.Value)
				SetCreditScoreDateNull();
			else
			{
				_creditscoredate = Convert.ToDateTime(data["CreditScoreDate"]);
				_creditscoredate_isnull = false;
			}
			// assigns the CreditScoreModelNameTypeOtherDescription data to the class member
			if (data["CreditScoreModelNameTypeOtherDescription"] == System.DBNull.Value)
				SetCreditScoreModelNameTypeOtherDescriptionNull();
			else
			{
				_creditscoremodelnametypeotherdescription = Convert.ToString(data["CreditScoreModelNameTypeOtherDescription"]);
			}
			// assigns the CreditScoreValue data to the class member
			if (data["CreditScoreValue"] == System.DBNull.Value)
				SetCreditScoreValueNull();
			else
			{
				_creditscorevalue = Convert.ToInt16(data["CreditScoreValue"]);
				_creditscorevalue_isnull = false;
			}
			// assigns the BorrowerId data to the class member
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the CreditRepositorySourceType data to the class member
			if (data["CreditRepositorySourceType"] == System.DBNull.Value)
				SetCreditRepositorySourceTypeNull();
			else
			{
				_creditrepositorysourcetype = Convert.ToInt16(data["CreditRepositorySourceType"]);
				_creditrepositorysourcetype_isnull = false;
			}
			// assigns the CreditScoreExclusionType data to the class member
			if (data["CreditScoreExclusionType"] == System.DBNull.Value)
				SetCreditScoreExclusionTypeNull();
			else
			{
				_creditscoreexclusiontype = Convert.ToInt16(data["CreditScoreExclusionType"]);
				_creditscoreexclusiontype_isnull = false;
			}
			// assigns the CreditScoreModelNameType data to the class member
			if (data["CreditScoreModelNameType"] == System.DBNull.Value)
				SetCreditScoreModelNameTypeNull();
			else
			{
				_creditscoremodelnametype = Convert.ToInt16(data["CreditScoreModelNameType"]);
				_creditscoremodelnametype_isnull = false;
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
			CreditScoreBase.ServiceObject.Persist(this as CreditScore, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the CREDIT_SCORE object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			CreditScoreBase.ServiceObject.Delete(this as CreditScore);


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
		/// Gets the single object for the CreditScoreModelNameType relationship.
		/// </summary>
		public CreditScoreModelNameType GetCreditScoreModelNameType()
		{
			if (_creditscoremodelnametype_isnull)
				return null;
			else
				return new CreditScoreModelNameType(_creditscoremodelnametype);
		}


		/// <summary>
		/// Gets the single object for the CreditRepositorySourceType relationship.
		/// </summary>
		public CreditRepositorySourceType GetCreditRepositorySourceType()
		{
			if (_creditrepositorysourcetype_isnull)
				return null;
			else
				return new CreditRepositorySourceType(_creditrepositorysourcetype);
		}


		/// <summary>
		/// Gets the single object for the CreditScoreExclusionReasonType relationship.
		/// </summary>
		public CreditScoreExclusionReasonType GetCreditScoreExclusionReasonType()
		{
			if (_creditscoreexclusiontype_isnull)
				return null;
			else
				return new CreditScoreExclusionReasonType(_creditscoreexclusiontype);
		}


		/// <summary>
		/// Gets all persisted CreditScore objects
		/// </summary>
		public static CreditScores GetAll()
		{
			// have the service object get the objects
			return CreditScoreBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
