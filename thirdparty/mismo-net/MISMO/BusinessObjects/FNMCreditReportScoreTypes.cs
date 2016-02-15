using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a FNMCreditReportScoreTypes collection.
	/// </summary>
	[Serializable]
	public class FNMCreditReportScoreTypes : FNMCreditReportScoreTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public FNMCreditReportScoreTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public FNMCreditReportScoreTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			FNMCreditReportScoreType[] items = (FNMCreditReportScoreType[])Info.GetValue("items",typeof(FNMCreditReportScoreType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(FNMCreditReportScoreType)};


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
		public virtual FNMCreditReportScoreType this[int index]
		{
			get
			{
				return InnerList[index] as FNMCreditReportScoreType;
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
			FNMCreditReportScoreType[] items = (FNMCreditReportScoreType[])InnerList.ToArray(typeof(FNMCreditReportScoreType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
