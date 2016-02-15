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
using System.Data.SqlTypes;
using System.Threading;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;




namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// Summary description for Service.
	/// </summary>
	public class Service : ContextBoundObject, ICounterProvider
	{
		// members...
		protected static PerformanceCounter _numServiceObjectsCounter;
		protected static PerformanceCounter _getEntitySetRateCounter;
		protected static PerformanceCounter _getAllRateCounter;
		protected static PerformanceCounter _getByIdRateCounter;




		// const...
		protected const string NumServiceObjectsCounterName = "NumServiceObjects";
		protected const string GetEntitySetRateCounterName = "Service.GetEntitySets/sec";
		protected const string GetAllRateCounterName = "Service.GetAll/sec";
		protected const string GetByIdRateCounterName = "Service.GetById/sec";








		public Service()
		{
			if(_numServiceObjectsCounter != null)
				_numServiceObjectsCounter.Increment();
		}




		~Service()
		{
			// try to decrement...
			try
			{
				if(_numServiceObjectsCounter != null)
					_numServiceObjectsCounter.Decrement();
			}
			catch
			{
			}
		}




		public virtual void CreateCounters(EnterpriseCounters counters)
		{
			// create the counters...
			counters.Counters.Add(new EnterpriseCounter(NumServiceObjectsCounterName, "Number of open service objects", PerformanceCounterType.NumberOfItems32));
			counters.Counters.Add(new EnterpriseCounter(GetEntitySetRateCounterName, "Number of GetEntitySet calls per second", PerformanceCounterType.RateOfCountsPerSecond32));
			counters.Counters.Add(new EnterpriseCounter(GetAllRateCounterName, "Number of GetAll calls per second", PerformanceCounterType.RateOfCountsPerSecond32));
			counters.Counters.Add(new EnterpriseCounter(GetByIdRateCounterName, "Number of GetById calls per second", PerformanceCounterType.RateOfCountsPerSecond32));
		}




		public virtual void CountersCreated(EnterpriseCounters counters)
		{
			// save them...
			_numServiceObjectsCounter = counters.Counters.Find(NumServiceObjectsCounterName).Counter;
			_getEntitySetRateCounter = counters.Counters.Find(GetEntitySetRateCounterName).Counter;
			_getAllRateCounter = counters.Counters.Find(GetAllRateCounterName).Counter;
			_getByIdRateCounter = counters.Counters.Find(GetByIdRateCounterName).Counter;
		}




		public DataSet GetDataSet(string commandText) 
		{
			// create a command...
			SqlCommand command = new SqlCommand(commandText);
			DataSet dataset = GetDataSet(command);
			command.Dispose();




			// return...
			return dataset;
		}




		public DataSet GetDataSet(SqlCommand command)
		{
			// do we have a connection?
			SqlConnection connection = null;
			if(command.Connection == null)
			{
				connection = new SqlConnection(EnterpriseApplication.Application.ConnectionString);
				connection.Open();
				command.Connection = connection;
			}




			// run...
			DataSet dataset = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(dataset);
			adapter.Dispose();




			// close the connection...
			if(connection != null)
				connection.Close();




			// return...
			return dataset;
		}




//		public byte[] GetLatestTimestamp(string tableName, string idColumnName, int id)
//		{
//			// changed?
//			byte[] latest = null;
//
//			// get the latest version...
//			SqlConnection connection = new SqlConnection(EnterpriseApplication.Application.ConnectionString);
//			connection.Open();
//			SqlCommand command = new SqlCommand("select timestamp from " + tableName + " where " + idColumnName + "=" + id.ToString(), connection);
//			SqlDataReader reader = command.ExecuteReader();
//			if(reader.Read() == true)
//				latest = (byte[])reader[0];
//	
//			// close...
//			reader.Close();
//			connection.Close();
//
//			// return...
//			return latest;
//		}	
//
//		public bool HasChanged(SqlBinary timestamp1, SqlBinary timestamp2)
//		{
//			// compare...
//			SqlBoolean result = SqlBinary.Equals(timestamp1, timestamp2);
//			return !(result.Value);
//		}




		public string GetSecurityToken()
		{
			// get the data from the call context...
			ContextToken token = (ContextToken)CallContext.GetData(EnterpriseApplication.SecurityTokenSlotName);
			if(token != null)
				return token.Token;
			
			return null;
		}




		[Conditional("DEBUG")] public void DebugSecurityToken()
		{
			DebugSecurityToken(false);
		}




		[Conditional("DEBUG")] public void DebugSecurityToken(bool showExtendedData)
		{
			// render...
			Console.WriteLine("--------------------------------------------------------------------");
			Console.Write("Security token for thread #{0}: ", Thread.CurrentThread.GetHashCode());
			string contextToken = GetSecurityToken();
			if(contextToken != null)
			{
				// write the token...
				Console.WriteLine(contextToken);




				// do we want extended info?
				if(showExtendedData == true)
				{
					// load the token...
					Token token = Token.Load(contextToken);
					if(token != null)
					{
						Console.WriteLine("Token ID: {0}", token.Id.ToString());
						Console.WriteLine("User ID: {0}", token.UserId.ToString());
						Console.WriteLine("NTLM name: {0}", token.NtlmName);
					}
					else
						Console.WriteLine("INVALID TOKEN!");
				}
				else
					Console.WriteLine("NOT FOUND!");
			}




			Console.WriteLine("--------------------------------------------------------------------");
		}
	}
}






