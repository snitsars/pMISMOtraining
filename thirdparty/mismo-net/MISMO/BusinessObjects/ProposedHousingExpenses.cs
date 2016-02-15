using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ProposedHousingExpenses collection.
	/// </summary>
	[Serializable]
	public class ProposedHousingExpenses : ProposedHousingExpensesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ProposedHousingExpenses()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ProposedHousingExpenses(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ProposedHousingExpense[] items = (ProposedHousingExpense[])Info.GetValue("items",typeof(ProposedHousingExpense[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ProposedHousingExpense)};


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
		public virtual ProposedHousingExpense this[int index]
		{
			get
			{
				return InnerList[index] as ProposedHousingExpense;
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
			ProposedHousingExpense[] items = (ProposedHousingExpense[])InnerList.ToArray(typeof(ProposedHousingExpense));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
