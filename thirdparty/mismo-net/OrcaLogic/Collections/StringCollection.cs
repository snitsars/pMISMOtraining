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
	/// A class that represents a simple collection of strings strongly typed.
	/// </summary>
	public class StringCollection : CollectionBase
	{
		/// <summary>
		/// Creates a new string collection from an existing string collection.
		/// </summary>
		/// <param name="c">The existing string collection to create a new instance from.</param>
		public StringCollection(StringCollection c)
		{
			InnerList.AddRange(c);
		}

		/// <summary>
		/// Create a new string collection with a specified capacity.
		/// </summary>
		/// <param name="Capacity">The initial capacity of the string collection.</param>
		public StringCollection(int Capacity)
		{
			InnerList.Capacity = Capacity;
		}


		/// <summary>
		/// Default constructor.
		/// </summary>
		public StringCollection() : base() {}


		#region Methods

		/// <summary>
		/// Copies the contents of the collection to a target array at the specified index.
		/// </summary>
		/// <param name="array">The target array.</param>
		/// <param name="arrayIndex">The index to begin copying.</param>
		public void CopyTo(System.Array array, int arrayIndex) 
		{
			if (!(array is string[])) throw new ArgumentException("Invalid target array type. It must be a string array.", "array");
			InnerList.CopyTo(array, arrayIndex);
		}

		public void Insert(int index, object value) 
		{
			if (!(value is string)) throw new ArgumentException("Invalid insertion value. The value must be of the string type.", "value");
			InnerList.Insert(index, value);
		}


		public int Add(string stringItem) 
		{
			_sorted = false;
			return InnerList.Add(stringItem);
		}

		public void AddRange(StringCollection c) 
		{
			if (c == null || c.Count == 0) return; // do nothing
			_sorted = false;
			InnerList.AddRange(c);
		}

		public void AddRange(string[] strings) 
		{
			if (strings == null || strings.Length == 0) return; // do nothing
			_sorted = false;
			InnerList.AddRange(strings);
		}


		public int BinarySearch(string stringValue) 
		{
			if (!_sorted) InnerList.Sort();
			return InnerList.BinarySearch(stringValue);
		}

		public void Remove(string stringItem) 
		{
			InnerList.Remove(stringItem);
		}

		public string[] ToArray() 
		{
			return InnerList.ToArray(typeof(System.String)) as string[];
		}

		public override string ToString()
		{
			return ToString("\r\n");
		}

		public string ToString(char c)
		{
			return ToString(c.ToString());
		}

		public string ToString(string delimeter) 
		{
			if (delimeter == null) delimeter = string.Empty;

			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			for(int i = 0; i<InnerList.Count; i++)
			{
				if (i<this.Count - 1)
					sb.Append(string.Format("{0}{1}",this[i],delimeter));
				else
					sb.Append(this[i]);
			}

			return sb.ToString();
		}

		#endregion Methods

		#region Properties

		private bool _sorted = false;
		public bool Sorted 
		{
			get { return _sorted; }
		}

		public int Capacity 
		{
			get { return InnerList.Capacity; }
			set { InnerList.Capacity = value; }
		}

		public string this[int index] 
		{
			get { return InnerList[index] as string; }
			set 
			{ 
				InnerList[index] = value;
				_sorted = false; // the setting of this value could mean that the sort is off
			}
		}

		#endregion Properties
	}
}
