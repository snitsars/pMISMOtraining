using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ConstructionPurposeTypes collection.
	/// </summary>
	[Serializable]
	public class ConstructionPurposeTypes : ConstructionPurposeTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ConstructionPurposeTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ConstructionPurposeTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ConstructionPurposeType[] items = (ConstructionPurposeType[])Info.GetValue("items",typeof(ConstructionPurposeType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ConstructionPurposeType)};


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
		public virtual ConstructionPurposeType this[int index]
		{
			get
			{
				return InnerList[index] as ConstructionPurposeType;
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
			ConstructionPurposeType[] items = (ConstructionPurposeType[])InnerList.ToArray(typeof(ConstructionPurposeType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
