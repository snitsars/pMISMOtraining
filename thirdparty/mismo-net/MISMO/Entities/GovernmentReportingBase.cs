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
	/// A class that represents an abstract entity for table 'GOVERNMENT_REPORTING'
	/// </summary>
	[Serializable]
	public abstract class GovernmentReportingBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentReportingBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.GovernmentReporting)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public GovernmentReportingBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			GovernmentReportingBase.ServiceObject.Fill(this as GovernmentReporting, loanApplicationId);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hmdapurposeofloantype_isnull = true;
		/// <summary>
		/// Member that stores the value for the hmdapurposeofloantype.
		/// </summary>
		internal System.Int16 _hmdapurposeofloantype;
		/// <summary>
		/// Gets and sets the HMDAPurposeOfLoanType value of the class instance.
		/// </summary>
		public virtual System.Int16 HMDAPurposeOfLoanType
		{
			get
			{
				return _hmdapurposeofloantype;
			}
			set
			{
				_hmdapurposeofloantype = value;
				_hmdapurposeofloantype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HMDAPurposeOfLoanType value to see if it was set to null.
		/// </summary>
		public System.Boolean HMDAPurposeOfLoanTypeIsNull
		{
			get
			{
				return _hmdapurposeofloantype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hmdapreapprovaltype_isnull = true;
		/// <summary>
		/// Member that stores the value for the hmdapreapprovaltype.
		/// </summary>
		internal System.Int16 _hmdapreapprovaltype;
		/// <summary>
		/// Gets and sets the HMDAPreapprovalType value of the class instance.
		/// </summary>
		public virtual System.Int16 HMDAPreapprovalType
		{
			get
			{
				return _hmdapreapprovaltype;
			}
			set
			{
				_hmdapreapprovaltype = value;
				_hmdapreapprovaltype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HMDAPreapprovalType value to see if it was set to null.
		/// </summary>
		public System.Boolean HMDAPreapprovalTypeIsNull
		{
			get
			{
				return _hmdapreapprovaltype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _hmda_hoepaloanstatusindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the hmda_hoepaloanstatusindicator.
		/// </summary>
		internal System.Boolean _hmda_hoepaloanstatusindicator;
		/// <summary>
		/// Gets and sets the HMDA_HOEPALoanStatusIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean HMDA_HOEPALoanStatusIndicator
		{
			get
			{
				return _hmda_hoepaloanstatusindicator;
			}
			set
			{
				_hmda_hoepaloanstatusindicator = value;
				_hmda_hoepaloanstatusindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hmdaratespreadpercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the hmdaratespreadpercent.
		/// </summary>
		internal System.Decimal _hmdaratespreadpercent;
		/// <summary>
		/// Gets and sets the HMDARateSpreadPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal HMDARateSpreadPercent
		{
			get
			{
				return _hmdaratespreadpercent;
			}
			set
			{
				_hmdaratespreadpercent = value;
				_hmdaratespreadpercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HMDARateSpreadPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean HMDARateSpreadPercentIsNull
		{
			get
			{
				return _hmdaratespreadpercent_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the GovernmentReportingBase.
		/// </summary>
		internal static GovernmentReportingService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(GovernmentReportingService)) as GovernmentReportingService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of GovernmentReportingBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the HMDAPurposeOfLoanType value as null.
		/// </summary>
		public virtual void SetHMDAPurposeOfLoanTypeNull()
		{
			_hmdapurposeofloantype = 0;
			_hmdapurposeofloantype_isnull = true;
		}


		/// <summary>
		/// Marks the HMDAPreapprovalType value as null.
		/// </summary>
		public virtual void SetHMDAPreapprovalTypeNull()
		{
			_hmdapreapprovaltype = 0;
			_hmdapreapprovaltype_isnull = true;
		}


		/// <summary>
		/// Marks the HMDARateSpreadPercent value as null.
		/// </summary>
		public virtual void SetHMDARateSpreadPercentNull()
		{
			_hmdaratespreadpercent = 0;
			_hmdaratespreadpercent_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref GovernmentReportingBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the HMDAPurposeOfLoanType data to the class member
			_hmdapurposeofloantype = data._hmdapurposeofloantype;
			_hmdapurposeofloantype_isnull = data._hmdapurposeofloantype_isnull;
			// assigns the HMDAPreapprovalType data to the class member
			_hmdapreapprovaltype = data._hmdapreapprovaltype;
			_hmdapreapprovaltype_isnull = data._hmdapreapprovaltype_isnull;
			// assigns the HMDA_HOEPALoanStatusIndicator data to the class member
			_hmda_hoepaloanstatusindicator = data._hmda_hoepaloanstatusindicator;
			_hmda_hoepaloanstatusindicator_assigned = data._hmda_hoepaloanstatusindicator_assigned;
			// assigns the HMDARateSpreadPercent data to the class member
			_hmdaratespreadpercent = data._hmdaratespreadpercent;
			_hmdaratespreadpercent_isnull = data._hmdaratespreadpercent_isnull;


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
			// assigns the HMDAPurposeOfLoanType data to the class member
			if (data["HMDAPurposeOfLoanType"] == System.DBNull.Value)
				SetHMDAPurposeOfLoanTypeNull();
			else
			{
				_hmdapurposeofloantype = Convert.ToInt16(data["HMDAPurposeOfLoanType"]);
				_hmdapurposeofloantype_isnull = false;
			}
			// assigns the HMDAPreapprovalType data to the class member
			if (data["HMDAPreapprovalType"] == System.DBNull.Value)
				SetHMDAPreapprovalTypeNull();
			else
			{
				_hmdapreapprovaltype = Convert.ToInt16(data["HMDAPreapprovalType"]);
				_hmdapreapprovaltype_isnull = false;
			}
			// assigns the HMDA_HOEPALoanStatusIndicator data to the class member
			_hmda_hoepaloanstatusindicator = Convert.ToBoolean(data["HMDA_HOEPALoanStatusIndicator"]);
			_hmda_hoepaloanstatusindicator_assigned = true;
			// assigns the HMDARateSpreadPercent data to the class member
			if (data["HMDARateSpreadPercent"] == System.DBNull.Value)
				SetHMDARateSpreadPercentNull();
			else
			{
				_hmdaratespreadpercent = Convert.ToDecimal(data["HMDARateSpreadPercent"]);
				_hmdaratespreadpercent_isnull = false;
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
			// assigns the HMDAPurposeOfLoanType data to the class member
			if (data["HMDAPurposeOfLoanType"] == System.DBNull.Value)
				SetHMDAPurposeOfLoanTypeNull();
			else
			{
				_hmdapurposeofloantype = Convert.ToInt16(data["HMDAPurposeOfLoanType"]);
				_hmdapurposeofloantype_isnull = false;
			}
			// assigns the HMDAPreapprovalType data to the class member
			if (data["HMDAPreapprovalType"] == System.DBNull.Value)
				SetHMDAPreapprovalTypeNull();
			else
			{
				_hmdapreapprovaltype = Convert.ToInt16(data["HMDAPreapprovalType"]);
				_hmdapreapprovaltype_isnull = false;
			}
			// assigns the HMDA_HOEPALoanStatusIndicator data to the class member
			_hmda_hoepaloanstatusindicator = Convert.ToBoolean(data["HMDA_HOEPALoanStatusIndicator"]);
			_hmda_hoepaloanstatusindicator_assigned = true;
			// assigns the HMDARateSpreadPercent data to the class member
			if (data["HMDARateSpreadPercent"] == System.DBNull.Value)
				SetHMDARateSpreadPercentNull();
			else
			{
				_hmdaratespreadpercent = Convert.ToDecimal(data["HMDARateSpreadPercent"]);
				_hmdaratespreadpercent_isnull = false;
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
			GovernmentReportingBase.ServiceObject.Persist(this as GovernmentReporting, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the GOVERNMENT_REPORTING object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			GovernmentReportingBase.ServiceObject.Delete(this as GovernmentReporting);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the HMDAPreapprovalType relationship.
		/// </summary>
		public HMDAPreapprovalType GetHMDAPreapprovalType()
		{
			if (_hmdapreapprovaltype_isnull)
				return null;
			else
				return new HMDAPreapprovalType(_hmdapreapprovaltype);
		}


		/// <summary>
		/// Gets the single object for the HMDAPurposeOfLoanType relationship.
		/// </summary>
		public HMDAPurposeOfLoanType GetHMDAPurposeOfLoanType()
		{
			if (_hmdapurposeofloantype_isnull)
				return null;
			else
				return new HMDAPurposeOfLoanType(_hmdapurposeofloantype);
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
		/// Gets all persisted GovernmentReporting objects
		/// </summary>
		public static GovernmentReportingCollection GetAll()
		{
			// have the service object get the objects
			return GovernmentReportingBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
