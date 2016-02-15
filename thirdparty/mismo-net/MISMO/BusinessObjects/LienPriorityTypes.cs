using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LienPropertyTypes collection.
	/// </summary>
	[Serializable]
	public class LienPriorityTypes : LienPriorityTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LienPriorityTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LienPriorityTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LienPriorityType[] items = (LienPriorityType[])Info.GetValue("items",typeof(LienPriorityType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LienPriorityType)};


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
		public virtual LienPriorityType this[int index]
		{
			get
			{
				return InnerList[index] as LienPriorityType;
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
			LienPriorityType[] items = (LienPriorityType[])InnerList.ToArray(typeof(LienPriorityType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}