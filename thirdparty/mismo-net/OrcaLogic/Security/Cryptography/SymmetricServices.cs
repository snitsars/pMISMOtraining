// ******************************************************************************************************************
//  OrcaLogic, Inc - http://www.OrcaLogic.com
//  Copyright (c) 2004
// 
//  OrcaLogic, Inc. is a consulting company specializing in delivering custom software solutions.  Please contact
//  OrcaLogic Inc. for details on this, other open source projects, or to inquire about consulting services.
//  
//  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
//  documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
//  the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
//  to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all copies or substantial portions 
//  of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
//  TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
//  THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
//  CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
//  DEALINGS IN THE SOFTWARE.
// ******************************************************************************************************************
using System;
using System.IO;
using System.Text;

namespace OrcaLogic.Security.Cryptography
{
	/// <remarks>
	/// An enumeration of symmetric algorithms.
	/// </remarks>
	public enum SymmetricAlgorithms : int
	{
		/// <summary>
		/// The DES symmetic algorithm.
		/// </summary>
		DES, 
		/// <summary>
		/// The RC2 symmetric algorithm.
		/// </summary>
		RC2, 
		/// <summary>
		/// The Rijndael symmetric algorithm.
		/// </summary>
		Rijndael
	}
	
	/// <summary>
	/// A class that represents a simplification of symmetric cryptographic algorithms.
	/// </summary>
	public sealed class SymmetricServices
	{
		#region Member Fields

		/// <summary>
		/// Variable that stores the .NET crypto service.
		/// </summary>
		private System.Security.Cryptography.SymmetricAlgorithm _cryptoservice;

		#endregion Member Fields

		#region Constructors/Destructors

		/// <remarks>
		/// Creates a new instance of the symmetric crypto service with the DES crypto algorithms as the default algorithm.
		/// </remarks>
		public SymmetricServices() : this(SymmetricAlgorithms.DES) {}

		/// <remarks>
		/// Creates a new instance of the symmetric crypto service for the specified algorithm.
		/// </remarks>
		public SymmetricServices(SymmetricAlgorithms CryptographyAlgorithm)
		{
			// set the internal cryptographic service based on the selected algorithm.
			switch (CryptographyAlgorithm)
			{
				case SymmetricAlgorithms.DES:
					_cryptoservice = new System.Security.Cryptography.DESCryptoServiceProvider();
					break;
				case SymmetricAlgorithms.RC2:
					_cryptoservice = new System.Security.Cryptography.RC2CryptoServiceProvider();
					break;
				case SymmetricAlgorithms.Rijndael:
					_cryptoservice = new System.Security.Cryptography.RijndaelManaged();
					break;
			}
		}

		/// <remarks>
		/// Creates a new instance of the symmetric crypto service for any other custom symmetric crypto provider.
		/// </remarks>
		public SymmetricServices(System.Security.Cryptography.SymmetricAlgorithm CryptoProvider)
		{
			_cryptoservice = CryptoProvider;
		}

		#endregion Constructors/Destructors

		#region Properties
		#endregion Properties

		#region Methods

		/// <remarks>
		/// Depending on the legal key size limitations of a specific CryptoService provider
		/// and length of the private key provided, padding the secret key with space character
		/// to meet the legal size of the algorithm.
		/// </remarks>
		private byte[] GetLegalKey(string Key)
		{
			string sTemp;
			if (_cryptoservice.LegalKeySizes.Length > 0)
			{
				int min = _cryptoservice.LegalKeySizes[0].MinSize;
				int max = _cryptoservice.LegalKeySizes[0].MaxSize;
				int keybits = Key.Length * 8;

				if (keybits < min)
                    sTemp = Key.PadRight(min / 8, ' '); // pad it with spaces
				else
					sTemp = Key.Substring(0, max / 8); // drop off the excess key length
			}
			else
				sTemp = Key;

			// convert the secret key to byte array
			return System.Text.ASCIIEncoding.ASCII.GetBytes(sTemp);
		}

		/// <summary>
		/// Encrypts a source string and returns a Base64 result.
		/// </summary>
		/// <param name="Source">The source string to encrypt.</param>
		/// <param name="Key">A key to use for the encryption.</param>
		/// <returns>A Base64 string of the encrypted information.</returns>
		public string Encrypt(string Source, string Key)
		{
			byte[] bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(Source);
			// create a MemoryStream so that the process can be done without I/O files
			System.IO.MemoryStream ms = new System.IO.MemoryStream();

			byte[] bytKey = GetLegalKey(Key);

			// set the private key
			_cryptoservice.Key = bytKey;
			_cryptoservice.IV = bytKey;

			// create an Encryptor from the Provider Service instance
			System.Security.Cryptography.ICryptoTransform encrypto = _cryptoservice.CreateEncryptor();

			// create Crypto Stream that transforms a stream using the encryption
			System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, encrypto, System.Security.Cryptography.CryptoStreamMode.Write);

