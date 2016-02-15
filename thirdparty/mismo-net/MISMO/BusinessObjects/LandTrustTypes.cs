using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LandTrustTypes collection.
	/// </summary>
	[Serializable]
	public class LandTrustTypes : LandTrustTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LandTrustTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LandTrustTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LandTrustType[] items = (LandTrustType[])Info.GetValue("items",typeof(LandTrustType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LandTrustType)};


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
		public virtual LandTrustType this[int index]
		{
			get
			{
				return InnerList[index] as LandTrustType;
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
			LandTrustType[] items = (LandTrustType[])InnerList.ToArray(typeof(LandTrustType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
