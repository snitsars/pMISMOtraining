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
using System.Data;
using System.Data.SqlClient;
using OrcaLogic;
using MISMO.EnterpriseCode;
using MISMO.Entities;
using MISMO.BusinessObjects;


namespace MISMO.DAL
{
	/// <summary>
	/// A base class service object for table 'LOAN_FEATURES'
	/// </summary>
	internal class LoanFeaturesServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanFeaturesServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(LoanFeatures persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(LoanFeatures persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_UpdateLoanFeatures");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_CreateLoanFeatures");


				// Store the parameter for the AssumabilityIndicator attribute.
				sqlparams["@assumabilityIndicator"].Value = persistObject.AssumabilityIndicator;
				// Store the parameter for the BalloonIndicator attribute.
				sqlparams["@balloonIndicator"].Value = persistObject.BalloonIndicator;
				// Store the parameter for the BalloonLoanMaturityTermMonths attribute.
				if (!persistObject.BalloonLoanMaturityTermMonthsIsNull)
					sqlparams["@balloonLoanMaturityTermMonths"].Value = persistObject.BalloonLoanMaturityTermMonths;
				// Store the parameter for the BuydownTemporarySubsidyIndicator attribute.
				sqlparams["@buydownTemporarySubsidyIndicator"].Value = persistObject.BuydownTemporarySubsidyIndicator;
				// Store the parameter for the CounselingConfirmationIndicator attribute.
				sqlparams["@counselingConfirmationIndicator"].Value = persistObject.CounselingConfirmationIndicator;
				// Store the parameter for the EscrowWaiverIndicator attribute.
				sqlparams["@escrowWaiverIndicator"].Value = persistObject.EscrowWaiverIndicator;
				// Store the parameter for the FREOfferingIdentifier attribute.
				if (!persistObject.FREOfferingIdentifierIsNull)
					sqlparams["@fREOfferingIdentifier"].Value = persistObject.FREOfferingIdentifier;
				// Store the parameter for the FNMProductPlanIdentifier attribute.
				if (!persistObject.FNMProductPlanIdentifierIsNull)
					sqlparams["@fNMProductPlanIdentifier"].Value = persistObject.FNMProductPlanIdentifier;
				// Store the parameter for the FNMProductPlanIndentifier attribute.
				if (!persistObject.FNMProductPlanIndentifierIsNull)
					sqlparams["@fNMProductPlanIndentifier"].Value = persistObject.FNMProductPlanIndentifier;
				// Store the parameter for the HELOCMaximumBalanceAmount attribute.
				if (!persistObject.HELOCMaximumBalanceAmountIsNull)
					sqlparams["@hELOCMaximumBalanceAmount"].Value = persistObject.HELOCMaximumBalanceAmount;
				// Store the parameter for the HELOCInitialAdvanceAmount attribute.
				if (!persistObject.HELOCInitialAdvanceAmountIsNull)
					sqlparams["@hELOCInitialAdvanceAmount"].Value = persistObject.HELOCInitialAdvanceAmount;
				// Store the parameter for the InterestOnlyTerm attribute.
				if (!persistObject.InterestOnlyTermIsNull)
					sqlparams["@interestOnlyTerm"].Value = persistObject.InterestOnlyTerm;
				// Store the parameter for the LenderSelfInsuredIndicator attribute.
				sqlparams["@lenderSelfInsuredIndicator"].Value = persistObject.LenderSelfInsuredIndicator;
				// Store the parameter for the LoanScheduledClosingDate attribute.
				if (!persistObject.LoanScheduledClosingDateIsNull)
					sqlparams["@loanScheduledClosingDate"].Value = persistObject.LoanScheduledClosingDate;
				// Store the parameter for the MICoveragePercent attribute.
				if (!persistObject.MICoveragePercentIsNull)
					sqlparams["@mICoveragePercent"].Value = persistObject.MICoveragePercent;
				// Store the parameter for the NegativeAmortizationLimitPercent attribute.
				if (!persistObject.NegativeAmortizationLimitPercentIsNull)
					sqlparams["@negativeAmortizationLimitPercent"].Value = persistObject.NegativeAmortizationLimitPercent;
				// Store the parameter for the PrepaymentPenaltyIndicator attribute.
				sqlparams["@prepaymentPenaltyIndicator"].Value = persistObject.PrepaymentPenaltyIndicator;
				// Store the parameter for the PrepaymentPenaltyTermMonths attribute.
				if (!persistObject.PrepaymentPenaltyTermMonthsIsNull)
					sqlparams["@prepaymentPenaltyTermMonths"].Value = persistObject.PrepaymentPenaltyTermMonths;
				// Store the parameter for the PrepaymentRestrictionIndicator attribute.
				sqlparams["@prepaymentRestrictionIndicator"].Value = persistObject.PrepaymentRestrictionIndicator;
				// Store the parameter for the ProductDescription attribute.
				if (!persistObject.ProductDescriptionIsNull)
					sqlparams["@productDescription"].Value = persistObject.ProductDescription;
				// Store the parameter for the ProductName attribute.
				if (!persistObject.ProductNameIsNull)
					sqlparams["@productName"].Value = persistObject.ProductName;
				// Store the parameter for the ScheduledFirstPaymentDate attribute.
				if (!persistObject.ScheduledFirstPaymentDateIsNull)
					sqlparams["@scheduledFirstPaymentDate"].Value = persistObject.ScheduledFirstPaymentDate;
				// Store the parameter for the NameDocumentsDrawnInType attribute.
				if (!persistObject.NameDocumentsDrawnInTypeIsNull)
					sqlparams["@nameDocumentsDrawnInType"].Value = persistObject.NameDocumentsDrawnInType;
				// Store the parameter for the GSEProjectClassificationType attribute.
				if (!persistObject.GSEProjectClassificationTypeIsNull)
					sqlparams["@gSEProjectClassificationType"].Value = persistObject.GSEProjectClassificationType;
				// Store the parameter for the GSEPropertyType attribute.
				if (!persistObject.GSEPropertyTypeIsNull)
					sqlparams["@gSEPropertyType"].Value = persistObject.GSEPropertyType;
				// Store the parameter for the LienPriorityType attribute.
				if (!persistObject.LienPriorityTypeIsNull)
					sqlparams["@lienPriorityType"].Value = persistObject.LienPriorityType;
				// Store the parameter for the LoanDocumentationType attribute.
				if (!persistObject.LoanDocumentationTypeIsNull)
					sqlparams["@loanDocumentationType"].Value = persistObject.LoanDocumentationType;
				// Store the parameter for the LoanRepaymentType attribute.
				if (!persistObject.LoanRepaymentTypeIsNull)
					sqlparams["@loanRepaymentType"].Value = persistObject.LoanRepaymentType;
				// Store the parameter for the MICertificationStatusType attribute.
				if (!persistObject.MICertificationStatusTypeIsNull)
					sqlparams["@mICertificationStatusType"].Value = persistObject.MICertificationStatusType;
				// Store the parameter for the MICompanyNameType attribute.
				if (!persistObject.MICompanyNameTypeIsNull)
					sqlparams["@mICompanyNameType"].Value = persistObject.MICompanyNameType;
				// Store the parameter for the PaymentFrequencyType attribute.
				if (!persistObject.PaymentFrequencyTypeIsNull)
					sqlparams["@paymentFrequencyType"].Value = persistObject.PaymentFrequencyType;
				// Store the parameter for the FullPrepaymentPenaltyOptionType attribute.
				if (!persistObject.FullPrepaymentPenaltyOptionTypeIsNull)
					sqlparams["@fullPrepaymentPenaltyOptionType"].Value = persistObject.FullPrepaymentPenaltyOptionType;
				// Store the parameter for the LoanClosingStatusType attribute.
				if (!persistObject.LoanClosingStatusTypeIsNull)
					sqlparams["@loanClosingStatusType"].Value = persistObject.LoanClosingStatusType;
				// Store the parameter for the ServicingTransferStatusType attribute.
				if (!persistObject.ServicingTransferStatusTypeIsNull)
					sqlparams["@servicingTransferStatusType"].Value = persistObject.ServicingTransferStatusType;
				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = persistObject.LoanApplicationId;
				if (!persistObject.Persisted)
				{
					// store the create only (historical fixed) values
				}
				else
				{
					// store the update only (historical changeable) values
				}


				if (sqlTrans == null)
				{
					// Process using the isolated connection
					using (cnn)
					{
						// open the connection
						cnn.Open();


						if (!persistObject.Persisted)
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateLoanFeatures", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateLoanFeatures", sqlparams);
						}


						// close the connection after usage
						cnn.Close();
					}


