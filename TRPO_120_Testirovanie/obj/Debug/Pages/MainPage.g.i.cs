﻿#pragma checksum "..\..\..\Pages\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1FCF5D2544AC60B59EC7B7778B950826188944DF85F600EFA1FC677142196E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using TRPO_120_Testirovanie;


namespace TRPO_120_Testirovanie {
    
    
    /// <summary>
    /// MainPage
    /// </summary>
    public partial class MainPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Search;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Testbut;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Questbut;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Studbut;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Addbut;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\MainPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame dbFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/TRPO_120_Testirovanie;component/pages/mainpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MainPage.xaml"
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
            this.Search = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Testbut = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\MainPage.xaml"
            this.Testbut.Click += new System.Windows.RoutedEventHandler(this.Tests_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Questbut = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Pages\MainPage.xaml"
            this.Questbut.Click += new System.Windows.RoutedEventHandler(this.Questions_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Studbut = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Pages\MainPage.xaml"
            this.Studbut.Click += new System.Windows.RoutedEventHandler(this.Students_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Addbut = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Pages\MainPage.xaml"
            this.Addbut.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dbFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
