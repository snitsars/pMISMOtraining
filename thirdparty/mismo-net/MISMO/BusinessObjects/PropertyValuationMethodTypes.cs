using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PropertyValuationMethodTypes collection.
	/// </summary>
	[Serializable]
	public class PropertyValuationMethodTypes : PropertyValuationMethodTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PropertyValuationMethodTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PropertyValuationMethodTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PropertyValuationMethodType[] items = (PropertyValuationMethodType[])Info.GetValue("items",typeof(PropertyValuationMethodType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PropertyValuationMethodType)};


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
		public virtual PropertyValuationMethodType this[int index]
		{
			get
			{
				return InnerList[index] as PropertyValuationMethodType;
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
			PropertyValuationMethodType[] items = (PropertyValuationMethodType[])InnerList.ToArray(typeof(PropertyValuationMethodType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
