using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanProductDataCollection collection.
	/// </summary>
	[Serializable]
	public class LoanProductDataCollection : LoanProductDataCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanProductDataCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanProductDataCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanProductData[] items = (LoanProductData[])Info.GetValue("items",typeof(LoanProductData[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanProductData)};


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
		public virtual LoanProductData this[int index]
		{
			get
			{
				return InnerList[index] as LoanProductData;
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
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// Move collection data into an array for serialization
			LoanProductData[] items = (LoanProductData[])InnerList.ToArray(typeof(LoanProductData));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
