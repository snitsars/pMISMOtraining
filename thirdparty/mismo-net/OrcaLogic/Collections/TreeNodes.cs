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
	/// A class that represents a collection of nodes.
	/// </summary>
	public class TreeNodes : System.Collections.CollectionBase
	{
		#region Member Fields
		#endregion Member Fields

		#region Constructors/Destructors

		/// <summary>
		/// Default constructor
		/// </summary>
		public TreeNodes() : this(null, -1)
		{
			//
			// TODO: Add constructor logic here
			//
		}

		/// <summary>
		/// Creates a new instance of a collection of nodes with a specified maximum capacity.
		/// </summary>
		public TreeNodes(int maxcapacity) : this(null, maxcapacity) {}

		/// <summary>
		/// Creates a new instance of a collection of nodes for a specified parent.
		/// </summary>
		public TreeNodes(ITreeNode parent) : this(parent, -1) {}

		/// <summary>
		/// Creates a new instance of a collection of nodes for a specified parent.
		/// </summary>
		public TreeNodes(ITreeNode parent, int maxcapacity)
		{
			if (maxcapacity != -1)
				InnerList.Capacity = maxcapacity;
			_parent = parent;
		}

		#endregion Constructors/Destructors

		#region Properties

		/// <summary>
		/// The parent of the current tree node instance.
		/// </summary>
		protected ITreeNode _parent = null;
		/// <summary>
		/// Gets or sets the parent of the current tree node instance.
		/// </summary>
		public ITreeNode Parent 
		{
			get { return _parent; }
			set
			{ 
				_parent = value; 

				if (Count > 0) // change all the children nodes' parent
				{
					for(int i = 0; i<Count; i++)
					{
						this[i].Parent = value;
					}
				}
			}
		}

		/// <summary>
		/// Indexer for the tree's collection of nodes.
		/// </summary>
		public ITreeNode this[int index] 
		{
			get { return InnerList[index] as ITreeNode; }
			set { InnerList[index] = value; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Adds a new tree node to the collection of nodes.
		/// </summary>
		/// <param name="treenode">The tree node to add to the node collection.</param>
		/// <returns>The location in the node list that the add was at.</returns>
		public int Add(ITreeNode treenode) 
		{
			treenode.Parent = _parent;
			return InnerList.Add(treenode);
		}

		/// <summary>
		/// Adds the elements of a treenodes collection to  the end of an existing treenodes collection.
		/// </summary>
		/// <param name="treenodes">A collection of treenodes to add to the existing collection of treenodes.</param>
		public void AddRange(TreeNodes treenodes) 
		{
			if (treenodes == null || treenodes.Count == 0) return;
			// share the current instance with the added treenodes collection
			treenodes.Parent = _parent;
			InnerList.AddRange(treenodes);
		}

	
		/// <summary>
		/// Gets a list of the objects in the current nodes collection and its children nodes.
		/// </summary>
		/// <returns>An arraylist of objects.</returns>
		public System.Collections.ArrayList GetList() 
		{
			if (this.Count == 0) return new System.Collections.ArrayList();
			System.Collections.ArrayList newlist = new System.Collections.ArrayList();
			System.Collections.ArrayList childlist = null;

			for(int i=0; i<this.Count; i++)
			{
				newlist.Add(this[i].Value);
				childlist = this[i].Nodes.GetList();
				if (childlist.Count > 0)
				{
					newlist.AddRange(childlist);
				}
				childlist = null;
			}

			return newlist;
		}

		/// <summary>
		/// Removes an existing tree node from the collection of nodes.
		/// </summary>
		/// <param name="treenode">The tree node to remove.</param>
		public void Remove(ITreeNode treenode) 
		{
			InnerList.Remove(treenode);
		}

		#endregion Methods
	}
}
