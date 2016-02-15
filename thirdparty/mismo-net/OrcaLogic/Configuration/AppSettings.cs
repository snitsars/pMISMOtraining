//===================================================================================================
// AppSettings Utility Class
//===================================================================================================
// Author:
//  Patrick W. Grinsell
//  Created : 01/06/03
//
//  2002 © Patrick W. Grinsell.  All rights reserved.
//  This code may be used, shared and distributed free of charge.
//
// Purpose:
// Allows writing, reading, and removing of app settings.
//
// Change Log:
//   01/06/2003 - Patrick Grinsell - Created.
//
using System;
using System.Xml;

namespace OrcaLogic.Configuration
{
	/// <summary>
	/// Class for configuring application configuration files at runtime.
	/// Note that the AppSettingsReader used in .Net System.Configuration is sourced in memory
	/// so changes won't reflect until the application restarts.  For this reason I've supplied
	/// a GetValue method that returns the current file settings.  Because of this it's likely
	/// that changes to dynamic properties also require a restart.
	/// </summary>
	public class AppSettings
	{
		#region Member Fields

		/// <summary>
		/// The crypto service that layers on top of the application settings.
		/// </summary>
		private OrcaLogic.Security.Cryptography.SymmetricServices _cryptoservice = null;
		/// <summary>
		/// The variable used to store the encryption key.
		/// </summary>
		private string _encryptionkey = string.Empty;

		/// <summary>
		/// Use integrated windows authentication
		/// </summary>
		private static bool _integratedAuthentication = true;

		private static int _appId = -1;

		#endregion Member Fields

		#region Constructors/Destructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		public AppSettings() : this(null, string.Empty) {}

		/// <summary>
		/// Creates a new instance of the app settings with encryption enabled.
		/// </summary>
		public AppSettings(string EncryptionKey) : this(new OrcaLogic.Security.Cryptography.SymmetricServices(), EncryptionKey) {}

		/// <summary>
		/// Creates a new instance of the app settings with the specified cryptography services and key.
		/// </summary>
		public AppSettings(OrcaLogic.Security.Cryptography.SymmetricServices CryptoService, string EncryptionKey)
		{
			_cryptoservice = CryptoService;
			_encryptionkey = EncryptionKey;
		}

		#endregion Constructors/Destructors

		#region Properties

		/// <summary>
		/// Gets or sets the specified setting for the app settings instance.
		/// </summary>
		public string this[string Setting] 
		{
			get 
			{
				if (_cryptoservice == null) return AppSettings.GetValue(Setting);
				return _cryptoservice.Decrypt(AppSettings.GetValue(_cryptoservice.Encrypt(Setting, _encryptionkey)), _encryptionkey);
			}
			set 
			{ 
				if (_cryptoservice == null)
					AppSettings.SetValue(Setting, value); 
				else
					AppSettings.SetValue(_cryptoservice.Encrypt(Setting, _encryptionkey), _cryptoservice.Encrypt(value, _encryptionkey));
			}
		}

		/// <summary>
		/// Gets or sets the integrated windows authentication
		/// </summary>
		public static bool IntegratedAuthentication
		{
			get
			{
				return _integratedAuthentication;
			}
			set
			{
				_integratedAuthentication = value;
			}
		}

		public static int AppId
		{
			get
			{
				if (_appId == -1)
				{
					_appId = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["AppId"]);
				}
				return _appId;
			}
		}
		#endregion Properties

		#region Methods
		#endregion Methods

		#region Static Methods

