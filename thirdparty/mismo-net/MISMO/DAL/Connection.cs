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


namespace MISMO.DAL
{
	/// <summary>
	/// A class that stores the connection information.
	/// </summary>
	public class Connection
	{

		#region Constructors

		/// <summary>
		/// Default Constructor. (private prevents instancing)
		/// </summary>
		private Connection()
		{
		}

		#endregion Constructors


		#region Static Properties

		/// <summary>
		/// Member that stores the connection string.
		/// </summary>
		private static System.String _cnnstring = null;
		/// <summary>
		/// Gets or sets the connection string information used in the DAL.
		/// </summary>
		public static System.String String
		{
			get
			{
				return _cnnstring;
			}
			set
			{
				_cnnstring = value;
				MISMO.EnterpriseCode.EnterpriseApplication.Application.ConnectionString = value;
			}
		}

		#endregion Static Properties

	}
}
