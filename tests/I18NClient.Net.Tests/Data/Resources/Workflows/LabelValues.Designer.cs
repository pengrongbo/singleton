﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WanderingWiFi.AirWatch.Globalization.Resources.Workflows {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LabelValues {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LabelValues() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WanderingWiFi.AirWatch.Globalization.Resources.Workflows.LabelValues", typeof(LabelValues).Assembly);
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
        ///   Looks up a localized string similar to Workflow sync failed.
        /// </summary>
        internal static string RequestWorkflowsSyncFailed {
            get {
                return ResourceManager.GetString("RequestWorkflowsSyncFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Workflow sync successful.
        /// </summary>
        internal static string RequestWorkflowsSyncSuccess {
            get {
                return ResourceManager.GetString("RequestWorkflowsSyncSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Workflows.
        /// </summary>
        internal static string WorkflowsSync {
            get {
                return ResourceManager.GetString("WorkflowsSync", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Sync Workflows.
        /// </summary>
        internal static string SyncWorkflows
        {
            get
            {
                return ResourceManager.GetString("SyncWorkflows", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Device received the workflow but has not yet reported a workflow step status..
        /// </summary>
        internal static string WorkflowStepStatusNotReported
        {
            get
            {
                return ResourceManager.GetString("WorkflowStepStatusNotReported", resourceCulture);
            }
        }
    }
}