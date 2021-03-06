﻿#pragma checksum "..\..\OpenedDatabaseWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58D81B00B0300FBE3DC2F7C39C663BE2B23A7A551C03322F0474F8A5AFDBFFE4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using TechVault;


namespace TechVault {
    
    
    /// <summary>
    /// OpenedDatabaseWindow
    /// </summary>
    public partial class OpenedDatabaseWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\OpenedDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TechVault.OpenedDatabaseWindow OpenedDatabase;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\OpenedDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView EntryGroupsList;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\OpenedDatabaseWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView EntryList;
        
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
            System.Uri resourceLocater = new System.Uri("/TechVault;component/openeddatabasewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OpenedDatabaseWindow.xaml"
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
            this.OpenedDatabase = ((TechVault.OpenedDatabaseWindow)(target));
            return;
            case 2:
            
            #line 25 "..\..\OpenedDatabaseWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddEntry);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 33 "..\..\OpenedDatabaseWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddGroup);
            
            #line default
            #line hidden
            return;
            case 4:
            this.EntryGroupsList = ((System.Windows.Controls.ListView)(target));
            
            #line 49 "..\..\OpenedDatabaseWindow.xaml"
            this.EntryGroupsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectedGroupChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EntryList = ((System.Windows.Controls.ListView)(target));
            
            #line 62 "..\..\OpenedDatabaseWindow.xaml"
            this.EntryList.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EditEntry);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

