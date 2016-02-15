using System;
using System.Runtime.Serialization;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents a collection of credit scores.
	/// </summary>
	[Serializable]
	public class CreditScores : MISMO.BusinessObjects.CreditScores
	{
		#region Member Fields
		
		/// <summary>
		/// Member that stores the borrower for the credit scores collection instance.
		/// </summary>
		internal Borrower _borrower = null;

		#endregion Member Fields

		#region Constructors

		/// <summary>
		/// Creates a new instance of a credit scores collection for the specified borrower.
		/// </summary>
		/// <param name="borrower"></param>
		public CreditScores(Borrower borrower) : base()
		{
			_borrower = borrower;
		}

		/// <summary>
		/// Deserialization Constructor
		/// </summary>
		public CreditScores(SerializationInfo Info, StreamingContext Context)
		{
			// // deserialize into the inner list
			CreditScore[] items = (CreditScore[])Info.GetValue("items",typeof(CreditScore[]));
			InnerList.AddRange(items);
		}

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Gets the first credit score from the collection by the specified repository source type.
		/// </summary>
		/// <param name="sourceType">The repository source type.</param>
		/// <returns>An AUS credit score object or null if the repository entry does not exist.</returns>
		public AUS.CreditScore GetByRepository(MISMO.Enums.CreditRepositorySourceType sourceType)
		{
			for(int i = 0, j = this.Count; i<j; i++)
			{
				AUS.CreditScore curscore = this[i] as AUS.CreditScore;
				if (curscore.CreditRepositorySourceType == (short) sourceType)
					return curscore;
			}
			return null;
		}

		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			// Move collection data into an array for serialization
			CreditScore[] items = (CreditScore[])InnerList.ToArray(typeof(CreditScore));
			info.AddValue("items",items);
		}

		/// <summary>
		/// Adds a new credit object to the collection with the specified source type and score values.
		/// </summary>
		/// <param name="sourceType">The credit repository source type.</param>
		/// <param name="creditScore">The credit score.</param>
		/// <returns>The position of the addition in the collection</returns>
		public int Add(MISMO.Enums.CreditRepositorySourceType sourceType, short creditScore)
		{
			AUS.CreditScore credscore = new AUS.CreditScore(_borrower);
			credscore.CreditRepositorySourceType = (short) sourceType;
			credscore.CreditScoreValue = creditScore;
			return this.Add(credscore);
		}

		/// <summary>
		/// Adds an AUS credit score object to the collection of credit scores for the borrower.
		/// </summary>
		/// <param name="creditScore">An AUS credit score object.</param>
		/// <returns>The position of the addition in the collection.</returns>
		public int Add(AUS.CreditScore creditScore)
		{
			if (!Object.ReferenceEquals(creditScore._borrower, this._borrower)) creditScore._borrower = _borrower;
			return this.Add(creditScore as MISMO.Entities.CreditScoreBase);
		}

		/// <summary>
		/// Adds a new credit score object to the collection of credit score objects.
		/// </summary>
		/// <param name="creditScoreBase">A credit score base object.</param>
		/// <returns>The position of the addition in the collection.</returns>
		public override int Add(MISMO.Entities.CreditScoreBase creditScoreBase)
		{
			if (creditScoreBase == null) throw new ArgumentNullException("creditScoreBase", "You may only a valid AUS.CreditScore object to the credit score collection.");
			CreditScore score = creditScoreBase as CreditScore;
			if (!Object.ReferenceEquals(score._borrower, this._borrower)) score._borrower = _borrower;
			return base.Add(creditScoreBase);
		}
 
		public override void Remove(MISMO.Entities.CreditScoreBase creditScoreBase)
		{
			CreditScore score = creditScoreBase as CreditScore;
			score._borrower = null;

			base.Remove (creditScoreBase);
		}

		#endregion Methods

		#region Properties

		/// <summary>
		/// Gets or sets the credit score for the specified repository type.
		/// </summary>
		/// <remarks>
		/// If they do not exist, a -1 value is returned. Otherwise, the score itself is returned.
		/// </remarks>
		public short this[MISMO.Enums.CreditRepositorySourceType sourceType]
		{
			get 
			{
				AUS.CreditScore score = this.GetByRepository(sourceType);
				return (score == null ? (short) -1 : score.CreditScoreValue);
			}
			set 
			{
				AUS.CreditScore score = this.GetByRepository(sourceType);
				if (score == null)
				{
					this.Add(sourceType, value);
				}
			}
		}

		#endregion Properties
	}
}
