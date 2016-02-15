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
using System.Globalization;

namespace OrcaLogic
{
	/// <summary>
	/// A utility class that contains parsing helper methods.
	/// </summary>
	public sealed class ParsingHelper
	{
		private ParsingHelper()
		{
			//
			// prevents instancing
			//
		}

		#region Public Static Methods

		/// <summary>
		/// Gets the date truth of any object (to see if we can parse it as a date and time).
		/// </summary>
		/// <param name="anyDateFormat">Any object to test.</param>
		/// <returns>True if it is a date and false otherwise.</returns>
		public static bool IsDate(object anyDateFormat)
		{
			if (anyDateFormat is string)
				return IsDate(anyDateFormat as string);
			else
				return IsDate(anyDateFormat.ToString());
		}

		/// <summary>
		/// Gets the date truth of any string (to see if we can parse it as a date and time.
		/// </summary>
		/// <param name="anyDateFormat">Any string to test.</param>
		/// <returns>True if it is a date and false otherwise.</returns>
		public static bool IsDate(string anyDateFormat)
		{
			bool isdate = false; // assumption
			try
			{
				DateTime.Parse(anyDateFormat);
				isdate = true;
			}
			catch{}

			return isdate;
		}

		/// <summary>
		/// Gets the numeric truth of any object.
		/// </summary>
		/// <param name="any">Any object to test if it is numeric.</param>
		/// <returns>True if numeric and false otherwise.</returns>
		public static bool IsNumeric(object any)
		{
			System.Double parsed;
			return System.Double.TryParse(Convert.ToString(any), NumberStyles.Any, NumberFormatInfo.CurrentInfo, out parsed);
		}

		/// <summary>
		/// Gets the integer truth of any object.
		/// </summary>
		/// <param name="any">Any object to test if it is an integer.</param>
		/// <returns>True if integer and false otherwise.</returns>
		public static bool IsInteger(object any)
		{
			System.Double parsed;
			return System.Double.TryParse(Convert.ToString(any), NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out parsed);
		}		

		#endregion Public Static Methods
	}
}
