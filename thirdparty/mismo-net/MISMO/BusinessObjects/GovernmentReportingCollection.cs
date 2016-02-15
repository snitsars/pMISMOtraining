using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a GovernmentReportingCollection collection.
	/// </summary>
	[Serializable]
	public class GovernmentReportingCollection : GovernmentReportingCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentReportingCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public GovernmentReportingCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			GovernmentReporting[] items = (GovernmentReporting[])Info.GetValue("items",typeof(GovernmentReporting[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(GovernmentReporting)};


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
		public virtual GovernmentReporting this[int index]
		{
			get
			{
				return InnerList[index] as GovernmentReporting;
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
			GovernmentReporting[] items = (GovernmentReporting[])InnerList.ToArray(typeof(GovernmentReporting));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
