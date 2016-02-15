using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents the credit score object.
	/// </summary>
	[Serializable]
	public class CreditScore : MISMO.BusinessObjects.CreditScore
	{
		#region Constructors

		public CreditScore() : this(null)
		{
		}

		public CreditScore(Borrower borrower) : base()
		{
			_borrower = borrower;
		}

		#endregion Constructors

		#region Member Fields

		/// <summary>
		/// Member that stores the borrower reference for the credit score instance.
		/// </summary>
		internal Borrower _borrower = null;

		#endregion Member Fields

		#region Properties
	
		/// <summary>
		/// Gets any additional attributes for the credit score object.
		/// </summary>
		protected override System.Collections.Specialized.NameValueCollection AdditionalAttributes
		{
			get
			{
				System.Collections.Specialized.NameValueCollection addattrib = base.AdditionalAttributes;
				if (addattrib == null)
					addattrib = new System.Collections.Specialized.NameValueCollection();
				addattrib.Add("BorrowerIDREFS_Referencing_BorrowerIDs", _borrower.GetIDREF());

				return addattrib;
			}
		}


		#endregion Properties
	
	}
}
