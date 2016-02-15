using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a GSEPropertyTypes collection.
	/// </summary>
	[Serializable]
	public class GSEPropertyTypes : GSEPropertyTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GSEPropertyTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public GSEPropertyTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			GSEPropertyType[] items = (GSEPropertyType[])Info.GetValue("items",typeof(GSEPropertyType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(GSEPropertyType)};


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
		public virtual GSEPropertyType this[int index]
		{
			get
			{
				return InnerList[index] as GSEPropertyType;
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
			GSEPropertyType[] items = (GSEPropertyType[])InnerList.ToArray(typeof(GSEPropertyType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
