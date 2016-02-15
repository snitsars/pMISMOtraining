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
	/// A base class service object for table 'FHA_VA_BORROWER'
	/// </summary>
	internal class FHAVABorrowerServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVABorrowerServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(FHAVABorrower persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(FHAVABorrower persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(FHAVABorrower.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHAVABorrower.GetConnectionString(), "gsp_UpdateFHAVABorrower");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHAVABorrower.GetConnectionString(), "gsp_CreateFHAVABorrower");


				// Store the parameter for the CAIVRSIdentifier attribute.
				if (!persistObject.CAIVRSIdentifierIsNull)
					sqlparams["@cAIVRSIdentifier"].Value = persistObject.CAIVRSIdentifier;
				// Store the parameter for the FNMBankruptcyCount attribute.
				if (!persistObject.FNMBankruptcyCountIsNull)
					sqlparams["@fNMBankruptcyCount"].Value = persistObject.FNMBankruptcyCount;
				// Store the parameter for the FNMBorrowerCreditRating attribute.
				if (!persistObject.FNMBorrowerCreditRatingIsNull)
					sqlparams["@fNMBorrowerCreditRating"].Value = persistObject.FNMBorrowerCreditRating;
				// Store the parameter for the FNMCreditReportScoreType attribute.
				if (!persistObject.FNMCreditReportScoreTypeIsNull)
					sqlparams["@fNMCreditReportScoreType"].Value = persistObject.FNMCreditReportScoreType;
				// Store the parameter for the FNMForeclosureCount attribute.
				if (!persistObject.FNMForeclosureCountIsNull)
					sqlparams["@fNMForeclosureCount"].Value = persistObject.FNMForeclosureCount;
				// Store the parameter for the VeteranStatusIndicator attribute.
				sqlparams["@veteranStatusIndicator"].Value = persistObject.VeteranStatusIndicator;
				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = persistObject.BorrowerId;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateFHAVABorrower", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateFHAVABorrower", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateFHAVABorrower", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateFHAVABorrower", sqlparams);
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
		public virtual void Delete(FHAVABorrower deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(FHAVABorrower.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(FHAVABorrower.GetConnectionString(), "gsp_DeleteFHAVABorrower");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = deleteObject.BorrowerId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteFHAVABorrower", sqlparams);


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
		public virtual void Fill(FHAVABorrower fhavaborrower, System.Int64 borrowerId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVABorrower.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHAVABorrower.GetConnectionString(), "gsp_SelectFHAVABorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = borrowerId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVABorrower", sqlparams);


					if (datareader.Read())
						fhavaborrower.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of FHAVABorrowers
		/// </summary>
		public virtual void Fill(FHAVABorrowers fHAVABorrowers)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVABorrower.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVABorrowers");


					// Send the collection and data to the object factory
					CreateObjectsFromData(fHAVABorrowers, datareader);


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
		public void FillByBorrower(FHAVABorrowers fHAVABorrowers, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVABorrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHAVABorrower.GetConnectionString(), "gsp_SelectFHAVABorrowersByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVABorrowersByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHAVABorrowers, datareader);


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
		/// Fill method for populating a collection by FNMCreditReportScoreType
		/// </summary>
		public void FillByFNMCreditReportScoreType(FHAVABorrowers fHAVABorrowers, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(FHAVABorrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(FHAVABorrower.GetConnectionString(), "gsp_SelectFHAVABorrowersByFNMCreditReportScoreType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@fNMCreditReportScoreType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectFHAVABorrowersByFNMCreditReportScoreType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(fHAVABorrowers, datareader);


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
		public virtual void CreateObjectsFromData(FHAVABorrowers fhavaborrowers, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			FHAVABorrower newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(fhavaborrowers.ContainsType[0]) as FHAVABorrower;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				fhavaborrowers.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(FHAVABorrowers fhavaborrowers, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			FHAVABorrower newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(fhavaborrowers.ContainsType[0]) as FHAVABorrower;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				fhavaborrowers.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual FHAVABorrowers GetAll()
		{
			// create a new instance of the return object
			FHAVABorrowers objects = new FHAVABorrowers();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
