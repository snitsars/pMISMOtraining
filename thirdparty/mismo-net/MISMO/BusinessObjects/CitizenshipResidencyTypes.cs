using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CitizenshipResidencyTypes collection.
	/// </summary>
	[Serializable]
	public class CitizenshipResidencyTypes : CitizenshipResidencyTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CitizenshipResidencyTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CitizenshipResidencyTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CitizenshipResidencyType[] items = (CitizenshipResidencyType[])Info.GetValue("items",typeof(CitizenshipResidencyType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CitizenshipResidencyType)};


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
		public virtual CitizenshipResidencyType this[int index]
		{
			get
			{
				return InnerList[index] as CitizenshipResidencyType;
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
			CitizenshipResidencyType[] items = (CitizenshipResidencyType[])InnerList.ToArray(typeof(CitizenshipResidencyType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
