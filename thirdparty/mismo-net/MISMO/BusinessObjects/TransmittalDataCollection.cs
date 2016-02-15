using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a TransmittalDataCollection collection.
	/// </summary>
	[Serializable]
	public class TransmittalDataCollection : TransmittalDataCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public TransmittalDataCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public TransmittalDataCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			TransmittalData[] items = (TransmittalData[])Info.GetValue("items",typeof(TransmittalData[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(TransmittalData)};


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
		public virtual TransmittalData this[int index]
		{
			get
			{
				return InnerList[index] as TransmittalData;
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
			TransmittalData[] items = (TransmittalData[])InnerList.ToArray(typeof(TransmittalData));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
