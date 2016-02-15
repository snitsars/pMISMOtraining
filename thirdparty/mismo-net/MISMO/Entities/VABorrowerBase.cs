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
	/// A class that represents an abstract entity for table 'VA_BORROWER'
	/// </summary>
	[Serializable]
	public abstract class VABorrowerBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VABorrowerBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.VABorrower)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public VABorrowerBase(System.Int64 borrowerId)
		{
			// Fill this instance.
			VABorrowerBase.ServiceObject.Fill(this as VABorrower, borrowerId);
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
		internal bool _vacoborrowernontaxableincomeamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vacoborrowernontaxableincomeamount.
		/// </summary>
		internal System.Decimal _vacoborrowernontaxableincomeamount;
		/// <summary>
		/// Gets and sets the VACoBorrowerNonTaxableIncomeAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VACoBorrowerNonTaxableIncomeAmount
		{
			get
			{
				return _vacoborrowernontaxableincomeamount;
			}
			set
			{
				_vacoborrowernontaxableincomeamount = value;
				_vacoborrowernontaxableincomeamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VACoBorrowerNonTaxableIncomeAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VACoBorrowerNonTaxableIncomeAmountIsNull
		{
			get
			{
				return _vacoborrowernontaxableincomeamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vacoborrowertaxableincomeamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vacoborrowertaxableincomeamount.
		/// </summary>
		internal System.Decimal _vacoborrowertaxableincomeamount;
		/// <summary>
		/// Gets and sets the VACoBorrowerTaxableIncomeAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VACoBorrowerTaxableIncomeAmount
		{
			get
			{
				return _vacoborrowertaxableincomeamount;
			}
			set
			{
				_vacoborrowertaxableincomeamount = value;
				_vacoborrowertaxableincomeamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VACoBorrowerTaxableIncomeAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VACoBorrowerTaxableIncomeAmountIsNull
		{
			get
			{
				return _vacoborrowertaxableincomeamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vafederaltaxamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vafederaltaxamount.
		/// </summary>
		internal System.Decimal _vafederaltaxamount;
		/// <summary>
		/// Gets and sets the VAFederalTaxAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAFederalTaxAmount
		{
			get
			{
				return _vafederaltaxamount;
			}
			set
			{
				_vafederaltaxamount = value;
				_vafederaltaxamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAFederalTaxAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAFederalTaxAmountIsNull
		{
			get
			{
				return _vafederaltaxamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _valocaltaxamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the valocaltaxamount.
		/// </summary>
		internal System.Decimal _valocaltaxamount;
		/// <summary>
		/// Gets and sets the VALocalTaxAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VALocalTaxAmount
		{
			get
			{
				return _valocaltaxamount;
			}
			set
			{
				_valocaltaxamount = value;
				_valocaltaxamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VALocalTaxAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VALocalTaxAmountIsNull
		{
			get
			{
				return _valocaltaxamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vaprimaryborrowernontaxableincomeamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vaprimaryborrowernontaxableincomeamount.
		/// </summary>
		internal System.Decimal _vaprimaryborrowernontaxableincomeamount;
		/// <summary>
		/// Gets and sets the VAPrimaryBorrowerNonTaxableIncomeAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAPrimaryBorrowerNonTaxableIncomeAmount
		{
			get
			{
				return _vaprimaryborrowernontaxableincomeamount;
			}
			set
			{
				_vaprimaryborrowernontaxableincomeamount = value;
				_vaprimaryborrowernontaxableincomeamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAPrimaryBorrowerNonTaxableIncomeAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAPrimaryBorrowerNonTaxableIncomeAmountIsNull
		{
			get
			{
				return _vaprimaryborrowernontaxableincomeamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vaprimaryborrowertaxableincomeamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vaprimaryborrowertaxableincomeamount.
		/// </summary>
		internal System.Decimal _vaprimaryborrowertaxableincomeamount;
		/// <summary>
		/// Gets and sets the VAPrimaryBorrowerTaxableIncomeAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAPrimaryBorrowerTaxableIncomeAmount
		{
			get
			{
				return _vaprimaryborrowertaxableincomeamount;
			}
			set
			{
				_vaprimaryborrowertaxableincomeamount = value;
				_vaprimaryborrowertaxableincomeamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAPrimaryBorrowerTaxableIncomeAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAPrimaryBorrowerTaxableIncomeAmountIsNull
		{
			get
			{
				return _vaprimaryborrowertaxableincomeamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vasocialsecuritytaxamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vasocialsecuritytaxamount.
		/// </summary>
		internal System.Decimal _vasocialsecuritytaxamount;
		/// <summary>
		/// Gets and sets the VASocialSecurityTaxAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VASocialSecurityTaxAmount
		{
			get
			{
				return _vasocialsecuritytaxamount;
			}
			set
			{
				_vasocialsecuritytaxamount = value;
				_vasocialsecuritytaxamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VASocialSecurityTaxAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VASocialSecurityTaxAmountIsNull
		{
			get
			{
				return _vasocialsecuritytaxamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _vastatetaxamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the vastatetaxamount.
		/// </summary>
		internal System.Decimal _vastatetaxamount;
		/// <summary>
		/// Gets and sets the VAStateTaxAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal VAStateTaxAmount
		{
			get
			{
				return _vastatetaxamount;
			}
			set
			{
				_vastatetaxamount = value;
				_vastatetaxamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the VAStateTaxAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean VAStateTaxAmountIsNull
		{
			get
			{
				return _vastatetaxamount_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the VABorrowerBase.
		/// </summary>
		internal static VABorrowerService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(VABorrowerService)) as VABorrowerService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of VABorrowerBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the VACoBorrowerNonTaxableIncomeAmount value as null.
		/// </summary>
		public virtual void SetVACoBorrowerNonTaxableIncomeAmountNull()
		{
			_vacoborrowernontaxableincomeamount = 0;
			_vacoborrowernontaxableincomeamount_isnull = true;
		}


		/// <summary>
		/// Marks the VACoBorrowerTaxableIncomeAmount value as null.
		/// </summary>
		public virtual void SetVACoBorrowerTaxableIncomeAmountNull()
		{
			_vacoborrowertaxableincomeamount = 0;
			_vacoborrowertaxableincomeamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAFederalTaxAmount value as null.
		/// </summary>
		public virtual void SetVAFederalTaxAmountNull()
		{
			_vafederaltaxamount = 0;
			_vafederaltaxamount_isnull = true;
		}


		/// <summary>
		/// Marks the VALocalTaxAmount value as null.
		/// </summary>
		public virtual void SetVALocalTaxAmountNull()
		{
			_valocaltaxamount = 0;
			_valocaltaxamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAPrimaryBorrowerNonTaxableIncomeAmount value as null.
		/// </summary>
		public virtual void SetVAPrimaryBorrowerNonTaxableIncomeAmountNull()
		{
			_vaprimaryborrowernontaxableincomeamount = 0;
			_vaprimaryborrowernontaxableincomeamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAPrimaryBorrowerTaxableIncomeAmount value as null.
		/// </summary>
		public virtual void SetVAPrimaryBorrowerTaxableIncomeAmountNull()
		{
			_vaprimaryborrowertaxableincomeamount = 0;
			_vaprimaryborrowertaxableincomeamount_isnull = true;
		}


		/// <summary>
		/// Marks the VASocialSecurityTaxAmount value as null.
		/// </summary>
		public virtual void SetVASocialSecurityTaxAmountNull()
		{
			_vasocialsecuritytaxamount = 0;
			_vasocialsecuritytaxamount_isnull = true;
		}


		/// <summary>
		/// Marks the VAStateTaxAmount value as null.
		/// </summary>
		public virtual void SetVAStateTaxAmountNull()
		{
			_vastatetaxamount = 0;
			_vastatetaxamount_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref VABorrowerBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the VACoBorrowerNonTaxableIncomeAmount data to the class member
			_vacoborrowernontaxableincomeamount = data._vacoborrowernontaxableincomeamount;
			_vacoborrowernontaxableincomeamount_isnull = data._vacoborrowernontaxableincomeamount_isnull;
			// assigns the VACoBorrowerTaxableIncomeAmount data to the class member
			_vacoborrowertaxableincomeamount = data._vacoborrowertaxableincomeamount;
			_vacoborrowertaxableincomeamount_isnull = data._vacoborrowertaxableincomeamount_isnull;
			// assigns the VAFederalTaxAmount data to the class member
			_vafederaltaxamount = data._vafederaltaxamount;
			_vafederaltaxamount_isnull = data._vafederaltaxamount_isnull;
			// assigns the VALocalTaxAmount data to the class member
			_valocaltaxamount = data._valocaltaxamount;
			_valocaltaxamount_isnull = data._valocaltaxamount_isnull;
			// assigns the VAPrimaryBorrowerNonTaxableIncomeAmount data to the class member
			_vaprimaryborrowernontaxableincomeamount = data._vaprimaryborrowernontaxableincomeamount;
			_vaprimaryborrowernontaxableincomeamount_isnull = data._vaprimaryborrowernontaxableincomeamount_isnull;
			// assigns the VAPrimaryBorrowerTaxableIncomeAmount data to the class member
			_vaprimaryborrowertaxableincomeamount = data._vaprimaryborrowertaxableincomeamount;
			_vaprimaryborrowertaxableincomeamount_isnull = data._vaprimaryborrowertaxableincomeamount_isnull;
			// assigns the VASocialSecurityTaxAmount data to the class member
			_vasocialsecuritytaxamount = data._vasocialsecuritytaxamount;
			_vasocialsecuritytaxamount_isnull = data._vasocialsecuritytaxamount_isnull;
			// assigns the VAStateTaxAmount data to the class member
			_vastatetaxamount = data._vastatetaxamount;
			_vastatetaxamount_isnull = data._vastatetaxamount_isnull;


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
			// assigns the VACoBorrowerNonTaxableIncomeAmount data to the class member
			if (data["VACoBorrowerNonTaxableIncomeAmount"] == System.DBNull.Value)
				SetVACoBorrowerNonTaxableIncomeAmountNull();
			else
			{
				_vacoborrowernontaxableincomeamount = Convert.ToDecimal(data["VACoBorrowerNonTaxableIncomeAmount"]);
				_vacoborrowernontaxableincomeamount_isnull = false;
			}
			// assigns the VACoBorrowerTaxableIncomeAmount data to the class member
			if (data["VACoBorrowerTaxableIncomeAmount"] == System.DBNull.Value)
				SetVACoBorrowerTaxableIncomeAmountNull();
			else
			{
				_vacoborrowertaxableincomeamount = Convert.ToDecimal(data["VACoBorrowerTaxableIncomeAmount"]);
				_vacoborrowertaxableincomeamount_isnull = false;
			}
			// assigns the VAFederalTaxAmount data to the class member
			if (data["VAFederalTaxAmount"] == System.DBNull.Value)
				SetVAFederalTaxAmountNull();
			else
			{
				_vafederaltaxamount = Convert.ToDecimal(data["VAFederalTaxAmount"]);
				_vafederaltaxamount_isnull = false;
			}
			// assigns the VALocalTaxAmount data to the class member
			if (data["VALocalTaxAmount"] == System.DBNull.Value)
				SetVALocalTaxAmountNull();
			else
			{
				_valocaltaxamount = Convert.ToDecimal(data["VALocalTaxAmount"]);
				_valocaltaxamount_isnull = false;
			}
			// assigns the VAPrimaryBorrowerNonTaxableIncomeAmount data to the class member
			if (data["VAPrimaryBorrowerNonTaxableIncomeAmount"] == System.DBNull.Value)
				SetVAPrimaryBorrowerNonTaxableIncomeAmountNull();
			else
			{
				_vaprimaryborrowernontaxableincomeamount = Convert.ToDecimal(data["VAPrimaryBorrowerNonTaxableIncomeAmount"]);
				_vaprimaryborrowernontaxableincomeamount_isnull = false;
			}
			// assigns the VAPrimaryBorrowerTaxableIncomeAmount data to the class member
			if (data["VAPrimaryBorrowerTaxableIncomeAmount"] == System.DBNull.Value)
				SetVAPrimaryBorrowerTaxableIncomeAmountNull();
			else
			{
				_vaprimaryborrowertaxableincomeamount = Convert.ToDecimal(data["VAPrimaryBorrowerTaxableIncomeAmount"]);
				_vaprimaryborrowertaxableincomeamount_isnull = false;
			}
			// assigns the VASocialSecurityTaxAmount data to the class member
			if (data["VASocialSecurityTaxAmount"] == System.DBNull.Value)
				SetVASocialSecurityTaxAmountNull();
			else
			{
				_vasocialsecuritytaxamount = Convert.ToDecimal(data["VASocialSecurityTaxAmount"]);
				_vasocialsecuritytaxamount_isnull = false;
			}
			// assigns the VAStateTaxAmount data to the class member
			if (data["VAStateTaxAmount"] == System.DBNull.Value)
				SetVAStateTaxAmountNull();
			else
			{
				_vastatetaxamount = Convert.ToDecimal(data["VAStateTaxAmount"]);
				_vastatetaxamount_isnull = false;
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
			// assigns the VACoBorrowerNonTaxableIncomeAmount data to the class member
			if (data["VACoBorrowerNonTaxableIncomeAmount"] == System.DBNull.Value)
				SetVACoBorrowerNonTaxableIncomeAmountNull();
			else
			{
				_vacoborrowernontaxableincomeamount = Convert.ToDecimal(data["VACoBorrowerNonTaxableIncomeAmount"]);
				_vacoborrowernontaxableincomeamount_isnull = false;
			}
			// assigns the VACoBorrowerTaxableIncomeAmount data to the class member
			if (data["VACoBorrowerTaxableIncomeAmount"] == System.DBNull.Value)
				SetVACoBorrowerTaxableIncomeAmountNull();
			else
			{
				_vacoborrowertaxableincomeamount = Convert.ToDecimal(data["VACoBorrowerTaxableIncomeAmount"]);
				_vacoborrowertaxableincomeamount_isnull = false;
			}
			// assigns the VAFederalTaxAmount data to the class member
			if (data["VAFederalTaxAmount"] == System.DBNull.Value)
				SetVAFederalTaxAmountNull();
			else
			{
				_vafederaltaxamount = Convert.ToDecimal(data["VAFederalTaxAmount"]);
				_vafederaltaxamount_isnull = false;
			}
			// assigns the VALocalTaxAmount data to the class member
			if (data["VALocalTaxAmount"] == System.DBNull.Value)
				SetVALocalTaxAmountNull();
			else
			{
				_valocaltaxamount = Convert.ToDecimal(data["VALocalTaxAmount"]);
				_valocaltaxamount_isnull = false;
			}
			// assigns the VAPrimaryBorrowerNonTaxableIncomeAmount data to the class member
			if (data["VAPrimaryBorrowerNonTaxableIncomeAmount"] == System.DBNull.Value)
				SetVAPrimaryBorrowerNonTaxableIncomeAmountNull();
			else
			{
				_vaprimaryborrowernontaxableincomeamount = Convert.ToDecimal(data["VAPrimaryBorrowerNonTaxableIncomeAmount"]);
				_vaprimaryborrowernontaxableincomeamount_isnull = false;
			}
			// assigns the VAPrimaryBorrowerTaxableIncomeAmount data to the class member
			if (data["VAPrimaryBorrowerTaxableIncomeAmount"] == System.DBNull.Value)
				SetVAPrimaryBorrowerTaxableIncomeAmountNull();
			else
			{
				_vaprimaryborrowertaxableincomeamount = Convert.ToDecimal(data["VAPrimaryBorrowerTaxableIncomeAmount"]);
				_vaprimaryborrowertaxableincomeamount_isnull = false;
			}
			// assigns the VASocialSecurityTaxAmount data to the class member
			if (data["VASocialSecurityTaxAmount"] == System.DBNull.Value)
				SetVASocialSecurityTaxAmountNull();
			else
			{
				_vasocialsecuritytaxamount = Convert.ToDecimal(data["VASocialSecurityTaxAmount"]);
				_vasocialsecuritytaxamount_isnull = false;
			}
			// assigns the VAStateTaxAmount data to the class member
			if (data["VAStateTaxAmount"] == System.DBNull.Value)
				SetVAStateTaxAmountNull();
			else
			{
				_vastatetaxamount = Convert.ToDecimal(data["VAStateTaxAmount"]);
				_vastatetaxamount_isnull = false;
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
			VABorrowerBase.ServiceObject.Persist(this as VABorrower, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the VA_BORROWER object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			VABorrowerBase.ServiceObject.Delete(this as VABorrower);


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
		/// Gets all persisted VABorrower objects
		/// </summary>
		public static VABorrowers GetAll()
		{
			// have the service object get the objects
			return VABorrowerBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
