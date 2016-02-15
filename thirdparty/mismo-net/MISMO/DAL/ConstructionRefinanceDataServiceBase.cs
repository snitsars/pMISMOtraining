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
	/// A base class service object for table 'CONSTRUCTION_REFINANCE_DATA'
	/// </summary>
	internal class ConstructionRefinanceDataServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ConstructionRefinanceDataServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(ConstructionRefinanceData persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(ConstructionRefinanceData persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_UpdateConstructionRefinanceData");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_CreateConstructionRefinanceData");


				// Store the parameter for the ConstructionImprovementCostsAmount attribute.
				if (!persistObject.ConstructionImprovementCostsAmountIsNull)
					sqlparams["@constructionImprovementCostsAmount"].Value = persistObject.ConstructionImprovementCostsAmount;
				// Store the parameter for the FRECashOutAmount attribute.
				if (!persistObject.FRECashOutAmountIsNull)
					sqlparams["@fRECashOutAmount"].Value = persistObject.FRECashOutAmount;
				// Store the parameter for the LandEstimatedValueAmount attribute.
				if (!persistObject.LandEstimatedValueAmountIsNull)
					sqlparams["@landEstimatedValueAmount"].Value = persistObject.LandEstimatedValueAmount;
				// Store the parameter for the LandOriginalCostAmount attribute.
				if (!persistObject.LandOriginalCostAmountIsNull)
					sqlparams["@landOriginalCostAmount"].Value = persistObject.LandOriginalCostAmount;
				// Store the parameter for the PropertyAcquiredYear attribute.
				if (!persistObject.PropertyAcquiredYearIsNull)
					sqlparams["@propertyAcquiredYear"].Value = persistObject.PropertyAcquiredYear;
				// Store the parameter for the PropertyExistingLienAmount attribute.
				if (!persistObject.PropertyExistingLienAmountIsNull)
					sqlparams["@propertyExistingLienAmount"].Value = persistObject.PropertyExistingLienAmount;
				// Store the parameter for the PropertyOriginalCostAmount attribute.
				if (!persistObject.PropertyOriginalCostAmountIsNull)
					sqlparams["@propertyOriginalCostAmount"].Value = persistObject.PropertyOriginalCostAmount;
				// Store the parameter for the RefinanceImprovementCostsAmount attribute.
				if (!persistObject.RefinanceImprovementCostsAmountIsNull)
					sqlparams["@refinanceImprovementCostsAmount"].Value = persistObject.RefinanceImprovementCostsAmount;
				// Store the parameter for the RefinanceProposedImprovementsDescription attribute.
				if (!persistObject.RefinanceProposedImprovementsDescriptionIsNull)
					sqlparams["@refinanceProposedImprovementsDescription"].Value = persistObject.RefinanceProposedImprovementsDescription;
				// Store the parameter for the SecondaryFinancingRefinanceIndicator attribute.
				sqlparams["@secondaryFinancingRefinanceIndicator"].Value = persistObject.SecondaryFinancingRefinanceIndicator;
				// Store the parameter for the FNMSecondMortgageFinancingOriginalPropertyIndicator attribute.
				sqlparams["@fNMSecondMortgageFinancingOriginalPropertyIndicator"].Value = persistObject.FNMSecondMortgageFinancingOriginalPropertyIndicator;
				// Store the parameter for the StructuralAlterationsConventionalAmount attribute.
				if (!persistObject.StructuralAlterationsConventionalAmountIsNull)
					sqlparams["@structuralAlterationsConventionalAmount"].Value = persistObject.StructuralAlterationsConventionalAmount;
				// Store the parameter for the NonStructuralAlterationsConventionalAmount attribute.
				if (!persistObject.NonStructuralAlterationsConventionalAmountIsNull)
					sqlparams["@nonStructuralAlterationsConventionalAmount"].Value = persistObject.NonStructuralAlterationsConventionalAmount;
				// Store the parameter for the ConstructionPurposeType attribute.
				if (!persistObject.ConstructionPurposeTypeIsNull)
					sqlparams["@constructionPurposeType"].Value = persistObject.ConstructionPurposeType;
				// Store the parameter for the RefinanceImprovementsType attribute.
				if (!persistObject.RefinanceImprovementsTypeIsNull)
					sqlparams["@refinanceImprovementsType"].Value = persistObject.RefinanceImprovementsType;
				// Store the parameter for the GSERefinancePurposeType attribute.
				if (!persistObject.GSERefinancePurposeTypeIsNull)
					sqlparams["@gSERefinancePurposeType"].Value = persistObject.GSERefinancePurposeType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateConstructionRefinanceData", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateConstructionRefinanceData", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateConstructionRefinanceData", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateConstructionRefinanceData", sqlparams);
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
		public virtual void Delete(ConstructionRefinanceData deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_DeleteConstructionRefinanceData");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteConstructionRefinanceData", sqlparams);


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
		public virtual void Fill(ConstructionRefinanceData constructionrefinancedata, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_SelectConstructionRefinanceData");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectConstructionRefinanceData", sqlparams);


					if (datareader.Read())
						constructionrefinancedata.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of ConstructionRefinanceDataCollection
		/// </summary>
		public virtual void Fill(ConstructionRefinanceDataCollection constructionRefinanceDataCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectConstructionRefinanceDataCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(constructionRefinanceDataCollection, datareader);


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
		/// Fill method for populating a collection by ConstructionPurposeType
		/// </summary>
		public void FillByConstructionPurposeType(ConstructionRefinanceDataCollection constructionRefinanceDataCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_SelectConstructionRefinanceDataCollectionByConstructionPurposeType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@constructionPurposeType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectConstructionRefinanceDataCollectionByConstructionPurposeType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(constructionRefinanceDataCollection, datareader);


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
		/// Fill method for populating a collection by GSERefinancePurposeType
		/// </summary>
		public void FillByGSERefinancePurposeType(ConstructionRefinanceDataCollection constructionRefinanceDataCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_SelectConstructionRefinanceDataCollectionByGSERefinancePurposeType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@gSERefinancePurposeType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectConstructionRefinanceDataCollectionByGSERefinancePurposeType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(constructionRefinanceDataCollection, datareader);


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
		/// Fill method for populating a collection by LOAN_PURPOSE
		/// </summary>
		public void FillByLoanPurpose(ConstructionRefinanceDataCollection constructionRefinanceDataCollection, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_SelectConstructionRefinanceDataCollectionByLoanPurpose");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectConstructionRefinanceDataCollectionByLoanPurpose", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(constructionRefinanceDataCollection, datareader);


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
		/// Fill method for populating a collection by RefinanceImprovementsType
		/// </summary>
		public void FillByRefinanceImprovementsType(ConstructionRefinanceDataCollection constructionRefinanceDataCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ConstructionRefinanceData.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ConstructionRefinanceData.GetConnectionString(), "gsp_SelectConstructionRefinanceDataCollectionByRefinanceImprovementsType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@refinanceImprovementsType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectConstructionRefinanceDataCollectionByRefinanceImprovementsType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(constructionRefinanceDataCollection, datareader);


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
		public virtual void CreateObjectsFromData(ConstructionRefinanceDataCollection constructionrefinancedatacollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			ConstructionRefinanceData newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(constructionrefinancedatacollection.ContainsType[0]) as ConstructionRefinanceData;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				constructionrefinancedatacollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(ConstructionRefinanceDataCollection constructionrefinancedatacollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			ConstructionRefinanceData newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(constructionrefinancedatacollection.ContainsType[0]) as ConstructionRefinanceData;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				constructionrefinancedatacollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual ConstructionRefinanceDataCollection GetAll()
		{
			// create a new instance of the return object
			ConstructionRefinanceDataCollection objects = new ConstructionRefinanceDataCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
