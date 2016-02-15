using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanRepaymentTypes collection.
	/// </summary>
	[Serializable]
	public class LoanRepaymentTypes : LoanRepaymentTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanRepaymentTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanRepaymentTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanRepaymentType[] items = (LoanRepaymentType[])Info.GetValue("items",typeof(LoanRepaymentType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanRepaymentType)};


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
		public virtual LoanRepaymentType this[int index]
		{
			get
			{
				return InnerList[index] as LoanRepaymentType;
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
			LoanRepaymentType[] items = (LoanRepaymentType[])InnerList.ToArray(typeof(LoanRepaymentType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
