﻿#pragma checksum "..\..\Excercise2.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A8370A3DCCDB01A6B9ED0296B33CB3C2BE3A5E39"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Biology;
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


namespace Biology {
    
    
    /// <summary>
    /// Excercise2
    /// </summary>
    public partial class Excercise2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Gene;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Spadok;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Correct;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image False;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AnswerText;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTarget1;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTarget2;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ArrowLeft;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ArrowHome;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\Excercise2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ArrowRight;
        
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
            System.Uri resourceLocater = new System.Uri("/Biology;component/excercise2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Excercise2.xaml"
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
            this.Gene = ((System.Windows.Controls.Label)(target));
            
            #line 60 "..\..\Excercise2.xaml"
            this.Gene.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label2_Drag);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Spadok = ((System.Windows.Controls.Label)(target));
            
            #line 69 "..\..\Excercise2.xaml"
            this.Spadok.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label1_Drag);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Correct = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.False = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.AnswerText = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtTarget1 = ((System.Windows.Controls.TextBlock)(target));
            
            #line 101 "..\..\Excercise2.xaml"
            this.txtTarget1.Drop += new System.Windows.DragEventHandler(this.txtTarget1_Drop);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtTarget2 = ((System.Windows.Controls.TextBlock)(target));
            
            #line 106 "..\..\Excercise2.xaml"
            this.txtTarget2.Drop += new System.Windows.DragEventHandler(this.txtTarget2_Drop);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 118 "..\..\Excercise2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonCheck_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ArrowLeft = ((System.Windows.Controls.Image)(target));
            
            #line 128 "..\..\Excercise2.xaml"
            this.ArrowLeft.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ArrowHome = ((System.Windows.Controls.Image)(target));
            
            #line 136 "..\..\Excercise2.xaml"
            this.ArrowHome.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowDownButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ArrowRight = ((System.Windows.Controls.Image)(target));
            
            #line 144 "..\..\Excercise2.xaml"
            this.ArrowRight.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowRightButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
