using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a LoanDocumentationTypes collection.
	/// </summary>
	[Serializable]
	public class LoanDocumentationTypes : LoanDocumentationTypesBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanDocumentationTypes()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public LoanDocumentationTypes(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			LoanDocumentationType[] items = (LoanDocumentationType[])Info.GetValue("items",typeof(LoanDocumentationType[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(LoanDocumentationType)};


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
		public virtual LoanDocumentationType this[int index]
		{
			get
			{
				return InnerList[index] as LoanDocumentationType;
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
			LoanDocumentationType[] items = (LoanDocumentationType[])InnerList.ToArray(typeof(LoanDocumentationType));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
