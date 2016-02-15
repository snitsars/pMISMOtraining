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
	/// A class that represents an abstract entity for table 'BUYDOWN'
	/// </summary>
	[Serializable]
	public abstract class BuydownBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BuydownBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Buydown)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public BuydownBase(System.Int64 id)
		{
			// Fill this instance.
			BuydownBase.ServiceObject.Fill(this as Buydown, id);
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
		internal bool _changefrequencymonths_isnull = true;
		/// <summary>
		/// Member that stores the value for the changefrequencymonths.
		/// </summary>
		internal System.Decimal _changefrequencymonths;
		/// <summary>
		/// Gets and sets the ChangeFrequencyMonths value of the class instance.
		/// </summary>
		public virtual System.Decimal ChangeFrequencyMonths
		{
			get
			{
				return _changefrequencymonths;
			}
			set
			{
				_changefrequencymonths = value;
				_changefrequencymonths_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ChangeFrequencyMonths value to see if it was set to null.
		/// </summary>
		public System.Boolean ChangeFrequencyMonthsIsNull
		{
			get
			{
				return _changefrequencymonths_isnull;
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
		internal bool _increaseratepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the increaseratepercent.
		/// </summary>
		internal System.Decimal _increaseratepercent;
		/// <summary>
		/// Gets and sets the IncreaseRatePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal IncreaseRatePercent
		{
			get
			{
				return _increaseratepercent;
			}
			set
			{
				_increaseratepercent = value;
				_increaseratepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the IncreaseRatePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean IncreaseRatePercentIsNull
		{
			get
			{
				return _increaseratepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _lenderfundingindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the lenderfundingindicator.
		/// </summary>
		internal System.Boolean _lenderfundingindicator;
		/// <summary>
		/// Gets and sets the LenderFundingIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean LenderFundingIndicator
		{
			get
			{
				return _lenderfundingindicator;
			}
			set
			{
				_lenderfundingindicator = value;
				_lenderfundingindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _permanentindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the permanentindicator.
		/// </summary>
		internal System.Boolean _permanentindicator;
		/// <summary>
		/// Gets and sets the PermanentIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PermanentIndicator
		{
			get
			{
				return _permanentindicator;
			}
			set
			{
				_permanentindicator = value;
				_permanentindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _basedatatype_isnull = true;
		/// <summary>
		/// Member that stores the value for the basedatatype.
		/// </summary>
		internal System.Int16 _basedatatype;
		/// <summary>
		/// Gets and sets the BaseDataType value of the class instance.
		/// </summary>
		public virtual System.Int16 BaseDataType
		{
			get
			{
				return _basedatatype;
			}
			set
			{
				_basedatatype = value;
				_basedatatype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BaseDataType value to see if it was set to null.
		/// </summary>
		public System.Boolean BaseDataTypeIsNull
		{
			get
			{
				return _basedatatype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _contributortype_isnull = true;
		/// <summary>
		/// Member that stores the value for the contributortype.
		/// </summary>
		internal System.Int16 _contributortype;
		/// <summary>
		/// Gets and sets the ContributorType value of the class instance.
		/// </summary>
		public virtual System.Int16 ContributorType
		{
			get
			{
				return _contributortype;
			}
			set
			{
				_contributortype = value;
				_contributortype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ContributorType value to see if it was set to null.
		/// </summary>
		public System.Boolean ContributorTypeIsNull
		{
			get
			{
				return _contributortype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the BuydownBase.
		/// </summary>
		internal static BuydownService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(BuydownService)) as BuydownService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of BuydownBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the ChangeFrequencyMonths value as null.
		/// </summary>
		public virtual void SetChangeFrequencyMonthsNull()
		{
			_changefrequencymonths = 0;
			_changefrequencymonths_isnull = true;
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
		/// Marks the IncreaseRatePercent value as null.
		/// </summary>
		public virtual void SetIncreaseRatePercentNull()
		{
			_increaseratepercent = 0;
			_increaseratepercent_isnull = true;
		}


		/// <summary>
		/// Marks the BaseDataType value as null.
		/// </summary>
		public virtual void SetBaseDataTypeNull()
		{
			_basedatatype = 0;
			_basedatatype_isnull = true;
		}


		/// <summary>
		/// Marks the ContributorType value as null.
		/// </summary>
		public virtual void SetContributorTypeNull()
		{
			_contributortype = 0;
			_contributortype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref BuydownBase data)
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
			// assigns the ChangeFrequencyMonths data to the class member
			_changefrequencymonths = data._changefrequencymonths;
			_changefrequencymonths_isnull = data._changefrequencymonths_isnull;
			// assigns the DurationMonths data to the class member
			_durationmonths = data._durationmonths;
			_durationmonths_isnull = data._durationmonths_isnull;
			// assigns the IncreaseRatePercent data to the class member
			_increaseratepercent = data._increaseratepercent;
			_increaseratepercent_isnull = data._increaseratepercent_isnull;
			// assigns the LenderFundingIndicator data to the class member
			_lenderfundingindicator = data._lenderfundingindicator;
			_lenderfundingindicator_assigned = data._lenderfundingindicator_assigned;
			// assigns the PermanentIndicator data to the class member
			_permanentindicator = data._permanentindicator;
			_permanentindicator_assigned = data._permanentindicator_assigned;
			// assigns the BaseDataType data to the class member
			_basedatatype = data._basedatatype;
			_basedatatype_isnull = data._basedatatype_isnull;
			// assigns the ContributorType data to the class member
			_contributortype = data._contributortype;
			_contributortype_isnull = data._contributortype_isnull;


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
			// assigns the ChangeFrequencyMonths data to the class member
			if (data["ChangeFrequencyMonths"] == System.DBNull.Value)
				SetChangeFrequencyMonthsNull();
			else
			{
				_changefrequencymonths = Convert.ToDecimal(data["ChangeFrequencyMonths"]);
				_changefrequencymonths_isnull = false;
			}
			// assigns the DurationMonths data to the class member
			if (data["DurationMonths"] == System.DBNull.Value)
				SetDurationMonthsNull();
			else
			{
				_durationmonths = Convert.ToDecimal(data["DurationMonths"]);
				_durationmonths_isnull = false;
			}
			// assigns the IncreaseRatePercent data to the class member
			if (data["IncreaseRatePercent"] == System.DBNull.Value)
				SetIncreaseRatePercentNull();
			else
			{
				_increaseratepercent = Convert.ToDecimal(data["IncreaseRatePercent"]);
				_increaseratepercent_isnull = false;
			}
			// assigns the LenderFundingIndicator data to the class member
			_lenderfundingindicator = Convert.ToBoolean(data["LenderFundingIndicator"]);
			_lenderfundingindicator_assigned = true;
			// assigns the PermanentIndicator data to the class member
			_permanentindicator = Convert.ToBoolean(data["PermanentIndicator"]);
			_permanentindicator_assigned = true;
			// assigns the BaseDataType data to the class member
			if (data["BaseDataType"] == System.DBNull.Value)
				SetBaseDataTypeNull();
			else
			{
				_basedatatype = Convert.ToInt16(data["BaseDataType"]);
				_basedatatype_isnull = false;
			}
			// assigns the ContributorType data to the class member
			if (data["ContributorType"] == System.DBNull.Value)
				SetContributorTypeNull();
			else
			{
				_contributortype = Convert.ToInt16(data["ContributorType"]);
				_contributortype_isnull = false;
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
			// assigns the ChangeFrequencyMonths data to the class member
			if (data["ChangeFrequencyMonths"] == System.DBNull.Value)
				SetChangeFrequencyMonthsNull();
			else
			{
				_changefrequencymonths = Convert.ToDecimal(data["ChangeFrequencyMonths"]);
				_changefrequencymonths_isnull = false;
			}
			// assigns the DurationMonths data to the class member
			if (data["DurationMonths"] == System.DBNull.Value)
				SetDurationMonthsNull();
			else
			{
				_durationmonths = Convert.ToDecimal(data["DurationMonths"]);
				_durationmonths_isnull = false;
			}
			// assigns the IncreaseRatePercent data to the class member
			if (data["IncreaseRatePercent"] == System.DBNull.Value)
				SetIncreaseRatePercentNull();
			else
			{
				_increaseratepercent = Convert.ToDecimal(data["IncreaseRatePercent"]);
				_increaseratepercent_isnull = false;
			}
			// assigns the LenderFundingIndicator data to the class member
			_lenderfundingindicator = Convert.ToBoolean(data["LenderFundingIndicator"]);
			_lenderfundingindicator_assigned = true;
			// assigns the PermanentIndicator data to the class member
			_permanentindicator = Convert.ToBoolean(data["PermanentIndicator"]);
			_permanentindicator_assigned = true;
			// assigns the BaseDataType data to the class member
			if (data["BaseDataType"] == System.DBNull.Value)
				SetBaseDataTypeNull();
			else
			{
				_basedatatype = Convert.ToInt16(data["BaseDataType"]);
				_basedatatype_isnull = false;
			}
			// assigns the ContributorType data to the class member
			if (data["ContributorType"] == System.DBNull.Value)
				SetContributorTypeNull();
			else
			{
				_contributortype = Convert.ToInt16(data["ContributorType"]);
				_contributortype_isnull = false;
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
			BuydownBase.ServiceObject.Persist(this as Buydown, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the BUYDOWN object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			BuydownBase.ServiceObject.Delete(this as Buydown);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the BaseDataType relationship.
		/// </summary>
		public BaseDataType GetBaseDataType()
		{
			if (_basedatatype_isnull)
				return null;
			else
				return new BaseDataType(_basedatatype);
		}


		/// <summary>
		/// Gets the single object for the ContributorType relationship.
		/// </summary>
		public ContributorType GetContributorType()
		{
			if (_contributortype_isnull)
				return null;
			else
				return new ContributorType(_contributortype);
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
		/// Gets all persisted Buydown objects
		/// </summary>
		public static BuydownCollection GetAll()
		{
			// have the service object get the objects
			return BuydownBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
