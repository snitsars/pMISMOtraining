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
	/// A base class service object for table 'MORTGAGE_TERMS'
	/// </summary>
	internal class MortgageTermsServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageTermsServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(MortgageTerms persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(MortgageTerms persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(MortgageTerms.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_UpdateMortgageTerms");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_CreateMortgageTerms");


				// Store the parameter for the AgencyCaseIdentifier attribute.
				if (!persistObject.AgencyCaseIdentifierIsNull)
					sqlparams["@agencyCaseIdentifier"].Value = persistObject.AgencyCaseIdentifier;
				// Store the parameter for the ARMTypeDescription attribute.
				if (!persistObject.ARMTypeDescriptionIsNull)
					sqlparams["@aRMTypeDescription"].Value = persistObject.ARMTypeDescription;
				// Store the parameter for the BaseLoanAmount attribute.
				if (!persistObject.BaseLoanAmountIsNull)
					sqlparams["@baseLoanAmount"].Value = persistObject.BaseLoanAmount;
				// Store the parameter for the BorrowerRequestedLoanAmount attribute.
				if (!persistObject.BorrowerRequestedLoanAmountIsNull)
					sqlparams["@borrowerRequestedLoanAmount"].Value = persistObject.BorrowerRequestedLoanAmount;
				// Store the parameter for the LenderCaseIdentifier attribute.
				if (!persistObject.LenderCaseIdentifierIsNull)
					sqlparams["@lenderCaseIdentifier"].Value = persistObject.LenderCaseIdentifier;
				// Store the parameter for the LoanAmortizationTermMonths attribute.
				if (!persistObject.LoanAmortizationTermMonthsIsNull)
					sqlparams["@loanAmortizationTermMonths"].Value = persistObject.LoanAmortizationTermMonths;
				// Store the parameter for the OtherMortgageTypeDescription attribute.
				if (!persistObject.OtherMortgageTypeDescriptionIsNull)
					sqlparams["@otherMortgageTypeDescription"].Value = persistObject.OtherMortgageTypeDescription;
				// Store the parameter for the OtherAmortizationTypeDescription attribute.
				if (!persistObject.OtherAmortizationTypeDescriptionIsNull)
					sqlparams["@otherAmortizationTypeDescription"].Value = persistObject.OtherAmortizationTypeDescription;
				// Store the parameter for the RequestedInterestRatePercent attribute.
				if (!persistObject.RequestedInterestRatePercentIsNull)
					sqlparams["@requestedInterestRatePercent"].Value = persistObject.RequestedInterestRatePercent;
				// Store the parameter for the LoanAmortizationType attribute.
				if (!persistObject.LoanAmortizationTypeIsNull)
					sqlparams["@loanAmortizationType"].Value = persistObject.LoanAmortizationType;
				// Store the parameter for the MortgageType attribute.
				if (!persistObject.MortgageTypeIsNull)
					sqlparams["@mortgageType"].Value = persistObject.MortgageType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateMortgageTerms", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateMortgageTerms", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateMortgageTerms", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateMortgageTerms", sqlparams);
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
		public virtual void Delete(MortgageTerms deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(MortgageTerms.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_DeleteMortgageTerms");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteMortgageTerms", sqlparams);


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
		public virtual void Fill(MortgageTerms mortgageterms, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageTerms.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_SelectMortgageTerms");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageTerms", sqlparams);


					if (datareader.Read())
						mortgageterms.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of MortgageTermsCollection
		/// </summary>
		public virtual void Fill(MortgageTermsCollection mortgageTermsCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageTerms.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageTermsCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(mortgageTermsCollection, datareader);


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
		/// Fill method for populating a collection by LoanAmortizationType
		/// </summary>
		public void FillByLoanAmortizationType(MortgageTermsCollection mortgageTermsCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageTerms.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_SelectMortgageTermsCollectionByLoanAmortizationType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanAmortizationType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageTermsCollectionByLoanAmortizationType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(mortgageTermsCollection, datareader);


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
		/// Fill method for populating a collection by LOAN_APPLICATION
		/// </summary>
		public void FillByLoanApplication(MortgageTermsCollection mortgageTermsCollection, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageTerms.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_SelectMortgageTermsCollectionByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageTermsCollectionByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(mortgageTermsCollection, datareader);


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
		/// Fill method for populating a collection by MortgageType
		/// </summary>
		public void FillByMortgageType(MortgageTermsCollection mortgageTermsCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageTerms.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(MortgageTerms.GetConnectionString(), "gsp_SelectMortgageTermsCollectionByMortgageType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@mortgageType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageTermsCollectionByMortgageType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(mortgageTermsCollection, datareader);


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
		public virtual void CreateObjectsFromData(MortgageTermsCollection mortgagetermscollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			MortgageTerms newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(mortgagetermscollection.ContainsType[0]) as MortgageTerms;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				mortgagetermscollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(MortgageTermsCollection mortgagetermscollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			MortgageTerms newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(mortgagetermscollection.ContainsType[0]) as MortgageTerms;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				mortgagetermscollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual MortgageTermsCollection GetAll()
		{
			// create a new instance of the return object
			MortgageTermsCollection objects = new MortgageTermsCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
