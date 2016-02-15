using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a FHAVABorrowers collection.
	/// </summary>
	[Serializable]
	public class FHAVABorrowers : FHAVABorrowersBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVABorrowers()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public FHAVABorrowers(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			FHAVABorrower[] items = (FHAVABorrower[])Info.GetValue("items",typeof(FHAVABorrower[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(FHAVABorrower)};


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
		public virtual FHAVABorrower this[int index]
		{
			get
			{
				return InnerList[index] as FHAVABorrower;
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
			FHAVABorrower[] items = (FHAVABorrower[])InnerList.ToArray(typeof(FHAVABorrower));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
