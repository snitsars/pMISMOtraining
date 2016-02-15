using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanClosingStatusTypes collection.
	/// </summary>
	[Serializable]
	public class LoanClosingStatusTypes : LoanClosingStatusTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanClosingStatusTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanClosingStatusTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanClosingStatusType[] items = (LoanClosingStatusType[])Info.GetValue("items",typeof(LoanClosingStatusType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanClosingStatusType)};


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
		public virtual LoanClosingStatusType this[int index]
		{
			get
			{
				return InnerList[index] as LoanClosingStatusType;
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
			LoanClosingStatusType[] items = (LoanClosingStatusType[])InnerList.ToArray(typeof(LoanClosingStatusType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
