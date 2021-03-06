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
	/// A base class service object for table 'PARSED_STREET_ADDRESS'
	/// </summary>
	internal class ParsedStreetAddressServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ParsedStreetAddressServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(ParsedStreetAddress persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(ParsedStreetAddress persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(ParsedStreetAddress.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(ParsedStreetAddress.GetConnectionString(), "gsp_UpdateParsedStreetAddress");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(ParsedStreetAddress.GetConnectionString(), "gsp_CreateParsedStreetAddress");


				// Store the parameter for the ApartmentOrUnit attribute.
				if (!persistObject.ApartmentOrUnitIsNull)
					sqlparams["@apartmentOrUnit"].Value = persistObject.ApartmentOrUnit;
				// Store the parameter for the DirectionPrefix attribute.
				if (!persistObject.DirectionPrefixIsNull)
					sqlparams["@directionPrefix"].Value = persistObject.DirectionPrefix;
				// Store the parameter for the DirectionSuffix attribute.
				if (!persistObject.DirectionSuffixIsNull)
					sqlparams["@directionSuffix"].Value = persistObject.DirectionSuffix;
				// Store the parameter for the BuildingNumber attribute.
				if (!persistObject.BuildingNumberIsNull)
					sqlparams["@buildingNumber"].Value = persistObject.BuildingNumber;
				// Store the parameter for the HouseNumber attribute.
				if (!persistObject.HouseNumberIsNull)
					sqlparams["@houseNumber"].Value = persistObject.HouseNumber;
				// Store the parameter for the Military_APO_FPO attribute.
				if (!persistObject.Military_APO_FPOIsNull)
					sqlparams["@military_APO_FPO"].Value = persistObject.Military_APO_FPO;
				// Store the parameter for the PostOfficeBox attribute.
				if (!persistObject.PostOfficeBoxIsNull)
					sqlparams["@postOfficeBox"].Value = persistObject.PostOfficeBox;
				// Store the parameter for the RuralRoute attribute.
				if (!persistObject.RuralRouteIsNull)
					sqlparams["@ruralRoute"].Value = persistObject.RuralRoute;
				// Store the parameter for the StreetName attribute.
				if (!persistObject.StreetNameIsNull)
					sqlparams["@streetName"].Value = persistObject.StreetName;
				// Store the parameter for the StreetSuffix attribute.
				if (!persistObject.StreetSuffixIsNull)
					sqlparams["@streetSuffix"].Value = persistObject.StreetSuffix;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateParsedStreetAddress", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateParsedStreetAddress", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateParsedStreetAddress", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateParsedStreetAddress", sqlparams);
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
		public virtual void Delete(ParsedStreetAddress deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(ParsedStreetAddress.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(ParsedStreetAddress.GetConnectionString(), "gsp_DeleteParsedStreetAddress");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteParsedStreetAddress", sqlparams);


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
		public virtual void Fill(ParsedStreetAddress parsedstreetaddress, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ParsedStreetAddress.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ParsedStreetAddress.GetConnectionString(), "gsp_SelectParsedStreetAddress");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectParsedStreetAddress", sqlparams);


					if (datareader.Read())
						parsedstreetaddress.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of ParsedStreetAddresses
		/// </summary>
		public virtual void Fill(ParsedStreetAddresses parsedStreetAddresses)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ParsedStreetAddress.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectParsedStreetAddresses");


					// Send the collection and data to the object factory
					CreateObjectsFromData(parsedStreetAddresses, datareader);


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
		/// Fill method for populating a collection by PROPERTY
		/// </summary>
		public void FillByProperty(ParsedStreetAddresses parsedStreetAddresses, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(ParsedStreetAddress.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(ParsedStreetAddress.GetConnectionString(), "gsp_SelectParsedStreetAddressesByProperty");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectParsedStreetAddressesByProperty", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(parsedStreetAddresses, datareader);


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
		public virtual void CreateObjectsFromData(ParsedStreetAddresses parsedstreetaddresses, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			ParsedStreetAddress newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(parsedstreetaddresses.ContainsType[0]) as ParsedStreetAddress;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				parsedstreetaddresses.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(ParsedStreetAddresses parsedstreetaddresses, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			ParsedStreetAddress newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(parsedstreetaddresses.ContainsType[0]) as ParsedStreetAddress;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				parsedstreetaddresses.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual ParsedStreetAddresses GetAll()
		{
			// create a new instance of the return object
			ParsedStreetAddresses objects = new ParsedStreetAddresses();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
