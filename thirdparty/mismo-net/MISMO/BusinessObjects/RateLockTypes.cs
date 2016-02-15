using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a RateLockTypes collection.
	/// </summary>
	[Serializable]
	public class RateLockTypes : RateLockTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public RateLockTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public RateLockTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			RateLockType[] items = (RateLockType[])Info.GetValue("items",typeof(RateLockType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(RateLockType)};


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
		public virtual RateLockType this[int index]
		{
			get
			{
				return InnerList[index] as RateLockType;
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
			RateLockType[] items = (RateLockType[])InnerList.ToArray(typeof(RateLockType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}