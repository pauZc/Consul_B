﻿#pragma checksum "..\..\ConsultaWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6DB53D39E6E9CB5030D88D383A44A28B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace WpfApplication {
    
    
    /// <summary>
    /// ConsultaWindow
    /// </summary>
    public partial class ConsultaWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstCitas;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblDate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblEdad;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGrasa;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMagra;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWeight;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtComent;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Clean;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label History;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\ConsultaWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication;component/consultawindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConsultaWindow.xaml"
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
            
            #line 4 "..\..\ConsultaWindow.xaml"
            ((WpfApplication.ConsultaWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstCitas = ((System.Windows.Controls.ListBox)(target));
            
            #line 11 "..\..\ConsultaWindow.xaml"
            this.lstCitas.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.lstCitas_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblDate = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblName = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblEdad = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtGrasa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtMagra = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtWeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtComent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.Clean = ((System.Windows.Controls.Label)(target));
            
            #line 58 "..\..\ConsultaWindow.xaml"
            this.Clean.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Clear_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.History = ((System.Windows.Controls.Label)(target));
            
            #line 63 "..\..\ConsultaWindow.xaml"
            this.History.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btnHN_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnSave = ((System.Windows.Controls.Label)(target));
            
            #line 68 "..\..\ConsultaWindow.xaml"
            this.btnSave.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 80 "..\..\ConsultaWindow.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.UIElement_OnMouseUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

