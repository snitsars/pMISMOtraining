using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a Valuations collection.
	/// </summary>
	[Serializable]
	public class Valuations : ValuationsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Valuations()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public Valuations(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			Valuation[] items = (Valuation[])Info.GetValue("items",typeof(Valuation[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(Valuation)};


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
		public virtual Valuation this[int index]
		{
			get
			{
				return InnerList[index] as Valuation;
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
			Valuation[] items = (Valuation[])InnerList.ToArray(typeof(Valuation));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
