using System;
using System.Runtime.Serialization;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a collection of assets.
	/// </summary>
	[Serializable]
	public class Assets : MISMO.BusinessObjects.Assets
	{
		#region Member Fields

		/// <summary>
		/// Member that stores a reference to the borrower instance.
		/// </summary>
		protected Borrower _borrower = null;

		#endregion Member Fields

		public Assets(Borrower borrower) : base()
		{
			_borrower = borrower;
		}

		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public Assets(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			Asset[] items = (Asset[])Info.GetValue("items",typeof(Asset[]));
			InnerList.AddRange(items);
		}

		#region Methods

		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			// Move collection data into an array for serialization
			Asset[] items = (Asset[])InnerList.ToArray(typeof(Asset));
			info.AddValue("items",items);
		}

		public override int Add(MISMO.Entities.AssetBase assetBase)
		{
			Asset a = assetBase as Asset;
			if (a != null)
				a._borrower = _borrower;
			return base.Add (assetBase);
		}

		public override void Remove(MISMO.Entities.AssetBase assetBase)
		{
			Asset a = assetBase as Asset;
			if (a != null)
				a._borrower = null;
			base.Remove (assetBase);
		}



		#endregion Methods
	}
}
