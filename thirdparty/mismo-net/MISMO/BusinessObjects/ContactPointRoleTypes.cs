using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ContactPointRoleTypes collection.
	/// </summary>
	[Serializable]
	public class ContactPointRoleTypes : ContactPointRoleTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ContactPointRoleTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ContactPointRoleTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ContactPointRoleType[] items = (ContactPointRoleType[])Info.GetValue("items",typeof(ContactPointRoleType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ContactPointRoleType)};


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
		public virtual ContactPointRoleType this[int index]
		{
			get
			{
				return InnerList[index] as ContactPointRoleType;
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
			ContactPointRoleType[] items = (ContactPointRoleType[])InnerList.ToArray(typeof(ContactPointRoleType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
