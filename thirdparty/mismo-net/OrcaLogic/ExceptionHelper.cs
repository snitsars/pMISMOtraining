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

namespace OrcaLogic
{
	/// <summary>
	/// A class that represents a exception helper class.
	/// </summary>
	public sealed class ExceptionHelper
	{
		private ExceptionHelper()
		{
			//
			// prevent instancing
			//
		}

		#region Static Methods

		/// <summary>
		/// A data layer process exception helper method that parses exceptions and reroutes the exception to a 
		/// specific exception.
		/// </summary>
		/// <param name="exp">The exception to process.</param>
		/// <returns>The same exception if there are no processing to do and a new exception with the original exception as an inner exception.</returns>
		public static Exception Process(Exception exp) 
		{
			if (exp != null && exp.Message.StartsWith("Concurrency"))
				return new System.Data.DBConcurrencyException(exp.Message, exp);
			if (exp != null && exp.Message.StartsWith("Inherited exclusions"))
				return new ApplicationException(exp.Message, exp);
			else
				return exp;
		}

		#endregion
	}
}
