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
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using OrcaLogic;




namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// A class that represents an entity.
	/// </summary>
	[Serializable]
	public class Entity : ICloneable
	{
		#region Inner Classes
	       
		#endregion Inner Classes
	           
		#region Member Fields
	  
		protected static Hashtable _serviceObjects;
		/// <summary>
		/// Member that stores the check sum of the object instance.
		/// </summary>
		private UInt16 _checksum = 0;
	
		#endregion Member Fields
		               
		#region Constructor/Destructor
		
		/// <summary>
		/// Default Constructor
		/// </summary>
		public Entity()
		{
			// an object has not been persisted by default
			_persisted = false;
		}
        
		#endregion Constructor/Destructor	               
		
		#region Methods


		/// <summary>
		/// Recalculates the checksum for an object.
		/// </summary>
		protected void RecalculateChecksum()
		{
			// before we recalculate a checksum...zero it out
			_checksum = 0;
			_checksum = OrcaLogic.Runtime.Serialization.SerializationHelper.GenerateCheckSum(this);
		}


		/// <summary>
		/// ServiceObject - return our service object...
		/// </summary>
		/// <param name="serviceObjectType">type of service</param>
		/// <returns>service</returns>
		protected static Service GetServiceObject(Type serviceObjectType)
		{
			// do we have the cache?
			if(_serviceObjects == null)
				_serviceObjects = new Hashtable();




			// get it out of the cache...
			Service serviceObject = (Service)_serviceObjects[serviceObjectType];
			if(serviceObject == null)
			{
				ServiceObjectFactory factory = EnterpriseApplication.Application.ServiceObjectFactory;
				serviceObject = factory.Create(serviceObjectType);




				// add it...
				_serviceObjects.Add(serviceObjectType, serviceObject);
			}
		
			return serviceObject;
		}


		#region ICloneable Members


		/// <summary>
		/// Creates a new clone of the current instance.
		/// </summary>
		/// <returns>A new clone of the current instance.</returns>
		public virtual object Clone()
		{
			Entity thisclone = this.MemberwiseClone() as Entity;
			thisclone.RecalculateChecksum();
			return thisclone;
		}


		#endregion




		/// <summary>
		/// Method to persist object.
		/// </summary>
		public virtual void Persist()
		{
			Persist(null);
		}


		/// <summary>
		/// Method to persist object.
		/// </summary>
		internal virtual void Persist(SqlTransaction sqlTrans)
		{
			// see if there is exceptions in the business model
			RuleViolationException businessexception = this.BusinessExceptions;
			if (businessexception != null) throw businessexception;
		}


		/// <summary>
		/// Marks the entity as deleted.
		/// </summary>
		/// <remarks>
		/// Override to provide specific delete processes.
		/// </remarks>
		public virtual void Delete()
		{
			_deleted = true;
			RecalculateChecksum();
		}




		/// <summary>
		/// Sets the members of the entity through the SetMembers method.
		/// </summary>
		/// <param name="datareader">The reader that contains data to set.</param>
		protected virtual void SetMembers(ref Entity data)
		{
			_deleted = data._deleted;
			_persisted = data._persisted;
		}


		/// <summary>
		/// Sets the members of the entity through the SetMembers method.
		/// </summary>
		/// <param name="datareader">The reader that contains data to set.</param>
		internal virtual void SetMembers(ref SqlDataReader datareader)
		{
			SetMembers();
		}


		/// <summary>
		/// Sets the members of the entity through the SetMembers method.
		/// </summary>
		/// <param name="datarow">The data row that contains data to set.</param>
		internal virtual void SetMembers(ref System.Data.DataRow datarow)
		{
			SetMembers();
		}


		/// <summary>
		/// Performs the same operations on both set members (reader/datatable)
		/// </summary>
		private void SetMembers()
		{
			_persisted = true; // setting members via a reader means that the instance has already been persisted.
			// since we are setting from the database it must not be deleted.
			// the descendants will change it if they have delete flag support.
			_deleted = false; 
		}


		#endregion Methods
	
		#region Properties
	
		/// <summary>
		/// The modified state of the current object instance.
		/// </summary>
		public bool IsModified 
		{
			get 
			{
				// cache the current one since we need to gen a checksum with it zero.
				UInt16 cachedchecksum = _checksum;


				// zero out the checksum before checking it
				_checksum = 0;


				// calculate the current checksum
				UInt16 currentchecksum = OrcaLogic.Runtime.Serialization.SerializationHelper.GenerateCheckSum(this);


				// restore the cached checksum
				_checksum = cachedchecksum;


				return (cachedchecksum != currentchecksum);
			}
		}


		/// <summary>
		/// Member that stores the persisted state of the object instance.
		/// </summary>
		protected bool _persisted = false;
		/// <summary>
		/// The persisted state of the current object instance.
		/// </summary>
		public virtual bool Persisted
		{
			get { return _persisted; }
		}


		/// <summary>
		/// Member that stores the deleted state of the object instance.
		/// </summary>
		protected bool _deleted = false;
		/// <summary>
		/// Gets the deleted state of the object instance.
		/// </summary>
		public virtual bool Deleted 
		{
			get 
			{
				return _deleted;
			}
		}


		/// <summary>
		/// Gets any business exceptions for the current state of the object.
		/// </summary>
		public virtual RuleViolationException BusinessExceptions
		{
			get 
			{ 
				return null; // a basic entity has no business rules yet.	
			}
		}




		#endregion Properties
	}
}






