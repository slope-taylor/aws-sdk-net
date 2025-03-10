using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("AWSSDK.CloudDirectory")]
#if BCL35
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (3.5) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif BCL45
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (4.5) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif PCL
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (PCL) -  Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif UNITY
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (Unity) - Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif NETSTANDARD13
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 1.3)- Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#elif NETSTANDARD20
[assembly: AssemblyDescription("The Amazon Web Services SDK for .NET (NetStandard 2.0)- Amazon CloudDirectory. Cloud Directory (CD) is a multi-tenant, hierarchical data store for use by other AWS services to store directory data for AWS resources, including both metadata about resources and policy data governing resources.")]
#else
#error Unknown platform constant - unable to set correct AssemblyDescription
#endif

[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("Amazon Web Services SDK for .NET")]
[assembly: AssemblyCompany("Amazon.com, Inc")]
[assembly: AssemblyCopyright("Copyright 2009-2019 Amazon.com, Inc. or its affiliates. All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

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
[assembly: AssemblyVersion("3.3")]
[assembly: AssemblyFileVersion("3.3.100.107")]

#if WINDOWS_PHONE || UNITY
[assembly: System.CLSCompliant(false)]
# else
[assembly: System.CLSCompliant(true)]
#endif

#if BCL
[assembly: System.Security.AllowPartiallyTrustedCallers]
#endif