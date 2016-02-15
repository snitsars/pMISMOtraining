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
	/// A base class service object for table 'PROPERTY'
	/// </summary>
	internal class PropertyServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PropertyServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Property persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Property persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(Property.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_UpdateProperty");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_CreateProperty");


				// Store the parameter for the StreetAddress attribute.
				if (!persistObject.StreetAddressIsNull)
					sqlparams["@streetAddress"].Value = persistObject.StreetAddress;
				// Store the parameter for the StreetAddress2 attribute.
				if (!persistObject.StreetAddress2IsNull)
					sqlparams["@streetAddress2"].Value = persistObject.StreetAddress2;
				// Store the parameter for the City attribute.
				if (!persistObject.CityIsNull)
					sqlparams["@city"].Value = persistObject.City;
				// Store the parameter for the State attribute.
				if (!persistObject.StateIsNull)
					sqlparams["@state"].Value = persistObject.State;
				// Store the parameter for the County attribute.
				if (!persistObject.CountyIsNull)
					sqlparams["@county"].Value = persistObject.County;
				// Store the parameter for the PostalCode attribute.
				if (!persistObject.PostalCodeIsNull)
					sqlparams["@postalCode"].Value = persistObject.PostalCode;
				// Store the parameter for the FinancedNumberOfUnits attribute.
				if (!persistObject.FinancedNumberOfUnitsIsNull)
					sqlparams["@financedNumberOfUnits"].Value = persistObject.FinancedNumberOfUnits;
				// Store the parameter for the StructureBuiltYear attribute.
				if (!persistObject.StructureBuiltYearIsNull)
					sqlparams["@structureBuiltYear"].Value = persistObject.StructureBuiltYear;
				// Store the parameter for the AcquiredDate attribute.
				if (!persistObject.AcquiredDateIsNull)
					sqlparams["@acquiredDate"].Value = persistObject.AcquiredDate;
				// Store the parameter for the PlannedUnitDevelopmentIndicator attribute.
				sqlparams["@plannedUnitDevelopmentIndicator"].Value = persistObject.PlannedUnitDevelopmentIndicator;
				// Store the parameter for the AcreageNumber attribute.
				if (!persistObject.AcreageNumberIsNull)
					sqlparams["@acreageNumber"].Value = persistObject.AcreageNumber;
				// Store the parameter for the BuildingStatusType attribute.
				if (!persistObject.BuildingStatusTypeIsNull)
					sqlparams["@buildingStatusType"].Value = persistObject.BuildingStatusType;
				// Store the parameter for the GSEPropertyType attribute.
				if (!persistObject.GSEPropertyTypeIsNull)
					sqlparams["@gSEPropertyType"].Value = persistObject.GSEPropertyType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateProperty", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateProperty", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateProperty", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateProperty", sqlparams);
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
		public virtual void Delete(Property deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(Property.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_DeleteProperty");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteProperty", sqlparams);


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
		public virtual void Fill(Property property, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Property.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_SelectProperty");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectProperty", sqlparams);


					if (datareader.Read())
						property.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of Properties
		/// </summary>
		public virtual void Fill(Properties properties)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Property.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectProperties");


					// Send the collection and data to the object factory
					CreateObjectsFromData(properties, datareader);


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
		/// Fill method for populating a collection by BuildingStatusType
		/// </summary>
		public void FillByBuildingStatusType(Properties properties, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Property.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_SelectPropertiesByBuildingStatusType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@buildingStatusType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPropertiesByBuildingStatusType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(properties, datareader);


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
		/// Fill method for populating a collection by GSEPropertyType
		/// </summary>
		public void FillByGSEPropertyType(Properties properties, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Property.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_SelectPropertiesByGSEPropertyType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@gSEPropertyType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPropertiesByGSEPropertyType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(properties, datareader);


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
		public void FillByLoanApplication(Properties properties, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Property.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Property.GetConnectionString(), "gsp_SelectPropertiesByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPropertiesByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(properties, datareader);


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
		public virtual void CreateObjectsFromData(Properties properties, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			Property newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(properties.ContainsType[0]) as Property;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				properties.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(Properties properties, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			Property newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(properties.ContainsType[0]) as Property;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				properties.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual Properties GetAll()
		{
			// create a new instance of the return object
			Properties objects = new Properties();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
