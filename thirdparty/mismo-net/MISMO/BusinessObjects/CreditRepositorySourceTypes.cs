using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CreditRepositorySourceTypes collection.
	/// </summary>
	[Serializable]
	public class CreditRepositorySourceTypes : CreditRepositorySourceTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditRepositorySourceTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CreditRepositorySourceTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CreditRepositorySourceType[] items = (CreditRepositorySourceType[])Info.GetValue("items",typeof(CreditRepositorySourceType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CreditRepositorySourceType)};


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
		public virtual CreditRepositorySourceType this[int index]
		{
			get
			{
				return InnerList[index] as CreditRepositorySourceType;
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
			CreditRepositorySourceType[] items = (CreditRepositorySourceType[])InnerList.ToArray(typeof(CreditRepositorySourceType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
