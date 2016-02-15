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

namespace OrcaLogic.Math
{
	/// <summary>
	/// A class that represents a static send of rounding functions.
	/// </summary>
	public sealed class Round
	{
		private Round()
		{
			//
			// private prevents instantiation.
			//
		}

		#region Methods

		/// <summary>
		/// Rounds a percent number to the nearest eighth percent.
		/// </summary>
		/// <param name="percentNumber">The percent number to round.</param>
		/// <returns>A number percent in eighth increments.</returns>
		public static double Eighth(double percentNumber)
		{
			const double EIGHTHVAL = 0.125;
			int eighthparts = (int) (percentNumber / EIGHTHVAL);
			double roundtolerance = (percentNumber % EIGHTHVAL) / EIGHTHVAL;

			if (roundtolerance >= 0.5)
				return (eighthparts * EIGHTHVAL) + EIGHTHVAL;
			else
				return eighthparts * EIGHTHVAL;
		}

		#endregion Methods
	}
}
