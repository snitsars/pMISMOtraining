using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a DataInformationCollection collection.
	/// </summary>
	[Serializable]
	public class DataInformationCollection : DataInformationCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DataInformationCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public DataInformationCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			DataInformation[] items = (DataInformation[])Info.GetValue("items",typeof(DataInformation[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(DataInformation)};


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
		public virtual DataInformation this[int index]
		{
			get
			{
				return InnerList[index] as DataInformation;
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
			DataInformation[] items = (DataInformation[])InnerList.ToArray(typeof(DataInformation));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
