﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;



/// <summary>
///   A strongly-typed resource class, for looking up localized strings, etc.
/// </summary>
// This class was auto-generated by the StronglyTypedResourceBuilder
// class via a tool like ResGen or Visual Studio.
// To add or remove a member, edit your .ResX file then rerun ResGen
// with the /str option, or rebuild your VS project.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class MshSnapInCmdletResources {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal MshSnapInCmdletResources() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MshSnapInCmdletResources", typeof(MshSnapInCmdletResources).GetTypeInfo().Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }
    
    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture {
        get {
            return resourceCulture;
        }
        set {
            resourceCulture = value;
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The operation cannot be performed. The specified cmdlet is not supported in a custom shell..
    /// </summary>
    internal static string CmdletNotAvailable {
        get {
            return ResourceManager.GetString("CmdletNotAvailable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The custom Windows PowerShell snap-in is not supported in OneCore PowerShell..
    /// </summary>
    internal static string CustomPSSnapInNotSupportedInOneCorePowerShell {
        get {
            return ResourceManager.GetString("CustomPSSnapInNotSupportedInOneCorePowerShell", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The format of the specified snap-in name was not valid.  Windows PowerShell snap-in names can only contain alpha-numeric characters, dashes, underscores and periods. Correct the name and then try the operation again..
    /// </summary>
    internal static string InvalidPSSnapInName {
        get {
            return ResourceManager.GetString("InvalidPSSnapInName", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot add Windows PowerShell snap-in {0} because it is a system Windows PowerShell module. Use Import-Module to load the module..
    /// </summary>
    internal static string LoadSystemSnapinAsModule {
        get {
            return ResourceManager.GetString("LoadSystemSnapinAsModule", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to No Windows PowerShell snap-ins matching the pattern &apos;{0}&apos; were found. Check the pattern and then try the command again..
    /// </summary>
    internal static string NoPSSnapInsFound {
        get {
            return ResourceManager.GetString("NoPSSnapInsFound", resourceCulture);
        }
    }
}