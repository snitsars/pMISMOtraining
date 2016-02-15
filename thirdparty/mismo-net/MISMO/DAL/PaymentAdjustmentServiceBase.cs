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
	/// A base class service object for table 'PAYMENT_ADJUSTMENT'
	/// </summary>
	internal class PaymentAdjustmentServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PaymentAdjustmentServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(PaymentAdjustment persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(PaymentAdjustment persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(PaymentAdjustment.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(PaymentAdjustment.GetConnectionString(), "gsp_UpdatePaymentAdjustment");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(PaymentAdjustment.GetConnectionString(), "gsp_CreatePaymentAdjustment");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = persistObject.LoanApplicationId;
				// Store the parameter for the FirstPaymentAdjustmentMonths attribute.
				if (!persistObject.FirstPaymentAdjustmentMonthsIsNull)
					sqlparams["@firstPaymentAdjustmentMonths"].Value = persistObject.FirstPaymentAdjustmentMonths;
				// Store the parameter for the Amount attribute.
				if (!persistObject.AmountIsNull)
					sqlparams["@amount"].Value = persistObject.Amount;
				// Store the parameter for the CalculationType attribute.
				sqlparams["@calculationType"].Value = persistObject.CalculationType;
				// Store the parameter for the DurationMonths attribute.
				if (!persistObject.DurationMonthsIsNull)
					sqlparams["@durationMonths"].Value = persistObject.DurationMonths;
				// Store the parameter for the Percent attribute.
				if (!persistObject.PercentIsNull)
					sqlparams["@percent"].Value = persistObject.Percent;
				// Store the parameter for the PeriodicCapAmount attribute.
				if (!persistObject.PeriodicCapAmountIsNull)
					sqlparams["@periodicCapAmount"].Value = persistObject.PeriodicCapAmount;
				// Store the parameter for the PeriodicCapPercent attribute.
				if (!persistObject.PeriodicCapPercentIsNull)
					sqlparams["@periodicCapPercent"].Value = persistObject.PeriodicCapPercent;
				// Store the parameter for the PeriodNumber attribute.
				if (!persistObject.PeriodNumberIsNull)
					sqlparams["@periodNumber"].Value = persistObject.PeriodNumber;
				// Store the parameter for the SubsequentPaymentAdjustmentMonths attribute.
				if (!persistObject.SubsequentPaymentAdjustmentMonthsIsNull)
					sqlparams["@subsequentPaymentAdjustmentMonths"].Value = persistObject.SubsequentPaymentAdjustmentMonths;
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
							persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(cnn, CommandType.StoredProcedure, "gsp_CreatePaymentAdjustment", sqlparams));
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdatePaymentAdjustment", sqlparams);
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
						persistObject._id = Convert.ToInt64(SqlHelper.ExecuteScalar(sqlTrans, CommandType.StoredProcedure, "gsp_CreatePaymentAdjustment", sqlparams));
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdatePaymentAdjustment", sqlparams);
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
		public virtual void Delete(PaymentAdjustment deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(PaymentAdjustment.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(PaymentAdjustment.GetConnectionString(), "gsp_DeletePaymentAdjustment");


				// Store the parameter for the Id attribute.
				sqlparams["@id"].Value = deleteObject.Id;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeletePaymentAdjustment", sqlparams);


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
		public virtual void Fill(PaymentAdjustment paymentadjustment, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PaymentAdjustment.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(PaymentAdjustment.GetConnectionString(), "gsp_SelectPaymentAdjustment");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@id"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPaymentAdjustment", sqlparams);


					if (datareader.Read())
						paymentadjustment.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of PaymentAdjustments
		/// </summary>
		public virtual void Fill(PaymentAdjustments paymentAdjustments)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PaymentAdjustment.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPaymentAdjustments");


					// Send the collection and data to the object factory
					CreateObjectsFromData(paymentAdjustments, datareader);


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
		/// Fill method for populating a collection by LOAN_PRODUCT_DATA
		/// </summary>
		public void FillByLoanProductData(PaymentAdjustments paymentAdjustments, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(PaymentAdjustment.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(PaymentAdjustment.GetConnectionString(), "gsp_SelectPaymentAdjustmentsByLoanProductData");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectPaymentAdjustmentsByLoanProductData", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(paymentAdjustments, datareader);


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
		public virtual void CreateObjectsFromData(PaymentAdjustments paymentadjustments, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			PaymentAdjustment newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(paymentadjustments.ContainsType[0]) as PaymentAdjustment;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				paymentadjustments.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(PaymentAdjustments paymentadjustments, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			PaymentAdjustment newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(paymentadjustments.ContainsType[0]) as PaymentAdjustment;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				paymentadjustments.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual PaymentAdjustments GetAll()
		{
			// create a new instance of the return object
			PaymentAdjustments objects = new PaymentAdjustments();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
