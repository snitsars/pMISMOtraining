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
	/// A base class service object for table 'INTERVIEWER_INFORMATION'
	/// </summary>
	internal class InterviewerInformationServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public InterviewerInformationServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(InterviewerInformation persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(InterviewerInformation persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(InterviewerInformation.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(InterviewerInformation.GetConnectionString(), "gsp_UpdateInterviewerInformation");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(InterviewerInformation.GetConnectionString(), "gsp_CreateInterviewerInformation");


				// Store the parameter for the InterviewersEmployerStreetAddress attribute.
				if (!persistObject.InterviewersEmployerStreetAddressIsNull)
					sqlparams["@interviewersEmployerStreetAddress"].Value = persistObject.InterviewersEmployerStreetAddress;
				// Store the parameter for the InterviewersEmployerCity attribute.
				if (!persistObject.InterviewersEmployerCityIsNull)
					sqlparams["@interviewersEmployerCity"].Value = persistObject.InterviewersEmployerCity;
				// Store the parameter for the InterviewersEmployerState attribute.
				if (!persistObject.InterviewersEmployerStateIsNull)
					sqlparams["@interviewersEmployerState"].Value = persistObject.InterviewersEmployerState;
				// Store the parameter for the InterviewersEmployerPostalCode attribute.
				if (!persistObject.InterviewersEmployerPostalCodeIsNull)
					sqlparams["@interviewersEmployerPostalCode"].Value = persistObject.InterviewersEmployerPostalCode;
				// Store the parameter for the InterviewersTelephoneNumber attribute.
				if (!persistObject.InterviewersTelephoneNumberIsNull)
					sqlparams["@interviewersTelephoneNumber"].Value = persistObject.InterviewersTelephoneNumber;
				// Store the parameter for the ApplicationTakenMethodType attribute.
				if (!persistObject.ApplicationTakenMethodTypeIsNull)
					sqlparams["@applicationTakenMethodType"].Value = persistObject.ApplicationTakenMethodType;
				// Store the parameter for the InterviewerApplicationSignedDate attribute.
				if (!persistObject.InterviewerApplicationSignedDateIsNull)
					sqlparams["@interviewerApplicationSignedDate"].Value = persistObject.InterviewerApplicationSignedDate;
				// Store the parameter for the InterviewersEmployerName attribute.
				if (!persistObject.InterviewersEmployerNameIsNull)
					sqlparams["@interviewersEmployerName"].Value = persistObject.InterviewersEmployerName;
				// Store the parameter for the InterviewersName attribute.
				if (!persistObject.InterviewersNameIsNull)
					sqlparams["@interviewersName"].Value = persistObject.InterviewersName;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateInterviewerInformation", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateInterviewerInformation", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateInterviewerInformation", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateInterviewerInformation", sqlparams);
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
		public virtual void Delete(InterviewerInformation deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(InterviewerInformation.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(InterviewerInformation.GetConnectionString(), "gsp_DeleteInterviewerInformation");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteInterviewerInformation", sqlparams);


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
		public virtual void Fill(InterviewerInformation interviewerinformation, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(InterviewerInformation.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(InterviewerInformation.GetConnectionString(), "gsp_SelectInterviewerInformation");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectInterviewerInformation", sqlparams);


					if (datareader.Read())
						interviewerinformation.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of InterviewerInformationCollection
		/// </summary>
		public virtual void Fill(InterviewerInformationCollection interviewerInformationCollection)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(InterviewerInformation.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectInterviewerInformationCollection");


					// Send the collection and data to the object factory
					CreateObjectsFromData(interviewerInformationCollection, datareader);


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
		/// Fill method for populating a collection by ApplicationMethod
		/// </summary>
		public void FillByApplicationMethod(InterviewerInformationCollection interviewerInformationCollection, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(InterviewerInformation.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(InterviewerInformation.GetConnectionString(), "gsp_SelectInterviewerInformationCollectionByApplicationMethod");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@applicationTakenMethodType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectInterviewerInformationCollectionByApplicationMethod", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(interviewerInformationCollection, datareader);


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
		public void FillByLoanApplication(InterviewerInformationCollection interviewerInformationCollection, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(InterviewerInformation.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(InterviewerInformation.GetConnectionString(), "gsp_SelectInterviewerInformationCollectionByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectInterviewerInformationCollectionByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(interviewerInformationCollection, datareader);


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
		public virtual void CreateObjectsFromData(InterviewerInformationCollection interviewerinformationcollection, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			InterviewerInformation newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(interviewerinformationcollection.ContainsType[0]) as InterviewerInformation;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				interviewerinformationcollection.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(InterviewerInformationCollection interviewerinformationcollection, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			InterviewerInformation newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(interviewerinformationcollection.ContainsType[0]) as InterviewerInformation;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				interviewerinformationcollection.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual InterviewerInformationCollection GetAll()
		{
			// create a new instance of the return object
			InterviewerInformationCollection objects = new InterviewerInformationCollection();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
