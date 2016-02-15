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
	/// A class that represents an abstract entity for table 'PRESENT_HOUSING_EXPENSE'
	/// </summary>
	[Serializable]
	public abstract class PresentHousingExpenseBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PresentHousingExpenseBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.PresentHousingExpense)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public PresentHousingExpenseBase(System.Int64 id)
		{
			// Fill this instance.
			PresentHousingExpenseBase.ServiceObject.Fill(this as PresentHousingExpense, id);
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
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _paymentamount_assigned = false;
		/// <summary>
		/// Member that stores the value for the paymentamount.
		/// </summary>
		internal System.Decimal _paymentamount;
		/// <summary>
		/// Gets and sets the PaymentAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PaymentAmount
		{
			get
			{
				return _paymentamount;
			}
			set
			{
				_paymentamount = value;
				_paymentamount_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _housingexpensetype_assigned = false;
		/// <summary>
		/// Member that stores the value for the housingexpensetype.
		/// </summary>
		internal System.Int16 _housingexpensetype;
		/// <summary>
		/// Gets and sets the HousingExpenseType value of the class instance.
		/// </summary>
		public virtual System.Int16 HousingExpenseType
		{
			get
			{
				return _housingexpensetype;
			}
			set
			{
				_housingexpensetype = value;
				_housingexpensetype_assigned = true;
			}
		}


		/// <summary>
		/// Gets the service object for the PresentHousingExpenseBase.
		/// </summary>
		internal static PresentHousingExpenseService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(PresentHousingExpenseService)) as PresentHousingExpenseService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of PresentHousingExpenseBase. The value has not been explicitly assigned.", exceptions);
				if (!_paymentamount_assigned) exceptions = BusinessLogic.ChainException("PaymentAmount is a required value of PresentHousingExpenseBase. The value has not been explicitly assigned.", exceptions);
				if (!_housingexpensetype_assigned) exceptions = BusinessLogic.ChainException("HousingExpenseType is a required value of PresentHousingExpenseBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref PresentHousingExpenseBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the PaymentAmount data to the class member
			_paymentamount = data._paymentamount;
			_paymentamount_assigned = data._paymentamount_assigned;
			// assigns the HousingExpenseType data to the class member
			_housingexpensetype = data._housingexpensetype;
			_housingexpensetype_assigned = data._housingexpensetype_assigned;


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
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the PaymentAmount data to the class member
			_paymentamount = Convert.ToDecimal(data["PaymentAmount"]);
			_paymentamount_assigned = true;
			// assigns the HousingExpenseType data to the class member
			_housingexpensetype = Convert.ToInt16(data["HousingExpenseType"]);
			_housingexpensetype_assigned = true;


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
			_borrowerid = Convert.ToInt64(data["BorrowerId"]);
			_borrowerid_assigned = true;
			// assigns the PaymentAmount data to the class member
			_paymentamount = Convert.ToDecimal(data["PaymentAmount"]);
			_paymentamount_assigned = true;
			// assigns the HousingExpenseType data to the class member
			_housingexpensetype = Convert.ToInt16(data["HousingExpenseType"]);
			_housingexpensetype_assigned = true;


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
			PresentHousingExpenseBase.ServiceObject.Persist(this as PresentHousingExpense, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the PRESENT_HOUSING_EXPENSE object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			PresentHousingExpenseBase.ServiceObject.Delete(this as PresentHousingExpense);


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
		/// Gets the single object for the HousingExpenseType relationship.
		/// </summary>
		public HousingExpenseType GetHousingExpenseType()
		{
			if (_housingexpensetype_assigned)
				return null;
			else
				return new HousingExpenseType(_housingexpensetype);
		}


		/// <summary>
		/// Gets all persisted PresentHousingExpense objects
		/// </summary>
		public static PresentHousingExpenses GetAll()
		{
			// have the service object get the objects
			return PresentHousingExpenseBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
