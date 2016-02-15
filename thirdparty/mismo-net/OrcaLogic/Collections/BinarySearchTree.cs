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
using System.Text;

namespace OrcaLogic.Collections
{
	/// <summary>
	/// A class that represents a binary search tree.
	/// </summary>
	public class BinarySearchTree : BinaryTree, ICloneable, IEnumerable
	{
		/// <summary>
		/// Members that stores the internal could of nodes.
		/// </summary>
		private int _count = 0;

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BinarySearchTree() : base() {}

		#region Public Methods

		/// <summary>
		/// Clears the contents of the binary search tree.
		/// </summary>
		public override void Clear()
		{
			base.Clear();
			_count = 0;
		}

		/// <summary>
		/// Clones the contents of the binary search tree (deep clone).
		/// </summary>
		/// <returns>An object representing the binary search tree instance.</returns>
		public virtual object Clone()
		{
			BinarySearchTree clone = new BinarySearchTree();
			clone._root = _root.Clone() as IBinaryTreeNode;
			clone._count = this._count;
			return clone;
		}

		#region GetEnumerator

		/// <summary>
		/// Gets the IEnumerator for the binary search tree instance.
		/// </summary>
		/// <returns></returns>
		public IEnumerator GetEnumerator()
		{
			// dump the contents of the BST's Inorder traversal into an ArrayList and
			// then return this ArrayList's enumerator
			System.Collections.ArrayList contents = new System.Collections.ArrayList(_count);
			InorderTraversalBuildup(_root, contents);
			return contents.GetEnumerator();
		}

		/// <summary>
		/// Builds an arraylist of the inorder traversal of the tree.
		/// </summary>
		/// <param name="current">The current binary tree node.</param>
		/// <param name="contents">The contents of the tree.</param>
		protected virtual void InorderTraversalBuildup(IBinaryTreeNode current, System.Collections.ArrayList contents)
		{
			if (current != null)
			{
				InorderTraversalBuildup(current.LeftChild, contents);
				contents.Add(current);
				InorderTraversalBuildup(current.RightChild, contents);
			}
		}
		#endregion

		#region Add

		/// <summary>
		/// Adds new content to the binary search tree.
		/// </summary>
		/// <param name="data"></param>
		public virtual void Add(IComparable data)
		{
			// first, create a new Node
			BinaryTreeNode n = new BinaryTreeNode(data);
			int result;

			// now, insert n into the tree
			// trace down the tree until we hit a NULL
			IBinaryTreeNode current = _root, parent = null;
			// define variable for comparisons
			IComparable comparableval = null;

			while (current != null)
			{
				comparableval = current.Value as IComparable;
				if (comparableval == null) return; // unable to perform insert - do nothing
				result = comparableval.CompareTo(n.Value);
				if (result == 0)
					// they are equal - inserting a duplicate - do nothing
					return;
				else if (result > 0)
				{
					// current.Value > n.Value
					// therefore, n must be added to current's left subtree
					parent = current;
					current = current.LeftChild;
				}
				else if (result < 0)
				{
					// current.Value < n.Value
					// therefore, n must be added to current's right subtree
					parent = current;
					current = current.RightChild;
				}
			}

			// ok, at this point we have reached the end of the tree
			_count++;
			if (parent == null)
				// the tree was empty
				_root = n;
			else
			{
				// store a reference to the parent
				n.Parent = parent;

				comparableval = parent.Value as IComparable;
				if (comparableval != null)
				{
					result = comparableval.CompareTo(n.Value);
					if (result > 0)
						// parent.Value > n.Value
						// therefore, n must be added to parent's left subtree
						parent.LeftChild = n;
					else if (result < 0)
						// parent.Value < n.Value
						// therefore, n must be added to parent's right subtree
						parent.RightChild = n;
				}
			}
		}
		#endregion

		#region Contains

		/// <summary>
		/// Checks to see if the data is contained within the binary search tree.
		/// </summary>
		/// <param name="data">The data to search for.</param>
		/// <returns>True if contained and false otherwise.</returns>
		public virtual bool Contains(IComparable data)
		{
			return Search(data) != null;
		}
		
		#endregion

		#region Search

