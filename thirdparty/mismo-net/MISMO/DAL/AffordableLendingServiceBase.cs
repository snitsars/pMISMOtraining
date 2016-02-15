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
	/// A base class service object for table 'AFFORDABLE_LENDING'
	/// </summary>
	internal class AffordableLendingServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AffordableLendingServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(AffordableLending persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(AffordableLending persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(AffordableLending.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(AffordableLending.GetConnectionString(), "gsp_UpdateAffordableLending");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(AffordableLending.GetConnectionString(), "gsp_CreateAffordableLending");


				// Store the parameter for the FNMCommunityLendingProductName attribute.
				if (!persistObject.FNMCommunityLendingProductNameIsNull)
					sqlparams["@fNMCommunityLendingProductName"].Value = persistObject.FNMCommunityLendingProductName;
				// Store the parameter for the FNMCommunityLendingProductTypeOtherDescription attribute.
				if (!persistObject.FNMCommunityLendingProductTypeOtherDescriptionIsNull)
					sqlparams["@fNMCommunityLendingProductTypeOtherDescription"].Value = persistObject.FNMCommunityLendingProductTypeOtherDescription;
				// Store the parameter for the FNMCommunitySecondsIndicator attribute.
				sqlparams["@fNMCommunitySecondsIndicator"].Value = persistObject.FNMCommunitySecondsIndicator;
				// Store the parameter for the FNMNeighborsMortgageEligibilityIndicator attribute.
				sqlparams["@fNMNeighborsMortgageEligibilityIndicator"].Value = persistObject.FNMNeighborsMortgageEligibilityIndicator;
				// Store the parameter for the FREAffordableProgramIdentifier attribute.
				if (!persistObject.FREAffordableProgramIdentifierIsNull)
					sqlparams["@fREAffordableProgramIdentifier"].Value = persistObject.FREAffordableProgramIdentifier;
				// Store the parameter for the HUDIncomeLimitAdjustmentFactor attribute.
				if (!persistObject.HUDIncomeLimitAdjustmentFactorIsNull)
					sqlparams["@hUDIncomeLimitAdjustmentFactor"].Value = persistObject.HUDIncomeLimitAdjustmentFactor;
				// Store the parameter for the HUDLendingIncomeLimitAmount attribute.
				if (!persistObject.HUDLendingIncomeLimitAmountIsNull)
					sqlparams["@hUDLendingIncomeLimitAmount"].Value = persistObject.HUDLendingIncomeLimitAmount;
				// Store the parameter for the HUDMedianIncomeAmount attribute.
				if (!persistObject.HUDMedianIncomeAmountIsNull)
					sqlparams["@hUDMedianIncomeAmount"].Value = persistObject.HUDMedianIncomeAmount;
				// Store the parameter for the MSAIdentifier attribute.
				if (!persistObject.MSAIdentifierIsNull)
					sqlparams["@mSAIdentifier"].Value = persistObject.MSAIdentifier;
				// Store the parameter for the FNMCommunityLendingProductType attribute.
				if (!persistObject.FNMCommunityLendingProductTypeIsNull)
					sqlparams["@fNMCommunityLendingProductType"].Value = persistObject.FNMCommunityLendingProductType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateAffordableLending", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateAffordableLending", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateAffordableLending", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateAffordableLending", sqlparams);
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
		public virtual void Delete(AffordableLending deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(AffordableLending.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(AffordableLending.GetConnectionString(), "gsp_DeleteAffordableLending");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteAffordableLending", sqlparams);


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
		public virtual void Fill(AffordableLending affordablelending, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(AffordableLending.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(AffordableLending.GetConnectionString(), "gsp_SelectAffordableLending");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAffordableLending", sqlparams);


					if (datareader.Read())
						affordablelending.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of AffordableLendingCollection
		/// </summary>
		public virtual void Fill(AffordableLendingCollection affordableLendingCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(AffordableLending.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAffordableLendingCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(affordableLendingCollection, datareader);


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
		/// Fill method for populating a collection by FNMCommunityLendingProductType
		/// </summary>
		public void FillByFNMCommunityLendingProductType(AffordableLendingCollection affordableLendingCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(AffordableLending.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(AffordableLending.GetConnectionString(), "gsp_SelectAffordableLendingCollectionByFNMCommunityLendingProductType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@fNMCommunityLendingProductType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAffordableLendingCollectionByFNMCommunityLendingProductType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(affordableLendingCollection, datareader);


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
		public void FillByLoanApplication(AffordableLendingCollection affordableLendingCollection, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(AffordableLending.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(AffordableLending.GetConnectionString(), "gsp_SelectAffordableLendingCollectionByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAffordableLendingCollectionByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(affordableLendingCollection, datareader);


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
		public virtual void CreateObjectsFromData(AffordableLendingCollection affordablelendingcollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			AffordableLending newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(affordablelendingcollection.ContainsType[0]) as AffordableLending;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				affordablelendingcollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(AffordableLendingCollection affordablelendingcollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			AffordableLending newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(affordablelendingcollection.ContainsType[0]) as AffordableLending;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				affordablelendingcollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual AffordableLendingCollection GetAll()
		{
			// create a new instance of the return object
			AffordableLendingCollection objects = new AffordableLendingCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
