﻿#pragma checksum "..\..\Cuenta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73F258184780A95C7D2310BD78AC1ECFDD4EB036FF2AE9F3E04B7E5F7ADE28BC"
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
using estudioGrabacion;


namespace estudioGrabacion {
    
    
    /// <summary>
    /// Cuenta
    /// </summary>
    public partial class Cuenta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Cuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button inicio;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Cuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button beat;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Cuenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button estudio;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Cuenta.xaml"
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
            System.Uri resourceLocater = new System.Uri("/estudioGrabacion;component/cuenta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Cuenta.xaml"
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
            
            #line 19 "..\..\Cuenta.xaml"
            this.inicio.Click += new System.Windows.RoutedEventHandler(this.inicio_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.beat = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Cuenta.xaml"
            this.beat.Click += new System.Windows.RoutedEventHandler(this.beat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.estudio = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Cuenta.xaml"
            this.estudio.Click += new System.Windows.RoutedEventHandler(this.estudio_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cuenta = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

