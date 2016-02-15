using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a DownPayments collection.
	/// </summary>
	[Serializable]
	public class DownPayments : DownPaymentsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DownPayments()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public DownPayments(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			DownPayment[] items = (DownPayment[])Info.GetValue("items",typeof(DownPayment[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(DownPayment)};


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
		public virtual DownPayment this[int index]
		{
			get
			{
				return InnerList[index] as DownPayment;
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
			DownPayment[] items = (DownPayment[])InnerList.ToArray(typeof(DownPayment));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
