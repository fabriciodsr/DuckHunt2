﻿#pragma checksum "..\..\Score.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B79CA76122BBB98160E924DFB628D00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DuckHunter;
using Microsoft.Expression.Prototyping.Behavior;
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
using System.Windows.Interactivity;
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


namespace DuckHunter {
    
    
    /// <summary>
    /// Score
    /// </summary>
    public partial class Score : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Score.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CAPA_jpg;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Score.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblReiniciar;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Score.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblQuit;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Score.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblScoreMessage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Score.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblScoreCount;
        
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
            System.Uri resourceLocater = new System.Uri("/DuckHunter;component/score.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Score.xaml"
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
            this.CAPA_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.lblReiniciar = ((System.Windows.Controls.Label)(target));
            
            #line 25 "..\..\Score.xaml"
            this.lblReiniciar.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lblReiniciar_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.lblQuit = ((System.Windows.Controls.Label)(target));
            
            #line 26 "..\..\Score.xaml"
            this.lblQuit.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.lblQuit_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblScoreMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblScoreCount = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

