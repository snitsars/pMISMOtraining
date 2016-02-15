using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanApplications collection.
	/// </summary>
	[Serializable]
	public class LoanApplications : LoanApplicationsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanApplications()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanApplications(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanApplication[] items = (LoanApplication[])Info.GetValue("items",typeof(LoanApplication[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanApplication)};


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
		public virtual LoanApplication this[int index]
		{
			get
			{
				return InnerList[index] as LoanApplication;
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
			LoanApplication[] items = (LoanApplication[])InnerList.ToArray(typeof(LoanApplication));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