					// nullify the connection var
					cnn = null;
				}
				else
				{
					// Process using the shared transaction
					if (!persistObject.Persisted)
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateLoanFeatures", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateLoanFeatures", sqlparams);
					}
				}
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Deletes the object.
		/// </summary>
		public virtual void Delete(LoanFeatures deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_DeleteLoanFeatures");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteLoanFeatures", sqlparams);


					// close the connection after usage
					cnn.Close();
				}


				// nullify the connection var
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}


			// nullify the reference
			deleteObject = null;
		}


		/// <summary>
		/// Fills a single instance with data based on its primary key values.
		/// </summary>
		public virtual void Fill(LoanFeatures loanfeatures, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeatures");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeatures", sqlparams);


					if (datareader.Read())
						loanfeatures.SetMembers(ref datareader);


					cnn.Close(); // close the connection
				}


				// nullify the connection var
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating an entire collection of LoanFeaturesCollection
		/// </summary>
		public virtual void Fill(LoanFeaturesCollection loanFeaturesCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by FullPrepaymentPenaltyOptionType
		/// </summary>
		public void FillByFullPrepaymentPenaltyOptionType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByFullPrepaymentPenaltyOptionType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@fullPrepaymentPenaltyOptionType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByFullPrepaymentPenaltyOptionType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by GSEProjectClassificationType
		/// </summary>
		public void FillByGSEProjectClassificationType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByGSEProjectClassificationType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@gSEProjectClassificationType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByGSEProjectClassificationType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by GSEPropertyType
		/// </summary>
		public void FillByGSEPropertyType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByGSEPropertyType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@gSEPropertyType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByGSEPropertyType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by LienPriorityType
		/// </summary>
		public void FillByLienPriorityType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByLienPriorityType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@lienPriorityType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByLienPriorityType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by LOAN_PRODUCT_DATA
		/// </summary>
		public void FillByLoanProductData(LoanFeaturesCollection loanFeaturesCollection, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByLoanProductData");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByLoanProductData", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by LoanClosingStatusType
		/// </summary>
		public void FillByLoanClosingStatusType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByLoanClosingStatusType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanClosingStatusType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByLoanClosingStatusType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by LoanDocumentationType
		/// </summary>
		public void FillByLoanDocumentationType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByLoanDocumentationType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanDocumentationType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByLoanDocumentationType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by LoanRepaymentType
		/// </summary>
		public void FillByLoanRepaymentType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByLoanRepaymentType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanRepaymentType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByLoanRepaymentType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by MICertificationStatusType
		/// </summary>
		public void FillByMICertificationStatusType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByMICertificationStatusType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@mICertificationStatusType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByMICertificationStatusType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by MICompanyNameType
		/// </summary>
		public void FillByMICompanyNameType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByMICompanyNameType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@mICompanyNameType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByMICompanyNameType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by NameDocumentsDrawnInType
		/// </summary>
		public void FillByNameDocumentsDrawnInType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByNameDocumentsDrawnInType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@nameDocumentsDrawnInType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByNameDocumentsDrawnInType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by PaymentFrequencyType
		/// </summary>
		public void FillByPaymentFrequencyType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByPaymentFrequencyType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@paymentFrequencyType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByPaymentFrequencyType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// Fill method for populating a collection by ServicingTransferStatusType
		/// </summary>
		public void FillByServicingTransferStatusType(LoanFeaturesCollection loanFeaturesCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(LoanFeatures.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(LoanFeatures.GetConnectionString(), "gsp_SelectLoanFeaturesCollectionByServicingTransferStatusType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@servicingTransferStatusType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLoanFeaturesCollectionByServicingTransferStatusType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(loanFeaturesCollection, datareader);


					// close the connection
					cnn.Close();
				}


				// nullify the connection
				cnn = null;
			}
			catch (SqlException sqlex)
			{
				throw sqlex;
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(LoanFeaturesCollection loanfeaturescollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			LoanFeatures newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(loanfeaturescollection.ContainsType[0]) as LoanFeatures;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				loanfeaturescollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(LoanFeaturesCollection loanfeaturescollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			LoanFeatures newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(loanfeaturescollection.ContainsType[0]) as LoanFeatures;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				loanfeaturescollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual LoanFeaturesCollection GetAll()
		{
			// create a new instance of the return object
			LoanFeaturesCollection objects = new LoanFeaturesCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
