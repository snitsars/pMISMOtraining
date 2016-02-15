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
	/// A class that represents an abstract entity for table 'FHA_LOAN'
	/// </summary>
	[Serializable]
	public abstract class FHALoanBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHALoanBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.FHALoan)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public FHALoanBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			FHALoanBase.ServiceObject.Fill(this as FHALoan, loanApplicationId);
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
		internal bool _borrowerfinancedfhadiscountpointsamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the borrowerfinancedfhadiscountpointsamount.
		/// </summary>
		internal System.Decimal _borrowerfinancedfhadiscountpointsamount;
		/// <summary>
		/// Gets and sets the BorrowerFinancedFHADiscountPointsAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal BorrowerFinancedFHADiscountPointsAmount
		{
			get
			{
				return _borrowerfinancedfhadiscountpointsamount;
			}
			set
			{
				_borrowerfinancedfhadiscountpointsamount = value;
				_borrowerfinancedfhadiscountpointsamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the BorrowerFinancedFHADiscountPointsAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean BorrowerFinancedFHADiscountPointsAmountIsNull
		{
			get
			{
				return _borrowerfinancedfhadiscountpointsamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fhacoveragerenewalratepercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the fhacoveragerenewalratepercent.
		/// </summary>
		internal System.Decimal _fhacoveragerenewalratepercent;
		/// <summary>
		/// Gets and sets the FHACoverageRenewalRatePercent value of the class instance.
		/// </summary>
		public virtual System.Decimal FHACoverageRenewalRatePercent
		{
			get
			{
				return _fhacoveragerenewalratepercent;
			}
			set
			{
				_fhacoveragerenewalratepercent = value;
				_fhacoveragerenewalratepercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FHACoverageRenewalRatePercent value to see if it was set to null.
		/// </summary>
		public System.Boolean FHACoverageRenewalRatePercentIsNull
		{
			get
			{
				return _fhacoveragerenewalratepercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fha_mipremiumrefundamount_isnull = true;
		/// <summary>
		/// Member that stores the value for the fha_mipremiumrefundamount.
		/// </summary>
		internal System.Decimal _fha_mipremiumrefundamount;
		/// <summary>
		/// Gets and sets the FHA_MIPremiumRefundAmount value of the class instance.
		/// </summary>
		public virtual System.Decimal FHA_MIPremiumRefundAmount
		{
			get
			{
				return _fha_mipremiumrefundamount;
			}
			set
			{
				_fha_mipremiumrefundamount = value;
				_fha_mipremiumrefundamount_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FHA_MIPremiumRefundAmount value to see if it was set to null.
		/// </summary>
		public System.Boolean FHA_MIPremiumRefundAmountIsNull
		{
			get
			{
				return _fha_mipremiumrefundamount_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fhaupfrontmipremiumpercent_isnull = true;
		/// <summary>
		/// Member that stores the value for the fhaupfrontmipremiumpercent.
		/// </summary>
		internal System.Decimal _fhaupfrontmipremiumpercent;
		/// <summary>
		/// Gets and sets the FHAUpfrontMIPremiumPercent value of the class instance.
		/// </summary>
		public virtual System.Decimal FHAUpfrontMIPremiumPercent
		{
			get
			{
				return _fhaupfrontmipremiumpercent;
			}
			set
			{
				_fhaupfrontmipremiumpercent = value;
				_fhaupfrontmipremiumpercent_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FHAUpfrontMIPremiumPercent value to see if it was set to null.
		/// </summary>
		public System.Boolean FHAUpfrontMIPremiumPercentIsNull
		{
			get
			{
				return _fhaupfrontmipremiumpercent_isnull;
			}
		}


		/// <summary>
		/// Member that stores the value for the lenderidentifier.
		/// </summary>
		internal System.String _lenderidentifier;
		/// <summary>
		/// Gets and sets the LenderIdentifier value of the class instance.
		/// </summary>
		public virtual System.String LenderIdentifier
		{
			get
			{
				return _lenderidentifier;
			}
			set
			{
				_lenderidentifier = value;
			}
		}


		/// <summary>
		/// Checks the LenderIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean LenderIdentifierIsNull
		{
			get
			{
				return (_lenderidentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the sponsoridentifier.
		/// </summary>
		internal System.String _sponsoridentifier;
		/// <summary>
		/// Gets and sets the SponsorIdentifier value of the class instance.
		/// </summary>
		public virtual System.String SponsorIdentifier
		{
			get
			{
				return _sponsoridentifier;
			}
			set
			{
				_sponsoridentifier = value;
			}
		}


		/// <summary>
		/// Checks the SponsorIdentifier value to see if it was set to null.
		/// </summary>
		public System.Boolean SponsorIdentifierIsNull
		{
			get
			{
				return (_sponsoridentifier == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _sectionofacttype_isnull = true;
		/// <summary>
		/// Member that stores the value for the sectionofacttype.
		/// </summary>
		internal System.Int16 _sectionofacttype;
		/// <summary>
		/// Gets and sets the SectionOfActType value of the class instance.
		/// </summary>
		public virtual System.Int16 SectionOfActType
		{
			get
			{
				return _sectionofacttype;
			}
			set
			{
				_sectionofacttype = value;
				_sectionofacttype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the SectionOfActType value to see if it was set to null.
		/// </summary>
		public System.Boolean SectionOfActTypeIsNull
		{
			get
			{
				return _sectionofacttype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _fhaalimonyliabilitytreatmenttype2_isnull = true;
		/// <summary>
		/// Member that stores the value for the fhaalimonyliabilitytreatmenttype2.
		/// </summary>
		internal System.Int16 _fhaalimonyliabilitytreatmenttype2;
		/// <summary>
		/// Gets and sets the FHAAlimonyLiabilityTreatmentType2 value of the class instance.
		/// </summary>
		public virtual System.Int16 FHAAlimonyLiabilityTreatmentType2
		{
			get
			{
				return _fhaalimonyliabilitytreatmenttype2;
			}
			set
			{
				_fhaalimonyliabilitytreatmenttype2 = value;
				_fhaalimonyliabilitytreatmenttype2_isnull = false;
			}
		}


		/// <summary>
		/// Checks the FHAAlimonyLiabilityTreatmentType2 value to see if it was set to null.
		/// </summary>
		public System.Boolean FHAAlimonyLiabilityTreatmentType2IsNull
		{
			get
			{
				return _fhaalimonyliabilitytreatmenttype2_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the FHALoanBase.
		/// </summary>
		internal static FHALoanService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(FHALoanService)) as FHALoanService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of FHALoanBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the BorrowerFinancedFHADiscountPointsAmount value as null.
		/// </summary>
		public virtual void SetBorrowerFinancedFHADiscountPointsAmountNull()
		{
			_borrowerfinancedfhadiscountpointsamount = 0;
			_borrowerfinancedfhadiscountpointsamount_isnull = true;
		}


		/// <summary>
		/// Marks the FHACoverageRenewalRatePercent value as null.
		/// </summary>
		public virtual void SetFHACoverageRenewalRatePercentNull()
		{
			_fhacoveragerenewalratepercent = 0;
			_fhacoveragerenewalratepercent_isnull = true;
		}


		/// <summary>
		/// Marks the FHA_MIPremiumRefundAmount value as null.
		/// </summary>
		public virtual void SetFHA_MIPremiumRefundAmountNull()
		{
			_fha_mipremiumrefundamount = 0;
			_fha_mipremiumrefundamount_isnull = true;
		}


		/// <summary>
		/// Marks the FHAUpfrontMIPremiumPercent value as null.
		/// </summary>
		public virtual void SetFHAUpfrontMIPremiumPercentNull()
		{
			_fhaupfrontmipremiumpercent = 0;
			_fhaupfrontmipremiumpercent_isnull = true;
		}


		/// <summary>
		/// Marks the LenderIdentifier value as null.
		/// </summary>
		public virtual void SetLenderIdentifierNull()
		{
			_lenderidentifier = null;
		}


		/// <summary>
		/// Marks the SponsorIdentifier value as null.
		/// </summary>
		public virtual void SetSponsorIdentifierNull()
		{
			_sponsoridentifier = null;
		}


		/// <summary>
		/// Marks the SectionOfActType value as null.
		/// </summary>
		public virtual void SetSectionOfActTypeNull()
		{
			_sectionofacttype = 0;
			_sectionofacttype_isnull = true;
		}


		/// <summary>
		/// Marks the FHAAlimonyLiabilityTreatmentType2 value as null.
		/// </summary>
		public virtual void SetFHAAlimonyLiabilityTreatmentType2Null()
		{
			_fhaalimonyliabilitytreatmenttype2 = 0;
			_fhaalimonyliabilitytreatmenttype2_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref FHALoanBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the BorrowerFinancedFHADiscountPointsAmount data to the class member
			_borrowerfinancedfhadiscountpointsamount = data._borrowerfinancedfhadiscountpointsamount;
			_borrowerfinancedfhadiscountpointsamount_isnull = data._borrowerfinancedfhadiscountpointsamount_isnull;
			// assigns the FHACoverageRenewalRatePercent data to the class member
			_fhacoveragerenewalratepercent = data._fhacoveragerenewalratepercent;
			_fhacoveragerenewalratepercent_isnull = data._fhacoveragerenewalratepercent_isnull;
			// assigns the FHA_MIPremiumRefundAmount data to the class member
			_fha_mipremiumrefundamount = data._fha_mipremiumrefundamount;
			_fha_mipremiumrefundamount_isnull = data._fha_mipremiumrefundamount_isnull;
			// assigns the FHAUpfrontMIPremiumPercent data to the class member
			_fhaupfrontmipremiumpercent = data._fhaupfrontmipremiumpercent;
			_fhaupfrontmipremiumpercent_isnull = data._fhaupfrontmipremiumpercent_isnull;
			// assigns the LenderIdentifier data to the class member
			_lenderidentifier = data._lenderidentifier;
			// assigns the SponsorIdentifier data to the class member
			_sponsoridentifier = data._sponsoridentifier;
			// assigns the SectionOfActType data to the class member
			_sectionofacttype = data._sectionofacttype;
			_sectionofacttype_isnull = data._sectionofacttype_isnull;
			// assigns the FHAAlimonyLiabilityTreatmentType2 data to the class member
			_fhaalimonyliabilitytreatmenttype2 = data._fhaalimonyliabilitytreatmenttype2;
			_fhaalimonyliabilitytreatmenttype2_isnull = data._fhaalimonyliabilitytreatmenttype2_isnull;


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
			// assigns the BorrowerFinancedFHADiscountPointsAmount data to the class member
			if (data["BorrowerFinancedFHADiscountPointsAmount"] == System.DBNull.Value)
				SetBorrowerFinancedFHADiscountPointsAmountNull();
			else
			{
				_borrowerfinancedfhadiscountpointsamount = Convert.ToDecimal(data["BorrowerFinancedFHADiscountPointsAmount"]);
				_borrowerfinancedfhadiscountpointsamount_isnull = false;
			}
			// assigns the FHACoverageRenewalRatePercent data to the class member
			if (data["FHACoverageRenewalRatePercent"] == System.DBNull.Value)
				SetFHACoverageRenewalRatePercentNull();
			else
			{
				_fhacoveragerenewalratepercent = Convert.ToDecimal(data["FHACoverageRenewalRatePercent"]);
				_fhacoveragerenewalratepercent_isnull = false;
			}
			// assigns the FHA_MIPremiumRefundAmount data to the class member
			if (data["FHA_MIPremiumRefundAmount"] == System.DBNull.Value)
				SetFHA_MIPremiumRefundAmountNull();
			else
			{
				_fha_mipremiumrefundamount = Convert.ToDecimal(data["FHA_MIPremiumRefundAmount"]);
				_fha_mipremiumrefundamount_isnull = false;
			}
			// assigns the FHAUpfrontMIPremiumPercent data to the class member
			if (data["FHAUpfrontMIPremiumPercent"] == System.DBNull.Value)
				SetFHAUpfrontMIPremiumPercentNull();
			else
			{
				_fhaupfrontmipremiumpercent = Convert.ToDecimal(data["FHAUpfrontMIPremiumPercent"]);
				_fhaupfrontmipremiumpercent_isnull = false;
			}
			// assigns the LenderIdentifier data to the class member
			if (data["LenderIdentifier"] == System.DBNull.Value)
				SetLenderIdentifierNull();
			else
			{
				_lenderidentifier = Convert.ToString(data["LenderIdentifier"]);
			}
			// assigns the SponsorIdentifier data to the class member
			if (data["SponsorIdentifier"] == System.DBNull.Value)
				SetSponsorIdentifierNull();
			else
			{
				_sponsoridentifier = Convert.ToString(data["SponsorIdentifier"]);
			}
			// assigns the SectionOfActType data to the class member
			if (data["SectionOfActType"] == System.DBNull.Value)
				SetSectionOfActTypeNull();
			else
			{
				_sectionofacttype = Convert.ToInt16(data["SectionOfActType"]);
				_sectionofacttype_isnull = false;
			}
			// assigns the FHAAlimonyLiabilityTreatmentType2 data to the class member
			if (data["FHAAlimonyLiabilityTreatmentType2"] == System.DBNull.Value)
				SetFHAAlimonyLiabilityTreatmentType2Null();
			else
			{
				_fhaalimonyliabilitytreatmenttype2 = Convert.ToInt16(data["FHAAlimonyLiabilityTreatmentType2"]);
				_fhaalimonyliabilitytreatmenttype2_isnull = false;
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
			// assigns the BorrowerFinancedFHADiscountPointsAmount data to the class member
			if (data["BorrowerFinancedFHADiscountPointsAmount"] == System.DBNull.Value)
				SetBorrowerFinancedFHADiscountPointsAmountNull();
			else
			{
				_borrowerfinancedfhadiscountpointsamount = Convert.ToDecimal(data["BorrowerFinancedFHADiscountPointsAmount"]);
				_borrowerfinancedfhadiscountpointsamount_isnull = false;
			}
			// assigns the FHACoverageRenewalRatePercent data to the class member
			if (data["FHACoverageRenewalRatePercent"] == System.DBNull.Value)
				SetFHACoverageRenewalRatePercentNull();
			else
			{
				_fhacoveragerenewalratepercent = Convert.ToDecimal(data["FHACoverageRenewalRatePercent"]);
				_fhacoveragerenewalratepercent_isnull = false;
			}
			// assigns the FHA_MIPremiumRefundAmount data to the class member
			if (data["FHA_MIPremiumRefundAmount"] == System.DBNull.Value)
				SetFHA_MIPremiumRefundAmountNull();
			else
			{
				_fha_mipremiumrefundamount = Convert.ToDecimal(data["FHA_MIPremiumRefundAmount"]);
				_fha_mipremiumrefundamount_isnull = false;
			}
			// assigns the FHAUpfrontMIPremiumPercent data to the class member
			if (data["FHAUpfrontMIPremiumPercent"] == System.DBNull.Value)
				SetFHAUpfrontMIPremiumPercentNull();
			else
			{
				_fhaupfrontmipremiumpercent = Convert.ToDecimal(data["FHAUpfrontMIPremiumPercent"]);
				_fhaupfrontmipremiumpercent_isnull = false;
			}
			// assigns the LenderIdentifier data to the class member
			if (data["LenderIdentifier"] == System.DBNull.Value)
				SetLenderIdentifierNull();
			else
			{
				_lenderidentifier = Convert.ToString(data["LenderIdentifier"]);
			}
			// assigns the SponsorIdentifier data to the class member
			if (data["SponsorIdentifier"] == System.DBNull.Value)
				SetSponsorIdentifierNull();
			else
			{
				_sponsoridentifier = Convert.ToString(data["SponsorIdentifier"]);
			}
			// assigns the SectionOfActType data to the class member
			if (data["SectionOfActType"] == System.DBNull.Value)
				SetSectionOfActTypeNull();
			else
			{
				_sectionofacttype = Convert.ToInt16(data["SectionOfActType"]);
				_sectionofacttype_isnull = false;
			}
			// assigns the FHAAlimonyLiabilityTreatmentType2 data to the class member
			if (data["FHAAlimonyLiabilityTreatmentType2"] == System.DBNull.Value)
				SetFHAAlimonyLiabilityTreatmentType2Null();
			else
			{
				_fhaalimonyliabilitytreatmenttype2 = Convert.ToInt16(data["FHAAlimonyLiabilityTreatmentType2"]);
				_fhaalimonyliabilitytreatmenttype2_isnull = false;
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
			FHALoanBase.ServiceObject.Persist(this as FHALoan, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the FHA_LOAN object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			FHALoanBase.ServiceObject.Delete(this as FHALoan);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the single object for the FHAAlimonyLiabilityTreatmentType relationship.
		/// </summary>
		public FHAAlimonyLiabilityTreatmentType GetFHAAlimonyLiabilityTreatmentType()
		{
			if (_fhaalimonyliabilitytreatmenttype2_isnull)
				return null;
			else
				return new FHAAlimonyLiabilityTreatmentType(_fhaalimonyliabilitytreatmenttype2);
		}


		/// <summary>
		/// Gets the single object for the GOVERNMENT_LOAN relationship.
		/// </summary>
		public GovernmentLoan GetGovernmentLoan()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new GovernmentLoan(_loanapplicationid);
		}


		/// <summary>
		/// Gets the single object for the NationalHousingActSectionType relationship.
		/// </summary>
		public NationalHousingActSectionType GetNationalHousingActSectionType()
		{
			if (_sectionofacttype_isnull)
				return null;
			else
				return new NationalHousingActSectionType(_sectionofacttype);
		}


		/// <summary>
		/// Gets all persisted FHALoan objects
		/// </summary>
		public static FHALoans GetAll()
		{
			// have the service object get the objects
			return FHALoanBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
