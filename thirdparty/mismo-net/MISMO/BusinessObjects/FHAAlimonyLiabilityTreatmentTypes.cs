using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a FHAAlimonyLiabilityTreatmentTypes collection.
	/// </summary>
	[Serializable]
	public class FHAAlimonyLiabilityTreatmentTypes : FHAAlimonyLiabilityTreatmentTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAAlimonyLiabilityTreatmentTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public FHAAlimonyLiabilityTreatmentTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			FHAAlimonyLiabilityTreatmentType[] items = (FHAAlimonyLiabilityTreatmentType[])Info.GetValue("items",typeof(FHAAlimonyLiabilityTreatmentType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(FHAAlimonyLiabilityTreatmentType)};


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
		public virtual FHAAlimonyLiabilityTreatmentType this[int index]
		{
			get
			{
				return InnerList[index] as FHAAlimonyLiabilityTreatmentType;
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
			FHAAlimonyLiabilityTreatmentType[] items = (FHAAlimonyLiabilityTreatmentType[])InnerList.ToArray(typeof(FHAAlimonyLiabilityTreatmentType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