			// write out encrypted content into MemoryStream
			cs.Write(bytIn, 0, bytIn.Length);
			cs.FlushFinalBlock();
            
			byte[] bytOut = ms.GetBuffer();
                    
			// convert into Base64 so that the result can be used in xml
			return System.Convert.ToBase64String(bytOut,0,(int)ms.Length);
		}

		/// <summary>
		/// Encrypts a source stream and returns a Base64 result.
		/// </summary>
		/// <param name="Source">The source steam.</param>
		/// <param name="Key">A key to use for the encryption.</param>
		/// <returns>A Base64 string of the encrypted information.</returns>
		public string Encrypt(System.IO.Stream Source, string Key)
		{
			// read the stream into a byte array
			Source.Position = 0;
			byte[] bytIn = new byte[Source.Length];
			Source.Read(bytIn,0,(int)Source.Length);

			// create a MemoryStream so that the process can be done without I/O files
			System.IO.MemoryStream ms = new System.IO.MemoryStream();

			byte[] bytKey = GetLegalKey(Key);

			// set the private key
			_cryptoservice.Key = bytKey;
			_cryptoservice.IV = bytKey;

			// create an Encryptor from the Provider Service instance
			System.Security.Cryptography.ICryptoTransform encrypto = _cryptoservice.CreateEncryptor();

			// create Crypto Stream that transforms a stream using the encryption
			System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, encrypto, System.Security.Cryptography.CryptoStreamMode.Write);

			// write out encrypted content into MemoryStream
			cs.Write(bytIn, 0, bytIn.Length);
			cs.FlushFinalBlock();
            
			byte[] bytOut = ms.GetBuffer();
                    
			// convert into Base64 so that the result can be used in xml
			return System.Convert.ToBase64String(bytOut, 0, (int)ms.Length);
		}

		/// <summary>
		/// Decrypts a Base64 wrapped encrypted data from the provided key.
		/// </summary>
		/// <param name="Source">The encrypted base64 data.</param>
		/// <param name="Key">The key to use for decryption.</param>
		/// <returns>The original string of data.</returns>
		public string Decrypt(string Source, string Key)
		{
			// convert from Base64 to binary
			byte[] bytIn = System.Convert.FromBase64String(Source);
			// create a MemoryStream with the input
			System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);

			byte[] bytKey = GetLegalKey(Key);

			// set the private key
			_cryptoservice.Key = bytKey;
			_cryptoservice.IV = bytKey;

			// create a Decryptor from the Provider Service instance
			System.Security.Cryptography.ICryptoTransform decrypto = _cryptoservice.CreateDecryptor();
 
			// create Crypto Stream that transforms a stream using the decryption
			System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, decrypto, System.Security.Cryptography.CryptoStreamMode.Read);

			// read out the result from the Crypto Stream
			System.IO.StreamReader sr = new System.IO.StreamReader( cs );
			return sr.ReadToEnd();
		}

		/// <summary>
		/// Decrypts a Base64 wrapped encrypted data from the provided key.
		/// </summary>
		/// <param name="Source">The encrypted base64 string.</param>
		/// <param name="Key">The key to use for decryption.</param>
		/// <returns>The original binary stream of data.</returns>
		public System.IO.Stream DecryptToStream(string Source, string Key)
		{
			// convert from Base64 to binary
			byte[] bytIn = System.Convert.FromBase64String(Source);
			// create a MemoryStream with the input
			System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);

			byte[] bytKey = GetLegalKey(Key);

			// set the private key
			_cryptoservice.Key = bytKey;
			_cryptoservice.IV = bytKey;

			// create a Decryptor from the Provider Service instance
			System.Security.Cryptography.ICryptoTransform decrypto = _cryptoservice.CreateDecryptor();
 
			// create Crypto Stream that transforms a stream using the decryption
			System.Security.Cryptography.CryptoStream cs = new System.Security.Cryptography.CryptoStream(ms, decrypto, System.Security.Cryptography.CryptoStreamMode.Read);

			return cs;
		}
		#endregion Methods

	}

}
