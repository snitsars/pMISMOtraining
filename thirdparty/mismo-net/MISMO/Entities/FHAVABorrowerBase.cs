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
	/// A class that represents an abstract entity for table 'FHA_VA_BORROWER'
	/// </summary>
	[Serializable]
	public abstract class FHAVABorrowerBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVABorrowerBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.FHAVABorrower)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FHAVABorrowerBase(System.Int64 borrowerId)
		{
			// Fill this instance.
			FHAVABorrowerBase.ServiceObject.Fill(this as FHAVABorrower, borrowerId);
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
		/// Member that stores the value for the caivrsidentifier.
		/// </summary>
		internal System.String _caivrsidentifier;
		/// <summary>
		/// Gets and sets the CAIVRSIdentifier value of the class instance.
		/// </summary>
		public virtual System.String CAIVRSIdentifier
		{
			get
			{
				return _caivrsidentifier;
			}
			set
			{
				_caivrsidentifier = value;
			}
		}


		/// <summary>
		/// Checks the CAIVRSIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean CAIVRSIdentifierIsNull
		{
			get
			{
				return (_caivrsidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fnmbankruptcycount_isnull = true;
		/// <summary>
		/// Member that stores the value for the fnmbankruptcycount.
		/// </summary>
		internal System.Byte _fnmbankruptcycount;
		/// <summary>
		/// Gets and sets the FNMBankruptcyCount value of the class instance.
		/// </summary>
		public virtual System.Byte FNMBankruptcyCount
		{
			get
			{
				return _fnmbankruptcycount;
			}
			set
			{
				_fnmbankruptcycount = value;
				_fnmbankruptcycount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FNMBankruptcyCount value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMBankruptcyCountIsNull
		{
			get
			{
				return _fnmbankruptcycount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the fnmborrowercreditrating.
		/// </summary>
		internal System.String _fnmborrowercreditrating;
		/// <summary>
		/// Gets and sets the FNMBorrowerCreditRating value of the class instance.
		/// </summary>
		public virtual System.String FNMBorrowerCreditRating
		{
			get
			{
				return _fnmborrowercreditrating;
			}
			set
			{
				_fnmborrowercreditrating = value;
			}
		}


		/// <summary>
		/// Checks the FNMBorrowerCreditRating value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMBorrowerCreditRatingIsNull
		{
			get
			{
				return (_fnmborrowercreditrating == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fnmcreditreportscoretype_isnull = true;
		/// <summary>
		/// Member that stores the value for the fnmcreditreportscoretype.
		/// </summary>
		internal System.Int16 _fnmcreditreportscoretype;
		/// <summary>
		/// Gets and sets the FNMCreditReportScoreType value of the class instance.
		/// </summary>
		public virtual System.Int16 FNMCreditReportScoreType
		{
			get
			{
				return _fnmcreditreportscoretype;
			}
			set
			{
				_fnmcreditreportscoretype = value;
				_fnmcreditreportscoretype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FNMCreditReportScoreType value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMCreditReportScoreTypeIsNull
		{
			get
			{
				return _fnmcreditreportscoretype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fnmforeclosurecount_isnull = true;
		/// <summary>
		/// Member that stores the value for the fnmforeclosurecount.
		/// </summary>
		internal System.Byte _fnmforeclosurecount;
		/// <summary>
		/// Gets and sets the FNMForeclosureCount value of the class instance.
		/// </summary>
		public virtual System.Byte FNMForeclosureCount
		{
			get
			{
				return _fnmforeclosurecount;
			}
			set
			{
				_fnmforeclosurecount = value;
				_fnmforeclosurecount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FNMForeclosureCount value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMForeclosureCountIsNull
		{
			get
			{
				return _fnmforeclosurecount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _veteranstatusindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the veteranstatusindicator.
		/// </summary>
		internal System.Boolean _veteranstatusindicator;
		/// <summary>
		/// Gets and sets the VeteranStatusIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean VeteranStatusIndicator
		{
			get
			{
				return _veteranstatusindicator;
			}
			set
			{
				_veteranstatusindicator = value;
				_veteranstatusindicator_assigned = true;
			}
		}


		/// <summary>
		/// Gets the service object for the FHAVABorrowerBase.
		/// </summary>
		internal static FHAVABorrowerService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(FHAVABorrowerService)) as FHAVABorrowerService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of FHAVABorrowerBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the CAIVRSIdentifier value as null.
		/// </summary>
		public virtual void SetCAIVRSIdentifierNull()
		{
			_caivrsidentifier = null;
		}


		/// <summary>
		/// Marks the FNMBankruptcyCount value as null.
		/// </summary>
		public virtual void SetFNMBankruptcyCountNull()
		{
			_fnmbankruptcycount = 0;
			_fnmbankruptcycount_isnull = true;
		}


		/// <summary>
		/// Marks the FNMBorrowerCreditRating value as null.
		/// </summary>
		public virtual void SetFNMBorrowerCreditRatingNull()
		{
			_fnmborrowercreditrating = null;
		}


		/// <summary>
		/// Marks the FNMCreditReportScoreType value as null.
		/// </summary>
		public virtual void SetFNMCreditReportScoreTypeNull()
		{
			_fnmcreditreportscoretype = 0;
			_fnmcreditreportscoretype_isnull = true;
		}


		/// <summary>
		/// Marks the FNMForeclosureCount value as null.
		/// </summary>
		public virtual void SetFNMForeclosureCountNull()
		{
			_fnmforeclosurecount = 0;
			_fnmforeclosurecount_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref FHAVABorrowerBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the CAIVRSIdentifier data to the class member
			_caivrsidentifier = data._caivrsidentifier;
			// assigns the FNMBankruptcyCount data to the class member
			_fnmbankruptcycount = data._fnmbankruptcycount;
			_fnmbankruptcycount_isnull = data._fnmbankruptcycount_isnull;
			// assigns the FNMBorrowerCreditRating data to the class member
			_fnmborrowercreditrating = data._fnmborrowercreditrating;
			// assigns the FNMCreditReportScoreType data to the class member
			_fnmcreditreportscoretype = data._fnmcreditreportscoretype;
			_fnmcreditreportscoretype_isnull = data._fnmcreditreportscoretype_isnull;
			// assigns the FNMForeclosureCount data to the class member
			_fnmforeclosurecount = data._fnmforeclosurecount;
			_fnmforeclosurecount_isnull = data._fnmforeclosurecount_isnull;
			// assigns the VeteranStatusIndicator data to the class member
			_veteranstatusindicator = data._veteranstatusindicator;
			_veteranstatusindicator_assigned = data._veteranstatusindicator_assigned;


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
			// assigns the CAIVRSIdentifier data to the class member
			if (data["CAIVRSIdentifier"] == System.DBNull.Value)
				SetCAIVRSIdentifierNull();
			else
			{
				_caivrsidentifier = Convert.ToString(data["CAIVRSIdentifier"]);
			}
			// assigns the FNMBankruptcyCount data to the class member
			if (data["FNMBankruptcyCount"] == System.DBNull.Value)
				SetFNMBankruptcyCountNull();
			else
			{
				_fnmbankruptcycount = Convert.ToByte(data["FNMBankruptcyCount"]);
				_fnmbankruptcycount_isnull = false;
			}
			// assigns the FNMBorrowerCreditRating data to the class member
			if (data["FNMBorrowerCreditRating"] == System.DBNull.Value)
				SetFNMBorrowerCreditRatingNull();
			else
			{
				_fnmborrowercreditrating = Convert.ToString(data["FNMBorrowerCreditRating"]);
			}
			// assigns the FNMCreditReportScoreType data to the class member
			if (data["FNMCreditReportScoreType"] == System.DBNull.Value)
				SetFNMCreditReportScoreTypeNull();
			else
			{
				_fnmcreditreportscoretype = Convert.ToInt16(data["FNMCreditReportScoreType"]);
				_fnmcreditreportscoretype_isnull = false;
			}
			// assigns the FNMForeclosureCount data to the class member
			if (data["FNMForeclosureCount"] == System.DBNull.Value)
				SetFNMForeclosureCountNull();
			else
			{
				_fnmforeclosurecount = Convert.ToByte(data["FNMForeclosureCount"]);
				_fnmforeclosurecount_isnull = false;
			}
			// assigns the VeteranStatusIndicator data to the class member
			_veteranstatusindicator = Convert.ToBoolean(data["VeteranStatusIndicator"]);
			_veteranstatusindicator_assigned = true;


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
			// assigns the CAIVRSIdentifier data to the class member
			if (data["CAIVRSIdentifier"] == System.DBNull.Value)
				SetCAIVRSIdentifierNull();
			else
			{
				_caivrsidentifier = Convert.ToString(data["CAIVRSIdentifier"]);
			}
			// assigns the FNMBankruptcyCount data to the class member
			if (data["FNMBankruptcyCount"] == System.DBNull.Value)
				SetFNMBankruptcyCountNull();
			else
			{
				_fnmbankruptcycount = Convert.ToByte(data["FNMBankruptcyCount"]);
				_fnmbankruptcycount_isnull = false;
			}
			// assigns the FNMBorrowerCreditRating data to the class member
			if (data["FNMBorrowerCreditRating"] == System.DBNull.Value)
				SetFNMBorrowerCreditRatingNull();
			else
			{
				_fnmborrowercreditrating = Convert.ToString(data["FNMBorrowerCreditRating"]);
			}
			// assigns the FNMCreditReportScoreType data to the class member
			if (data["FNMCreditReportScoreType"] == System.DBNull.Value)
				SetFNMCreditReportScoreTypeNull();
			else
			{
				_fnmcreditreportscoretype = Convert.ToInt16(data["FNMCreditReportScoreType"]);
				_fnmcreditreportscoretype_isnull = false;
			}
			// assigns the FNMForeclosureCount data to the class member
			if (data["FNMForeclosureCount"] == System.DBNull.Value)
				SetFNMForeclosureCountNull();
			else
			{
				_fnmforeclosurecount = Convert.ToByte(data["FNMForeclosureCount"]);
				_fnmforeclosurecount_isnull = false;
			}
			// assigns the VeteranStatusIndicator data to the class member
			_veteranstatusindicator = Convert.ToBoolean(data["VeteranStatusIndicator"]);
			_veteranstatusindicator_assigned = true;


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
			FHAVABorrowerBase.ServiceObject.Persist(this as FHAVABorrower, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the FHA_VA_BORROWER object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			FHAVABorrowerBase.ServiceObject.Delete(this as FHAVABorrower);


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
		/// Gets the single object for the FNMCreditReportScoreType relationship.
		/// </summary>
		public FNMCreditReportScoreType GetFNMCreditReportScoreType()
		{
			if (_fnmcreditreportscoretype_isnull)
				return null;
			else
				return new FNMCreditReportScoreType(_fnmcreditreportscoretype);
		}


		/// <summary>
		/// Gets all persisted FHAVABorrower objects
		/// </summary>
		public static FHAVABorrowers GetAll()
		{
			// have the service object get the objects
			return FHAVABorrowerBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
