﻿#pragma checksum "..\..\AddSupplierWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "008F7F760467052BEC746026F45B40D3DB206B17"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SuhadahWMS;
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


namespace SuhadahWMS {
    
    
    /// <summary>
    /// AddSupplierWindow
    /// </summary>
    public partial class AddSupplierWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SupplierCodeTextbox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextbox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AddressTextbox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneTextbox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextbox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteTextbox;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddSupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddSupplierBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/SuhadahWMS;component/addsupplierwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddSupplierWindow.xaml"
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
            this.SupplierCodeTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.NameTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.AddressTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.PhoneTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EmailTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.NoteTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.AddSupplierBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\AddSupplierWindow.xaml"
            this.AddSupplierBtn.Click += new System.Windows.RoutedEventHandler(this.AddSupplierBtnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

