using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a FullPrepaymentPenaltyOptionTypes collection.
	/// </summary>
	[Serializable]
	public class FullPrepaymentPenaltyOptionTypes : FullPrepaymentPenaltyOptionTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FullPrepaymentPenaltyOptionTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public FullPrepaymentPenaltyOptionTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			FullPrepaymentPenaltyOptionType[] items = (FullPrepaymentPenaltyOptionType[])Info.GetValue("items",typeof(FullPrepaymentPenaltyOptionType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(FullPrepaymentPenaltyOptionType)};


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
		public virtual FullPrepaymentPenaltyOptionType this[int index]
		{
			get
			{
				return InnerList[index] as FullPrepaymentPenaltyOptionType;
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
			FullPrepaymentPenaltyOptionType[] items = (FullPrepaymentPenaltyOptionType[])InnerList.ToArray(typeof(FullPrepaymentPenaltyOptionType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
