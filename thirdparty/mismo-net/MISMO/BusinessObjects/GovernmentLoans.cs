using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a GovernmentLoans collection.
	/// </summary>
	[Serializable]
	public class GovernmentLoans : GovernmentLoansBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentLoans()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public GovernmentLoans(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			GovernmentLoan[] items = (GovernmentLoan[])Info.GetValue("items",typeof(GovernmentLoan[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(GovernmentLoan)};


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
		public virtual GovernmentLoan this[int index]
		{
			get
			{
				return InnerList[index] as GovernmentLoan;
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
			GovernmentLoan[] items = (GovernmentLoan[])InnerList.ToArray(typeof(GovernmentLoan));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
