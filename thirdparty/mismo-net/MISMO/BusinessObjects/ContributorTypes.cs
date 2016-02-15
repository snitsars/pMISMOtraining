using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ContributorTypes collection.
	/// </summary>
	[Serializable]
	public class ContributorTypes : ContributorTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ContributorTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ContributorTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ContributorType[] items = (ContributorType[])Info.GetValue("items",typeof(ContributorType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ContributorType)};


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
		public virtual ContributorType this[int index]
		{
			get
			{
				return InnerList[index] as ContributorType;
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
			ContributorType[] items = (ContributorType[])InnerList.ToArray(typeof(ContributorType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
