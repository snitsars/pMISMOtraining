using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MortgageScoreTypes collection.
	/// </summary>
	[Serializable]
	public class MortgageScoreTypes : MortgageScoreTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageScoreTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MortgageScoreTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MortgageScoreType[] items = (MortgageScoreType[])Info.GetValue("items",typeof(MortgageScoreType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MortgageScoreType)};


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
		public virtual MortgageScoreType this[int index]
		{
			get
			{
				return InnerList[index] as MortgageScoreType;
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
			MortgageScoreType[] items = (MortgageScoreType[])InnerList.ToArray(typeof(MortgageScoreType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
