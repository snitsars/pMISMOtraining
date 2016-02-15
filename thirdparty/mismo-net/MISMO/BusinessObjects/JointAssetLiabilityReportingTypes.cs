using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a JointAssetLiabilityReportingTypes collection.
	/// </summary>
	[Serializable]
	public class JointAssetLiabilityReportingTypes : JointAssetLiabilityReportingTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public JointAssetLiabilityReportingTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public JointAssetLiabilityReportingTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			JointAssetLiabilityReportingType[] items = (JointAssetLiabilityReportingType[])Info.GetValue("items",typeof(JointAssetLiabilityReportingType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(JointAssetLiabilityReportingType)};


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
		public virtual JointAssetLiabilityReportingType this[int index]
		{
			get
			{
				return InnerList[index] as JointAssetLiabilityReportingType;
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
			JointAssetLiabilityReportingType[] items = (JointAssetLiabilityReportingType[])InnerList.ToArray(typeof(JointAssetLiabilityReportingType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
