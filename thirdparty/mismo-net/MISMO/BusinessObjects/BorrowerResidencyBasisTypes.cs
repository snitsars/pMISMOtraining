using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a BorrowerResidencyBasisTypes collection.
	/// </summary>
	[Serializable]
	public class BorrowerResidencyBasisTypes : BorrowerResidencyBasisTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public BorrowerResidencyBasisTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public BorrowerResidencyBasisTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			BorrowerResidencyBasisType[] items = (BorrowerResidencyBasisType[])Info.GetValue("items",typeof(BorrowerResidencyBasisType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(BorrowerResidencyBasisType)};


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
		public virtual BorrowerResidencyBasisType this[int index]
		{
			get
			{
				return InnerList[index] as BorrowerResidencyBasisType;
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
			BorrowerResidencyBasisType[] items = (BorrowerResidencyBasisType[])InnerList.ToArray(typeof(BorrowerResidencyBasisType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
