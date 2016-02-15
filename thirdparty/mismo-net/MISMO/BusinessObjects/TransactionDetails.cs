using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a TransactionDetails collection.
	/// </summary>
	[Serializable]
	public class TransactionDetails : TransactionDetailsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransactionDetails()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public TransactionDetails(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			TransactionDetail[] items = (TransactionDetail[])Info.GetValue("items",typeof(TransactionDetail[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(TransactionDetail)};


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
		public virtual TransactionDetail this[int index]
		{
			get
			{
				return InnerList[index] as TransactionDetail;
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
			TransactionDetail[] items = (TransactionDetail[])InnerList.ToArray(typeof(TransactionDetail));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
