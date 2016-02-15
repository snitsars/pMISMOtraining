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
using System.Collections;

namespace OrcaLogic.Collections
{
	/// <summary>
	/// An abstract class that represents a sortable collection.
	/// </summary>
	/// <remarks>
	/// This class maintains an inner array list. It is intended to
	/// be abstract so that consuming developers are forced to implement
	/// their own update and indexor methods for specific collections.
	/// </remarks>
	public abstract class SortableCollection : CollectionBase
	{
		#region Inner classes

		/// <summary>
		/// A class that represents a sorting comparer for the sortable collection
		/// </summary>
		private class SortableComparer : System.Collections.IComparer 
		{
			Type _sortobjtype = null;
			string [] _properties = null;

			/// <summary>
			/// Creates a new comparer instance from an object and property names.
			/// </summary>
			/// <param name="SortCollectionObject">An object from the sortable collection instance.</param>
			/// <param name="PropertyNames">An array of property names.</param>
			public SortableComparer(object SortCollectionObject, string[] PropertyNames)
			{
				_sortobjtype = SortCollectionObject.GetType();
				_properties = PropertyNames;
			}
			
			/// <summary>
			/// Compares two objects and returns a value indicating whether one is less than, equal to or greater than the other.
			/// </summary>
			/// <param name="obj1">First object to compare.</param>
			/// <param name="obj2">Second object to compare.</param>
			/// <seealso cref="System.Collections.IComparer" />
			/// <returns>See IComparer.Compare.</returns>
			public int Compare(object obj1, object obj2) 
			{
				// do null comparisons on objects first
				if (obj1 == null && obj2 == null) return 0;
				if (obj1 == null) return -1;
				if (obj2 == null) return 1;
				if (obj1 == obj2) return 0;

				// store their types
				Type type1 = obj1.GetType();
				Type type2 = obj2.GetType();

				// if both are of the sortable object type compare them
				if (type1.Name == _sortobjtype.Name && type2.Name == _sortobjtype.Name)
					return this.CompareSortableObjects(obj1, obj2);
				
				// if obj1 is a sortable type then try to compare it with a comparable of the other
				if (type1.Name == _sortobjtype.Name && type2.Name != _sortobjtype.Name)
					return this.CompareToSortableObject(obj2 as IComparable, obj1);

				// if obj2 is a sortable type then try to compare it with a comparable of the other
				if (type1.Name != _sortobjtype.Name && type2.Name == _sortobjtype.Name)
					return this.CompareToSortableObject(obj1 as IComparable, obj2);

				// since they aren't sortable object types
				// try and compare them.
				IComparable compare1 = obj1 as IComparable;
				IComparable compare2 = obj2 as IComparable;

				if (compare1 == null && compare2 == null) return 0; // they can't both be compared
				if (compare1 == null) return -1;
				if (compare2 == null) return 1;

				// simply return the comparison of both
				return compare1.CompareTo(compare2);
			}
		
			/// <summary>
			/// Compare the sortable objects.
			/// </summary>
			/// <param name="obj1">The first object to compare.</param>
			/// <param name="obj2">The second object to compare.</param>
			/// <returns>The comparison result.</returns>
			private int CompareSortableObjects(object obj1, object obj2) 
			{
				int compareresult = 0;
				IComparable val1, val2;

				for(int i = 0; i<_properties.Length; i++)
				{
					val1 = _sortobjtype.GetProperty(_properties[i]).GetValue(obj1, null) as IComparable;
					val2 = _sortobjtype.GetProperty(_properties[i]).GetValue(obj2, null) as IComparable;
					if (val1 == null || val2 == null )
						throw new Exception("A specified member could not be compared during searching/sorting. Make sure that their values are primitives or that they implement IComparable!");
					compareresult = val1.CompareTo(val2);
					if (compareresult != 0) break;
				}

				return compareresult;
			}
			
			/// <summary>
			/// Compares a generic object to a sortable object instance.
			/// </summary>
			/// <param name="someobject">Any object.</param>
			/// <param name="SortableObject">A member of the sortable collection.</param>
			/// <returns>Less than zero if it is less than, zero if equal, and greater than zero if greater than.</returns>
			private int CompareToSortableObject(IComparable someobject, object SortableObject) 
			{
				int compareresult = 0;
				IComparable SortableValue;

				for(int i = 0; i<_properties.Length; i++)
				{
					SortableValue = _sortobjtype.GetProperty(_properties[i]).GetValue(SortableObject, null) as IComparable;
					if (SortableValue == null || someobject == null )
						throw new Exception("A comparing item could not be compared during searching/sorting. Make sure that their values are primitives or that they implement IComparable!");
					compareresult = SortableValue.CompareTo(someobject);
					if (compareresult != 0) break;
				}

				return compareresult;
			}
		}

		#endregion

		#region Fields

		/// <summary>
		/// Stores the sorted state of the collection instance.
		/// </summary>
		protected bool _sorted = false;
		/// <summary>
		/// An array of properties that we have sorted on.
		/// </summary>
		private string[] _sortedproperties = null;

		#endregion

		#region Constructors/Destructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		protected SortableCollection() {}

		#endregion

		#region Properties

		/// <summary>
		/// Returns true if the collection is sorted and false otherwise.
		/// </summary>
		public bool Sorted { get { return _sorted; } }

		#endregion

		#region Methods/Functions

		/// <summary>
		/// Reverses the order of items in the collection.
		/// </summary>
		public void Reverse() 
		{
			this.InnerList.Reverse();
		}

		/// <summary>
		/// Sorts a sortable collection by the specified properties.
		/// </summary>
		/// <param name="PropertyNames">The properties to sort by.</param>
		public void Sort(params string[] PropertyNames)
		{
			if (PropertyNames == null || PropertyNames.Length < 1) throw new Exception("To sort a sortable collection, you must specify at least one property that the collection should sort on.");

			if (InnerList.Count > 0)
				InnerList.Sort(new SortableComparer(InnerList[0], PropertyNames));

			// the array of property names we are sorting on. (stored for future usage).
			_sortedproperties = PropertyNames;

			// the arraylist is now sorted.
			_sorted = true;
		}
	
		/// <summary>
		/// Performs a binary search on the collection.
		/// </summary>
		/// <param name="match">The match object to search for.</param>
		/// <returns>The match index if found othewise it returns the bitwise complement of the nearest match.</returns>
		public int BinarySearch(object match)
		{
			if (!this.Sorted) throw new Exception("The collection must be sorted before a binary search is called!");

			// if there aren't any items
			if (InnerList == null) return -1;
			if (InnerList.Count == 0) return -1;
			// do a binary search on the inner list.
			return InnerList.BinarySearch(match, new SortableComparer(InnerList[0], _sortedproperties));
		}


		#endregion

	}
}
