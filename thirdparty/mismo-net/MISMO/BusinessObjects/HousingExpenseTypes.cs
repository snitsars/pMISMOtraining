using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a HousingExpenseTypes collection.
	/// </summary>
	[Serializable]
	public class HousingExpenseTypes : HousingExpenseTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public HousingExpenseTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public HousingExpenseTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			HousingExpenseType[] items = (HousingExpenseType[])Info.GetValue("items",typeof(HousingExpenseType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(HousingExpenseType)};


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
		public virtual HousingExpenseType this[int index]
		{
			get
			{
				return InnerList[index] as HousingExpenseType;
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
			HousingExpenseType[] items = (HousingExpenseType[])InnerList.ToArray(typeof(HousingExpenseType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
