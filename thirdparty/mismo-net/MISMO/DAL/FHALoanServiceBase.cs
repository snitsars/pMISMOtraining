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
	/// A base class service object for table 'FHA_LOAN'
	/// </summary>
	internal class FHALoanServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHALoanServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(FHALoan persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(FHALoan persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(FHALoan.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_UpdateFHALoan");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_CreateFHALoan");


				// Store the parameter for the BorrowerFinancedFHADiscountPointsAmount attribute.
				if (!persistObject.BorrowerFinancedFHADiscountPointsAmountIsNull)
					sqlparams["@borrowerFinancedFHADiscountPointsAmount"].Value = persistObject.BorrowerFinancedFHADiscountPointsAmount;
				// Store the parameter for the FHACoverageRenewalRatePercent attribute.
				if (!persistObject.FHACoverageRenewalRatePercentIsNull)
					sqlparams["@fHACoverageRenewalRatePercent"].Value = persistObject.FHACoverageRenewalRatePercent;
				// Store the parameter for the FHA_MIPremiumRefundAmount attribute.
				if (!persistObject.FHA_MIPremiumRefundAmountIsNull)
					sqlparams["@fHA_MIPremiumRefundAmount"].Value = persistObject.FHA_MIPremiumRefundAmount;
				// Store the parameter for the FHAUpfrontMIPremiumPercent attribute.
				if (!persistObject.FHAUpfrontMIPremiumPercentIsNull)
					sqlparams["@fHAUpfrontMIPremiumPercent"].Value = persistObject.FHAUpfrontMIPremiumPercent;
				// Store the parameter for the LenderIdentifier attribute.
				if (!persistObject.LenderIdentifierIsNull)
					sqlparams["@lenderIdentifier"].Value = persistObject.LenderIdentifier;
				// Store the parameter for the SponsorIdentifier attribute.
				if (!persistObject.SponsorIdentifierIsNull)
					sqlparams["@sponsorIdentifier"].Value = persistObject.SponsorIdentifier;
				// Store the parameter for the SectionOfActType attribute.
				if (!persistObject.SectionOfActTypeIsNull)
					sqlparams["@sectionOfActType"].Value = persistObject.SectionOfActType;
				// Store the parameter for the FHAAlimonyLiabilityTreatmentType2 attribute.
				if (!persistObject.FHAAlimonyLiabilityTreatmentType2IsNull)
					sqlparams["@fHAAlimonyLiabilityTreatmentType2"].Value = persistObject.FHAAlimonyLiabilityTreatmentType2;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateFHALoan", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateFHALoan", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateFHALoan", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateFHALoan", sqlparams);
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
		public virtual void Delete(FHALoan deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(FHALoan.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_DeleteFHALoan");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteFHALoan", sqlparams);


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
		public virtual void Fill(FHALoan fhaloan, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHALoan.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_SelectFHALoan");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHALoan", sqlparams);


					if (datareader.Read())
						fhaloan.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of FHALoans
		/// </summary>
		public virtual void Fill(FHALoans fHALoans)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHALoan.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHALoans");


					// Send the collection and data to the object factory
					CreateObjectsFromData(fHALoans, datareader);


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
		/// Fill method for populating a collection by FHAAlimonyLiabilityTreatmentType
		/// </summary>
		public void FillByFHAAlimonyLiabilityTreatmentType(FHALoans fHALoans, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHALoan.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_SelectFHALoansByFHAAlimonyLiabilityTreatmentType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@fHAAlimonyLiabilityTreatmentType2"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHALoansByFHAAlimonyLiabilityTreatmentType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHALoans, datareader);


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
		public void FillByGovernmentLoan(FHALoans fHALoans, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHALoan.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_SelectFHALoansByGovernmentLoan");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHALoansByGovernmentLoan", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHALoans, datareader);


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
		/// Fill method for populating a collection by NationalHousingActSectionType
		/// </summary>
		public void FillByNationalHousingActSectionType(FHALoans fHALoans, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHALoan.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHALoan.GetConnectionString(), "gsp_SelectFHALoansByNationalHousingActSectionType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@sectionOfActType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHALoansByNationalHousingActSectionType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHALoans, datareader);


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
		public virtual void CreateObjectsFromData(FHALoans fhaloans, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			FHALoan newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(fhaloans.ContainsType[0]) as FHALoan;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				fhaloans.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(FHALoans fhaloans, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			FHALoan newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(fhaloans.ContainsType[0]) as FHALoan;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				fhaloans.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual FHALoans GetAll()
		{
			// create a new instance of the return object
			FHALoans objects = new FHALoans();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
