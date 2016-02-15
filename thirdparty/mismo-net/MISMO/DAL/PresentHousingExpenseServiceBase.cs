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
	/// A base class service object for table 'PRESENT_HOUSING_EXPENSE'
	/// </summary>
	internal class PresentHousingExpenseServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PresentHousingExpenseServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(PresentHousingExpense persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(PresentHousingExpense persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(PresentHousingExpense.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(PresentHousingExpense.GetConnectionString(), "gsp_UpdatePresentHousingExpense");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(PresentHousingExpense.GetConnectionString(), "gsp_CreatePresentHousingExpense");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = persistObject.BorrowerId;
				// Store the parameter for the PaymentAmount attribute.
				sqlparams["@paymentAmount"].Value = persistObject.PaymentAmount;
				// Store the parameter for the HousingExpenseType attribute.
				sqlparams["@housingExpenseType"].Value = persistObject.HousingExpenseType;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreatePresentHousingExpense", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdatePresentHousingExpense", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreatePresentHousingExpense", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdatePresentHousingExpense", sqlparams);
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
		public virtual void Delete(PresentHousingExpense deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(PresentHousingExpense.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(PresentHousingExpense.GetConnectionString(), "gsp_DeletePresentHousingExpense");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeletePresentHousingExpense", sqlparams);


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
		public virtual void Fill(PresentHousingExpense presenthousingexpense, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PresentHousingExpense.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(PresentHousingExpense.GetConnectionString(), "gsp_SelectPresentHousingExpense");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPresentHousingExpense", sqlparams);


					if (datareader.Read())
						presenthousingexpense.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of PresentHousingExpenses
		/// </summary>
		public virtual void Fill(PresentHousingExpenses presentHousingExpenses)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PresentHousingExpense.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPresentHousingExpenses");


					// Send the collection and data to the object factory
					CreateObjectsFromData(presentHousingExpenses, datareader);


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
		public void FillByBorrower(PresentHousingExpenses presentHousingExpenses, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PresentHousingExpense.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(PresentHousingExpense.GetConnectionString(), "gsp_SelectPresentHousingExpensesByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPresentHousingExpensesByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(presentHousingExpenses, datareader);


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
		/// Fill method for populating a collection by HousingExpenseType
		/// </summary>
		public void FillByHousingExpenseType(PresentHousingExpenses presentHousingExpenses, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PresentHousingExpense.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(PresentHousingExpense.GetConnectionString(), "gsp_SelectPresentHousingExpensesByHousingExpenseType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@housingExpenseType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPresentHousingExpensesByHousingExpenseType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(presentHousingExpenses, datareader);


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
		public virtual void CreateObjectsFromData(PresentHousingExpenses presenthousingexpenses, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			PresentHousingExpense newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(presenthousingexpenses.ContainsType[0]) as PresentHousingExpense;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				presenthousingexpenses.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(PresentHousingExpenses presenthousingexpenses, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			PresentHousingExpense newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(presenthousingexpenses.ContainsType[0]) as PresentHousingExpense;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				presenthousingexpenses.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual PresentHousingExpenses GetAll()
		{
			// create a new instance of the return object
			PresentHousingExpenses objects = new PresentHousingExpenses();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}