		/// <summary>
		/// Gets the application configuration setting.
		/// </summary>
		/// <param name="setting">Setting to be returned.</param>
		/// <returns></returns>
		public static string GetValue(string setting)
		{
			//			System.Configuration.AppSettingsReader conf=new System.Configuration.AppSettingsReader();
			//			object v=conf.GetValue(setting, typeof(string));
			//			return v;
			System.Reflection.Assembly asm=System.Reflection.Assembly.GetEntryAssembly();
			System.IO.FileInfo fi=new System.IO.FileInfo(asm.Location+".config");
			System.Xml.XmlDataDocument doc= new System.Xml.XmlDataDocument();
			try
			{
				//Load the XML configuration file.
				doc.Load(fi.FullName);
				//Loop through the nodes to find the target node to be returned.
				foreach (System.Xml.XmlNode node in doc["configuration"]["appSettings"])
				{
					if (node.Name=="add")
					{
						if (node.Attributes.GetNamedItem("key").Value==setting)
						{
							return (string)node.Attributes.GetNamedItem("value").Value;
						}
					}
				}
				//If not found then the setting probably didn't exist...throw an error.
				throw new Exception();
				//Save the results...
			}
			catch
			{
				//There was an error loading or reading the config file...throw an error.
				throw new Exception("Unable to find the setting.  Check that the configuration file exists and contains the appSettings element.");
			}
		}

		/// <summary>
		/// Sets the application configuration setting.
		/// </summary>
		/// <param name="setting">Setting to be changed/added.</param>
		/// <param name="val">Value to change/add.</param>
		public static void SetValue(string setting, string val)
		{
			bool changed=false;
			System.Reflection.Assembly asm=System.Reflection.Assembly.GetEntryAssembly();
			System.IO.FileInfo fi=new System.IO.FileInfo(asm.Location+".config");
			System.Xml.XmlDataDocument doc= new System.Xml.XmlDataDocument();
			try
			{
				//Load the XML application configuration file
				doc.Load(fi.FullName);
				//Loops through the nodes to find the target node to change
				foreach (System.Xml.XmlNode node in doc["configuration"]["appSettings"])
				{
					if (node.Name=="add")
					{
						//Set the key and value attributes
						if (node.Attributes.GetNamedItem("key").Value==setting)
						{
							node.Attributes.GetNamedItem("value").Value=val;
							//Flag the change as complete
							changed=true;
						}
					}
				}
				//If not changed yet then we assume it's a new key to be added
				if (!changed) 
				{
					//create the new node and append it to the collection
					System.Xml.XmlNode node=doc["configuration"]["appSettings"];
					System.Xml.XmlElement elem=doc.CreateElement("add");
					System.Xml.XmlAttribute attrKey=doc.CreateAttribute("key");
					System.Xml.XmlAttribute attrVal=doc.CreateAttribute("value");
					elem.Attributes.SetNamedItem(attrKey).Value=setting;
					elem.Attributes.SetNamedItem(attrVal).Value=val;
					node.AppendChild(elem);
				}
				//Save the XML configuration file.
				doc.Save(fi.FullName);
			}
			catch
			{
				//There was an error loading or reading the config file...throw an error.
				throw new Exception("Unable to set the value.  Check that the configuration file exists and contains the appSettings element.");
			}
		}

		/// <summary>
		/// Removes the application configuration setting.
		/// </summary>
		/// <param name="setting">Setting to be removed.</param>
		public static void RemoveSetting(string setting)
		{
			bool removed=false;
			System.Reflection.Assembly asm=System.Reflection.Assembly.GetEntryAssembly();
			System.IO.FileInfo fi=new System.IO.FileInfo(asm.Location+".config");
			System.Xml.XmlDataDocument doc= new System.Xml.XmlDataDocument();
			try
			{
				//Load the XML configuration file.
				doc.Load(fi.FullName);
				//Loop through the nodes to find the target node to be removed.
				foreach (System.Xml.XmlNode node in doc["configuration"]["appSettings"])
				{
					if (node.Name=="add")
					{
						if (node.Attributes.GetNamedItem("key").Value==setting)
						{
							node.ParentNode.RemoveChild(node);
							removed=true;
						}
					}
				}
				//If not removed then the setting probably didn't exist...throw an error.
				if (!removed) throw new Exception();
				//Save the results...
				doc.Save(fi.FullName);
			}
			catch
			{
				//There was an error loading or reading the config file...throw an error.
				throw new Exception("Unable to remove the value.  Check that the configuration file exists and contains the appSettings element.");
			}
		}

		#endregion
	}
}