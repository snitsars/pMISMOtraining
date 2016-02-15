using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a valuation instance.
	/// </summary>
	[Serializable]
	public class Valuation : MISMO.BusinessObjects.Valuation
	{
		#region Constructors

		public Valuation() : base()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#endregion Constructors

		#region Properties
		
		/// <summary>
		/// Member that stores the appraiser for the valuation object.
		/// </summary>
		protected MISMO.BusinessObjects.Appraisers _appraisers = new MISMO.BusinessObjects.Appraisers();
		/// <summary>
		/// Gets the appraiser for the valuation object instance.
		/// </summary>
		public MISMO.BusinessObjects.Appraisers Appraisers
		{
			get { return _appraisers; }
		}

		#endregion Properties

		#region Methods

		internal override void SetMembers(ref MISMO.Entities.ValuationBase data)
		{
			// first call up to base
			base.SetMembers (ref data);

			// TODO fix the relationship ERD to correctly model after MISMO
//			_appraisers = this.g
		}


		#endregion Methods
	}
}