		/// <summary>
		/// Locates the binary tree node withing the binary tree for the specified data item.
		/// </summary>
		/// <param name="data">The data to search for.</param>
		/// <returns>A reference to the binary tree node that it contains.</returns>
		public virtual IBinaryTreeNode Search(IComparable data)
		{
			return SearchHelper(_root, data);
		}

		/// <summary>
		/// Search helper method that assists in locating the current binary node for the specified data item.
		/// </summary>
		/// <param name="current">The current node to begin the search with.</param>
		/// <param name="data">The data to look for.</param>
		/// <returns>A reference to the node that the data is contained in.</returns>
		protected virtual IBinaryTreeNode SearchHelper(IBinaryTreeNode current, IComparable data)
		{
			if (current == null)
				return null;	// node was not found
			else
			{
				// get the comparable instance from the value of the object.
				IComparable currval = current.Value as IComparable;
				// if the current value is not comparable return null stating that we can not locate the node.
				if (currval == null) return null;
				// get the compare to results
				int result = currval.CompareTo(data);
				if (result == 0)
					// they are equal - we found the data
					return current;
				else if (result > 0)
				{
					// current.Value > n.Value
					// therefore, if the data exists it is in current's left subtree
					return SearchHelper(current.LeftChild, data);
				}
				else // result < 0
				{
					// current.Value < n.Value
					// therefore, if the data exists it is in current's right subtree
					return SearchHelper(current.RightChild, data);
				}
			}
		}

		#endregion

		#region Delete

		/// <summary>
		/// Deletes the specified data item from the binary search tree.
		/// </summary>
		/// <param name="data">The data to delete.</param>
		public void Delete(IComparable data)
		{
			// find n in the tree
			// trace down the tree until we hit n
			IBinaryTreeNode current = _root, parent = null;

			// define variable for comparisons
			IComparable comparableval = current.Value as IComparable;

			// check if IComparable is supported
			if (comparableval == null) return; // we can do nothing if the value doesn't support IComparable			
			
			int result = comparableval.CompareTo(data);


			while (result != 0 && current != null)
			{				
				if (result > 0)
				{
					// current.Value > n.Value
					// therefore, n must be added to current's left subtree
					parent = current;
					current = current.LeftChild;
				}
				else if (result < 0)
				{
					// current.Value < n.Value
					// therefore, n must be added to current's right subtree
					parent = current;
					current = current.RightChild;
				}

				comparableval = current.Value as IComparable;
				result = comparableval.CompareTo(data);
			}

			// if current == null, then we did not find the item to delete
			if (current == null)
				throw new Exception("Item to be deleted does not exist in the BST.");


			// at this point current is the node to delete, and parent is its parent
			_count--;
			
			// CASE 1: If current has no right child, then current's left child becomes the
			// node pointed to by the parent
			if (current.RightChild == null)
			{
				if (parent == null)
					_root = current.LeftChild;
				else
				{
					comparableval = parent.Value as IComparable;
					if (comparableval != null)
					{
						result = comparableval.CompareTo(current.Value);
						if (result > 0)
							// parent.Value > current
							// therefore, the parent's left subtree is now current's Left subtree
							parent.LeftChild = current.LeftChild;
						else if (result < 0)
							// parent.Value < current.Value
							// therefore, the parent's right subtree is now current's left subtree
							parent.RightChild = current.LeftChild;
					}
				}
			}
				// CASE 2: If current's right child has no left child, then current's right child replaces
				// current in the tree
			else if (current.RightChild.LeftChild == null)
			{
				if (parent == null)
					_root = current.RightChild;
				else
				{
					comparableval = parent.Value as IComparable;
					if (comparableval != null)
					{
						result = comparableval.CompareTo(current.Value);
						if (result > 0)
							// parent.Value > current
							// therefore, the parent's left subtree is now current's right subtree
							parent.LeftChild = current.RightChild;
						else if (result < 0)
							// parent.Value < current.Value
							// therefore, the parent's right subtree is now current's right subtree
							parent.RightChild = current.RightChild;
					}
				}
			}	
				// CASE 3: If current's right child has a left child, replace current with current's
				// right child's left-most node.
			else
			{
				// we need to find the right node's left-most child
				IBinaryTreeNode leftmost = current.RightChild.LeftChild, lmParent = current.RightChild;
				while (leftmost.LeftChild != null)
				{
					lmParent = leftmost;
					leftmost = leftmost.LeftChild;
				}

				// the parent's left subtree becomes the leftmost's right subtree
				lmParent.LeftChild = leftmost.RightChild;
				
				// assign leftmost's left and right to current's left and right
				leftmost.LeftChild = current.LeftChild;
				leftmost.RightChild = current.RightChild;

				if (parent == null)
					_root = leftmost;
				else
				{
					comparableval = parent.Value as IComparable;
					if (comparableval != null)
					{
						result = comparableval.CompareTo(current.Value);
						if (result > 0)
							// parent.Value > current
							// therefore, the parent's left subtree is now current's right subtree
							parent.LeftChild = leftmost;
						else if (result < 0)
							// parent.Value < current.Value
							// therefore, the parent's right subtree is now current's right subtree
							parent.RightChild = leftmost;
					}
				}
			}
		}
		#endregion

