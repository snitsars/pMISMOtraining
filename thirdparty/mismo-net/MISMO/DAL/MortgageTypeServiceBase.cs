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
	/// A base class service object for table 'MortgageType'
	/// </summary>
	internal class MortgageTypeServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageTypeServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(MortgageType persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(MortgageType persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(MortgageType.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(MortgageType.GetConnectionString(), "gsp_UpdateMortgageType");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(MortgageType.GetConnectionString(), "gsp_CreateMortgageType");


				// Store the parameter for the Name attribute.
				sqlparams["@name"].Value = persistObject.Name;
				// Store the parameter for the EnumeratedName attribute.
				sqlparams["@enumeratedName"].Value = persistObject.EnumeratedName;
				// Store the parameter for the Description attribute.
				if (!persistObject.DescriptionIsNull)
					sqlparams["@description"].Value = persistObject.Description;
				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = persistObject.Id;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateMortgageType", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateMortgageType", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateMortgageType", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateMortgageType", sqlparams);
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
		public virtual void Delete(MortgageType deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(MortgageType.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(MortgageType.GetConnectionString(), "gsp_DeleteMortgageType");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteMortgageType", sqlparams);


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
		public virtual void Fill(MortgageType mt, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageType.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(MortgageType.GetConnectionString(), "gsp_SelectMortgageType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageType", sqlparams);


					if (datareader.Read())
						mt.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of MortgageTypes
		/// </summary>
		public virtual void Fill(MortgageTypes mortgageTypes)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(MortgageType.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectMortgageTypes");


					// Send the collection and data to the object factory
					CreateObjectsFromData(mortgageTypes, datareader);


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
		public virtual void CreateObjectsFromData(MortgageTypes mortgagetypes, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			MortgageType newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(mortgagetypes.ContainsType[0]) as MortgageType;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				mortgagetypes.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(MortgageTypes mortgagetypes, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			MortgageType newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(mortgagetypes.ContainsType[0]) as MortgageType;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				mortgagetypes.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual MortgageTypes GetAll()
		{
			// create a new instance of the return object
			MortgageTypes objects = new MortgageTypes();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}