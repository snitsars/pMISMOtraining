using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PurchaseCreditTypes collection.
	/// </summary>
	[Serializable]
	public class PurchaseCreditTypes : PurchaseCreditTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PurchaseCreditTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PurchaseCreditTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PurchaseCreditType[] items = (PurchaseCreditType[])Info.GetValue("items",typeof(PurchaseCreditType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PurchaseCreditType)};


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
		public virtual PurchaseCreditType this[int index]
		{
			get
			{
				return InnerList[index] as PurchaseCreditType;
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
			PurchaseCreditType[] items = (PurchaseCreditType[])InnerList.ToArray(typeof(PurchaseCreditType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
