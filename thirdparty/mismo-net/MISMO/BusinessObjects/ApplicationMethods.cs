using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// A class that represents a ApplicationMethods collection.
	/// </summary>
	[Serializable]
	public class ApplicationMethods : ApplicationMethodsBase, ISerializable
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ApplicationMethods()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public ApplicationMethods(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			ApplicationMethod[] items = (ApplicationMethod[])Info.GetValue("items",typeof(ApplicationMethod[]));
			InnerList.AddRange(items);
		}



		#endregion Constructors


		#region Properties

		/// <summary>
		/// Member that stores the supported type of the collection.
		/// </summary>
		private System.Type[] _type = {typeof(ApplicationMethod)};


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
		public virtual ApplicationMethod this[int index]
		{
			get
			{
				return InnerList[index] as ApplicationMethod;
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
			ApplicationMethod[] items = (ApplicationMethod[])InnerList.ToArray(typeof(ApplicationMethod));
			info.AddValue("items",items);
		}



		#endregion ISerializable Members

	}
}
