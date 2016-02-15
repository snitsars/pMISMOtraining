using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a BorrowerResidencyTypes collection.
	/// </summary>
	[Serializable]
	public class BorrowerResidencyTypes : BorrowerResidencyTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BorrowerResidencyTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public BorrowerResidencyTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			BorrowerResidencyType[] items = (BorrowerResidencyType[])Info.GetValue("items",typeof(BorrowerResidencyType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(BorrowerResidencyType)};


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
		public virtual BorrowerResidencyType this[int index]
		{
			get
			{
				return InnerList[index] as BorrowerResidencyType;
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
			BorrowerResidencyType[] items = (BorrowerResidencyType[])InnerList.ToArray(typeof(BorrowerResidencyType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
