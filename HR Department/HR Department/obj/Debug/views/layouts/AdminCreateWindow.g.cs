﻿#pragma checksum "..\..\..\..\views\layouts\AdminCreateWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D2A01ABB5875999D92C56FFFEE1E328419BAFBF2BFCD9D3B6F466FDC1E3755E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HR_Department.views.layouts;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace HR_Department.views.layouts {
    
    
    /// <summary>
    /// AdminCreateWindow
    /// </summary>
    public partial class AdminCreateWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock logotitle;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastName;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstName;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox post;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button companyStore;
        
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
            System.Uri resourceLocater = new System.Uri("/HR Department;component/views/layouts/admincreatewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
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
            
            #line 12 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
            ((HR_Department.views.layouts.AdminCreateWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 26 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
            ((MaterialDesignThemes.Wpf.PackIcon)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseLogin);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logotitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.lastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.firstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.post = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.password = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.companyStore = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\..\..\views\layouts\AdminCreateWindow.xaml"
            this.companyStore.Click += new System.Windows.RoutedEventHandler(this.companyStore_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

