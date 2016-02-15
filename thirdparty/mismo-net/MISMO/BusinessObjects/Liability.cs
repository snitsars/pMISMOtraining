using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;


namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'LIABILITY'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class Liability : LiabilityBase
	{

		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Liability() : base()
		{
			// 
			// TODO: Add constructor logic here
			// 
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public Liability(System.Int64 id) : base(id)
		{
		}



		#endregion Constructors

		#region Properties

		/// <summary>
		/// Gets the core MISMO element name for the liability object.
		/// </summary>
		protected string ElementName
		{
			get { return "LIABILITY"; }
		}

		#endregion Properties
	}
}
