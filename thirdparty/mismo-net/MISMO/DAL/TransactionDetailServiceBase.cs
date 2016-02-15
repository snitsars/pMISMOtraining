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
	/// A base class service object for table 'TRANSACTION_DETAIL'
	/// </summary>
	internal class TransactionDetailServiceBase : Service
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransactionDetailServiceBase()
		{
		}

		#endregion Constructors


		#region Methods

		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(TransactionDetail persistObject)
		{
			// Make a call to the overloaded method with a null transaction
			Persist(persistObject, null);
		}


		/// <summary>
		/// Persists the object.
		/// </summary>
		public virtual void Persist(TransactionDetail persistObject, SqlTransaction sqlTrans)
		{
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;
			// Create a local variable for the connection
			SqlConnection cnn = null;


			// Use the parameter overload or create a new instance
			if (sqlTrans == null)
				cnn = new SqlConnection(TransactionDetail.GetConnectionString());


			try
			{
				// discover the parameters
				if (persistObject.Persisted)
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(TransactionDetail.GetConnectionString(), "gsp_UpdateTransactionDetail");
				else
					sqlparams =  SqlHelperParameterCache.GetSpParameterSet(TransactionDetail.GetConnectionString(), "gsp_CreateTransactionDetail");


				// Store the parameter for the AlterationsImprovementsAndRepairsAmount attribute.
				if (!persistObject.AlterationsImprovementsAndRepairsAmountIsNull)
					sqlparams["@alterationsImprovementsAndRepairsAmount"].Value = persistObject.AlterationsImprovementsAndRepairsAmount;
				// Store the parameter for the BorrowerPaidDiscountPointsTotalAmount attribute.
				if (!persistObject.BorrowerPaidDiscountPointsTotalAmountIsNull)
					sqlparams["@borrowerPaidDiscountPointsTotalAmount"].Value = persistObject.BorrowerPaidDiscountPointsTotalAmount;
				// Store the parameter for the EstimatedClosingCostsAmount attribute.
				if (!persistObject.EstimatedClosingCostsAmountIsNull)
					sqlparams["@estimatedClosingCostsAmount"].Value = persistObject.EstimatedClosingCostsAmount;
				// Store the parameter for the MIAndFundingFeeFinancedAmount attribute.
				if (!persistObject.MIAndFundingFeeFinancedAmountIsNull)
					sqlparams["@mIAndFundingFeeFinancedAmount"].Value = persistObject.MIAndFundingFeeFinancedAmount;
				// Store the parameter for the MIAndFundingFeeTotalAmount attribute.
				if (!persistObject.MIAndFundingFeeTotalAmountIsNull)
					sqlparams["@mIAndFundingFeeTotalAmount"].Value = persistObject.MIAndFundingFeeTotalAmount;
				// Store the parameter for the PrepaidItemsEstimatedAmount attribute.
				if (!persistObject.PrepaidItemsEstimatedAmountIsNull)
					sqlparams["@prepaidItemsEstimatedAmount"].Value = persistObject.PrepaidItemsEstimatedAmount;
				// Store the parameter for the PurchasePriceAmount attribute.
				if (!persistObject.PurchasePriceAmountIsNull)
					sqlparams["@purchasePriceAmount"].Value = persistObject.PurchasePriceAmount;
				// Store the parameter for the RefinanceIncludingDebtsToBePaidOffAmount attribute.
				if (!persistObject.RefinanceIncludingDebtsToBePaidOffAmountIsNull)
					sqlparams["@refinanceIncludingDebtsToBePaidOffAmount"].Value = persistObject.RefinanceIncludingDebtsToBePaidOffAmount;
				// Store the parameter for the SalesConcessionAmount attribute.
				if (!persistObject.SalesConcessionAmountIsNull)
					sqlparams["@salesConcessionAmount"].Value = persistObject.SalesConcessionAmount;
				// Store the parameter for the SellerPaidClosingCostsAmount attribute.
				if (!persistObject.SellerPaidClosingCostsAmountIsNull)
					sqlparams["@sellerPaidClosingCostsAmount"].Value = persistObject.SellerPaidClosingCostsAmount;
				// Store the parameter for the SubordinateLienAmount attribute.
				if (!persistObject.SubordinateLienAmountIsNull)
					sqlparams["@subordinateLienAmount"].Value = persistObject.SubordinateLienAmount;
				// Store the parameter for the SubordinateLienHELOCAmount attribute.
				if (!persistObject.SubordinateLienHELOCAmountIsNull)
					sqlparams["@subordinateLienHELOCAmount"].Value = persistObject.SubordinateLienHELOCAmount;
				// Store the parameter for the FREReserveAmount attribute.
				if (!persistObject.FREReserveAmountIsNull)
					sqlparams["@fREReserveAmount"].Value = persistObject.FREReserveAmount;
				// Store the parameter for the FREReservesAmount attribute.
				if (!persistObject.FREReservesAmountIsNull)
					sqlparams["@fREReservesAmount"].Value = persistObject.FREReservesAmount;
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
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_CreateTransactionDetail", sqlparams);
						}
						else
						{
							SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_UpdateTransactionDetail", sqlparams);
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
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_CreateTransactionDetail", sqlparams);
					}
					else
					{
						SqlHelper.ExecuteNonQuery(sqlTrans, CommandType.StoredProcedure, "gsp_UpdateTransactionDetail", sqlparams);
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
		public virtual void Delete(TransactionDetail deleteObject)
		{
			// create a new instance of the connection
			SqlConnection cnn = new SqlConnection(TransactionDetail.GetConnectionString());
			// create local variable array for the sql parameters
			SqlParameterHash sqlparams = null;


			try
			{
				// discover the parameters
				sqlparams =  SqlHelperParameterCache.GetSpParameterSet(TransactionDetail.GetConnectionString(), "gsp_DeleteTransactionDetail");


				// Store the parameter for the LoanApplicationId attribute.
				sqlparams["@loanApplicationId"].Value = deleteObject.LoanApplicationId;


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// Execute the stored proc to perform the delete on the instance.
					SqlHelper.ExecuteNonQuery(cnn, CommandType.StoredProcedure, "gsp_DeleteTransactionDetail", sqlparams);


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
		public virtual void Fill(TransactionDetail transactiondetail, System.Int64 loanApplicationId)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransactionDetail.GetConnectionString());
			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransactionDetail.GetConnectionString(), "gsp_SelectTransactionDetail");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = loanApplicationId;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransactionDetail", sqlparams);


					if (datareader.Read())
						transactiondetail.SetMembers(ref datareader);


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
		/// Fill method for populating an entire collection of TransactionDetails
		/// </summary>
		public virtual void Fill(TransactionDetails transactionDetails)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransactionDetail.GetConnectionString());


			try
			{
				using (cnn)
				{
					// open the connection
					cnn.Open();


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransactionDetails");


					// Send the collection and data to the object factory
					CreateObjectsFromData(transactionDetails, datareader);


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
		public void FillByLoanApplication(TransactionDetails transactionDetails, System.Int64 id)
		{
			// create the connection to use
			SqlConnection cnn = new SqlConnection(TransactionDetail.GetConnectionString());


			try
			{
				// discover the sql parameters
				SqlParameterHash sqlparams = SqlHelperParameterCache.GetSpParameterSet(TransactionDetail.GetConnectionString(), "gsp_SelectTransactionDetailsByLoanApplication");


				using (cnn)
				{
					// open the connection
					cnn.Open();


					// set the parameters
					sqlparams["@loanApplicationId"].Value = id;


					// create an instance of the reader to fill.
					SqlDataReader datareader = SqlHelper.ExecuteReader(cnn, "gsp_SelectTransactionDetailsByLoanApplication", sqlparams);


					// Send the collection and data to the object factory.
					CreateObjectsFromData(transactionDetails, datareader);


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
		public virtual void CreateObjectsFromData(TransactionDetails transactiondetails, System.Data.SqlClient.SqlDataReader data)
		{
			// Do nothing if we have nothing
			if (data == null) return;


			// Create a local variable for the new instance.
			TransactionDetail newobj = null;
			// Iterate through the data reader
			while (data.Read())
			{
				// Create a new object instance
				newobj = System.Activator.CreateInstance(transactiondetails.ContainsType[0]) as TransactionDetail;
				// Let the instance set its own members
				newobj.SetMembers(ref data);
				// Add the new object to the collection instance
				transactiondetails.Add(newobj);
			}
		}


		/// <summary>
		/// The object factory for a particular data collection instance.
		/// </summary>
		public virtual void CreateObjectsFromData(TransactionDetails transactiondetails, System.Data.DataSet data)
		{
			// Do nothing if we have nothing
			if (data == null || data.Tables.Count == 0 || data.Tables[0].Rows.Count == 0) return;


			// Create a local variable for the new instance.
			TransactionDetail newobj = null;
			// Create a local variable for the data row instance.
			System.Data.DataRow dr = null;


			// Iterate through the table rows
			for (int i = 0; i<data.Tables[0].Rows.Count; i++)
			{
				// Get a reference to the data row
				dr = data.Tables[0].Rows[i];
				// Create a new object instance
				newobj = System.Activator.CreateInstance(transactiondetails.ContainsType[0]) as TransactionDetail;
				// Let the instance set its own members
				newobj.SetMembers(ref dr);
				// Add the new object to the collection instance
				transactiondetails.Add(newobj);
			}
		}


		/// <summary>
		/// Gets all the available objects.
		/// </summary>
		public virtual TransactionDetails GetAll()
		{
			// create a new instance of the return object
			TransactionDetails objects = new TransactionDetails();


			// fill the objects
			this.Fill(objects);


			// return the filled object from the service
			return objects;
		}

		#endregion Methods

	}
}
