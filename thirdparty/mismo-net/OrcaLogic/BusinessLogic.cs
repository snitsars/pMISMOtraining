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

namespace OrcaLogic
{
	/// <summary>
	/// A class that represents business logic utilities.
	/// </summary>
	public sealed class BusinessLogic
	{
		private BusinessLogic()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#region Methods

		/// <summary>
		/// Chains the exceptions.
		/// </summary>
		/// <param name="message">The message of the new exception.</param>
		/// <param name="chain">The chain to "inner link" everything.</param>
		/// <returns>A new rule violation exception with the inner chains if necessary.</returns>
		public static RuleViolationException ChainException(string message, RuleViolationException chain)
		{
			if (chain == null) return new RuleViolationException(message);
			return new RuleViolationException(message, chain); 
		}

		/// <summary>
		/// Chains the exceptions.
		/// </summary>
		/// <param name="newException">The new exception.</param>
		/// <param name="chain">The chain to "inner link" everything.</param>
		/// <returns>A new rule violation exception with the inner chains if necessary.</returns>
		public static RuleViolationException ChainException(RuleViolationException newException, RuleViolationException chain)
		{
			// if there is nothing to chain return the new exception
			if (chain == null) return newException;
			
			// if there are no new inner exceptions, simply return the chain
			if (newException.InnerException == null)
				return ChainException(newException.Message, chain);
			else // recurse through the new exception chain to link up the two chains
			{
				RuleViolationException newChain = ChainException(newException.InnerException as RuleViolationException, chain);
				return ChainException(newException.Message, newChain);
			}
		}

		#endregion
	}
}
