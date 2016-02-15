using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PaymentFrequencyTypes collection.
	/// </summary>
	[Serializable]
	public class PaymentFrequencyTypes : PaymentFrequencyTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PaymentFrequencyTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PaymentFrequencyTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PaymentFrequencyType[] items = (PaymentFrequencyType[])Info.GetValue("items",typeof(PaymentFrequencyType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PaymentFrequencyType)};


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
		public virtual PaymentFrequencyType this[int index]
		{
			get
			{
				return InnerList[index] as PaymentFrequencyType;
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
			PaymentFrequencyType[] items = (PaymentFrequencyType[])InnerList.ToArray(typeof(PaymentFrequencyType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
