﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunityToolkit.Maui.Analyzers {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CommunityToolkit.Maui.Analyzers.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
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
        ///   Consulta uma cadeia de caracteres localizada semelhante a All CSharp files should have a suffix.
        /// </summary>
        internal static string CheckFileNameAnalyzerDescription {
            get {
                return ResourceManager.GetString("CheckFileNameAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Suffix is missing on your file name.
        /// </summary>
        internal static string CheckFileNameAnalyzerTitle {
            get {
                return ResourceManager.GetString("CheckFileNameAnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Implement this member.
        /// </summary>
        internal static string NotImplementedAnalyzerDescription {
            get {
                return ResourceManager.GetString("NotImplementedAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a NotImplemented Exception is not allowed.
        /// </summary>
        internal static string NotImplementedAnalyzerTitle {
            get {
                return ResourceManager.GetString("NotImplementedAnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a You should implement this member.
        /// </summary>
        internal static string NotImplementedMessageFormat {
            get {
                return ResourceManager.GetString("NotImplementedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a You should use Argument.ThrowIfNull(parameter).
        /// </summary>
        internal static string NullArgumentAnalyzerDescription {
            get {
                return ResourceManager.GetString("NullArgumentAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a Checking the type &apos;{0}&apos; in the wrong way.
        /// </summary>
        internal static string NullArgumentAnalyzerMessageFormat {
            get {
                return ResourceManager.GetString("NullArgumentAnalyzerMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a You&apos;re checking for null in the wrong way.
        /// </summary>
        internal static string NullArgumentAnalyzerTitle {
            get {
                return ResourceManager.GetString("NullArgumentAnalyzerTitle", resourceCulture);
            }
        }
    }
}
