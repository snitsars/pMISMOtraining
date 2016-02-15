using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a BaseDataTypes collection.
	/// </summary>
	[Serializable]
	public class BaseDataTypes : BaseDataTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BaseDataTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public BaseDataTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			BaseDataType[] items = (BaseDataType[])Info.GetValue("items",typeof(BaseDataType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(BaseDataType)};


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
		public virtual BaseDataType this[int index]
		{
			get
			{
				return InnerList[index] as BaseDataType;
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
			BaseDataType[] items = (BaseDataType[])InnerList.ToArray(typeof(BaseDataType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
