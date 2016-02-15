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
	/// A class that represents a field table collection.
	/// </summary>
	/// <remarks>
	/// A field table is internally based on a hash table which provides quick lookup access
	/// to FieldInfo items.
	/// </remarks>
	public class FieldTable : MemberTable, IFieldTable
	{
		#region Inner Classes
	       
		#endregion Inner Classes
	           
		#region Member Fields
	
		#endregion Member Fields
		               
		#region Constructor/Destructor
		         

		/// <summary>
		/// Creates a new instance of the field table that will map members of a particular object.
		/// </summary>
		/// <param name="ReflectionObject">The object that is being reflected.</param>
		public FieldTable(object ReflectionObject) : this(ReflectionObject, (BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public))
		{

		}

		/// <summary>
		/// Creates a new instance of the field table that will map members of a particular object.
		/// </summary>
		/// <param name="ReflectionObject">The object that is being reflected.</param>
		/// <param name="bindingFlags">The specific binding flag attributes of the reflection table.</param>
		public FieldTable(object ReflectionObject, System.Reflection.BindingFlags bindingFlags) : base(ReflectionObject, bindingFlags)
		{
			// check to see if reflection object is null
			if (ReflectionObject == null) throw new ArgumentNullException("ReflectionObject", "Unable to create a field table for a null object instance"); 

			// declare the field member array
			FieldInfo[] fieldarray;
			// get the object type
			Type objtype = ReflectionObject.GetType();
			// Get the type and fields of FieldInfoClass.
			fieldarray = objtype.GetFields(_bindflags);
			// store the field information into the hash table.
			for(int i = 0; i < fieldarray.Length; i++)
				_innerhash[fieldarray[i].Name] = fieldarray[i];
		}

		#endregion Constructor/Destructor	                       
		               
		#region Methods
	
		/// <summary>
		/// Gets all the simple members from the field table.
		/// </summary>
		/// <returns>An array of field info items.</returns>
		public FieldInfo[] GetSimpleMembers()
		{
			// if we have already done this...then there is no need to do it again.
			if (_simplemembers != null) return _simplemembers as FieldInfo[];

			System.Collections.ArrayList templist = new System.Collections.ArrayList();
			System.Collections.IDictionaryEnumerator en = this.GetEnumerator() as System.Collections.IDictionaryEnumerator;
			FieldInfo currfield = null;

			if (en != null)
			{
				while (en.MoveNext())
				{
					currfield = en.Value as FieldInfo;
					if (currfield != null && OrcaLogic.TypeHelper.IsSimpleType(currfield.FieldType))
						templist.Add(currfield);
				}
			}

			// store it for future usage
			_simplemembers = templist.ToArray(typeof(System.Reflection.FieldInfo)) as object[];

			// return it as a specific type array
			return _simplemembers as FieldInfo[];
		}		
	
		#endregion Methods
	
		#region Properties
	
		#endregion Properties

		#region IFieldTable Members

		public FieldInfo this[string MemberName]
		{
			get { return _innerhash[MemberName] as FieldInfo; }
			set { _innerhash[MemberName] = value; }
		}

		public void Add(string MemberName, FieldInfo value)
		{
			_innerhash.Add(MemberName, value);
		}

		public void Remove(string MemberName)
		{
			_innerhash.Remove(MemberName);
		}

		#endregion
	}
}
