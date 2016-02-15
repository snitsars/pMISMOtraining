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
	/// An interface for a strongly typed collection of objects.
	/// </summary>
	/// <remarks>
	/// Implement this interface for defining additional constructs
	/// for strongly typing a collection of objects.
	/// </remarks>
	public interface ITypedCollection
	{
		/// <summary>
		/// Gets the type of object that the current collection may support.
		/// </summary>
		System.Type[] ContainsType { get; }

		/// <summary>
		/// Analyzes the type of the object that is about to be contained
		/// and verifies if the type is supported.
		/// </summary>
		/// <param name="any">Any object that could interface with the internal storage of the collection.</param>
		/// <returns>True if the type is supported and false otherwise.</returns>
		bool IsTypeSupported(object any);

		/// <summary>
		/// Gets or sets the item at the specified index of the collection.
		/// </summary>
		object this[int index]
		{
			get;
			set;
		}

		/// <summary>
		/// Adds a strongly supported type item to the collection.
		/// </summary>
		/// <param name="any">The supported object to add.</param>
		int Add(object any);

		/// <summary>
		/// Removes a strongly types supported item from the collection.
		/// </summary>
		/// <param name="any">The supported object to remove.</param>
		void Remove(object any);
	}
}
