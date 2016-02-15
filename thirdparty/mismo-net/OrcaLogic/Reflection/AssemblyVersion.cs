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

namespace OrcaLogic.Reflection
{
	/// <summary>
	/// A class that represents an assembly version.
	/// </summary>
	public class AssemblyVersion
	{
		/// <summary>
		/// A member that stores the assembly version information.
		/// </summary>
		private System.Version _version = null;

		/// <summary>
		/// Create a new instance of an assembly version object from an existing assembly.
		/// </summary>
		/// <param name="assembly">An assembly to create a assembly version instance for.</param>
		public AssemblyVersion(System.Reflection.Assembly assembly)
		{
			if (assembly == null) throw new ArgumentNullException("assembly");
			_version = assembly.GetName().Version;
		}

		#region Properties

		/// <summary>
		/// Gets the major release number of the assembly.
		/// </summary>
		public int Major
		{
			get { return _version.Major; }
		}

		/// <summary>
		/// Gets the minor release number of the assembly.
		/// </summary>
		public int Minor 
		{
			get { return _version.Minor; }
		}

		/// <summary>
		/// Gets the build number of the assembly.
		/// </summary>
		public int Build 
		{
			get { return _version.Build; }
		}

		/// <summary>
		/// Gets the revision number of the assembly.
		/// </summary>
		public int Revision 
		{
			get { return _version.Revision; }
		}

		private DateTime _builddate = DateTime.MinValue;
		/// <summary>
		/// Retrieves the date and time of the assembly build from the Build and Revision numbers.
		/// </summary>
		public DateTime BuildDate 
		{
			get 
			{
				if (_builddate != DateTime.MinValue) return _builddate;

				// construct the build date.
				_builddate = new DateTime(2000,1,1);
				_builddate = _builddate.AddDays(_version.Build).AddSeconds((_version.Revision * 2));
				return _builddate;
			}
		}

		#endregion Properties

		#region Methods

		/// <summary>
		/// The long version of the assembly version as a string.
		/// </summary>
		/// <returns>The version converted to a string.</returns>
		public override string ToString()
		{
			return this.ToLongVersionString();
		}


		/// <summary>
		/// The short version of the assembly string.
		/// </summary>
		/// <returns>A short version of the assembly string.</returns>
		public virtual string ToShortVersionString() 
		{
			return string.Format("{0}.{1}", _version.Major, _version.Minor);
		}

		/// <summary>
		/// The long version of the assembly as a string.
		/// </summary>
		/// <returns>The long version string of the assembly.</returns>
		public string ToLongVersionString() 
		{
			return string.Format("{0}.{1}.{2}.{3}", _version.Major, _version.Minor, _version.Build, _version.Revision);
		}

		/// <summary>
		/// The short date version string of the assembly.
		/// </summary>
		/// <returns>The short date version string.</returns>
		public string ToShortDateVersionString() 
		{
			return string.Format("{0}.{1} build {2:yyyyMMdd}", _version.Major, _version.Minor, this.BuildDate);
		}

		/// <summary>
		/// The long date version string of the assembly.
		/// </summary>
		/// <returns>The long date version string.</returns>
		public string ToLongDateVersionString() 
		{
			return string.Format("{0}.{1} build {2:yyyyMMdd.HHmm}", _version.Major, _version.Minor, this.BuildDate);
		}

		#endregion Methods
	}
}
