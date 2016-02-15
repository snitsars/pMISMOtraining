using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CreditScoreExclusionReasonTypes collection.
	/// </summary>
	[Serializable]
	public class CreditScoreExclusionReasonTypes : CreditScoreExclusionReasonTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditScoreExclusionReasonTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CreditScoreExclusionReasonTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CreditScoreExclusionReasonType[] items = (CreditScoreExclusionReasonType[])Info.GetValue("items",typeof(CreditScoreExclusionReasonType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CreditScoreExclusionReasonType)};


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
		public virtual CreditScoreExclusionReasonType this[int index]
		{
			get
			{
				return InnerList[index] as CreditScoreExclusionReasonType;
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
			CreditScoreExclusionReasonType[] items = (CreditScoreExclusionReasonType[])InnerList.ToArray(typeof(CreditScoreExclusionReasonType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
