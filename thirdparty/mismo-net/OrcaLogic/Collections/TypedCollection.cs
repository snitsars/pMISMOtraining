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
using OrcaLogic.Reflection;
using System.Reflection;


namespace OrcaLogic.Collections
{
	/// <summary>
	/// A class that represents an abstract set of strongly typed collection objects.
	/// </summary>
	/// <remarks>
	/// A collection must implement the Contains type property. When adding add and remove methods,
	/// the descendant collection must call the internal add, remove, and replace methods for preserving the strict
	/// support of the typed collection.
	/// </remarks>
	public abstract class TypedCollection : SortableCollection, ITypedCollection, ICloneable
	{
		#region Members

		#endregion Members

		#region Properties

		#endregion Properties

		#region Methods

		/// <summary>
		/// Internally adds an object to the inner list.
		/// </summary>
		/// <param name="any">Any object to add to the list of objects.</param>
		/// <returns>The index value to where the object was added.</returns>
		/// <remarks>
		/// Since additions may throw off a sort of the current collection, it is marked as not sorted when
		/// any new elements are added to the collection.
		/// </remarks>
		protected int InnerAdd(object any) 
		{
			// check to see if the object is a supported type.
			if (!IsTypeSupported(any)) throw new ArgumentException(any.GetType().FullName + " is not a supported type for this collection.");
			_sorted = false; // additions will throw of the sort.
			return InnerList.Add(any);
		}

		/// <summary>
		/// Internally removes an object to the inner list.
		/// </summary>
		/// <param name="any">An object to remove from the list of objects.</param>
		protected void InnerRemove(object any) 
		{
			// check to see if the object is a supported type
			if (!IsTypeSupported(any)) throw new ArgumentException(any.GetType().FullName + " is not a supported type for this collection.");
			InnerList.Remove(any); // do not need to mark it as unsorted since removals do not mess up a sort.
		}

		/// <summary>
		/// Internally replaces an object at the specified index with another object.
		/// </summary>
		/// <param name="index">The index of the existing object to replace.</param>
		/// <param name="any">An object to replace at the specified index.</param>
		protected void InnerReplace(int index, object any) 
		{
			// check to see if the object is a supported type
			if (!IsTypeSupported(any)) throw new ArgumentException(any.GetType().FullName + " is not a supported type for this collection.");
			InnerList[index] = any; // do not need to mark it as unsorted since removals do not mess up a sort.
			// the replacement could possibly throw off a sort so mark it as unsorted.
			_sorted = false;
		}

		/// <summary>
		/// Convert collection to dataset.
		/// </summary>
		/// <returns>DataSet</returns>
		public System.Data.DataSet ToDataSet()
		{
			System.Data.DataSet ds = new System.Data.DataSet();
			
			for (int i=0; i<ContainsType.Length; i++)
			{
				ds.Tables.Add(new System.Data.DataTable(ContainsType[i].Name));
				System.Data.DataTable dt = ds.Tables[i];
				for (int j=0; j<this.InnerList.Count; j++)
				{
					if (this.InnerList[j].GetType() == ContainsType[i])
					{
						OrcaLogic.Reflection.PropertyTable pt = OrcaLogic.Reflection.ReflectionHelper.GetProperties(InnerList[j]);
						PropertyInfo[] propertyInfo = pt.GetSimpleMembers();			
						if (dt.Columns.Count == 0)
							BuildColumnCollection(propertyInfo, dt);

						System.Data.DataRow dr = dt.NewRow();
						dr.ItemArray = this.GetItemArray(propertyInfo, this.InnerList[j]);
						dt.Rows.Add(dr);
					}
				}
			}

			ds.AcceptChanges();

			return ds;
			
		}

		/// <summary>
		/// Build column collection for specific DataTable
		/// </summary>
		/// <param name="propertyInfo">PropertyInfo array</param>
		/// <param name="dt">DataTable</param>
		private void BuildColumnCollection(PropertyInfo[] propertyInfo, System.Data.DataTable dt)
		{
			for(int i=0;i<propertyInfo.Length;i++)
			{
				dt.Columns.Add(propertyInfo[i].Name, propertyInfo[i].PropertyType);
			}
		}

