using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a MortgageTermsCollection collection.
	/// </summary>
	[Serializable]
	public class MortgageTermsCollection : MortgageTermsCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MortgageTermsCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public MortgageTermsCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			MortgageTerms[] items = (MortgageTerms[])Info.GetValue("items",typeof(MortgageTerms[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(MortgageTerms)};


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
		public virtual MortgageTerms this[int index]
		{
			get
			{
				return InnerList[index] as MortgageTerms;
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
			MortgageTerms[] items = (MortgageTerms[])InnerList.ToArray(typeof(MortgageTerms));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
