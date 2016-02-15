using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a GSERefinancePurposeTypes collection.
	/// </summary>
	[Serializable]
	public class GSERefinancePurposeTypes : GSERefinancePurposeTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GSERefinancePurposeTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public GSERefinancePurposeTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			GSERefinancePurposeType[] items = (GSERefinancePurposeType[])Info.GetValue("items",typeof(GSERefinancePurposeType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(GSERefinancePurposeType)};


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
		public virtual GSERefinancePurposeType this[int index]
		{
			get
			{
				return InnerList[index] as GSERefinancePurposeType;
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
			GSERefinancePurposeType[] items = (GSERefinancePurposeType[])InnerList.ToArray(typeof(GSERefinancePurposeType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