		/// <summary>
		/// Get item array from PropertyInfo array
		/// </summary>
		/// <param name="propertyInfo">PropertyInfo array</param>
		/// <returns>Object array</returns>
		/// <param name="o">object</param>
		private object[] GetItemArray(PropertyInfo[] propertyInfo, object o)
		{
			object[] itemArray = new object[propertyInfo.Length];
			
			// Display information for all properties.
			for(int i=0;i<propertyInfo.Length;i++)
			{
				itemArray[i] = propertyInfo[i].GetValue(o,null);
			}
			return itemArray;
		}

		#endregion Methods

		#region ITypedCollection Members

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		abstract public Type[] ContainsType { get; }

		//abstract public Type ContainsType { get; }

		/// <summary>
		/// Returns the supported state of any object interfaces with the colleciton.
		/// </summary>
		/// <param name="any">Any object to interface with the collection store.</param>
		/// <returns>True if the object is supported and false otherwise.</returns>
		/// <remarks>
		/// A null object will not be supported even if it is defined as the same type.
		/// </remarks>
		public bool IsTypeSupported(object any)
		{
			if (any == null) return false;
			return IsTypeSupported(any.GetType());
			
		}

		/// <summary>
		/// Returns the supported state of any object interfaces with the colleciton.
		/// </summary>
		/// <param name="typeFullName">The type to that we would like to see if it supports.</param>
		/// <returns>True if the type is supported and false otherwise.</returns>
		/// <remarks>
		/// A null object will not be supported even if it is defined as the same type.
		/// </remarks>
		public bool IsTypeSupported(string typeFullName)
		{
			if (typeFullName == string.Empty) return false;
			return IsTypeSupported(Type.GetType(typeFullName));
		}

		/// <summary>
		/// Returns the supported state of any object interfaces with the colleciton.
		/// </summary>
		/// <param name="type">The type to that we would like to see if it supports.</param>
		/// <returns>True if the type is supported and false otherwise.</returns>
		/// <remarks>
		/// A null object will not be supported even if it is defined as the same type.
		/// </remarks>
		public bool IsTypeSupported(System.Type type)
		{
			// if there is nothing then the type isn't supported because it isn't defined.
			if (ContainsType == null || ContainsType.Length == 0)
				return false;

			for(int i = 0; i<ContainsType.Length; i++)
			{
				if (ContainsType[i] != null && (ContainsType[i] == type || type.IsSubclassOf(ContainsType[0])))
					return true;
			}

//			foreach (Type type in ContainsType)
//			{
//				if (any != null && any.GetType() == type)
//				{
//					return true;
//				}
//			}

			return false;
			
		}

		/// <summary>
		/// Adds a strongly supported type item to the collection.
		/// </summary>
		/// <param name="any">The supported object to add.</param>
		int ITypedCollection.Add(object any) { return InnerAdd(any); }

		/// <summary>
		/// Removes a strongly types supported item from the collection.
		/// </summary>
		/// <param name="any">The supported object to remove.</param>
		void ITypedCollection.Remove(object any) { InnerRemove(any); }

		/// <summary>
		/// Gets or sets the item at the specified index of the collection.
		/// </summary>
		object ITypedCollection.this[int index] 
		{
			get { return InnerList[index]; }
			set { InnerReplace(index, value); }
		}

		#endregion

		#region ICloneable Members

		/// <summary>
		/// Creates a shallow copy of the TypedCollection.
		/// </summary>
		/// <returns>A new instance of the collection that is a shallow clone of the current instance.</returns>
		public TypedCollection Clone()
		{
			TypedCollection newtypedcollection = System.Activator.CreateInstance(this.GetType()) as TypedCollection;
			if (newtypedcollection != null) newtypedcollection.InnerList.AddRange(this.InnerList.Clone() as System.Collections.ArrayList);
			return newtypedcollection;
		}

		/// <summary>
		/// Creates a shallow copy of the TypedCollection.
		/// </summary>
		/// <returns>A new instance of the collection that is a shallow clone of the current instance.</returns>
		object ICloneable.Clone() 
		{
			return this.Clone();
		}

		#endregion
	}
}
