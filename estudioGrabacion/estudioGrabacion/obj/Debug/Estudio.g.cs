﻿#pragma checksum "..\..\Estudio.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D9ED1B515DCD9825991ABC63843701B53F1B9518DFAB736963AD52522FB6025"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WpfAnimatedGif;
using estudioGrabacion;


namespace estudioGrabacion {
    
    
    /// <summary>
    /// Estudio
    /// </summary>
    public partial class Estudio : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Estudio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button inicio;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Estudio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button beat;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Estudio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button estudio;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Estudio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cuenta;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/estudioGrabacion;component/estudio.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Estudio.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.inicio = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Estudio.xaml"
            this.inicio.Click += new System.Windows.RoutedEventHandler(this.inicio_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.beat = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\Estudio.xaml"
            this.beat.Click += new System.Windows.RoutedEventHandler(this.beat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.estudio = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.cuenta = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Estudio.xaml"
            this.cuenta.Click += new System.Windows.RoutedEventHandler(this.cuenta_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

