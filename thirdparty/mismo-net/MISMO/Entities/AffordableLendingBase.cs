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
	/// A class that represents an abstract entity for table 'AFFORDABLE_LENDING'
	/// </summary>
	[Serializable]
	public abstract class AffordableLendingBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AffordableLendingBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.AffordableLending)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public AffordableLendingBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			AffordableLendingBase.ServiceObject.Fill(this as AffordableLending, loanApplicationId);
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
		/// Member that stores the value for the fnmcommunitylendingproductname.
		/// </summary>
		internal System.String _fnmcommunitylendingproductname;
		/// <summary>
		/// Gets and sets the FNMCommunityLendingProductName value of the class instance.
		/// </summary>
		public virtual System.String FNMCommunityLendingProductName
		{
			get
			{
				return _fnmcommunitylendingproductname;
			}
			set
			{
				_fnmcommunitylendingproductname = value;
			}
		}


		/// <summary>
		/// Checks the FNMCommunityLendingProductName value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMCommunityLendingProductNameIsNull
		{
			get
			{
				return (_fnmcommunitylendingproductname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the fnmcommunitylendingproducttypeotherdescription.
		/// </summary>
		internal System.String _fnmcommunitylendingproducttypeotherdescription;
		/// <summary>
		/// Gets and sets the FNMCommunityLendingProductTypeOtherDescription value of the class instance.
		/// </summary>
		public virtual System.String FNMCommunityLendingProductTypeOtherDescription
		{
			get
			{
				return _fnmcommunitylendingproducttypeotherdescription;
			}
			set
			{
				_fnmcommunitylendingproducttypeotherdescription = value;
			}
		}


		/// <summary>
		/// Checks the FNMCommunityLendingProductTypeOtherDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMCommunityLendingProductTypeOtherDescriptionIsNull
		{
			get
			{
				return (_fnmcommunitylendingproducttypeotherdescription == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _fnmcommunitysecondsindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the fnmcommunitysecondsindicator.
		/// </summary>
		internal System.Boolean _fnmcommunitysecondsindicator;
		/// <summary>
		/// Gets and sets the FNMCommunitySecondsIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean FNMCommunitySecondsIndicator
		{
			get
			{
				return _fnmcommunitysecondsindicator;
			}
			set
			{
				_fnmcommunitysecondsindicator = value;
				_fnmcommunitysecondsindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _fnmneighborsmortgageeligibilityindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the fnmneighborsmortgageeligibilityindicator.
		/// </summary>
		internal System.Boolean _fnmneighborsmortgageeligibilityindicator;
		/// <summary>
		/// Gets and sets the FNMNeighborsMortgageEligibilityIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean FNMNeighborsMortgageEligibilityIndicator
		{
			get
			{
				return _fnmneighborsmortgageeligibilityindicator;
			}
			set
			{
				_fnmneighborsmortgageeligibilityindicator = value;
				_fnmneighborsmortgageeligibilityindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the freaffordableprogramidentifier.
		/// </summary>
		internal System.String _freaffordableprogramidentifier;
		/// <summary>
		/// Gets and sets the FREAffordableProgramIdentifier value of the class instance.
		/// </summary>
		public virtual System.String FREAffordableProgramIdentifier
		{
			get
			{
				return _freaffordableprogramidentifier;
			}
			set
			{
				_freaffordableprogramidentifier = value;
			}
		}


		/// <summary>
		/// Checks the FREAffordableProgramIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean FREAffordableProgramIdentifierIsNull
		{
			get
			{
				return (_freaffordableprogramidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hudincomelimitadjustmentfactor_isnull = true;
		/// <summary>
		/// Member that stores the value for the hudincomelimitadjustmentfactor.
		/// </summary>
		internal System.Decimal _hudincomelimitadjustmentfactor;
		/// <summary>
		/// Gets and sets the HUDIncomeLimitAdjustmentFactor value of the class instance.
		/// </summary>
		public virtual System.Decimal HUDIncomeLimitAdjustmentFactor
		{
			get
			{
				return _hudincomelimitadjustmentfactor;
			}
			set
			{
				_hudincomelimitadjustmentfactor = value;
				_hudincomelimitadjustmentfactor_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HUDIncomeLimitAdjustmentFactor value to see if it was set to null.
		/// </summary>
		public System.Boolean HUDIncomeLimitAdjustmentFactorIsNull
		{
			get
			{
				return _hudincomelimitadjustmentfactor_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hudlendingincomelimitamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the hudlendingincomelimitamount.
		/// </summary>
		internal System.Decimal _hudlendingincomelimitamount;
		/// <summary>
		/// Gets and sets the HUDLendingIncomeLimitAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal HUDLendingIncomeLimitAmount
		{
			get
			{
				return _hudlendingincomelimitamount;
			}
			set
			{
				_hudlendingincomelimitamount = value;
				_hudlendingincomelimitamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HUDLendingIncomeLimitAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean HUDLendingIncomeLimitAmountIsNull
		{
			get
			{
				return _hudlendingincomelimitamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _hudmedianincomeamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the hudmedianincomeamount.
		/// </summary>
		internal System.Decimal _hudmedianincomeamount;
		/// <summary>
		/// Gets and sets the HUDMedianIncomeAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal HUDMedianIncomeAmount
		{
			get
			{
				return _hudmedianincomeamount;
			}
			set
			{
				_hudmedianincomeamount = value;
				_hudmedianincomeamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HUDMedianIncomeAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean HUDMedianIncomeAmountIsNull
		{
			get
			{
				return _hudmedianincomeamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the msaidentifier.
		/// </summary>
		internal System.String _msaidentifier;
		/// <summary>
		/// Gets and sets the MSAIdentifier value of the class instance.
		/// </summary>
		public virtual System.String MSAIdentifier
		{
			get
			{
				return _msaidentifier;
			}
			set
			{
				_msaidentifier = value;
			}
		}


		/// <summary>
		/// Checks the MSAIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean MSAIdentifierIsNull
		{
			get
			{
				return (_msaidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fnmcommunitylendingproducttype_isnull = true;
		/// <summary>
		/// Member that stores the value for the fnmcommunitylendingproducttype.
		/// </summary>
		internal System.Int16 _fnmcommunitylendingproducttype;
		/// <summary>
		/// Gets and sets the FNMCommunityLendingProductType value of the class instance.
		/// </summary>
		public virtual System.Int16 FNMCommunityLendingProductType
		{
			get
			{
				return _fnmcommunitylendingproducttype;
			}
			set
			{
				_fnmcommunitylendingproducttype = value;
				_fnmcommunitylendingproducttype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FNMCommunityLendingProductType value to see if it was set to null.
		/// </summary>
		public System.Boolean FNMCommunityLendingProductTypeIsNull
		{
			get
			{
				return _fnmcommunitylendingproducttype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the AffordableLendingBase.
		/// </summary>
		internal static AffordableLendingService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(AffordableLendingService)) as AffordableLendingService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of AffordableLendingBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the FNMCommunityLendingProductName value as null.
		/// </summary>
		public virtual void SetFNMCommunityLendingProductNameNull()
		{
			_fnmcommunitylendingproductname = null;
		}


		/// <summary>
		/// Marks the FNMCommunityLendingProductTypeOtherDescription value as null.
		/// </summary>
		public virtual void SetFNMCommunityLendingProductTypeOtherDescriptionNull()
		{
			_fnmcommunitylendingproducttypeotherdescription = null;
		}


		/// <summary>
		/// Marks the FREAffordableProgramIdentifier value as null.
		/// </summary>
		public virtual void SetFREAffordableProgramIdentifierNull()
		{
			_freaffordableprogramidentifier = null;
		}


		/// <summary>
		/// Marks the HUDIncomeLimitAdjustmentFactor value as null.
		/// </summary>
		public virtual void SetHUDIncomeLimitAdjustmentFactorNull()
		{
			_hudincomelimitadjustmentfactor = 0;
			_hudincomelimitadjustmentfactor_isnull = true;
		}


		/// <summary>
		/// Marks the HUDLendingIncomeLimitAmount value as null.
		/// </summary>
		public virtual void SetHUDLendingIncomeLimitAmountNull()
		{
			_hudlendingincomelimitamount = 0;
			_hudlendingincomelimitamount_isnull = true;
		}


		/// <summary>
		/// Marks the HUDMedianIncomeAmount value as null.
		/// </summary>
		public virtual void SetHUDMedianIncomeAmountNull()
		{
			_hudmedianincomeamount = 0;
			_hudmedianincomeamount_isnull = true;
		}


		/// <summary>
		/// Marks the MSAIdentifier value as null.
		/// </summary>
		public virtual void SetMSAIdentifierNull()
		{
			_msaidentifier = null;
		}


		/// <summary>
		/// Marks the FNMCommunityLendingProductType value as null.
		/// </summary>
		public virtual void SetFNMCommunityLendingProductTypeNull()
		{
			_fnmcommunitylendingproducttype = 0;
			_fnmcommunitylendingproducttype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref AffordableLendingBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the FNMCommunityLendingProductName data to the class member
			_fnmcommunitylendingproductname = data._fnmcommunitylendingproductname;
			// assigns the FNMCommunityLendingProductTypeOtherDescription data to the class member
			_fnmcommunitylendingproducttypeotherdescription = data._fnmcommunitylendingproducttypeotherdescription;
			// assigns the FNMCommunitySecondsIndicator data to the class member
			_fnmcommunitysecondsindicator = data._fnmcommunitysecondsindicator;
			_fnmcommunitysecondsindicator_assigned = data._fnmcommunitysecondsindicator_assigned;
			// assigns the FNMNeighborsMortgageEligibilityIndicator data to the class member
			_fnmneighborsmortgageeligibilityindicator = data._fnmneighborsmortgageeligibilityindicator;
			_fnmneighborsmortgageeligibilityindicator_assigned = data._fnmneighborsmortgageeligibilityindicator_assigned;
			// assigns the FREAffordableProgramIdentifier data to the class member
			_freaffordableprogramidentifier = data._freaffordableprogramidentifier;
			// assigns the HUDIncomeLimitAdjustmentFactor data to the class member
			_hudincomelimitadjustmentfactor = data._hudincomelimitadjustmentfactor;
			_hudincomelimitadjustmentfactor_isnull = data._hudincomelimitadjustmentfactor_isnull;
			// assigns the HUDLendingIncomeLimitAmount data to the class member
			_hudlendingincomelimitamount = data._hudlendingincomelimitamount;
			_hudlendingincomelimitamount_isnull = data._hudlendingincomelimitamount_isnull;
			// assigns the HUDMedianIncomeAmount data to the class member
			_hudmedianincomeamount = data._hudmedianincomeamount;
			_hudmedianincomeamount_isnull = data._hudmedianincomeamount_isnull;
			// assigns the MSAIdentifier data to the class member
			_msaidentifier = data._msaidentifier;
			// assigns the FNMCommunityLendingProductType data to the class member
			_fnmcommunitylendingproducttype = data._fnmcommunitylendingproducttype;
			_fnmcommunitylendingproducttype_isnull = data._fnmcommunitylendingproducttype_isnull;


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
			// assigns the FNMCommunityLendingProductName data to the class member
			if (data["FNMCommunityLendingProductName"] == System.DBNull.Value)
				SetFNMCommunityLendingProductNameNull();
			else
			{
				_fnmcommunitylendingproductname = Convert.ToString(data["FNMCommunityLendingProductName"]);
			}
			// assigns the FNMCommunityLendingProductTypeOtherDescription data to the class member
			if (data["FNMCommunityLendingProductTypeOtherDescription"] == System.DBNull.Value)
				SetFNMCommunityLendingProductTypeOtherDescriptionNull();
			else
			{
				_fnmcommunitylendingproducttypeotherdescription = Convert.ToString(data["FNMCommunityLendingProductTypeOtherDescription"]);
			}
			// assigns the FNMCommunitySecondsIndicator data to the class member
			_fnmcommunitysecondsindicator = Convert.ToBoolean(data["FNMCommunitySecondsIndicator"]);
			_fnmcommunitysecondsindicator_assigned = true;
			// assigns the FNMNeighborsMortgageEligibilityIndicator data to the class member
			_fnmneighborsmortgageeligibilityindicator = Convert.ToBoolean(data["FNMNeighborsMortgageEligibilityIndicator"]);
			_fnmneighborsmortgageeligibilityindicator_assigned = true;
			// assigns the FREAffordableProgramIdentifier data to the class member
			if (data["FREAffordableProgramIdentifier"] == System.DBNull.Value)
				SetFREAffordableProgramIdentifierNull();
			else
			{
				_freaffordableprogramidentifier = Convert.ToString(data["FREAffordableProgramIdentifier"]);
			}
			// assigns the HUDIncomeLimitAdjustmentFactor data to the class member
			if (data["HUDIncomeLimitAdjustmentFactor"] == System.DBNull.Value)
				SetHUDIncomeLimitAdjustmentFactorNull();
			else
			{
				_hudincomelimitadjustmentfactor = Convert.ToDecimal(data["HUDIncomeLimitAdjustmentFactor"]);
				_hudincomelimitadjustmentfactor_isnull = false;
			}
			// assigns the HUDLendingIncomeLimitAmount data to the class member
			if (data["HUDLendingIncomeLimitAmount"] == System.DBNull.Value)
				SetHUDLendingIncomeLimitAmountNull();
			else
			{
				_hudlendingincomelimitamount = Convert.ToDecimal(data["HUDLendingIncomeLimitAmount"]);
				_hudlendingincomelimitamount_isnull = false;
			}
			// assigns the HUDMedianIncomeAmount data to the class member
			if (data["HUDMedianIncomeAmount"] == System.DBNull.Value)
				SetHUDMedianIncomeAmountNull();
			else
			{
				_hudmedianincomeamount = Convert.ToDecimal(data["HUDMedianIncomeAmount"]);
				_hudmedianincomeamount_isnull = false;
			}
			// assigns the MSAIdentifier data to the class member
			if (data["MSAIdentifier"] == System.DBNull.Value)
				SetMSAIdentifierNull();
			else
			{
				_msaidentifier = Convert.ToString(data["MSAIdentifier"]);
			}
			// assigns the FNMCommunityLendingProductType data to the class member
			if (data["FNMCommunityLendingProductType"] == System.DBNull.Value)
				SetFNMCommunityLendingProductTypeNull();
			else
			{
				_fnmcommunitylendingproducttype = Convert.ToInt16(data["FNMCommunityLendingProductType"]);
				_fnmcommunitylendingproducttype_isnull = false;
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
			// assigns the FNMCommunityLendingProductName data to the class member
			if (data["FNMCommunityLendingProductName"] == System.DBNull.Value)
				SetFNMCommunityLendingProductNameNull();
			else
			{
				_fnmcommunitylendingproductname = Convert.ToString(data["FNMCommunityLendingProductName"]);
			}
			// assigns the FNMCommunityLendingProductTypeOtherDescription data to the class member
			if (data["FNMCommunityLendingProductTypeOtherDescription"] == System.DBNull.Value)
				SetFNMCommunityLendingProductTypeOtherDescriptionNull();
			else
			{
				_fnmcommunitylendingproducttypeotherdescription = Convert.ToString(data["FNMCommunityLendingProductTypeOtherDescription"]);
			}
			// assigns the FNMCommunitySecondsIndicator data to the class member
			_fnmcommunitysecondsindicator = Convert.ToBoolean(data["FNMCommunitySecondsIndicator"]);
			_fnmcommunitysecondsindicator_assigned = true;
			// assigns the FNMNeighborsMortgageEligibilityIndicator data to the class member
			_fnmneighborsmortgageeligibilityindicator = Convert.ToBoolean(data["FNMNeighborsMortgageEligibilityIndicator"]);
			_fnmneighborsmortgageeligibilityindicator_assigned = true;
			// assigns the FREAffordableProgramIdentifier data to the class member
			if (data["FREAffordableProgramIdentifier"] == System.DBNull.Value)
				SetFREAffordableProgramIdentifierNull();
			else
			{
				_freaffordableprogramidentifier = Convert.ToString(data["FREAffordableProgramIdentifier"]);
			}
			// assigns the HUDIncomeLimitAdjustmentFactor data to the class member
			if (data["HUDIncomeLimitAdjustmentFactor"] == System.DBNull.Value)
				SetHUDIncomeLimitAdjustmentFactorNull();
			else
			{
				_hudincomelimitadjustmentfactor = Convert.ToDecimal(data["HUDIncomeLimitAdjustmentFactor"]);
				_hudincomelimitadjustmentfactor_isnull = false;
			}
			// assigns the HUDLendingIncomeLimitAmount data to the class member
			if (data["HUDLendingIncomeLimitAmount"] == System.DBNull.Value)
				SetHUDLendingIncomeLimitAmountNull();
			else
			{
				_hudlendingincomelimitamount = Convert.ToDecimal(data["HUDLendingIncomeLimitAmount"]);
				_hudlendingincomelimitamount_isnull = false;
			}
			// assigns the HUDMedianIncomeAmount data to the class member
			if (data["HUDMedianIncomeAmount"] == System.DBNull.Value)
				SetHUDMedianIncomeAmountNull();
			else
			{
				_hudmedianincomeamount = Convert.ToDecimal(data["HUDMedianIncomeAmount"]);
				_hudmedianincomeamount_isnull = false;
			}
			// assigns the MSAIdentifier data to the class member
			if (data["MSAIdentifier"] == System.DBNull.Value)
				SetMSAIdentifierNull();
			else
			{
				_msaidentifier = Convert.ToString(data["MSAIdentifier"]);
			}
			// assigns the FNMCommunityLendingProductType data to the class member
			if (data["FNMCommunityLendingProductType"] == System.DBNull.Value)
				SetFNMCommunityLendingProductTypeNull();
			else
			{
				_fnmcommunitylendingproducttype = Convert.ToInt16(data["FNMCommunityLendingProductType"]);
				_fnmcommunitylendingproducttype_isnull = false;
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
			AffordableLendingBase.ServiceObject.Persist(this as AffordableLending, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the AFFORDABLE_LENDING object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			AffordableLendingBase.ServiceObject.Delete(this as AffordableLending);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the FNMCommunityLendingProductType relationship.
		/// </summary>
		public FNMCommunityLendingProductType GetFNMCommunityLendingProductType()
		{
			if (_fnmcommunitylendingproducttype_isnull)
				return null;
			else
				return new FNMCommunityLendingProductType(_fnmcommunitylendingproducttype);
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
		/// Gets all persisted AffordableLending objects
		/// </summary>
		public static AffordableLendingCollection GetAll()
		{
			// have the service object get the objects
			return AffordableLendingBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
