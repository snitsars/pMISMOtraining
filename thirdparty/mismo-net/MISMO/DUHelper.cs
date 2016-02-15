using System;
using System.Collections.Specialized;

namespace MISMO
{
	/// <summary>
	/// A class that represents a DU helper/processor.
	/// </summary>
	internal class DUHelper
	{
		/// <summary>
		/// Member that stores the field code lookup (hash of string collections).
		/// </summary>
		private System.Collections.Hashtable _hash = new System.Collections.Hashtable();
		/// <summary>
		/// The temporary capture collection.
		/// </summary>
		private StringCollection _capturecol = null;

		/// <summary>
		/// Create a new instance of the du helper from a file location.
		/// </summary>
		/// <param name="fileName">The full file name of the file to load data from.</param>
		public DUHelper(string fileName)
		{
			System.IO.FileInfo file = new System.IO.FileInfo(fileName);
			if (!file.Exists) throw new System.IO.FileNotFoundException("Could not find file.", fileName);
			System.IO.FileStream fs = file.OpenRead();
			byte[] filedat = new byte[fs.Length];
			fs.Read(filedat, 0, filedat.Length);
			fs.Close();
			LoadFromBytes(filedat);
		}

		/// <summary>
		/// Create a new instance of the du helper from a set of file bytes.
		/// </summary>
		/// <param name="fileBytes">The bytes to create the DU helper from.</param>
		public DUHelper(byte[] fileData)
		{
			LoadFromBytes(fileData);
		}

		/// <summary>
		/// Loads data into the DU helper from a set of file bytes.
		/// </summary>
		/// <param name="fileData"></param>
		private void LoadFromBytes(byte[] fileData)
		{
			string[] dudata = System.Text.UTF8Encoding.UTF8.GetString(fileData).Split('\r','\n');
			string seqid = null;

			StringCollection sequence = null;

			for(int i = 0; i<dudata.Length; i++)
			{
				if (dudata[i].Length > 2)
				{
					seqid = dudata[i].Substring(0, 3).Trim();
					sequence = _hash[seqid] as StringCollection;
					if (sequence == null)
					{
						sequence = new StringCollection();
						_hash[seqid] = sequence;
					}

					sequence.Add(dudata[i]);
				}
			}
		}

		/// <summary>
		/// Internal extract data method to get the data of any string according to the DU documentation.
		/// </summary>
		/// <param name="any">Any string to extract data from.</param>
		/// <param name="position">The position to extract data according to DU documentation.</param>
		/// <param name="length">The length of the data to extract according to DU documentation.</param>
		/// <returns>An extract string for an empty string if the extraction data is invalid.</returns>
		private string ExtractDataInternal(string any, int position, int length)
		{
			string temp = string.Empty;
			if (position > any.Length || position < 0 || ((position - 1) + length) > any.Length) return string.Empty;
			return any.Substring(position-1, length).Trim();
		}

		/// <summary>
		/// Extracts data from the DU file according to the DU documenation.
		/// </summary>
		/// <param name="fieldCode">The field code context of the data.</param>
		/// <param name="position">The position according to DU documentation.</param>
		/// <param name="length">The length according to DU documenation.</param>
		/// <returns>The extracting string or an empty string if extract parameters are invalid.</returns>
		public string ExtractData(string fieldCode, int position, int length)
		{
			StringCollection stringdat = _hash[fieldCode] as StringCollection;
			if (stringdat == null || stringdat.Count == 0) return string.Empty;
			if (stringdat.Count > 1) return string.Empty;
			return ExtractDataInternal(stringdat[0], position, length);
		}

		/// <summary>
		/// Starts to capture a subset of data based the field code.
		/// </summary>
		/// <param name="fieldCode">The field code to capture the subset of data.</param>
		/// <returns>The number of items captured.</returns>
		public int BeginCapture(string fieldCode)
		{
			return BeginCapture(fieldCode, -1, -1, null);
		}

		/// <summary>
		/// Starts to capture a subset of data based on the field code and a match on the specified key data.
		/// </summary>
		/// <param name="fieldCode">The field code to match.</param>
		/// <param name="keyPosition">The position of the key according to DU documentation.</param>
		/// <param name="keyLength">The length of the key according to DU documentation.</param>
		/// <param name="key">The key to match as a capture.</param>
		/// <returns>The number of rows captured.</returns>
		public int BeginCapture(string fieldCode, int keyPosition, int keyLength, string key)
		{
			StringCollection stringdat = _hash[fieldCode] as StringCollection;
			if (stringdat == null) return -1;
			_capturecol = new StringCollection();
			if (stringdat.Count == 0)
			{
				return 0;
			}

			if (key == null) 
			{
				// we aren't matching a key in the sub capture just returning it all
				string[] results = new string[stringdat.Count];
				stringdat.CopyTo(results, 0);
				_capturecol.AddRange(results);
				return stringdat.Count;
			}

			for (int i = 0, j = stringdat.Count; i<j; i++)
			{
				if (ExtractDataInternal(stringdat[i], keyPosition, keyLength) == key)
				{
					_capturecol.Add(stringdat[i]);
				}
			}

			return _capturecol.Count;
		}

		/// <summary>
		/// Extracts the capture data.
		/// </summary>
		/// <param name="recordPos">The zero based index of the record.</param>
		/// <param name="position">The DU position standard (see DU documentation).</param>
		/// <param name="length">The DU length stadard according to documentation.</param>
		/// <returns>An extract of the captured data.</returns>
		public string ExtractCaptureData(int recordPos, int position, int length)
		{
			if (_capturecol == null || _capturecol.Count == 0) return string.Empty;
			return ExtractDataInternal(_capturecol[recordPos], position, length);
		}

		/// <summary>
		/// Ends the capturing of data.
		/// </summary>
		public void EndCapture()
		{
			_capturecol = null;
		}


		/// <summary>
		/// Converts a DU date format into an actual date.
		/// </summary>
		/// <param name="duDate">The DU date value.</param>
		/// <returns>A date time value.</returns>
		public DateTime ToDate(string duDate)
		{
			if (duDate.Length == 4)
			{
				return DateTime.Parse(string.Format("12/31/{0}", duDate));
			}

			return Convert.ToDateTime(string.Format("{0}/{1}/{2}", duDate.Substring(4,2), duDate.Substring(6, 2), duDate.Substring(0, 4)));
		}
	}
}
