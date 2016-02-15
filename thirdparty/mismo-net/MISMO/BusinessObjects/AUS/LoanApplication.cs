using System;
using OrcaLogic.Xml;
using System.Data;
using System.Data.SqlClient;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a basic MISMO loan object.
	/// </summary>
	[Serializable]
	public class LoanApplication : MISMO.BusinessObjects.LoanApplication
	{
		#region Field Members

		#endregion Field Members

		#region Constructors

		/// <summary>
		/// Creates a new instance of an unpersisted loan application.
		/// </summary>
		public LoanApplication() : base()
		{

		}

		/// <summary>
		/// Creates a new instance of an existing (persisted) loan application.
		/// </summary>
		/// <param name="appId">The identity of the loan application.</param>
		public LoanApplication(long appId) : base(appId)
		{
			// TODO: add additional fill methods for the rest of the loan object

			// load up the data information
			MISMO.BusinessObjects.DataInformationCollection dats = this.GetDataInformationCollection();
			if (dats != null && dats.Count > 0)
			{
				_datainformation = new DataInformation();
				MISMO.Entities.DataInformationBase datbase = dats[0];
				_datainformation.SetMembers(ref datbase);
			}

			// load up the additional case data.
			MISMO.BusinessObjects.AdditionalCaseDataCollection addcasecol = this.GetAdditionalCaseDataCollection();
			if (addcasecol != null && addcasecol.Count > 0)
			{
				MISMO.Entities.AdditionalCaseDataBase addcasebase = addcasecol[0] as MISMO.Entities.AdditionalCaseDataBase;
				_additionalcasedata = new AdditionalCaseData();
				_additionalcasedata.SetMembers(ref addcasebase);
			}

			// load up the down payment information
			_downpayments = this.GetDownPayments();

			// load up the interviewer information
			MISMO.BusinessObjects.InterviewerInformationCollection intvcol = this.GetInterviewerInformationCollection();
			if (intvcol != null && intvcol.Count > 0)
				_interviewer = intvcol[0];

			// load up the loan product data
			MISMO.BusinessObjects.LoanProductDataCollection loanproducts = this.GetLoanProductDataCollection();
			if (loanproducts != null && loanproducts.Count > 0)
			{
				MISMO.Entities.LoanProductDataBase lpbase = loanproducts[0];
				_loanproductdata = new LoanProductData();
				_loanproductdata.SetMembers(ref lpbase);
			}


			// load up the loan purpose
			MISMO.BusinessObjects.LoanPurposes purps = this.GetLoanPurposes();
			if (purps != null && purps.Count > 0)
			{
				MISMO.Entities.LoanPurposeBase purpbase = purps[0];
				_purpose = new LoanPurpose();
				_purpose.SetMembers(ref purpbase);
			}

			// load up the loan qualification information
			MISMO.BusinessObjects.LoanQualifications lqcol = this.GetLoanQualifications();
			if (lqcol != null && lqcol.Count > 0)
			{
				MISMO.Entities.LoanQualificationBase lqbase = lqcol[0] as MISMO.Entities.LoanQualificationBase;
				_loanqualification.SetMembers(ref lqbase);
			}


			// load up the mortgage terms.
			MISMO.BusinessObjects.MortgageTermsCollection mtgterms = this.GetMortgageTermsCollection();
			if (mtgterms != null && mtgterms.Count > 0)
				_mortgageterms = mtgterms[0];


			// loan up the property information
			MISMO.BusinessObjects.Properties props = this.GetProperties();
			if (props != null && props.Count > 0)
			{
				_prop = new AUS.Property();
				MISMO.Entities.PropertyBase propbase = props[0];
				_prop.SetMembers(ref propbase);
			}

			// load up the proposed housing expenses
			_proposedHousingExpenses = this.GetProposedHousingExpenses();

			// load up the REO properties
			_reoProperties = this.GetREOProperties();

			// load up the title holder objects
			_titleholders = this.GetTitleHolders();

			// load up the transaction details
			MISMO.BusinessObjects.TransactionDetails trandets = this.GetTransactionDetails();
			if (trandets != null && trandets.Count > 0)
			{
				MISMO.Entities.TransactionDetailBase trandbase = trandets[0];
				_transdetail = new AUS.TransactionDetail();
				_transdetail.SetMembers(ref trandbase);
			}

			// load up the borrower information
			MISMO.BusinessObjects.Borrowers bws = this.GetBorrowers();
			MISMO.Entities.BorrowerBase bwsbase = null;
			for(int i = 0, j = bws.Count; i<j; i++)
			{
				MISMO.BusinessObjects.AUS.Borrower ausbw = new Borrower();
				bwsbase = bws[i] as MISMO.Entities.BorrowerBase;
				ausbw.SetMembers(ref bwsbase);
				_borrowers.Add(ausbw);
			}

			// finally update the checksum if this constructor wasn't called from a descendant.
			if (this.GetType() == typeof(MISMO.BusinessObjects.AUS.LoanApplication))
			{
				RecalculateChecksum();
			}
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the interviewer for the loan instance.
		/// </summary>
		protected MISMO.BusinessObjects.InterviewerInformation _interviewer = null;
		/// <summary>
		/// Gets or sets the interviewer for the loan instance.
		/// </summary>
		public MISMO.BusinessObjects.InterviewerInformation InterviewerInformation
		{
			get { return _interviewer; }
			set { _interviewer = value; }
		}

		/// <summary>
		/// Member that stores the data information for the loan instance.
		/// </summary>
		protected DataInformation _datainformation = null;
		/// <summary>
		/// Gets the data information for the loan instance.
		/// </summary>
		public DataInformation DataInformation
		{
			get { return _datainformation; }
		}

		/// <summary>
		/// Member that stores the additional case data information
		/// </summary>
		protected AdditionalCaseData _additionalcasedata = null;
		/// <summary>
		/// Gets the additional case data for the loan instance.
		/// </summary>
		public AdditionalCaseData AdditionalCaseData
		{
			get 
			{
				return _additionalcasedata; 
			}
		}

		/// <summary>
		/// Member that stores the government reporting instance
		/// </summary>
		protected MISMO.BusinessObjects.GovernmentReporting _governmentReporting = null;
		/// <summary>
		/// Gets the government reporting instance
		/// </summary>
		public MISMO.BusinessObjects.GovernmentReporting GovernmentReporting
		{
			get { return _governmentReporting; }
		}


		/// <summary>
		/// Member that stores a reference to the down payments collection.
		/// </summary>
		protected MISMO.BusinessObjects.DownPayments _downpayments = new DownPayments();
		/// <summary>
		/// Gets the down payments for the loan application instance.
		/// </summary>
		public MISMO.BusinessObjects.DownPayments DownPayments
		{
			get { return _downpayments; }
		}

		/// <summary>
		/// Member that stores the borrowers for the loan instance.
		/// </summary>
		protected Borrowers _borrowers = new Borrowers();
		/// <summary>
		/// Gets the borrower collection for the loan instance.
		/// </summary>
		public Borrowers Borrowers
		{
			get { return _borrowers; }
		}

		/// <summary>
		/// Member that stores the proposed housing expenses instance
		/// </summary>
		protected ProposedHousingExpenses _proposedHousingExpenses = new ProposedHousingExpenses();
		/// <summary>
		/// Gets the proposed housing expenses collection instance
		/// </summary>
		public ProposedHousingExpenses ProposedHousingExpenses
		{
			get { return _proposedHousingExpenses; }
		}

		/// <summary>
		/// Member that stores the loan qualification instance
		/// </summary>
		protected MISMO.BusinessObjects.LoanQualification _loanqualification = null;
		/// <summary>
		/// Gets the loan qualification instance
		/// </summary>
		public MISMO.BusinessObjects.LoanQualification Qualification
		{
			get { return _loanqualification; }
		}

		/// <summary>
		/// Member that stores the liabilities for the loan instance
		/// </summary>
		protected Liabilities _liabilities = new Liabilities();
		/// <summary>
		/// Gets the liabilities collection for the loan instance
		/// </summary>
		public Liabilities Liabilities
		{
			get { return _liabilities; }
		}


		/// <summary>
		/// Member that stores a collection of title holder objects.
		/// </summary>
		protected MISMO.BusinessObjects.TitleHolders _titleholders = new TitleHolders();
		/// <summary>
		/// Gets the title holder collection for the current loan application instance.
		/// </summary>
		public MISMO.BusinessObjects.TitleHolders TitleHolders
		{
			get { return _titleholders; }
		}

		/// <summary>
		/// Member that stores the loan product data for the loan application instance.
		/// </summary>
		protected LoanProductData _loanproductdata = null;
		/// <summary>
		/// Gets the loan product data for the loan application instance.
		/// </summary>
		public LoanProductData ProductData
		{
			get 
			{
				return _loanproductdata;
			}
		}


		/// <summary>
		/// Member that stores the mortgage terms.
		/// </summary>
		protected MISMO.BusinessObjects.MortgageTerms _mortgageterms = null;
		/// <summary>
		/// Gets the mortgage terms for the current loan application object.
		/// </summary>
		public MISMO.BusinessObjects.MortgageTerms MortgageTerms
		{
			get 
			{
				return _mortgageterms; 
			}
		}

		/// <summary>
		/// Member that stores the reoproperties instance
		/// </summary>
		protected MISMO.BusinessObjects.REOProperties _reoProperties = new REOProperties();
		/// <summary>
		/// Gets the reoproperties instance
		/// </summary>
		public MISMO.BusinessObjects.REOProperties REOProperties
		{
			get { return _reoProperties; }
		}


		/// <summary>
		/// Member that stores a reference to the property object.
		/// </summary>
		protected Property _prop = null;
		/// <summary>
		/// Gets the property object of the loan instance.
		/// </summary>
		public Property Property
		{
			get 
			{
				return _prop; 
			}
			set 
			{
				_prop = value;
			}
		}

		/// <summary>
		/// Member that stores a reference to the loan purpose object.
		/// </summary>
		protected LoanPurpose _purpose = null;
		/// <summary>
		/// Gets the loan purpose object of the loan instance.
		/// </summary>
		public LoanPurpose Purpose
		{
			get 
			{
				return _purpose; 
			}
			set 
			{
				_purpose = value;
			}
		}

		/// <summary>
		/// Member that stores the transaction detail for a loan instance.
		/// </summary>
		protected MISMO.BusinessObjects.AUS.TransactionDetail _transdetail = null;
		/// <summary>
		/// Gets the transaction detail object of the loan instance.
		/// </summary>
		public MISMO.BusinessObjects.AUS.TransactionDetail TransactionDetail
		{
			get 
			{
				return _transdetail; 
			}
		}



		#endregion Properties

		#region Methods

		/// <summary>
		/// Loads a loan object with data from the external source file.
		/// </summary>
		/// <param name="sourceType">The external system type.</param>
		/// <param name="fileName">The full file name of the source to load.</param>
		public virtual void Load(MISMO.Enums.ExternalFileType sourceType, string fileName)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(fileName);
			if (!file.Exists) throw new System.IO.FileNotFoundException("Could not find file.", fileName);

			System.IO.FileStream fs = file.OpenRead();
			byte[] filedat = new byte[fs.Length];
			fs.Read(filedat, 0, filedat.Length);
			fs.Close();

			Load(sourceType, filedat);
		}

		/// <summary>
		/// Loads a loan object with the specified loan bytes.
		/// </summary>
		/// <param name="sourceType">The type of external file to load.</param>
		/// <param name="fileBytes">The data bytes of the file to load.</param>
		public virtual void Load(MISMO.Enums.ExternalFileType sourceType, byte[] fileBytes)
		{
			// error out if we do not have valid data
			if (fileBytes == null || fileBytes.Length == 0)
				throw new ArgumentException("Null byte data or zero length received. Unable to load from external file.", "fileBytes");

			if (sourceType != Enums.ExternalFileType.FannieMaeResidentialLoanData)
			{
				// we only support DU imports for now.
				throw new NotImplementedException("Support for that external file source type is has not been implemented.");
			}

			switch(sourceType)
			{
				case Enums.ExternalFileType.FannieMaeResidentialLoanData:
				{
					LoadDU(fileBytes);
					break;
				}
			}
		}


		/// <summary>
		/// Loads the loan object with information from a Fannie Mae set of data.
		/// </summary>
		/// <param name="fileBytes">The fannie data bytes.</param>
		protected virtual void LoadDU(byte[] fileBytes)
		{
			DUHelper du = new DUHelper(fileBytes);
			Exception invalidfiledata = new Exception("The file data is not a recognized Fannie Mae DU format.");
			
			#region DATA_INFORMATION

			// capture the versioning information
			int vercount = du.BeginCapture("000");
			if (vercount < 1) throw invalidfiledata;
			else
			{
				this._datainformation = new DataInformation();
				for(int i = 0; i<vercount; i++)
				{
					MISMO.BusinessObjects.DataVersion dv = new DataVersion();
					dv.Name = du.ExtractCaptureData(i, 4, 3);
					if (dv.Name == "1") dv.Name = "1003";
					dv.Number = du.ExtractCaptureData(i, 7, 5);
					this._datainformation.DataVersions.Add(dv);
				}
			}
			du.EndCapture();

			if (vercount > 0 && 
				!(this.DataInformation.DataVersions[0].Number == "3.20" ||
				this.DataInformation.DataVersions[0].Number == "3.2")
				) throw new NotImplementedException("Fannie Mae loader only supports 3.20 DU file formats.");

			#endregion DATA_INFORMATION

			#region MORTGAGE_TERMS

			string tempval = null;

			// extract information for the mortgage terms
			tempval = du.ExtractData("01A", 86, 30);
			if (tempval != string.Empty) 
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.AgencyCaseIdentifier = tempval;
			}

			tempval = du.ExtractData("01A", 238, 80);
			if (tempval != string.Empty) 
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.ARMTypeDescription = tempval;
			}
			
			tempval = du.ExtractData("01A", 131, 15);
			if (tempval != string.Empty) 
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.BaseLoanAmount = Convert.ToDecimal(tempval);
			}
			
			tempval = du.ExtractData("01A", 131, 15);
			if (tempval != string.Empty) 
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.BorrowerRequestedLoanAmount = Convert.ToDecimal(tempval);
			}
			
			tempval = du.ExtractData("01A", 116, 15);
			if (tempval != string.Empty)
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.LenderCaseIdentifier = tempval;
			}
			
			tempval = du.ExtractData("01A", 153, 3);
			if (tempval != string.Empty)
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.LoanAmortizationTermMonths = Convert.ToDecimal(tempval);
			}
			
			tempval = du.ExtractData("01A", 156, 2);
			if (tempval != string.Empty)
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();

				switch(tempval)
				{
					case "01":
					{
						this.MortgageTerms.LoanAmortizationType = (short) MISMO.Enums.LoanAmortizationType.AdjustableRate;
						break;
					}
					case "04":
					{
						this.MortgageTerms.LoanAmortizationType = (short) MISMO.Enums.LoanAmortizationType.GrowingEquityMortgage;
						break;
					}
					case "05":
					{
						this.MortgageTerms.LoanAmortizationType = (short) MISMO.Enums.LoanAmortizationType.Fixed;
						break;
					}
					case "06":
					{
						this.MortgageTerms.LoanAmortizationType = (short) MISMO.Enums.LoanAmortizationType.GraduatedPaymentMortgage;
						break;
					}
					case "13":
					{
						this.MortgageTerms.LoanAmortizationType = (short) MISMO.Enums.LoanAmortizationType.OtherAmortizationType;
						break;
					}
				}
			}

			tempval = du.ExtractData("01A", 4, 2);
			if (tempval != string.Empty)
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();

				switch(tempval)
				{
					case "01":
					{
						this.MortgageTerms.MortgageType = (short) MISMO.Enums.MortgageType.Conventional;
						break;
					}
					case "02":
					{
						this.MortgageTerms.MortgageType = (short) MISMO.Enums.MortgageType.VA;
						break;
					}
					case "03":
					{
						this.MortgageTerms.MortgageType = (short) MISMO.Enums.MortgageType.FHA;
						break;
					}
					case "04":
					{
						this.MortgageTerms.MortgageType = (short) MISMO.Enums.MortgageType.FarmersHomeAdministration;
						break;
					}
					case "07":
					{
						this.MortgageTerms.MortgageType = (short) MISMO.Enums.MortgageType.Other;
						break;
					}
				}
			}

			tempval = du.ExtractData("01A", 6, 80);
			if (tempval != string.Empty) 
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.OtherMortgageTypeDescription= tempval;
			}

			tempval = du.ExtractData("01A", 158, 80);
			if (tempval != string.Empty)
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.OtherAmortizationTypeDescription = tempval;
			}

			tempval = du.ExtractData("01A", 146, 7);
			if (tempval != string.Empty)
			{
				if (_mortgageterms == null) _mortgageterms = new MISMO.BusinessObjects.MortgageTerms();
				this.MortgageTerms.RequestedInterestRatePercent = Convert.ToDecimal(tempval);
			}

			#endregion MORTGAGE_TERMS
			
			#region PROPERTY
			// now let us get PROPERTY information

			tempval = du.ExtractData("02A", 4, 50);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.StreetAddress = tempval;
			}

			tempval = du.ExtractData("02A", 54, 35);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.City = tempval;
			}

			tempval = du.ExtractData("02A", 89, 2);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.State = tempval;
			}

			tempval = du.ExtractData("GOA", 102, 35);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.County = tempval;
			}

			tempval = du.ExtractData("02A", 91, 5);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.PostalCode = tempval;
			}

			tempval = du.ExtractData("02A", 96, 4);
			if (tempval != string.Empty && _prop != null && !this.Property.PostalCodeIsNull) this.Property.PostalCode += string.Format("-{0}", tempval);

			tempval = du.ExtractData("02A", 100, 3);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.FinancedNumberOfUnits = Convert.ToInt32(tempval);
			}

			tempval = du.ExtractData("02A", 185, 4);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				this.Property.StructureBuiltYear = DateTime.Parse(string.Format("12/31/{0}", tempval));
			}

			MISMO.BusinessObjects.LegalDescription legdesc = null;

			tempval = du.ExtractData("02A", 105, 80);
			if (tempval != string.Empty) 
			{
				if (_prop == null) _prop = new AUS.Property();
				if (legdesc == null) 
				{
					legdesc = new MISMO.BusinessObjects.LegalDescription();
					this.Property.LegalDescriptions.Add(legdesc);
				}
				legdesc.TextDescription = tempval;
			}

			tempval = du.ExtractData("02A", 103, 2);
			if (tempval != string.Empty)
			{
				if (_prop == null) _prop = new AUS.Property();
				if (legdesc == null) 
				{
					legdesc = new MISMO.BusinessObjects.LegalDescription();
					this.Property.LegalDescriptions.Add(legdesc);
				}

				switch(tempval)
				{
					case "F1":
					{
						legdesc.Type = (short) MISMO.Enums.LegalDescriptionType.Other;
						break;
					}
					case "02":
					{
						legdesc.Type = (short) MISMO.Enums.LegalDescriptionType.MetesAndBounds;
						break;
					}
				}
			}

			#endregion PROPERTY

			#region BORROWER

			// get the borrower information
			System.Collections.Specialized.StringCollection brwssncol = new System.Collections.Specialized.StringCollection();
			int borrowercount = du.BeginCapture("03A");
			Borrower brw = null;

			if (borrowercount > 0)
			{
				for(int i = 0; i<borrowercount; i++)
				{
					brw = new Borrower();
					
					tempval = du.ExtractCaptureData(i, 15, 35);
					if (tempval != string.Empty) brw.FirstName = tempval;

					tempval = du.ExtractCaptureData(i, 50, 35);
					if (tempval != string.Empty) brw.MiddleName = tempval;

					tempval = du.ExtractCaptureData(i, 85, 35);
					if (tempval != string.Empty) brw.LastName = tempval;

					tempval = du.ExtractCaptureData(i, 120, 4);
					if (tempval != string.Empty) brw.NameSuffix = tempval;

					tempval = du.ExtractCaptureData(i, 134, 3);
					if (tempval != string.Empty) brw.AgeAtApplicationYears = Convert.ToDecimal(tempval);

					// TODO: revisit extracting borrower data in different captures zones
//					tempval = du.ExtractCaptureData(i, 13, 8);
//					if (tempval != string.Empty) brw.ApplicationSignedDate = DateTime.Parse(string.Format("{0}/{1}/{2}", tempval.Substring(4, 2), tempval.Substring(6, 2), tempval.Substring(0, 4)));

					tempval = du.ExtractCaptureData(i, 124, 10);
					if (tempval != string.Empty) 
					{
						MISMO.BusinessObjects.ContactPoint cp = new ContactPoint();
						cp.Type = (short) MISMO.Enums.ContactPointType.Phone;
						cp.Value = tempval;
						brw.ContactPoints.Add(cp);
					}

					tempval = du.ExtractCaptureData(i, 4, 2);
					switch(tempval)
					{
						case "BW":
						{
							brw.PrintPositionType = (short) MISMO.Enums.PrintPositionType.Borrower;
							break;
						}
						case "QZ":
						{
							brw.PrintPositionType = (short) MISMO.Enums.PrintPositionType.CoBorrower;
							break;
						}
					}

					tempval = du.ExtractCaptureData(i, 6, 9);
					if (tempval != string.Empty) brw.SSN = tempval;

					tempval = du.ExtractCaptureData(i, 140, 2);
					if (tempval != string.Empty) brw.DependentCount = Convert.ToByte(tempval);

					tempval = du.ExtractCaptureData(i, 142, 1);
					switch(tempval)
					{
						case "Y":
						{
							brw.JointAssetLiabilityReportingType = (short) MISMO.Enums.JointAssetLiabilityReportingType.Jointly;
							break;
						}
						case "N":
						{
							brw.JointAssetLiabilityReportingType = (short) MISMO.Enums.JointAssetLiabilityReportingType.NotJointly;
							break;
						}
					}

					tempval = du.ExtractCaptureData(i, 139, 1);
					switch(tempval)
					{
						case "M":
						{
							brw.MaritalStatusType = (short) MISMO.Enums.MaritalStatusType.Married;
							break;
						}
						case "S":
						{
							brw.MaritalStatusType = (short) MISMO.Enums.MaritalStatusType.Separated;
							break;
						}
						case "U":
						{
							brw.MaritalStatusType = (short) MISMO.Enums.MaritalStatusType.Unmarried;
							break;
						}
					}

					tempval = du.ExtractCaptureData(i, 137, 2);
					if (tempval != string.Empty) brw.SchoolingYears = Convert.ToDecimal(tempval);

					this.Borrowers.Add(brw);
				}
			} // end of borrowers section

			#endregion BORROWER

			#region DOWN_PAYMENTS

			// extract the down payments
			int downpaymentcount = du.BeginCapture("02E");
			if (downpaymentcount > 0)
			{
				MISMO.BusinessObjects.DownPayment dp = null;
				for(int i = 0; i<downpaymentcount; i++)
				{
					dp = new MISMO.BusinessObjects.DownPayment();
					tempval = du.ExtractCaptureData(i, 6, 15);
					if (tempval != string.Empty) dp.Amount = Convert.ToDecimal(tempval);

					tempval = du.ExtractCaptureData(i, 21, 80);
					if (tempval != string.Empty) dp.SourceDescription = tempval;


					tempval = du.ExtractCaptureData(i, 4, 2);
					switch(tempval)
					{
						case "F1":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.CheckingSavings;
							break;
						}
						case "F2":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.DepositOnSalesContract;
							break;
						}
						case "F3":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.EquityOnSoldProperty;
							break;
						}
						case "03":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.EquityOnPendingSale;
							break;
						}
						case "04":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.GiftFunds;
							break;
						}
						case "F5":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.StocksAndBonds;
							break;
						}
						case "10":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.LotEquity;
							break;
						}
						case "09":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.BridgeLoan;
							break;
						}
						case "01":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.UnsecuredBorrowedFunds;
							break;
						}
						case "F6":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.TrustFunds;
							break;
						}
						case "F7":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.RetirementFunds;
							break;
						}
						case "11":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.RentWithOptionToPurchase;
							break;
						}
						case "F8":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.LifeInsuranceCashValue;
							break;
						}
						case "14":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.SaleOfChattel;
							break;
						}
						case "07":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.TradeEquity;
							break;
						}
						case "06":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.SweatEquity;
							break;
						}
						case "02":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.CashOnHand;
							break;
						}
						case "13":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.OtherTypeOfDownPayment;
							break;
						}
						case "28":
						{
							dp.Type = (short) MISMO.Enums.DownPaymentType.SecuredBorrowedFunds;
							break;
						}
					}
					

					this.DownPayments.Add(dp);
				}
			} // end of downpaymentcount

			#endregion DOWN_PAYMENTS

			#region ADDITIONAL_CASE_DATA.MORTGAGE_SCORE

			int mortgagescores = du.BeginCapture("SCA");
			if (mortgagescores > 0)
			{
				if (_additionalcasedata == null)
					_additionalcasedata = new AdditionalCaseData();

				MISMO.BusinessObjects.MortgageScore mtgscore = null;
				
				for(int i = 0; i<mortgagescores; i++)
				{
					mtgscore = new MISMO.BusinessObjects.MortgageScore();

					tempval = du.ExtractCaptureData(i, 10, 8);
					if (tempval != string.Empty) mtgscore.Date = du.ToDate(tempval);

					tempval = du.ExtractCaptureData(i, 4, 3);
					switch(tempval)
					{
						case "001":
						{
							mtgscore.Type = (short) MISMO.Enums.MortgageScoreType.PMIAuraAQIScore;
							break;
						}
						case "002":
						{
							mtgscore.Type = (short) MISMO.Enums.MortgageScoreType.GE_IQScore;
							break;
						}
						case "003":
						{
							mtgscore.Type = (short) MISMO.Enums.MortgageScoreType.UGIAccuscore;
							break;
						}
					}

					tempval = du.ExtractCaptureData(i, 7, 3);
					if (tempval != string.Empty) mtgscore.Value = tempval;

					_additionalcasedata.MortgageScores.Add(mtgscore);
				}
			} // end of mortgagescores

			#endregion ADDITIONAL_CASE_DATA.MORTGAGE_SCORE

			#region ADDITIONAL_CASE_DATA.TRANSMITTAL_DATA

			tempval = du.ExtractData("99B", 22, 7);
			if (tempval != string.Empty) 
			{
				if (_additionalcasedata == null) _additionalcasedata = new AUS.AdditionalCaseData();
				if (_additionalcasedata._transmitdata == null) _additionalcasedata._transmitdata = new BusinessObjects.TransmittalData();
				this.AdditionalCaseData.TransmittalData.BuydownRatePercent = Convert.ToDecimal(tempval);
			}


			tempval = du.ExtractData("99B", 5, 2);
			if (tempval != string.Empty) 
			{
				if (_additionalcasedata == null) _additionalcasedata = new AUS.AdditionalCaseData();
				if (_additionalcasedata._transmitdata == null) _additionalcasedata._transmitdata = new BusinessObjects.TransmittalData();
				switch(tempval)
				{
					case "01":
					{
						this.AdditionalCaseData.TransmittalData.CurrentFirstMortgageHolderType = (short) MISMO.Enums.MortgageHolderType.FNM;
						break;
					}
					case "02":
					{
						this.AdditionalCaseData.TransmittalData.CurrentFirstMortgageHolderType = (short) MISMO.Enums.MortgageHolderType.FRE;
						break;
					}
					case "03":
					{
						this.AdditionalCaseData.TransmittalData.CurrentFirstMortgageHolderType = (short) MISMO.Enums.MortgageHolderType.Other;
						break;
					}
					case "F1":
					{
						this.AdditionalCaseData.TransmittalData.CurrentFirstMortgageHolderType = (short) MISMO.Enums.MortgageHolderType.Unknown;
						break;
					}
				}
			}

			tempval = du.ExtractData("99B", 7, 15);
			if (tempval != string.Empty) 
			{
				if (_additionalcasedata == null) _additionalcasedata = new AUS.AdditionalCaseData();
				if (_additionalcasedata._transmitdata == null) _additionalcasedata._transmitdata = new BusinessObjects.TransmittalData();
				this.AdditionalCaseData.TransmittalData.PropertyAppraisedValueAmount = Convert.ToDecimal(tempval);
			}


			#endregion ADDITIONAL_CASE_DATA.TRANSMITTAL_DATA

			#region LOAN_PURPOSE

			tempval = du.ExtractData("02B", 89, 60);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				this.Purpose.GSETitleMannerHeldDescription = tempval;
			}

			tempval = du.ExtractData("02B", 6, 2);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				switch(tempval)
				{
					case "04":
					{
						this.Purpose.Type = (short) MISMO.Enums.LoanPurposeType.ConstructionOnly;
						break;
					}
					case "05":
					{
						this.Purpose.Type = (short) MISMO.Enums.LoanPurposeType.Refinance;
						break;
					}
					case "13":
					{
						this.Purpose.Type = (short) MISMO.Enums.LoanPurposeType.ConstructionToPermanent;
						break;
					}
					case "15":
					{
						this.Purpose.Type = (short) MISMO.Enums.LoanPurposeType.Other;
						break;
					}
					case "16":
					{
						this.Purpose.Type = (short) MISMO.Enums.LoanPurposeType.Purchase;
						break;
					}
				}
			}

			tempval = du.ExtractData("02B", 8, 80);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				this.Purpose.OtherLoanPurposeDescription = tempval;
			}

			tempval = du.ExtractData("02B", 150, 8);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				this.Purpose.PropertyLeaseholdExpirationDate = du.ToDate(tempval);
			}


			tempval = du.ExtractData("02B", 149, 1);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				switch(tempval)
				{
					case "1":
					{
						this.Purpose.PropertyRightsType = (short) MISMO.Enums.PropertyRightsType.FeeSimple;
						break;
					}
					case "2":
					{
						this.Purpose.PropertyRightsType = (short) MISMO.Enums.PropertyRightsType.Leasehold;
						break;
					}
				}
			}


			tempval = du.ExtractData("02B", 88, 1);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				switch(tempval)
				{
					case "1":
					{
						this.Purpose.PropertyUsageType = (short) MISMO.Enums.PropertyUsageType.PrimaryResidence;
						break;
					}
					case "2":
					{
						this.Purpose.PropertyUsageType = (short) MISMO.Enums.PropertyUsageType.SecondHome;
						break;
					}
					case "D":
					{
						this.Purpose.PropertyUsageType = (short) MISMO.Enums.PropertyUsageType.Investor;
						break;
					}
				}
			}
			
			#endregion LOAN_PURPOSE

			#region LOAN_PURPOSE.CONSTRUCTION_REFINANCE_DATA

			// load up the construction refi data
			tempval = du.ExtractData("02D", 53, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.ConstructionImprovementCostsAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("02D", 68, 2);
			if (tempval != string.Empty)
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				switch(tempval) 
				{
					case "F1":
					{
						this.Purpose.ConstructionRefinanceData.GSERefinancePurposeType = (short) MISMO.Enums.GSERefinancePurposeType.NoCashOutOther;
						break;
					}
					case "01":
					{
						this.Purpose.ConstructionRefinanceData.GSERefinancePurposeType = (short) MISMO.Enums.GSERefinancePurposeType.CashOutOther;
						break;
					}
					case "04":
					{
						this.Purpose.ConstructionRefinanceData.GSERefinancePurposeType = (short) MISMO.Enums.GSERefinancePurposeType.CashOutHomeImprovement;
						break;
					}
					case "11":
					{
						this.Purpose.ConstructionRefinanceData.GSERefinancePurposeType = (short) MISMO.Enums.GSERefinancePurposeType.CashOutDebtConsolidation;
						break;
					}
					case "13":
					{
						this.Purpose.ConstructionRefinanceData.GSERefinancePurposeType = (short) MISMO.Enums.GSERefinancePurposeType.CashOutLimited;
						break;
					}
				}
			}

			tempval = du.ExtractData("02D", 38, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.LandEstimatedValueAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("02D", 8, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.LandOriginalCostAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("02D", 4, 4);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.PropertyAcquiredYear = du.ToDate(tempval);
			}

			tempval = du.ExtractData("02D", 23, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.PropertyExistingLienAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("02D", 8, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.PropertyOriginalCostAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("02D", 151, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.RefinanceImprovementCostsAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("02D", 151, 15);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				switch(tempval)
				{
					case "Y":
					{
						this.Purpose.ConstructionRefinanceData.RefinanceImprovementsType = (short) MISMO.Enums.RefinanceImprovementsType.Made;
						break;
					}
					case "N":
					{
						this.Purpose.ConstructionRefinanceData.RefinanceImprovementsType = (short) MISMO.Enums.RefinanceImprovementsType.ToBeMade;
						break;
					}
					case "U":
					{
						this.Purpose.ConstructionRefinanceData.RefinanceImprovementsType = (short) MISMO.Enums.RefinanceImprovementsType.Unknown;
						break;
					}
				}
			}


			tempval = du.ExtractData("02D", 70, 80);
			if (tempval != string.Empty) 
			{
				if (_purpose == null) _purpose = new AUS.LoanPurpose();
				if (_purpose._consrefidata == null) _purpose._consrefidata = new BusinessObjects.ConstructionRefinanceData();
				this.Purpose.ConstructionRefinanceData.RefinanceProposedImprovementsDescription = tempval;
			}

			#endregion LOAN_PURPOSE.CONSTRUCTION_REFINANCE_DATA

			#region LOAN_PRODUCT_DATA.LOAN_FEATURES
			// load the product data

			tempval = du.ExtractData("PCH", 7, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.AssumabilityIndicator = (tempval == "Y");
			}

			tempval = du.ExtractData("LNC", 25, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.BalloonIndicator = (tempval == "Y");
			}

			tempval = du.ExtractData("PCH", 4, 3);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.BalloonLoanMaturityTermMonths = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("LNC", 28, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.CounselingConfirmationIndicator = (tempval == "Y");
			}

			// TODO: DownPaymentOptionType??
//			tempval = du.ExtractData("LNC", 28, 1);
//			if (tempval != string.Empty) 
//			{
//				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
//				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeature();
//				switch(tempval)
//				{
//					case "":
//					{
//						this.ProductData.LoanFeatures.d = (tempval == "Y");
//						break;
//					}
//				}
//			}

			tempval = du.ExtractData("LNC", 58, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.EscrowWaiverIndicator = (tempval == "Y");
			}

			tempval = du.ExtractData("LNC", 6, 2);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				switch(tempval)
				{
					case "01":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.Detached;
						break;
					}
					case "02":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.Attached;
						break;
					}
					case "03":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.Condominium;
						break;
					}
					case "04":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.PUD;
						break;
					}
					case "05":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.Cooperative;
						break;
					}
					case "07":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.HighRiseCondominium;
						break;
					}
					case "08":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.ManufacturedHousing;
						break;
					}
					case "09":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.DetachedCondominium;
						break;
					}
					case "10":
					{
						this.ProductData.LoanFeatures.GSEPropertyType = (short) MISMO.Enums.GSEPropertyType.ManufacturedHomeCondominiumOrPUDOrCooperative;
						break;
					}
				}
			}

			tempval = du.ExtractData("LNC", 4, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				switch(tempval)
				{
					case "1":
					{
						this.ProductData.LoanFeatures.LienPriorityType = (short) MISMO.Enums.LienPriorityType.FirstLien;
						break;
					}
					case "2":
					{
						this.ProductData.LoanFeatures.LienPriorityType = (short) MISMO.Enums.LienPriorityType.SecondLien;
						break;
					}
					case "F":
					{
						this.ProductData.LoanFeatures.LienPriorityType = (short) MISMO.Enums.LienPriorityType.Other;
						break;
					}
				}
			}


			tempval = du.ExtractData("LNC", 5, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				switch(tempval)
				{
					case "A":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.Alternative;
						break;
					}
					case "F":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.FullDocumentation;
						break;
					}
					case "R":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.Reduced;
						break;
					}
					case "B":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.StreamlineRefinance;
						break;
					}
					case "C":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoDocumentation;
						break;
					}
					case "D":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoRatio;
						break;
					}
					// TODO try to verify mapping???
