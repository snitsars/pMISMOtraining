using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PropertyUsageTypes collection.
	/// </summary>
	[Serializable]
	public class PropertyUsageTypes : PropertyUsageTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PropertyUsageTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PropertyUsageTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PropertyUsageType[] items = (PropertyUsageType[])Info.GetValue("items",typeof(PropertyUsageType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PropertyUsageType)};


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
		public virtual PropertyUsageType this[int index]
		{
			get
			{
				return InnerList[index] as PropertyUsageType;
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
			PropertyUsageType[] items = (PropertyUsageType[])InnerList.ToArray(typeof(PropertyUsageType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
