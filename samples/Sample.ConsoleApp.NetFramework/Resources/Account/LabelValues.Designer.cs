﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sample.ConsoleApp.NetFramework.Resources.Account {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
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
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sample.ConsoleApp.NetFramework.Resources.Account.LabelValues", typeof(LabelValues).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 Allow HTTP, Allow HTTPs 的本地化字符串。
        /// </summary>
        internal static string ALLOW_HTTP_HTTPS {
            get {
                return ResourceManager.GetString("ALLOW_HTTP_HTTPS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CDS Instance 的本地化字符串。
        /// </summary>
        internal static string CDS_INSTANCE {
            get {
                return ResourceManager.GetString("CDS_INSTANCE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Default 的本地化字符串。
        /// </summary>
        internal static string DEFAULT {
            get {
                return ResourceManager.GetString("DEFAULT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 All Detail Pages 的本地化字符串。
        /// </summary>
        internal static string DETAIL_PAGE {
            get {
                return ResourceManager.GetString("DETAIL_PAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 External IP Address 的本地化字符串。
        /// </summary>
        internal static string EXTERNAL {
            get {
                return ResourceManager.GetString("EXTERNAL", resourceCulture);
            }
        }
    }
}
