using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a property instance.
	/// </summary>
	[Serializable]
	public class Property : MISMO.BusinessObjects.Property
	{

		#region Constructors

		public Property() : base()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the legal description of the loan property.
		/// </summary>
		internal MISMO.BusinessObjects.LegalDescriptions _legaldescs = new MISMO.BusinessObjects.LegalDescriptions();
		/// <summary>
		/// Get or set the legal description collection of the property instance.
		/// </summary>
		public MISMO.BusinessObjects.LegalDescriptions LegalDescriptions
		{
			get { return _legaldescs; }
		}

		/// <summary>
		/// Member that stores the parsed street address of the loan property.
		/// </summary>
		internal MISMO.BusinessObjects.ParsedStreetAddress _parsedaddress = null;
		/// <summary>
		/// Gets the parsed street object of the property instance.
		/// </summary>
		public MISMO.BusinessObjects.ParsedStreetAddress ParsedStreetAddress
		{
			get 
			{ 
				return _parsedaddress; 
			}
		}

		/// <summary>
		/// Member that stores the valuation of the loan property.
		/// </summary>
		protected MISMO.BusinessObjects.Valuations _valuations = new MISMO.BusinessObjects.Valuations();
		/// <summary>
		/// Gets the valuation object of the property instance.
		/// </summary>
		public MISMO.BusinessObjects.Valuations Valuations 
		{
			get { return _valuations; }
			set { _valuations = value; }
		}

		
			
		#endregion Properties

		#region Methods

		internal override void SetMembers(ref MISMO.Entities.PropertyBase data)
		{
			// make a call to the base to set the members for the base structures.
			base.SetMembers (ref data);

			// now since this object is set...we can get instance of the other data elements.

			// get the legal descriptions
			_legaldescs = this.GetLegalDescriptions();
			
			// get the parsed address if it exists
			MISMO.BusinessObjects.ParsedStreetAddresses parsedaddys = this.GetParsedStreetAddresses();
			if (parsedaddys != null && parsedaddys.Count > 0)
				_parsedaddress = parsedaddys[0];

			// get the valuations into the right object model
			MISMO.BusinessObjects.Valuations vals = this.GetValuations();
			MISMO.Entities.ValuationBase valbase = null;
			MISMO.BusinessObjects.AUS.Valuation val = null;

			if (vals != null && vals.Count > 0)
			{
				for(int i = 0, j = vals.Count; i<j; i++)
				{
					val = new AUS.Valuation();
					valbase = vals[i];

					val.SetMembers(ref valbase);
					_valuations.Add(val);
				}
			}

			// update the checksum
			this.RecalculateChecksum();
		}


		/// <summary>
		/// Gets a new instance of the valutation object that is compatible with this object instance.
		/// </summary>
		/// <returns>A new valuation object.</returns>
		public MISMO.BusinessObjects.AUS.Valuation NewValuation()
		{
			return new MISMO.BusinessObjects.AUS.Valuation();
		}

		#endregion Methods

	}
}
