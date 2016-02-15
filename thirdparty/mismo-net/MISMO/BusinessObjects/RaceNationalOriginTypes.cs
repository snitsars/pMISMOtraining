using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a RaceNationalOriginTypes collection.
	/// </summary>
	[Serializable]
	public class RaceNationalOriginTypes : RaceNationalOriginTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public RaceNationalOriginTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public RaceNationalOriginTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			RaceNationalOriginType[] items = (RaceNationalOriginType[])Info.GetValue("items",typeof(RaceNationalOriginType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(RaceNationalOriginType)};


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
		public virtual RaceNationalOriginType this[int index]
		{
			get
			{
				return InnerList[index] as RaceNationalOriginType;
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
			RaceNationalOriginType[] items = (RaceNationalOriginType[])InnerList.ToArray(typeof(RaceNationalOriginType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
