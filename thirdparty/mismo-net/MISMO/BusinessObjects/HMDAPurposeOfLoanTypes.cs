using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a HMDAPurposeOfLoanTypes collection.
	/// </summary>
	[Serializable]
	public class HMDAPurposeOfLoanTypes : HMDAPurposeOfLoanTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HMDAPurposeOfLoanTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public HMDAPurposeOfLoanTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			HMDAPurposeOfLoanType[] items = (HMDAPurposeOfLoanType[])Info.GetValue("items",typeof(HMDAPurposeOfLoanType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(HMDAPurposeOfLoanType)};


		/// <summary>
		/// Gets the internal supported type of the collection.
		/// </summary>
		public override System.Type[] ContainsType
		{
			get
			{
				return _type;
			}
		}


		/// <summary>
		/// Gets or sets the object instance from the specified index location.
		/// </summary>
		public virtual HMDAPurposeOfLoanType this[int index]
		{
			get
			{
				return InnerList[index] as HMDAPurposeOfLoanType;
			}
			set
			{
				InnerReplace(index, value);
			}
		}



		#endregion Properties


		#region ISerializable Members

		/// <summary>
		/// Helper method for serialization of the instance.
		/// </summary>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// Move collection data into an array for serialization
			HMDAPurposeOfLoanType[] items = (HMDAPurposeOfLoanType[])InnerList.ToArray(typeof(HMDAPurposeOfLoanType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
