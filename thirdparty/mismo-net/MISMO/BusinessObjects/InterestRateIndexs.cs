using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a InterestRateIndexs collection.
	/// </summary>
	[Serializable]
	public class InterestRateIndexs : InterestRateIndexsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public InterestRateIndexs()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public InterestRateIndexs(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			InterestRateIndex[] items = (InterestRateIndex[])Info.GetValue("items",typeof(InterestRateIndex[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(InterestRateIndex)};


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
		public virtual InterestRateIndex this[int index]
		{
			get
			{
				return InnerList[index] as InterestRateIndex;
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
			InterestRateIndex[] items = (InterestRateIndex[])InnerList.ToArray(typeof(InterestRateIndex));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