		#region Traversal Methods

		/// <summary>
		/// Gets the string representation of the tree using inorder and a space separator.
		/// </summary>
		/// <returns>The inorder traversal of the tree as string.</returns>
		public override string ToString()
		{
			return ToString(TreeTraversalMethods.Inorder);
		}

		/// <summary>
		/// Gets a string representation of the tree using the specified traversal method and a space separator.
		/// </summary>
		/// <param name="traversalMethod">The traversal method to use.</param>
		/// <returns>The traversed data in the tree as string.</returns>
		public virtual string ToString(TreeTraversalMethods traversalMethod)
		{
			return ToString(traversalMethod, " ");
		}

		/// <summary>
		/// Gets a string representation of the tree using the specified traversal method and a specified separator.
		/// </summary>
		/// <param name="traversalMethod">The traversal method to use.</param>
		/// <param name="separator">The separator used in the output.</param>
		/// <returns>The traversed data in the tree as string.</returns>
		public virtual string ToString(TreeTraversalMethods traversalMethod, string separator)
		{
			string results = String.Empty;
			switch (traversalMethod)
			{
				case TreeTraversalMethods.Preorder:
					results = PreorderTraversal(_root, separator);
					break;

				case TreeTraversalMethods.Inorder:
					results = InorderTraversal(_root, separator);
					break;

				case TreeTraversalMethods.Postorder:
					results = PostorderTraversal(_root, separator);
					break;					
			}

			// finally, hack off the last separator
			if (results.Length == 0)
				return String.Empty;
			else
				return results.Substring(0, results.Length - separator.Length);
		}

		#region Pre-order
		protected virtual string PreorderTraversal(IBinaryTreeNode current, string separator)
		{
			if (current != null)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(current.Value.ToString());
				sb.Append(separator);

				sb.Append(PreorderTraversal(current.LeftChild, separator));
				sb.Append(PreorderTraversal(current.RightChild, separator));
				return sb.ToString();
			}
			else
				return String.Empty;
		}
		#endregion

		#region In-order
		protected virtual string InorderTraversal(IBinaryTreeNode current, string separator)
		{
			if (current != null)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(InorderTraversal(current.LeftChild, separator));
				sb.Append(current.Value.ToString());
				sb.Append(separator);
				sb.Append(InorderTraversal(current.RightChild, separator));
				return sb.ToString();
			}
			else
				return String.Empty;
		}
		#endregion

		#region Post-order

		/// <summary>
		/// Performs a post order traversal of the tree.
		/// </summary>
		/// <param name="current">The current node to begin the traversal.</param>
		/// <param name="separator">The separator to use in the output.</param>
		/// <returns>A string of the post order traversal.</returns>
		protected virtual string PostorderTraversal(IBinaryTreeNode current, string separator)
		{
			if (current != null)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(PostorderTraversal(current.LeftChild, separator));
				sb.Append(PostorderTraversal(current.RightChild, separator));

				sb.Append(current.Value.ToString());
				sb.Append(separator);
				return sb.ToString();
			}
			else
				return String.Empty;
		}
		#endregion
		#endregion
		#endregion

		#region Public Properties

		/// <summary>
		/// The count of items in the binary search tree.
		/// </summary>
		public virtual int Count
		{
			get
			{
				return _count;
			}
		}

		#endregion
	}
}
