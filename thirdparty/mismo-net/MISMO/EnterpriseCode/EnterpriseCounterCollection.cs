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
using System.Threading;
using System.Collections;
using System.Diagnostics;




namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// Summary description for CounterCollection.
	/// </summary>
	public class EnterpriseCounterCollection : CollectionBase
	{
		// members...
		private ReaderWriterLock _lock = new ReaderWriterLock();
		private Hashtable _cache;




		public EnterpriseCounterCollection()
		{
		}




		public void Add(EnterpriseCounter counter)
		{
			// have we already added it?
			EnterpriseCounter existing = Find(counter.Name);
			if(existing != null)
				return;




			// add it...
			_lock.AcquireWriterLock(-1);
			List.Add(counter);
			ClearCache();
			_lock.ReleaseWriterLock();
		}




		public void Remove(EnterpriseCounter counter)
		{
			_lock.AcquireWriterLock(-1);
			List.Remove(counter);
			ClearCache();
			_lock.ReleaseWriterLock();
		}




		public new void Clear()
		{
			_lock.AcquireWriterLock(-1);
			base.Clear();
			ClearCache();
			_lock.ReleaseWriterLock();
		}




		public new void RemoveAt(int index)
		{
			_lock.AcquireWriterLock(-1);
			base.RemoveAt(index);
			ClearCache();
			_lock.ReleaseWriterLock();
		}
		
		public new int Count
		{
			get
			{
				_lock.AcquireReaderLock(-1);
				int theCount = base.Count;
				_lock.ReleaseWriterLock();
				return theCount;
			}
		}




		public EnterpriseCounter this[int index]
		{
			get
			{
				_lock.AcquireReaderLock(-1);
				EnterpriseCounter theItem = (EnterpriseCounter)List[index];
				_lock.ReleaseReaderLock();
				return theItem;
			}
			set
			{
				_lock.AcquireWriterLock(-1);
				List[index] = value;
				ClearCache();
				_lock.ReleaseWriterLock();
			}
		}




		protected void ClearCache()
		{
			_lock.AcquireWriterLock(-1);
			_cache = null;
			_lock.ReleaseWriterLock();
		}




		protected void CheckCacheExists()
		{
			// lock...
			_lock.AcquireReaderLock(-1);




			// do we have it?
			if(_cache == null)
			{
				// upgrade...
				_lock.UpgradeToWriterLock(-1);




				// create it...
				_cache = new Hashtable();
				foreach(EnterpriseCounter counter in InnerList)
					_cache.Add(counter.Name.ToLower(), counter);
			}




			// unlock...
			_lock.ReleaseLock();
		}




		public EnterpriseCounter Find(string name)
		{
			// do we have a cache?
			CheckCacheExists();




			// loop...
			_lock.AcquireReaderLock(-1);
			EnterpriseCounter found = (EnterpriseCounter)_cache[name.ToLower()];
			_lock.ReleaseReaderLock();




			// return...
			return found;
		}




		public bool Exists(string name) 
		{
			// do we have a cache?
			CheckCacheExists();




			// exists?
			_lock.AcquireReaderLock(-1);
			bool counterExists = _cache.Contains(name.ToLower());
			_lock.ReleaseReaderLock();




			// return...
			return counterExists;
		}
	}
}






