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
	/// A base class service object for table 'DECLARATION'
	/// </summary>
	internal class DeclarationServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DeclarationServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Declaration persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(Declaration persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(Declaration.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_UpdateDeclaration");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_CreateDeclaration");


				// Store the parameter for the AlimonyChildSupportObligationIndicator attribute.
				sqlparams["@alimonyChildSupportObligationIndicator"].Value = persistObject.AlimonyChildSupportObligationIndicator;
				// Store the parameter for the BankruptcyIndicator attribute.
				sqlparams["@bankruptcyIndicator"].Value = persistObject.BankruptcyIndicator;
				// Store the parameter for the BorrowedDownPaymentIndicator attribute.
				sqlparams["@borrowedDownPaymentIndicator"].Value = persistObject.BorrowedDownPaymentIndicator;
				// Store the parameter for the CoMakerEndorserOfNoteIndicator attribute.
				sqlparams["@coMakerEndorserOfNoteIndicator"].Value = persistObject.CoMakerEndorserOfNoteIndicator;
				// Store the parameter for the HomeownerPastThreeYearsType attribute.
				if (!persistObject.HomeownerPastThreeYearsTypeIsNull)
					sqlparams["@homeownerPastThreeYearsType"].Value = persistObject.HomeownerPastThreeYearsType;
				// Store the parameter for the IntentToOccupyType attribute.
				if (!persistObject.IntentToOccupyTypeIsNull)
					sqlparams["@intentToOccupyType"].Value = persistObject.IntentToOccupyType;
				// Store the parameter for the LoanForeclosureOrJudgementIndicator attribute.
				sqlparams["@loanForeclosureOrJudgementIndicator"].Value = persistObject.LoanForeclosureOrJudgementIndicator;
				// Store the parameter for the OutstandingJudgementsIndicator attribute.
				sqlparams["@outstandingJudgementsIndicator"].Value = persistObject.OutstandingJudgementsIndicator;
				// Store the parameter for the PartyToLawsuitIndicator attribute.
				sqlparams["@partyToLawsuitIndicator"].Value = persistObject.PartyToLawsuitIndicator;
				// Store the parameter for the PresentlyDelinquentIndicator attribute.
				sqlparams["@presentlyDelinquentIndicator"].Value = persistObject.PresentlyDelinquentIndicator;
				// Store the parameter for the PropertyForeclosedPastSevenYearsIndicator attribute.
				sqlparams["@propertyForeclosedPastSevenYearsIndicator"].Value = persistObject.PropertyForeclosedPastSevenYearsIndicator;
				// Store the parameter for the CitizenshipResidencyType attribute.
				if (!persistObject.CitizenshipResidencyTypeIsNull)
					sqlparams["@citizenshipResidencyType"].Value = persistObject.CitizenshipResidencyType;
				// Store the parameter for the PriorPropertyTitleType attribute.
				if (!persistObject.PriorPropertyTitleTypeIsNull)
					sqlparams["@priorPropertyTitleType"].Value = persistObject.PriorPropertyTitleType;
				// Store the parameter for the PriorPropertyUsageType attribute.
				if (!persistObject.PriorPropertyUsageTypeIsNull)
					sqlparams["@priorPropertyUsageType"].Value = persistObject.PriorPropertyUsageType;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateDeclaration", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateDeclaration", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateDeclaration", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateDeclaration", sqlparams);
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
		public virtual void Delete(Declaration deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_DeleteDeclaration");


				// Store the parameter for the BorrowerId attribute.
				sqlparams["@borrowerId"].Value = deleteObject.BorrowerId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteDeclaration", sqlparams);


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
		public virtual void Fill(Declaration declaration, System.Int64 borrowerId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_SelectDeclaration");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = borrowerId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectDeclaration", sqlparams);


					if (datareader.Read())
						declaration.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of Declarations
		/// </summary>
		public virtual void Fill(Declarations declarations)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectDeclarations");


					// Send the collection and data to the object factory
					CreateObjectsFromData(declarations, datareader);


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
		public void FillByBorrower(Declarations declarations, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_SelectDeclarationsByBorrower");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@borrowerId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectDeclarationsByBorrower", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(declarations, datareader);


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
		/// Fill method for populating a collection by CitizenshipResidencyType
		/// </summary>
		public void FillByCitizenshipResidencyType(Declarations declarations, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_SelectDeclarationsByCitizenshipResidencyType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@citizenshipResidencyType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectDeclarationsByCitizenshipResidencyType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(declarations, datareader);


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
		/// Fill method for populating a collection by PriorPropertyUsageType
		/// </summary>
		public void FillByPriorPropertyUsageType(Declarations declarations, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_SelectDeclarationsByPriorPropertyUsageType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@priorPropertyUsageType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectDeclarationsByPriorPropertyUsageType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(declarations, datareader);


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
		/// Fill method for populating a collection by PriorPropertyTitleType
		/// </summary>
		public void FillByPriorPropertyTitleType(Declarations declarations, System.Int16 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(Declaration.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(Declaration.GetConnectionString(), "gsp_SelectDeclarationsByPriorPropertyTitleType");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@priorPropertyTitleType"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectDeclarationsByPriorPropertyTitleType", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(declarations, datareader);


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
		public virtual void CreateObjectsFromData(Declarations declarations, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			Declaration newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(declarations.ContainsType[0]) as Declaration;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				declarations.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(Declarations declarations, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			Declaration newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(declarations.ContainsType[0]) as Declaration;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				declarations.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual Declarations GetAll()
		{
			// create a new instance of the return object
			Declarations objects = new Declarations();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
