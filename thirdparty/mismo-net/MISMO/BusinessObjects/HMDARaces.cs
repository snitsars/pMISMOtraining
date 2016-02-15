using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a HMDARaces collection.
	/// </summary>
	[Serializable]
	public class HMDARaces : HMDARacesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HMDARaces()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public HMDARaces(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			HMDARace[] items = (HMDARace[])Info.GetValue("items",typeof(HMDARace[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(HMDARace)};


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
		public virtual HMDARace this[int index]
		{
			get
			{
				return InnerList[index] as HMDARace;
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
			HMDARace[] items = (HMDARace[])InnerList.ToArray(typeof(HMDARace));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
