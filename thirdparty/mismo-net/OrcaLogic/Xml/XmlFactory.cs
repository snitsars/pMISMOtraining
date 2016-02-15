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
using System.Reflection;
using OrcaLogic.Reflection;

namespace OrcaLogic.Xml
{
	/// <summary>
	/// A class that represents an Xml factory.
	/// </summary>
	public sealed class XmlFactory
	{
		private XmlFactory()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Creates a new xml document from any object.
		/// </summary>
		/// <param name="any">Any object.</param>
		/// <returns>An xml document.</returns>
		public static XmlDocument GenerateDocument(object any)
		{
			// if we do not have an object then return null
			if (any == null) return null;

			// attemp to convert the generic object to a factory element
			IXmlFactoryElement factoryelement = any as IXmlFactoryElement;

			// create a new instance of the document we are generating.
			XmlDocument xdoc = new XmlDocument();

			if (factoryelement != null)
				xdoc.LoadXml(string.Format("<{0} />", factoryelement.ElementName));
			else
				xdoc.LoadXml(string.Format("<{0} />", any.GetType().Name));

			// set the attributes of the element.
			SetAttributes(xdoc.DocumentElement, any);
			
			return xdoc;
		}

		/// <summary>
		/// Creates a new xml element from any object.
		/// </summary>
		/// <param name="containerElement">The container element for the </param>
		/// <param name="any">Any object.</param>
		/// <returns>An xml element.</returns>
		public static XmlElement GenerateElement(XmlElement containerElement, object any)
		{
			// throw an exception if we do not have a container.
			if (containerElement == null) throw new ArgumentNullException("containerElement", "A container element must be specified. Othwerwise, call method overload with an XmlDocument instead.");
			// if we do not have an object then return null
			if (any == null) return null;

			// attemp to convert the generic object to a factory element
			IXmlFactoryElement factoryelement = any as IXmlFactoryElement;

			XmlElement newelement = null;
				
			if (factoryelement != null)
				newelement = containerElement.OwnerDocument.CreateElement(factoryelement.ElementName);
			else
				newelement = containerElement.OwnerDocument.CreateElement(any.GetType().Name);

			// set the attributes of the element.
			SetAttributes(newelement, any);
			
			// add the child to the container element
			containerElement.AppendChild(newelement);

			return newelement;
		}

		/// <summary>
		/// Sets the attributes of the class element with its own attributes.
		/// </summary>
		/// <param name="classElement">The class element to set attributes for.</param>
		/// <param name="any">Any object.</param>
		private static void SetAttributes(XmlElement classElement, object any)
		{
			// attemp to convert the generic object to a factory element
			IXmlFactoryElement factoryelement = any as IXmlFactoryElement;

			PropertyTable properties = new PropertyTable(any, BindingFlags.Instance | BindingFlags.Public);
			PropertyInfo pinfo = null;
			bool continueprocessing = false;

			// add any additional attributes that can not be extracted from the object
			if (factoryelement != null)
			{
				System.Collections.Specialized.NameValueCollection additionalattribs = factoryelement.AdditionalAttributes;
				if (additionalattribs != null && additionalattribs.Count > 0)
				{
					for(int i = 0; i<additionalattribs.Count; i++)
					{
						classElement.SetAttribute(string.Format("{0}", additionalattribs.Keys[i]), string.Format("{0}", additionalattribs[additionalattribs.Keys[i]]));
					}
				}
			}


			System.Collections.DictionaryEntry dentry;

			// process all the property members
			foreach(string membername in properties.MemberNames)
			{
				dentry = new System.Collections.DictionaryEntry(membername, null);
				pinfo = properties[membername];
				if (pinfo != null)
				{
					try
					{
						dentry.Value = pinfo.GetValue(any, null);
					} 
					catch
					{
						dentry.Value = null;
					}
					if (factoryelement != null)
						continueprocessing = factoryelement.ProcessAttribute(ref dentry);
					else
						continueprocessing = true; // just keep going without constraints

					// if there is no reason to quit processing then set attributes.
					if (continueprocessing)
						classElement.SetAttribute(string.Format("{0}", dentry.Key), string.Format("{0}", dentry.Value));
				}
			}
		}
	}
}
