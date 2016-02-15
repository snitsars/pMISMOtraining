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
	/// A class that represents an abstract entity for table 'SUMMARY'
	/// </summary>
	[Serializable]
	public abstract class SummaryBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public SummaryBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Summary)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public SummaryBase(System.Int64 id)
		{
			// Fill this instance.
			SummaryBase.ServiceObject.Fill(this as Summary, id);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _id_assigned = false;
		/// <summary>
		/// Member that stores the value for the id.
		/// </summary>
		internal System.Int64 _id;
		/// <summary>
		/// Gets and sets the Id value of the class instance.
		/// </summary>
		public virtual System.Int64 Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
				_id_assigned = true;
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _amount_isnull = true;
		/// <summary>
		/// Member that stores the value for the amount.
		/// </summary>
		internal System.Decimal _amount;
		/// <summary>
		/// Gets and sets the Amount value of the class instance.
		/// </summary>
		public virtual System.Decimal Amount
		{
			get
			{
				return _amount;
			}
			set
			{
				_amount = value;
				_amount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the Amount value to see if it was set to null.
		/// </summary>
		public System.Boolean AmountIsNull
		{
			get
			{
				return _amount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _amounttype_isnull = true;
		/// <summary>
		/// Member that stores the value for the amounttype.
		/// </summary>
		internal System.Int16 _amounttype;
		/// <summary>
		/// Gets and sets the AmountType value of the class instance.
		/// </summary>
		public virtual System.Int16 AmountType
		{
			get
			{
				return _amounttype;
			}
			set
			{
				_amounttype = value;
				_amounttype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AmountType value to see if it was set to null.
		/// </summary>
		public System.Boolean AmountTypeIsNull
		{
			get
			{
				return _amounttype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the SummaryBase.
		/// </summary>
		internal static SummaryService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(SummaryService)) as SummaryService;
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


				if (!_id_assigned) exceptions = BusinessLogic.ChainException("Id is a required value of SummaryBase. The value has not been explicitly assigned.", exceptions);


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
		/// Marks the Amount value as null.
		/// </summary>
		public virtual void SetAmountNull()
		{
			_amount = 0;
			_amount_isnull = true;
		}


		/// <summary>
		/// Marks the AmountType value as null.
		/// </summary>
		public virtual void SetAmountTypeNull()
		{
			_amounttype = 0;
			_amounttype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref SummaryBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			_id_assigned = data._id_assigned;
			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_isnull = data._borrowerid_isnull;
			// assigns the Amount data to the class member
			_amount = data._amount;
			_amount_isnull = data._amount_isnull;
			// assigns the AmountType data to the class member
			_amounttype = data._amounttype;
			_amounttype_isnull = data._amounttype_isnull;


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
			_id_assigned = true;
			// assigns the BorrowerId data to the class member
			if (data["BorrowerId"] == System.DBNull.Value)
				SetBorrowerIdNull();
			else
			{
				_borrowerid = Convert.ToInt64(data["BorrowerId"]);
				_borrowerid_isnull = false;
			}
			// assigns the Amount data to the class member
			if (data["Amount"] == System.DBNull.Value)
				SetAmountNull();
			else
			{
				_amount = Convert.ToDecimal(data["Amount"]);
				_amount_isnull = false;
			}
			// assigns the AmountType data to the class member
			if (data["AmountType"] == System.DBNull.Value)
				SetAmountTypeNull();
			else
			{
				_amounttype = Convert.ToInt16(data["AmountType"]);
				_amounttype_isnull = false;
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
			_id_assigned = true;
			// assigns the BorrowerId data to the class member
			if (data["BorrowerId"] == System.DBNull.Value)
				SetBorrowerIdNull();
			else
			{
				_borrowerid = Convert.ToInt64(data["BorrowerId"]);
				_borrowerid_isnull = false;
			}
			// assigns the Amount data to the class member
			if (data["Amount"] == System.DBNull.Value)
				SetAmountNull();
			else
			{
				_amount = Convert.ToDecimal(data["Amount"]);
				_amount_isnull = false;
			}
			// assigns the AmountType data to the class member
			if (data["AmountType"] == System.DBNull.Value)
				SetAmountTypeNull();
			else
			{
				_amounttype = Convert.ToInt16(data["AmountType"]);
				_amounttype_isnull = false;
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
			SummaryBase.ServiceObject.Persist(this as Summary, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the SUMMARY object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			SummaryBase.ServiceObject.Delete(this as Summary);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the SummaryAmountType relationship.
		/// </summary>
		public SummaryAmountType GetSummaryAmountType()
		{
			if (_amounttype_isnull)
				return null;
			else
				return new SummaryAmountType(_amounttype);
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
		/// Gets all persisted Summary objects
		/// </summary>
		public static Summaries GetAll()
		{
			// have the service object get the objects
			return SummaryBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
