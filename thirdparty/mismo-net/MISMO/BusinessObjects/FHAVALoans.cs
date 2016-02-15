using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a FHAVALoans collection.
	/// </summary>
	[Serializable]
	public class FHAVALoans : FHAVALoansBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHAVALoans()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public FHAVALoans(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			FHAVALoan[] items = (FHAVALoan[])Info.GetValue("items",typeof(FHAVALoan[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(FHAVALoan)};


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
		public virtual FHAVALoan this[int index]
		{
			get
			{
				return InnerList[index] as FHAVALoan;
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
			FHAVALoan[] items = (FHAVALoan[])InnerList.ToArray(typeof(FHAVALoan));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
