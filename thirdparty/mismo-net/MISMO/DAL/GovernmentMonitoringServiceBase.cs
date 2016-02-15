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
	/// A base class service object for table 'GOVERNMENT_MONITORING'
	/// </summary>
	internal class GovernmentMonitoringServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentMonitoringServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(GovernmentMonitoring persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(GovernmentMonitoring persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_UpdateGovernmentMonitoring");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_CreateGovernmentMonitoring");


				// Store the parameter for the GenderType attribute.
				if (!persistObject.GenderTypeIsNull)
					sqlparams["@genderType"].Value = persistObject.GenderType;
				// Store the parameter for the OtherRaceNationalOriginDescription attribute.
				if (!persistObject.OtherRaceNationalOriginDescriptionIsNull)
					sqlparams["@otherRaceNationalOriginDescription"].Value = persistObject.OtherRaceNationalOriginDescription;
				// Store the parameter for the RaceNationalOriginRefusalIndicator attribute.
				sqlparams["@raceNationalOriginRefusalIndicator"].Value = persistObject.RaceNationalOriginRefusalIndicator;
				// Store the parameter for the RaceNationalOriginType attribute.
				if (!persistObject.RaceNationalOriginTypeIsNull)
					sqlparams["@raceNationalOriginType"].Value = persistObject.RaceNationalOriginType;
				// Store the parameter for the HMDAEthnicityType attribute.
				if (!persistObject.HMDAEthnicityTypeIsNull)
					sqlparams["@hMDAEthnicityType"].Value = persistObject.HMDAEthnicityType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateGovernmentMonitoring", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateGovernmentMonitoring", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateGovernmentMonitoring", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateGovernmentMonitoring", sqlparams);
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
		public virtual void Delete(GovernmentMonitoring deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_DeleteGovernmentMonitoring");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = deleteObject.BorrowerId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteGovernmentMonitoring", sqlparams);


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
		public virtual void Fill(GovernmentMonitoring governmentmonitoring, System.Int64 borrowerId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_SelectGovernmentMonitoring");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = borrowerId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectGovernmentMonitoring", sqlparams);


					if (datareader.Read())
						governmentmonitoring.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of GovernmentMonitoringCollection
		/// </summary>
		public virtual void Fill(GovernmentMonitoringCollection governmentMonitoringCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectGovernmentMonitoringCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(governmentMonitoringCollection, datareader);


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
		public void FillByBorrower(GovernmentMonitoringCollection governmentMonitoringCollection, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_SelectGovernmentMonitoringCollectionByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectGovernmentMonitoringCollectionByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(governmentMonitoringCollection, datareader);


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
		/// Fill method for populating a collection by GenderType
		/// </summary>
		public void FillByGenderType(GovernmentMonitoringCollection governmentMonitoringCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_SelectGovernmentMonitoringCollectionByGenderType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@genderType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectGovernmentMonitoringCollectionByGenderType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(governmentMonitoringCollection, datareader);


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
		/// Fill method for populating a collection by HMDAEthnicityType
		/// </summary>
		public void FillByHMDAEthnicityType(GovernmentMonitoringCollection governmentMonitoringCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_SelectGovernmentMonitoringCollectionByHMDAEthnicityType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@hMDAEthnicityType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectGovernmentMonitoringCollectionByHMDAEthnicityType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(governmentMonitoringCollection, datareader);


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
		/// Fill method for populating a collection by RaceNationalOriginType
		/// </summary>
		public void FillByRaceNationalOriginType(GovernmentMonitoringCollection governmentMonitoringCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(GovernmentMonitoring.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(GovernmentMonitoring.GetConnectionString(), "gsp_SelectGovernmentMonitoringCollectionByRaceNationalOriginType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@raceNationalOriginType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectGovernmentMonitoringCollectionByRaceNationalOriginType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(governmentMonitoringCollection, datareader);


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
		public virtual void CreateObjectsFromData(GovernmentMonitoringCollection governmentmonitoringcollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			GovernmentMonitoring newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(governmentmonitoringcollection.ContainsType[0]) as GovernmentMonitoring;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				governmentmonitoringcollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(GovernmentMonitoringCollection governmentmonitoringcollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			GovernmentMonitoring newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(governmentmonitoringcollection.ContainsType[0]) as GovernmentMonitoring;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				governmentmonitoringcollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual GovernmentMonitoringCollection GetAll()
		{
			// create a new instance of the return object
			GovernmentMonitoringCollection objects = new GovernmentMonitoringCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
