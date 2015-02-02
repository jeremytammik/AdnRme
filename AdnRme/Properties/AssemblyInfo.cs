using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "Revit MEP Sample Application" )]
[assembly: AssemblyDescription
  ( "Demonstrate use of the Revit API for MEP: "
  + "1. use of the generic API for HVAC specific tasks: "
  + "determine air terminals for each space; "
  + "assign flow to the air terminals depending on the space's calculated supply air flow; "
  + "change size of diffuser based on flow; "
  + "populate the value of the 'CFM per SF' variable on all spaces; "
  + "determine unhosted elements; "
  + "reset demo. "
  + "2. use of the MEP specific API to traverse an electrical system "
  + "and display its hierarchy in a tree view." )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "ADN Autodesk Developer Network, Autodesk, Inc." )]
[assembly: AssemblyProduct( "Revit MEP Sample Application" )]
[assembly: AssemblyCopyright( "Copyright © 2007-2015 by Jeremy Tammik, Autodesk, Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "118f7279-630d-4661-afe5-c23c23acf46f" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// History:
// 2014-09-02 2015.0.0.2 reformatted before removing obsolete API usage
// 2014-09-02 2015.0.0.3 removed obsolete API usage, specifically replaced Family.Symbols property by GetFamilySymbolIds
// 2014-09-02 2015.0.0.4 bumped the copyright message year from 2013 or whatever to 2014
// 2015-02-02 2015.0.0.5 bumped the copyright message year from 2014 to 2015
//
[assembly: AssemblyVersion( "2015.0.0.5" )]
[assembly: AssemblyFileVersion( "2015.0.0.5" )]
