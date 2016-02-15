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
	/// A class that represents an abstract entity for table 'LOAN_QUALIFICATION'
	/// </summary>
	[Serializable]
	public abstract class LoanQualificationBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanQualificationBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.LoanQualification)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanQualificationBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			LoanQualificationBase.ServiceObject.Fill(this as LoanQualification, loanApplicationId);
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
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _additionalborrowerassetsnotconsideredindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the additionalborrowerassetsnotconsideredindicator.
		/// </summary>
		internal System.Boolean _additionalborrowerassetsnotconsideredindicator;
		/// <summary>
		/// Gets and sets the AdditionalBorrowerAssetsNotConsideredIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean AdditionalBorrowerAssetsNotConsideredIndicator
		{
			get
			{
				return _additionalborrowerassetsnotconsideredindicator;
			}
			set
			{
				_additionalborrowerassetsnotconsideredindicator = value;
				_additionalborrowerassetsnotconsideredindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _additionalborrowerassetsconsideredindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the additionalborrowerassetsconsideredindicator.
		/// </summary>
		internal System.Boolean _additionalborrowerassetsconsideredindicator;
		/// <summary>
		/// Gets and sets the AdditionalBorrowerAssetsConsideredIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean AdditionalBorrowerAssetsConsideredIndicator
		{
			get
			{
				return _additionalborrowerassetsconsideredindicator;
			}
			set
			{
				_additionalborrowerassetsconsideredindicator = value;
				_additionalborrowerassetsconsideredindicator_assigned = true;
			}
		}


		/// <summary>
		/// Gets the service object for the LoanQualificationBase.
		/// </summary>
		internal static LoanQualificationService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(LoanQualificationService)) as LoanQualificationService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of LoanQualificationBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref LoanQualificationBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the AdditionalBorrowerAssetsNotConsideredIndicator data to the class member
			_additionalborrowerassetsnotconsideredindicator = data._additionalborrowerassetsnotconsideredindicator;
			_additionalborrowerassetsnotconsideredindicator_assigned = data._additionalborrowerassetsnotconsideredindicator_assigned;
			// assigns the AdditionalBorrowerAssetsConsideredIndicator data to the class member
			_additionalborrowerassetsconsideredindicator = data._additionalborrowerassetsconsideredindicator;
			_additionalborrowerassetsconsideredindicator_assigned = data._additionalborrowerassetsconsideredindicator_assigned;


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
			// assigns the AdditionalBorrowerAssetsNotConsideredIndicator data to the class member
			_additionalborrowerassetsnotconsideredindicator = Convert.ToBoolean(data["AdditionalBorrowerAssetsNotConsideredIndicator"]);
			_additionalborrowerassetsnotconsideredindicator_assigned = true;
			// assigns the AdditionalBorrowerAssetsConsideredIndicator data to the class member
			_additionalborrowerassetsconsideredindicator = Convert.ToBoolean(data["AdditionalBorrowerAssetsConsideredIndicator"]);
			_additionalborrowerassetsconsideredindicator_assigned = true;


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
			// assigns the AdditionalBorrowerAssetsNotConsideredIndicator data to the class member
			_additionalborrowerassetsnotconsideredindicator = Convert.ToBoolean(data["AdditionalBorrowerAssetsNotConsideredIndicator"]);
			_additionalborrowerassetsnotconsideredindicator_assigned = true;
			// assigns the AdditionalBorrowerAssetsConsideredIndicator data to the class member
			_additionalborrowerassetsconsideredindicator = Convert.ToBoolean(data["AdditionalBorrowerAssetsConsideredIndicator"]);
			_additionalborrowerassetsconsideredindicator_assigned = true;


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
			LoanQualificationBase.ServiceObject.Persist(this as LoanQualification, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the LOAN_QUALIFICATION object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			LoanQualificationBase.ServiceObject.Delete(this as LoanQualification);


			// Now call the base for it to do its own thing
			base.Delete();
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
		/// Gets all persisted LoanQualification objects
		/// </summary>
		public static LoanQualifications GetAll()
		{
			// have the service object get the objects
			return LoanQualificationBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
