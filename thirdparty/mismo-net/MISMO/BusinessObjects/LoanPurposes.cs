using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanPurposes collection.
	/// </summary>
	[Serializable]
	public class LoanPurposes : LoanPurposesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanPurposes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanPurposes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanPurpose[] items = (LoanPurpose[])Info.GetValue("items",typeof(LoanPurpose[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanPurpose)};


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
		public virtual LoanPurpose this[int index]
		{
			get
			{
				return InnerList[index] as LoanPurpose;
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
			LoanPurpose[] items = (LoanPurpose[])InnerList.ToArray(typeof(LoanPurpose));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
