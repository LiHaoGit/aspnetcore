// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING
// WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR CONDITIONS OF
// TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR
// NON-INFRINGEMENT.
// See the Apache 2 License for the specific language governing
// permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34006
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Net.Http.Server {
    using System;
    
    
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Net.Http.Server.Resources", System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(Resources)).Assembly);
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
        ///   Looks up a localized string similar to The destination array is too small..
        /// </summary>
        internal static string Exception_ArrayTooSmall {
            get {
                return ResourceManager.GetString("Exception_ArrayTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to End has already been called..
        /// </summary>
        internal static string Exception_EndCalledMultipleTimes {
            get {
                return ResourceManager.GetString("Exception_EndCalledMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The status code &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string Exception_InvalidStatusCode {
            get {
                return ResourceManager.GetString("Exception_InvalidStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The stream is not seekable..
        /// </summary>
        internal static string Exception_NoSeek {
            get {
                return ResourceManager.GetString("Exception_NoSeek", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The prefix &apos;{0}&apos; is already registered..
        /// </summary>
        internal static string Exception_PrefixAlreadyRegistered {
            get {
                return ResourceManager.GetString("Exception_PrefixAlreadyRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This stream only supports read operations..
        /// </summary>
        internal static string Exception_ReadOnlyStream {
            get {
                return ResourceManager.GetString("Exception_ReadOnlyStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More data written than specified in the Content-Length header..
        /// </summary>
        internal static string Exception_TooMuchWritten {
            get {
                return ResourceManager.GetString("Exception_TooMuchWritten", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only the http and https schemes are supported..
        /// </summary>
        internal static string Exception_UnsupportedScheme {
            get {
                return ResourceManager.GetString("Exception_UnsupportedScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This stream only supports write operations..
        /// </summary>
        internal static string Exception_WriteOnlyStream {
            get {
                return ResourceManager.GetString("Exception_WriteOnlyStream", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given IAsyncResult does not match this opperation..
        /// </summary>
        internal static string Exception_WrongIAsyncResult {
            get {
                return ResourceManager.GetString("Exception_WrongIAsyncResult", resourceCulture);
            }
        }

        /// <summary>
        /// An exception occured while running an action registered with {0}.
        /// </summary>
        internal static string Warning_ExceptionInOnResponseCompletedAction
        {
            get { return ResourceManager.GetString("Warning_ExceptionInOnResponseCompletedAction"); }
        }
    }
}
