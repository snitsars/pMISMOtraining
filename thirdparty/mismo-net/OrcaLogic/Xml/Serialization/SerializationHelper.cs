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

namespace OrcaLogic.Xml.Serialization
{
	/// <summary>
	/// A class that represents utility serialization methods.
	/// </summary>
	public sealed class SerializationHelper
	{
		private SerializationHelper()
		{
			//
			// private can not be instanced
			//
		}

		/// <summary>
		/// Generates a check sum from the serializable object.
		/// </summary>
		/// <param name="any">Any object that can be serialized.</param>
		/// <returns>A check sum.</returns>
		public static UInt16 GenerateCheckSum(object any)
		{
			System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(any.GetType());
			System.IO.MemoryStream ms = new System.IO.MemoryStream();

			xser.Serialize(ms, any);
			ms.Seek(0, System.IO.SeekOrigin.Begin);

			byte[] streambytes = new byte[ms.Length];
			ms.Read(streambytes, 0, streambytes.Length);
			UInt16[] ckarray = OrcaLogic.Collections.ArrayConverter.ToUInt16(streambytes);
			ms.Close();

			ms = null;
			return OrcaLogic.Math.CheckSum.Generate(ckarray, ckarray.Length);
		}
	}
}
