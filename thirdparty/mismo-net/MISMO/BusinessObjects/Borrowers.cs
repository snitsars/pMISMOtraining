using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a Borrowers collection.
	/// </summary>
	[Serializable]
	public class Borrowers : BorrowersBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Borrowers()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public Borrowers(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			Borrower[] items = (Borrower[])Info.GetValue("items",typeof(Borrower[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(Borrower)};


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
		public virtual Borrower this[int index]
		{
			get
			{
				return InnerList[index] as Borrower;
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
			Borrower[] items = (Borrower[])InnerList.ToArray(typeof(Borrower));
			info.AddValue("items",items);
		}


		#endregion ISerializable Members

	}
}
