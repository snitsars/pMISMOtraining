using System;

namespace MISMO.BusinessObjects.AUS
{
	/// <summary>
	/// A class that represents an asset.
	/// </summary>
	[Serializable]
	public class Borrower : MISMO.BusinessObjects.Borrower
	{
		#region Member Fields


		#endregion Member Fields

		#region Constructors

		public Borrower() : base()
		{
			_creditscores = new CreditScores(this);
			_assets = new Assets(this);
		}

		#endregion Constructors

		#region Properties

		/// <summary>
		/// Member that stores the collection of aliases for the borrower instance.
		/// </summary>
		protected MISMO.BusinessObjects.Aliases _aliases = new Aliases();
		/// <summary>
		/// Gets the aliases for the borrower instance.
		/// </summary>
		public MISMO.BusinessObjects.Aliases Aliases 
		{
			get { return _aliases; }
		}

		/// <summary>
		/// Member that stores the mail to object instance reference.
		/// </summary>
		protected MISMO.BusinessObjects.MailTo _mailto = null;
		/// <summary>
		/// Gets the mail to instance of the borrower object.
		/// </summary>
		public MISMO.BusinessObjects.MailTo MailTo
		{
			get { return _mailto; }
		}

		/// <summary>
		/// Member that stores the residence collection instance.
		/// </summary>
		protected MISMO.BusinessObjects.Residences _residences = new Residences();
		/// <summary>
		/// Gets the residence collection associated with borrower instance.
		/// </summary>
		public MISMO.BusinessObjects.Residences Residences
		{
			get { return _residences; }
		}

		/// <summary>
		/// Member that stores the dependent collection instance.
		/// </summary>
		protected MISMO.BusinessObjects.Dependents _dependents = new BusinessObjects.Dependents();
		/// <summary>
		/// Gets the depends for the specified borrower instance.
		/// </summary>
		public MISMO.BusinessObjects.Dependents Dependents
		{
			get { return _dependents; }
		}

		/// <summary>
		/// Member that stores the current income collection instance
		/// </summary>
		protected MISMO.BusinessObjects.CurrentIncomeCollection _currentIncomes = new CurrentIncomeCollection();
		/// <summary>
		/// Gets the current income collection associated with borrower instance
		/// </summary>
		public MISMO.BusinessObjects.CurrentIncomeCollection CurrentIncomes
		{
			get { return _currentIncomes; }
		}

		/// <summary>
		/// Member that stores the declaration instance
		/// </summary>
		protected MISMO.BusinessObjects.AUS.Declaration _declaration = null;
		/// <summary>
		/// Gets the declaration associated with the borrower instance
		/// </summary>
		public MISMO.BusinessObjects.AUS.Declaration Declaration
		{
			get { return _declaration; }
			set { _declaration = value; }
		}

		/// <summary>
		/// Member that stores the employer instance
		/// </summary>
		protected MISMO.BusinessObjects.Employers _employers = new BusinessObjects.Employers();
		/// <summary>
		/// Gets the employer associated with the borrower instance
		/// </summary>
		public MISMO.BusinessObjects.Employers Employers
		{
			get { return _employers; }
		}

		/// <summary>
		/// Member that stores the present housing expense instance
		/// </summary>
		protected MISMO.BusinessObjects.PresentHousingExpenses _presentHousingExpenses = new PresentHousingExpenses();
		/// <summary>
		/// Gets the present housing expense for the borrower
		/// </summary>
		public MISMO.BusinessObjects.PresentHousingExpenses PresentHousingExpenses 
		{
			get { return _presentHousingExpenses; }
		}

		/// <summary>
		/// Member that stores the contact point instance
		/// </summary>
		protected MISMO.BusinessObjects.ContactPointCollection _contactpoints = new MISMO.BusinessObjects.ContactPointCollection();
		/// <summary>
		/// Gets the contact point for the borrower
		/// </summary>
		public MISMO.BusinessObjects.ContactPointCollection ContactPoints
		{
			get { return _contactpoints; }
		}

		/// <summary>
		/// Member that stores the summary instance
		/// </summary>
		protected MISMO.BusinessObjects.Summaries _summaries = new BusinessObjects.Summaries();
		/// <summary>
		/// Gets the summary for the borrower
		/// </summary>
		public MISMO.BusinessObjects.Summaries Summaries
		{
			get { return _summaries; }
		}

		/// <summary>
		/// Member that stores the asset for the borrower instance.
		/// </summary>
		protected Assets _assets = null;
		/// <summary>
		/// Gets the assets collection for the borrower instance.
		/// </summary>
		public Assets Assets
		{
			get { return _assets; }
		}

		/// <summary>
		/// Member that stores the liability for the borrower instance.
		/// </summary>
		protected Liabilities _liabilities = new Liabilities();
		/// <summary>
		/// Gets the liabilities collection for the borrower instance.
		/// </summary>
		public Liabilities Liabilities
		{
			get { return _liabilities; }
		}

