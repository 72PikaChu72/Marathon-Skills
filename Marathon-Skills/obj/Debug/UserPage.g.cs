﻿#pragma checksum "..\..\UserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "08179CEE59147F6640C4EFDB3CCCDAD2533339AE7F9D336FBB574D54BB0D2BCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Marathon_Skills;
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


namespace Marathon_Skills {
    
    
    /// <summary>
    /// UserPage
    /// </summary>
    public partial class UserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grider;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MarathonStartTimer;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunnerButton2;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunnerButton3;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunnerButton4;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RunnerButton5;
        
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
            System.Uri resourceLocater = new System.Uri("/Marathon-Skills;component/userpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserPage.xaml"
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
            this.Grider = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.MarathonStartTimer = ((System.Windows.Controls.TextBlock)(target));
            
            #line 12 "..\..\UserPage.xaml"
            this.MarathonStartTimer.Loaded += new System.Windows.RoutedEventHandler(this.MarathonStartTimer_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 14 "..\..\UserPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RunnerButton2 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\UserPage.xaml"
            this.RunnerButton2.Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 5:
            this.RunnerButton3 = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\UserPage.xaml"
            this.RunnerButton3.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RunnerButton4 = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\UserPage.xaml"
            this.RunnerButton4.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RunnerButton5 = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\UserPage.xaml"
            this.RunnerButton5.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 19 "..\..\UserPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
