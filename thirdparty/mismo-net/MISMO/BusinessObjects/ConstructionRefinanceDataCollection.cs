using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ConstructionRefinanceDataCollection collection.
	/// </summary>
	[Serializable]
	public class ConstructionRefinanceDataCollection : ConstructionRefinanceDataCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ConstructionRefinanceDataCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ConstructionRefinanceDataCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ConstructionRefinanceData[] items = (ConstructionRefinanceData[])Info.GetValue("items",typeof(ConstructionRefinanceData[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ConstructionRefinanceData)};


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
		public virtual ConstructionRefinanceData this[int index]
		{
			get
			{
				return InnerList[index] as ConstructionRefinanceData;
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
			ConstructionRefinanceData[] items = (ConstructionRefinanceData[])InnerList.ToArray(typeof(ConstructionRefinanceData));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
