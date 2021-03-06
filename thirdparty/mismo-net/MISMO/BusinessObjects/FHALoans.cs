using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a FHALoans collection.
	/// </summary>
	[Serializable]
	public class FHALoans : FHALoansBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FHALoans()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public FHALoans(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			FHALoan[] items = (FHALoan[])Info.GetValue("items",typeof(FHALoan[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(FHALoan)};


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
		public virtual FHALoan this[int index]
		{
			get
			{
				return InnerList[index] as FHALoan;
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
			FHALoan[] items = (FHALoan[])InnerList.ToArray(typeof(FHALoan));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
