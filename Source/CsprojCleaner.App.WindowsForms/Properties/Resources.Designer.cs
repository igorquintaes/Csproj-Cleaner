﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CsprojCleaner.App.WindowsForms.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CsprojCleaner.App.WindowsForms.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Project Files|*.csproj.
        /// </summary>
        internal static string csprojFormat {
            get {
                return ResourceManager.GetString("csprojFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap eguru_logo {
            get {
                object obj = ResourceManager.GetObject("eguru logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Erro (Exception). Verifique o log..
        /// </summary>
        internal static string ErrorExceptionVerifyLog {
            get {
                return ResourceManager.GetString("ErrorExceptionVerifyLog", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Erro (ReadFolderException). Verifique o log. .
        /// </summary>
        internal static string ErrorFolderExceptionVerifyLog {
            get {
                return ResourceManager.GetString("ErrorFolderExceptionVerifyLog", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Erro ao instanciar log de erros: .
        /// </summary>
        internal static string ErrorLogExceptionInitialize {
            get {
                return ResourceManager.GetString("ErrorLogExceptionInitialize", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Concluído! Clique para executar de novo.
        /// </summary>
        internal static string FinishedClickToRunAgain {
            get {
                return ResourceManager.GetString("FinishedClickToRunAgain", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Aguarde....
        /// </summary>
        internal static string Loading___ {
            get {
                return ResourceManager.GetString("Loading...", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Verifique se todos os diretórios foram preenchidos..
        /// </summary>
        internal static string VerifyAllDirWasFilled {
            get {
                return ResourceManager.GetString("VerifyAllDirWasFilled", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Atenção!.
        /// </summary>
        internal static string Warning_ {
            get {
                return ResourceManager.GetString("Warning!", resourceCulture);
            }
        }
    }
}
