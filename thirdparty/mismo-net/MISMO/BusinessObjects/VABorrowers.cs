using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a VABorrowers collection.
	/// </summary>
	[Serializable]
	public class VABorrowers : VABorrowersBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public VABorrowers()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public VABorrowers(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			VABorrower[] items = (VABorrower[])Info.GetValue("items",typeof(VABorrower[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(VABorrower)};


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
		public virtual VABorrower this[int index]
		{
			get
			{
				return InnerList[index] as VABorrower;
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
			VABorrower[] items = (VABorrower[])InnerList.ToArray(typeof(VABorrower));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
