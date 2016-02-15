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
	/// A base class service object for table 'BORROWER'
	/// </summary>
	internal class BorrowerServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BorrowerServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Borrower persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Borrower persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_UpdateBorrower");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_CreateBorrower");


				// Store the parameter for the JointAssetBorrowerID attribute.
				if (!persistObject.JointAssetBorrowerIDIsNull)
					sqlparams["@jointAssetBorrowerID"].Value = persistObject.JointAssetBorrowerID;
				// Store the parameter for the LoanApplicationId attribute.
				if (!persistObject.LoanApplicationIdIsNull)
					sqlparams["@loanApplicationId"].Value = persistObject.LoanApplicationId;
				// Store the parameter for the FirstName attribute.
				if (!persistObject.FirstNameIsNull)
					sqlparams["@firstName"].Value = persistObject.FirstName;
				// Store the parameter for the MiddleName attribute.
				if (!persistObject.MiddleNameIsNull)
					sqlparams["@middleName"].Value = persistObject.MiddleName;
				// Store the parameter for the LastName attribute.
				if (!persistObject.LastNameIsNull)
					sqlparams["@lastName"].Value = persistObject.LastName;
				// Store the parameter for the NameSuffix attribute.
				if (!persistObject.NameSuffixIsNull)
					sqlparams["@nameSuffix"].Value = persistObject.NameSuffix;
				// Store the parameter for the AgeAtApplicationYears attribute.
				if (!persistObject.AgeAtApplicationYearsIsNull)
					sqlparams["@ageAtApplicationYears"].Value = persistObject.AgeAtApplicationYears;
				// Store the parameter for the BirthDate attribute.
				if (!persistObject.BirthDateIsNull)
					sqlparams["@birthDate"].Value = persistObject.BirthDate;
				// Store the parameter for the ApplicationSignedDate attribute.
				if (!persistObject.ApplicationSignedDateIsNull)
					sqlparams["@applicationSignedDate"].Value = persistObject.ApplicationSignedDate;
				// Store the parameter for the HomeTelephoneNumber attribute.
				if (!persistObject.HomeTelephoneNumberIsNull)
					sqlparams["@homeTelephoneNumber"].Value = persistObject.HomeTelephoneNumber;
				// Store the parameter for the SSN attribute.
				if (!persistObject.SSNIsNull)
					sqlparams["@sSN"].Value = persistObject.SSN;
				// Store the parameter for the DependentCount attribute.
				if (!persistObject.DependentCountIsNull)
					sqlparams["@dependentCount"].Value = persistObject.DependentCount;
				// Store the parameter for the SchoolingYears attribute.
				if (!persistObject.SchoolingYearsIsNull)
					sqlparams["@schoolingYears"].Value = persistObject.SchoolingYears;
				// Store the parameter for the CreditReportIdentifier attribute.
				if (!persistObject.CreditReportIdentifierIsNull)
					sqlparams["@creditReportIdentifier"].Value = persistObject.CreditReportIdentifier;
				// Store the parameter for the MaritalStatusType attribute.
				if (!persistObject.MaritalStatusTypeIsNull)
					sqlparams["@maritalStatusType"].Value = persistObject.MaritalStatusType;
				// Store the parameter for the PrintPositionType attribute.
				if (!persistObject.PrintPositionTypeIsNull)
					sqlparams["@printPositionType"].Value = persistObject.PrintPositionType;
				// Store the parameter for the JointAssetLiabilityReportingType attribute.
				if (!persistObject.JointAssetLiabilityReportingTypeIsNull)
					sqlparams["@jointAssetLiabilityReportingType"].Value = persistObject.JointAssetLiabilityReportingType;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreateBorrower", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateBorrower", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreateBorrower", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateBorrower", sqlparams);
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
		public virtual void Delete(Borrower deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_DeleteBorrower");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteBorrower", sqlparams);


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
		public virtual void Fill(Borrower borrower, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_SelectBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrower", sqlparams);


					if (datareader.Read())
						borrower.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of Borrowers
		/// </summary>
		public virtual void Fill(Borrowers borrowers)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrowers");


					// Send the collection and data to the object factory
					CreateObjectsFromData(borrowers, datareader);


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
		public void FillByBorrower(Borrowers borrowers, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_SelectBorrowersByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@jointAssetBorrowerID"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrowersByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(borrowers, datareader);


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
		/// Fill method for populating a collection by JointAssetLiabilityReportingType
		/// </summary>
		public void FillByJointAssetLiabilityReportingType(Borrowers borrowers, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_SelectBorrowersByJointAssetLiabilityReportingType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@jointAssetLiabilityReportingType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrowersByJointAssetLiabilityReportingType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(borrowers, datareader);


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
		public void FillByLoanApplication(Borrowers borrowers, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_SelectBorrowersByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrowersByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(borrowers, datareader);


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
		/// Fill method for populating a collection by MaritalStatusType
		/// </summary>
		public void FillByMaritalStatusType(Borrowers borrowers, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_SelectBorrowersByMaritalStatusType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@maritalStatusType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrowersByMaritalStatusType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(borrowers, datareader);


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
		/// Fill method for populating a collection by PrintPositionType
		/// </summary>
		public void FillByPrintPositionType(Borrowers borrowers, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_SelectBorrowersByPrintPositionType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@printPositionType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectBorrowersByPrintPositionType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(borrowers, datareader);


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
		public virtual void CreateObjectsFromData(Borrowers borrowers, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			Borrower newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(borrowers.ContainsType[0]) as Borrower;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				borrowers.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(Borrowers borrowers, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			Borrower newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(borrowers.ContainsType[0]) as Borrower;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				borrowers.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual Borrowers GetAll()
		{
			// create a new instance of the return object
			Borrowers objects = new Borrowers();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}
		/// <summary>
		/// Fill method for populating an entire collection of Borrowers using the selection service GetBySSN
		/// </summary>
		public virtual void GetBySSN(Borrowers borrowers, System.String sSN)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Borrower.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Borrower.GetConnectionString(), "gsp_BorrowersGetBySSN");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Start setting the requirement SP parameters
					sqlparams["@sSN"].Value = sSN;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_BorrowersGetBySSN", sqlparams);


					// Send the collection and data to the object factory
					CreateObjectsFromData(borrowers, datareader);


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



		#endregion Methods

	}
}
