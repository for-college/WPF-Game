﻿#pragma checksum "..\..\Rules.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "277799ABADDD98DFE5AAD5074B02DD50DDCE7350B10F9A8CD6EA17672601A381"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyGame;
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


namespace MyGame {
    
    
    /// <summary>
    /// Rules
    /// </summary>
    public partial class Rules : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Rules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rulesBlock;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Rules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ruleButtonNext;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Rules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ruleButtonBefore;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Rules.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
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
            System.Uri resourceLocater = new System.Uri("/MyGame;component/rules.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Rules.xaml"
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
            this.rulesBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ruleButtonNext = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\Rules.xaml"
            this.ruleButtonNext.Click += new System.Windows.RoutedEventHandler(this.NextRule);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ruleButtonBefore = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Rules.xaml"
            this.ruleButtonBefore.Click += new System.Windows.RoutedEventHandler(this.PrevRule);
            
            #line default
            #line hidden
            return;
            case 4:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Rules.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

