using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a GovernmentMonitoringCollection collection.
	/// </summary>
	[Serializable]
	public class GovernmentMonitoringCollection : GovernmentMonitoringCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public GovernmentMonitoringCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public GovernmentMonitoringCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			GovernmentMonitoring[] items = (GovernmentMonitoring[])Info.GetValue("items",typeof(GovernmentMonitoring[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(GovernmentMonitoring)};


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
		public virtual GovernmentMonitoring this[int index]
		{
			get
			{
				return InnerList[index] as GovernmentMonitoring;
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
			GovernmentMonitoring[] items = (GovernmentMonitoring[])InnerList.ToArray(typeof(GovernmentMonitoring));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
