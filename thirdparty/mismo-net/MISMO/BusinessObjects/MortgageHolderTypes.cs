using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MortgageHolderTypes collection.
	/// </summary>
	[Serializable]
	public class MortgageHolderTypes : MortgageHolderTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageHolderTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MortgageHolderTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MortgageHolderType[] items = (MortgageHolderType[])Info.GetValue("items",typeof(MortgageHolderType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MortgageHolderType)};


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
		public virtual MortgageHolderType this[int index]
		{
			get
			{
				return InnerList[index] as MortgageHolderType;
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
			MortgageHolderType[] items = (MortgageHolderType[])InnerList.ToArray(typeof(MortgageHolderType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
