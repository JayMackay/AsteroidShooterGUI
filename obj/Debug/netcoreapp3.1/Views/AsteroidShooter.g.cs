﻿#pragma checksum "..\..\..\..\Views\AsteroidShooter.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58113F8C24150B0D009EE858DB993A36E975CFB4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AsteroidShooterGUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AsteroidShooterGUI {
    
    
    /// <summary>
    /// AsteroidShooter
    /// </summary>
    public partial class AsteroidShooter : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Views\AsteroidShooter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas MyCanvas;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Views\AsteroidShooter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle player;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\AsteroidShooter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreText;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\AsteroidShooter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label damageText;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Views\AsteroidShooter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockName;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\AsteroidShooter.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WelcomeHeading;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AsteroidShooterGUI;component/views/asteroidshooter.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AsteroidShooter.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\..\Views\AsteroidShooter.xaml"
            ((AsteroidShooterGUI.AsteroidShooter)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MyCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 26 "..\..\..\..\Views\AsteroidShooter.xaml"
            this.MyCanvas.KeyDown += new System.Windows.Input.KeyEventHandler(this.onKeyDown);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\Views\AsteroidShooter.xaml"
            this.MyCanvas.KeyUp += new System.Windows.Input.KeyEventHandler(this.onKeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.player = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.scoreText = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.damageText = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TextBlockName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.WelcomeHeading = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

