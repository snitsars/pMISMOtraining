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
	/// A base class service object for table 'EMPLOYER'
	/// </summary>
	internal class EmployerServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public EmployerServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Employer persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Employer persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(Employer.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Employer.GetConnectionString(), "gsp_UpdateEmployer");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Employer.GetConnectionString(), "gsp_CreateEmployer");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = persistObject.BorrowerId;
				// Store the parameter for the Name attribute.
				if (!persistObject.NameIsNull)
					sqlparams["@name"].Value = persistObject.Name;
				// Store the parameter for the StreetAddress attribute.
				if (!persistObject.StreetAddressIsNull)
					sqlparams["@streetAddress"].Value = persistObject.StreetAddress;
				// Store the parameter for the City attribute.
				if (!persistObject.CityIsNull)
					sqlparams["@city"].Value = persistObject.City;
				// Store the parameter for the State attribute.
				if (!persistObject.StateIsNull)
					sqlparams["@state"].Value = persistObject.State;
				// Store the parameter for the PostalCode attribute.
				if (!persistObject.PostalCodeIsNull)
					sqlparams["@postalCode"].Value = persistObject.PostalCode;
				// Store the parameter for the TelephoneNumber attribute.
				if (!persistObject.TelephoneNumberIsNull)
					sqlparams["@telephoneNumber"].Value = persistObject.TelephoneNumber;
				// Store the parameter for the CurrentEmploymentMonthsOnJob attribute.
				if (!persistObject.CurrentEmploymentMonthsOnJobIsNull)
					sqlparams["@currentEmploymentMonthsOnJob"].Value = persistObject.CurrentEmploymentMonthsOnJob;
				// Store the parameter for the CurrentEmploymentTimeInLineOfWorkYears attribute.
				if (!persistObject.CurrentEmploymentTimeInLineOfWorkYearsIsNull)
					sqlparams["@currentEmploymentTimeInLineOfWorkYears"].Value = persistObject.CurrentEmploymentTimeInLineOfWorkYears;
				// Store the parameter for the CurrentEmploymentYearsOnJob attribute.
				if (!persistObject.CurrentEmploymentYearsOnJobIsNull)
					sqlparams["@currentEmploymentYearsOnJob"].Value = persistObject.CurrentEmploymentYearsOnJob;
				// Store the parameter for the EmploymentBorrowerSelfEmployedIndicator attribute.
				sqlparams["@employmentBorrowerSelfEmployedIndicator"].Value = persistObject.EmploymentBorrowerSelfEmployedIndicator;
				// Store the parameter for the EmploymentCurrentIndicator attribute.
				sqlparams["@employmentCurrentIndicator"].Value = persistObject.EmploymentCurrentIndicator;
				// Store the parameter for the EmploymentPositionDescription attribute.
				if (!persistObject.EmploymentPositionDescriptionIsNull)
					sqlparams["@employmentPositionDescription"].Value = persistObject.EmploymentPositionDescription;
				// Store the parameter for the EmploymentPrimaryIndicator attribute.
				sqlparams["@employmentPrimaryIndicator"].Value = persistObject.EmploymentPrimaryIndicator;
				// Store the parameter for the IncomeEmploymentMonthlyAmount attribute.
				if (!persistObject.IncomeEmploymentMonthlyAmountIsNull)
					sqlparams["@incomeEmploymentMonthlyAmount"].Value = persistObject.IncomeEmploymentMonthlyAmount;
				// Store the parameter for the PreviousEmploymentEndDate attribute.
				if (!persistObject.PreviousEmploymentEndDateIsNull)
					sqlparams["@previousEmploymentEndDate"].Value = persistObject.PreviousEmploymentEndDate;
				// Store the parameter for the PreviousEmploymentStartDate attribute.
				if (!persistObject.PreviousEmploymentStartDateIsNull)
					sqlparams["@previousEmploymentStartDate"].Value = persistObject.PreviousEmploymentStartDate;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreateEmployer", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateEmployer", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreateEmployer", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateEmployer", sqlparams);
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
		public virtual void Delete(Employer deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(Employer.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Employer.GetConnectionString(), "gsp_DeleteEmployer");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteEmployer", sqlparams);


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
		public virtual void Fill(Employer employer, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Employer.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Employer.GetConnectionString(), "gsp_SelectEmployer");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectEmployer", sqlparams);


					if (datareader.Read())
						employer.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of Employers
		/// </summary>
		public virtual void Fill(Employers employers)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Employer.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectEmployers");


					// Send the collection and data to the object factory
					CreateObjectsFromData(employers, datareader);


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
		public void FillByBorrower(Employers employers, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Employer.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Employer.GetConnectionString(), "gsp_SelectEmployersByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectEmployersByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(employers, datareader);


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
		public virtual void CreateObjectsFromData(Employers employers, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			Employer newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(employers.ContainsType[0]) as Employer;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				employers.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(Employers employers, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			Employer newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(employers.ContainsType[0]) as Employer;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				employers.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual Employers GetAll()
		{
			// create a new instance of the return object
			Employers objects = new Employers();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
