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
using System.Collections.Specialized;

namespace OrcaLogic.Collections
{
	/// <summary>
	/// Summary description for NameValueArrayList.
	/// </summary>
	public class NameValueArrayList : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.IList
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public NameValueArrayList():base()
		{
		}
		#region IList Members

		bool IList.IsReadOnly
		{
			get
			{
				return base.IsReadOnly;
			}
		}


		object IList.this[int index]
		{
			get 
			{
				return this[index];
			}
			set
			{
				this[index] = (NameValuePair)value;
			}
		}

		public void RemoveAt(int index)
		{
			this.BaseRemoveAt(index);
		}

		public void Insert(int index, object value)
		{
			throw new NotSupportedException("Insert not supported for this collection type.");
		}

		public void Remove(object value)
		{
			this.BaseRemove(value as string);
		}

		public bool Contains(object value)
		{
			for(int x = 0; x<this.Keys.Count; x++)
			{
				if (value == this.BaseGet(x)) return true;
			}
			return false;
		}

		public void Clear()
		{
			this.BaseClear();
		}

		public int IndexOf(object value)
		{
			if (value!=null)
			{
				NameValuePair nv = (NameValuePair)value;
				for(int x = 0; x<this.Keys.Count; x++)
				{
					NameValuePair nv2 = (NameValuePair)this.BaseGet(x);
					if (nv2.Value == nv.Value && nv2.Name == nv.Name) return x;
				}
			}
			return -1;
		}

		public int Add(object value)
		{
			NameValuePair nv = (NameValuePair)value;
			this.BaseAdd(nv.Name as string,nv);
			return this.IndexOf(nv);
		}

		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		#endregion

		#region ICollection Members

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public int Count
		{
			get
			{
				return base.Count;
			}
		}

		public void CopyTo(Array array, int index)
		{
			if (array.Length<(base.Count+index)) throw new ArgumentException("The number of elements in the source ICollection is greater than the available space from index to the end of the destination array.","array");
			if (index>=array.Length) throw new ArgumentException("index is equal to or greater than the length of array.","index");
			if (array.Rank>1) throw new ArgumentException("Array must not be multidimensional.","array");
			if (array==null) throw new NullReferenceException("Array must not be null");
			if (index<0) throw new ArgumentNullException("index","Index must not be less than zero.");
			if (!(array is DictionaryEntry [] || array is object[])) throw new InvalidCastException("Array type not supported.");

			for(int x = index; x<array.Length+index; x++)
			{
				array.SetValue(this[x],x);
			}

		}

		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		#endregion

		#region IEnumerable Members

		public IEnumerator GetEnumerator()
		{
			return base.GetEnumerator();
		}

		#endregion

		#region Properties

		public string [] AllKeys
		{
			get { return this.BaseGetAllKeys(); }
		}
		
		public NameValuePair this[int index]
		{
			get 
			{
				return (NameValuePair)this.BaseGet(index);
			}
			set
			{
				this.BaseSet(index,value.Value);
			}
		}
		
		public string this[string key]
		{
			get
			{
				if (this.BaseGet(key)==null) return null;
				else return ((NameValuePair)this.BaseGet(key)).Value as string;
			}
			set
			{
				if (this.BaseGet(key)!=null)
				{
					NameValuePair nv = (NameValuePair)this.BaseGet(key);
					nv.Value = value;
					this.BaseSet(key,nv);
				}
			}
		}

		#endregion
	}

	#region NameValuePair Class

	public class NameValuePair
	{
		public NameValuePair()
		{
		}

		public NameValuePair(string name, string value)
		{
            _name=name;
			_value=value;
		}

		string _name = string.Empty;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		string _value = string.Empty;
		public string Value
		{
			get { return _value; }
			set 
			{ 
				_value=value; 
			}
		}
	}
	#endregion
}
