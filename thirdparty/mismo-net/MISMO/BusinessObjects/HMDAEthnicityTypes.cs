using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a HMDAEthnicityTypes collection.
	/// </summary>
	[Serializable]
	public class HMDAEthnicityTypes : HMDAEthnicityTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HMDAEthnicityTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public HMDAEthnicityTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			HMDAEthnicityType[] items = (HMDAEthnicityType[])Info.GetValue("items",typeof(HMDAEthnicityType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(HMDAEthnicityType)};


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
		public virtual HMDAEthnicityType this[int index]
		{
			get
			{
				return InnerList[index] as HMDAEthnicityType;
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
			HMDAEthnicityType[] items = (HMDAEthnicityType[])InnerList.ToArray(typeof(HMDAEthnicityType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
