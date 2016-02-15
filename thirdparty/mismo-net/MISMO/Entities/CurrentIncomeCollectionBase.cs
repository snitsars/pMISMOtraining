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
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.DAL;


namespace MISMO.Entities
{
	/// <summary>
	/// A class that represents the collection base for a CURRENT_INCOME entity.
	/// </summary>
	[Serializable]
	public abstract class CurrentIncomeCollectionBase : MISMO.EnterpriseCode.Entities
	{

		#region Constructors

		/// <summary>
		/// Default Constructor
		/// </summary>
		public CurrentIncomeCollectionBase()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}

		#endregion Constructors


		#region Properties

		/// <summary>
		/// Gets or sets the object instance from the specified index location.
		/// </summary>
		public virtual MISMO.BusinessObjects.CurrentIncome this[int index]
		{
			get
			{
				return InnerList[index] as MISMO.BusinessObjects.CurrentIncome;
			}
			set
			{
				InnerReplace(index, value);
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Adds a new object instance to the current collection set.
		/// </summary>
		public virtual int Add(CurrentIncomeBase currentIncomeBase)
		{
			return InnerAdd(currentIncomeBase);
		}


		/// <summary>
		/// Removes an object instance from the current collection set of items.
		/// </summary>
		public virtual void Remove(CurrentIncomeBase currentIncomeBase)
		{
			InnerRemove(currentIncomeBase);
		}



		#endregion Methods

	}
}
