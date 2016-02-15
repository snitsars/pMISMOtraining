using System;
using System.Runtime.Serialization;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// Summary description for Borrowers.
	/// </summary>
	[Serializable]
	public class Borrowers : MISMO.BusinessObjects.Borrowers
	{
		public Borrowers() : base()
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

		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			// Move collection data into an array for serialization
			Borrower[] items = (Borrower[])InnerList.ToArray(typeof(Borrower));
			info.AddValue("items",items);
		}

	}
}
