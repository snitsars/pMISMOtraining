using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a PresentHousingExpenses collection.
	/// </summary>
	[Serializable]
	public class PresentHousingExpenses : PresentHousingExpensesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public PresentHousingExpenses()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public PresentHousingExpenses(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			PresentHousingExpense[] items = (PresentHousingExpense[])Info.GetValue("items",typeof(PresentHousingExpense[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(PresentHousingExpense)};


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
		public virtual PresentHousingExpense this[int index]
		{
			get
			{
				return InnerList[index] as PresentHousingExpense;
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
			PresentHousingExpense[] items = (PresentHousingExpense[])InnerList.ToArray(typeof(PresentHousingExpense));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
