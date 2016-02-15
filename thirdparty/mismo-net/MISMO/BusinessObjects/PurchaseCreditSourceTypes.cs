using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PurchaseCreditSourceTypes collection.
	/// </summary>
	[Serializable]
	public class PurchaseCreditSourceTypes : PurchaseCreditSourceTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PurchaseCreditSourceTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PurchaseCreditSourceTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PurchaseCreditSourceType[] items = (PurchaseCreditSourceType[])Info.GetValue("items",typeof(PurchaseCreditSourceType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PurchaseCreditSourceType)};


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
		public virtual PurchaseCreditSourceType this[int index]
		{
			get
			{
				return InnerList[index] as PurchaseCreditSourceType;
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
			PurchaseCreditSourceType[] items = (PurchaseCreditSourceType[])InnerList.ToArray(typeof(PurchaseCreditSourceType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
