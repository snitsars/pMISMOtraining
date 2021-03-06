using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ParsedStreetAddresses collection.
	/// </summary>
	[Serializable]
	public class ParsedStreetAddresses : ParsedStreetAddressesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ParsedStreetAddresses()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ParsedStreetAddresses(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ParsedStreetAddress[] items = (ParsedStreetAddress[])Info.GetValue("items",typeof(ParsedStreetAddress[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ParsedStreetAddress)};


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
		public virtual ParsedStreetAddress this[int index]
		{
			get
			{
				return InnerList[index] as ParsedStreetAddress;
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
			ParsedStreetAddress[] items = (ParsedStreetAddress[])InnerList.ToArray(typeof(ParsedStreetAddress));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
