using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PaymentAdjustments collection.
	/// </summary>
	[Serializable]
	public class PaymentAdjustments : PaymentAdjustmentsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PaymentAdjustments()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PaymentAdjustments(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PaymentAdjustment[] items = (PaymentAdjustment[])Info.GetValue("items",typeof(PaymentAdjustment[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PaymentAdjustment)};


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
		public virtual PaymentAdjustment this[int index]
		{
			get
			{
				return InnerList[index] as PaymentAdjustment;
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
			PaymentAdjustment[] items = (PaymentAdjustment[])InnerList.ToArray(typeof(PaymentAdjustment));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
