using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'DEPENDENT'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class Dependent : DependentBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Dependent() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public Dependent(System.Int64 id) : base(id)
		{
		}



		#endregion Constructors

	}
}
