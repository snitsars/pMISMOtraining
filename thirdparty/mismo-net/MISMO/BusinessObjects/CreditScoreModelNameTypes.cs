using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CreditScoreModelNameTypes collection.
	/// </summary>
	[Serializable]
	public class CreditScoreModelNameTypes : CreditScoreModelNameTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CreditScoreModelNameTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CreditScoreModelNameTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CreditScoreModelNameType[] items = (CreditScoreModelNameType[])Info.GetValue("items",typeof(CreditScoreModelNameType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CreditScoreModelNameType)};


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
		public virtual CreditScoreModelNameType this[int index]
		{
			get
			{
				return InnerList[index] as CreditScoreModelNameType;
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
			CreditScoreModelNameType[] items = (CreditScoreModelNameType[])InnerList.ToArray(typeof(CreditScoreModelNameType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
