﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EventoMobile.UWP
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        private global::EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo.XamlMetaDataProvider __appProvider;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo.XamlMetaDataProvider _AppProvider
        {
            get
            {
                if (__appProvider == null)
                {
                    __appProvider = new global::EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo.XamlMetaDataProvider();
                }
                return __appProvider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return _AppProvider.GetXamlType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return _AppProvider.GetXamlType(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return _AppProvider.GetXmlnsDefinitions();
        }
    }
}

namespace EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo
{
    /// <summary>
    /// Main class for providing metadata for the app or library
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed class XamlMetaDataProvider : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo.XamlTypeInfoProvider _provider = null;

        private global::EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo.XamlTypeInfoProvider Provider
        {
            get
            {
                if (_provider == null)
                {
                    _provider = new global::EventoMobile.UWP.EventoMobile_UWP_XamlTypeInfo.XamlTypeInfoProvider();
                }
                return _provider;
            }
        }

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            return Provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            return Provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        private global::Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider _Provider;
        private global::Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider Provider
        {
            get
            {
                if (_Provider == null)
                {
                    _Provider = new global::Microsoft.UI.Xaml.Markup.ReflectionXamlMetadataProvider();
                }
                return _Provider;
            }
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            return Provider.GetXamlType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            return Provider.GetXamlType(typeName);
        }
    }
}

