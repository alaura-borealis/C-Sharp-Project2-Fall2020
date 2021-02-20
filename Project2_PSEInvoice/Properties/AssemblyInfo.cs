using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Project #2 -- PSE Invoice")]
[assembly: AssemblyDescription("A Windows Form Application that generates a mock PSE gas utility bill for a selected customer in a list, which can be printed in two ways. The calculation for charges are based on the following: \r\n\r\n\u2022 Customer charge— a flat fee of $6.25\r\n\u2022 Delivery charge—$0.29062 per thermal unit\r\n\u2022 Cost of gas—$0.69156 per thermal unit for the first 50 thermal units, $1.23863 per thermal unit for 51-100 thermal units and $2.0389 per thermal unit thereafter\r\n\u2022 Gas Conservation Program Charge—$0.00437 per thermal unit\r\n\u2022 City Tax—6% tax on all charges")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Laura Waite")]
[assembly: AssemblyProduct("Puget Sound Energy Invoice")]
[assembly: AssemblyCopyright("Copyright © Fall 2020 - CS 218")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("4c49a40a-9b31-45dd-a434-16c7b9a4b30f")]

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
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