//					case "E":
//					{
//						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.;
//						break;
//					}
					case "U":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoIncomeNoEmploymentNoAssetsOn1003;
						break;
					}
//					case "G":
//					{
//						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.no;
//						break;
//					}
					case "J":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoIncomeOn1003;
						break;
					}
					case "K":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoVerificationOfStatedIncomeEmploymentOrAssets;
						break;
					}
					case "L":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoVerificationOfStatedIncomeOrAssests;
						break;
					}
					case "M":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoVerificationOfStatedAssets;
						break;
					}
					case "N":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoVerificationOfStatedIncomeOrEmployment;
						break;
					}
					case "O":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.NoVerificationOfStatedIncome;
						break;
					}
					case "P":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.VerbalVerificationOfEmployment;
						break;
					}
					case "Q":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.OnePaystub;
						break;
					}
					case "S":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.OnePaystubAndVerbalVerificationOfEmployment;
						break;
					}
					case "T":
					{
						this.ProductData.LoanFeatures.LoanDocumentationType = (short) MISMO.Enums.LoanDocumentationType.OnePaystubAndOneW2AndVerbalVerificationOfEmploymentOrOneYear1040;
						break;
					}
				}
			} // end of loan documentation type


			tempval = du.ExtractData("PCH", 12, 2);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				switch(tempval)
				{
					case "N":
					{
						this.ProductData.LoanFeatures.LoanRepaymentType = (short) MISMO.Enums.LoanRepaymentType.NoNegativeAmortization;
						break;
					}
					case "F1":
					{
						this.ProductData.LoanFeatures.LoanRepaymentType = (short) MISMO.Enums.LoanRepaymentType.ScheduledAmortization;
						break;
					}
					case "F2":
					{
						this.ProductData.LoanFeatures.LoanRepaymentType = (short) MISMO.Enums.LoanRepaymentType.InterestOnly;
						break;
					}
					case "P":
					{
						this.ProductData.LoanFeatures.LoanRepaymentType = (short) MISMO.Enums.LoanRepaymentType.PotentialNegativeAmortization;
						break;
					}
					case "S":
					{
						this.ProductData.LoanFeatures.LoanRepaymentType = (short) MISMO.Enums.LoanRepaymentType.ScheduledNegativeAmortization;
						break;
					}
				}
			}

			tempval = du.ExtractData("LNC", 59, 8);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.LoanScheduledClosingDate = du.ToDate(tempval);
			}

			tempval = du.ExtractData("LNC", 75, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.MICoveragePercent = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("LNC", 82, 3);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				switch(tempval)
				{
					case "001":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.GECapitalMICorporation;
						break;
					}
					case "006":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.MortgageGuarantyInsuranceCorporation;
						break;
					}
					case "011":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.PMI_MICorporation;
						break;
					}
					case "012":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.UnitedGuarantyCorporation;
						break;
					}
					case "013":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.RepublicMICompany;
						break;
					}
					case "017":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.RadianGuarantyIncorporated;
						break;
					}
					case "024":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.TriadGuarantyInsuranceCorporation;
						break;
					}
					case "038":
					{
						this.ProductData.LoanFeatures.MICompanyNameType = (short) MISMO.Enums.MICompanyNameType.CMG_MICompany;
						break;
					}
				}
			}

			tempval = du.ExtractData("LNC", 18, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.NegativeAmortizationLimitPercent = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("PCH", 8, 2);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				switch(tempval)
				{
					case "01":
					{
						this.ProductData.LoanFeatures.PaymentFrequencyType = (short) MISMO.Enums.PaymentFrequencyType.Monthly;
						break;
					}
					case "02":
					{
						this.ProductData.LoanFeatures.PaymentFrequencyType = (short) MISMO.Enums.PaymentFrequencyType.Biweekly;
						break;
					}
				}
			}

			tempval = du.ExtractData("PCH", 10, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.PrepaymentPenaltyIndicator = (tempval == "Y");
			}

			tempval = du.ExtractData("PCH", 11, 1);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.PrepaymentRestrictionIndicator = (tempval == "Y");
			}

			tempval = du.ExtractData("PID", 4, 30);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.ProductDescription = tempval;
			}

			tempval = du.ExtractData("PID", 34, 15);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.ProductName = tempval;
			}

			tempval = du.ExtractData("LNC", 67, 8);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._loanfeatures == null) _loanproductdata._loanfeatures = new BusinessObjects.LoanFeatures();
				this.ProductData.LoanFeatures.ScheduledFirstPaymentDate = du.ToDate(tempval);
			}

			#endregion LOAN_PRODUCT_DATA.LOAN_FEATURES

			#region TRANSACTION_DETAIL

			tempval = du.ExtractData("07A", 19, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.AlterationsImprovementsAndRepairsAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 109, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.BorrowerPaidDiscountPointsTotalAmount = Convert.ToDecimal(tempval);
			}


			tempval = du.ExtractData("07A", 79, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.EstimatedClosingCostsAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 154, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.MIAndFundingFeeFinancedAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 94, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.MIAndFundingFeeTotalAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 64, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.PrepaidItemsEstimatedAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 4, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.PurchasePriceAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 49, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.RefinanceIncludingDebtsToBePaidOffAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("GOA", 20, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.SalesConcessionAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 139, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.SellerPaidClosingCostsAmount = Convert.ToDecimal(tempval);
			}

			tempval = du.ExtractData("07A", 124, 15);
			if (tempval != string.Empty) 
			{
				if (_transdetail == null) _transdetail = new AUS.TransactionDetail();
				this.TransactionDetail.SubordinateLienAmount = Convert.ToDecimal(tempval);
			}

			#endregion TRANSACTION_DETAIL

			#region LOAN_PRODUCT_DATA.ARM
		
			tempval = du.ExtractData("ARM", 4, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				this.ProductData.ARM.IndexCurrentValuePercent = Convert.ToDecimal(tempval) / 100;
			}

			tempval = du.ExtractData("ARM", 13, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				this.ProductData.ARM.IndexMarginPercent = Convert.ToDecimal(tempval) / 100;
			}

			tempval = du.ExtractData("ARM", 11, 2);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				switch(tempval)
				{
					case "0":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WeeklyAverageConstantMaturingTreasury;
						break;
					}
					case "1":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.MonthlyAverageConstantMaturingTreasury;
						break;
					}
					case "2":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WeeklyAverageTreasuryAuctionAverageInvestmentYield;
						break;
					}
					case "3":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WeeklyAverageTreasuryAuctionAverageBondDiscountYield;
						break;
					}
					case "4":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WeeklyAverageSecondaryMarketTreasuryBillInvestmentYield;
						break;
					}
					case "5":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.DailyCertificateOfDepositRate;
						break;
					}
					case "6":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WeeklyAverageCertificateOfDepositRate;
						break;
					}
					case "7":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WeeklyAveragePrimeRate;
						break;
					}
					case "8":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.TreasuryBillDailyValue;
						break;
					}
					case "9":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.EleventhDistrictCostOfFunds;
						break;
					}
					case "10":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.NationalMonthlyMedianCostOfFunds;
						break;
					}
					case "11":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.WallStreetJournalLIBOR;
						break;
					}
					case "12":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.FNM_LIBOR;
						break;
					}
					case "13":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.FRE_LIBOR;
						break;
					}
					case "14":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.NationalAverageContractRateFHLBB;
						break;
					}
					case "15":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.FederalCostOfFunds;
						break;
					}
					case "16":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.FNM60DayRequiredNetYield;
						break;
					}
					case "17":
					{
						_loanproductdata._arm.IndexType = (short) MISMO.Enums.ARMIndexType.FRE60DayRequiredNetYield;
						break;
					}
				}
			}

			tempval = du.ExtractData("ARM", 20, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				this.ProductData.ARM.QualifyingRatePercent = Convert.ToDecimal(tempval) / 100;
			}


			tempval = du.ExtractData("LNC", 43, 15);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				this.ProductData.ARM.PaymentAdjustmentLifetimeCapAmount = Convert.ToDecimal(tempval);
			}


			tempval = du.ExtractData("LNC", 36, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				this.ProductData.ARM.PaymentAdjustmentLifetimeCapPercent = Convert.ToDecimal(tempval) / 100;
			}

			tempval = du.ExtractData("LNC", 29, 7);
			if (tempval != string.Empty) 
			{
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				if (_loanproductdata._arm == null) _loanproductdata._arm = new BusinessObjects.ARM();
				this.ProductData.ARM.RateAdjustmentLifetimeCapPercent = Convert.ToDecimal(tempval) / 100;
			}

			#endregion LOAN_PRODUCT_DATA.ARM

			#region LOAN_PRODUCT_DATA.RATE_ADJUSTMENT

			int rateadjustmentcount = du.BeginCapture("RAJ");
			if (rateadjustmentcount > 0)
			{
				MISMO.BusinessObjects.RateAdjustment raj = null;
				if (_loanproductdata == null) _loanproductdata = new AUS.LoanProductData();
				for(int i = 0; i<rateadjustmentcount; i++)
				{
					raj = new BusinessObjects.RateAdjustment();
					
					tempval = du.ExtractCaptureData(i, 29, 3);
					if (tempval != string.Empty)
						raj.FirstRateAdjustmentMonths = Convert.ToDecimal(tempval);

					tempval = du.ExtractCaptureData(i, 14, 1);
					switch(tempval)
					{
						case "0":
						{
							raj.CalculationType = (short) MISMO.Enums.RateAdjustmentCalculationType.AddPercentToCurrentRate;
							break;
						}
						case "1":
						{
							raj.CalculationType = (short) MISMO.Enums.RateAdjustmentCalculationType.AddPercentToOriginalRate;
							break;
						}
						case "2":
						{
							raj.CalculationType = (short) MISMO.Enums.RateAdjustmentCalculationType.IndexPlusMargin;
							break;
						}
					}

					tempval = du.ExtractCaptureData(i, 8, 3);
					if (tempval != string.Empty)
						raj.DurationMonths = Convert.ToDecimal(tempval);

					tempval = du.ExtractCaptureData(i, 15, 7);
					if (tempval != string.Empty)
						raj.Percent = Convert.ToDecimal(tempval) / 100;

					tempval = du.ExtractCaptureData(i, 4, 4);
					if (tempval != string.Empty)
						raj.PeriodNumber = Convert.ToDecimal(tempval);

					tempval = du.ExtractCaptureData(i, 22, 7);
					if (tempval != string.Empty)
						raj.SubsequentCapPercent = Convert.ToDecimal(tempval) / 100;

					tempval = du.ExtractCaptureData(i, 11, 3);
					if (tempval != string.Empty)
						raj.SubsequentRateAdjustmentMonths = Convert.ToDecimal(tempval);

					if (raj.CalculationType != (short) Enums.RateAdjustmentCalculationType.Undefined)
						_loanproductdata._rateadjustments.Add(raj);
				}
			}
			du.EndCapture();

			#endregion LOAN_PRODUCT_DATA.RATE_ADJUSTMENT

			#region PROPOSED_HOUSING_EXPENSE

			int propsedexpcount = du.BeginCapture("05H");
			if (propsedexpcount > 0)
			{
				MISMO.BusinessObjects.ProposedHousingExpense propexp = null;
				for(int i = 0; i<propsedexpcount; i++)
				{
					propexp = new BusinessObjects.ProposedHousingExpense();

					tempval = du.ExtractCaptureData(i, 14, 2);
					switch(tempval)
					{
						case "25":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.GroundRent;
							break;
						}
						case "26":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.FirstMortgagePrincipalAndInterest;
							break;
						}
						case "22":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.OtherMortgageLoanPrincipalAndInterest;
							break;
						}
						case "01":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.HazardInsurance;
							break;
						}
						case "14":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.RealEstateTax;
							break;
						}
						case "02":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.MI;
							break;
						}
						case "06":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.HomeownersAssociationDuesAndCondominiumFees;
							break;
						}
						case "23":
						{
							propexp.HousingExpenseType = (short) MISMO.Enums.HousingExpenseType.OtherHousingExpense;
							break;
						}
					}

					tempval = du.ExtractCaptureData(i, 16, 15);
					if (tempval != string.Empty)
						propexp.PaymentAmount = Convert.ToDecimal(tempval);

					this.ProposedHousingExpenses.Add(propexp);
				}
			}

		#endregion PROPOSED_HOUSING_EXPENSE

			#region BORROWER (nested elements)

			// iterate through all the borrowers and extract their respective data
			for(int i = 0, j= _borrowers.Count; i<j; i++)
			{
				MISMO.BusinessObjects.AUS.Borrower cborrower = _borrowers[i] as AUS.Borrower;

				#region BORROWER.CURRENT_INCOME

				int cincomecount = du.BeginCapture("05I", 4, 9, cborrower.SSN);
				MISMO.BusinessObjects.CurrentIncome cincome = null;

				if (cincomecount > 0)
				{
					for(int k = 0; k<cincomecount; k++)
					{
						cincome = new BusinessObjects.CurrentIncome();

						tempval = du.ExtractCaptureData(k, 13, 2);
						switch(tempval)
						{
							case "F1":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryBasePay;
								break;
							}
							case "07":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryRationsAllowance;
								break;
							}
							case "F2":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryFlightPay;
								break;
							}
							case "F3":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryHazardPay;
								break;
							}
							case "02":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryClothesAllowance;
								break;
							}
							case "04":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryQuartersAllowance;
								break;
							}
							case "03":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryPropPay;
								break;
							}
							case "F4":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryOverseasPay;
								break;
							}
							case "F5":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryCombatPay;
								break;
							}
							case "F6":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MilitaryVariableHousingAllowance;
								break;
							}
							case "F7":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.AlimonyChildSupport;
								break;
							}
							case "F8":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.NotesReceivableInstallment;
								break;
							}
							case "41":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Pension;
								break;
							}
							case "42":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.SocialSecurity;
								break;
							}
							case "30":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.MortgageDifferential;
								break;
							}
							case "F9":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Trust;
								break;
							}
							case "M1":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Unemployment;
								break;
							}
							case "M2":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.AutomobileExpenseAccount;
								break;
							}
							case "M3":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.FosterCare;
								break;
							}
							case "M4":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.VABenefitsNonEducational;
								break;
							}
							case "45":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.OtherTypesOfIncome;
								break;
							}
							case "20":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Base;
								break;
							}
							case "09":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Overtime;
								break;
							}
							case "08":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Bonus;
								break;
							}
							case "10":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.Commissions;
								break;
							}
							case "17":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.DividendsInterest;
								break;
							}
							case "SI":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.SubjectPropertyNetCashFlow;
								break;
							}
							case "33":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.NetRentalIncome;
								break;
							}
							case "BI":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.OtherTypesOfIncome;
								break;
							}
							case "MC":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.OtherTypesOfIncome;
								break;
							}
							case "TC":
							{
								cincome.IncomeType = (short) MISMO.Enums.IncomeType.OtherTypesOfIncome;
								break;
							}
						}

						tempval = du.ExtractCaptureData(k, 15, 15);
						if (tempval != string.Empty)
							cincome.MonthlyTotalAmount = Convert.ToDecimal(tempval);

						cborrower.CurrentIncomes.Add(cincome);
					}
				}

				#endregion BORROWER.CURRENT_INCOME

				#region BORROWER.DECLARATION

				int brwdeclcount = du.BeginCapture("08A", 4, 9, cborrower.SSN);
				if (brwdeclcount > 0)
				{
					// first create an instance of the declaration.
					if (cborrower.Declaration == null) cborrower.Declaration = new AUS.Declaration();
				
					tempval = du.ExtractCaptureData(0, 19, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.AlimonyChildSupportObligationIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 14, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.BankruptcyIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 20, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.BorrowedDownPaymentIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 22, 2);
					switch(tempval)
					{
						case "01":
						{
							cborrower.Declaration.CitizenshipResidencyType = (short) MISMO.Enums.CitizenshipResidencyType.USCitizen;
							break;
						}
						case "03":
						{
							cborrower.Declaration.CitizenshipResidencyType = (short) MISMO.Enums.CitizenshipResidencyType.PermanentResidentAlien;
							break;
						}
						case "05":
						{
							cborrower.Declaration.CitizenshipResidencyType = (short) MISMO.Enums.CitizenshipResidencyType.NonPermanentResidentAlien;
							break;
						}
					}

					tempval = du.ExtractCaptureData(0, 21, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.CoMakerEndorserOfNoteIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 25, 1);
					if (tempval != string.Empty && (tempval == "Y" || tempval == "N"))
						cborrower.Declaration.HomeownerPastThreeYearsType = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 24, 1);
					if (tempval != string.Empty && (tempval == "Y" || tempval == "N"))
						cborrower.Declaration.IntentToOccupyType = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 17, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.LoanForeclosureOrJudgementIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 13, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.OutstandingJudgementsIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 16, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.PartyToLawsuitIndicator = (tempval == "Y");

					tempval = du.ExtractCaptureData(0, 18, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.PresentlyDelinquentIndicator = (tempval == "Y");
					
					tempval = du.ExtractCaptureData(0, 27, 2);
					switch(tempval)
					{
						case "01":
						{
							cborrower.Declaration.PriorPropertyTitleType = (short) MISMO.Enums.PriorPropertyTitleType.Sole;
							break;
						}
						case "25":
						{
							cborrower.Declaration.PriorPropertyTitleType = (short) MISMO.Enums.PriorPropertyTitleType.JointWithSpouse;
							break;
						}
						case "26":
						{
							cborrower.Declaration.PriorPropertyTitleType = (short) MISMO.Enums.PriorPropertyTitleType.JointWithOtherThanSpouse;
							break;
						}
					}

					tempval = du.ExtractCaptureData(0, 26, 1);
					switch(tempval)
					{
						case "1":
						{
							cborrower.Declaration.PriorPropertyUsageType = (short) MISMO.Enums.PriorPropertyUsageType.PrimaryResidence;
							break;
						}
						case "2":
						{
							cborrower.Declaration.PriorPropertyUsageType = (short) MISMO.Enums.PriorPropertyUsageType.SecondaryResidence;
							break;
						}
						case "D":
						{
							cborrower.Declaration.PriorPropertyUsageType = (short) MISMO.Enums.PriorPropertyUsageType.Investment;
							break;
						}
					}


					tempval = du.ExtractCaptureData(0, 15, 1);
					if (tempval != string.Empty)
						cborrower.Declaration.PropertyForeclosedPastSevenYearsIndicator = (tempval == "Y");

					du.EndCapture();

					#region BORROWER.DECLARATION._EXPLANATION

					int explanationcount = du.BeginCapture("08B", 4, 9, cborrower.SSN);
					if (explanationcount > 0)
					{
						MISMO.BusinessObjects.Explanation expl = null;
						for(int l = 0; l<explanationcount; l++)
						{
							expl = new MISMO.BusinessObjects.Explanation();

							tempval = du.ExtractCaptureData(l, 15, 255);
							if (tempval != string.Empty)
							{
								expl.Description = tempval;
							}

							tempval = du.ExtractCaptureData(l, 13, 2);
							switch(tempval)
							{
								case "91":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.OutstandingJudgments;
									break;
								}
								case "92":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.DeclaredBankruptcyPastSevenYears;
									break;
								}
								case "93":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.DirectIndirectForeclosedPropertyPastSevenYears;
									break;
								}
								case "94":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.PartyToLawsuit;
									break;
								}
								case "95":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.ObligatedOnLoanForeclosedOrDeedInLieuOfJudgement;
									break;
								}
								case "96":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.DelinquencyOrDefault;
									break;
								}
								case "97":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.AlimonyChildSupport;
									break;
								}
								case "98":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.BorrowedDownPayment;
									break;
								}
								case "99":
								{
									expl.Type = (short) MISMO.Enums.ExplanationType.CoMakerEndorserOnNote;
									break;
								}
							}

							cborrower.Declaration.Explanations.Add(expl);
						}
					}

					#endregion BORROWER.DECLARATION._EXPLANATION
				}

				#endregion BORROWER.DECLARATION

				#region ASSETS

				AUS.Asset assobj = null;

				// load standard assets
				int asscount = du.BeginCapture("06C", 4, 9, cborrower.SSN);
				if (asscount > 0)
				{
					for(int n = 0; n<asscount; n++)
					{
						assobj = new AUS.Asset();

						// first extract or try to determine the asset type
						tempval = du.ExtractCaptureData(n, 13, 3);
						switch(tempval)
						{
							case "03":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.CheckingAccount;
								break;
							}
							case "F1":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.SaleOtherAssets;
								break;
							}
							case "SG":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.SavingsAccount;
								break;
							}
							case "F2":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.GiftsTotal;
								break;
							}
							case "01":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.CertificateOfDepositTimeDeposit;
								break;
							}
							case "F3":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.MoneyMarketFund;
								break;
							}
							case "F4":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.MutualFund;
								break;
							}
							case "05":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.Stock;
								break;
							}
							case "06":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.Bond;
								break;
							}
							case "F5":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.SecuredBorrowedFundsNotDeposited;
								break;
							}
							case "F7":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.BridgeLoanNotDeposited;
								break;
							}
							case "08":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.RetirementFund;
								break;
							}
							case "F8":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.NetWorthOfBusinessOwned;
								break;
							}
							case "11":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.TrustAccount;
								break;
							}
							case "M1":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.OtherNonLiquidAssets;
								break;
							}
							case "OL":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.OtherLiquidAssets;
								break;
							}
							case "NE":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.PendingNetSaleProceedsFromRealEstateAssets;
								break;
							}
							case "COH":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.CashOnHand;
								break;
							}
							case "GE":
							{
								assobj.Type = (short) MISMO.Enums.AssetType.GiftsNotDeposited;
								break;
							}
						}

						
						tempval = du.ExtractCaptureData(n, 132, 30);
						if (tempval != string.Empty)
						{
							assobj.AccountIdentifier = tempval;
						}

						tempval = du.ExtractCaptureData(n, 162, 15);
						if (tempval != string.Empty)
						{
							assobj.CashOrMarketValueAmount = Convert.ToDecimal(tempval);
						}					

						tempval = du.ExtractCaptureData(n, 16, 35);
						if (tempval != string.Empty)
						{
							assobj.HolderName = tempval;
						}

						tempval = du.ExtractCaptureData(n, 51, 35);
						if (tempval != string.Empty)
						{
							assobj.HolderStreetAddress = tempval;
						}

						tempval = du.ExtractCaptureData(n, 86, 35);
						if (tempval != string.Empty)
						{
							assobj.HolderCity = tempval;
						}

						tempval = du.ExtractCaptureData(n, 121, 2);
						if (tempval != string.Empty)
						{
							assobj.HolderState = tempval;
						}

						tempval = du.ExtractCaptureData(n, 123, 5);
						if (tempval != string.Empty)
						{
							assobj.HolderPostalCode = tempval;
						}

						tempval = du.ExtractCaptureData(n, 128, 4);
						if (tempval != string.Empty)
						{
							assobj.HolderPostalCode += "-" + tempval;
						}

						tempval = du.ExtractCaptureData(n, 184, 80);
						if (tempval != string.Empty)
						{
							assobj.OtherAssetTypeDescription = tempval;
						}					

						tempval = du.ExtractCaptureData(n, 177, 7);
						if (tempval != string.Empty)
						{
							assobj.StockBondMutualFundShareCount = Convert.ToDecimal(tempval);
						}	

						// add the asset to the borrower
						cborrower.Assets.Add(assobj);
					}
				}

				// load life insurance assets
				asscount = du.BeginCapture("06B", 4, 9, cborrower.SSN);
				if (asscount > 0)
				{
					for(int n = 0; n<asscount; n++)
					{
						assobj = new AUS.Asset();
						assobj.Type = (short) MISMO.Enums.AssetType.LifeInsurance; 

						tempval = du.ExtractCaptureData(n, 13, 30);
						if (tempval != string.Empty)
						{
							assobj.AccountIdentifier = tempval;
						}

						tempval = du.ExtractCaptureData(n, 43, 15);
						if (tempval != string.Empty)
						{
							assobj.CashOrMarketValueAmount = Convert.ToDecimal(tempval);
						}

						tempval = du.ExtractCaptureData(n, 58, 15);
						if (tempval != string.Empty)
						{
							assobj.LifeInsuranceFaceValueAmount = Convert.ToDecimal(tempval);
						}
					}
				}


				// load cash deposits assets
				asscount = du.BeginCapture("06A", 4, 9, cborrower.SSN);
				if (asscount > 0)
				{
					for(int n = 0; n<asscount; n++)
					{
						assobj = new AUS.Asset();
						assobj.Type = (short) MISMO.Enums.AssetType.EarnestMoneyCashDepositTowardPurchase; 

						tempval = du.ExtractCaptureData(n, 48, 15);
						if (tempval != string.Empty)
						{
							assobj.CashOrMarketValueAmount = Convert.ToDecimal(tempval);
						}

						tempval = du.ExtractCaptureData(n, 13, 35);
						if (tempval != string.Empty)
						{
							assobj.HolderName = tempval;
						}
					}
				}

				// load automobile assets
				asscount = du.BeginCapture("06D", 4, 9, cborrower.SSN);
				if (asscount > 0)
				{
					for(int n = 0; n<asscount; n++)
					{
						assobj = new AUS.Asset();
						assobj.Type = (short) MISMO.Enums.AssetType.Automobile; 

						tempval = du.ExtractCaptureData(n, 47, 15);
						if (tempval != string.Empty)
						{
							assobj.CashOrMarketValueAmount = Convert.ToDecimal(tempval);
						}

						tempval = du.ExtractCaptureData(n, 13, 30);
						if (tempval != string.Empty)
						{
							assobj.AutomobileMakeDescription = tempval;
						}

						tempval = du.ExtractCaptureData(n, 43, 4);
						if (tempval != string.Empty)
						{
							assobj.AutomobileModelYear = du.ToDate(tempval);
						}
					}
				}

				#endregion ASSETS
			}

			#endregion BORROWER (nested elements)



	} // end of LoadDU

		/// <summary>
		/// Gets the XML document representation for this loan application.
		/// </summary>
		/// <returns>An xml DOM.</returns>
		public override System.Xml.XmlDocument ToXml()
		{
			System.Xml.XmlDocument xdoc = XmlFactory.GenerateDocument(this);
			System.Xml.XmlElement xroot = xdoc.DocumentElement; // root element
			System.Xml.XmlElement xelem = null; // parent
			System.Xml.XmlElement xelem2 = null;
			System.Xml.XmlElement xelem3 = null;
			Borrower brw = null;

			if (this.DataInformation != null && this.DataInformation.DataVersions != null && this.DataInformation.DataVersions.Count > 0)
			{
				xelem = XmlFactory.GenerateElement(xroot, this.DataInformation);
				for(int i = 0, j = this.DataInformation.DataVersions.Count; i<j; i++)
				{
					XmlFactory.GenerateElement(xelem, this.DataInformation.DataVersions[i]);
				}
			}

			if (this.AdditionalCaseData != null)
			{
				xelem = XmlFactory.GenerateElement(xroot, this.AdditionalCaseData);
				if (this.AdditionalCaseData.TransmittalData != null)
				{
					XmlFactory.GenerateElement(xelem, this.AdditionalCaseData.TransmittalData);
				}
				for(int i = 0, j = this.AdditionalCaseData.MortgageScores.Count; i<j; i++)
				{
					XmlFactory.GenerateElement(xelem, this.AdditionalCaseData.MortgageScores[i]);
				}
			}

			// render the assets
			for(int i = 0; i<this.Borrowers.Count; i++)
			{
				brw = this.Borrowers[i] as Borrower;
				for(int j = 0; j<brw.Assets.Count; j++)
				{
					XmlFactory.GenerateElement(xroot, brw.Assets[j]);
				}
			}

			// render the downpayment information
			if (this.DownPayments != null && this.DownPayments.Count > 0)
			{
				for(int i = 0, j = this.DownPayments.Count; i<j; i++)
				{
					XmlFactory.GenerateElement(xroot, this.DownPayments[i]);
				}
			}

			// render government reporting
			if (_governmentReporting != null)
				XmlFactory.GenerateElement(xroot, _governmentReporting);

			// render the interviewer information
			if (_interviewer != null)
				XmlFactory.GenerateElement(xroot, _interviewer);

			// insert liabilities
			for(int i = 0; i<this.Borrowers.Count; i++)
			{
				brw = this.Borrowers[i] as Borrower;
				for (int j = 0; j < brw.Liabilities.Count; j++)
				{
					XmlFactory.GenerateElement(xroot, brw.Liabilities[j]);
				}
			}
			
			// render the loan product and any sub elements
			if (_loanproductdata != null)
			{
				xelem = _loanproductdata.ToXml(xroot);
			}

			// render the loan purpose
			if (_purpose != null)
			{
				xelem = XmlFactory.GenerateElement(xroot, _purpose);
				if (_purpose._consrefidata != null)
					XmlFactory.GenerateElement(xelem, _purpose._consrefidata);
			}

			// render the loan qualification
			if (_loanqualification != null)
				XmlFactory.GenerateElement(xroot, _loanqualification);

			// render the mortgage terms
			if (_mortgageterms != null)
				XmlFactory.GenerateElement(xroot, _mortgageterms);

			// render the property
			if (_prop != null)
			{
				xelem = XmlFactory.GenerateElement(xroot, _prop);

				for(int i = 0, j = _prop.LegalDescriptions.Count; i<j ; i++)
				{
					XmlFactory.GenerateElement(xelem, _prop.LegalDescriptions[i]);
				}

				if (_prop._parsedaddress != null)
					XmlFactory.GenerateElement(xelem, _prop._parsedaddress);		

				MISMO.BusinessObjects.AUS.Valuation vltn = null;

				for(int i = 0, j = _prop.Valuations.Count; i<j ; i++)
				{
					vltn = _prop.Valuations[i] as MISMO.BusinessObjects.AUS.Valuation;
					if (vltn != null)
					{
						xelem2 = XmlFactory.GenerateElement(xelem, vltn);

						for(int k = 0, l = vltn.Appraisers.Count; k<l; k++)
							XmlFactory.GenerateElement(xelem2, vltn.Appraisers[k]);
					}
				}
			}
			
			
			
			

			// render proposed housing expense
			for (int j = 0; j < this.ProposedHousingExpenses.Count; j++)
			{
				this.ProposedHousingExpenses[j].ToXml(xroot);
			}
			
			// render the REOProperties
			for (int j = 0; j < this.REOProperties.Count; j++)
			{
				XmlFactory.GenerateElement(xroot, this.REOProperties[j]);
			}

			// render the transaction detail
			if (_transdetail != null)
				xelem = _transdetail.ToXml(xroot);

			System.Xml.XmlElement xborelem = null; // the borrower element

			// insert borrower rendering here
			for(int i = 0, j = this.Borrowers.Count; i<j; i++)
			{
				this.Borrowers[i].ToXml(xroot);
			}

		
			return xdoc;
		}

		internal override void Persist(SqlTransaction sqlTrans)
		{
			// persist the base object first
			base.Persist(sqlTrans);

			// now iterate and persist any nested objects

			// persist the data information
			if (_datainformation != null)
			{
				_datainformation.LoanApplicationId = _id;
				_datainformation.Persist(sqlTrans);
			}

			// persist the addtional case data
			if (_additionalcasedata != null)
			{
				_additionalcasedata.LoanApplicationId = _id;
				_additionalcasedata.Persist(sqlTrans);
			}

			// persist the down payments
			if (_downpayments != null && _downpayments.Count > 0)
			{
				for(int i = 0, j = _downpayments.Count; i<j; i++)
				{
					_downpayments[i].LoanApplicationId = _id;
					_downpayments[i].Persist(sqlTrans);
				}
			}

			// persist the interviewer information
			if (_interviewer != null)
			{
				_interviewer.LoanApplicationId = _id;
				_interviewer.Persist(sqlTrans);
			}

			// persist the loan product data
			if (_loanproductdata != null)
			{
				_loanproductdata.LoanApplicationId = _id;
				_loanproductdata.Persist(sqlTrans);
			}

			// persist the loan purpose
			if (_purpose != null)
			{
				_purpose.LoanApplicationId = _id;
				_purpose.Persist(sqlTrans);
			}

			// persist the loan qualifications
			if (_loanqualification != null)
			{
				_loanqualification.LoanApplicationId = _id;
				_loanqualification.Persist(sqlTrans);
			}
			
			// persist the mortgage terms.
			if (_mortgageterms != null)
			{
				_mortgageterms.LoanApplicationId = _id;
				_mortgageterms.Persist(sqlTrans);
			}

			// persist the property
			if (_prop != null)
			{
				_prop.LoanApplicationId = _id;
				_prop.Persist(sqlTrans);
			}
		
			// persist the proposed housing expenses
			for(int i = 0, j = _proposedHousingExpenses.Count; i<j; i++)
			{
				_proposedHousingExpenses[i].LoanApplicationId = _id;
				_proposedHousingExpenses[i].Persist(sqlTrans);
			}

			// persist the REO properties
			for(int i = 0, j = _reoProperties.Count; i<j; i++)
			{
				_reoProperties[i].LoanApplicationId = _id;
				_reoProperties[i].Persist(sqlTrans);
			}

			// persist the title holders
			for(int i = 0, j = _titleholders.Count; i<j; i++)
			{
				_titleholders[i].LoanApplicationId = _id;
				_titleholders[i].Persist(sqlTrans);
			}			

			// persist the transaction detail
			if (_transdetail != null)
			{
				_transdetail.LoanApplicationId = _id;
				_transdetail.Persist(sqlTrans);
			}
			
			// persist the borrower persist
			if (_borrowers != null && _borrowers.Count > 0)
			{
				Borrower currborr = null;
				for (int i = 0; i<_borrowers.Count; i++)
				{
					currborr = _borrowers[i] as Borrower;
					currborr.LoanApplicationId = _id;
					currborr.Persist(sqlTrans);
				} 
			} 

			// finally update the checksum if the persist wasn't called from a descendant.
			if (this.GetType() == typeof(MISMO.BusinessObjects.AUS.LoanApplication))
			{
				RecalculateChecksum();
			}
		}


		/// <summary>
		/// Perisists the loan application to the database.
		/// </summary>
		public override void Persist()
		{
			SqlConnection cnn = new SqlConnection(DAL.Connection.String);
			System.Data.SqlClient.SqlTransaction tran = null;

			try
			{
				cnn.Open();
				tran = cnn.BeginTransaction();

				Persist(tran);

				tran.Commit();
				cnn.Close();
			}

			catch(Exception ex)
			{
				tran.Rollback();
				throw ex;
			}

			finally
			{
				if (cnn != null && cnn.State == ConnectionState.Open)
				{
					cnn.Close();
					cnn.Dispose();
				}
			}

			RecalculateChecksum();
		}

		#endregion Methods

	}
}
