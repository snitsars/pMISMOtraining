using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ServicingTransferStatusTypes collection.
	/// </summary>
	[Serializable]
	public class ServicingTransferStatusTypes : ServicingTransferStatusTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ServicingTransferStatusTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ServicingTransferStatusTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ServicingTransferStatusType[] items = (ServicingTransferStatusType[])Info.GetValue("items",typeof(ServicingTransferStatusType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ServicingTransferStatusType)};


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
		public virtual ServicingTransferStatusType this[int index]
		{
			get
			{
				return InnerList[index] as ServicingTransferStatusType;
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
			ServicingTransferStatusType[] items = (ServicingTransferStatusType[])InnerList.ToArray(typeof(ServicingTransferStatusType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
