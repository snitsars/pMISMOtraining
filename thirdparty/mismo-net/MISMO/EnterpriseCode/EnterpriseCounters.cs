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
using System.Reflection;
using System.Collections;
using System.Diagnostics;




namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// Summary description for Counters.
	/// </summary>
	public class EnterpriseCounters
	{
		// members...
		public string PerformanceObjectName = "MyEnterpriseApplication";
		private EnterpriseCounterCollection _counters = new EnterpriseCounterCollection();
		private ArrayList _counterCapableObjects = new ArrayList();




		public EnterpriseCounters()
		{
			//
			// TODO: Add constructor logic here
			//
		}




		public EnterpriseCounterCollection Counters
		{
			get
			{
				return _counters;
			}
		}




		public void ScanAssembly(object seedObject)
		{
			ScanAssembly(seedObject.GetType().Assembly);
		}




		public void ScanAssembly(Assembly scanAssembly)
		{
			// go through the types...
			foreach(Type scanType in scanAssembly.GetTypes())
			{
				// get the attributes...
				foreach(Type counterInterface in scanType.GetInterfaces())
				{
					// do we have one?
					if(counterInterface == typeof(ICounterProvider))
					{
						// create it...
						try
						{
							// call it and add it to the list...
							ICounterProvider targetObject = (ICounterProvider)Activator.CreateInstance(scanType);
							targetObject.CreateCounters(this);
							_counterCapableObjects.Add(targetObject);
						}
						catch
						{
						}
					}
				}
			}
		}




		public void CreateCounters()
		{
			CreateCounters(false);
		}




		public void CreateCounters(bool force)
		{
			// does the object exist?
			bool countersExist = PerformanceCounterCategory.Exists(PerformanceObjectName);




			// delete the category?
			if(countersExist == true && force == true)
			{
				PerformanceCounterCategory.Delete(PerformanceObjectName);
				countersExist = false;
			}




			// do we need to create it?
			if(countersExist == false)
			{
				// create a collection...
				CounterCreationDataCollection list = new CounterCreationDataCollection();




				// go through each counter...
				foreach(EnterpriseCounter counter in Counters)
				{
					// create some new data...
					CounterCreationData data = new CounterCreationData();
					data.CounterName = counter.Name;
					data.CounterHelp = counter.HelpText;
					data.CounterType = counter.Type;
					
					// add it...
					list.Add(data);
				}




				// create the category and all of the counters...
				PerformanceCounterCategory.Create(PerformanceObjectName, "", list);
			}




			// now, go back through the counters and create instances...
			foreach(EnterpriseCounter counter in Counters)
			{
				// create an instance and store it...
				counter.Counter = new PerformanceCounter(PerformanceObjectName, counter.Name, "", false);




				// reset the value...
				counter.Counter.RawValue = 0;
			}




			// ok, now tell all the objects that registered counters that they have been created...
			foreach(ICounterProvider counterObject in _counterCapableObjects)
				counterObject.CountersCreated(this);
	        _counterCapableObjects.Clear();
		}
	}
}






