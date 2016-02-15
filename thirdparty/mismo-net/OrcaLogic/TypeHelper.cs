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
	/// A class that represents type class of static type related helper functions.
	/// </summary>
	public sealed class TypeHelper
	{
		private TypeHelper()
		{
			//
			// prevent instancing
			//
		}

		#region Static Methods

		/// <summary>
		/// Checks to see if the type is a simple type.
		/// </summary>
		/// <param name="anytype">The type to verify if it is a simple type.</param>
		/// <returns>True if it is a simple type and false otherwise.</returns>
		/// <remarks>
		/// Simple types are primitive types and a handful of other simple framework types.
		/// </remarks>
		public static bool IsSimpleType(System.Type anytype)
		{
			// by default return the primitives
			if (anytype.IsPrimitive) return true;

			// if the primities do not return it....check the full name of the type 

			switch(anytype.FullName)
			{
				case "System.String":
				{
					return true;
				}
				case "System.DateTime":
				{
					return true;
				}
				case "System.Guid": 
				{
					return true;
				}
				case "System.Boolean": 
				{
					return true;
				}
				case "System.Byte":
				{
					return true;
				}
				case "System.SByte": 
				{
					return true;
				}
				case "System.Single":
				{
					return true;
				}
				case "System.UInt16":
				{
					return true;
				}
				case "System.UInt32":
				{
					return true;
				}
				case "System.UInt64":
				{
					return true;
				}
				case "System.Int16":
				{
					return true;
				}
				case "System.Int32":
				{
					return true;
				}
				case "System.Int64":
				{
					return true;
				}
				case "System.Double": 
				{
					return true;
				}
				case "System.Decimal": 
				{
					return true;
				}
				case "System.Char": 
				{
					return true;
				}
				default:
				{
					return false;
				}
			}
		}

		#endregion Static Methods
	}
}
