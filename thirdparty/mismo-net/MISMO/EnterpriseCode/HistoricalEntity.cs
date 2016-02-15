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
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using OrcaLogic;


namespace MISMO.EnterpriseCode
{
	/// <summary>
	/// A class that represents a historical entity.
	/// </summary>
	[Serializable]
	public abstract class HistoricalEntity : Entity
	{
		#region Member Fields
	  


		#endregion Member Fields


		#region Constructor/Destructor   
		
        
		/// <summary>
		/// Creates a new instance of the historical object for the current date and time.
		/// </summary>
		/// <remarks>
		/// The historical request date is set to a null date and time if 
		/// requesting current date and time.
		/// </remarks>
		public HistoricalEntity() : this(Constants.NULLDATETIME) {}


		/// <summary>
		/// Creates a new instance of the historical object for the specified historical request date.
		/// </summary>
		/// <remarks>
		/// The historical request date is the date and time requested of the object. It does
		/// not reflect its actual historical instance.
		/// </remarks>
		public HistoricalEntity(DateTime historicalRequestDate) : base()
		{
			_requestdate = historicalRequestDate;
		}
		
		#endregion Constructor/Destructor


		#region Properties


		/// <summary>
		/// The persisted state of the current object instance.
		/// </summary>
		public override bool Persisted
		{
			get { return _modifieddate != Constants.NULLDATETIME; }
		}


		/// <summary>
		/// Gets any business exceptions for the current state of the object.
		/// </summary>
		public override RuleViolationException BusinessExceptions
		{
			get 
			{ 
				RuleViolationException exceptions = null;
				if (!_modifiedby_assigned)  exceptions = BusinessLogic.ChainException("You must specify the identity of the person modifying the historical object.", exceptions);
				
				// return any results
				return exceptions;
			}
		}


		/// <summary>
		/// Member that stores the revision identity of the historical object.
		/// </summary>
		protected long _revisionid;
		/// <summary>
		/// Gets the identity of the object instance.
		/// </summary>
		public long RevisionId { get { return _revisionid; } }




		/// <summary>
		/// Member that stores the applicable/effetive date of the historical object instance.
		/// </summary>
		protected DateTime _instancedate = Constants.NULLDATETIME;
		/// <summary>
		/// Gets the applicable/effective date of the historical object instance.
		/// </summary>
		public DateTime InstanceDate 
		{
			get { return _instancedate; }
		}


		/// <summary>
		/// The date that the instance was created.  
		/// </summary>
		protected DateTime _createdate;
		/// <summary>
		/// The date that the instance was created.  
		/// </summary>
		/// <remarks>
		/// The create date is based on the creation date of the persisted instance.
		/// </remarks>
		public DateTime CreateDate
		{
			get { return _createdate; }
		}




		
		/// <summary>
		/// The user that modified the current instance.  
		/// </summary>
		protected int _modifiedby;
		protected bool _modifiedby_assigned = false;
		/// <summary>
		/// The user that modified the current instance.  
		/// </summary>
		public int ModifiedBy
		{
			get { return _modifiedby; }
			set 
			{ 
				_modifiedby = value; 
				_modifiedby_assigned = true;
			}
		}




		/// <summary>
		/// The date and time that the current instance was modified.  
		/// </summary>
		protected DateTime _modifieddate;
		/// <summary>
		/// The date and time that the current instance was modified. 
		/// </summary>
		/// <remarks>
		/// The last modified date is based on the last modified date of the persisted data.
		/// </remarks>
		public DateTime ModifiedDate
		{
			get { return _modifieddate; }
		}






		/// <summary>
		/// The requested historical date and time of the object instance.
		/// </summary>
		private DateTime _requestdate;
		/// <summary>
		/// Gets the date that the historical instance has been specified for.
		/// </summary>
		public DateTime RequestDate 
		{
			get { return _requestdate; }
		}


		/// <summary>
		/// The deleted state of the current object instance.
		/// </summary>
		protected bool _deleted = false;
		/// <summary>
		/// The deleted state of the current object instance.
		/// </summary>
		public bool Deleted
		{
			get { return _deleted; }
		}


		#endregion Properties


		#region Methods


		/// <summary>
		/// Method that stores the data back to the underlying database.
		/// </summary>
		/// <param name="instanceDate">A specific instance in time to target (future historical support).</param>
		/// <param name="sqlTrans">The shared transaction to perist with.</param>
		public virtual void Persist(DateTime instanceDate, SqlTransaction sqlTrans)
		{
			_instancedate = instanceDate;
			base.Persist(sqlTrans);
		}




		/// <summary>
		/// Method that stores the data back to the underlying database.
		/// </summary>
		/// <param name="instanceDate">A specific instance in time to target (future historical support).</param>
		public virtual void Persist(DateTime instanceDate)
		{
			Persist(instanceDate, null);
		}


		/// <summary>
		/// Sets the members of the entity through the SetMembers method.
		/// </summary>
		/// <param name="datareader">The reader that contains data to set.</param>
		internal override void SetMembers(ref SqlDataReader datareader)
		{
			_revisionid = Convert.ToInt64(datareader["RevisionId"]);
			_createdate = Convert.ToDateTime(datareader["CreateDate"]);
			_deleted = Convert.ToBoolean(datareader["Deleted"]);
			_modifieddate = Convert.ToDateTime(datareader["ModifiedDate"]);
			_instancedate = Convert.ToDateTime(datareader["InstanceDate"]);
			_modifiedby = Convert.ToInt32(datareader["ModifiedBy"]);
			
			// let the base handle other things
			base.SetMembers(ref datareader);
		}




		/// <summary>
		/// Sets the members of the entity through the SetMembers method.
		/// </summary>
		/// <param name="datarow">The datarow that contains data to set.</param>
		internal override void SetMembers(ref System.Data.DataRow datarow)
		{
			_revisionid = Convert.ToInt64(datarow["RevisionId"]);
			_createdate = Convert.ToDateTime(datarow["CreateDate"]);
			_deleted = Convert.ToBoolean(datarow["Deleted"]);
			_modifieddate = Convert.ToDateTime(datarow["ModifiedDate"]);
			_instancedate = Convert.ToDateTime(datarow["InstanceDate"]);
			_modifiedby = Convert.ToInt32(datarow["ModifiedBy"]);
			
			// let the base handle other things
			base.SetMembers(ref datarow);
		}




		#endregion Methods
	}
}


