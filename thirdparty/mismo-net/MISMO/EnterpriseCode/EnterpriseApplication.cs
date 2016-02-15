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
using System.Collections;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;




namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// Summary description for EnterpriseApplication.
	/// </summary>
	public class EnterpriseApplication
	{




		#region Members
		// members...
		private static EnterpriseApplication _application = new EnterpriseApplication();
		private string _connectionString;
		private Hashtable _connectionStringParts;
		public ConnectionType ConnectionMode = ConnectionType.Direct;
		private ServiceObjectFactory _serviceObjectFactory;
		private string _securityToken;
		private EnterpriseCounters _counters = new EnterpriseCounters();
		// const...
		public const string SecurityTokenSlotName = "WeoSecurityToken";




		// enum...
		public enum ConnectionType { Direct=0, Remoting };
		#endregion




		#region Properties
		/// <summary>
		/// gets static enterprise application instance
		/// </summary>
		public static EnterpriseApplication Application
		{
			get
			{
				return _application;
			}
		}




		//gets and sets connection string
		public string ConnectionString
		{
			get
			{
				return _connectionString;
			}
			set
			{
				// set it...
				_connectionString = value;
				_connectionStringParts = null;
			}
		}




		/// <summary>
		/// gets parts of connectionstring (split up the connection string)
		/// </summary>
		public Hashtable ConnectionStringParts
		{
			get
			{
				// do we have it?
				if(_connectionStringParts == null)
				{
					// first see if we have a valid string
					if (ConnectionString == null || ConnectionString == string.Empty)
						throw new Exception("Connection string has not been specified.");


					// create it...
					_connectionStringParts = new Hashtable();




					// split it...
					string[] parts = ConnectionString.Split(';');
					foreach(string part in parts)
					{
						// split into value...
						string[] valueParts = part.Split('=');
						if (valueParts.Length > 1)
							_connectionStringParts.Add(valueParts[0], valueParts[1]);
					}
				}




				// return...
				return _connectionStringParts;
			}
		}




		// ServiceObjectFactory - create a factory...
		public ServiceObjectFactory ServiceObjectFactory
		{
			get
			{
				// do we have one?
				if(_serviceObjectFactory == null)
				{
					// look at the string...
					if(ConnectionStringParts.Contains("Enterprise Connection Type") == true)
					{
						string connectionType = ConnectionStringParts["Enterprise Connection Type"].ToString().ToLower();
						switch(connectionType)
						{
								// direct...
							case "direct":
								_serviceObjectFactory = new DirectServiceObjectFactory();
								break;




								// remoting...
							case "remoting":
								_serviceObjectFactory = new RemotingServiceObjectFactory();
								break;




								// else...
							default:
								throw new NotSupportedException("Connection type '" + connectionType + "' not supported.");
						}
					}




					// did we get one?  create a default one...
					if(_serviceObjectFactory == null)
						_serviceObjectFactory = new DirectServiceObjectFactory();
				}




				// return it...
				return _serviceObjectFactory;
			}
		}




		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set
			{
				// set the value...
				_securityToken = value;




				// configure the thread...
				ConfigureThread();
			}
		}




		public EnterpriseCounters Counters
		{
			get
			{
				return _counters;
			}
		}
		#endregion




		#region Constructor/Destructor 




		#endregion




		#region Methods
		public void ConfigureThread()
		{
			// add it...
			CallContext.SetData(SecurityTokenSlotName, new ContextToken(SecurityToken));
		}
		#endregion




	}
}






