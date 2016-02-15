using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a AffordableLendingCollection collection.
	/// </summary>
	[Serializable]
	public class AffordableLendingCollection : AffordableLendingCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AffordableLendingCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public AffordableLendingCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			AffordableLending[] items = (AffordableLending[])Info.GetValue("items",typeof(AffordableLending[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(AffordableLending)};


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
		public virtual AffordableLending this[int index]
		{
			get
			{
				return InnerList[index] as AffordableLending;
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
			AffordableLending[] items = (AffordableLending[])InnerList.ToArray(typeof(AffordableLending));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
