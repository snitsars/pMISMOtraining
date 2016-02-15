using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MaritalStatusTypes collection.
	/// </summary>
	[Serializable]
	public class MaritalStatusTypes : MaritalStatusTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MaritalStatusTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MaritalStatusTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MaritalStatusType[] items = (MaritalStatusType[])Info.GetValue("items",typeof(MaritalStatusType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MaritalStatusType)};


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
		public virtual MaritalStatusType this[int index]
		{
			get
			{
				return InnerList[index] as MaritalStatusType;
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
			MaritalStatusType[] items = (MaritalStatusType[])InnerList.ToArray(typeof(MaritalStatusType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
