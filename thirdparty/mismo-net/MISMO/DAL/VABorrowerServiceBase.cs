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
	/// A base class service object for table 'VA_BORROWER'
	/// </summary>
	internal class VABorrowerServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VABorrowerServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(VABorrower persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(VABorrower persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(VABorrower.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(VABorrower.GetConnectionString(), "gsp_UpdateVABorrower");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(VABorrower.GetConnectionString(), "gsp_CreateVABorrower");


				// Store the parameter for the VACoBorrowerNonTaxableIncomeAmount attribute.
				if (!persistObject.VACoBorrowerNonTaxableIncomeAmountIsNull)
					sqlparams["@vACoBorrowerNonTaxableIncomeAmount"].Value = persistObject.VACoBorrowerNonTaxableIncomeAmount;
				// Store the parameter for the VACoBorrowerTaxableIncomeAmount attribute.
				if (!persistObject.VACoBorrowerTaxableIncomeAmountIsNull)
					sqlparams["@vACoBorrowerTaxableIncomeAmount"].Value = persistObject.VACoBorrowerTaxableIncomeAmount;
				// Store the parameter for the VAFederalTaxAmount attribute.
				if (!persistObject.VAFederalTaxAmountIsNull)
					sqlparams["@vAFederalTaxAmount"].Value = persistObject.VAFederalTaxAmount;
				// Store the parameter for the VALocalTaxAmount attribute.
				if (!persistObject.VALocalTaxAmountIsNull)
					sqlparams["@vALocalTaxAmount"].Value = persistObject.VALocalTaxAmount;
				// Store the parameter for the VAPrimaryBorrowerNonTaxableIncomeAmount attribute.
				if (!persistObject.VAPrimaryBorrowerNonTaxableIncomeAmountIsNull)
					sqlparams["@vAPrimaryBorrowerNonTaxableIncomeAmount"].Value = persistObject.VAPrimaryBorrowerNonTaxableIncomeAmount;
				// Store the parameter for the VAPrimaryBorrowerTaxableIncomeAmount attribute.
				if (!persistObject.VAPrimaryBorrowerTaxableIncomeAmountIsNull)
					sqlparams["@vAPrimaryBorrowerTaxableIncomeAmount"].Value = persistObject.VAPrimaryBorrowerTaxableIncomeAmount;
				// Store the parameter for the VASocialSecurityTaxAmount attribute.
				if (!persistObject.VASocialSecurityTaxAmountIsNull)
					sqlparams["@vASocialSecurityTaxAmount"].Value = persistObject.VASocialSecurityTaxAmount;
				// Store the parameter for the VAStateTaxAmount attribute.
				if (!persistObject.VAStateTaxAmountIsNull)
					sqlparams["@vAStateTaxAmount"].Value = persistObject.VAStateTaxAmount;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateVABorrower", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateVABorrower", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateVABorrower", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateVABorrower", sqlparams);
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
		public virtual void Delete(VABorrower deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(VABorrower.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(VABorrower.GetConnectionString(), "gsp_DeleteVABorrower");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = deleteObject.BorrowerId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteVABorrower", sqlparams);


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
		public virtual void Fill(VABorrower vaborrower, System.Int64 borrowerId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(VABorrower.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(VABorrower.GetConnectionString(), "gsp_SelectVABorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = borrowerId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectVABorrower", sqlparams);


					if (datareader.Read())
						vaborrower.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of VABorrowers
		/// </summary>
		public virtual void Fill(VABorrowers vABorrowers)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(VABorrower.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectVABorrowers");


					// Send the collection and data to the object factory
					CreateObjectsFromData(vABorrowers, datareader);


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
		public void FillByBorrower(VABorrowers vABorrowers, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(VABorrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(VABorrower.GetConnectionString(), "gsp_SelectVABorrowersByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectVABorrowersByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(vABorrowers, datareader);


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
		public virtual void CreateObjectsFromData(VABorrowers vaborrowers, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			VABorrower newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(vaborrowers.ContainsType[0]) as VABorrower;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				vaborrowers.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(VABorrowers vaborrowers, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			VABorrower newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(vaborrowers.ContainsType[0]) as VABorrower;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				vaborrowers.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual VABorrowers GetAll()
		{
			// create a new instance of the return object
			VABorrowers objects = new VABorrowers();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
