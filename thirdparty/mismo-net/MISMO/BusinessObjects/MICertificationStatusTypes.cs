using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MICertificationStatusTypes collection.
	/// </summary>
	[Serializable]
	public class MICertificationStatusTypes : MICertificationStatusTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MICertificationStatusTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MICertificationStatusTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MICertificationStatusType[] items = (MICertificationStatusType[])Info.GetValue("items",typeof(MICertificationStatusType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MICertificationStatusType)};


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
		public virtual MICertificationStatusType this[int index]
		{
			get
			{
				return InnerList[index] as MICertificationStatusType;
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
			MICertificationStatusType[] items = (MICertificationStatusType[])InnerList.ToArray(typeof(MICertificationStatusType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
