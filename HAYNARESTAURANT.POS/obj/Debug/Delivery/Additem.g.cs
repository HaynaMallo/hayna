﻿#pragma checksum "..\..\..\Delivery\Additem.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1DA16F12E4B23C80C4EF9EF16E028BD162275CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HAYNARESTAURANT.POS.Delivery;
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


namespace HAYNARESTAURANT.POS.Delivery {
    
    
    /// <summary>
    /// Additem
    /// </summary>
    public partial class Additem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel resultStack;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMaterial;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQty;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQty;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblMaterialId;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Delivery\Additem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/HAYNARESTAURANT.POS;component/delivery/additem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Delivery\Additem.xaml"
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
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\..\Delivery\Additem.xaml"
            this.textBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.textBox_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.resultStack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.lblMaterial = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtQty = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblQty = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblMaterialId = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Delivery\Additem.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Delivery\Additem.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.btnCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
