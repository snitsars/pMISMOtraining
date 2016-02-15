using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PriorPropertyTitleTypes collection.
	/// </summary>
	[Serializable]
	public class PriorPropertyTitleTypes : PriorPropertyTitleTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PriorPropertyTitleTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PriorPropertyTitleTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PriorPropertyTitleType[] items = (PriorPropertyTitleType[])Info.GetValue("items",typeof(PriorPropertyTitleType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PriorPropertyTitleType)};


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
		public virtual PriorPropertyTitleType this[int index]
		{
			get
			{
				return InnerList[index] as PriorPropertyTitleType;
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
			PriorPropertyTitleType[] items = (PriorPropertyTitleType[])InnerList.ToArray(typeof(PriorPropertyTitleType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
