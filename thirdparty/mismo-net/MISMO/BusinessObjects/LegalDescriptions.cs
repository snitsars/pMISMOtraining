using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LegalDescriptions collection.
	/// </summary>
	[Serializable]
	public class LegalDescriptions : LegalDescriptionsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LegalDescriptions()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LegalDescriptions(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LegalDescription[] items = (LegalDescription[])Info.GetValue("items",typeof(LegalDescription[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LegalDescription)};


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
		public virtual LegalDescription this[int index]
		{
			get
			{
				return InnerList[index] as LegalDescription;
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
			LegalDescription[] items = (LegalDescription[])InnerList.ToArray(typeof(LegalDescription));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
