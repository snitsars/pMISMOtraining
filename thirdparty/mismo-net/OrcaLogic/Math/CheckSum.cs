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

namespace OrcaLogic.Math
{
	/// <summary>
	/// A class that handles generation and processing of check sums.
	/// </summary>
	public sealed class CheckSum
	{
		private CheckSum()
		{
			//
			// private methods prevent instancing
			//
		}

		
		/// <summary>
		/// Generates a checksum.
		/// </summary>
		/// <param name="buffer">The buffer to generate a checksum from.</param>
		/// <returns>A check sum value.</returns>
		public static UInt16 Generate( byte[] buffer )
		{
			UInt16[] ckarray = OrcaLogic.Collections.ArrayConverter.ToUInt16(buffer);
			return Generate(ckarray, ckarray.Length);
		}


		/// <summary>
		/// Generates a checksum.
		/// </summary>
		/// <param name="buffer">The buffer to generate a checksum from.</param>
		/// <param name="size">The size of the buffer to generate a checksum from.</param>
		/// <returns>A check sum value.</returns>
		public static UInt16 Generate( UInt16[] buffer, int size )
		{
			Int32 cksum = 0;
			int counter;
			counter = 0;

			while ( size > 0 ) 
			{
				UInt16 val = buffer[counter];

				cksum += Convert.ToInt32( buffer[counter] );
				counter += 1;
				size -= 1;
			}

			cksum = (cksum >> 16) + (cksum & 0xffff);
			cksum += (cksum >> 16);
			return (UInt16)(~cksum);
		}
	}
}
