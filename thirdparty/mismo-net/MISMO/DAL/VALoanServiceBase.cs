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
	/// A base class service object for table 'VA_LOAN'
	/// </summary>
	internal class VALoanServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VALoanServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(VALoan persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(VALoan persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(VALoan.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(VALoan.GetConnectionString(), "gsp_UpdateVALoan");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(VALoan.GetConnectionString(), "gsp_CreateVALoan");


				// Store the parameter for the VABorrowerCoBorrowerMarriedIndicator attribute.
				sqlparams["@vABorrowerCoBorrowerMarriedIndicator"].Value = persistObject.VABorrowerCoBorrowerMarriedIndicator;
				// Store the parameter for the BorrowerFundingFeePercent attribute.
				if (!persistObject.BorrowerFundingFeePercentIsNull)
					sqlparams["@borrowerFundingFeePercent"].Value = persistObject.BorrowerFundingFeePercent;
				// Store the parameter for the VAEntitlementAmount attribute.
				if (!persistObject.VAEntitlementAmountIsNull)
					sqlparams["@vAEntitlementAmount"].Value = persistObject.VAEntitlementAmount;
				// Store the parameter for the VAMaintenanceExpenseMonthlyAmount attribute.
				if (!persistObject.VAMaintenanceExpenseMonthlyAmountIsNull)
					sqlparams["@vAMaintenanceExpenseMonthlyAmount"].Value = persistObject.VAMaintenanceExpenseMonthlyAmount;
				// Store the parameter for the VAResidualIncomeAmount attribute.
				if (!persistObject.VAResidualIncomeAmountIsNull)
					sqlparams["@vAResidualIncomeAmount"].Value = persistObject.VAResidualIncomeAmount;
				// Store the parameter for the VAUtilityExpenseMonthlyAmount attribute.
				if (!persistObject.VAUtilityExpenseMonthlyAmountIsNull)
					sqlparams["@vAUtilityExpenseMonthlyAmount"].Value = persistObject.VAUtilityExpenseMonthlyAmount;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateVALoan", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateVALoan", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateVALoan", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateVALoan", sqlparams);
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
		public virtual void Delete(VALoan deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(VALoan.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(VALoan.GetConnectionString(), "gsp_DeleteVALoan");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteVALoan", sqlparams);


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
		public virtual void Fill(VALoan valoan, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(VALoan.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(VALoan.GetConnectionString(), "gsp_SelectVALoan");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectVALoan", sqlparams);


					if (datareader.Read())
						valoan.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of VALoans
		/// </summary>
		public virtual void Fill(VALoans vALoans)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(VALoan.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectVALoans");


					// Send the collection and data to the object factory
					CreateObjectsFromData(vALoans, datareader);


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
		public void FillByGovernmentLoan(VALoans vALoans, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(VALoan.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(VALoan.GetConnectionString(), "gsp_SelectVALoansByGovernmentLoan");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectVALoansByGovernmentLoan", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(vALoans, datareader);


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
		public virtual void CreateObjectsFromData(VALoans valoans, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			VALoan newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(valoans.ContainsType[0]) as VALoan;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				valoans.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(VALoans valoans, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			VALoan newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(valoans.ContainsType[0]) as VALoan;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				valoans.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual VALoans GetAll()
		{
			// create a new instance of the return object
			VALoans objects = new VALoans();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}