using System;
using System.Runtime.Serialization;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// Summary description for Liabilities.
	/// </summary>
	[Serializable]
	public class Liabilities : MISMO.BusinessObjects.Liabilities
	{
		#region Member Fields

		/// <summary>
		/// Member that stores a reference to the borrower instance.
		/// </summary>
		protected Borrower _borrower = null;

		#endregion Member Fields

		/// <summary>
		/// Default constructor
		/// </summary>
		public Liabilities()
		{

		}

		public Liabilities(Borrower borrower) : base()
		{
			_borrower = borrower;
		}

		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public Liabilities(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			Liability[] items = (Liability[])Info.GetValue("items",typeof(Liability[]));
			InnerList.AddRange(items);
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// Move collection data into an array for serialization
			Liability[] items = (Liability[])InnerList.ToArray(typeof(Liability));
			info.AddValue("items",items);			
		}

	}
}