		/// <summary>
		/// Member that stores the collection of credit scores for the borrower instance.
		/// </summary>
		protected CreditScores _creditscores = null;
		/// <summary>
		/// Gets the credit scores associated with the borrower instance.
		/// </summary>
		public CreditScores CreditScores
		{
			get { return _creditscores; }
		}

		/// <summary>
		/// Member that stores the government monitoring object for the borrower instance.
		/// </summary>
		protected GovernmentMonitoring _govmon = null;
		/// <summary>
		/// Gets the government monitoring instance for the borrower.
		/// </summary>
		public GovernmentMonitoring GovernmentMonitoring
		{
			get { return _govmon; }
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// Creates an Xml element from the parent element of the object instance, adds it to the parent element, and returns a reference to the caller.
		/// </summary>
		/// <param name="parentElement">The parent element to add this element to.</param>
		/// <returns>A reference to the newly created and added element.</returns>
		internal override System.Xml.XmlElement ToXml(System.Xml.XmlElement parentElement)
		{
			// create and get a reference to this element.
			System.Xml.XmlElement thiselem = base.ToXml(parentElement);
			System.Xml.XmlElement xelem = null;

			xelem = OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.MailTo);

			// render the residences
			for(int k = 0; k<this.Aliases.Count; k++)
			{
				xelem = OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.Aliases[k]);
			}


			// render the residences
			for(int k = 0; k<this.Residences.Count; k++)
			{
				xelem = OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.Residences[k]);
			}

