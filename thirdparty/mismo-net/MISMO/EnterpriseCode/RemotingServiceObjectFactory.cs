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
using System.Text;




namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// Summary description for RemoteServiceObjectFactory.
	/// </summary>
	public class RemotingServiceObjectFactory : ServiceObjectFactory
	{
		// members...
		public RemotingChannelType ChannelType = RemotingChannelType.Tcp;
		public string RemoteAppName;
		public string RemoteServerName;
		public int RemotePort;




		// enum...
		public enum RemotingChannelType { Tcp = 0, Http };








		public RemotingServiceObjectFactory()
		{
			// go through the parts...
			foreach(string part in EnterpriseApplication.Application.ConnectionStringParts.Keys)
			{
				// check...
				switch(part.ToLower())
				{
					case "appname":
						RemoteAppName = (string)EnterpriseApplication.Application.ConnectionStringParts[part];
						break;
					case "servername":
						RemoteServerName = (string)EnterpriseApplication.Application.ConnectionStringParts[part];
						break;
					case "port":
						RemotePort = Int32.Parse((string)EnterpriseApplication.Application.ConnectionStringParts[part]);
						break;
					case "protocol":
						string protocol = (string)EnterpriseApplication.Application.ConnectionStringParts[part];
					switch(protocol.ToLower())
					{
						case "tcp":
							ChannelType = RemotingChannelType.Tcp;
							break;
						case "http":
							ChannelType = RemotingChannelType.Http;
							break;
						default:
							throw new NotSupportedException("Channel type '" + protocol + "' not supported.");
					}
						break;
				}
			}




			// did we get everything?
			if(RemoteAppName == "")
				throw new RemotingConnectionException("You must provide a remote application name");
			if(RemoteServerName == "")
				throw new RemotingConnectionException("You must provide a remote server name");
			if(RemotePort == 0)
				throw new RemotingConnectionException("You must provide a remote port");
		}
	
		public override Service Create(Type serviceObjectType)
		{
			// get the url...
			string url = GetRemotingUrl(serviceObjectType);
			Service serviceObject = (Service)System.Activator.GetObject(serviceObjectType, url);




			// return it...
			return serviceObject;
		}




		public override string ToString()
		{
			return "Remoting";
		}




		public string GetRemotingUrl(Type serviceObjectType)
		{
			// create it...
			StringBuilder url = new StringBuilder();
			switch(ChannelType)
			{
				case RemotingChannelType.Tcp:
					url.Append("tcp");
					break;
				case RemotingChannelType.Http:
					url.Append("http");
					break;
				default:
					throw new NotSupportedException("Remoting channel type '" + ChannelType + "' not supported.");
			}




			// append...
			url.Append("://");
			url.Append(RemoteServerName);
			url.Append(":");
			url.Append(RemotePort.ToString());
			url.Append("/");
			url.Append(RemoteAppName);
			url.Append("/");
			url.Append(serviceObjectType.ToString());
			url.Append(".remote");




			// return...
			return url.ToString();
		}
	}
}






