using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MailToCollection collection.
	/// </summary>
	[Serializable]
	public class MailToCollection : MailToCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MailToCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MailToCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MailTo[] items = (MailTo[])Info.GetValue("items",typeof(MailTo[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MailTo)};


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
		public virtual MailTo this[int index]
		{
			get
			{
				return InnerList[index] as MailTo;
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
			MailTo[] items = (MailTo[])InnerList.ToArray(typeof(MailTo));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
