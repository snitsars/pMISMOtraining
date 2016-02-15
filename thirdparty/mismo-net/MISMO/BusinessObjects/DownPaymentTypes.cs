using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a DownPaymentTypes collection.
	/// </summary>
	[Serializable]
	public class DownPaymentTypes : DownPaymentTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DownPaymentTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public DownPaymentTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			DownPaymentType[] items = (DownPaymentType[])Info.GetValue("items",typeof(DownPaymentType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(DownPaymentType)};


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
		public virtual DownPaymentType this[int index]
		{
			get
			{
				return InnerList[index] as DownPaymentType;
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
			DownPaymentType[] items = (DownPaymentType[])InnerList.ToArray(typeof(DownPaymentType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
