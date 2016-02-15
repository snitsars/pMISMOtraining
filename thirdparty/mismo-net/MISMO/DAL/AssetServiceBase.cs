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
	/// A base class service object for table 'ASSET'
	/// </summary>
	internal class AssetServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AssetServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Asset persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Asset persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(Asset.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_UpdateAsset");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_CreateAsset");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = persistObject.BorrowerId;
				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = persistObject.LoanApplicationId;
				// Store the parameter for the AccountIdentifier attribute.
				if (!persistObject.AccountIdentifierIsNull)
					sqlparams["@accountIdentifier"].Value = persistObject.AccountIdentifier;
				// Store the parameter for the CashOrMarketValueAmount attribute.
				if (!persistObject.CashOrMarketValueAmountIsNull)
					sqlparams["@cashOrMarketValueAmount"].Value = persistObject.CashOrMarketValueAmount;
				// Store the parameter for the Type attribute.
				sqlparams["@type"].Value = persistObject.Type;
				// Store the parameter for the VerifiedIndicator attribute.
				sqlparams["@verifiedIndicator"].Value = persistObject.VerifiedIndicator;
				// Store the parameter for the HolderName attribute.
				if (!persistObject.HolderNameIsNull)
					sqlparams["@holderName"].Value = persistObject.HolderName;
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
				// Store the parameter for the AutomobileMakeDescription attribute.
				if (!persistObject.AutomobileMakeDescriptionIsNull)
					sqlparams["@automobileMakeDescription"].Value = persistObject.AutomobileMakeDescription;
				// Store the parameter for the AutomobileModelYear attribute.
				if (!persistObject.AutomobileModelYearIsNull)
					sqlparams["@automobileModelYear"].Value = persistObject.AutomobileModelYear;
				// Store the parameter for the LifeInsuranceFaceValueAmount attribute.
				if (!persistObject.LifeInsuranceFaceValueAmountIsNull)
					sqlparams["@lifeInsuranceFaceValueAmount"].Value = persistObject.LifeInsuranceFaceValueAmount;
				// Store the parameter for the OtherAssetTypeDescription attribute.
				if (!persistObject.OtherAssetTypeDescriptionIsNull)
					sqlparams["@otherAssetTypeDescription"].Value = persistObject.OtherAssetTypeDescription;
				// Store the parameter for the StockBondMutualFundShareCount attribute.
				if (!persistObject.StockBondMutualFundShareCountIsNull)
					sqlparams["@stockBondMutualFundShareCount"].Value = persistObject.StockBondMutualFundShareCount;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreateAsset", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateAsset", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreateAsset", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateAsset", sqlparams);
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
		public virtual void Delete(Asset deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(Asset.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_DeleteAsset");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteAsset", sqlparams);


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
		public virtual void Fill(Asset asset, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Asset.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_SelectAsset");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAsset", sqlparams);


					if (datareader.Read())
						asset.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of Assets
		/// </summary>
		public virtual void Fill(Assets assets)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Asset.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAssets");


					// Send the collection and data to the object factory
					CreateObjectsFromData(assets, datareader);


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
		public void FillByBorrower(Assets assets, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Asset.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_SelectAssetsByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAssetsByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(assets, datareader);


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
		public void FillByLoanApplication(Assets assets, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Asset.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_SelectAssetsByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAssetsByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(assets, datareader);


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
		/// Fill method for populating a collection by AssetType
		/// </summary>
		public void FillByAssetType(Assets assets, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Asset.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Asset.GetConnectionString(), "gsp_SelectAssetsByAssetType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@type"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectAssetsByAssetType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(assets, datareader);


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
		public virtual void CreateObjectsFromData(Assets assets, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			Asset newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(assets.ContainsType[0]) as Asset;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				assets.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(Assets assets, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			Asset newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(assets.ContainsType[0]) as Asset;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				assets.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual Assets GetAll()
		{
			// create a new instance of the return object
			Assets objects = new Assets();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
