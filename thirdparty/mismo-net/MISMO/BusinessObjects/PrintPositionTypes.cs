using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PrintPositionTypes collection.
	/// </summary>
	[Serializable]
	public class PrintPositionTypes : PrintPositionTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PrintPositionTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PrintPositionTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PrintPositionType[] items = (PrintPositionType[])Info.GetValue("items",typeof(PrintPositionType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PrintPositionType)};


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
		public virtual PrintPositionType this[int index]
		{
			get
			{
				return InnerList[index] as PrintPositionType;
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
			PrintPositionType[] items = (PrintPositionType[])InnerList.ToArray(typeof(PrintPositionType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