			// render current income
			for (int k = 0; k < this.CurrentIncomes.Count; k++)
			{
				xelem = OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.CurrentIncomes[k]);
			}

			// render declaration 
			if (_declaration != null)
				_declaration.ToXml(thiselem);

			// render employers
			for(int k = 0, l = this.Employers.Count; k<l; k++)
			{
				OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.Employers[k]);
			}
																

			// render govt monitoring tag
			xelem = OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.GovernmentMonitoring);

			if (this.GovernmentMonitoring != null && this.GovernmentMonitoring.HMDARaces.Count > 0)
			{
				for(int k = 0; k<this.GovernmentMonitoring.HMDARaces.Count; k++)
				{
					OrcaLogic.Xml.XmlFactory.GenerateElement(xelem, this.GovernmentMonitoring.HMDARaces[k]);
				}
			}

			// render present housing expense
			for (int k = 0; k < this.PresentHousingExpenses.Count; k++)
			{
				OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.PresentHousingExpenses[k]);
			}

			// render the summary
			for(int k = 0, l = this.Summaries.Count; k<l; k++)
			{
				OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.Summaries[k]);
			}

			// render the contact points
			for(int k = 0, l = this.ContactPoints.Count; k<l; k++)
			{
				OrcaLogic.Xml.XmlFactory.GenerateElement(thiselem, this.ContactPoints[k]);
			}

			return thiselem;
		}

		/// <summary>
		/// Persist the object and its sub object to the database via a specified transaction.
		/// </summary>
		/// <param name="sqlTrans">A transaction object that manages the transaction.</param>
		internal override void Persist(System.Data.SqlClient.SqlTransaction sqlTrans)
		{
			// let the base do its work first
			base.Persist (sqlTrans);

			// persist the aliases
			for(int j = 0, k = _aliases.Count; j<k; j++)
			{
				_aliases[j].BorrowerId = _id;
				_aliases[j].Persist(sqlTrans);
			}	

			// persist the mailto
			if (_mailto != null)
			{
				_mailto.BorrowerId = _id;
				_mailto.Persist(sqlTrans);
			}

			// persist the residences
			for(int i = 0, j = _residences.Count; i<j; i++)
			{
				_residences[i].BorrowerId = _id;
				_residences[i].Persist(sqlTrans);
			}

			// persist the current income
			for(int i = 0, j = _currentIncomes.Count; i<j; i++)
			{
				_currentIncomes[i].BorrowerId = _id;
				_currentIncomes[i].Persist(sqlTrans);
			}

			// persist the declaration
			if (_declaration != null)
			{
				_declaration.BorrowerId = _id;
				_declaration.Persist(sqlTrans);
			}

			// persist the dependents
			for(int i = 0, j = _dependents.Count; i<j; i++)
			{
				_dependents[i].BorrowerId = _id;
				_dependents[i].Persist(sqlTrans);
			}

			// persist the employers
			for(int i = 0, j = _employers.Count; i<j; i++)
			{
				_employers[i].BorrowerId = _id;
				_employers[i].Persist(sqlTrans);
			}

			// persist the government monitoring
			if (_govmon != null)
			{
				_govmon.BorrowerId = _id;
				_govmon.Persist(sqlTrans);
			}

			// persist the present housing expenses
			for(int i = 0, j = _presentHousingExpenses.Count; i<j; i++)
			{
				_presentHousingExpenses[i].BorrowerId = _id;
				_presentHousingExpenses[i].Persist(sqlTrans);
			}

			// persist the summaries
			for(int i = 0, j = _summaries.Count; i<j; i++)
			{
				_summaries[i].BorrowerId = _id;
				_summaries[i].Persist(sqlTrans);
			}

			// persist the contact points
			for(int i = 0, j = _contactpoints.Count; i<j; i++)
			{
				_contactpoints[i].BorrowerId = _id;
				_contactpoints[i].Persist(sqlTrans);
			}


			// persist the borrower's assets
			for(int j = 0, k = _assets.Count; j<k; j++)
			{
				_assets[j].BorrowerId = _id;
				_assets[j].LoanApplicationId = _loanapplicationid;
				_assets[j].Persist(sqlTrans);
			}

			// persist the borrower's credit scores.
			for(int j = 0, k = _creditscores.Count; j<k; j++)
			{
				_creditscores[j].BorrowerId = _id;
				_creditscores[j].Persist(sqlTrans);
			}

			// persist the borrower's liabilities
			for(int j = 0, k = _liabilities.Count; j<k; j++)
			{
				_liabilities[j].BorrowerId = _id;
				_liabilities[j].LoanApplicationId = _loanapplicationid;
				_liabilities[j].Persist(sqlTrans);
			}			

	

			// recalulate the checksum after persisting all the nested elements
			RecalculateChecksum();
		}


		internal override void SetMembers(ref MISMO.Entities.BorrowerBase data)
		{
			// first call up to the base
			base.SetMembers (ref data);

			// load up the aliases
			_aliases = this.GetAliases();

			// load up the mailto
			MISMO.BusinessObjects.MailToCollection mailtocol = this.GetMailToCollection();
			if (mailtocol != null && mailtocol.Count > 0)
			{
				_mailto = mailtocol[0];
			}

			// load up the residences
			_residences = this.GetResidences();

			// load up the current incomes
			_currentIncomes = this.GetCurrentIncomeCollection();

			// load up the assets
			MISMO.BusinessObjects.Assets assets = this.GetAssets();
			if (assets != null && assets.Count > 0)
			{
				MISMO.Entities.AssetBase assetbase = null;
				AUS.Asset asset = null;

				for(int i = 0, j = assets.Count; i<j; i++)
				{
					asset = new AUS.Asset();
					asset._borrower = this;
					assetbase = assets[i];
					asset.SetMembers(ref assetbase);
					_assets.Add(asset);
				}
			}

			// load up the contact points
			_contactpoints = this.GetContactPointCollection();

			// load up the credit scores
			MISMO.BusinessObjects.CreditScores cscores = this.GetCreditScores();
			if (cscores != null && cscores.Count > 0)
			{
				MISMO.Entities.CreditScoreBase csbase = null;
				AUS.CreditScore cscore = null;
				for(int i = 0, j = cscores.Count; i<j; i++)
				{
					csbase = cscores[i];
					cscore = new AUS.CreditScore(this);
					cscore.SetMembers(ref csbase);
					_creditscores.Add(cscore);
				}
			}

			// load up declaration
			MISMO.BusinessObjects.Declarations decls = this.GetDeclarations();
			if (decls != null && decls.Count > 0)
			{
				MISMO.Entities.DeclarationBase declbase = decls[0];
				_declaration = new MISMO.BusinessObjects.AUS.Declaration();
				_declaration.SetMembers(ref declbase);
			}

			// load up the employers
			_employers = this.GetEmployers();

			// load up the government monitoring
			MISMO.BusinessObjects.GovernmentMonitoringCollection govmons = this.GetGovernmentMonitoringCollection();
			if (govmons != null && govmons.Count > 0)
			{
				MISMO.Entities.GovernmentMonitoringBase govbase = govmons[0];
				_govmon = new AUS.GovernmentMonitoring();
				_govmon.SetMembers(ref govbase);
			}

			// load up the liabilities
			MISMO.BusinessObjects.Liabilities liabs = this.GetLiabilities();
			if (liabs != null && liabs.Count > 0)
			{
				MISMO.Entities.LiabilityBase liabase = null;
				AUS.Liability liab = null;
				for(int i = 0, j = liabs.Count; i<j; i++)
				{
					liabase = liabs[i];
					liab = new AUS.Liability();
					liab._borrower = this;
					liab.SetMembers(ref liabase);
					_liabilities.Add(liab);
				}
			}

			// load up the present housing expenses
			_presentHousingExpenses = this.GetPresentHousingExpenses();

			// load up the summaries
			_summaries = this.GetSummaries();

			// recalc the checksum
			RecalculateChecksum();
		}


		#endregion Methods

	}
}
