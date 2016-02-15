using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanQualifications collection.
	/// </summary>
	[Serializable]
	public class LoanQualifications : LoanQualificationsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanQualifications()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanQualifications(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanQualification[] items = (LoanQualification[])Info.GetValue("items",typeof(LoanQualification[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanQualification)};


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
		public virtual LoanQualification this[int index]
		{
			get
			{
				return InnerList[index] as LoanQualification;
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
			LoanQualification[] items = (LoanQualification[])InnerList.ToArray(typeof(LoanQualification));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
