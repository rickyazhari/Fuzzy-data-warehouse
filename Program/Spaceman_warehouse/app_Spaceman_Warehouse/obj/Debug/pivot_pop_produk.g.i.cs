﻿#pragma checksum "..\..\pivot_pop_produk.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "762C2B7F2DD6D0AEA5B2D4FDE204A961"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Mvvm;
using DevExpress.Mvvm.UI;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Charts;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.ConditionalFormattingManager;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DataPager;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.ExpressionEditor;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Flyout;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.RangeControl;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.PivotGrid;
using DevExpress.Xpf.PropertyGrid;
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


namespace app_Spaceman_Warehouse {
    
    
    /// <summary>
    /// pivot_pop_produk
    /// </summary>
    public partial class pivot_pop_produk : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// pivot_height Name Field
        /// </summary>
        
        #line 19 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.RowDefinition pivot_height;
        
        #line default
        #line hidden
        
        /// <summary>
        /// chart_height Name Field
        /// </summary>
        
        #line 21 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.RowDefinition chart_height;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.PivotGrid.PivotGridControl pivot;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.PivotGrid.PivotGridField produk_field;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.PivotGrid.PivotGridField tahun_field;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.PivotGrid.PivotGridField kelas_field;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\pivot_pop_produk.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.PivotGrid.PivotGridField kepopuleran;
        
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
            System.Uri resourceLocater = new System.Uri("/app_Spaceman_Warehouse;component/pivot_pop_produk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\pivot_pop_produk.xaml"
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
            this.pivot_height = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 2:
            this.chart_height = ((System.Windows.Controls.RowDefinition)(target));
            return;
            case 3:
            this.pivot = ((DevExpress.Xpf.PivotGrid.PivotGridControl)(target));
            return;
            case 4:
            this.produk_field = ((DevExpress.Xpf.PivotGrid.PivotGridField)(target));
            return;
            case 5:
            this.tahun_field = ((DevExpress.Xpf.PivotGrid.PivotGridField)(target));
            return;
            case 6:
            this.kelas_field = ((DevExpress.Xpf.PivotGrid.PivotGridField)(target));
            return;
            case 7:
            this.kepopuleran = ((DevExpress.Xpf.PivotGrid.PivotGridField)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

