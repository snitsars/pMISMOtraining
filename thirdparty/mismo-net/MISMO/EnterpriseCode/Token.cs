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
using System.Data;
using System.Threading;
using System.Security;
using System.Security.Cryptography;




namespace MISMO.EnterpriseCode
{
	public class Token
	{
		// members...
		private int _userId;
		private string _ntlmName;
		private string _tokenString;
		private int _tokenId = 0;
		private int _ordinal;
		private ReaderWriterLock _lock = new ReaderWriterLock();




		// const...
		private const string EncryptionKey = "helloworld";
		private const int ExpiryTimeout = 20;




		private Token(DataSet dataset)
		{
			// set it...
			_tokenId = (int)dataset.Tables[0].Rows[0]["tokenid"];
			_userId = (int)dataset.Tables[0].Rows[0]["userid"];
			_tokenString = (string)dataset.Tables[0].Rows[0]["token"];
			_ntlmName = (string)dataset.Tables[0].Rows[0]["ntlmname"];




			// update the expiry time...
			UpdateExpiryTime();
		}




		public Token(int userId)
		{
			// set...
			_userId = userId;




			// get an ordinal...
			int useOrdinal = 0;
			_lock.AcquireWriterLock(-1);
			useOrdinal = _ordinal;
			_ordinal++;
			_lock.ReleaseWriterLock();




			// create a complex string based on a combination of factors...
			string rawToken = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + userId + "_" + useOrdinal;




			// initialize the key...
			Byte[] keyBytes = new Byte[EncryptionKey.Length];
			ASCIIEncoding encoding = new ASCIIEncoding();
			encoding.GetBytes(EncryptionKey, 0, EncryptionKey.Length, keyBytes, 0);




			// create the new cryptographic service provider...
			SHA1CryptoServiceProvider provider = new SHA1CryptoServiceProvider();




			// create a hash of the key... once we have the hash, we need a key and an initialization vector, each 
			// eight bytes in length.
			Byte[] hash = provider.ComputeHash(keyBytes);
			Byte[] key = new Byte[8];
			Byte[] vector = new Byte[8];
			for(int n = 0; n < 8; n++)
			{
				key[n] = hash[n];
				vector[n] = hash[n + 8];
			}




			// now we can start the actual encryption process.  first, we need to translate the
			// string into an array of bytes...
			Byte[] tokenBytes = new Byte[rawToken.Length];
			encoding.GetBytes(rawToken, 0, rawToken.Length, tokenBytes, 0);




			// now, we need a DES service provide and create an object
			// that will perform the encyrption...
			DESCryptoServiceProvider desProvider = new DESCryptoServiceProvider();
			ICryptoTransform encrypt = desProvider.CreateEncryptor(key, vector);




			// we need an input stream, an output stream and a cryptostream. This last
			// one reads the bytes from the encryptor...
			MemoryStream inStream = new MemoryStream(tokenBytes);
			MemoryStream outStream = new MemoryStream();
			CryptoStream cryptStream = new CryptoStream(inStream, encrypt, CryptoStreamMode.Read);




			// encrypt...
			Byte[] buf = new Byte[1024];
			while(true)
			{
				int bytesRead = cryptStream.Read(buf, 0, 1024);
				if(bytesRead == 0)
					break;
				outStream.Write(buf, 0, bytesRead);
			}




			// finally, if we got some data, we need to convert it to a unicode string...
			if(outStream.Length != 0)
				_tokenString = Convert.ToBase64String(outStream.GetBuffer(), 0, (int)outStream.Length);
			else
				throw new Exception("Encryption of security token failed");
		}




		public void UpdateExpiryTime()
		{
			// call a sproc...
			SprocSetTokenExpires(Id, CreateExpiryTime());
		}




		// CreateExpiryTime - set the next expiry of the token...
		public DateTime CreateExpiryTime() 
		{
			return DateTime.Now.AddMinutes(ExpiryTimeout);
		}




		// Load - load the token when given a string...
		// Thanks to Kevin Trickey for providing the C# implementation of this method!
		public static Token Load(string tokenString)
		{
			// try and find the token...
			DataSet dataset = SprocGetToken(tokenString);
			if (dataset.Tables[0].Rows.Count > 0)
			{
				// create the new token...
				Token token = new Token(dataset);
				return token;
			}
			else
			{
				return null;
			}
		}




