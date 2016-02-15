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
	/// A class that represents an abstract entity for table 'CONSTRUCTION_REFINANCE_DATA'
	/// </summary>
	[Serializable]
	public abstract class ConstructionRefinanceDataBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ConstructionRefinanceDataBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.ConstructionRefinanceData)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public ConstructionRefinanceDataBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			ConstructionRefinanceDataBase.ServiceObject.Fill(this as ConstructionRefinanceData, loanApplicationId);
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
		internal bool _constructionimprovementcostsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the constructionimprovementcostsamount.
		/// </summary>
		internal System.Decimal _constructionimprovementcostsamount;
		/// <summary>
		/// Gets and sets the ConstructionImprovementCostsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal ConstructionImprovementCostsAmount
		{
			get
			{
				return _constructionimprovementcostsamount;
			}
			set
			{
				_constructionimprovementcostsamount = value;
				_constructionimprovementcostsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ConstructionImprovementCostsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean ConstructionImprovementCostsAmountIsNull
		{
			get
			{
				return _constructionimprovementcostsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _frecashoutamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the frecashoutamount.
		/// </summary>
		internal System.Decimal _frecashoutamount;
		/// <summary>
		/// Gets and sets the FRECashOutAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal FRECashOutAmount
		{
			get
			{
				return _frecashoutamount;
			}
			set
			{
				_frecashoutamount = value;
				_frecashoutamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FRECashOutAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean FRECashOutAmountIsNull
		{
			get
			{
				return _frecashoutamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _landestimatedvalueamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the landestimatedvalueamount.
		/// </summary>
		internal System.Decimal _landestimatedvalueamount;
		/// <summary>
		/// Gets and sets the LandEstimatedValueAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal LandEstimatedValueAmount
		{
			get
			{
				return _landestimatedvalueamount;
			}
			set
			{
				_landestimatedvalueamount = value;
				_landestimatedvalueamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LandEstimatedValueAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean LandEstimatedValueAmountIsNull
		{
			get
			{
				return _landestimatedvalueamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _landoriginalcostamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the landoriginalcostamount.
		/// </summary>
		internal System.Decimal _landoriginalcostamount;
		/// <summary>
		/// Gets and sets the LandOriginalCostAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal LandOriginalCostAmount
		{
			get
			{
				return _landoriginalcostamount;
			}
			set
			{
				_landoriginalcostamount = value;
				_landoriginalcostamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LandOriginalCostAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean LandOriginalCostAmountIsNull
		{
			get
			{
				return _landoriginalcostamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyacquiredyear_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyacquiredyear.
		/// </summary>
		internal System.DateTime _propertyacquiredyear;
		/// <summary>
		/// Gets and sets the PropertyAcquiredYear value of the class instance.
		/// </summary>
		public virtual System.DateTime PropertyAcquiredYear
		{
			get
			{
				return _propertyacquiredyear;
			}
			set
			{
				_propertyacquiredyear = value;
				_propertyacquiredyear_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyAcquiredYear value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyAcquiredYearIsNull
		{
			get
			{
				return _propertyacquiredyear_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyexistinglienamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyexistinglienamount.
		/// </summary>
		internal System.Decimal _propertyexistinglienamount;
		/// <summary>
		/// Gets and sets the PropertyExistingLienAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PropertyExistingLienAmount
		{
			get
			{
				return _propertyexistinglienamount;
			}
			set
			{
				_propertyexistinglienamount = value;
				_propertyexistinglienamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyExistingLienAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyExistingLienAmountIsNull
		{
			get
			{
				return _propertyexistinglienamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyoriginalcostamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyoriginalcostamount.
		/// </summary>
		internal System.Decimal _propertyoriginalcostamount;
		/// <summary>
		/// Gets and sets the PropertyOriginalCostAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal PropertyOriginalCostAmount
		{
			get
			{
				return _propertyoriginalcostamount;
			}
			set
			{
				_propertyoriginalcostamount = value;
				_propertyoriginalcostamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyOriginalCostAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyOriginalCostAmountIsNull
		{
			get
			{
				return _propertyoriginalcostamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _refinanceimprovementcostsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the refinanceimprovementcostsamount.
		/// </summary>
		internal System.Decimal _refinanceimprovementcostsamount;
		/// <summary>
		/// Gets and sets the RefinanceImprovementCostsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal RefinanceImprovementCostsAmount
		{
			get
			{
				return _refinanceimprovementcostsamount;
			}
			set
			{
				_refinanceimprovementcostsamount = value;
				_refinanceimprovementcostsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RefinanceImprovementCostsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean RefinanceImprovementCostsAmountIsNull
		{
			get
			{
				return _refinanceimprovementcostsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the refinanceproposedimprovementsdescription.
		/// </summary>
		internal System.String _refinanceproposedimprovementsdescription;
		/// <summary>
		/// Gets and sets the RefinanceProposedImprovementsDescription value of the class instance.
		/// </summary>
		public virtual System.String RefinanceProposedImprovementsDescription
		{
			get
			{
				return _refinanceproposedimprovementsdescription;
			}
			set
			{
				_refinanceproposedimprovementsdescription = value;
			}
		}


		/// <summary>
		/// Checks the RefinanceProposedImprovementsDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean RefinanceProposedImprovementsDescriptionIsNull
		{
			get
			{
				return (_refinanceproposedimprovementsdescription == null);
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _secondaryfinancingrefinanceindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the secondaryfinancingrefinanceindicator.
		/// </summary>
		internal System.Boolean _secondaryfinancingrefinanceindicator;
		/// <summary>
		/// Gets and sets the SecondaryFinancingRefinanceIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean SecondaryFinancingRefinanceIndicator
		{
			get
			{
				return _secondaryfinancingrefinanceindicator;
			}
			set
			{
				_secondaryfinancingrefinanceindicator = value;
				_secondaryfinancingrefinanceindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _fnmsecondmortgagefinancingoriginalpropertyindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the fnmsecondmortgagefinancingoriginalpropertyindicator.
		/// </summary>
		internal System.Boolean _fnmsecondmortgagefinancingoriginalpropertyindicator;
		/// <summary>
		/// Gets and sets the FNMSecondMortgageFinancingOriginalPropertyIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean FNMSecondMortgageFinancingOriginalPropertyIndicator
		{
			get
			{
				return _fnmsecondmortgagefinancingoriginalpropertyindicator;
			}
			set
			{
				_fnmsecondmortgagefinancingoriginalpropertyindicator = value;
				_fnmsecondmortgagefinancingoriginalpropertyindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _structuralalterationsconventionalamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the structuralalterationsconventionalamount.
		/// </summary>
		internal System.Decimal _structuralalterationsconventionalamount;
		/// <summary>
		/// Gets and sets the StructuralAlterationsConventionalAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal StructuralAlterationsConventionalAmount
		{
			get
			{
				return _structuralalterationsconventionalamount;
			}
			set
			{
				_structuralalterationsconventionalamount = value;
				_structuralalterationsconventionalamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the StructuralAlterationsConventionalAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean StructuralAlterationsConventionalAmountIsNull
		{
			get
			{
				return _structuralalterationsconventionalamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _nonstructuralalterationsconventionalamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the nonstructuralalterationsconventionalamount.
		/// </summary>
		internal System.Decimal _nonstructuralalterationsconventionalamount;
		/// <summary>
		/// Gets and sets the NonStructuralAlterationsConventionalAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal NonStructuralAlterationsConventionalAmount
		{
			get
			{
				return _nonstructuralalterationsconventionalamount;
			}
			set
			{
				_nonstructuralalterationsconventionalamount = value;
				_nonstructuralalterationsconventionalamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the NonStructuralAlterationsConventionalAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean NonStructuralAlterationsConventionalAmountIsNull
		{
			get
			{
				return _nonstructuralalterationsconventionalamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _constructionpurposetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the constructionpurposetype.
		/// </summary>
		internal System.Int16 _constructionpurposetype;
		/// <summary>
		/// Gets and sets the ConstructionPurposeType value of the class instance.
		/// </summary>
		public virtual System.Int16 ConstructionPurposeType
		{
			get
			{
				return _constructionpurposetype;
			}
			set
			{
				_constructionpurposetype = value;
				_constructionpurposetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ConstructionPurposeType value to see if it was set to null.
		/// </summary>
		public System.Boolean ConstructionPurposeTypeIsNull
		{
			get
			{
				return _constructionpurposetype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _refinanceimprovementstype_isnull = true;
		/// <summary>
		/// Member that stores the value for the refinanceimprovementstype.
		/// </summary>
		internal System.Int16 _refinanceimprovementstype;
		/// <summary>
		/// Gets and sets the RefinanceImprovementsType value of the class instance.
		/// </summary>
		public virtual System.Int16 RefinanceImprovementsType
		{
			get
			{
				return _refinanceimprovementstype;
			}
			set
			{
				_refinanceimprovementstype = value;
				_refinanceimprovementstype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the RefinanceImprovementsType value to see if it was set to null.
		/// </summary>
		public System.Boolean RefinanceImprovementsTypeIsNull
		{
			get
			{
				return _refinanceimprovementstype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _gserefinancepurposetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the gserefinancepurposetype.
		/// </summary>
		internal System.Int16 _gserefinancepurposetype;
		/// <summary>
		/// Gets and sets the GSERefinancePurposeType value of the class instance.
		/// </summary>
		public virtual System.Int16 GSERefinancePurposeType
		{
			get
			{
				return _gserefinancepurposetype;
			}
			set
			{
				_gserefinancepurposetype = value;
				_gserefinancepurposetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the GSERefinancePurposeType value to see if it was set to null.
		/// </summary>
		public System.Boolean GSERefinancePurposeTypeIsNull
		{
			get
			{
				return _gserefinancepurposetype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the ConstructionRefinanceDataBase.
		/// </summary>
		internal static ConstructionRefinanceDataService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(ConstructionRefinanceDataService)) as ConstructionRefinanceDataService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of ConstructionRefinanceDataBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the ConstructionImprovementCostsAmount value as null.
		/// </summary>
		public virtual void SetConstructionImprovementCostsAmountNull()
		{
			_constructionimprovementcostsamount = 0;
			_constructionimprovementcostsamount_isnull = true;
		}


		/// <summary>
		/// Marks the FRECashOutAmount value as null.
		/// </summary>
		public virtual void SetFRECashOutAmountNull()
		{
			_frecashoutamount = 0;
			_frecashoutamount_isnull = true;
		}


		/// <summary>
		/// Marks the LandEstimatedValueAmount value as null.
		/// </summary>
		public virtual void SetLandEstimatedValueAmountNull()
		{
			_landestimatedvalueamount = 0;
			_landestimatedvalueamount_isnull = true;
		}


		/// <summary>
		/// Marks the LandOriginalCostAmount value as null.
		/// </summary>
		public virtual void SetLandOriginalCostAmountNull()
		{
			_landoriginalcostamount = 0;
			_landoriginalcostamount_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyAcquiredYear value as null.
		/// </summary>
		public virtual void SetPropertyAcquiredYearNull()
		{
			_propertyacquiredyear = DateTime.MinValue;
			_propertyacquiredyear_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyExistingLienAmount value as null.
		/// </summary>
		public virtual void SetPropertyExistingLienAmountNull()
		{
			_propertyexistinglienamount = 0;
			_propertyexistinglienamount_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyOriginalCostAmount value as null.
		/// </summary>
		public virtual void SetPropertyOriginalCostAmountNull()
		{
			_propertyoriginalcostamount = 0;
			_propertyoriginalcostamount_isnull = true;
		}


		/// <summary>
		/// Marks the RefinanceImprovementCostsAmount value as null.
		/// </summary>
		public virtual void SetRefinanceImprovementCostsAmountNull()
		{
			_refinanceimprovementcostsamount = 0;
			_refinanceimprovementcostsamount_isnull = true;
		}


		/// <summary>
		/// Marks the RefinanceProposedImprovementsDescription value as null.
		/// </summary>
		public virtual void SetRefinanceProposedImprovementsDescriptionNull()
		{
			_refinanceproposedimprovementsdescription = null;
		}


		/// <summary>
		/// Marks the StructuralAlterationsConventionalAmount value as null.
		/// </summary>
		public virtual void SetStructuralAlterationsConventionalAmountNull()
		{
			_structuralalterationsconventionalamount = 0;
			_structuralalterationsconventionalamount_isnull = true;
		}


		/// <summary>
		/// Marks the NonStructuralAlterationsConventionalAmount value as null.
		/// </summary>
		public virtual void SetNonStructuralAlterationsConventionalAmountNull()
		{
			_nonstructuralalterationsconventionalamount = 0;
			_nonstructuralalterationsconventionalamount_isnull = true;
		}


		/// <summary>
		/// Marks the ConstructionPurposeType value as null.
		/// </summary>
		public virtual void SetConstructionPurposeTypeNull()
		{
			_constructionpurposetype = 0;
			_constructionpurposetype_isnull = true;
		}


		/// <summary>
		/// Marks the RefinanceImprovementsType value as null.
		/// </summary>
		public virtual void SetRefinanceImprovementsTypeNull()
		{
			_refinanceimprovementstype = 0;
			_refinanceimprovementstype_isnull = true;
		}


		/// <summary>
		/// Marks the GSERefinancePurposeType value as null.
		/// </summary>
		public virtual void SetGSERefinancePurposeTypeNull()
		{
			_gserefinancepurposetype = 0;
			_gserefinancepurposetype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref ConstructionRefinanceDataBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the ConstructionImprovementCostsAmount data to the class member
			_constructionimprovementcostsamount = data._constructionimprovementcostsamount;
			_constructionimprovementcostsamount_isnull = data._constructionimprovementcostsamount_isnull;
			// assigns the FRECashOutAmount data to the class member
			_frecashoutamount = data._frecashoutamount;
			_frecashoutamount_isnull = data._frecashoutamount_isnull;
			// assigns the LandEstimatedValueAmount data to the class member
			_landestimatedvalueamount = data._landestimatedvalueamount;
			_landestimatedvalueamount_isnull = data._landestimatedvalueamount_isnull;
			// assigns the LandOriginalCostAmount data to the class member
			_landoriginalcostamount = data._landoriginalcostamount;
			_landoriginalcostamount_isnull = data._landoriginalcostamount_isnull;
			// assigns the PropertyAcquiredYear data to the class member
			_propertyacquiredyear = data._propertyacquiredyear;
			_propertyacquiredyear_isnull = data._propertyacquiredyear_isnull;
			// assigns the PropertyExistingLienAmount data to the class member
			_propertyexistinglienamount = data._propertyexistinglienamount;
			_propertyexistinglienamount_isnull = data._propertyexistinglienamount_isnull;
			// assigns the PropertyOriginalCostAmount data to the class member
			_propertyoriginalcostamount = data._propertyoriginalcostamount;
			_propertyoriginalcostamount_isnull = data._propertyoriginalcostamount_isnull;
			// assigns the RefinanceImprovementCostsAmount data to the class member
			_refinanceimprovementcostsamount = data._refinanceimprovementcostsamount;
			_refinanceimprovementcostsamount_isnull = data._refinanceimprovementcostsamount_isnull;
			// assigns the RefinanceProposedImprovementsDescription data to the class member
			_refinanceproposedimprovementsdescription = data._refinanceproposedimprovementsdescription;
			// assigns the SecondaryFinancingRefinanceIndicator data to the class member
			_secondaryfinancingrefinanceindicator = data._secondaryfinancingrefinanceindicator;
			_secondaryfinancingrefinanceindicator_assigned = data._secondaryfinancingrefinanceindicator_assigned;
			// assigns the FNMSecondMortgageFinancingOriginalPropertyIndicator data to the class member
			_fnmsecondmortgagefinancingoriginalpropertyindicator = data._fnmsecondmortgagefinancingoriginalpropertyindicator;
			_fnmsecondmortgagefinancingoriginalpropertyindicator_assigned = data._fnmsecondmortgagefinancingoriginalpropertyindicator_assigned;
			// assigns the StructuralAlterationsConventionalAmount data to the class member
			_structuralalterationsconventionalamount = data._structuralalterationsconventionalamount;
			_structuralalterationsconventionalamount_isnull = data._structuralalterationsconventionalamount_isnull;
			// assigns the NonStructuralAlterationsConventionalAmount data to the class member
			_nonstructuralalterationsconventionalamount = data._nonstructuralalterationsconventionalamount;
			_nonstructuralalterationsconventionalamount_isnull = data._nonstructuralalterationsconventionalamount_isnull;
			// assigns the ConstructionPurposeType data to the class member
			_constructionpurposetype = data._constructionpurposetype;
			_constructionpurposetype_isnull = data._constructionpurposetype_isnull;
			// assigns the RefinanceImprovementsType data to the class member
			_refinanceimprovementstype = data._refinanceimprovementstype;
			_refinanceimprovementstype_isnull = data._refinanceimprovementstype_isnull;
			// assigns the GSERefinancePurposeType data to the class member
			_gserefinancepurposetype = data._gserefinancepurposetype;
			_gserefinancepurposetype_isnull = data._gserefinancepurposetype_isnull;


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
			// assigns the ConstructionImprovementCostsAmount data to the class member
			if (data["ConstructionImprovementCostsAmount"] == System.DBNull.Value)
				SetConstructionImprovementCostsAmountNull();
			else
			{
				_constructionimprovementcostsamount = Convert.ToDecimal(data["ConstructionImprovementCostsAmount"]);
				_constructionimprovementcostsamount_isnull = false;
			}
			// assigns the FRECashOutAmount data to the class member
			if (data["FRECashOutAmount"] == System.DBNull.Value)
				SetFRECashOutAmountNull();
			else
			{
				_frecashoutamount = Convert.ToDecimal(data["FRECashOutAmount"]);
				_frecashoutamount_isnull = false;
			}
			// assigns the LandEstimatedValueAmount data to the class member
			if (data["LandEstimatedValueAmount"] == System.DBNull.Value)
				SetLandEstimatedValueAmountNull();
			else
			{
				_landestimatedvalueamount = Convert.ToDecimal(data["LandEstimatedValueAmount"]);
				_landestimatedvalueamount_isnull = false;
			}
			// assigns the LandOriginalCostAmount data to the class member
			if (data["LandOriginalCostAmount"] == System.DBNull.Value)
				SetLandOriginalCostAmountNull();
			else
			{
				_landoriginalcostamount = Convert.ToDecimal(data["LandOriginalCostAmount"]);
				_landoriginalcostamount_isnull = false;
			}
			// assigns the PropertyAcquiredYear data to the class member
			if (data["PropertyAcquiredYear"] == System.DBNull.Value)
				SetPropertyAcquiredYearNull();
			else
			{
				_propertyacquiredyear = Convert.ToDateTime(data["PropertyAcquiredYear"]);
				_propertyacquiredyear_isnull = false;
			}
			// assigns the PropertyExistingLienAmount data to the class member
			if (data["PropertyExistingLienAmount"] == System.DBNull.Value)
				SetPropertyExistingLienAmountNull();
			else
			{
				_propertyexistinglienamount = Convert.ToDecimal(data["PropertyExistingLienAmount"]);
				_propertyexistinglienamount_isnull = false;
			}
			// assigns the PropertyOriginalCostAmount data to the class member
			if (data["PropertyOriginalCostAmount"] == System.DBNull.Value)
				SetPropertyOriginalCostAmountNull();
			else
			{
				_propertyoriginalcostamount = Convert.ToDecimal(data["PropertyOriginalCostAmount"]);
				_propertyoriginalcostamount_isnull = false;
			}
			// assigns the RefinanceImprovementCostsAmount data to the class member
			if (data["RefinanceImprovementCostsAmount"] == System.DBNull.Value)
				SetRefinanceImprovementCostsAmountNull();
			else
			{
				_refinanceimprovementcostsamount = Convert.ToDecimal(data["RefinanceImprovementCostsAmount"]);
				_refinanceimprovementcostsamount_isnull = false;
			}
			// assigns the RefinanceProposedImprovementsDescription data to the class member
			if (data["RefinanceProposedImprovementsDescription"] == System.DBNull.Value)
				SetRefinanceProposedImprovementsDescriptionNull();
			else
			{
				_refinanceproposedimprovementsdescription = Convert.ToString(data["RefinanceProposedImprovementsDescription"]);
			}
			// assigns the SecondaryFinancingRefinanceIndicator data to the class member
			_secondaryfinancingrefinanceindicator = Convert.ToBoolean(data["SecondaryFinancingRefinanceIndicator"]);
			_secondaryfinancingrefinanceindicator_assigned = true;
			// assigns the FNMSecondMortgageFinancingOriginalPropertyIndicator data to the class member
			_fnmsecondmortgagefinancingoriginalpropertyindicator = Convert.ToBoolean(data["FNMSecondMortgageFinancingOriginalPropertyIndicator"]);
			_fnmsecondmortgagefinancingoriginalpropertyindicator_assigned = true;
			// assigns the StructuralAlterationsConventionalAmount data to the class member
			if (data["StructuralAlterationsConventionalAmount"] == System.DBNull.Value)
				SetStructuralAlterationsConventionalAmountNull();
			else
			{
				_structuralalterationsconventionalamount = Convert.ToDecimal(data["StructuralAlterationsConventionalAmount"]);
				_structuralalterationsconventionalamount_isnull = false;
			}
			// assigns the NonStructuralAlterationsConventionalAmount data to the class member
			if (data["NonStructuralAlterationsConventionalAmount"] == System.DBNull.Value)
				SetNonStructuralAlterationsConventionalAmountNull();
			else
			{
				_nonstructuralalterationsconventionalamount = Convert.ToDecimal(data["NonStructuralAlterationsConventionalAmount"]);
				_nonstructuralalterationsconventionalamount_isnull = false;
			}
			// assigns the ConstructionPurposeType data to the class member
			if (data["ConstructionPurposeType"] == System.DBNull.Value)
				SetConstructionPurposeTypeNull();
			else
			{
				_constructionpurposetype = Convert.ToInt16(data["ConstructionPurposeType"]);
				_constructionpurposetype_isnull = false;
			}
			// assigns the RefinanceImprovementsType data to the class member
			if (data["RefinanceImprovementsType"] == System.DBNull.Value)
				SetRefinanceImprovementsTypeNull();
			else
			{
				_refinanceimprovementstype = Convert.ToInt16(data["RefinanceImprovementsType"]);
				_refinanceimprovementstype_isnull = false;
			}
			// assigns the GSERefinancePurposeType data to the class member
			if (data["GSERefinancePurposeType"] == System.DBNull.Value)
				SetGSERefinancePurposeTypeNull();
			else
			{
				_gserefinancepurposetype = Convert.ToInt16(data["GSERefinancePurposeType"]);
				_gserefinancepurposetype_isnull = false;
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
			// assigns the ConstructionImprovementCostsAmount data to the class member
			if (data["ConstructionImprovementCostsAmount"] == System.DBNull.Value)
				SetConstructionImprovementCostsAmountNull();
			else
			{
				_constructionimprovementcostsamount = Convert.ToDecimal(data["ConstructionImprovementCostsAmount"]);
				_constructionimprovementcostsamount_isnull = false;
			}
			// assigns the FRECashOutAmount data to the class member
			if (data["FRECashOutAmount"] == System.DBNull.Value)
				SetFRECashOutAmountNull();
			else
			{
				_frecashoutamount = Convert.ToDecimal(data["FRECashOutAmount"]);
				_frecashoutamount_isnull = false;
			}
			// assigns the LandEstimatedValueAmount data to the class member
			if (data["LandEstimatedValueAmount"] == System.DBNull.Value)
				SetLandEstimatedValueAmountNull();
			else
			{
				_landestimatedvalueamount = Convert.ToDecimal(data["LandEstimatedValueAmount"]);
				_landestimatedvalueamount_isnull = false;
			}
			// assigns the LandOriginalCostAmount data to the class member
			if (data["LandOriginalCostAmount"] == System.DBNull.Value)
				SetLandOriginalCostAmountNull();
			else
			{
				_landoriginalcostamount = Convert.ToDecimal(data["LandOriginalCostAmount"]);
				_landoriginalcostamount_isnull = false;
			}
			// assigns the PropertyAcquiredYear data to the class member
			if (data["PropertyAcquiredYear"] == System.DBNull.Value)
				SetPropertyAcquiredYearNull();
			else
			{
				_propertyacquiredyear = Convert.ToDateTime(data["PropertyAcquiredYear"]);
				_propertyacquiredyear_isnull = false;
			}
			// assigns the PropertyExistingLienAmount data to the class member
			if (data["PropertyExistingLienAmount"] == System.DBNull.Value)
				SetPropertyExistingLienAmountNull();
			else
			{
				_propertyexistinglienamount = Convert.ToDecimal(data["PropertyExistingLienAmount"]);
				_propertyexistinglienamount_isnull = false;
			}
			// assigns the PropertyOriginalCostAmount data to the class member
			if (data["PropertyOriginalCostAmount"] == System.DBNull.Value)
				SetPropertyOriginalCostAmountNull();
			else
			{
				_propertyoriginalcostamount = Convert.ToDecimal(data["PropertyOriginalCostAmount"]);
				_propertyoriginalcostamount_isnull = false;
			}
			// assigns the RefinanceImprovementCostsAmount data to the class member
			if (data["RefinanceImprovementCostsAmount"] == System.DBNull.Value)
				SetRefinanceImprovementCostsAmountNull();
			else
			{
				_refinanceimprovementcostsamount = Convert.ToDecimal(data["RefinanceImprovementCostsAmount"]);
				_refinanceimprovementcostsamount_isnull = false;
			}
			// assigns the RefinanceProposedImprovementsDescription data to the class member
			if (data["RefinanceProposedImprovementsDescription"] == System.DBNull.Value)
				SetRefinanceProposedImprovementsDescriptionNull();
			else
			{
				_refinanceproposedimprovementsdescription = Convert.ToString(data["RefinanceProposedImprovementsDescription"]);
			}
			// assigns the SecondaryFinancingRefinanceIndicator data to the class member
			_secondaryfinancingrefinanceindicator = Convert.ToBoolean(data["SecondaryFinancingRefinanceIndicator"]);
			_secondaryfinancingrefinanceindicator_assigned = true;
			// assigns the FNMSecondMortgageFinancingOriginalPropertyIndicator data to the class member
			_fnmsecondmortgagefinancingoriginalpropertyindicator = Convert.ToBoolean(data["FNMSecondMortgageFinancingOriginalPropertyIndicator"]);
			_fnmsecondmortgagefinancingoriginalpropertyindicator_assigned = true;
			// assigns the StructuralAlterationsConventionalAmount data to the class member
			if (data["StructuralAlterationsConventionalAmount"] == System.DBNull.Value)
				SetStructuralAlterationsConventionalAmountNull();
			else
			{
				_structuralalterationsconventionalamount = Convert.ToDecimal(data["StructuralAlterationsConventionalAmount"]);
				_structuralalterationsconventionalamount_isnull = false;
			}
			// assigns the NonStructuralAlterationsConventionalAmount data to the class member
			if (data["NonStructuralAlterationsConventionalAmount"] == System.DBNull.Value)
				SetNonStructuralAlterationsConventionalAmountNull();
			else
			{
				_nonstructuralalterationsconventionalamount = Convert.ToDecimal(data["NonStructuralAlterationsConventionalAmount"]);
				_nonstructuralalterationsconventionalamount_isnull = false;
			}
			// assigns the ConstructionPurposeType data to the class member
			if (data["ConstructionPurposeType"] == System.DBNull.Value)
				SetConstructionPurposeTypeNull();
			else
			{
				_constructionpurposetype = Convert.ToInt16(data["ConstructionPurposeType"]);
				_constructionpurposetype_isnull = false;
			}
			// assigns the RefinanceImprovementsType data to the class member
			if (data["RefinanceImprovementsType"] == System.DBNull.Value)
				SetRefinanceImprovementsTypeNull();
			else
			{
				_refinanceimprovementstype = Convert.ToInt16(data["RefinanceImprovementsType"]);
				_refinanceimprovementstype_isnull = false;
			}
			// assigns the GSERefinancePurposeType data to the class member
			if (data["GSERefinancePurposeType"] == System.DBNull.Value)
				SetGSERefinancePurposeTypeNull();
			else
			{
				_gserefinancepurposetype = Convert.ToInt16(data["GSERefinancePurposeType"]);
				_gserefinancepurposetype_isnull = false;
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
			ConstructionRefinanceDataBase.ServiceObject.Persist(this as ConstructionRefinanceData, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the CONSTRUCTION_REFINANCE_DATA object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			ConstructionRefinanceDataBase.ServiceObject.Delete(this as ConstructionRefinanceData);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the ConstructionPurposeType relationship.
		/// </summary>
		public ConstructionPurposeType GetConstructionPurposeType()
		{
			if (_constructionpurposetype_isnull)
				return null;
			else
				return new ConstructionPurposeType(_constructionpurposetype);
		}


		/// <summary>
		/// Gets the single object for the GSERefinancePurposeType relationship.
		/// </summary>
		public GSERefinancePurposeType GetGSERefinancePurposeType()
		{
			if (_gserefinancepurposetype_isnull)
				return null;
			else
				return new GSERefinancePurposeType(_gserefinancepurposetype);
		}


		/// <summary>
		/// Gets the single object for the LOAN_PURPOSE relationship.
		/// </summary>
		public LoanPurpose GetLoanPurpose()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new LoanPurpose(_loanapplicationid);
		}


		/// <summary>
		/// Gets the single object for the RefinanceImprovementsType relationship.
		/// </summary>
		public RefinanceImprovementsType GetRefinanceImprovementsType()
		{
			if (_refinanceimprovementstype_isnull)
				return null;
			else
				return new RefinanceImprovementsType(_refinanceimprovementstype);
		}


		/// <summary>
		/// Gets all persisted ConstructionRefinanceData objects
		/// </summary>
		public static ConstructionRefinanceDataCollection GetAll()
		{
			// have the service object get the objects
			return ConstructionRefinanceDataBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
