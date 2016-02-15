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
	/// A class that represents an abstract entity for table 'LOAN_PURPOSE'
	/// </summary>
	[Serializable]
	public abstract class LoanPurposeBase : Entity
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanPurposeBase()
		{
			// do a checksum on a new instance when possible.
			if (this.GetType() == typeof(MISMO.BusinessObjects.LoanPurpose)) RecalculateChecksum();
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanPurposeBase(System.Int64 loanApplicationId)
		{
			// Fill this instance.
			LoanPurposeBase.ServiceObject.Fill(this as LoanPurpose, loanApplicationId);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the assigned indicator of the non-nullable value type.
		/// </summary>
		internal bool _loanapplicationid_assigned = false;
		/// <summary>
		/// Member that stores the value for the loanapplicationid.
		/// </summary>
		internal System.Int64 _loanapplicationid;
		/// <summary>
		/// Gets and sets the LoanApplicationId value of the class instance.
		/// </summary>
		public virtual System.Int64 LoanApplicationId
		{
			get
			{
				return _loanapplicationid;
			}
			set
			{
				_loanapplicationid = value;
				_loanapplicationid_assigned = true;
			}
		}


		/// <summary>
		/// Member that stores the value for the gsetitlemannerhelddescription.
		/// </summary>
		internal System.String _gsetitlemannerhelddescription;
		/// <summary>
		/// Gets and sets the GSETitleMannerHeldDescription value of the class instance.
		/// </summary>
		public virtual System.String GSETitleMannerHeldDescription
		{
			get
			{
				return _gsetitlemannerhelddescription;
			}
			set
			{
				_gsetitlemannerhelddescription = value;
			}
		}


		/// <summary>
		/// Checks the GSETitleMannerHeldDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean GSETitleMannerHeldDescriptionIsNull
		{
			get
			{
				return (_gsetitlemannerhelddescription == null);
			}
		}


		/// <summary>
		/// Member that stores the value for the otherloanpurposedescription.
		/// </summary>
		internal System.String _otherloanpurposedescription;
		/// <summary>
		/// Gets and sets the OtherLoanPurposeDescription value of the class instance.
		/// </summary>
		public virtual System.String OtherLoanPurposeDescription
		{
			get
			{
				return _otherloanpurposedescription;
			}
			set
			{
				_otherloanpurposedescription = value;
			}
		}


		/// <summary>
		/// Checks the OtherLoanPurposeDescription value to see if it was set to null.
		/// </summary>
		public System.Boolean OtherLoanPurposeDescriptionIsNull
		{
			get
			{
				return (_otherloanpurposedescription == null);
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyleaseholdexpirationdate_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyleaseholdexpirationdate.
		/// </summary>
		internal System.DateTime _propertyleaseholdexpirationdate;
		/// <summary>
		/// Gets and sets the PropertyLeaseholdExpirationDate value of the class instance.
		/// </summary>
		public virtual System.DateTime PropertyLeaseholdExpirationDate
		{
			get
			{
				return _propertyleaseholdexpirationdate;
			}
			set
			{
				_propertyleaseholdexpirationdate = value;
				_propertyleaseholdexpirationdate_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyLeaseholdExpirationDate value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyLeaseholdExpirationDateIsNull
		{
			get
			{
				return _propertyleaseholdexpirationdate_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyusagetype_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyusagetype.
		/// </summary>
		internal System.Int16 _propertyusagetype;
		/// <summary>
		/// Gets and sets the PropertyUsageType value of the class instance.
		/// </summary>
		public virtual System.Int16 PropertyUsageType
		{
			get
			{
				return _propertyusagetype;
			}
			set
			{
				_propertyusagetype = value;
				_propertyusagetype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyUsageType value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyUsageTypeIsNull
		{
			get
			{
				return _propertyusagetype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _propertyrightstype_isnull = true;
		/// <summary>
		/// Member that stores the value for the propertyrightstype.
		/// </summary>
		internal System.Int16 _propertyrightstype;
		/// <summary>
		/// Gets and sets the PropertyRightsType value of the class instance.
		/// </summary>
		public virtual System.Int16 PropertyRightsType
		{
			get
			{
				return _propertyrightstype;
			}
			set
			{
				_propertyrightstype = value;
				_propertyrightstype_isnull = false;
			}
		}


		/// <summary>
		/// Checks the PropertyRightsType value to see if it was set to null.
		/// </summary>
		public System.Boolean PropertyRightsTypeIsNull
		{
			get
			{
				return _propertyrightstype_isnull;
			}
		}


		/// <summary>
		/// Member that stores the null state of the related member.
		/// </summary>
		internal bool _type_isnull = true;
		/// <summary>
		/// Member that stores the value for the type.
		/// </summary>
		internal System.Int16 _type;
		/// <summary>
		/// Gets and sets the Type value of the class instance.
		/// </summary>
		public virtual System.Int16 Type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
				_type_isnull = false;
			}
		}


		/// <summary>
		/// Checks the Type value to see if it was set to null.
		/// </summary>
		public System.Boolean TypeIsNull
		{
			get
			{
				return _type_isnull;
			}
		}


		/// <summary>
		/// Gets the service object for the LoanPurposeBase.
		/// </summary>
		internal static LoanPurposeService ServiceObject
		{
			get
			{
				return GetServiceObject(typeof(LoanPurposeService)) as LoanPurposeService;
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


				if (!_loanapplicationid_assigned) exceptions = BusinessLogic.ChainException("LoanApplicationId is a required value of LoanPurposeBase. The value has not been explicitly assigned.", exceptions);


				return exceptions;
			}
		}



		#endregion Properties


		#region Methods

		/// <summary>
		/// Marks the GSETitleMannerHeldDescription value as null.
		/// </summary>
		public virtual void SetGSETitleMannerHeldDescriptionNull()
		{
			_gsetitlemannerhelddescription = null;
		}


		/// <summary>
		/// Marks the OtherLoanPurposeDescription value as null.
		/// </summary>
		public virtual void SetOtherLoanPurposeDescriptionNull()
		{
			_otherloanpurposedescription = null;
		}


		/// <summary>
		/// Marks the PropertyLeaseholdExpirationDate value as null.
		/// </summary>
		public virtual void SetPropertyLeaseholdExpirationDateNull()
		{
			_propertyleaseholdexpirationdate = DateTime.MinValue;
			_propertyleaseholdexpirationdate_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyUsageType value as null.
		/// </summary>
		public virtual void SetPropertyUsageTypeNull()
		{
			_propertyusagetype = 0;
			_propertyusagetype_isnull = true;
		}


		/// <summary>
		/// Marks the PropertyRightsType value as null.
		/// </summary>
		public virtual void SetPropertyRightsTypeNull()
		{
			_propertyrightstype = 0;
			_propertyrightstype_isnull = true;
		}


		/// <summary>
		/// Marks the Type value as null.
		/// </summary>
		public virtual void SetTypeNull()
		{
			_type = 0;
			_type_isnull = true;
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal virtual void SetMembers(ref LoanPurposeBase data)
		{


			// store a reference to this as an Entity class instance.
			Entity thisent = data as Entity;
			// make sure to always call up to the base
			base.SetMembers(ref thisent);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = data._loanapplicationid;
			_loanapplicationid_assigned = data._loanapplicationid_assigned;
			// assigns the GSETitleMannerHeldDescription data to the class member
			_gsetitlemannerhelddescription = data._gsetitlemannerhelddescription;
			// assigns the OtherLoanPurposeDescription data to the class member
			_otherloanpurposedescription = data._otherloanpurposedescription;
			// assigns the PropertyLeaseholdExpirationDate data to the class member
			_propertyleaseholdexpirationdate = data._propertyleaseholdexpirationdate;
			_propertyleaseholdexpirationdate_isnull = data._propertyleaseholdexpirationdate_isnull;
			// assigns the PropertyUsageType data to the class member
			_propertyusagetype = data._propertyusagetype;
			_propertyusagetype_isnull = data._propertyusagetype_isnull;
			// assigns the PropertyRightsType data to the class member
			_propertyrightstype = data._propertyrightstype;
			_propertyrightstype_isnull = data._propertyrightstype_isnull;
			// assigns the Type data to the class member
			_type = data._type;
			_type_isnull = data._type_isnull;


			RecalculateChecksum();
		}


		/// <summary>
		/// Sets the members of the class instance with data from the data layer framework.
		/// </summary>
		internal override void SetMembers(ref System.Data.SqlClient.SqlDataReader data)
		{


			// make sure to always call up to the base
			base.SetMembers(ref data);


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the GSETitleMannerHeldDescription data to the class member
			if (data["GSETitleMannerHeldDescription"] == System.DBNull.Value)
				SetGSETitleMannerHeldDescriptionNull();
			else
			{
				_gsetitlemannerhelddescription = Convert.ToString(data["GSETitleMannerHeldDescription"]);
			}
			// assigns the OtherLoanPurposeDescription data to the class member
			if (data["OtherLoanPurposeDescription"] == System.DBNull.Value)
				SetOtherLoanPurposeDescriptionNull();
			else
			{
				_otherloanpurposedescription = Convert.ToString(data["OtherLoanPurposeDescription"]);
			}
			// assigns the PropertyLeaseholdExpirationDate data to the class member
			if (data["PropertyLeaseholdExpirationDate"] == System.DBNull.Value)
				SetPropertyLeaseholdExpirationDateNull();
			else
			{
				_propertyleaseholdexpirationdate = Convert.ToDateTime(data["PropertyLeaseholdExpirationDate"]);
				_propertyleaseholdexpirationdate_isnull = false;
			}
			// assigns the PropertyUsageType data to the class member
			if (data["PropertyUsageType"] == System.DBNull.Value)
				SetPropertyUsageTypeNull();
			else
			{
				_propertyusagetype = Convert.ToInt16(data["PropertyUsageType"]);
				_propertyusagetype_isnull = false;
			}
			// assigns the PropertyRightsType data to the class member
			if (data["PropertyRightsType"] == System.DBNull.Value)
				SetPropertyRightsTypeNull();
			else
			{
				_propertyrightstype = Convert.ToInt16(data["PropertyRightsType"]);
				_propertyrightstype_isnull = false;
			}
			// assigns the Type data to the class member
			if (data["Type"] == System.DBNull.Value)
				SetTypeNull();
			else
			{
				_type = Convert.ToInt16(data["Type"]);
				_type_isnull = false;
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


			// assigns the LoanApplicationId data to the class member
			_loanapplicationid = Convert.ToInt64(data["LoanApplicationId"]);
			_loanapplicationid_assigned = true;
			// assigns the GSETitleMannerHeldDescription data to the class member
			if (data["GSETitleMannerHeldDescription"] == System.DBNull.Value)
				SetGSETitleMannerHeldDescriptionNull();
			else
			{
				_gsetitlemannerhelddescription = Convert.ToString(data["GSETitleMannerHeldDescription"]);
			}
			// assigns the OtherLoanPurposeDescription data to the class member
			if (data["OtherLoanPurposeDescription"] == System.DBNull.Value)
				SetOtherLoanPurposeDescriptionNull();
			else
			{
				_otherloanpurposedescription = Convert.ToString(data["OtherLoanPurposeDescription"]);
			}
			// assigns the PropertyLeaseholdExpirationDate data to the class member
			if (data["PropertyLeaseholdExpirationDate"] == System.DBNull.Value)
				SetPropertyLeaseholdExpirationDateNull();
			else
			{
				_propertyleaseholdexpirationdate = Convert.ToDateTime(data["PropertyLeaseholdExpirationDate"]);
				_propertyleaseholdexpirationdate_isnull = false;
			}
			// assigns the PropertyUsageType data to the class member
			if (data["PropertyUsageType"] == System.DBNull.Value)
				SetPropertyUsageTypeNull();
			else
			{
				_propertyusagetype = Convert.ToInt16(data["PropertyUsageType"]);
				_propertyusagetype_isnull = false;
			}
			// assigns the PropertyRightsType data to the class member
			if (data["PropertyRightsType"] == System.DBNull.Value)
				SetPropertyRightsTypeNull();
			else
			{
				_propertyrightstype = Convert.ToInt16(data["PropertyRightsType"]);
				_propertyrightstype_isnull = false;
			}
			// assigns the Type data to the class member
			if (data["Type"] == System.DBNull.Value)
				SetTypeNull();
			else
			{
				_type = Convert.ToInt16(data["Type"]);
				_type_isnull = false;
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
			LoanPurposeBase.ServiceObject.Persist(this as LoanPurpose, sqlTrans);


			// if this is a direct descendant then allow it to mark the persist flag
			// Mark the object as persisted if it hasn't already been marked
			if (!_persisted) _persisted = true;


			RecalculateChecksum();
		}


		/// <summary>
		/// Deletes the LOAN_PURPOSE object from its peristed location. Renders object unusable (Persisted will be false)
		/// </summary>
		public override void Delete()
		{
			// Do children logic first
			LoanPurposeBase.ServiceObject.Delete(this as LoanPurpose);


			// Now call the base for it to do its own thing
			base.Delete();
		}


		/// <summary>
		/// Gets the objects for the CONSTRUCTION_REFINANCE_DATA relationship.
		/// </summary>
		public ConstructionRefinanceDataCollection GetConstructionRefinanceDataCollection()
		{
			ConstructionRefinanceDataCollection constructionrefinancedatacollection = new ConstructionRefinanceDataCollection();


			ConstructionRefinanceDataBase.ServiceObject.FillByLoanPurpose(constructionrefinancedatacollection, _loanapplicationid);
			return constructionrefinancedatacollection;
		}


		/// <summary>
		/// Gets the single object for the LOAN_APPLICATION relationship.
		/// </summary>
		public LoanApplication GetLoanApplication()
		{
			if (_loanapplicationid_assigned)
				return null;
			else
				return new LoanApplication(_loanapplicationid);
		}


		/// <summary>
		/// Gets the single object for the PropertyUsageType relationship.
		/// </summary>
		public PropertyUsageType GetPropertyUsageType()
		{
			if (_propertyusagetype_isnull)
				return null;
			else
				return new PropertyUsageType(_propertyusagetype);
		}


		/// <summary>
		/// Gets the single object for the PropertyRightsType relationship.
		/// </summary>
		public PropertyRightsType GetPropertyRightsType()
		{
			if (_propertyrightstype_isnull)
				return null;
			else
				return new PropertyRightsType(_propertyrightstype);
		}


		/// <summary>
		/// Gets the single object for the PurposeType relationship.
		/// </summary>
		public PurposeType GetPurposeType()
		{
			if (_type_isnull)
				return null;
			else
				return new PurposeType(_type);
		}


		/// <summary>
		/// Gets all persisted LoanPurpose objects
		/// </summary>
		public static LoanPurposes GetAll()
		{
			// have the service object get the objects
			return LoanPurposeBase.ServiceObject.GetAll();
		}



		#endregion Methods

	}
}
