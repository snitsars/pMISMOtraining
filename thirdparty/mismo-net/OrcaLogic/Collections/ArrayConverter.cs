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

namespace OrcaLogic.Collections
{
	/// <summary>
	/// A class that handler the conversion of arrays.
	/// </summary>
	public sealed class ArrayConverter
	{
		/// <summary>
		/// Private which prevents instancing.
		/// </summary>
		private ArrayConverter()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Converts a byte array to a short or unsigned 16-bit int array.
		/// </summary>
		/// <param name="bytes">The bytes to convert.</param>
		/// <returns>A new short or unsigned 16-bit int array</returns>
		public static UInt16[] ToUInt16(byte[] bytes)
		{
			int retlen = Convert.ToInt32(System.Math.Ceiling( (double) (bytes.Length / 2)));
			UInt16 [] retarray = new UInt16[retlen];
			// transfer from the bytes to the UInt16
			int sourceindex = 0;
			for( int i = 0; i < retlen; i++ ) 
			{
				retarray[i] =
					BitConverter.ToUInt16(bytes, sourceindex);
				sourceindex += 2;
			}

			return retarray;
		}
	}
}
