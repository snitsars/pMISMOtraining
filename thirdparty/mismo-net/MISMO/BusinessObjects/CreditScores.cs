using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CreditScores collection.
	/// </summary>
	[Serializable]
	public class CreditScores : CreditScoresBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditScores()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CreditScores(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CreditScore[] items = (CreditScore[])Info.GetValue("items",typeof(CreditScore[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CreditScore)};


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
		public virtual CreditScore this[int index]
		{
			get
			{
				return InnerList[index] as CreditScore;
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
			CreditScore[] items = (CreditScore[])InnerList.ToArray(typeof(CreditScore));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
