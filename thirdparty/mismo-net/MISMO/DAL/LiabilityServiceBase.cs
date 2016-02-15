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
	/// A base class service object for table 'LIABILITY'
	/// </summary>
	internal class LiabilityServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LiabilityServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Liability persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Liability persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(Liability.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_UpdateLiability");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_CreateLiability");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = persistObject.LoanApplicationId;
				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = persistObject.BorrowerId;
				// Store the parameter for the REO_ID attribute.
				if (!persistObject.REO_IDIsNull)
					sqlparams["@rEO_ID"].Value = persistObject.REO_ID;
				// Store the parameter for the HolderStreetAddress attribute.
				if (!persistObject.HolderStreetAddressIsNull)
					sqlparams["@holderStreetAddress"].Value = persistObject.HolderStreetAddress;
				// Store the parameter for the HolderCity attribute.
				if (!persistObject.HolderCityIsNull)
					sqlparams["@holderCity"].Value = persistObject.HolderCity;
				// Store the parameter for the HolderState attribute.
				if (!persistObject.HolderStateIsNull)
					sqlparams["@holderState"].Value = persistObject.HolderState;
				// Store the parameter for the HolderPostalCode attribute.
				if (!persistObject.HolderPostalCodeIsNull)
					sqlparams["@holderPostalCode"].Value = persistObject.HolderPostalCode;
				// Store the parameter for the AlimonyOwedToName attribute.
				if (!persistObject.AlimonyOwedToNameIsNull)
					sqlparams["@alimonyOwedToName"].Value = persistObject.AlimonyOwedToName;
				// Store the parameter for the AccountIdentifier attribute.
				if (!persistObject.AccountIdentifierIsNull)
					sqlparams["@accountIdentifier"].Value = persistObject.AccountIdentifier;
				// Store the parameter for the ExclusionIndicator attribute.
				sqlparams["@exclusionIndicator"].Value = persistObject.ExclusionIndicator;
				// Store the parameter for the HolderName attribute.
				if (!persistObject.HolderNameIsNull)
					sqlparams["@holderName"].Value = persistObject.HolderName;
				// Store the parameter for the MonthlyPaymentAmount attribute.
				if (!persistObject.MonthlyPaymentAmountIsNull)
					sqlparams["@monthlyPaymentAmount"].Value = persistObject.MonthlyPaymentAmount;
				// Store the parameter for the PayoffStatusIndicator attribute.
				sqlparams["@payoffStatusIndicator"].Value = persistObject.PayoffStatusIndicator;
				// Store the parameter for the PayoffWithCurrentAssetsIndicator attribute.
				sqlparams["@payoffWithCurrentAssetsIndicator"].Value = persistObject.PayoffWithCurrentAssetsIndicator;
				// Store the parameter for the RemainingTermMonths attribute.
				if (!persistObject.RemainingTermMonthsIsNull)
					sqlparams["@remainingTermMonths"].Value = persistObject.RemainingTermMonths;
				// Store the parameter for the Type attribute.
				sqlparams["@type"].Value = persistObject.Type;
				// Store the parameter for the UnpaidBalanceAmount attribute.
				if (!persistObject.UnpaidBalanceAmountIsNull)
					sqlparams["@unpaidBalanceAmount"].Value = persistObject.UnpaidBalanceAmount;
				// Store the parameter for the SubjectLoanResubordinationIndicator attribute.
				sqlparams["@subjectLoanResubordinationIndicator"].Value = persistObject.SubjectLoanResubordinationIndicator;
				// Store the parameter for the Id attribute.
				if (!persistObject.Persisted)
				{
					// store the create only (historical fixed) values
				}
				else
				{
					// store the update only (historical changeable) values
					// Store the parameter for the Id attribute.
					sqlparams["@id"].Value = persistObject.Id;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreateLiability", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateLiability", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreateLiability", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateLiability", sqlparams);
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
		public virtual void Delete(Liability deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(Liability.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_DeleteLiability");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteLiability", sqlparams);


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
		public virtual void Fill(Liability liability, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Liability.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_SelectLiability");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLiability", sqlparams);


					if (datareader.Read())
						liability.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of Liabilities
		/// </summary>
		public virtual void Fill(Liabilities liabilities)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Liability.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLiabilities");


					// Send the collection and data to the object factory
					CreateObjectsFromData(liabilities, datareader);


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
		/// Fill method for populating a collection by BORROWER
		/// </summary>
		public void FillByBorrower(Liabilities liabilities, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Liability.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_SelectLiabilitiesByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLiabilitiesByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(liabilities, datareader);


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
		public void FillByLoanApplication(Liabilities liabilities, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Liability.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_SelectLiabilitiesByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLiabilitiesByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(liabilities, datareader);


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
		/// Fill method for populating a collection by LiabilityType
		/// </summary>
		public void FillByLiabilityType(Liabilities liabilities, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Liability.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Liability.GetConnectionString(), "gsp_SelectLiabilitiesByLiabilityType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@type"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectLiabilitiesByLiabilityType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(liabilities, datareader);


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
		public virtual void CreateObjectsFromData(Liabilities liabilities, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			Liability newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(liabilities.ContainsType[0]) as Liability;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				liabilities.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(Liabilities liabilities, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			Liability newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(liabilities.ContainsType[0]) as Liability;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				liabilities.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual Liabilities GetAll()
		{
			// create a new instance of the return object
			Liabilities objects = new Liabilities();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
