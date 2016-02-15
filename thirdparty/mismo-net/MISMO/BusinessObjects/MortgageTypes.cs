using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MortgageTypes collection.
	/// </summary>
	[Serializable]
	public class MortgageTypes : MortgageTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MortgageTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MortgageType[] items = (MortgageType[])Info.GetValue("items",typeof(MortgageType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MortgageType)};


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
		public virtual MortgageType this[int index]
		{
			get
			{
				return InnerList[index] as MortgageType;
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
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// Move collection data into an array for serialization
			MortgageType[] items = (MortgageType[])InnerList.ToArray(typeof(MortgageType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
