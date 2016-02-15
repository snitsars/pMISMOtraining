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
	/// A base class service object for table 'REO_PROPERTY'
	/// </summary>
	internal class REOPropertyServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public REOPropertyServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(REOProperty persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(REOProperty persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_UpdateREOProperty");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_CreateREOProperty");


				// Store the parameter for the LoanApplicationId attribute.
				if (!persistObject.LoanApplicationIdIsNull)
					sqlparams["@loanApplicationId"].Value = persistObject.LoanApplicationId;
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
				// Store the parameter for the PostalCode attribute.
				if (!persistObject.PostalCodeIsNull)
					sqlparams["@postalCode"].Value = persistObject.PostalCode;
				// Store the parameter for the CurrentResidenceIndicator attribute.
				sqlparams["@currentResidenceIndicator"].Value = persistObject.CurrentResidenceIndicator;
				// Store the parameter for the LienInstallmentAmount attribute.
				if (!persistObject.LienInstallmentAmountIsNull)
					sqlparams["@lienInstallmentAmount"].Value = persistObject.LienInstallmentAmount;
				// Store the parameter for the LienUPBAmount attribute.
				if (!persistObject.LienUPBAmountIsNull)
					sqlparams["@lienUPBAmount"].Value = persistObject.LienUPBAmount;
				// Store the parameter for the MaintenanceExpenseAmount attribute.
				if (!persistObject.MaintenanceExpenseAmountIsNull)
					sqlparams["@maintenanceExpenseAmount"].Value = persistObject.MaintenanceExpenseAmount;
				// Store the parameter for the MarketValueAmount attribute.
				if (!persistObject.MarketValueAmountIsNull)
					sqlparams["@marketValueAmount"].Value = persistObject.MarketValueAmount;
				// Store the parameter for the RentalIncomeGrossAmount attribute.
				if (!persistObject.RentalIncomeGrossAmountIsNull)
					sqlparams["@rentalIncomeGrossAmount"].Value = persistObject.RentalIncomeGrossAmount;
				// Store the parameter for the RentalIncomeNetAmount attribute.
				if (!persistObject.RentalIncomeNetAmountIsNull)
					sqlparams["@rentalIncomeNetAmount"].Value = persistObject.RentalIncomeNetAmount;
				// Store the parameter for the SubjectIndicator attribute.
				sqlparams["@subjectIndicator"].Value = persistObject.SubjectIndicator;
				// Store the parameter for the BorrowerID attribute.
				if (!persistObject.BorrowerIDIsNull)
					sqlparams["@borrowerID"].Value = persistObject.BorrowerID;
				// Store the parameter for the LiabilityID attribute.
				if (!persistObject.LiabilityIDIsNull)
					sqlparams["@liabilityID"].Value = persistObject.LiabilityID;
				// Store the parameter for the GSEPropertyType attribute.
				if (!persistObject.GSEPropertyTypeIsNull)
					sqlparams["@gSEPropertyType"].Value = persistObject.GSEPropertyType;
				// Store the parameter for the DispositionStatusType attribute.
				if (!persistObject.DispositionStatusTypeIsNull)
					sqlparams["@dispositionStatusType"].Value = persistObject.DispositionStatusType;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreateREOProperty", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateREOProperty", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreateREOProperty", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateREOProperty", sqlparams);
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
		public virtual void Delete(REOProperty deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_DeleteREOProperty");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteREOProperty", sqlparams);


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
		public virtual void Fill(REOProperty reoproperty, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_SelectREOProperty");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOProperty", sqlparams);


					if (datareader.Read())
						reoproperty.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of REOProperties
		/// </summary>
		public virtual void Fill(REOProperties rEOProperties)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOProperties");


					// Send the collection and data to the object factory
					CreateObjectsFromData(rEOProperties, datareader);


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
		public void FillByBorrower(REOProperties rEOProperties, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_SelectREOPropertiesByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerID"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOPropertiesByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(rEOProperties, datareader);


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
		/// Fill method for populating a collection by DispositionStatusType
		/// </summary>
		public void FillByDispositionStatusType(REOProperties rEOProperties, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_SelectREOPropertiesByDispositionStatusType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@dispositionStatusType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOPropertiesByDispositionStatusType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(rEOProperties, datareader);


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
		public void FillByGSEPropertyType(REOProperties rEOProperties, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_SelectREOPropertiesByGSEPropertyType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@gSEPropertyType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOPropertiesByGSEPropertyType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(rEOProperties, datareader);


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
		/// Fill method for populating a collection by LIABILITY
		/// </summary>
		public void FillByLiability(REOProperties rEOProperties, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_SelectREOPropertiesByLiability");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@liabilityID"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOPropertiesByLiability", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(rEOProperties, datareader);


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
		public void FillByLoanApplication(REOProperties rEOProperties, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(REOProperty.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(REOProperty.GetConnectionString(), "gsp_SelectREOPropertiesByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectREOPropertiesByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(rEOProperties, datareader);


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
		public virtual void CreateObjectsFromData(REOProperties reoproperties, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			REOProperty newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(reoproperties.ContainsType[0]) as REOProperty;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				reoproperties.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(REOProperties reoproperties, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			REOProperty newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(reoproperties.ContainsType[0]) as REOProperty;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				reoproperties.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual REOProperties GetAll()
		{
			// create a new instance of the return object
			REOProperties objects = new REOProperties();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
