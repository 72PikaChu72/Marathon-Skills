#pragma checksum "..\..\RunnerSponsors.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E988A27EE876698D41CF67459FF357ECBBBB457B52E3E19AEF366CE5BD50AAF1"
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
    /// RunnerSponsors
    /// </summary>
    public partial class RunnerSponsors : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\RunnerSponsors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MarathonStartTimer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\RunnerSponsors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MainSponsorImage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\RunnerSponsors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView Sponsors;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RunnerSponsors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MainSponsor;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\RunnerSponsors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Count;
        
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
            System.Uri resourceLocater = new System.Uri("/Marathon-Skills;component/runnersponsors.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RunnerSponsors.xaml"
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
            this.MarathonStartTimer = ((System.Windows.Controls.TextBlock)(target));
            
            #line 12 "..\..\RunnerSponsors.xaml"
            this.MarathonStartTimer.Loaded += new System.Windows.RoutedEventHandler(this.MarathonStartTimer_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\RunnerSponsors.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MainSponsorImage = ((System.Windows.Controls.Image)(target));
            
            #line 17 "..\..\RunnerSponsors.xaml"
            this.MainSponsorImage.Loaded += new System.Windows.RoutedEventHandler(this.MainSponsorImage_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Sponsors = ((System.Windows.Controls.ListView)(target));
            
            #line 18 "..\..\RunnerSponsors.xaml"
            this.Sponsors.Loaded += new System.Windows.RoutedEventHandler(this.ListView_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MainSponsor = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Count = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

