﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmbryoExpress.Res {
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
    internal class ProblemReportForm {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ProblemReportForm() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EmbryoExpress.Res.ProblemReportForm", typeof(ProblemReportForm).Assembly);
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
        ///   Looks up a localized string similar to Error Diagnosis Report has been created successfully and saved in the following directory:
        ///
        ///{0}
        ///
        ///Please contact ACEA technical support and provide this report..
        /// </summary>
        internal static string CreateErrorDiagnososReportOK {
            get {
                return ResourceManager.GetString("CreateErrorDiagnososReportOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Diagnosis Report creation is in progress. Please wait..
        /// </summary>
        internal static string CreatingErrorDiagnososReport {
            get {
                return ResourceManager.GetString("CreatingErrorDiagnososReport", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open folder containing the Error Diagnosis Report.
        /// </summary>
        internal static string OpenReportFolder {
            get {
                return ResourceManager.GetString("OpenReportFolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create Error Diagnosis Report.
        /// </summary>
        internal static string ProblemReportFormTitle {
            get {
                return ResourceManager.GetString("ProblemReportFormTitle", resourceCulture);
            }
        }
    }
}
