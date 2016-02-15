using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a DispositionStatusTypes collection.
	/// </summary>
	[Serializable]
	public class DispositionStatusTypes : DispositionStatusTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public DispositionStatusTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public DispositionStatusTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			DispositionStatusType[] items = (DispositionStatusType[])Info.GetValue("items",typeof(DispositionStatusType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(DispositionStatusType)};


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
		public virtual DispositionStatusType this[int index]
		{
			get
			{
				return InnerList[index] as DispositionStatusType;
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
			DispositionStatusType[] items = (DispositionStatusType[])InnerList.ToArray(typeof(DispositionStatusType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
