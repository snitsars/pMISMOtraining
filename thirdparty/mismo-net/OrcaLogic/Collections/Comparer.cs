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
	/// A class that represents a content comparer using reflection for extracting contents of objects.
	/// </summary>
	public class Comparer : System.Collections.IComparer
	{
		#region Member Fields
		
		/// <summary>
		/// Variable for the field array and information.
		/// </summary>
		FieldInfo[] _farray = null;
		/// <summary>
		/// Variable for the property array and information.
		/// </summary>
		PropertyInfo[] _parray = null;

		#endregion Member Fields

		#region Constructors/Destructors

		/// <summary>
		/// Creates a new instance of the comparer with the specified type.
		/// </summary>
		/// <param name="objectType">The object type to reflect internals for.</param>
		public Comparer(System.Type objectType)
		{
			// Get field members
			_farray = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			// Get the propery members.
			_parray = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
		}

		#endregion Constructors/Destructors

		#region Properties
		#endregion Properties

		#region Methods
		#endregion Methods

		#region IComparer Members

		/// <summary>
		/// Compares two objects to see if they are equal to each other.
		/// </summary>
		/// <param name="x">The first object to compare.</param>
		/// <param name="y">The second object to compare.</param>
		/// <returns>Returns -1 if x less than y, 0 if x equals y, 1 if x greater than y.</returns>
		/// <remarks>
		/// If the objects are of the same type and their references are not equal (different object instances), the system will first
		/// exhaust internal equality before it fails an equals to comparison.
		/// </remarks>
		public int Compare(object x, object y)
		{
			if (x == null && y == null) throw new NullReferenceException("Two null objects are not equal and can not be evaluated as less than or greater than.");
			
			// check nulls and direct equality
			if (x == null && y != null) return -1;
			if (y == null && x != null) return 1;
			if (y.Equals(x)) return 0;
			// if they aren't the same types...then simply try a compare on the ToString results.
			if (x.GetType() != y.GetType()) return x.ToString().CompareTo(y.ToString());

			// ASSUMING THE SAME TYPE NOW

			// now try and determine content equality
			int index = 0;
			IComparable cx = null;
			int comparetest = 0;
			object xobj = null;
			object yobj = null;

			// iterate and compare the fields first
			for(index = 0; index<_farray.Length; index++)
			{
				// get the values from the array
				xobj = _farray[index].GetValue(x);
				yobj = _farray[index].GetValue(y);

				// simply go to the next if they are equal
				if (xobj.Equals(yobj)) continue;

				// try the comparable test method
				cx = xobj as IComparable;
				if (cx != null) 
				{
					comparetest = cx.CompareTo(yobj);
					if (comparetest != 0) 
						return comparetest;
					else
						continue; // go to the next if they are equal
				}

				// if all else fails compare the tostring results
				comparetest = xobj.ToString().CompareTo(yobj.ToString());
				if (comparetest != 0)
					return comparetest;
				else
					continue;
			}


			// iterate and compare the properties
			for(index = 0; index<_parray.Length; index++)
			{
				// get the values from the array
				xobj = _parray[index].GetValue(x, null);
				yobj = _parray[index].GetValue(y, null);

				// simply go to the next if they are equal
				if (xobj.Equals(yobj)) continue;

				// try the comparable test method
				cx = xobj as IComparable;
				if (cx != null) 
				{
					comparetest = cx.CompareTo(yobj);
					if (comparetest != 0) 
						return comparetest;
					else
						continue; // go to the next if they are equal
				}

				// if all else fails compare the tostring results
				comparetest = xobj.ToString().CompareTo(yobj.ToString());
				if (comparetest != 0)
					return comparetest;
				else
					continue;
			}

			// all fields and properties are equal and thus we declare it so.
			return 0;
		}

		#endregion
	}
}
