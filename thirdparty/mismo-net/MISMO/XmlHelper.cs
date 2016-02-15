using System;
using OrcaLogic.Reflection;

namespace MISMO
{
	/// <summary>
	/// A class that represents a MISMO xml helper.
	/// </summary>
	internal sealed class XmlHelper
	{
		#region Member Variables

		/// <summary>
		/// Member that stores the field table hash of the MISMO library.
		/// </summary>
		private static System.Collections.Hashtable _fieldtablehash = System.Collections.Hashtable.Synchronized(new System.Collections.Hashtable());

		#endregion Member Variables
		
		#region Constructors

		private XmlHelper()
		{
			//
			// prevents instantiation
			//
		}

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Gets the truth indicator of whether we can process the xml attribute or not.
		/// </summary>
		/// <param name="attributeContainer">The class or object containing the attributes themselves.</param>
		/// <param name="attributeEntry">The dictionary entry of the attribute (name value pair).</param>
		/// <returns>True if we can process and false otherwise.</returns>
		public static bool CanProcessAttribute(object attributeContainer, ref System.Collections.DictionaryEntry attributeEntry)
		{
			if (attributeContainer == null) return false; // of course we can't process

			string key = attributeEntry.Key as string;

			// translate the value from boolean indicators to Y | N
			if (attributeEntry.Value != null && attributeEntry.Value.GetType() == typeof(System.Boolean))
			{
				bool boolval = (bool) attributeEntry.Value;
				attributeEntry.Value = (boolval ? "Y" : "N");
			}

			if (key != null) // reject the framewok attributes
			{
				if (key.IndexOf("IsNull") >= 0) return false;
				if (key == "BusinessExceptions") return false;
				if (key == "IsModified") return false;
				if (key == "Deleted") return false;
				if (key == "Id") return false;
				if (key == "Persisted") return false;
				if (key == "LoanApplicationId") return false;
			}

			// reject null values or anything that isn't a value type except for a string
			if (attributeEntry.Value == null || !(attributeEntry.Value.GetType().IsValueType || attributeEntry.Value is string))
				return false;


			FieldTable ft = GetFieldTable(ref attributeContainer);
			if (ft != null)
			{
				bool unassignedindicator = false;
				object tempval = null;
				System.Reflection.FieldInfo field = null;

				field = ft[string.Format("_{0}_isnull", key.ToLower())];
				if (field != null)
				{
					tempval = field.GetValue(attributeContainer);
					if (tempval != null)
					{
						unassignedindicator = (bool) tempval;
						if (unassignedindicator) return false;
					}
				}

				field = ft[string.Format("_{0}_assigned", key.ToLower())];
				if (field != null)
				{
					tempval = field.GetValue(attributeContainer);
					if (tempval != null)
					{
						unassignedindicator = !((bool) tempval);
						if (unassignedindicator) return false;
					}
				}
			}

			return true;
		}


		/// <summary>
		/// Gets the field table for any object.
		/// </summary>
		/// <param name="any">Any object to obtain a field table for.</param>
		/// <returns>A reference to a field table.</returns>
		/// <remarks>It will cache the field table in a hash for quick lookup at a later time.</remarks>
		public static FieldTable GetFieldTable(ref object any)
		{
			if (any == null) return null;
			string typefullname = any.GetType().FullName;
			FieldTable ft = _fieldtablehash[typefullname] as FieldTable;

			if (ft == null)
			{
				ft = new FieldTable(any);
				_fieldtablehash[typefullname] = ft;
			}

			return ft;
		}

		#endregion Methods
	}
}
