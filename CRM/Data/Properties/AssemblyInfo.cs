﻿using System.Reflection;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("CRM Data Tier")]
[assembly: AssemblyDescription("CRM data access layer")]
[assembly: AssemblyCompany("Return On Intelligence LLC")]
[assembly: AssemblyProduct("CRM")]
[assembly: AssemblyCopyright("Copyright ©2014 Return On Intelligence LLC")]

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

[assembly: InternalsVisibleTo("CRM.Data.Migrations")]

[assembly: TypeForwardedTo(typeof(System.Data.Entity.Infrastructure.SqlConnectionFactory))]
[assembly: TypeForwardedTo(typeof(System.Data.Entity.SqlServer.SqlProviderServices))]
