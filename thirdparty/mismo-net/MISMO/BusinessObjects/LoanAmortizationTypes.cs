using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanAmortizationTypes collection.
	/// </summary>
	[Serializable]
	public class LoanAmortizationTypes : LoanAmortizationTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanAmortizationTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanAmortizationTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanAmortizationType[] items = (LoanAmortizationType[])Info.GetValue("items",typeof(LoanAmortizationType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanAmortizationType)};


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
		public virtual LoanAmortizationType this[int index]
		{
			get
			{
				return InnerList[index] as LoanAmortizationType;
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
			LoanAmortizationType[] items = (LoanAmortizationType[])InnerList.ToArray(typeof(LoanAmortizationType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
