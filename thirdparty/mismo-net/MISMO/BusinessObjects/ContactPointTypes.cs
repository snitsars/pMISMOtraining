using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ContactPointTypes collection.
	/// </summary>
	[Serializable]
	public class ContactPointTypes : ContactPointTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ContactPointTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ContactPointTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ContactPointType[] items = (ContactPointType[])Info.GetValue("items",typeof(ContactPointType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ContactPointType)};


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
		public virtual ContactPointType this[int index]
		{
			get
			{
				return InnerList[index] as ContactPointType;
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
			ContactPointType[] items = (ContactPointType[])InnerList.ToArray(typeof(ContactPointType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
