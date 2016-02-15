using System;
using System.Runtime.Serialization;
using OrcaLogic;
using MISMO.Entities;
using OrcaLogic.Xml;

namespace MISMO.BusinessObjects
{
	/// <summary>
	/// Entity implementation for table 'LOAN_APPLICATION'.
	/// </summary>
	/// <remarks>
	/// ** OK to Add modifications to this file **
	/// </remarks>
	[Serializable]
	public class LoanApplication : LoanApplicationBase, IXmlFactoryElement
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public LoanApplication() : base()
		{
			_mismoversionid = "2.3.1";
		}


		/// <summary>
		/// Creates constructor that enables object to be populated by its identity items.
		/// </summary>
		public LoanApplication(System.Int64 id) : base(id)
		{
			_mismoversionid = "2.3.1";
		}



		#endregion Constructors

		#region Properties



		#endregion Properties

		#region Method

		/// <summary>
		/// Gets the binary formatted serialized set of bytes for the current instance.
		/// </summary>
		/// <returns>A byte array of serialized loan information.</returns>
		public virtual byte[] GetBytes()
		{
			System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			System.IO.MemoryStream ms = new System.IO.MemoryStream();
			bf.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
			bf.Serialize(ms, this);

			byte[] retbytes = ms.ToArray();

			ms.Close();

			return retbytes;
		}


		/// <summary>
		/// Gets the XML document representation for this loan application.
		/// </summary>
		/// <returns>An Xml document.</returns>
		public virtual System.Xml.XmlDocument ToXml()
		{
			return OrcaLogic.Xml.XmlFactory.GenerateDocument(this);
		}

		#endregion Method

		#region IXmlFactoryElement Members

		bool IXmlFactoryElement.ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			return this.ProcessAttribute(ref attributeEntry);
		}

		protected virtual bool ProcessAttribute(ref System.Collections.DictionaryEntry attributeEntry)
		{
			if (!MISMO.XmlHelper.CanProcessAttribute(this, ref attributeEntry)) return false;

			string key = attributeEntry.Key as string;
			if (key != "MISMOVersionID") return false; // not supported

			return true;
		}

		System.Collections.Specialized.NameValueCollection IXmlFactoryElement.AdditionalAttributes
		{
			get
			{
				return this.AdditionalAttributes;
			}
		}

		protected virtual System.Collections.Specialized.NameValueCollection AdditionalAttributes
		{
			get { return null; }
		}

		/// <summary>
		/// The name of the Xml element.
		/// </summary>
		string IXmlFactoryElement.ElementName
		{
			get
			{
				return this.ElementName;
			}
		}

		/// <summary>
		/// The name of the Xml element.
		/// </summary>
		protected virtual string ElementName
		{
			get
			{
				return "LOAN_APPLICATION";
			}
		}

		#endregion
	}
}
