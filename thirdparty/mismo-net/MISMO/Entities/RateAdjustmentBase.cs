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
	/// A class that represents an abstract entity for table 'RATE_ADJUSTMENT'
	/// </summary>
	[Serializable]
	public abstract class RateAdjustmentBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public RateAdjustmentBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.RateAdjustment)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public RateAdjustmentBase(System.Int64 id)
		{
			// Fill this instance.
			RateAdjustmentBase.ServiceObject.Fill(this as RateAdjustment, id);
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
		internal bool _firstrateadjustmentmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the firstrateadjustmentmonths.
		/// </summary>
		internal System.Decimal _firstrateadjustmentmonths;
		/// <summary>
		/// Gets and sets the FirstRateAdjustmentMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal FirstRateAdjustmentMonths
		{
			get
			{
				return _firstrateadjustmentmonths;
			}
			set
			{
				_firstrateadjustmentmonths = value;
				_firstrateadjustmentmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FirstRateAdjustmentMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean FirstRateAdjustmentMonthsIsNull
		{
			get
			{
				return _firstrateadjustmentmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _calculationtype_assigned = false;
		/// <summary>
		/// Member that stores the value for the calculationtype.
		/// </summary>
		internal System.Int16 _calculationtype;
		/// <summary>
		/// Gets and sets the CalculationType value of the class instance.
		/// </summary>
		public virtual System.Int16 CalculationType
		{
			get
			{
				return _calculationtype;
			}
			set
			{
				_calculationtype = value;
				_calculationtype_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _durationmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the durationmonths.
		/// </summary>
		internal System.Decimal _durationmonths;
		/// <summary>
		/// Gets and sets the DurationMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal DurationMonths
		{
			get
			{
				return _durationmonths;
			}
			set
			{
				_durationmonths = value;
				_durationmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the DurationMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean DurationMonthsIsNull
		{
			get
			{
				return _durationmonths_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _percent_isnull = true;
		/// <summary>
		/// Member that stores the value for the percent.
		/// </summary>
		internal System.Decimal _percent;
		/// <summary>
		/// Gets and sets the Percent value of the class instance.
		/// </summary>
		public virtual System.Decimal Percent
		{
			get
			{
				return _percent;
			}
			set
			{
				_percent = value;
				_percent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the Percent value to see if it was set to null.
		/// </summary>
		public System.Boolean PercentIsNull
		{
			get
			{
				return _percent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _periodnumber_isnull = true;
		/// <summary>
		/// Member that stores the value for the periodnumber.
		/// </summary>
		internal System.Decimal _periodnumber;
		/// <summary>
		/// Gets and sets the PeriodNumber value of the class instance.
		/// </summary>
		public virtual System.Decimal PeriodNumber
		{
			get
			{
				return _periodnumber;
			}
			set
			{
				_periodnumber = value;
				_periodnumber_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PeriodNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean PeriodNumberIsNull
		{
			get
			{
				return _periodnumber_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _subsequentcappercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the subsequentcappercent.
		/// </summary>
		internal System.Decimal _subsequentcappercent;
		/// <summary>
		/// Gets and sets the SubsequentCapPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal SubsequentCapPercent
		{
			get
			{
				return _subsequentcappercent;
			}
			set
			{
				_subsequentcappercent = value;
				_subsequentcappercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SubsequentCapPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean SubsequentCapPercentIsNull
		{
			get
			{
				return _subsequentcappercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _subsequentrateadjustmentmonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the subsequentrateadjustmentmonths.
		/// </summary>
		internal System.Decimal _subsequentrateadjustmentmonths;
		/// <summary>
		/// Gets and sets the SubsequentRateAdjustmentMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal SubsequentRateAdjustmentMonths
		{
			get
			{
				return _subsequentrateadjustmentmonths;
			}
			set
			{
				_subsequentrateadjustmentmonths = value;
				_subsequentrateadjustmentmonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SubsequentRateAdjustmentMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean SubsequentRateAdjustmentMonthsIsNull
		{
			get
			{
				return _subsequentrateadjustmentmonths_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the RateAdjustmentBase.
		/// </summary>
		internal static RateAdjustmentService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(RateAdjustmentService)) as RateAdjustmentService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of RateAdjustmentBase. The value has not been explicitly assigned.", exceptions);
				if (!_calculationtype_assigned) exceptions = BusinessLogic.ChainException("CalculationType is a required value of RateAdjustmentBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the FirstRateAdjustmentMonths value as null.
		/// </summary>
		public virtual void SetFirstRateAdjustmentMonthsNull()
		{
			_firstrateadjustmentmonths = 0;
			_firstrateadjustmentmonths_isnull = true;
		}


		/// <summary>
		/// Marks the DurationMonths value as null.
		/// </summary>
		public virtual void SetDurationMonthsNull()
		{
			_durationmonths = 0;
			_durationmonths_isnull = true;
		}


		/// <summary>
		/// Marks the Percent value as null.
		/// </summary>
		public virtual void SetPercentNull()
		{
			_percent = 0;
			_percent_isnull = true;
		}


		/// <summary>
		/// Marks the PeriodNumber value as null.
		/// </summary>
		public virtual void SetPeriodNumberNull()
		{
			_periodnumber = 0;
			_periodnumber_isnull = true;
		}


		/// <summary>
		/// Marks the SubsequentCapPercent value as null.
		/// </summary>
		public virtual void SetSubsequentCapPercentNull()
		{
			_subsequentcappercent = 0;
			_subsequentcappercent_isnull = true;
		}


		/// <summary>
		/// Marks the SubsequentRateAdjustmentMonths value as null.
		/// </summary>
		public virtual void SetSubsequentRateAdjustmentMonthsNull()
		{
			_subsequentrateadjustmentmonths = 0;
			_subsequentrateadjustmentmonths_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref RateAdjustmentBase data)
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
			// assigns the FirstRateAdjustmentMonths data to the class member
			_firstrateadjustmentmonths = data._firstrateadjustmentmonths;
			_firstrateadjustmentmonths_isnull = data._firstrateadjustmentmonths_isnull;
			// assigns the CalculationType data to the class member
			_calculationtype = data._calculationtype;
			_calculationtype_assigned = data._calculationtype_assigned;
			// assigns the DurationMonths data to the class member
			_durationmonths = data._durationmonths;
			_durationmonths_isnull = data._durationmonths_isnull;
			// assigns the Percent data to the class member
			_percent = data._percent;
			_percent_isnull = data._percent_isnull;
			// assigns the PeriodNumber data to the class member
			_periodnumber = data._periodnumber;
			_periodnumber_isnull = data._periodnumber_isnull;
			// assigns the SubsequentCapPercent data to the class member
			_subsequentcappercent = data._subsequentcappercent;
			_subsequentcappercent_isnull = data._subsequentcappercent_isnull;
			// assigns the SubsequentRateAdjustmentMonths data to the class member
			_subsequentrateadjustmentmonths = data._subsequentrateadjustmentmonths;
			_subsequentrateadjustmentmonths_isnull = data._subsequentrateadjustmentmonths_isnull;


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
			// assigns the FirstRateAdjustmentMonths data to the class member
			if (data["FirstRateAdjustmentMonths"] == System.DBNull.Value)
				SetFirstRateAdjustmentMonthsNull();
			else
			{
				_firstrateadjustmentmonths = Convert.ToDecimal(data["FirstRateAdjustmentMonths"]);
				_firstrateadjustmentmonths_isnull = false;
			}
			// assigns the CalculationType data to the class member
			_calculationtype = Convert.ToInt16(data["CalculationType"]);
			_calculationtype_assigned = true;
			// assigns the DurationMonths data to the class member
			if (data["DurationMonths"] == System.DBNull.Value)
				SetDurationMonthsNull();
			else
			{
				_durationmonths = Convert.ToDecimal(data["DurationMonths"]);
				_durationmonths_isnull = false;
			}
			// assigns the Percent data to the class member
			if (data["Percent"] == System.DBNull.Value)
				SetPercentNull();
			else
			{
				_percent = Convert.ToDecimal(data["Percent"]);
				_percent_isnull = false;
			}
			// assigns the PeriodNumber data to the class member
			if (data["PeriodNumber"] == System.DBNull.Value)
				SetPeriodNumberNull();
			else
			{
				_periodnumber = Convert.ToDecimal(data["PeriodNumber"]);
				_periodnumber_isnull = false;
			}
			// assigns the SubsequentCapPercent data to the class member
			if (data["SubsequentCapPercent"] == System.DBNull.Value)
				SetSubsequentCapPercentNull();
			else
			{
				_subsequentcappercent = Convert.ToDecimal(data["SubsequentCapPercent"]);
				_subsequentcappercent_isnull = false;
			}
			// assigns the SubsequentRateAdjustmentMonths data to the class member
			if (data["SubsequentRateAdjustmentMonths"] == System.DBNull.Value)
				SetSubsequentRateAdjustmentMonthsNull();
			else
			{
				_subsequentrateadjustmentmonths = Convert.ToDecimal(data["SubsequentRateAdjustmentMonths"]);
				_subsequentrateadjustmentmonths_isnull = false;
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
			// assigns the FirstRateAdjustmentMonths data to the class member
			if (data["FirstRateAdjustmentMonths"] == System.DBNull.Value)
				SetFirstRateAdjustmentMonthsNull();
			else
			{
				_firstrateadjustmentmonths = Convert.ToDecimal(data["FirstRateAdjustmentMonths"]);
				_firstrateadjustmentmonths_isnull = false;
			}
			// assigns the CalculationType data to the class member
			_calculationtype = Convert.ToInt16(data["CalculationType"]);
			_calculationtype_assigned = true;
			// assigns the DurationMonths data to the class member
			if (data["DurationMonths"] == System.DBNull.Value)
				SetDurationMonthsNull();
			else
			{
				_durationmonths = Convert.ToDecimal(data["DurationMonths"]);
				_durationmonths_isnull = false;
			}
			// assigns the Percent data to the class member
			if (data["Percent"] == System.DBNull.Value)
				SetPercentNull();
			else
			{
				_percent = Convert.ToDecimal(data["Percent"]);
				_percent_isnull = false;
			}
			// assigns the PeriodNumber data to the class member
			if (data["PeriodNumber"] == System.DBNull.Value)
				SetPeriodNumberNull();
			else
			{
				_periodnumber = Convert.ToDecimal(data["PeriodNumber"]);
				_periodnumber_isnull = false;
			}
			// assigns the SubsequentCapPercent data to the class member
			if (data["SubsequentCapPercent"] == System.DBNull.Value)
				SetSubsequentCapPercentNull();
			else
			{
				_subsequentcappercent = Convert.ToDecimal(data["SubsequentCapPercent"]);
				_subsequentcappercent_isnull = false;
			}
			// assigns the SubsequentRateAdjustmentMonths data to the class member
			if (data["SubsequentRateAdjustmentMonths"] == System.DBNull.Value)
				SetSubsequentRateAdjustmentMonthsNull();
			else
			{
				_subsequentrateadjustmentmonths = Convert.ToDecimal(data["SubsequentRateAdjustmentMonths"]);
				_subsequentrateadjustmentmonths_isnull = false;
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
			RateAdjustmentBase.ServiceObject.Persist(this as RateAdjustment, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the RATE_ADJUSTMENT object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			RateAdjustmentBase.ServiceObject.Delete(this as RateAdjustment);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the LOAN_PRODUCT_DATA relationship.
		/// </summary>
		public LoanProductData GetLoanProductData()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new LoanProductData(_loanapplicationid);
		}


		/// <summary>
		/// Gets all persisted RateAdjustment objects
		/// </summary>
		public static RateAdjustments GetAll()
		{
			// have the service object get the objects
			return RateAdjustmentBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
