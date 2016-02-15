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
	/// A class that represents an abstract entity for table 'LOAN_APPLICATION'
	/// </summary>
	[Serializable]
	public abstract class LoanApplicationBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanApplicationBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.LoanApplication)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanApplicationBase(System.Int64 id)
		{
			// Fill this instance.
			LoanApplicationBase.ServiceObject.Fill(this as LoanApplication, id);
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
		/// Member that stores the value for the mismoversionid.
		/// </summary>
		internal System.String _mismoversionid;
		/// <summary>
		/// Gets and sets the MISMOVersionID value of the class instance.
		/// </summary>
		public virtual System.String MISMOVersionID
		{
			get
			{
				return _mismoversionid;
			}
			set
			{
				_mismoversionid = value;
			}
		}


		/// <summary>
		/// Checks the MISMOVersionID value to see if it was set to null.
		/// </summary>
		public System.Boolean MISMOVersionIDIsNull
		{
			get
			{
				return (_mismoversionid == null);
			}
		}


		/// <summary>
		/// Gets the service object for the LoanApplicationBase.
		/// </summary>
		internal static LoanApplicationService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(LoanApplicationService)) as LoanApplicationService;
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
		/// Marks the MISMOVersionID value as null.
		/// </summary>
		public virtual void SetMISMOVersionIDNull()
		{
			_mismoversionid = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref LoanApplicationBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			// assigns the MISMOVersionID data to the class member
			_mismoversionid = data._mismoversionid;


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
			// assigns the MISMOVersionID data to the class member
			if (data["MISMOVersionID"] == System.DBNull.Value)
				SetMISMOVersionIDNull();
			else
			{
				_mismoversionid = Convert.ToString(data["MISMOVersionID"]);
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
			// assigns the MISMOVersionID data to the class member
			if (data["MISMOVersionID"] == System.DBNull.Value)
				SetMISMOVersionIDNull();
			else
			{
				_mismoversionid = Convert.ToString(data["MISMOVersionID"]);
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
			LoanApplicationBase.ServiceObject.Persist(this as LoanApplication, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the LOAN_APPLICATION object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			LoanApplicationBase.ServiceObject.Delete(this as LoanApplication);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the ADDITIONAL_CASE_DATA relationship.
		/// </summary>
		public AdditionalCaseDataCollection GetAdditionalCaseDataCollection()
		{
			AdditionalCaseDataCollection additionalcasedatacollection = new AdditionalCaseDataCollection();


			AdditionalCaseDataBase.ServiceObject.FillByLoanApplication(additionalcasedatacollection, _id);
			return additionalcasedatacollection;
		}


		/// <summary>
		/// Gets the objects for the AFFORDABLE_LENDING relationship.
		/// </summary>
		public AffordableLendingCollection GetAffordableLendingCollection()
		{
			AffordableLendingCollection affordablelendingcollection = new AffordableLendingCollection();


			AffordableLendingBase.ServiceObject.FillByLoanApplication(affordablelendingcollection, _id);
			return affordablelendingcollection;
		}


		/// <summary>
		/// Gets the objects for the ASSET relationship.
		/// </summary>
		public Assets GetAssets()
		{
			Assets assets = new Assets();


			AssetBase.ServiceObject.FillByLoanApplication(assets, _id);
			return assets;
		}


		/// <summary>
		/// Gets the objects for the BORROWER relationship.
		/// </summary>
		public Borrowers GetBorrowers()
		{
			Borrowers borrowers = new Borrowers();


			BorrowerBase.ServiceObject.FillByLoanApplication(borrowers, _id);
			return borrowers;
		}


		/// <summary>
		/// Gets the objects for the DATA_INFORMATION relationship.
		/// </summary>
		public DataInformationCollection GetDataInformationCollection()
		{
			DataInformationCollection datainformationcollection = new DataInformationCollection();


			DataInformationBase.ServiceObject.FillByLoanApplication(datainformationcollection, _id);
			return datainformationcollection;
		}


		/// <summary>
		/// Gets the objects for the DOWN_PAYMENT relationship.
		/// </summary>
		public DownPayments GetDownPayments()
		{
			DownPayments downpayments = new DownPayments();


			DownPaymentBase.ServiceObject.FillByLoanApplication(downpayments, _id);
			return downpayments;
		}


		/// <summary>
		/// Gets the objects for the GOVERNMENT_LOAN relationship.
		/// </summary>
		public GovernmentLoans GetGovernmentLoans()
		{
			GovernmentLoans governmentloans = new GovernmentLoans();


			GovernmentLoanBase.ServiceObject.FillByLoanApplication(governmentloans, _id);
			return governmentloans;
		}


		/// <summary>
		/// Gets the objects for the GOVERNMENT_REPORTING relationship.
		/// </summary>
		public GovernmentReportingCollection GetGovernmentReportingCollection()
		{
			GovernmentReportingCollection governmentreportingcollection = new GovernmentReportingCollection();


			GovernmentReportingBase.ServiceObject.FillByLoanApplication(governmentreportingcollection, _id);
			return governmentreportingcollection;
		}


		/// <summary>
		/// Gets the objects for the INTERVIEWER_INFORMATION relationship.
		/// </summary>
		public InterviewerInformationCollection GetInterviewerInformationCollection()
		{
			InterviewerInformationCollection interviewerinformationcollection = new InterviewerInformationCollection();


			InterviewerInformationBase.ServiceObject.FillByLoanApplication(interviewerinformationcollection, _id);
			return interviewerinformationcollection;
		}


		/// <summary>
		/// Gets the objects for the LIABILITY relationship.
		/// </summary>
		public Liabilities GetLiabilities()
		{
			Liabilities liabilities = new Liabilities();


			LiabilityBase.ServiceObject.FillByLoanApplication(liabilities, _id);
			return liabilities;
		}


		/// <summary>
		/// Gets the objects for the LOAN_PRODUCT_DATA relationship.
		/// </summary>
		public LoanProductDataCollection GetLoanProductDataCollection()
		{
			LoanProductDataCollection loanproductdatacollection = new LoanProductDataCollection();


			LoanProductDataBase.ServiceObject.FillByLoanApplication(loanproductdatacollection, _id);
			return loanproductdatacollection;
		}


		/// <summary>
		/// Gets the objects for the LOAN_PURPOSE relationship.
		/// </summary>
		public LoanPurposes GetLoanPurposes()
		{
			LoanPurposes loanpurposes = new LoanPurposes();


			LoanPurposeBase.ServiceObject.FillByLoanApplication(loanpurposes, _id);
			return loanpurposes;
		}


		/// <summary>
		/// Gets the objects for the LOAN_QUALIFICATION relationship.
		/// </summary>
		public LoanQualifications GetLoanQualifications()
		{
			LoanQualifications loanqualifications = new LoanQualifications();


			LoanQualificationBase.ServiceObject.FillByLoanApplication(loanqualifications, _id);
			return loanqualifications;
		}


		/// <summary>
		/// Gets the objects for the MORTGAGE_TERMS relationship.
		/// </summary>
		public MortgageTermsCollection GetMortgageTermsCollection()
		{
			MortgageTermsCollection mortgagetermscollection = new MortgageTermsCollection();


			MortgageTermsBase.ServiceObject.FillByLoanApplication(mortgagetermscollection, _id);
			return mortgagetermscollection;
		}


		/// <summary>
		/// Gets the objects for the PROPERTY relationship.
		/// </summary>
		public Properties GetProperties()
		{
			Properties properties = new Properties();


			PropertyBase.ServiceObject.FillByLoanApplication(properties, _id);
			return properties;
		}


		/// <summary>
		/// Gets the objects for the PROPOSED_HOUSING_EXPENSE relationship.
		/// </summary>
		public ProposedHousingExpenses GetProposedHousingExpenses()
		{
			ProposedHousingExpenses proposedhousingexpenses = new ProposedHousingExpenses();


			ProposedHousingExpenseBase.ServiceObject.FillByLoanApplication(proposedhousingexpenses, _id);
			return proposedhousingexpenses;
		}


		/// <summary>
		/// Gets the objects for the REO_PROPERTY relationship.
		/// </summary>
		public REOProperties GetREOProperties()
		{
			REOProperties reoproperties = new REOProperties();


			REOPropertyBase.ServiceObject.FillByLoanApplication(reoproperties, _id);
			return reoproperties;
		}


		/// <summary>
		/// Gets the objects for the TITLE_HOLDER relationship.
		/// </summary>
		public TitleHolders GetTitleHolders()
		{
			TitleHolders titleholders = new TitleHolders();


			TitleHolderBase.ServiceObject.FillByLoanApplication(titleholders, _id);
			return titleholders;
		}


		/// <summary>
		/// Gets the objects for the TRANSACTION_DETAIL relationship.
		/// </summary>
		public TransactionDetails GetTransactionDetails()
		{
			TransactionDetails transactiondetails = new TransactionDetails();


			TransactionDetailBase.ServiceObject.FillByLoanApplication(transactiondetails, _id);
			return transactiondetails;
		}


		/// <summary>
		/// Gets all persisted LoanApplication objects
		/// </summary>
		public static LoanApplications GetAll()
		{
			// have the service object get the objects
			return LoanApplicationBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
