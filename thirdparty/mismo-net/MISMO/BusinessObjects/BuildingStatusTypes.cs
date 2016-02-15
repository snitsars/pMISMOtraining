using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a BuildingStatusTypes collection.
	/// </summary>
	[Serializable]
	public class BuildingStatusTypes : BuildingStatusTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BuildingStatusTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public BuildingStatusTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			BuildingStatusType[] items = (BuildingStatusType[])Info.GetValue("items",typeof(BuildingStatusType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(BuildingStatusType)};


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
		public virtual BuildingStatusType this[int index]
		{
			get
			{
				return InnerList[index] as BuildingStatusType;
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
			BuildingStatusType[] items = (BuildingStatusType[])InnerList.ToArray(typeof(BuildingStatusType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
