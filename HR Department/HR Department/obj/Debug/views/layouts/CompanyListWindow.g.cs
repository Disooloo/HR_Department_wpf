﻿#pragma checksum "..\..\..\..\views\layouts\CompanyListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "69F4C39C8BB8147466F8E6DC6601DEE18B55B7A9504A8F0AEB52C36B2F4668E8"
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
    /// CompanyListWindow
    /// </summary>
    public partial class CompanyListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 148 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem company;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem vacancy;
        
        #line default
        #line hidden
        
        
        #line 173 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Minimase;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button close;
        
        #line default
        #line hidden
        
        
        #line 193 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/HR Department;component/views/layouts/companylistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
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
            
            #line 14 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            ((HR_Department.views.layouts.CompanyListWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.dragme);
            
            #line default
            #line hidden
            
            #line 14 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            ((HR_Department.views.layouts.CompanyListWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.company = ((System.Windows.Controls.MenuItem)(target));
            
            #line 149 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            this.company.Click += new System.Windows.RoutedEventHandler(this.company_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.vacancy = ((System.Windows.Controls.MenuItem)(target));
            
            #line 158 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            this.vacancy.Click += new System.Windows.RoutedEventHandler(this.vacancy_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Minimase = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            this.Minimase.Click += new System.Windows.RoutedEventHandler(this.Minimase_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.close = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            this.close.Click += new System.Windows.RoutedEventHandler(this.close_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            
            #line 193 "..\..\..\..\views\layouts\CompanyListWindow.xaml"
            this.MainFrame.ContentRendered += new System.EventHandler(this.MainFrame_ContentRendered);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

