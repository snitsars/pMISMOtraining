using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a BuydownCollection collection.
	/// </summary>
	[Serializable]
	public class BuydownCollection : BuydownCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BuydownCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public BuydownCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			Buydown[] items = (Buydown[])Info.GetValue("items",typeof(Buydown[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(Buydown)};


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
		public virtual Buydown this[int index]
		{
			get
			{
				return InnerList[index] as Buydown;
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
			Buydown[] items = (Buydown[])InnerList.ToArray(typeof(Buydown));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
