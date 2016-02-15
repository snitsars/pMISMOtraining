using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a NameDocumentsDrawnInTypes collection.
	/// </summary>
	[Serializable]
	public class NameDocumentsDrawnInTypes : NameDocumentsDrawnInTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public NameDocumentsDrawnInTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public NameDocumentsDrawnInTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			NameDocumentsDrawnInType[] items = (NameDocumentsDrawnInType[])Info.GetValue("items",typeof(NameDocumentsDrawnInType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(NameDocumentsDrawnInType)};


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
		public virtual NameDocumentsDrawnInType this[int index]
		{
			get
			{
				return InnerList[index] as NameDocumentsDrawnInType;
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
			NameDocumentsDrawnInType[] items = (NameDocumentsDrawnInType[])InnerList.ToArray(typeof(NameDocumentsDrawnInType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
