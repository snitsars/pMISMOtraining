using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a RefinanceImprovementsTypes collection.
	/// </summary>
	[Serializable]
	public class RefinanceImprovementsTypes : RefinanceImprovementsTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public RefinanceImprovementsTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public RefinanceImprovementsTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			RefinanceImprovementsType[] items = (RefinanceImprovementsType[])Info.GetValue("items",typeof(RefinanceImprovementsType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(RefinanceImprovementsType)};


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
		public virtual RefinanceImprovementsType this[int index]
		{
			get
			{
				return InnerList[index] as RefinanceImprovementsType;
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
			RefinanceImprovementsType[] items = (RefinanceImprovementsType[])InnerList.ToArray(typeof(RefinanceImprovementsType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
