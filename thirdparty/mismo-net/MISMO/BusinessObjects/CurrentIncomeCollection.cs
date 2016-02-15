using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CurrentIncomeCollection collection.
	/// </summary>
	[Serializable]
	public class CurrentIncomeCollection : CurrentIncomeCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CurrentIncomeCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CurrentIncomeCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CurrentIncome[] items = (CurrentIncome[])Info.GetValue("items",typeof(CurrentIncome[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CurrentIncome)};


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
		public virtual CurrentIncome this[int index]
		{
			get
			{
				return InnerList[index] as CurrentIncome;
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
			CurrentIncome[] items = (CurrentIncome[])InnerList.ToArray(typeof(CurrentIncome));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
