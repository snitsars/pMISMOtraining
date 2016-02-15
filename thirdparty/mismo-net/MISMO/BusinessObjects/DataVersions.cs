using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a DataVersions collection.
	/// </summary>
	[Serializable]
	public class DataVersions : DataVersionsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DataVersions()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public DataVersions(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			DataVersion[] items = (DataVersion[])Info.GetValue("items",typeof(DataVersion[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(DataVersion)};


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
		public virtual DataVersion this[int index]
		{
			get
			{
				return InnerList[index] as DataVersion;
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
			DataVersion[] items = (DataVersion[])InnerList.ToArray(typeof(DataVersion));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