		// Thanks to Kevin Trickey for providing the C# implementation of this method!
		protected static DataSet SprocGetToken(string token)
		{
			// create a connection...
			System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(EnterpriseApplication.Application.ConnectionString);
			connection.Open();
			// create a command...
			System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("GetToken", connection);
			command.CommandType = System.Data.CommandType.StoredProcedure;
			// parameters...
			System.Data.SqlClient.SqlParameter tokenParam  = command.Parameters.Add("@token", System.Data.SqlDbType.VarChar, 256);
			tokenParam.Value = token;
			// extract the dataset...
			System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter(command);
			DataSet dataset = new DataSet(); 
			adapter.Fill(dataset); 
			adapter.Dispose();
			// cleanup...  
			command.Dispose(); 
			connection.Close();
			// return dataset...  
			return dataset;
		}




		public int UserId
		{
			get
			{
				return _userId;
			}
		}




		public int Id
		{
			get
			{
				return _tokenId;
			}
		}




		public string NtlmName
		{
			get
			{
				return _ntlmName;
			}
		}




		public string TokenString
		{
			get
			{
				return _tokenString;
			}
		}




		public bool HasExpired()
		{
			return false;
		}




		protected static void SprocSetTokenExpires(int tokenId, System.DateTime expires)
		{
			// create a connection...
			System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(EnterpriseApplication.Application.ConnectionString);
			connection.Open();
			// create a command...
			System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("SetTokenExpires", connection);
			command.CommandType = System.Data.CommandType.StoredProcedure;
			// parameters...
			System.Data.SqlClient.SqlParameter tokenIdParam = command.Parameters.Add("@tokenId", System.Data.SqlDbType.Int);
			tokenIdParam.Value = tokenId;
			System.Data.SqlClient.SqlParameter expiresParam = command.Parameters.Add("@expires", System.Data.SqlDbType.DateTime);
			expiresParam.Value = expires;
			// execute...
			command.ExecuteNonQuery();
			// cleanup...
			command.Dispose();
			connection.Close();
		}




		public void Delete()
		{
			SprocDeleteToken(Id);
		}




		protected static void SprocDeleteToken(int tokenId)
		{
			// create a connection...
			System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(EnterpriseApplication.Application.ConnectionString);
			connection.Open();
			// create a command...
			System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("DeleteToken", connection);
			command.CommandType = System.Data.CommandType.StoredProcedure;
			// parameters...
			System.Data.SqlClient.SqlParameter tokenIdParam = command.Parameters.Add("@tokenId", System.Data.SqlDbType.Int);
			tokenIdParam.Value = tokenId;
			// execute...
			command.ExecuteNonQuery();
			// cleanup...
			command.Dispose();
			connection.Close();
		}




		// Save - save the token to the database...
		public void Save()
		{
			// save it...
			_tokenId = SprocCreateSecurityToken(UserId, TokenString, CreateExpiryTime());
		}




		protected static int SprocCreateSecurityToken(int userId, string token, System.DateTime expires)
		{
			// create a connection...
			System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(EnterpriseApplication.Application.ConnectionString);
			connection.Open();
			// create a command...
			System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("CreateSecurityToken", connection);
			command.CommandType = System.Data.CommandType.StoredProcedure;
			// parameters...
			System.Data.SqlClient.SqlParameter userIdParam = command.Parameters.Add("@userId", System.Data.SqlDbType.Int);
			userIdParam.Value = userId;
			System.Data.SqlClient.SqlParameter tokenParam = command.Parameters.Add("@token", System.Data.SqlDbType.VarChar, 256);
			tokenParam.Value = token;
			System.Data.SqlClient.SqlParameter expiresParam = command.Parameters.Add("@expires", System.Data.SqlDbType.DateTime);
			expiresParam.Value = expires;
			System.Data.SqlClient.SqlParameter returnValueParam = command.Parameters.Add("@returnValueParam", System.Data.SqlDbType.Int);
			returnValueParam.Direction = System.Data.ParameterDirection.ReturnValue;
			// execute...
			command.ExecuteNonQuery();
			// cleanup...
			command.Dispose();
			connection.Close();
			// return...
			return ((int)(returnValueParam.Value));
		}




		public override string ToString()
		{
			return TokenString;
		}
	}
}






