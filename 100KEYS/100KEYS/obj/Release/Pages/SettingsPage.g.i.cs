﻿#pragma checksum "C:\Users\Artem Shishkin\Desktop\100KEYS\100KEYS\Pages\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7922EA1CD77201ED8BB745EA80E8E42"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace KEYSAPP.Pages {
    
    
    public partial class SettingsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle RecTitle;
        
        internal System.Windows.Controls.TextBlock PTitle;
        
        internal System.Windows.Controls.TextBlock Keys;
        
        internal System.Windows.Controls.Button ButClear;
        
        internal System.Windows.Controls.Button ButThem;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/100KEYS;component/Pages/SettingsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RecTitle = ((System.Windows.Shapes.Rectangle)(this.FindName("RecTitle")));
            this.PTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PTitle")));
            this.Keys = ((System.Windows.Controls.TextBlock)(this.FindName("Keys")));
            this.ButClear = ((System.Windows.Controls.Button)(this.FindName("ButClear")));
            this.ButThem = ((System.Windows.Controls.Button)(this.FindName("ButThem")));
        }
    }
}

