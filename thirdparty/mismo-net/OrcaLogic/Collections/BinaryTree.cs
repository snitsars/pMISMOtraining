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
	/// A class that represents a binary tree.
	/// </summary>
	public class BinaryTree
	{
		/// <summary>
		/// Member that stores the _root node of the binary tree.
		/// </summary>
		protected IBinaryTreeNode _root;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BinaryTree()
		{
			_root = null;
		}

		#region Public Methods

		/// <summary>
		/// Clears the binary tree of all of its items.
		/// </summary>
		public virtual void Clear()
		{
			_root = null;
		}

		#endregion


		#region Public Properties

		/// <summary>
		/// Gets or sets the _root node of the binary tree.
		/// </summary>
		public IBinaryTreeNode Root
		{
			get
			{
				return _root;
			}
			set
			{
				_root = value;
			}
		}
		#endregion

	}
}
