﻿#pragma checksum "..\..\..\Views\CrudUsuarios.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30143773CF14876A382810A5718725BE66B5A805"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Annies_Store.Views;
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


namespace Annies_Store.Views {
    
    
    /// <summary>
    /// CrudUsuarios
    /// </summary>
    public partial class CrudUsuarios : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 114 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNombres;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbApellidos;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCI;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNIT;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbCorreo;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbTelefono;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbFechaDeNacimiento;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TbPrivilegios;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\Views\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagen;
        
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
            System.Uri resourceLocater = new System.Uri("/Annies Store;component/views/crudusuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\CrudUsuarios.xaml"
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
            this.Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BtnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\..\Views\CrudUsuarios.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.Regresar);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TbNombres = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TbApellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TbCI = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TbNIT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TbCorreo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TbTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.TbFechaDeNacimiento = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.TbPrivilegios = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.imagen = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
