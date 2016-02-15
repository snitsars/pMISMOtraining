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
	/// A class that represents an abstract entity for table 'DECLARATION'
	/// </summary>
	[Serializable]
	public abstract class DeclarationBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DeclarationBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Declaration)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public DeclarationBase(System.Int64 borrowerId)
		{
			// Fill this instance.
			DeclarationBase.ServiceObject.Fill(this as Declaration, borrowerId);
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
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _alimonychildsupportobligationindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the alimonychildsupportobligationindicator.
		/// </summary>
		internal System.Boolean _alimonychildsupportobligationindicator;
		/// <summary>
		/// Gets and sets the AlimonyChildSupportObligationIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean AlimonyChildSupportObligationIndicator
		{
			get
			{
				return _alimonychildsupportobligationindicator;
			}
			set
			{
				_alimonychildsupportobligationindicator = value;
				_alimonychildsupportobligationindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _bankruptcyindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the bankruptcyindicator.
		/// </summary>
		internal System.Boolean _bankruptcyindicator;
		/// <summary>
		/// Gets and sets the BankruptcyIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean BankruptcyIndicator
		{
			get
			{
				return _bankruptcyindicator;
			}
			set
			{
				_bankruptcyindicator = value;
				_bankruptcyindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _borroweddownpaymentindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the borroweddownpaymentindicator.
		/// </summary>
		internal System.Boolean _borroweddownpaymentindicator;
		/// <summary>
		/// Gets and sets the BorrowedDownPaymentIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean BorrowedDownPaymentIndicator
		{
			get
			{
				return _borroweddownpaymentindicator;
			}
			set
			{
				_borroweddownpaymentindicator = value;
				_borroweddownpaymentindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _comakerendorserofnoteindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the comakerendorserofnoteindicator.
		/// </summary>
		internal System.Boolean _comakerendorserofnoteindicator;
		/// <summary>
		/// Gets and sets the CoMakerEndorserOfNoteIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean CoMakerEndorserOfNoteIndicator
		{
			get
			{
				return _comakerendorserofnoteindicator;
			}
			set
			{
				_comakerendorserofnoteindicator = value;
				_comakerendorserofnoteindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _homeownerpastthreeyearstype_isnull = true;
		/// <summary>
		/// Member that stores the value for the homeownerpastthreeyearstype.
		/// </summary>
		internal System.Boolean _homeownerpastthreeyearstype;
		/// <summary>
		/// Gets and sets the HomeownerPastThreeYearsType value of the class instance.
		/// </summary>
		public virtual System.Boolean HomeownerPastThreeYearsType
		{
			get
			{
				return _homeownerpastthreeyearstype;
			}
			set
			{
				_homeownerpastthreeyearstype = value;
				_homeownerpastthreeyearstype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the HomeownerPastThreeYearsType value to see if it was set to null.
		/// </summary>
		public System.Boolean HomeownerPastThreeYearsTypeIsNull
		{
			get
			{
				return _homeownerpastthreeyearstype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _intenttooccupytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the intenttooccupytype.
		/// </summary>
		internal System.Boolean _intenttooccupytype;
		/// <summary>
		/// Gets and sets the IntentToOccupyType value of the class instance.
		/// </summary>
		public virtual System.Boolean IntentToOccupyType
		{
			get
			{
				return _intenttooccupytype;
			}
			set
			{
				_intenttooccupytype = value;
				_intenttooccupytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the IntentToOccupyType value to see if it was set to null.
		/// </summary>
		public System.Boolean IntentToOccupyTypeIsNull
		{
			get
			{
				return _intenttooccupytype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _loanforeclosureorjudgementindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the loanforeclosureorjudgementindicator.
		/// </summary>
		internal System.Boolean _loanforeclosureorjudgementindicator;
		/// <summary>
		/// Gets and sets the LoanForeclosureOrJudgementIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean LoanForeclosureOrJudgementIndicator
		{
			get
			{
				return _loanforeclosureorjudgementindicator;
			}
			set
			{
				_loanforeclosureorjudgementindicator = value;
				_loanforeclosureorjudgementindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _outstandingjudgementsindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the outstandingjudgementsindicator.
		/// </summary>
		internal System.Boolean _outstandingjudgementsindicator;
		/// <summary>
		/// Gets and sets the OutstandingJudgementsIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean OutstandingJudgementsIndicator
		{
			get
			{
				return _outstandingjudgementsindicator;
			}
			set
			{
				_outstandingjudgementsindicator = value;
				_outstandingjudgementsindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _partytolawsuitindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the partytolawsuitindicator.
		/// </summary>
		internal System.Boolean _partytolawsuitindicator;
		/// <summary>
		/// Gets and sets the PartyToLawsuitIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PartyToLawsuitIndicator
		{
			get
			{
				return _partytolawsuitindicator;
			}
			set
			{
				_partytolawsuitindicator = value;
				_partytolawsuitindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _presentlydelinquentindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the presentlydelinquentindicator.
		/// </summary>
		internal System.Boolean _presentlydelinquentindicator;
		/// <summary>
		/// Gets and sets the PresentlyDelinquentIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PresentlyDelinquentIndicator
		{
			get
			{
				return _presentlydelinquentindicator;
			}
			set
			{
				_presentlydelinquentindicator = value;
				_presentlydelinquentindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _propertyforeclosedpastsevenyearsindicator_assigned = false;
		/// <summary>
		/// Member that stores the value for the propertyforeclosedpastsevenyearsindicator.
		/// </summary>
		internal System.Boolean _propertyforeclosedpastsevenyearsindicator;
		/// <summary>
		/// Gets and sets the PropertyForeclosedPastSevenYearsIndicator value of the class instance.
		/// </summary>
		public virtual System.Boolean PropertyForeclosedPastSevenYearsIndicator
		{
			get
			{
				return _propertyforeclosedpastsevenyearsindicator;
			}
			set
			{
				_propertyforeclosedpastsevenyearsindicator = value;
				_propertyforeclosedpastsevenyearsindicator_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _citizenshipresidencytype_isnull = true;
		/// <summary>
		/// Member that stores the value for the citizenshipresidencytype.
		/// </summary>
		internal System.Int16 _citizenshipresidencytype;
		/// <summary>
		/// Gets and sets the CitizenshipResidencyType value of the class instance.
		/// </summary>
		public virtual System.Int16 CitizenshipResidencyType
		{
			get
			{
				return _citizenshipresidencytype;
			}
			set
			{
				_citizenshipresidencytype = value;
				_citizenshipresidencytype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the CitizenshipResidencyType value to see if it was set to null.
		/// </summary>
		public System.Boolean CitizenshipResidencyTypeIsNull
		{
			get
			{
				return _citizenshipresidencytype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _priorpropertytitletype_isnull = true;
		/// <summary>
		/// Member that stores the value for the priorpropertytitletype.
		/// </summary>
		internal System.Int16 _priorpropertytitletype;
		/// <summary>
		/// Gets and sets the PriorPropertyTitleType value of the class instance.
		/// </summary>
		public virtual System.Int16 PriorPropertyTitleType
		{
			get
			{
				return _priorpropertytitletype;
			}
			set
			{
				_priorpropertytitletype = value;
				_priorpropertytitletype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PriorPropertyTitleType value to see if it was set to null.
		/// </summary>
		public System.Boolean PriorPropertyTitleTypeIsNull
		{
			get
			{
				return _priorpropertytitletype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _priorpropertyusagetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the priorpropertyusagetype.
		/// </summary>
		internal System.Int16 _priorpropertyusagetype;
		/// <summary>
		/// Gets and sets the PriorPropertyUsageType value of the class instance.
		/// </summary>
		public virtual System.Int16 PriorPropertyUsageType
		{
			get
			{
				return _priorpropertyusagetype;
			}
			set
			{
				_priorpropertyusagetype = value;
				_priorpropertyusagetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PriorPropertyUsageType value to see if it was set to null.
		/// </summary>
		public System.Boolean PriorPropertyUsageTypeIsNull
		{
			get
			{
				return _priorpropertyusagetype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the DeclarationBase.
		/// </summary>
		internal static DeclarationService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(DeclarationService)) as DeclarationService;
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


				if (!_borrowerid_assigned) exceptions = BusinessLogic.ChainException("BorrowerId is a required value of DeclarationBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the HomeownerPastThreeYearsType value as null.
		/// </summary>
		public virtual void SetHomeownerPastThreeYearsTypeNull()
		{
			_homeownerpastthreeyearstype = false;
			_homeownerpastthreeyearstype_isnull = true;
		}


		/// <summary>
		/// Marks the IntentToOccupyType value as null.
		/// </summary>
		public virtual void SetIntentToOccupyTypeNull()
		{
			_intenttooccupytype = false;
			_intenttooccupytype_isnull = true;
		}


		/// <summary>
		/// Marks the CitizenshipResidencyType value as null.
		/// </summary>
		public virtual void SetCitizenshipResidencyTypeNull()
		{
			_citizenshipresidencytype = 0;
			_citizenshipresidencytype_isnull = true;
		}


		/// <summary>
		/// Marks the PriorPropertyTitleType value as null.
		/// </summary>
		public virtual void SetPriorPropertyTitleTypeNull()
		{
			_priorpropertytitletype = 0;
			_priorpropertytitletype_isnull = true;
		}


		/// <summary>
		/// Marks the PriorPropertyUsageType value as null.
		/// </summary>
		public virtual void SetPriorPropertyUsageTypeNull()
		{
			_priorpropertyusagetype = 0;
			_priorpropertyusagetype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref DeclarationBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the BorrowerId data to the class member
			_borrowerid = data._borrowerid;
			_borrowerid_assigned = data._borrowerid_assigned;
			// assigns the AlimonyChildSupportObligationIndicator data to the class member
			_alimonychildsupportobligationindicator = data._alimonychildsupportobligationindicator;
			_alimonychildsupportobligationindicator_assigned = data._alimonychildsupportobligationindicator_assigned;
			// assigns the BankruptcyIndicator data to the class member
			_bankruptcyindicator = data._bankruptcyindicator;
			_bankruptcyindicator_assigned = data._bankruptcyindicator_assigned;
			// assigns the BorrowedDownPaymentIndicator data to the class member
			_borroweddownpaymentindicator = data._borroweddownpaymentindicator;
			_borroweddownpaymentindicator_assigned = data._borroweddownpaymentindicator_assigned;
			// assigns the CoMakerEndorserOfNoteIndicator data to the class member
			_comakerendorserofnoteindicator = data._comakerendorserofnoteindicator;
			_comakerendorserofnoteindicator_assigned = data._comakerendorserofnoteindicator_assigned;
			// assigns the HomeownerPastThreeYearsType data to the class member
			_homeownerpastthreeyearstype = data._homeownerpastthreeyearstype;
			_homeownerpastthreeyearstype_isnull = data._homeownerpastthreeyearstype_isnull;
			// assigns the IntentToOccupyType data to the class member
			_intenttooccupytype = data._intenttooccupytype;
			_intenttooccupytype_isnull = data._intenttooccupytype_isnull;
			// assigns the LoanForeclosureOrJudgementIndicator data to the class member
			_loanforeclosureorjudgementindicator = data._loanforeclosureorjudgementindicator;
			_loanforeclosureorjudgementindicator_assigned = data._loanforeclosureorjudgementindicator_assigned;
			// assigns the OutstandingJudgementsIndicator data to the class member
			_outstandingjudgementsindicator = data._outstandingjudgementsindicator;
			_outstandingjudgementsindicator_assigned = data._outstandingjudgementsindicator_assigned;
			// assigns the PartyToLawsuitIndicator data to the class member
			_partytolawsuitindicator = data._partytolawsuitindicator;
			_partytolawsuitindicator_assigned = data._partytolawsuitindicator_assigned;
			// assigns the PresentlyDelinquentIndicator data to the class member
			_presentlydelinquentindicator = data._presentlydelinquentindicator;
			_presentlydelinquentindicator_assigned = data._presentlydelinquentindicator_assigned;
			// assigns the PropertyForeclosedPastSevenYearsIndicator data to the class member
			_propertyforeclosedpastsevenyearsindicator = data._propertyforeclosedpastsevenyearsindicator;
			_propertyforeclosedpastsevenyearsindicator_assigned = data._propertyforeclosedpastsevenyearsindicator_assigned;
			// assigns the CitizenshipResidencyType data to the class member
			_citizenshipresidencytype = data._citizenshipresidencytype;
			_citizenshipresidencytype_isnull = data._citizenshipresidencytype_isnull;
			// assigns the PriorPropertyTitleType data to the class member
			_priorpropertytitletype = data._priorpropertytitletype;
			_priorpropertytitletype_isnull = data._priorpropertytitletype_isnull;
			// assigns the PriorPropertyUsageType data to the class member
			_priorpropertyusagetype = data._priorpropertyusagetype;
			_priorpropertyusagetype_isnull = data._priorpropertyusagetype_isnull;


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
			// assigns the AlimonyChildSupportObligationIndicator data to the class member
			_alimonychildsupportobligationindicator = Convert.ToBoolean(data["AlimonyChildSupportObligationIndicator"]);
			_alimonychildsupportobligationindicator_assigned = true;
			// assigns the BankruptcyIndicator data to the class member
			_bankruptcyindicator = Convert.ToBoolean(data["BankruptcyIndicator"]);
			_bankruptcyindicator_assigned = true;
			// assigns the BorrowedDownPaymentIndicator data to the class member
			_borroweddownpaymentindicator = Convert.ToBoolean(data["BorrowedDownPaymentIndicator"]);
			_borroweddownpaymentindicator_assigned = true;
			// assigns the CoMakerEndorserOfNoteIndicator data to the class member
			_comakerendorserofnoteindicator = Convert.ToBoolean(data["CoMakerEndorserOfNoteIndicator"]);
			_comakerendorserofnoteindicator_assigned = true;
			// assigns the HomeownerPastThreeYearsType data to the class member
			if (data["HomeownerPastThreeYearsType"] == System.DBNull.Value)
				SetHomeownerPastThreeYearsTypeNull();
			else
			{
				_homeownerpastthreeyearstype = Convert.ToBoolean(data["HomeownerPastThreeYearsType"]);
				_homeownerpastthreeyearstype_isnull = false;
			}
			// assigns the IntentToOccupyType data to the class member
			if (data["IntentToOccupyType"] == System.DBNull.Value)
				SetIntentToOccupyTypeNull();
			else
			{
				_intenttooccupytype = Convert.ToBoolean(data["IntentToOccupyType"]);
				_intenttooccupytype_isnull = false;
			}
			// assigns the LoanForeclosureOrJudgementIndicator data to the class member
			_loanforeclosureorjudgementindicator = Convert.ToBoolean(data["LoanForeclosureOrJudgementIndicator"]);
			_loanforeclosureorjudgementindicator_assigned = true;
			// assigns the OutstandingJudgementsIndicator data to the class member
			_outstandingjudgementsindicator = Convert.ToBoolean(data["OutstandingJudgementsIndicator"]);
			_outstandingjudgementsindicator_assigned = true;
			// assigns the PartyToLawsuitIndicator data to the class member
			_partytolawsuitindicator = Convert.ToBoolean(data["PartyToLawsuitIndicator"]);
			_partytolawsuitindicator_assigned = true;
			// assigns the PresentlyDelinquentIndicator data to the class member
			_presentlydelinquentindicator = Convert.ToBoolean(data["PresentlyDelinquentIndicator"]);
			_presentlydelinquentindicator_assigned = true;
			// assigns the PropertyForeclosedPastSevenYearsIndicator data to the class member
			_propertyforeclosedpastsevenyearsindicator = Convert.ToBoolean(data["PropertyForeclosedPastSevenYearsIndicator"]);
			_propertyforeclosedpastsevenyearsindicator_assigned = true;
			// assigns the CitizenshipResidencyType data to the class member
			if (data["CitizenshipResidencyType"] == System.DBNull.Value)
				SetCitizenshipResidencyTypeNull();
			else
			{
				_citizenshipresidencytype = Convert.ToInt16(data["CitizenshipResidencyType"]);
				_citizenshipresidencytype_isnull = false;
			}
			// assigns the PriorPropertyTitleType data to the class member
			if (data["PriorPropertyTitleType"] == System.DBNull.Value)
				SetPriorPropertyTitleTypeNull();
			else
			{
				_priorpropertytitletype = Convert.ToInt16(data["PriorPropertyTitleType"]);
				_priorpropertytitletype_isnull = false;
			}
			// assigns the PriorPropertyUsageType data to the class member
			if (data["PriorPropertyUsageType"] == System.DBNull.Value)
				SetPriorPropertyUsageTypeNull();
			else
			{
				_priorpropertyusagetype = Convert.ToInt16(data["PriorPropertyUsageType"]);
				_priorpropertyusagetype_isnull = false;
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
			// assigns the AlimonyChildSupportObligationIndicator data to the class member
			_alimonychildsupportobligationindicator = Convert.ToBoolean(data["AlimonyChildSupportObligationIndicator"]);
			_alimonychildsupportobligationindicator_assigned = true;
			// assigns the BankruptcyIndicator data to the class member
			_bankruptcyindicator = Convert.ToBoolean(data["BankruptcyIndicator"]);
			_bankruptcyindicator_assigned = true;
			// assigns the BorrowedDownPaymentIndicator data to the class member
			_borroweddownpaymentindicator = Convert.ToBoolean(data["BorrowedDownPaymentIndicator"]);
			_borroweddownpaymentindicator_assigned = true;
			// assigns the CoMakerEndorserOfNoteIndicator data to the class member
			_comakerendorserofnoteindicator = Convert.ToBoolean(data["CoMakerEndorserOfNoteIndicator"]);
			_comakerendorserofnoteindicator_assigned = true;
			// assigns the HomeownerPastThreeYearsType data to the class member
			if (data["HomeownerPastThreeYearsType"] == System.DBNull.Value)
				SetHomeownerPastThreeYearsTypeNull();
			else
			{
				_homeownerpastthreeyearstype = Convert.ToBoolean(data["HomeownerPastThreeYearsType"]);
				_homeownerpastthreeyearstype_isnull = false;
			}
			// assigns the IntentToOccupyType data to the class member
			if (data["IntentToOccupyType"] == System.DBNull.Value)
				SetIntentToOccupyTypeNull();
			else
			{
				_intenttooccupytype = Convert.ToBoolean(data["IntentToOccupyType"]);
				_intenttooccupytype_isnull = false;
			}
			// assigns the LoanForeclosureOrJudgementIndicator data to the class member
			_loanforeclosureorjudgementindicator = Convert.ToBoolean(data["LoanForeclosureOrJudgementIndicator"]);
			_loanforeclosureorjudgementindicator_assigned = true;
			// assigns the OutstandingJudgementsIndicator data to the class member
			_outstandingjudgementsindicator = Convert.ToBoolean(data["OutstandingJudgementsIndicator"]);
			_outstandingjudgementsindicator_assigned = true;
			// assigns the PartyToLawsuitIndicator data to the class member
			_partytolawsuitindicator = Convert.ToBoolean(data["PartyToLawsuitIndicator"]);
			_partytolawsuitindicator_assigned = true;
			// assigns the PresentlyDelinquentIndicator data to the class member
			_presentlydelinquentindicator = Convert.ToBoolean(data["PresentlyDelinquentIndicator"]);
			_presentlydelinquentindicator_assigned = true;
			// assigns the PropertyForeclosedPastSevenYearsIndicator data to the class member
			_propertyforeclosedpastsevenyearsindicator = Convert.ToBoolean(data["PropertyForeclosedPastSevenYearsIndicator"]);
			_propertyforeclosedpastsevenyearsindicator_assigned = true;
			// assigns the CitizenshipResidencyType data to the class member
			if (data["CitizenshipResidencyType"] == System.DBNull.Value)
				SetCitizenshipResidencyTypeNull();
			else
			{
				_citizenshipresidencytype = Convert.ToInt16(data["CitizenshipResidencyType"]);
				_citizenshipresidencytype_isnull = false;
			}
			// assigns the PriorPropertyTitleType data to the class member
			if (data["PriorPropertyTitleType"] == System.DBNull.Value)
				SetPriorPropertyTitleTypeNull();
			else
			{
				_priorpropertytitletype = Convert.ToInt16(data["PriorPropertyTitleType"]);
				_priorpropertytitletype_isnull = false;
			}
			// assigns the PriorPropertyUsageType data to the class member
			if (data["PriorPropertyUsageType"] == System.DBNull.Value)
				SetPriorPropertyUsageTypeNull();
			else
			{
				_priorpropertyusagetype = Convert.ToInt16(data["PriorPropertyUsageType"]);
				_priorpropertyusagetype_isnull = false;
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
			DeclarationBase.ServiceObject.Persist(this as Declaration, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the DECLARATION object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			DeclarationBase.ServiceObject.Delete(this as Declaration);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the EXPLANATION relationship.
		/// </summary>
		public Explanations GetExplanations()
		{
			Explanations explanations = new Explanations();


			ExplanationBase.ServiceObject.FillByDeclaration(explanations, _borrowerid);
			return explanations;
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
		/// Gets the single object for the CitizenshipResidencyType relationship.
		/// </summary>
		public CitizenshipResidencyType GetCitizenshipResidencyType()
		{
			if (_citizenshipresidencytype_isnull)
				return null;
			else
				return new CitizenshipResidencyType(_citizenshipresidencytype);
		}


		/// <summary>
		/// Gets the single object for the PriorPropertyUsageType relationship.
		/// </summary>
		public PriorPropertyUsageType GetPriorPropertyUsageType()
		{
			if (_priorpropertyusagetype_isnull)
				return null;
			else
				return new PriorPropertyUsageType(_priorpropertyusagetype);
		}


		/// <summary>
		/// Gets the single object for the PriorPropertyTitleType relationship.
		/// </summary>
		public PriorPropertyTitleType GetPriorPropertyTitleType()
		{
			if (_priorpropertytitletype_isnull)
				return null;
			else
				return new PriorPropertyTitleType(_priorpropertytitletype);
		}


		/// <summary>
		/// Gets all persisted Declaration objects
		/// </summary>
		public static Declarations GetAll()
		{
			// have the service object get the objects
			return DeclarationBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
