﻿#pragma checksum "..\..\Format.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "61996E835B4396B0AC1AC142CEA6D0AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BetterNotepad;
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


namespace BetterNotepad {
    
    
    /// <summary>
    /// Format
    /// </summary>
    public partial class Format : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label example_label;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cb_fontFamily;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label size_label;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slider_size;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chckBox_bold;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chckBox_italic;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_save_format;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Format.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/BetterNotepad;component/format.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Format.xaml"
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
            this.example_label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.cb_fontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\Format.xaml"
            this.cb_fontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cb_fontFamily_Selected);
            
            #line default
            #line hidden
            return;
            case 3:
            this.size_label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.slider_size = ((System.Windows.Controls.Slider)(target));
            
            #line 33 "..\..\Format.xaml"
            this.slider_size.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slider_size_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chckBox_bold = ((System.Windows.Controls.CheckBox)(target));
            
            #line 37 "..\..\Format.xaml"
            this.chckBox_bold.Checked += new System.Windows.RoutedEventHandler(this.chckBox_bold_Checked);
            
            #line default
            #line hidden
            
            #line 37 "..\..\Format.xaml"
            this.chckBox_bold.Unchecked += new System.Windows.RoutedEventHandler(this.chckBox_bold_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.chckBox_italic = ((System.Windows.Controls.CheckBox)(target));
            
            #line 39 "..\..\Format.xaml"
            this.chckBox_italic.Checked += new System.Windows.RoutedEventHandler(this.chckBox_italic_Checked);
            
            #line default
            #line hidden
            
            #line 39 "..\..\Format.xaml"
            this.chckBox_italic.Unchecked += new System.Windows.RoutedEventHandler(this.chckBox_italic_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_save_format = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Format.xaml"
            this.btn_save_format.Click += new System.Windows.RoutedEventHandler(this.btn_save_format_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Format.xaml"
            this.btn_cancel.Click += new System.Windows.RoutedEventHandler(this.btn_cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
