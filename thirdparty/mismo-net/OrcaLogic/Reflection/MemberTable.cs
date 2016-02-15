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
using System.Reflection;

namespace OrcaLogic.Reflection
{
	/// <summary>
	/// A class that represents an abstract member table collection.
	/// </summary>
	public abstract class MemberTable : IMemberTable, ICollection
	{
		#region Inner Classes
	       
		#endregion Inner Classes
	           
		#region Member Fields
	  
		/// <summary>
		/// The inner hash that manages the members in a table.
		/// </summary>
		protected System.Collections.Hashtable _innerhash = new System.Collections.Hashtable(2);
		/// <summary>
		/// The variable array of simple members.
		/// </summary>
		protected object[] _simplemembers = null;
		/// <summary>
		/// Member that stores the binding flag configuraiton of the reflection tables.
		/// </summary>
		protected System.Reflection.BindingFlags _bindflags = (BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

	
		#endregion Member Fields
		               
		#region Constructor/Destructor
		         
		
		/// <summary>
		/// Creates a new instance of the reflection table that will map members of a particular object.
		/// </summary>
		/// <param name="ReflectionObject">The object that is being reflected.</param>
		public MemberTable(object ReflectionObject) : this(ReflectionObject, (BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public)) 
		{
		}

		/// <summary>
		/// Creates a new instance of the reflection table that will map members of a particular object.
		/// </summary>
		/// <param name="ReflectionObject">The object that is being reflected.</param>
		/// <param name="bindingFlags">The specific binding flag attributes of the reflection table.</param>
		public MemberTable(object ReflectionObject, System.Reflection.BindingFlags bindingFlags) 
		{
			_type = ReflectionObject.GetType();
			_bindflags = bindingFlags;
		}

		#endregion Constructor/Destructor	                       
		               
		#region Methods
	
		#endregion Methods
	
		#region Properties

		/// <summary>
		/// The name of the members in the member table.
		/// </summary>
		public ICollection MemberNames
		{
			get 
			{ 
				return _innerhash.Keys;
			}
		}

		#endregion Properties

		#region IMemberTable Members

		/// <summary>
		/// 
		/// </summary>
		public int Count
		{
			get { return _innerhash.Count; }
		}

		System.Reflection.MemberInfo IMemberTable.this[string MemberName]
		{
			get
			{
				// TODO:  Add MemberTable.this getter implementation
				return _innerhash[MemberName] as MemberInfo;
			}
			set
			{
				_innerhash[MemberName] = value;
			}
		}

		void IMemberTable.Add(string MemberName, System.Reflection.MemberInfo value)
		{
			_innerhash.Add(MemberName, value);
		}

		void IMemberTable.Remove(string MemberName)
		{
			_innerhash.Remove(MemberName);
		}

		/// <summary>
		/// The type that the member table is reflecting for.
		/// </summary>
		protected System.Type _type;
		/// <summary>
		/// The type that the member table is reflecting for.
		/// </summary>
		public System.Type Type 
		{
			get { return _type; }
		}

		#endregion

		#region ICollection Members

		/// <summary>
		/// Gets a value indicating whether access to the reflection table is synchronized (thread-safe).
		/// </summary>
		public bool IsSynchronized
		{
			get
			{
				return _innerhash.IsSynchronized;
			}
		}

		void ICollection.CopyTo(Array array, int index)
		{
			_innerhash.CopyTo(array, index);
		}

		/// <summary>
		/// Gets an object that can be used to syncronize access to the reflection table.
		/// </summary>
		public object SyncRoot
		{
			get
			{
				return _innerhash.SyncRoot;
			}
		}

		#endregion

		#region IEnumerable Members

		/// <summary>
		/// Returns a dictionary enumerator that will enable enumerating objects in the member collection.
		/// </summary>
		/// <returns>An IEnumerator object instance.</returns>
		public IEnumerator GetEnumerator()
		{
			return _innerhash.GetEnumerator();
		}

		#endregion
	}
}
