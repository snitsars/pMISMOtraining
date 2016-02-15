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
	/// A class that represents an extended array list.
	/// </summary>
	public class ArrayList : System.Collections.ArrayList
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public ArrayList() : base() {}

		#region Static Methods

		/// <summary>
		/// Gets a boolean that indicates that an object is contained within the arraylist.
		/// </summary>
		/// <param name="arraylist">The array list to search.</param>
		/// <param name="obj">The object to search.</param>
		/// <returns>True if contained and false otherwise.</returns>
		/// <remarks>
		/// Uses a comparer that will check internal content for equality if object references are not equal.
		/// </remarks>
		public static bool Contains(System.Collections.ArrayList arraylist, object obj)
		{
			return ArrayList.Contains(arraylist, obj, new OrcaLogic.Collections.Comparer(obj.GetType()));
		}

		/// <summary>
		/// Gets a boolean that indicates that an object is contained within the arraylist.
		/// </summary>
		/// <param name="arraylist">The array list to search.</param>
		/// <param name="obj">The object to search.</param>
		/// <param name="comparer">The comparer algorithm to use in the matching.</param>
		/// <returns>True if contained and false otherwise.</returns>
		public static bool Contains(System.Collections.ArrayList arraylist, object obj, System.Collections.IComparer comparer)
		{
			int matchindex = OrcaLogic.Collections.ArrayList.IndexOf(arraylist, obj, comparer);
			return (matchindex != -1);
		}

		/// <summary>
		/// Gets the index of the object in the specified arraylist.
		/// </summary>
		/// <param name="arraylist">The array list to obtain and index from.</param>
		/// <param name="obj">The object to obtain an index for.</param>
		/// <returns>The index of the object in the arraylist or -1 if not found.</returns>
		/// <remarks>
		/// Uses a comparer that will check internal content for equality if object references are not equal.
		/// </remarks>
		public static int IndexOf(System.Collections.ArrayList arraylist, object obj)
		{
			return ArrayList.IndexOf(arraylist, obj, new OrcaLogic.Collections.Comparer(obj.GetType()));
		}

		/// <summary>
		/// Gets the index of the object in the specified arraylist.
		/// </summary>
		/// <param name="arraylist">The array list to obtain and index from.</param>
		/// <param name="obj">The object to obtain an index for.</param>
		/// <param name="comparer">The comparer algorithm to use in the matching.</param>
		/// <returns>The index of the object in the arraylist or -1 if not found.</returns>
		public static int IndexOf(System.Collections.ArrayList arraylist, object obj, System.Collections.IComparer comparer) 
		{
			if (arraylist == null) throw new ArgumentNullException("arraylist", "Unable to get an index of a particular object for a null array list.");
			if (comparer == null) throw new ArgumentNullException("comparer", "Unable to get an index of a particular object with a null comparer reference");

			// object is not in the list because there are no items in the list.
			if (arraylist.Count == 0) return -1;
			
			// compare the single item to see if it matches.
			if (arraylist.Count == 1)
			{
				if (comparer.Compare(arraylist[0], obj) == 0) 
					return 0;
				else
					return -1;
			}

			// get a random generator to calcuate the starting iterative index.
			Random randgen = new Random();
			// get the random number between the indexes of the list for the search terminator
			int endsearch = randgen.Next(0, arraylist.Count - 1); 
			// store the array max index value
			int arraymax = arraylist.Count - 1;
			// the start index is one position from the termination index
			int index = (endsearch == arraymax ? 0 /* set to zero since at end */: endsearch + 1);
			// the terminator is the index...remember it
			int searchterminator = index;

			// while we haven't hit the termination index.
			// circulate through the arraylist.
			do
			{
				if (comparer.Compare(arraylist[index], obj) == 0)
					return index; // we have a match! return it
				else
					// increment index or set it to beginning
					index = (index == arraymax ? 0 /* set to zero since at end */: index + 1);
			} while (index != searchterminator);

			// if we haven't found anything yet....
			return -1;
		}

		#endregion Static Methods
	}
}
