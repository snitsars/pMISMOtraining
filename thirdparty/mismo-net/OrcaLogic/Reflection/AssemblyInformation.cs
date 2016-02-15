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
using System.Reflection;

namespace OrcaLogic.Reflection
{
	/// <summary>
	/// A class that represents an assembly set of information.
	/// </summary>
	public class AssemblyInformation : AssemblyVersion
	{
		/// <summary>
		/// A member that stores the assembly title.
		/// </summary>
		private string _title = string.Empty;
		/// <summary>
		/// A member that stores the assembly description.
		/// </summary>
		private string _description = string.Empty;
		/// <summary>
		/// A member that stores the assembly company.
		/// </summary>
		private string _company = string.Empty;
		/// <summary>
		/// A member that stores the company product name.
		/// </summary>
		private string _product = string.Empty;
		/// <summary>
		/// A member that stores the copyright.
		/// </summary>
		private string _copyright = string.Empty;
		/// <summary>
		/// A member that stores the trademark information.
		/// </summary>
		private string _trademark = string.Empty;

		/// <summary>
		/// Create a new instance of an assembly version object from an existing assembly.
		/// </summary>
		/// <param name="assembly">An assembly to create a assembly version instance for.</param>
		public AssemblyInformation(System.Reflection.Assembly assembly) : base(assembly)
		{
			if (assembly == null) throw new ArgumentNullException("assembly");

			_name = assembly.GetName().Name;

			_path = assembly.Location.Substring(0, assembly.Location.LastIndexOf(@"\"));

			// declare variable for attribute querying
			object[] attrs = null;
				
			// get the title information
			attrs = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
			if ( attrs.Length > 0 )
			{
				AssemblyTitleAttribute ata = attrs[0] as AssemblyTitleAttribute;
				_title = ata.Title;
			}
			// get the description information
			attrs = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
			if ( attrs.Length > 0 )
			{
				AssemblyDescriptionAttribute ada = attrs[0] as AssemblyDescriptionAttribute;
				_description = ada.Description;
			}
			// get the company information
			attrs = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
			if ( attrs.Length > 0 )
			{
				AssemblyCompanyAttribute aca = attrs[0] as AssemblyCompanyAttribute;
				_company = aca.Company;
			}
			// get the product information
			attrs = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
			if ( attrs.Length > 0 )
			{
				AssemblyProductAttribute apa = attrs[0] as AssemblyProductAttribute;
				_product = apa.Product;
			}
			// get the copyright information
			attrs = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
			if ( attrs.Length > 0 )
			{
				AssemblyCopyrightAttribute acpa = attrs[0] as AssemblyCopyrightAttribute;
				_copyright = acpa.Copyright;
			}
			// get the trademark information
			attrs = assembly.GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false);
			if ( attrs.Length > 0 )
			{
				AssemblyTrademarkAttribute atma = attrs[0] as AssemblyTrademarkAttribute;
				_trademark = atma.Trademark;
			}		
		}

		#region Properties

		/// <summary>
		/// Stores the name of the assembly.
		/// </summary>
		private readonly string _name = string.Empty;
		/// <summary>
		/// Gets the name of the assembly.
		/// </summary>
		public string Name { get { return _name; } }

		/// <summary>
		/// Stores the location of the assembly.
		/// </summary>
		private readonly string _path = string.Empty;
		/// <summary>
		/// Gets the path of the assembly.
		/// </summary>
		public string Path { get { return _path; } }

		/// <summary>
		/// Gets the title of the assembly.
		/// </summary>
		public string Title	{ get { return _title; } }
		
		/// <summary>
		/// Gets the description of the assembly.
		/// </summary>
		public string Desciption { get { return _description; } }

		/// <summary>
		/// Gets the company that developed the assembly.
		/// </summary>
		public string Company { get { return _company; } }

		/// <summary>
		/// Gets the product name of the assembly.
		/// </summary>
		public string Product { get { return _product; } }

		/// <summary>
		/// Gets the copyright of the assembly.
		/// </summary>
		public string Copyright { get { return _copyright; } }

		/// <summary>
		/// Gets the trademark information of the assembly.
		/// </summary>
		public string Trademark { get { return _trademark; } }


		#endregion Properties

		#region Methods

		/// <summary>
		/// Gets the assembly short version description including the name assembly information.
		/// </summary>
		/// <returns>A string that contains the assembly short version information.</returns>
		public override string ToShortVersionString()
		{
			return _title + " " + base.ToShortVersionString();
		}

		/// <summary>
		/// Gets the full file path to the associated assembly resource with the specified extension.
		/// </summary>
		/// <param name="FileExtension"></param>
		/// <returns></returns>
		public string GetAssociatedResource(string FileExtension) 
		{
			return _path + @"\" + _name + "." + FileExtension;
		}

		#endregion Methods
	}
}
