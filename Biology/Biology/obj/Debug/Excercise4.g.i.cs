﻿#pragma checksum "..\..\Excercise4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CF128E9670FE246F1AF341371B45B439B4D1C981"
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
    /// Excercise4
    /// </summary>
    public partial class Excercise4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Genotype;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Fenotype;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Correct;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image False;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label AnswerText;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTarget1;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTarget2;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\Excercise4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCheckAnswers;
        
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
            System.Uri resourceLocater = new System.Uri("/Biology;component/excercise4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Excercise4.xaml"
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
            this.Genotype = ((System.Windows.Controls.Label)(target));
            
            #line 60 "..\..\Excercise4.xaml"
            this.Genotype.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Fenotype = ((System.Windows.Controls.Label)(target));
            
            #line 69 "..\..\Excercise4.xaml"
            this.Fenotype.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseDown_2);
            
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
            
            #line 101 "..\..\Excercise4.xaml"
            this.txtTarget1.Drop += new System.Windows.DragEventHandler(this.txtTarget1_Drop);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtTarget2 = ((System.Windows.Controls.TextBlock)(target));
            
            #line 106 "..\..\Excercise4.xaml"
            this.txtTarget2.Drop += new System.Windows.DragEventHandler(this.txtTarget2_Drop);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonCheckAnswers = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\Excercise4.xaml"
            this.ButtonCheckAnswers.Click += new System.Windows.RoutedEventHandler(this.ButtonCheckAnswers_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 128 "..\..\Excercise4.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 136 "..\..\Excercise4.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowDownButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 144 "..\..\Excercise4.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ArrowRightButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

