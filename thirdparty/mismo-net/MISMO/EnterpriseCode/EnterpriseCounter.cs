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
using System.Diagnostics;




namespace MISMO.EnterpriseCode
{
	public class EnterpriseCounter
	{
		// members...
		public string Name;
		public string HelpText;
		public PerformanceCounterType Type;
		public PerformanceCounter Counter;
		private Hashtable _instances = new Hashtable();




		public EnterpriseCounter()
		{
		}




		public EnterpriseCounter(string name, string helpText, PerformanceCounterType type)
		{
			Name = name;
			HelpText = helpText;
			Type = type;
		}




		public void RegisterInstance(object theObject)
		{
			// do we have this object?
			int hashCode = theObject.GetHashCode();
			if(_instances.Contains(hashCode) == false)
			{
				_instances.Add(hashCode, null);
				Counter.Increment();
			}
		}




		public void DeregisterInstance(object theObject)
		{
			// get the hashcode...
			int hashCode = theObject.GetHashCode();
			if(_instances.Contains(hashCode) == true)
			{
				_instances.Remove(hashCode);
				Counter.Decrement();
			}
		}
	}
}






