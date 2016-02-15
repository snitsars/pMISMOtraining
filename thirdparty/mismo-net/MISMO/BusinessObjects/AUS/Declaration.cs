using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents an AUS declaration for a borrower.
	/// </summary>
	[Serializable]
	public class Declaration : MISMO.BusinessObjects.Declaration
	{
		#region Constructors

		/// <summary>
		/// Creates a new instance of the declaration.
		/// </summary>
		public Declaration() : base()
		{
			// refactor the checksum
			RecalculateChecksum();
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the explanations for a borrower's declaration.
		/// </summary>
		protected MISMO.BusinessObjects.Explanations _explanations = new BusinessObjects.Explanations();
		/// <summary>
		/// Gets the explanations for the borrower's declaration instance.
		/// </summary>
		public MISMO.BusinessObjects.Explanations Explanations
		{
			get { return _explanations; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Persist the object and its sub object to the database via a specified transaction.
		/// </summary>
		/// <param name="sqlTrans">A transaction object that manages the transaction.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// first call the base's persist
			base.Persist(sqlTrans);

			// now persist the dependent objects
			for(int i = 0, j = _explanations.Count; i<j; i++)
			{
				_explanations[i].BorrowerId = _borrowerid;
				_explanations[i].Persist(sqlTrans);
			}

			// refactor the checksum
			RecalculateChecksum();
		}


		/// <summary>
		/// Creates the xml element of the current object instance for the specified parent element.
		/// </summary>
		/// <param name="parentElement">The parent element to create the element for and to add to.</param>
		/// <returns>A reference of the object's XmlElement object.</returns>
		internal override System.Xml.XmlElement ToXml(System.Xml.XmlElement parentElement)
		{
			// call base to render the element.
			System.Xml.XmlElement thiselement = base.ToXml(parentElement);

			for(int i = 0, j = _explanations.Count; i<j; i++)
			{
				_explanations[i].ToXml(thiselement);
			}

			return thiselement;
		}

		#endregion Methods
	}
}
