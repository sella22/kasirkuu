#pragma checksum "..\..\UpdateData.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1B7677CE6F7BEB095124E8015C745DEC8E7DA638"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Kasirku;
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


namespace Kasirku {
    
    
    /// <summary>
    /// UpdateData
    /// </summary>
    public partial class UpdateData : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataTransaksi;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBarang;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox jumlah;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock harga;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock total;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox bayar;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock sosok;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTambah;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEdit;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\UpdateData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHapus;
        
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
            System.Uri resourceLocater = new System.Uri("/Kasirku;component/updatedata.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdateData.xaml"
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
            
            #line 14 "..\..\UpdateData.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dataTransaksi = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\UpdateData.xaml"
            this.dataTransaksi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataTransaksi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbBarang = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\UpdateData.xaml"
            this.cbBarang.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbBarang_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.jumlah = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\UpdateData.xaml"
            this.jumlah.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Jumlah_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.harga = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.total = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.bayar = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\UpdateData.xaml"
            this.bayar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Bayar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.sosok = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.btnTambah = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\UpdateData.xaml"
            this.btnTambah.Click += new System.Windows.RoutedEventHandler(this.BtnTambah_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnEdit = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\UpdateData.xaml"
            this.btnEdit.Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnHapus = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\UpdateData.xaml"
            this.btnHapus.Click += new System.Windows.RoutedEventHandler(this.BtnHapus_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

