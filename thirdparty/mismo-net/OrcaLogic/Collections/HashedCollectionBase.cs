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
using System.Runtime.Serialization;

namespace OrcaLogic.Collections
{
	/// <summary>
	/// A class that represents a collection base with an internal hash table.
	/// </summary>
	/// <remarks>
	/// A hashed collection base contains both an inner list and a hash table. To properly consume this
	/// abstract class, one must implement the abstract GetKeyFromObject() method to extract keys
	/// from stored objects. This also means that this class supports objects of consistent types. It will
	/// not support multiple class hierarchies.
	/// </remarks>
	[Serializable]
	public abstract class HashedCollectionBase : CollectionBase, ISerializable
	{
		#region Member Fields

		/// <summary>
		/// Member that stores a reference to the inner hash table.
		/// </summary>
		protected readonly Hashtable InnerHash = new Hashtable();

		#endregion Member Fields

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HashedCollectionBase()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// The deserialization constructor.
		/// </summary>
		/// <param name="info">The serialization info.</param>
		/// <param name="context">The streaming context.</param>
		protected HashedCollectionBase(SerializationInfo info, StreamingContext context)
		{
			object[] objs = info.GetValue("items", typeof(object[])) as object[];
			
			for(int i = 0; i<objs.Length; i++)
			{
				List.Add(objs[i]);
			}
		}


		#endregion Constructors

		#region Properties


		#endregion Properties

		#region Methods

		/// <summary>
		/// Called after the completion of an insert for additional processing by the HashedCollectionBase.
		/// </summary>
		/// <param name="index">The index that it was inserted at.</param>
		/// <param name="value">The value being inserted.</param>
		protected override void OnInsertComplete(int index, object value)
		{
			base.OnInsertComplete(index, value);
			if (value == null) throw new ArgumentNullException("value", "A HashedCollectionBase can not handle managing null values in hashed indexes.");
			object key = GetKeyFromObject(value);
			if (InnerHash.Contains(key))
			{
				throw new ArgumentException("A HashedCollectionBase can not handle duplicate key indexes. A collision has been detected.", "value");
			}
			
			InnerHash[key] = value;
		}


		/// <summary>
		/// Called after the completion of a removal for additional processing by the HashedCollectionBase.
		/// </summary>
		/// <param name="index">The index of the item being removed.</param>
		/// <param name="value">The value of the object at the specified index of removal.</param>
		protected override void OnRemoveComplete(int index, object value)
		{
			base.OnRemoveComplete(index, value);
			if (value == null) throw new ArgumentNullException("value", "A HashedCollectionBase can not handle managing null values in hashed indexes.");
			object key = GetKeyFromObject(value);
			InnerHash.Remove(key);
		}

		/// <summary>
		/// Called after the completion of "set" for additional processing by the HashedCollectionBase.
		/// </summary>
		/// <param name="index">The index at which the set operation is processed for.</param>
		/// <param name="oldValue">The old value before replacement.</param>
		/// <param name="newValue">The new value after replacement.</param>
		protected override void OnSetComplete(int index, object oldValue, object newValue)
		{
			base.OnSetComplete (index, oldValue, newValue);
			InnerHash[GetKeyFromObject(oldValue)] = newValue;
		}

		/// <summary>
		/// Gets the object in the collection by key.
		/// </summary>
		/// <param name="key">The key to get the object by.</param>
		/// <returns>The object referenced by the specified key.</returns>
		protected object GetByKey(object key)
		{
			return InnerHash[key];
		}

		/// <summary>
		/// Sets the object value by the specified key.
		/// </summary>
		/// <param name="key">The key to set the value at.</param>
		/// <param name="value">The value to set.</param>
		protected void SetByKey(object key, object value)
		{
			int listindex = IndexOf(key);
			InnerHash[key] = value; 
			if (listindex >= 0 && InnerList.Count >= 0) InnerList[listindex] = value;
		}

		/// <summary>
		/// Gets the index if the object with specified key.
		/// </summary>
		/// <param name="key">The key to obtain the item in the collection.</param>
		/// <returns>The index if it is valid in the collection, otherwise it returns less than zero.</returns>
		public virtual int IndexOf(object key)
		{
			object colobj = InnerHash[key];
			if (colobj == null) return -1;
			return List.IndexOf(colobj);
		}


		/// <summary>
		/// Determines if the hashed collection base contains the specified key.
		/// </summary>
		/// <param name="key">The key to check for existence.</param>
		/// <returns>True if contained and false otherwise.</returns>
		public bool ContainsKey(object key)
		{
			return InnerHash.ContainsKey(key);
		}

		/// <summary>
		/// Determines if the hashed collection base contains the specified object.
		/// </summary>
		/// <param name="any">Any object to check.</param>
		/// <returns>True if contained and false otherwise.</returns>
		public bool Contains(object any) 
		{
			object key = this.GetKeyFromObject(any);
			if (key == null) return false;
			return ContainsKey(key);
		}

		/// <summary>
		/// Gets the key value from the object.
		/// </summary>
		/// <param name="obj">The object to extract a key value from.</param>
		/// <returns>The key of the object obj.</returns>
		protected abstract object GetKeyFromObject(object obj);

		#endregion Methods

		#region ISerializable Members

		/// <summary>
		/// Gets the object data and adds it to the serialization info.
		/// </summary>
		/// <param name="info">The serialization info object.</param>
		/// <param name="context">The streaming context.</param>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			object[] objs = InnerList.ToArray();
			info.AddValue("items", objs);
		}

		#endregion
	}
}
