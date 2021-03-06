using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PurposeTypes collection.
	/// </summary>
	[Serializable]
	public class PurposeTypes : PurposeTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PurposeTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PurposeTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PurposeType[] items = (PurposeType[])Info.GetValue("items",typeof(PurposeType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PurposeType)};


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
		public virtual PurposeType this[int index]
		{
			get
			{
				return InnerList[index] as PurposeType;
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
			PurposeType[] items = (PurposeType[])InnerList.ToArray(typeof(PurposeType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
