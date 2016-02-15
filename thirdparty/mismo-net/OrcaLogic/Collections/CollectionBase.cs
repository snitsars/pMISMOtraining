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
using System.Reflection;

namespace OrcaLogic.Collections
{
	/// <summary>
	/// A class that represents a collection base.
	/// </summary>
	public class CollectionBase : System.Collections.CollectionBase
	{
		#region Inner Classes
		#endregion Inner Classes

		#region Member Fields
		#endregion Member Fields

		#region Constructors/Destructors
		#endregion Constructors/Destructors

		#region Properties
		#endregion Properties

		#region Methods

		/// <summary>
		/// Extracts the inner list from the System.Collections.CollectionBase.
		/// </summary>
		/// <param name="collection">The collection base to extract from.</param>
		/// <returns>An array list that is the inner list for a collection base object.</returns>
		public static System.Collections.ArrayList GetInnerList(System.Collections.CollectionBase collection)
		{
			// check to see if collection object is null
			if (collection == null) throw new ArgumentNullException("collection", "Unable to extract the inner list for a null collection."); 

			// declare the property member array
			PropertyInfo[] proparray;
			// get the object type
			Type objtype = collection.GetType();
			// Get the properties of the collection
			proparray = objtype.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

			// create a return variable for the inner list.
			System.Collections.ArrayList innerlist = null;

			// get the inner list
			for(int i = 0; i < proparray.Length; i++)
			{
				if (proparray[i].Name == "InnerList")
				{
					innerlist = proparray[i].GetValue(collection, null) as System.Collections.ArrayList;
					break;
				}
			}

			// return the inner list
			return innerlist;
		}

		#endregion Methods
	}
}
