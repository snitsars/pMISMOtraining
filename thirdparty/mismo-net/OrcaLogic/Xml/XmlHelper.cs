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
using System.Xml;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OrcaLogic.Xml
{
	/// <summary>
	/// A class that represents an xml helper class.
	/// </summary>
	public sealed class XmlHelper
	{
		private XmlHelper()
		{

		}

		#region Methods


		/// <summary>
		/// Gets an xml attribute from the xpath navigator.
		/// </summary>
		/// <param name="xpathNavigator">An xpath navigator with the current node set to an attribute.</param>
		/// <returns>An xml attribute or null (Nothing) if it can't extract an xml attribute from the current navigator position.</returns>
		public static XmlAttribute GetAttribute(System.Xml.XPath.XPathNavigator xpathNavigator)
		{
			return ((IHasXmlNode) xpathNavigator).GetNode() as XmlAttribute;
		}

		/// <summary>
		/// XmlSerialize a object to string
		/// </summary>
		/// <param name="data">object</param>
		/// <returns>string</returns>
		public static string XmlSerializationToString(object data)
		{
			MemoryStream ms = new MemoryStream();
			XmlTextWriter xml = new XmlTextWriter(ms,Encoding.UTF8);
			//xml.Formatting = Formatting.Indented;
			XmlSerializer saveXML = new XmlSerializer(data.GetType());
			saveXML.Serialize(xml,data);
			ms.Seek(0,System.IO.SeekOrigin.Begin);
			StreamReader reader = new StreamReader(ms);
			string buf = reader.ReadToEnd();
			xml.Close();
			reader.Close(); 

			return buf;
		}

		/// <summary>
		/// XmlSerialize a object to stream
		/// </summary>
		/// <param name="data">object</param>
		/// <returns>stream</returns>
		public static System.IO.MemoryStream XmlSerializationToStream(object data)
		{
			MemoryStream ms = new MemoryStream();
			XmlTextWriter xml = new XmlTextWriter(ms,Encoding.UTF8);
			//xml.Formatting = Formatting.Indented;
			XmlSerializer saveXML = new XmlSerializer(data.GetType());
			saveXML.Serialize(xml,data);

			return ms;
		}

		#endregion Methods
	}
}
