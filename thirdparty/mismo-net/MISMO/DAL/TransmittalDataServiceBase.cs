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
	/// A base class service object for table 'TRANSMITTAL_DATA'
	/// </summary>
	internal class TransmittalDataServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransmittalDataServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(TransmittalData persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(TransmittalData persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(TransmittalData.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_UpdateTransmittalData");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_CreateTransmittalData");


				// Store the parameter for the ArmsLengthIndicator attribute.
				sqlparams["@armsLengthIndicator"].Value = persistObject.ArmsLengthIndicator;
				// Store the parameter for the BelowMarketSubordinateFinancingIndicator attribute.
				sqlparams["@belowMarketSubordinateFinancingIndicator"].Value = persistObject.BelowMarketSubordinateFinancingIndicator;
				// Store the parameter for the BuydownRatePercent attribute.
				if (!persistObject.BuydownRatePercentIsNull)
					sqlparams["@buydownRatePercent"].Value = persistObject.BuydownRatePercent;
				// Store the parameter for the CreditReportAuthorizationIndicator attribute.
				sqlparams["@creditReportAuthorizationIndicator"].Value = persistObject.CreditReportAuthorizationIndicator;
				// Store the parameter for the LenderBranchIdentifier attribute.
				if (!persistObject.LenderBranchIdentifierIsNull)
					sqlparams["@lenderBranchIdentifier"].Value = persistObject.LenderBranchIdentifier;
				// Store the parameter for the LenderRegistrationIdentifier attribute.
				if (!persistObject.LenderRegistrationIdentifierIsNull)
					sqlparams["@lenderRegistrationIdentifier"].Value = persistObject.LenderRegistrationIdentifier;
				// Store the parameter for the PropertyAppraisedValueAmount attribute.
				if (!persistObject.PropertyAppraisedValueAmountIsNull)
					sqlparams["@propertyAppraisedValueAmount"].Value = persistObject.PropertyAppraisedValueAmount;
				// Store the parameter for the PropertyEstimatedValueAmount attribute.
				if (!persistObject.PropertyEstimatedValueAmountIsNull)
					sqlparams["@propertyEstimatedValueAmount"].Value = persistObject.PropertyEstimatedValueAmount;
				// Store the parameter for the InvestorLoanIdentifier attribute.
				if (!persistObject.InvestorLoanIdentifierIsNull)
					sqlparams["@investorLoanIdentifier"].Value = persistObject.InvestorLoanIdentifier;
				// Store the parameter for the InvestorInstitutionIdentifier attribute.
				if (!persistObject.InvestorInstitutionIdentifierIsNull)
					sqlparams["@investorInstitutionIdentifier"].Value = persistObject.InvestorInstitutionIdentifier;
				// Store the parameter for the CommitmentReferenceIdentifier attribute.
				if (!persistObject.CommitmentReferenceIdentifierIsNull)
					sqlparams["@commitmentReferenceIdentifier"].Value = persistObject.CommitmentReferenceIdentifier;
				// Store the parameter for the ConcurrentOriginationIndicator attribute.
				sqlparams["@concurrentOriginationIndicator"].Value = persistObject.ConcurrentOriginationIndicator;
				// Store the parameter for the ConcurrentOriginationLenderIndicator attribute.
				sqlparams["@concurrentOriginationLenderIndicator"].Value = persistObject.ConcurrentOriginationLenderIndicator;
				// Store the parameter for the RateLockPeriodDays attribute.
				if (!persistObject.RateLockPeriodDaysIsNull)
					sqlparams["@rateLockPeriodDays"].Value = persistObject.RateLockPeriodDays;
				// Store the parameter for the RateLockRequestedExtensionDays attribute.
				if (!persistObject.RateLockRequestedExtensionDaysIsNull)
					sqlparams["@rateLockRequestedExtensionDays"].Value = persistObject.RateLockRequestedExtensionDays;
				// Store the parameter for the CaseStateType attribute.
				if (!persistObject.CaseStateTypeIsNull)
					sqlparams["@caseStateType"].Value = persistObject.CaseStateType;
				// Store the parameter for the RateLockType attribute.
				if (!persistObject.RateLockTypeIsNull)
					sqlparams["@rateLockType"].Value = persistObject.RateLockType;
				// Store the parameter for the CurrentFirstMortgageHolderType attribute.
				if (!persistObject.CurrentFirstMortgageHolderTypeIsNull)
					sqlparams["@currentFirstMortgageHolderType"].Value = persistObject.CurrentFirstMortgageHolderType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateTransmittalData", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateTransmittalData", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateTransmittalData", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateTransmittalData", sqlparams);
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
		public virtual void Delete(TransmittalData deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_DeleteTransmittalData");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteTransmittalData", sqlparams);


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
		public virtual void Fill(TransmittalData transmittaldata, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_SelectTransmittalData");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransmittalData", sqlparams);


					if (datareader.Read())
						transmittaldata.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of TransmittalDataCollection
		/// </summary>
		public virtual void Fill(TransmittalDataCollection transmittalDataCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransmittalDataCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(transmittalDataCollection, datareader);


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
		/// Fill method for populating a collection by CaseStateType
		/// </summary>
		public void FillByCaseStateType(TransmittalDataCollection transmittalDataCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_SelectTransmittalDataCollectionByCaseStateType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@caseStateType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransmittalDataCollectionByCaseStateType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(transmittalDataCollection, datareader);


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
		/// Fill method for populating a collection by MortgageHolderType
		/// </summary>
		public void FillByMortgageHolderType(TransmittalDataCollection transmittalDataCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_SelectTransmittalDataCollectionByMortgageHolderType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@currentFirstMortgageHolderType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransmittalDataCollectionByMortgageHolderType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(transmittalDataCollection, datareader);


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
		/// Fill method for populating a collection by ADDITIONAL_CASE_DATA
		/// </summary>
		public void FillByAdditionalCaseData(TransmittalDataCollection transmittalDataCollection, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_SelectTransmittalDataCollectionByAdditionalCaseData");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransmittalDataCollectionByAdditionalCaseData", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(transmittalDataCollection, datareader);


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
		/// Fill method for populating a collection by RateLockType
		/// </summary>
		public void FillByRateLockType(TransmittalDataCollection transmittalDataCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransmittalData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransmittalData.GetConnectionString(), "gsp_SelectTransmittalDataCollectionByRateLockType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@rateLockType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransmittalDataCollectionByRateLockType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(transmittalDataCollection, datareader);


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
		public virtual void CreateObjectsFromData(TransmittalDataCollection transmittaldatacollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			TransmittalData newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(transmittaldatacollection.ContainsType[0]) as TransmittalData;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				transmittaldatacollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(TransmittalDataCollection transmittaldatacollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			TransmittalData newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(transmittaldatacollection.ContainsType[0]) as TransmittalData;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				transmittaldatacollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual TransmittalDataCollection GetAll()
		{
			// create a new instance of the return object
			TransmittalDataCollection objects = new TransmittalDataCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
