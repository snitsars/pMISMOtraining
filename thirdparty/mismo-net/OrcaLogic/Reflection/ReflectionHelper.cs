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

namespace OrcaLogic.Reflection
{
	/// <summary>
	/// A helper class for reflection.
	/// </summary>
	public sealed class ReflectionHelper
	{
		private static readonly System.Collections.Hashtable _fieldtable = new System.Collections.Hashtable();
		private static readonly System.Collections.Hashtable _proptable = new System.Collections.Hashtable();

		private ReflectionHelper()
		{
			//
			// prevents instancing
			//
		}

		#region Static Methods

		/// <summary>
		/// Gets a property hash table for quick lookup for any object.
		/// </summary>
		/// <param name="any">Any object to get a property table for.</param>
		/// <returns>A property table or null if unable to obtain a table.</returns>
		public static PropertyTable GetProperties(object any) 
		{
			PropertyTable match = null;

			lock(_proptable.SyncRoot)
			{
				// attempt to get a match
				match = _proptable[any.GetType()] as PropertyTable;
				// return it if we have one
				if (match != null) return match;
				// reflect the object into a new property table
				match = new PropertyTable(any);
				// cache it for future usage
                _proptable[any.GetType()] = match;
			}

			// return the match
			return match;
		}

		/// <summary>
		/// Gets a field hash table for quick lookup for any object.
		/// </summary>
		/// <param name="any">Any object to get a field table for.</param>
		/// <returns>A field table or null if unable to obtain a table.</returns>
		public static FieldTable GetFields(object any) 
		{
			FieldTable match = null;

			lock(_proptable.SyncRoot)
			{
				// attempt to get a match
				match = _fieldtable[any.GetType()] as FieldTable;
				// return it if we have one
				if (match != null) return match;
				// reflect the object into a new field table
				match = new FieldTable(any);
				// cache it for future usage
				_fieldtable[any.GetType()] = match;
			}

			// return the match
			return match;
		}


		/// <summary>
		/// Get the property value from an object instance.
		/// </summary>
		/// <param name="objectInstance">The object instance to get the property value for.</param>
		/// <param name="propertyName">The name of the property to get the value for.</param>
		/// <returns>The property's value.</returns>
		public static object GetPropertyValue(object objectInstance, string propertyName) 
		{
			// check to see if reflection object is null
			if (objectInstance == null) throw new ArgumentNullException("objectInstance", "Unable to extract values for a null object instance"); 

			PropertyTable proptable = GetProperties(objectInstance);
			PropertyInfo property = proptable[propertyName];

			if (property != null)
				return property.GetValue(objectInstance, null);

			// property can not be found so return null.
			return null;
		}

		/// <summary>
		/// Sets the value for a particular property.
		/// </summary>
		/// <param name="objectInstance">The object instance to set the property value for.</param>
		/// <param name="propertyName">The name of the property to set the value for.</param>
		/// <param name="value">The value to set.</param>
		public static void SetPropertyValue(object objectInstance, string propertyName, object value) 
		{
			// check to see if reflection object is null
			if (objectInstance == null) throw new ArgumentNullException("objectInstance", "Unable to set values for a null object instance"); 

			PropertyTable proptable = GetProperties(objectInstance);
			PropertyInfo property = proptable[propertyName];

			// if we have a valid property then set the value
			if (property != null)
				property.SetValue(objectInstance, value, null);
		}


		#endregion Static Methods
	}
}
