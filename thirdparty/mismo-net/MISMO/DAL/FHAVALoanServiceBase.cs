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
	/// A base class service object for table 'FHA_VA_LOAN'
	/// </summary>
	internal class FHAVALoanServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVALoanServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(FHAVALoan persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(FHAVALoan persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(FHAVALoan.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHAVALoan.GetConnectionString(), "gsp_UpdateFHAVALoan");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHAVALoan.GetConnectionString(), "gsp_CreateFHAVALoan");


				// Store the parameter for the BorrowerPaidFHA_VAClosingCostsAmount attribute.
				if (!persistObject.BorrowerPaidFHA_VAClosingCostsAmountIsNull)
					sqlparams["@borrowerPaidFHA_VAClosingCostsAmount"].Value = persistObject.BorrowerPaidFHA_VAClosingCostsAmount;
				// Store the parameter for the BorrowerPaidFHA_VAClosingCostsPercent attribute.
				if (!persistObject.BorrowerPaidFHA_VAClosingCostsPercentIsNull)
					sqlparams["@borrowerPaidFHA_VAClosingCostsPercent"].Value = persistObject.BorrowerPaidFHA_VAClosingCostsPercent;
				// Store the parameter for the GovernmentMortgageCreditCertificateAmount attribute.
				if (!persistObject.GovernmentMortgageCreditCertificateAmountIsNull)
					sqlparams["@governmentMortgageCreditCertificateAmount"].Value = persistObject.GovernmentMortgageCreditCertificateAmount;
				// Store the parameter for the GovernmentRefinanceType attribute.
				if (!persistObject.GovernmentRefinanceTypeIsNull)
					sqlparams["@governmentRefinanceType"].Value = persistObject.GovernmentRefinanceType;
				// Store the parameter for the OtherPartyPaidFHA_VAClosingCostsAmount attribute.
				if (!persistObject.OtherPartyPaidFHA_VAClosingCostsAmountIsNull)
					sqlparams["@otherPartyPaidFHA_VAClosingCostsAmount"].Value = persistObject.OtherPartyPaidFHA_VAClosingCostsAmount;
				// Store the parameter for the OtherPartyPaidFHA_VAClosingCostsPercent attribute.
				if (!persistObject.OtherPartyPaidFHA_VAClosingCostsPercentIsNull)
					sqlparams["@otherPartyPaidFHA_VAClosingCostsPercent"].Value = persistObject.OtherPartyPaidFHA_VAClosingCostsPercent;
				// Store the parameter for the PropertyEnergyEfficientHomeIndicator attribute.
				if (!persistObject.PropertyEnergyEfficientHomeIndicatorIsNull)
					sqlparams["@propertyEnergyEfficientHomeIndicator"].Value = persistObject.PropertyEnergyEfficientHomeIndicator;
				// Store the parameter for the SellerPaidFHA_VAClosingCostsPercent attribute.
				if (!persistObject.SellerPaidFHA_VAClosingCostsPercentIsNull)
					sqlparams["@sellerPaidFHA_VAClosingCostsPercent"].Value = persistObject.SellerPaidFHA_VAClosingCostsPercent;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateFHAVALoan", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateFHAVALoan", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateFHAVALoan", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateFHAVALoan", sqlparams);
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
		public virtual void Delete(FHAVALoan deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(FHAVALoan.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHAVALoan.GetConnectionString(), "gsp_DeleteFHAVALoan");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteFHAVALoan", sqlparams);


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
		public virtual void Fill(FHAVALoan fhavaloan, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVALoan.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHAVALoan.GetConnectionString(), "gsp_SelectFHAVALoan");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVALoan", sqlparams);


					if (datareader.Read())
						fhavaloan.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of FHAVALoans
		/// </summary>
		public virtual void Fill(FHAVALoans fHAVALoans)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVALoan.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVALoans");


					// Send the collection and data to the object factory
					CreateObjectsFromData(fHAVALoans, datareader);


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
		/// Fill method for populating a collection by GovernmentRefinanceType
		/// </summary>
		public void FillByGovernmentRefinanceType(FHAVALoans fHAVALoans, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVALoan.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHAVALoan.GetConnectionString(), "gsp_SelectFHAVALoansByGovernmentRefinanceType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@governmentRefinanceType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVALoansByGovernmentRefinanceType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHAVALoans, datareader);


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
		/// Fill method for populating a collection by GOVERNMENT_LOAN
		/// </summary>
		public void FillByGovernmentLoan(FHAVALoans fHAVALoans, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVALoan.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHAVALoan.GetConnectionString(), "gsp_SelectFHAVALoansByGovernmentLoan");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVALoansByGovernmentLoan", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHAVALoans, datareader);


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
		public virtual void CreateObjectsFromData(FHAVALoans fhavaloans, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			FHAVALoan newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(fhavaloans.ContainsType[0]) as FHAVALoan;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				fhavaloans.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(FHAVALoans fhavaloans, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			FHAVALoan newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(fhavaloans.ContainsType[0]) as FHAVALoan;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				fhavaloans.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual FHAVALoans GetAll()
		{
			// create a new instance of the return object
			FHAVALoans objects = new FHAVALoans();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
