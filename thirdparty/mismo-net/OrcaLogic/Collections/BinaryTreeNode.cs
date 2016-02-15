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
	/// A class that represents a binary tree node.
	/// </summary>
	public class BinaryTreeNode : TreeNode, IBinaryTreeNode
	{

		#region Constructors/Destructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BinaryTreeNode() : this(null, null) {}


		/// <summary>
		/// Creates a new instance of a tree node.
		/// </summary>
		/// <param name="parent">The parent of the node to create.</param>
		public BinaryTreeNode(IBinaryTreeNode parent) : this(parent, null) {}

		/// <summary>
		/// Creates a new instance of a tree node.
		/// </summary>
		/// <param name="Value">The value stored at the tree node.</param>
		public BinaryTreeNode(object Value) : this(null, Value) {}

		/// <summary>
		/// Creates a new instance of a tree node.
		/// </summary>
		/// <param name="parent">The parent of the node to create.</param>
		/// <param name="Value">The value stored at the tree node.</param>
		public BinaryTreeNode(IBinaryTreeNode parent, object Value) : base(parent, Value, new TreeNodes(2)) {}


		#endregion Constructors/Destructors

		#region Properties
		#endregion Properties

		#region Methods

		/// <summary>
		/// Creates a clone of the current instance of the tree node.
		/// </summary>
		/// <returns>A cloned instance of the tree node.</returns>
		public object Clone() 
		{
			BinaryTreeNode clone = new BinaryTreeNode();
			if (_value is ICloneable)
				clone.Value = (IComparable) ((ICloneable) _value).Clone();
			else
				clone.Value = _value;

			if (LeftChild != null)
				clone.LeftChild = LeftChild.Clone() as BinaryTreeNode;
			
			if (RightChild != null)
				clone.RightChild = RightChild.Clone() as BinaryTreeNode;

			return clone;
		}

		#endregion Methods


		#region IBinaryTreeNode Members

		/// <summary>
		/// Gets or sets the left child node of the binary tree node instance.
		/// </summary>
		public IBinaryTreeNode LeftChild
		{
			get
			{
				return this.Nodes[0] as IBinaryTreeNode;
			}
			set
			{
				this.Nodes[0] = value;
			}
		}

		/// <summary>
		/// Gets or sets the right child node of the binary tree node instance.
		/// </summary>
		public IBinaryTreeNode RightChild
		{
			get
			{
				return this.Nodes[1] as IBinaryTreeNode;
			}
			set
			{
				this.Nodes[1] = value;
			}
		}

		#endregion
	}
}
