using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a HMDARaceTypes collection.
	/// </summary>
	[Serializable]
	public class HMDARaceTypes : HMDARaceTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HMDARaceTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public HMDARaceTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			HMDARaceType[] items = (HMDARaceType[])Info.GetValue("items",typeof(HMDARaceType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(HMDARaceType)};


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
		public virtual HMDARaceType this[int index]
		{
			get
			{
				return InnerList[index] as HMDARaceType;
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
			HMDARaceType[] items = (HMDARaceType[])InnerList.ToArray(typeof(HMDARaceType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
