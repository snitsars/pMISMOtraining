using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a Appraisers collection.
	/// </summary>
	[Serializable]
	public class Appraisers : AppraisersBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Appraisers()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public Appraisers(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			Appraiser[] items = (Appraiser[])Info.GetValue("items",typeof(Appraiser[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(Appraiser)};


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
		public virtual Appraiser this[int index]
		{
			get
			{
				return InnerList[index] as Appraiser;
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
			Appraiser[] items = (Appraiser[])InnerList.ToArray(typeof(Appraiser));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
