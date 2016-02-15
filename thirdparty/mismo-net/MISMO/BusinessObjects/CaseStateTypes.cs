using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a CaseStateTypes collection.
	/// </summary>
	[Serializable]
	public class CaseStateTypes : CaseStateTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public CaseStateTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CaseStateTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CaseStateType[] items = (CaseStateType[])Info.GetValue("items",typeof(CaseStateType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(CaseStateType)};


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
		public virtual CaseStateType this[int index]
		{
			get
			{
				return InnerList[index] as CaseStateType;
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
			CaseStateType[] items = (CaseStateType[])InnerList.ToArray(typeof(CaseStateType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
