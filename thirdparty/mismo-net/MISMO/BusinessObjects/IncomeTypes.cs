using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a IncomeTypes collection.
	/// </summary>
	[Serializable]
	public class IncomeTypes : IncomeTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public IncomeTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public IncomeTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			IncomeType[] items = (IncomeType[])Info.GetValue("items",typeof(IncomeType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(IncomeType)};


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
		public virtual IncomeType this[int index]
		{
			get
			{
				return InnerList[index] as IncomeType;
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
			IncomeType[] items = (IncomeType[])InnerList.ToArray(typeof(IncomeType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
