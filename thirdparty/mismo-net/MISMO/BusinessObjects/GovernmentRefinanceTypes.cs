using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a GovernmentRefinanceTypes collection.
	/// </summary>
	[Serializable]
	public class GovernmentRefinanceTypes : GovernmentRefinanceTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentRefinanceTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public GovernmentRefinanceTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			GovernmentRefinanceType[] items = (GovernmentRefinanceType[])Info.GetValue("items",typeof(GovernmentRefinanceType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(GovernmentRefinanceType)};


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
		public virtual GovernmentRefinanceType this[int index]
		{
			get
			{
				return InnerList[index] as GovernmentRefinanceType;
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
			GovernmentRefinanceType[] items = (GovernmentRefinanceType[])InnerList.ToArray(typeof(GovernmentRefinanceType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
