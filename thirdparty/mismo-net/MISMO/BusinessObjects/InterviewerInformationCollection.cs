using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a InterviewerInformationCollection collection.
	/// </summary>
	[Serializable]
	public class InterviewerInformationCollection : InterviewerInformationCollectionBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public InterviewerInformationCollection()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public InterviewerInformationCollection(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			InterviewerInformation[] items = (InterviewerInformation[])Info.GetValue("items",typeof(InterviewerInformation[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(InterviewerInformation)};


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
		public virtual InterviewerInformation this[int index]
		{
			get
			{
				return InnerList[index] as InterviewerInformation;
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
			InterviewerInformation[] items = (InterviewerInformation[])InnerList.ToArray(typeof(InterviewerInformation));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
