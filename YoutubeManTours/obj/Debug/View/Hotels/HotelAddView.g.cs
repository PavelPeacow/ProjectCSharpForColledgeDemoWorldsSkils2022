﻿#pragma checksum "..\..\..\..\View\Hotels\HotelAddView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A060E37E53F6BE6DE8891D22866E85C9FDAF9B5CB5EC84B828A1F8772BD422D"
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
using YoutubeManTours.View.Hotels;


namespace YoutubeManTours.View.Hotels {
    
    
    /// <summary>
    /// HotelAddView
    /// </summary>
    public partial class HotelAddView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\..\View\Hotels\HotelAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNameHotel;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\View\Hotels\HotelAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtCountStars;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\View\Hotels\HotelAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtDescriptionHotel;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\View\Hotels\HotelAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbNameCountry;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\View\Hotels\HotelAddView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAddHotel;
        
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
            System.Uri resourceLocater = new System.Uri("/YoutubeManTours;component/view/hotels/hoteladdview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Hotels\HotelAddView.xaml"
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
            this.TxtNameHotel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtCountStars = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxtDescriptionHotel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CmbNameCountry = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.BtnAddHotel = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\..\View\Hotels\HotelAddView.xaml"
            this.BtnAddHotel.Click += new System.Windows.RoutedEventHandler(this.BtnAddHotel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

