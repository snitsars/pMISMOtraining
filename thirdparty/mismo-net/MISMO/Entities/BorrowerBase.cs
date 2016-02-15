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
	/// A class that represents an abstract entity for table 'BORROWER'
	/// </summary>
	[Serializable]
	public abstract class BorrowerBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BorrowerBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.Borrower)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public BorrowerBase(System.Int64 id)
		{
			// Fill this instance.
			BorrowerBase.ServiceObject.Fill(this as Borrower, id);
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
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _jointassetborrowerid_isnull = true;
		/// <summary>
		/// Member that stores the value for the jointassetborrowerid.
		/// </summary>
		internal System.Int64 _jointassetborrowerid;
		/// <summary>
		/// Gets and sets the JointAssetBorrowerID value of the class instance.
		/// </summary>
		public virtual System.Int64 JointAssetBorrowerID
		{
			get
			{
				return _jointassetborrowerid;
			}
			set
			{
				_jointassetborrowerid = value;
				_jointassetborrowerid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the JointAssetBorrowerID value to see if it was set to null.
		/// </summary>
		public System.Boolean JointAssetBorrowerIDIsNull
		{
			get
			{
				return _jointassetborrowerid_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _loanapplicationid_isnull = true;
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
				_loanapplicationid_isnull = false;
			}
		}


		/// <summary>
		/// Checks the LoanApplicationId value to see if it was set to null.
		/// </summary>
		public System.Boolean LoanApplicationIdIsNull
		{
			get
			{
				return _loanapplicationid_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the firstname.
		/// </summary>
		internal System.String _firstname;
		/// <summary>
		/// Gets and sets the FirstName value of the class instance.
		/// </summary>
		public virtual System.String FirstName
		{
			get
			{
				return _firstname;
			}
			set
			{
				_firstname = value;
			}
		}


		/// <summary>
		/// Checks the FirstName value to see if it was set to null.
		/// </summary>
		public System.Boolean FirstNameIsNull
		{
			get
			{
				return (_firstname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the middlename.
		/// </summary>
		internal System.String _middlename;
		/// <summary>
		/// Gets and sets the MiddleName value of the class instance.
		/// </summary>
		public virtual System.String MiddleName
		{
			get
			{
				return _middlename;
			}
			set
			{
				_middlename = value;
			}
		}


		/// <summary>
		/// Checks the MiddleName value to see if it was set to null.
		/// </summary>
		public System.Boolean MiddleNameIsNull
		{
			get
			{
				return (_middlename == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the lastname.
		/// </summary>
		internal System.String _lastname;
		/// <summary>
		/// Gets and sets the LastName value of the class instance.
		/// </summary>
		public virtual System.String LastName
		{
			get
			{
				return _lastname;
			}
			set
			{
				_lastname = value;
			}
		}


		/// <summary>
		/// Checks the LastName value to see if it was set to null.
		/// </summary>
		public System.Boolean LastNameIsNull
		{
			get
			{
				return (_lastname == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the namesuffix.
		/// </summary>
		internal System.String _namesuffix;
		/// <summary>
		/// Gets and sets the NameSuffix value of the class instance.
		/// </summary>
		public virtual System.String NameSuffix
		{
			get
			{
				return _namesuffix;
			}
			set
			{
				_namesuffix = value;
			}
		}


		/// <summary>
		/// Checks the NameSuffix value to see if it was set to null.
		/// </summary>
		public System.Boolean NameSuffixIsNull
		{
			get
			{
				return (_namesuffix == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _ageatapplicationyears_isnull = true;
		/// <summary>
		/// Member that stores the value for the ageatapplicationyears.
		/// </summary>
		internal System.Decimal _ageatapplicationyears;
		/// <summary>
		/// Gets and sets the AgeAtApplicationYears value of the class instance.
		/// </summary>
		public virtual System.Decimal AgeAtApplicationYears
		{
			get
			{
				return _ageatapplicationyears;
			}
			set
			{
				_ageatapplicationyears = value;
				_ageatapplicationyears_isnull = false;
			}
		}


		/// <summary>
		/// Checks the AgeAtApplicationYears value to see if it was set to null.
		/// </summary>
		public System.Boolean AgeAtApplicationYearsIsNull
		{
			get
			{
				return _ageatapplicationyears_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _birthdate_isnull = true;
		/// <summary>
		/// Member that stores the value for the birthdate.
		/// </summary>
		internal System.DateTime _birthdate;
		/// <summary>
		/// Gets and sets the BirthDate value of the class instance.
		/// </summary>
		public virtual System.DateTime BirthDate
		{
			get
			{
				return _birthdate;
			}
			set
			{
				_birthdate = value;
				_birthdate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BirthDate value to see if it was set to null.
		/// </summary>
		public System.Boolean BirthDateIsNull
		{
			get
			{
				return _birthdate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _applicationsigneddate_isnull = true;
		/// <summary>
		/// Member that stores the value for the applicationsigneddate.
		/// </summary>
		internal System.DateTime _applicationsigneddate;
		/// <summary>
		/// Gets and sets the ApplicationSignedDate value of the class instance.
		/// </summary>
		public virtual System.DateTime ApplicationSignedDate
		{
			get
			{
				return _applicationsigneddate;
			}
			set
			{
				_applicationsigneddate = value;
				_applicationsigneddate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the ApplicationSignedDate value to see if it was set to null.
		/// </summary>
		public System.Boolean ApplicationSignedDateIsNull
		{
			get
			{
				return _applicationsigneddate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the hometelephonenumber.
		/// </summary>
		internal System.String _hometelephonenumber;
		/// <summary>
		/// Gets and sets the HomeTelephoneNumber value of the class instance.
		/// </summary>
		public virtual System.String HomeTelephoneNumber
		{
			get
			{
				return _hometelephonenumber;
			}
			set
			{
				_hometelephonenumber = value;
			}
		}


		/// <summary>
		/// Checks the HomeTelephoneNumber value to see if it was set to null.
		/// </summary>
		public System.Boolean HomeTelephoneNumberIsNull
		{
			get
			{
				return (_hometelephonenumber == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the ssn.
		/// </summary>
		internal System.String _ssn;
		/// <summary>
		/// Gets and sets the SSN value of the class instance.
		/// </summary>
		public virtual System.String SSN
		{
			get
			{
				return _ssn;
			}
			set
			{
				_ssn = value;
			}
		}


		/// <summary>
		/// Checks the SSN value to see if it was set to null.
		/// </summary>
		public System.Boolean SSNIsNull
		{
			get
			{
				return (_ssn == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _dependentcount_isnull = true;
		/// <summary>
		/// Member that stores the value for the dependentcount.
		/// </summary>
		internal System.Byte _dependentcount;
		/// <summary>
		/// Gets and sets the DependentCount value of the class instance.
		/// </summary>
		public virtual System.Byte DependentCount
		{
			get
			{
				return _dependentcount;
			}
			set
			{
				_dependentcount = value;
				_dependentcount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the DependentCount value to see if it was set to null.
		/// </summary>
		public System.Boolean DependentCountIsNull
		{
			get
			{
				return _dependentcount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _schoolingyears_isnull = true;
		/// <summary>
		/// Member that stores the value for the schoolingyears.
		/// </summary>
		internal System.Decimal _schoolingyears;
		/// <summary>
		/// Gets and sets the SchoolingYears value of the class instance.
		/// </summary>
		public virtual System.Decimal SchoolingYears
		{
			get
			{
				return _schoolingyears;
			}
			set
			{
				_schoolingyears = value;
				_schoolingyears_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SchoolingYears value to see if it was set to null.
		/// </summary>
		public System.Boolean SchoolingYearsIsNull
		{
			get
			{
				return _schoolingyears_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the creditreportidentifier.
		/// </summary>
		internal System.String _creditreportidentifier;
		/// <summary>
		/// Gets and sets the CreditReportIdentifier value of the class instance.
		/// </summary>
		public virtual System.String CreditReportIdentifier
		{
			get
			{
				return _creditreportidentifier;
			}
			set
			{
				_creditreportidentifier = value;
			}
		}


		/// <summary>
		/// Checks the CreditReportIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean CreditReportIdentifierIsNull
		{
			get
			{
				return (_creditreportidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _maritalstatustype_isnull = true;
		/// <summary>
		/// Member that stores the value for the maritalstatustype.
		/// </summary>
		internal System.Int16 _maritalstatustype;
		/// <summary>
		/// Gets and sets the MaritalStatusType value of the class instance.
		/// </summary>
		public virtual System.Int16 MaritalStatusType
		{
			get
			{
				return _maritalstatustype;
			}
			set
			{
				_maritalstatustype = value;
				_maritalstatustype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the MaritalStatusType value to see if it was set to null.
		/// </summary>
		public System.Boolean MaritalStatusTypeIsNull
		{
			get
			{
				return _maritalstatustype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _printpositiontype_isnull = true;
		/// <summary>
		/// Member that stores the value for the printpositiontype.
		/// </summary>
		internal System.Int16 _printpositiontype;
		/// <summary>
		/// Gets and sets the PrintPositionType value of the class instance.
		/// </summary>
		public virtual System.Int16 PrintPositionType
		{
			get
			{
				return _printpositiontype;
			}
			set
			{
				_printpositiontype = value;
				_printpositiontype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PrintPositionType value to see if it was set to null.
		/// </summary>
		public System.Boolean PrintPositionTypeIsNull
		{
			get
			{
				return _printpositiontype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _jointassetliabilityreportingtype_isnull = true;
		/// <summary>
		/// Member that stores the value for the jointassetliabilityreportingtype.
		/// </summary>
		internal System.Int16 _jointassetliabilityreportingtype;
		/// <summary>
		/// Gets and sets the JointAssetLiabilityReportingType value of the class instance.
		/// </summary>
		public virtual System.Int16 JointAssetLiabilityReportingType
		{
			get
			{
				return _jointassetliabilityreportingtype;
			}
			set
			{
				_jointassetliabilityreportingtype = value;
				_jointassetliabilityreportingtype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the JointAssetLiabilityReportingType value to see if it was set to null.
		/// </summary>
		public System.Boolean JointAssetLiabilityReportingTypeIsNull
		{
			get
			{
				return _jointassetliabilityreportingtype_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the BorrowerBase.
		/// </summary>
		internal static BorrowerService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(BorrowerService)) as BorrowerService;
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




				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the JointAssetBorrowerID value as null.
		/// </summary>
		public virtual void SetJointAssetBorrowerIDNull()
		{
			_jointassetborrowerid = 0;
			_jointassetborrowerid_isnull = true;
		}


		/// <summary>
		/// Marks the LoanApplicationId value as null.
		/// </summary>
		public virtual void SetLoanApplicationIdNull()
		{
			_loanapplicationid = 0;
			_loanapplicationid_isnull = true;
		}


		/// <summary>
		/// Marks the FirstName value as null.
		/// </summary>
		public virtual void SetFirstNameNull()
		{
			_firstname = null;
		}


		/// <summary>
		/// Marks the MiddleName value as null.
		/// </summary>
		public virtual void SetMiddleNameNull()
		{
			_middlename = null;
		}


		/// <summary>
		/// Marks the LastName value as null.
		/// </summary>
		public virtual void SetLastNameNull()
		{
			_lastname = null;
		}


		/// <summary>
		/// Marks the NameSuffix value as null.
		/// </summary>
		public virtual void SetNameSuffixNull()
		{
			_namesuffix = null;
		}


		/// <summary>
		/// Marks the AgeAtApplicationYears value as null.
		/// </summary>
		public virtual void SetAgeAtApplicationYearsNull()
		{
			_ageatapplicationyears = 0;
			_ageatapplicationyears_isnull = true;
		}


		/// <summary>
		/// Marks the BirthDate value as null.
		/// </summary>
		public virtual void SetBirthDateNull()
		{
			_birthdate = DateTime.MinValue;
			_birthdate_isnull = true;
		}


		/// <summary>
		/// Marks the ApplicationSignedDate value as null.
		/// </summary>
		public virtual void SetApplicationSignedDateNull()
		{
			_applicationsigneddate = DateTime.MinValue;
			_applicationsigneddate_isnull = true;
		}


		/// <summary>
		/// Marks the HomeTelephoneNumber value as null.
		/// </summary>
		public virtual void SetHomeTelephoneNumberNull()
		{
			_hometelephonenumber = null;
		}


		/// <summary>
		/// Marks the SSN value as null.
		/// </summary>
		public virtual void SetSSNNull()
		{
			_ssn = null;
		}


		/// <summary>
		/// Marks the DependentCount value as null.
		/// </summary>
		public virtual void SetDependentCountNull()
		{
			_dependentcount = 0;
			_dependentcount_isnull = true;
		}


		/// <summary>
		/// Marks the SchoolingYears value as null.
		/// </summary>
		public virtual void SetSchoolingYearsNull()
		{
			_schoolingyears = 0;
			_schoolingyears_isnull = true;
		}


		/// <summary>
		/// Marks the CreditReportIdentifier value as null.
		/// </summary>
		public virtual void SetCreditReportIdentifierNull()
		{
			_creditreportidentifier = null;
		}


		/// <summary>
		/// Marks the MaritalStatusType value as null.
		/// </summary>
		public virtual void SetMaritalStatusTypeNull()
		{
			_maritalstatustype = 0;
			_maritalstatustype_isnull = true;
		}


		/// <summary>
		/// Marks the PrintPositionType value as null.
		/// </summary>
		public virtual void SetPrintPositionTypeNull()
		{
			_printpositiontype = 0;
			_printpositiontype_isnull = true;
		}


		/// <summary>
		/// Marks the JointAssetLiabilityReportingType value as null.
		/// </summary>
		public virtual void SetJointAssetLiabilityReportingTypeNull()
		{
			_jointassetliabilityreportingtype = 0;
			_jointassetliabilityreportingtype_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref BorrowerBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the JointAssetBorrowerID data to the class member
			_jointassetborrowerid = data._jointassetborrowerid;
			_jointassetborrowerid_isnull = data._jointassetborrowerid_isnull;
			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_isnull = data._loanapplicationid_isnull;
			// assigns the FirstName data to the class member
			_firstname = data._firstname;
			// assigns the MiddleName data to the class member
			_middlename = data._middlename;
			// assigns the LastName data to the class member
			_lastname = data._lastname;
			// assigns the NameSuffix data to the class member
			_namesuffix = data._namesuffix;
			// assigns the AgeAtApplicationYears data to the class member
			_ageatapplicationyears = data._ageatapplicationyears;
			_ageatapplicationyears_isnull = data._ageatapplicationyears_isnull;
			// assigns the BirthDate data to the class member
			_birthdate = data._birthdate;
			_birthdate_isnull = data._birthdate_isnull;
			// assigns the ApplicationSignedDate data to the class member
			_applicationsigneddate = data._applicationsigneddate;
			_applicationsigneddate_isnull = data._applicationsigneddate_isnull;
			// assigns the HomeTelephoneNumber data to the class member
			_hometelephonenumber = data._hometelephonenumber;
			// assigns the SSN data to the class member
			_ssn = data._ssn;
			// assigns the DependentCount data to the class member
			_dependentcount = data._dependentcount;
			_dependentcount_isnull = data._dependentcount_isnull;
			// assigns the SchoolingYears data to the class member
			_schoolingyears = data._schoolingyears;
			_schoolingyears_isnull = data._schoolingyears_isnull;
			// assigns the CreditReportIdentifier data to the class member
			_creditreportidentifier = data._creditreportidentifier;
			// assigns the MaritalStatusType data to the class member
			_maritalstatustype = data._maritalstatustype;
			_maritalstatustype_isnull = data._maritalstatustype_isnull;
			// assigns the PrintPositionType data to the class member
			_printpositiontype = data._printpositiontype;
			_printpositiontype_isnull = data._printpositiontype_isnull;
			// assigns the JointAssetLiabilityReportingType data to the class member
			_jointassetliabilityreportingtype = data._jointassetliabilityreportingtype;
			_jointassetliabilityreportingtype_isnull = data._jointassetliabilityreportingtype_isnull;


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
			// assigns the JointAssetBorrowerID data to the class member
			if (data["JointAssetBorrowerID"] == System.DBNull.Value)
				SetJointAssetBorrowerIDNull();
			else
			{
				_jointassetborrowerid = Convert.ToInt64(data["JointAssetBorrowerID"]);
				_jointassetborrowerid_isnull = false;
			}
			// assigns the LoanApplicationId data to the class member
			if (data["LoanApplicationId"] == System.DBNull.Value)
				SetLoanApplicationIdNull();
			else
			{
				_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
				_loanapplicationid_isnull = false;
			}
			// assigns the FirstName data to the class member
			if (data["FirstName"] == System.DBNull.Value)
				SetFirstNameNull();
			else
			{
				_firstname = Convert.ToString(data["FirstName"]);
			}
			// assigns the MiddleName data to the class member
			if (data["MiddleName"] == System.DBNull.Value)
				SetMiddleNameNull();
			else
			{
				_middlename = Convert.ToString(data["MiddleName"]);
			}
			// assigns the LastName data to the class member
			if (data["LastName"] == System.DBNull.Value)
				SetLastNameNull();
			else
			{
				_lastname = Convert.ToString(data["LastName"]);
			}
			// assigns the NameSuffix data to the class member
			if (data["NameSuffix"] == System.DBNull.Value)
				SetNameSuffixNull();
			else
			{
				_namesuffix = Convert.ToString(data["NameSuffix"]);
			}
			// assigns the AgeAtApplicationYears data to the class member
			if (data["AgeAtApplicationYears"] == System.DBNull.Value)
				SetAgeAtApplicationYearsNull();
			else
			{
				_ageatapplicationyears = Convert.ToDecimal(data["AgeAtApplicationYears"]);
				_ageatapplicationyears_isnull = false;
			}
			// assigns the BirthDate data to the class member
			if (data["BirthDate"] == System.DBNull.Value)
				SetBirthDateNull();
			else
			{
				_birthdate = Convert.ToDateTime(data["BirthDate"]);
				_birthdate_isnull = false;
			}
			// assigns the ApplicationSignedDate data to the class member
			if (data["ApplicationSignedDate"] == System.DBNull.Value)
				SetApplicationSignedDateNull();
			else
			{
				_applicationsigneddate = Convert.ToDateTime(data["ApplicationSignedDate"]);
				_applicationsigneddate_isnull = false;
			}
			// assigns the HomeTelephoneNumber data to the class member
			if (data["HomeTelephoneNumber"] == System.DBNull.Value)
				SetHomeTelephoneNumberNull();
			else
			{
				_hometelephonenumber = Convert.ToString(data["HomeTelephoneNumber"]);
			}
			// assigns the SSN data to the class member
			if (data["SSN"] == System.DBNull.Value)
				SetSSNNull();
			else
			{
				_ssn = Convert.ToString(data["SSN"]);
			}
			// assigns the DependentCount data to the class member
			if (data["DependentCount"] == System.DBNull.Value)
				SetDependentCountNull();
			else
			{
				_dependentcount = Convert.ToByte(data["DependentCount"]);
				_dependentcount_isnull = false;
			}
			// assigns the SchoolingYears data to the class member
			if (data["SchoolingYears"] == System.DBNull.Value)
				SetSchoolingYearsNull();
			else
			{
				_schoolingyears = Convert.ToDecimal(data["SchoolingYears"]);
				_schoolingyears_isnull = false;
			}
			// assigns the CreditReportIdentifier data to the class member
			if (data["CreditReportIdentifier"] == System.DBNull.Value)
				SetCreditReportIdentifierNull();
			else
			{
				_creditreportidentifier = Convert.ToString(data["CreditReportIdentifier"]);
			}
			// assigns the MaritalStatusType data to the class member
			if (data["MaritalStatusType"] == System.DBNull.Value)
				SetMaritalStatusTypeNull();
			else
			{
				_maritalstatustype = Convert.ToInt16(data["MaritalStatusType"]);
				_maritalstatustype_isnull = false;
			}
			// assigns the PrintPositionType data to the class member
			if (data["PrintPositionType"] == System.DBNull.Value)
				SetPrintPositionTypeNull();
			else
			{
				_printpositiontype = Convert.ToInt16(data["PrintPositionType"]);
				_printpositiontype_isnull = false;
			}
			// assigns the JointAssetLiabilityReportingType data to the class member
			if (data["JointAssetLiabilityReportingType"] == System.DBNull.Value)
				SetJointAssetLiabilityReportingTypeNull();
			else
			{
				_jointassetliabilityreportingtype = Convert.ToInt16(data["JointAssetLiabilityReportingType"]);
				_jointassetliabilityreportingtype_isnull = false;
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
			// assigns the JointAssetBorrowerID data to the class member
			if (data["JointAssetBorrowerID"] == System.DBNull.Value)
				SetJointAssetBorrowerIDNull();
			else
			{
				_jointassetborrowerid = Convert.ToInt64(data["JointAssetBorrowerID"]);
				_jointassetborrowerid_isnull = false;
			}
			// assigns the LoanApplicationId data to the class member
			if (data["LoanApplicationId"] == System.DBNull.Value)
				SetLoanApplicationIdNull();
			else
			{
				_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
				_loanapplicationid_isnull = false;
			}
			// assigns the FirstName data to the class member
			if (data["FirstName"] == System.DBNull.Value)
				SetFirstNameNull();
			else
			{
				_firstname = Convert.ToString(data["FirstName"]);
			}
			// assigns the MiddleName data to the class member
			if (data["MiddleName"] == System.DBNull.Value)
				SetMiddleNameNull();
			else
			{
				_middlename = Convert.ToString(data["MiddleName"]);
			}
			// assigns the LastName data to the class member
			if (data["LastName"] == System.DBNull.Value)
				SetLastNameNull();
			else
			{
				_lastname = Convert.ToString(data["LastName"]);
			}
			// assigns the NameSuffix data to the class member
			if (data["NameSuffix"] == System.DBNull.Value)
				SetNameSuffixNull();
			else
			{
				_namesuffix = Convert.ToString(data["NameSuffix"]);
			}
			// assigns the AgeAtApplicationYears data to the class member
			if (data["AgeAtApplicationYears"] == System.DBNull.Value)
				SetAgeAtApplicationYearsNull();
			else
			{
				_ageatapplicationyears = Convert.ToDecimal(data["AgeAtApplicationYears"]);
				_ageatapplicationyears_isnull = false;
			}
			// assigns the BirthDate data to the class member
			if (data["BirthDate"] == System.DBNull.Value)
				SetBirthDateNull();
			else
			{
				_birthdate = Convert.ToDateTime(data["BirthDate"]);
				_birthdate_isnull = false;
			}
			// assigns the ApplicationSignedDate data to the class member
			if (data["ApplicationSignedDate"] == System.DBNull.Value)
				SetApplicationSignedDateNull();
			else
			{
				_applicationsigneddate = Convert.ToDateTime(data["ApplicationSignedDate"]);
				_applicationsigneddate_isnull = false;
			}
			// assigns the HomeTelephoneNumber data to the class member
			if (data["HomeTelephoneNumber"] == System.DBNull.Value)
				SetHomeTelephoneNumberNull();
			else
			{
				_hometelephonenumber = Convert.ToString(data["HomeTelephoneNumber"]);
			}
			// assigns the SSN data to the class member
			if (data["SSN"] == System.DBNull.Value)
				SetSSNNull();
			else
			{
				_ssn = Convert.ToString(data["SSN"]);
			}
			// assigns the DependentCount data to the class member
			if (data["DependentCount"] == System.DBNull.Value)
				SetDependentCountNull();
			else
			{
				_dependentcount = Convert.ToByte(data["DependentCount"]);
				_dependentcount_isnull = false;
			}
			// assigns the SchoolingYears data to the class member
			if (data["SchoolingYears"] == System.DBNull.Value)
				SetSchoolingYearsNull();
			else
			{
				_schoolingyears = Convert.ToDecimal(data["SchoolingYears"]);
				_schoolingyears_isnull = false;
			}
			// assigns the CreditReportIdentifier data to the class member
			if (data["CreditReportIdentifier"] == System.DBNull.Value)
				SetCreditReportIdentifierNull();
			else
			{
				_creditreportidentifier = Convert.ToString(data["CreditReportIdentifier"]);
			}
			// assigns the MaritalStatusType data to the class member
			if (data["MaritalStatusType"] == System.DBNull.Value)
				SetMaritalStatusTypeNull();
			else
			{
				_maritalstatustype = Convert.ToInt16(data["MaritalStatusType"]);
				_maritalstatustype_isnull = false;
			}
			// assigns the PrintPositionType data to the class member
			if (data["PrintPositionType"] == System.DBNull.Value)
				SetPrintPositionTypeNull();
			else
			{
				_printpositiontype = Convert.ToInt16(data["PrintPositionType"]);
				_printpositiontype_isnull = false;
			}
			// assigns the JointAssetLiabilityReportingType data to the class member
			if (data["JointAssetLiabilityReportingType"] == System.DBNull.Value)
				SetJointAssetLiabilityReportingTypeNull();
			else
			{
				_jointassetliabilityreportingtype = Convert.ToInt16(data["JointAssetLiabilityReportingType"]);
				_jointassetliabilityreportingtype_isnull = false;
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
			BorrowerBase.ServiceObject.Persist(this as Borrower, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the BORROWER object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			BorrowerBase.ServiceObject.Delete(this as Borrower);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the ALIAS relationship.
		/// </summary>
		public Aliases GetAliases()
		{
			Aliases aliases = new Aliases();


			AliasBase.ServiceObject.FillByBorrower(aliases, _id);
			return aliases;
		}


		/// <summary>
		/// Gets the objects for the ASSET relationship.
		/// </summary>
		public Assets GetAssets()
		{
			Assets assets = new Assets();


			AssetBase.ServiceObject.FillByBorrower(assets, _id);
			return assets;
		}


		/// <summary>
		/// Gets the objects for the BORROWER relationship.
		/// </summary>
		public Borrowers GetBorrowers()
		{
			Borrowers borrowers = new Borrowers();


			BorrowerBase.ServiceObject.FillByBorrower(borrowers, _id);
			return borrowers;
		}


		/// <summary>
		/// Gets the objects for the CONTACT_POINT relationship.
		/// </summary>
		public ContactPointCollection GetContactPointCollection()
		{
			ContactPointCollection contactpointcollection = new ContactPointCollection();


			ContactPointBase.ServiceObject.FillByBorrower(contactpointcollection, _id);
			return contactpointcollection;
		}


		/// <summary>
		/// Gets the objects for the CREDIT_SCORE relationship.
		/// </summary>
		public CreditScores GetCreditScores()
		{
			CreditScores creditscores = new CreditScores();


			CreditScoreBase.ServiceObject.FillByBorrower(creditscores, _id);
			return creditscores;
		}


		/// <summary>
		/// Gets the objects for the CURRENT_INCOME relationship.
		/// </summary>
		public CurrentIncomeCollection GetCurrentIncomeCollection()
		{
			CurrentIncomeCollection currentincomecollection = new CurrentIncomeCollection();


			CurrentIncomeBase.ServiceObject.FillByBorrower(currentincomecollection, _id);
			return currentincomecollection;
		}


		/// <summary>
		/// Gets the objects for the DECLARATION relationship.
		/// </summary>
		public Declarations GetDeclarations()
		{
			Declarations declarations = new Declarations();


			DeclarationBase.ServiceObject.FillByBorrower(declarations, _id);
			return declarations;
		}


		/// <summary>
		/// Gets the objects for the DEPENDENT relationship.
		/// </summary>
		public Dependents GetDependents()
		{
			Dependents dependents = new Dependents();


			DependentBase.ServiceObject.FillByBorrower(dependents, _id);
			return dependents;
		}


		/// <summary>
		/// Gets the objects for the EMPLOYER relationship.
		/// </summary>
		public Employers GetEmployers()
		{
			Employers employers = new Employers();


			EmployerBase.ServiceObject.FillByBorrower(employers, _id);
			return employers;
		}


		/// <summary>
		/// Gets the objects for the FHA_VA_BORROWER relationship.
		/// </summary>
		public FHAVABorrowers GetFHAVABorrowers()
		{
			FHAVABorrowers fhavaborrowers = new FHAVABorrowers();


			FHAVABorrowerBase.ServiceObject.FillByBorrower(fhavaborrowers, _id);
			return fhavaborrowers;
		}


		/// <summary>
		/// Gets the objects for the GOVERNMENT_MONITORING relationship.
		/// </summary>
		public GovernmentMonitoringCollection GetGovernmentMonitoringCollection()
		{
			GovernmentMonitoringCollection governmentmonitoringcollection = new GovernmentMonitoringCollection();


			GovernmentMonitoringBase.ServiceObject.FillByBorrower(governmentmonitoringcollection, _id);
			return governmentmonitoringcollection;
		}


		/// <summary>
		/// Gets the objects for the LIABILITY relationship.
		/// </summary>
		public Liabilities GetLiabilities()
		{
			Liabilities liabilities = new Liabilities();


			LiabilityBase.ServiceObject.FillByBorrower(liabilities, _id);
			return liabilities;
		}


		/// <summary>
		/// Gets the objects for the MAIL_TO relationship.
		/// </summary>
		public MailToCollection GetMailToCollection()
		{
			MailToCollection mailtocollection = new MailToCollection();


			MailToBase.ServiceObject.FillByBorrower(mailtocollection, _id);
			return mailtocollection;
		}


		/// <summary>
		/// Gets the objects for the PRESENT_HOUSING_EXPENSE relationship.
		/// </summary>
		public PresentHousingExpenses GetPresentHousingExpenses()
		{
			PresentHousingExpenses presenthousingexpenses = new PresentHousingExpenses();


			PresentHousingExpenseBase.ServiceObject.FillByBorrower(presenthousingexpenses, _id);
			return presenthousingexpenses;
		}


		/// <summary>
		/// Gets the objects for the REO_PROPERTY relationship.
		/// </summary>
		public REOProperties GetREOProperties()
		{
			REOProperties reoproperties = new REOProperties();


			REOPropertyBase.ServiceObject.FillByBorrower(reoproperties, _id);
			return reoproperties;
		}


		/// <summary>
		/// Gets the objects for the RESIDENCE relationship.
		/// </summary>
		public Residences GetResidences()
		{
			Residences residences = new Residences();


			ResidenceBase.ServiceObject.FillByBorrower(residences, _id);
			return residences;
		}


		/// <summary>
		/// Gets the objects for the SUMMARY relationship.
		/// </summary>
		public Summaries GetSummaries()
		{
			Summaries summaries = new Summaries();


			SummaryBase.ServiceObject.FillByBorrower(summaries, _id);
			return summaries;
		}


		/// <summary>
		/// Gets the objects for the VA_BORROWER relationship.
		/// </summary>
		public VABorrowers GetVABorrowers()
		{
			VABorrowers vaborrowers = new VABorrowers();


			VABorrowerBase.ServiceObject.FillByBorrower(vaborrowers, _id);
			return vaborrowers;
		}


		/// <summary>
		/// Gets the single object for the BORROWER relationship.
		/// </summary>
		public Borrower GetJointAssetBorrowerID()
		{
			if (_jointassetborrowerid_isnull)
				return null;
			else
				return new Borrower(_jointassetborrowerid);
		}


		/// <summary>
		/// Gets the single object for the JointAssetLiabilityReportingType relationship.
		/// </summary>
		public JointAssetLiabilityReportingType GetJointAssetLiabilityReportingType()
		{
			if (_jointassetliabilityreportingtype_isnull)
				return null;
			else
				return new JointAssetLiabilityReportingType(_jointassetliabilityreportingtype);
		}


		/// <summary>
		/// Gets the single object for the LOAN_APPLICATION relationship.
		/// </summary>
		public LoanApplication GetLoanApplication()
		{
			if (_loanapplicationid_isnull)
				return null;
			else
				return new LoanApplication(_loanapplicationid);
		}


		/// <summary>
		/// Gets the single object for the MaritalStatusType relationship.
		/// </summary>
		public MaritalStatusType GetMaritalStatusType()
		{
			if (_maritalstatustype_isnull)
				return null;
			else
				return new MaritalStatusType(_maritalstatustype);
		}


		/// <summary>
		/// Gets the single object for the PrintPositionType relationship.
		/// </summary>
		public PrintPositionType GetPrintPositionType()
		{
			if (_printpositiontype_isnull)
				return null;
			else
				return new PrintPositionType(_printpositiontype);
		}


		/// <summary>
		/// Gets all persisted Borrower objects
		/// </summary>
		public static Borrowers GetAll()
		{
			// have the service object get the objects
			return BorrowerBase.ServiceObject.GetAll();
		}


		/// <summary>
		/// Gets other Borrower objects by the specified criteria parameters.
		/// </summary>
		public static Borrowers GetBySSN(System.String sSN)
		{
			// Create an empty collection to fill
			Borrowers collection = new Borrowers();


			// have the service object fill the collection the objects
			BorrowerBase.ServiceObject.GetBySSN(collection, sSN);
			return collection;
		}



		#endregion Methods

	}
}
