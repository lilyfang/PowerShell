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
internal class ExtendedTypeSystem {
    
    private static global::System.Resources.ResourceManager resourceMan;
    
    private static global::System.Globalization.CultureInfo resourceCulture;
    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal ExtendedTypeSystem() {
    }
    
    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager {
        get {
            if (object.ReferenceEquals(resourceMan, null)) {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExtendedTypeSystem", typeof(ExtendedTypeSystem).GetTypeInfo().Assembly);
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
    ///   Looks up a localized string similar to Cannot access member &quot;{0}&quot; outside of a PSObject..
    /// </summary>
    internal static string AccessMemberOutsidePSObject {
        get {
            return ResourceManager.GetString("AccessMemberOutsidePSObject", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to A PSProperty or PSMethod object cannot be added to this collection..
    /// </summary>
    internal static string CannotAddPropertyOrMethod {
        get {
            return ResourceManager.GetString("CannotAddPropertyOrMethod", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to &quot;{0}&quot; cannot be changed..
    /// </summary>
    internal static string CannotChangeReservedMember {
        get {
            return ResourceManager.GetString("CannotChangeReservedMember", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The value &quot;{0}&quot; cannot be converted to a string array..
    /// </summary>
    internal static string CannotConvertValueToStringArray {
        get {
            return ResourceManager.GetString("CannotConvertValueToStringArray", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot invoke static methods or access static properties on the open generic type {0}.  Specify the type parameters and retry.  For example, instead of [System.Collections.Generic.HashSet``1]::CreateSetComparer() use [System.Collections.Generic.HashSet[int]]::CreateSetComparer()..
    /// </summary>
    internal static string CannotInvokeStaticMethodOnUninstantiatedGenericType {
        get {
            return ResourceManager.GetString("CannotInvokeStaticMethodOnUninstantiatedGenericType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot set the value for property &quot;{0}&quot; because the object has type &quot;{1}&quot; instead of &quot;{2}&quot;..
    /// </summary>
    internal static string CannotSetNonManagementObject {
        get {
            return ResourceManager.GetString("CannotSetNonManagementObject", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot set the Value property for PSMemberInfo object of type &quot;{0}&quot;..
    /// </summary>
    internal static string CannotSetValueForMemberType {
        get {
            return ResourceManager.GetString("CannotSetValueForMemberType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot change the member created from the type configuration: &quot;{0}&quot;..
    /// </summary>
    internal static string ChangeStaticMember {
        get {
            return ResourceManager.GetString("ChangeStaticMember", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot create a code method because of the method format. The method should be public, static, and have one parameter of type PSObject..
    /// </summary>
    internal static string CodeMethodMethodFormat {
        get {
            return ResourceManager.GetString("CodeMethodMethodFormat", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to CodeProperty should use a getter or setter method..
    /// </summary>
    internal static string CodePropertyGetterAndSetterNull {
        get {
            return ResourceManager.GetString("CodePropertyGetterAndSetterNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The getter method should be public, not void, static, and have one parameter of the type PSObject..
    /// </summary>
    internal static string CodePropertyGetterFormat {
        get {
            return ResourceManager.GetString("CodePropertyGetterFormat", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The setter method should be public, void, static, and have two parameters. The first parameter should be of the type PSObject. A second parameter is required if a getter method is also available, and should have the same type as the return type for the getter method..
    /// </summary>
    internal static string CodePropertySetterFormat {
        get {
            return ResourceManager.GetString("CodePropertySetterFormat", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Could not compare &quot;{0}&quot; to &quot;{1}&quot;. Error: &quot;{2}&quot;.
    /// </summary>
    internal static string ComparisonFailure {
        get {
            return ResourceManager.GetString("ComparisonFailure", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to An exception was thrown when trying to call &quot;{0}&quot; to extract the contents of an object of type &quot;{1}&quot;: &quot;{2}&quot;.
    /// </summary>
    internal static string CopyToInvocationException {
        get {
            return ResourceManager.GetString("CopyToInvocationException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The alias with name &quot;{0}&quot; contains a cycle..
    /// </summary>
    internal static string CycleInAlias {
        get {
            return ResourceManager.GetString("CycleInAlias", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while trying to enumerate the collection: &quot;{0}&quot;..
    /// </summary>
    internal static string EnumerationException {
        get {
            return ResourceManager.GetString("EnumerationException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while constructing the attribute &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionConstructingAttribute {
        get {
            return ResourceManager.GetString("ExceptionConstructingAttribute", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving member &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionGettingMember {
        get {
            return ResourceManager.GetString("ExceptionGettingMember", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving members: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionGettingMembers {
        get {
            return ResourceManager.GetString("ExceptionGettingMembers", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the definitions for method &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingMethodDefinitions {
        get {
            return ResourceManager.GetString("ExceptionRetrievingMethodDefinitions", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the string representation for method &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingMethodString {
        get {
            return ResourceManager.GetString("ExceptionRetrievingMethodString", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the definitions for parameterized property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingParameterizedPropertyDefinitions {
        get {
            return ResourceManager.GetString("ExceptionRetrievingParameterizedPropertyDefinitions", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the read state for parameterized property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingParameterizedPropertyReadState {
        get {
            return ResourceManager.GetString("ExceptionRetrievingParameterizedPropertyReadState", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the string representation for parameterized property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingParameterizedPropertyString {
        get {
            return ResourceManager.GetString("ExceptionRetrievingParameterizedPropertyString", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the type for parameterized property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingParameterizedPropertytype {
        get {
            return ResourceManager.GetString("ExceptionRetrievingParameterizedPropertytype", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the write state for parameterized property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingParameterizedPropertyWriteState {
        get {
            return ResourceManager.GetString("ExceptionRetrievingParameterizedPropertyWriteState", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the attributes for property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingPropertyAttributes {
        get {
            return ResourceManager.GetString("ExceptionRetrievingPropertyAttributes", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the read state for property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingPropertyReadState {
        get {
            return ResourceManager.GetString("ExceptionRetrievingPropertyReadState", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the string representation for property &quot;{1}&quot; : &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingPropertyString {
        get {
            return ResourceManager.GetString("ExceptionRetrievingPropertyString", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the type for property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingPropertyType {
        get {
            return ResourceManager.GetString("ExceptionRetrievingPropertyType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the write state for property &quot;{1}&quot;: &quot;{0}&quot;.
    /// </summary>
    internal static string ExceptionRetrievingPropertyWriteState {
        get {
            return ResourceManager.GetString("ExceptionRetrievingPropertyWriteState", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the type name hierarchy: &quot;{0}&quot;..
    /// </summary>
    internal static string ExceptionRetrievingTypeNameHierarchy {
        get {
            return ResourceManager.GetString("ExceptionRetrievingTypeNameHierarchy", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Exception getting &quot;{0}&quot;: &quot;{1}&quot;.
    /// </summary>
    internal static string ExceptionWhenGetting {
        get {
            return ResourceManager.GetString("ExceptionWhenGetting", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Exception setting &quot;{0}&quot;: &quot;{1}&quot;.
    /// </summary>
    internal static string ExceptionWhenSetting {
        get {
            return ResourceManager.GetString("ExceptionWhenSetting", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot get the properties of &quot;{0}&quot;..
    /// </summary>
    internal static string GetProperties {
        get {
            return ResourceManager.GetString("GetProperties", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot get property &quot;{0}&quot; for &quot;{1}&quot;..
    /// </summary>
    internal static string GetProperty {
        get {
            return ResourceManager.GetString("GetProperty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot get the type hierarchy of &quot;{0}&quot;..
    /// </summary>
    internal static string GetTypeNameHierarchyError {
        get {
            return ResourceManager.GetString("GetTypeNameHierarchyError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Get accessor for property &quot;{0}&quot; is unavailable..
    /// </summary>
    internal static string GetWithoutGetterException {
        get {
            return ResourceManager.GetString("GetWithoutGetterException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value to type System.String..
    /// </summary>
    internal static string InvalidCastCannotRetrieveString {
        get {
            return ResourceManager.GetString("InvalidCastCannotRetrieveString", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert the &quot;{0}&quot; value of type &quot;{1}&quot; to type &quot;{2}&quot;..
    /// </summary>
    internal static string InvalidCastException {
        get {
            return ResourceManager.GetString("InvalidCastException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value &quot;{0}&quot; to type &quot;{1}&quot; because at least two matches were found ({2}, {3}) and only one match is allowed for this enumeration..
    /// </summary>
    internal static string InvalidCastExceptionEnumerationMoreThanOneValue {
        get {
            return ResourceManager.GetString("InvalidCastExceptionEnumerationMoreThanOneValue", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value &quot;{0}&quot; to type &quot;{1}&quot; because no commas are allowed for this enumeration..
    /// </summary>
    internal static string InvalidCastExceptionEnumerationNoFlagAndComma {
        get {
            return ResourceManager.GetString("InvalidCastExceptionEnumerationNoFlagAndComma", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value &quot;{0}&quot; to type &quot;{1}&quot; due to enumeration values that are not valid. Specify one of the following enumeration values and try again. The possible enumeration values are &quot;{2}&quot;..
    /// </summary>
    internal static string InvalidCastExceptionEnumerationNoValue {
        get {
            return ResourceManager.GetString("InvalidCastExceptionEnumerationNoValue", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert null to type &quot;{0}&quot; due to enumeration values that are not valid. Specify one of the following enumeration values and try again. The possible enumeration values are &quot;{1}&quot;..
    /// </summary>
    internal static string InvalidCastExceptionEnumerationNull {
        get {
            return ResourceManager.GetString("InvalidCastExceptionEnumerationNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value &quot;{0}&quot; to type &quot;{1}&quot;. Boolean parameters accept only Boolean values and numbers, such as $True, $False, 1 or 0..
    /// </summary>
    internal static string InvalidCastExceptionForBooleanArgumentValue {
        get {
            return ResourceManager.GetString("InvalidCastExceptionForBooleanArgumentValue", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value to type &quot;{0}&quot;. Only core types are supported in this language mode..
    /// </summary>
    internal static string InvalidCastExceptionNonCoreType {
        get {
            return ResourceManager.GetString("InvalidCastExceptionNonCoreType", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value to type &quot;{0}&quot;.  Error: &quot;{1}&quot;.
    /// </summary>
    internal static string InvalidCastExceptionNoStringForConversion {
        get {
            return ResourceManager.GetString("InvalidCastExceptionNoStringForConversion", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert value &quot;{0}&quot; to type &quot;{1}&quot;. Error: &quot;{2}&quot;.
    /// </summary>
    internal static string InvalidCastExceptionWithInnerException {
        get {
            return ResourceManager.GetString("InvalidCastExceptionWithInnerException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert null to type &quot;{0}&quot;..
    /// </summary>
    internal static string InvalidCastFromNull {
        get {
            return ResourceManager.GetString("InvalidCastFromNull", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot get or set the property value. The &quot;{0}&quot; argument should be of type &quot;{1}&quot; or &quot;{2}&quot;..
    /// </summary>
    internal static string InvalidComponent {
        get {
            return ResourceManager.GetString("InvalidComponent", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} is not a valid class path..
    /// </summary>
    internal static string InvalidWMIClassPath {
        get {
            return ResourceManager.GetString("InvalidWMIClassPath", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to {0} is not a valid path..
    /// </summary>
    internal static string InvalidWMIPath {
        get {
            return ResourceManager.GetString("InvalidWMIPath", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The member &quot;{0}&quot; is already present..
    /// </summary>
    internal static string MemberAlreadyPresent {
        get {
            return ResourceManager.GetString("MemberAlreadyPresent", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The member &quot;{0}&quot; is already present from the extended type data file..
    /// </summary>
    internal static string MemberAlreadyPresentFromTypesXml {
        get {
            return ResourceManager.GetString("MemberAlreadyPresentFromTypesXml", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The member &quot;{0}&quot; is not present..
    /// </summary>
    internal static string MemberNotPresent {
        get {
            return ResourceManager.GetString("MemberNotPresent", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Multiple ambiguous overloads found for &quot;{0}&quot; and the argument count: &quot;{1}&quot;..
    /// </summary>
    internal static string MethodAmbiguousException {
        get {
            return ResourceManager.GetString("MethodAmbiguousException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot convert argument &quot;{0}&quot;, with value: &quot;{1}&quot;, for &quot;{2}&quot; to type &quot;{3}&quot;: &quot;{4}&quot;.
    /// </summary>
    internal static string MethodArgumentConversionException {
        get {
            return ResourceManager.GetString("MethodArgumentConversionException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot find an overload for &quot;{0}&quot; and the argument count: &quot;{1}&quot;..
    /// </summary>
    internal static string MethodArgumentCountException {
        get {
            return ResourceManager.GetString("MethodArgumentCountException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Exception calling &quot;{0}&quot; with &quot;{1}&quot; argument(s): &quot;{2}&quot;.
    /// </summary>
    internal static string MethodInvocationException {
        get {
            return ResourceManager.GetString("MethodInvocationException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Argument: &apos;{0}&apos; should be a {1}. Use {2}..
    /// </summary>
    internal static string NonRefArgumentToRefParameter {
        get {
            return ResourceManager.GetString("NonRefArgumentToRefParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The field or property: &quot;{0}&quot; for type: &quot;{1}&quot; differs only in letter casing from the field or property: &quot;{2}&quot;. The type must be Common Language Specification (CLS) compliant..
    /// </summary>
    internal static string NotAClsCompliantFieldProperty {
        get {
            return ResourceManager.GetString("NotAClsCompliantFieldProperty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot compare &quot;{0}&quot; because it is not IComparable..
    /// </summary>
    internal static string NotIcomparable {
        get {
            return ResourceManager.GetString("NotIcomparable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot compare &quot;{0}&quot; to &quot;{1}&quot; because the objects are not the same type or the object &quot;{0}&quot; does not implement &quot;{2}&quot;..
    /// </summary>
    internal static string NotTheSameTypeOrNotIcomparable {
        get {
            return ResourceManager.GetString("NotTheSameTypeOrNotIcomparable", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to &quot;{0}&quot; returned a null value..
    /// </summary>
    internal static string NullReturnValueError {
        get {
            return ResourceManager.GetString("NullReturnValueError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot create object of type &quot;{0}&quot;. {1}.
    /// </summary>
    internal static string ObjectCreationError {
        get {
            return ResourceManager.GetString("ObjectCreationError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot get the value of property &quot;{0}&quot;..
    /// </summary>
    internal static string PropertyGetError {
        get {
            return ResourceManager.GetString("PropertyGetError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot determine whether property &quot;{0}&quot; is gettable..
    /// </summary>
    internal static string PropertyIsGettableError {
        get {
            return ResourceManager.GetString("PropertyIsGettableError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot determine whether property &quot;{0}&quot; can be changed..
    /// </summary>
    internal static string PropertyIsSettableError {
        get {
            return ResourceManager.GetString("PropertyIsSettableError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The {0} property was not found for the {1} object. The available property is: {2}.
    /// </summary>
    internal static string PropertyNotFound {
        get {
            return ResourceManager.GetString("PropertyNotFound", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The property &quot;{0}&quot; was not found..
    /// </summary>
    internal static string PropertyNotFoundInTypeDescriptor {
        get {
            return ResourceManager.GetString("PropertyNotFoundInTypeDescriptor", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot set the value of property &quot;{0}&quot;..
    /// </summary>
    internal static string PropertySetError {
        get {
            return ResourceManager.GetString("PropertySetError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The adapter cannot get the type of property &quot;{0}&quot;..
    /// </summary>
    internal static string PropertyTypeError {
        get {
            return ResourceManager.GetString("PropertyTypeError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to &quot;{0}&quot; is a ReadOnly property..
    /// </summary>
    internal static string ReadOnlyProperty {
        get {
            return ResourceManager.GetString("ReadOnlyProperty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Argument: &apos;{0}&apos; should not be a {1}. Do not use {2}..
    /// </summary>
    internal static string RefArgumentToNonRefParameter {
        get {
            return ResourceManager.GetString("RefArgumentToNonRefParameter", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Reference type is expected in argument..
    /// </summary>
    internal static string ReferenceTypeExpected {
        get {
            return ResourceManager.GetString("ReferenceTypeExpected", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The member name &quot;{0}&quot; is reserved..
    /// </summary>
    internal static string ReservedMemberName {
        get {
            return ResourceManager.GetString("ReservedMemberName", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Set accessor for property &quot;{0}&quot; is unavailable..
    /// </summary>
    internal static string SetWithoutSetterException {
        get {
            return ResourceManager.GetString("SetWithoutSetterException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following exception occurred while retrieving the string: &quot;{0}&quot;.
    /// </summary>
    internal static string ToStringException {
        get {
            return ResourceManager.GetString("ToStringException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to The following error occurred while loading the extended type data file: {0}.
    /// </summary>
    internal static string TypesXmlError {
        get {
            return ResourceManager.GetString("TypesXmlError", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Exception calling &quot;{0}&quot; : &quot;{1}&quot;.
    /// </summary>
    internal static string WMIMethodInvocationException {
        get {
            return ResourceManager.GetString("WMIMethodInvocationException", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot get property value because &quot;{0}&quot; is a write-only property..
    /// </summary>
    internal static string WriteOnlyProperty {
        get {
            return ResourceManager.GetString("WriteOnlyProperty", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot set &quot;{0}&quot; because only unique attributes or unique non-attributed leaf nodes can be set..
    /// </summary>
    internal static string XmlNodeSetRestrictions {
        get {
            return ResourceManager.GetString("XmlNodeSetRestrictions", resourceCulture);
        }
    }
    
    /// <summary>
    ///   Looks up a localized string similar to Cannot set &quot;{0}&quot; because only strings can be used as values to set XmlNode properties..
    /// </summary>
    internal static string XmlNodeSetShouldBeAString {
        get {
            return ResourceManager.GetString("XmlNodeSetShouldBeAString", resourceCulture);
        }
    }
}