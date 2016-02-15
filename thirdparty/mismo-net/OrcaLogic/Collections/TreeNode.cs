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
	/// A class that represents a tree node.
	/// </summary>
	public class TreeNode : ITreeNode
	{
		#region Member Fields
		#endregion Member Fields

		#region Constructors/Destructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TreeNode() : this(null, null, null) {}

		/// <summary>
		/// Default constructor
		/// </summary>
		public TreeNode(ITreeNode parent, object Value) : this(parent, Value, null) {}		

		/// <summary>
		/// Creates a new instance of a tree node.
		/// </summary>
		/// <param name="parent">The parent of the node to create.</param>
		public TreeNode(ITreeNode parent) : this(parent, null, null) {}

		/// <summary>
		/// Creates a new instance of a tree node.
		/// </summary>
		/// <param name="Value">The value stored at the tree node.</param>
		public TreeNode(object Value) : this(null, Value, null) {}

		/// <summary>
		/// Creates a new instance of a tree node.
		/// </summary>
		/// <param name="parent">The parent of the node to create.</param>
		/// <param name="Value">The value stored at the tree node.</param>
		/// <param name="children">The children of the tree node.</param>
		public TreeNode(ITreeNode parent, object Value, TreeNodes children) 
		{
			_parent = parent;
			_value = Value;
			if (children != null)
			{
				_nodes = children;
				_nodes.Parent = this;
			}
			else
				_nodes = new TreeNodes(this);
		}

		#endregion Constructors/Destructors

		#region Properties
	
		/// <summary>
		/// The value stored at the node.
		/// </summary>
		protected object _value = null;
		/// <summary>
		/// Gets or sets the value stored in the node.
		/// </summary>
		public object Value 
		{
			get { return _value; }
			set { _value = value; }
		}


		/// <summary>
		/// The collection of node children at a particular node instance.
		/// </summary>
		protected TreeNodes _nodes = null;
		/// <summary>
		/// The collection of node children at a particular node instance.
		/// </summary>
		public TreeNodes Nodes 
		{
			get { return _nodes; }
		}


		/// <summary>
		/// The parent of the current node instance.
		/// </summary>
		protected ITreeNode _parent = null;
		/// <summary>
		/// The parent of the current node instance.
		/// </summary>
		public ITreeNode Parent 
		{
			get { return _parent; }
			set { _parent = value; }
		}

		#endregion Properties

		#region Methods
		#endregion Methods
	}
}
