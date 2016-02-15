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
using System.Data;
using System.Data.SqlClient;
using OrcaLogic;
using MISMO.DAL;
using MISMO.EnterpriseCode;
using MISMO.BusinessObjects;


namespace MISMO.Entities
{
	/// <summary>
	/// A class that represents an abstract entity for table 'CreditScoreModelNameType'
	/// </summary>
	[Serializable]
	public abstract class CreditScoreModelNameTypeBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditScoreModelNameTypeBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.CreditScoreModelNameType)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public CreditScoreModelNameTypeBase(System.Int16 id)
		{
			// Fill this instance.
			CreditScoreModelNameTypeBase.ServiceObject.Fill(this as CreditScoreModelNameType, id);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _id_assigned = false;
		/// <summary>
		/// Member that stores the value for the id.
		/// </summary>
		internal System.Int16 _id;
		/// <summary>
		/// Gets and sets the Id value of the class instance.
		/// </summary>
		public virtual System.Int16 Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
				_id_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the name.
		/// </summary>
		internal System.String _name;
		/// <summary>
		/// Gets and sets the Name value of the class instance.
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}


		/// <summary>
		/// Member that stores the value for the enumeratedname.
		/// </summary>
		internal System.String _enumeratedname;
		/// <summary>
		/// Gets and sets the EnumeratedName value of the class instance.
		/// </summary>
		public virtual System.String EnumeratedName
		{
			get
			{
				return _enumeratedname;
			}
			set
			{
				_enumeratedname = value;
			}
		}


		/// <summary>
		/// Member that stores the value for the description.
		/// </summary>
		internal System.String _description;
		/// <summary>
		/// Gets and sets the Description value of the class instance.
		/// </summary>
		public virtual System.String Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}


		/// <summary>
		/// Checks the Description value to see if it was set to null.
		/// </summary>
		public System.Boolean DescriptionIsNull
		{
			get
			{
				return (_description == null);
			}
		}


		/// <summary>
		/// Gets the service object for the CreditScoreModelNameTypeBase.
		/// </summary>
		internal static CreditScoreModelNameTypeService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(CreditScoreModelNameTypeService)) as CreditScoreModelNameTypeService;
			}
		}


		/// <summary>
		/// The business exceptions of this object instance.
		/// </summary>
		public override RuleViolationException BusinessExceptions
		{
			get
			{
				// get the base's exception first
				RuleViolationException exceptions = base.BusinessExceptions;


				if (!_id_assigned) exceptions = BusinessLogic.ChainException("Id is a required value of CreditScoreModelNameTypeBase. The value has not been explicitly assigned.", exceptions);
				if (_name == null) exceptions = BusinessLogic.ChainException("Name is a required value of CreditScoreModelNameTypeBase and is null.", exceptions);
				if (_enumeratedname == null) exceptions = BusinessLogic.ChainException("EnumeratedName is a required value of CreditScoreModelNameTypeBase and is null.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the Description value as null.
		/// </summary>
		public virtual void SetDescriptionNull()
		{
			_description = null;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref CreditScoreModelNameTypeBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the Id data to the class member
			_id = data._id;
			_id_assigned = data._id_assigned;
			// assigns the Name data to the class member
			_name = data._name;
			// assigns the EnumeratedName data to the class member
			_enumeratedname = data._enumeratedname;
			// assigns the Description data to the class member
			_description = data._description;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.SqlClient.SqlDataReader data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the Id data to the class member
			_id = Convert.ToInt16(data["Id"]);
			_id_assigned = true;
			// assigns the Name data to the class member
			_name = Convert.ToString(data["Name"]);
			// assigns the EnumeratedName data to the class member
			_enumeratedname = Convert.ToString(data["EnumeratedName"]);
			// assigns the Description data to the class member
			if (data["Description"] == System.DBNull.Value)
				SetDescriptionNull();
			else
			{
				_description = Convert.ToString(data["Description"]);
			}


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.DataRow data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the Id data to the class member
			_id = Convert.ToInt16(data["Id"]);
			_id_assigned = true;
			// assigns the Name data to the class member
			_name = Convert.ToString(data["Name"]);
			// assigns the EnumeratedName data to the class member
			_enumeratedname = Convert.ToString(data["EnumeratedName"]);
			// assigns the Description data to the class member
			if (data["Description"] == System.DBNull.Value)
				SetDescriptionNull();
			else
			{
				_description = Convert.ToString(data["Description"]);
			}


			RecalculateChecksum();
		}


		/// <summary>
		/// Gets the connection string for the object instance. (Override if necessary)
		/// </summary>
		internal static System.String GetConnectionString()
		{


			// Simply return the DAL's static property.
			return Connection.String;


		}


		/// <summary>
		/// Method to persist object.
		/// </summary>
		public override void Persist()
		{
			Persist(null);
		}


		/// <summary>
		/// Method to persist object with the specified connection.
		/// </summary>
		internal virtual void Persist(SqlTransaction sqlTrans)
		{
			// make a call to the base method first
			base.Persist(sqlTrans);


			// call the persist method off the DAL service layer to persist the object instance
			CreditScoreModelNameTypeBase.ServiceObject.Persist(this as CreditScoreModelNameType, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the CreditScoreModelNameType object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			CreditScoreModelNameTypeBase.ServiceObject.Delete(this as CreditScoreModelNameType);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the CREDIT_SCORE relationship.
		/// </summary>
		public CreditScores GetCreditScores()
		{
			CreditScores creditscores = new CreditScores();


			CreditScoreBase.ServiceObject.FillByCreditScoreModelNameType(creditscores, _id);
			return creditscores;
		}


		/// <summary>
		/// Gets all persisted CreditScoreModelNameType objects
		/// </summary>
		public static CreditScoreModelNameTypes GetAll()
		{
			// have the service object get the objects
			return CreditScoreModelNameTypeBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
