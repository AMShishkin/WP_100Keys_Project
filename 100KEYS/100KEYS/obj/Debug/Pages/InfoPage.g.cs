﻿#pragma checksum "C:\Users\Artem Shishkin\Desktop\100KEYS_1.2.0.0\100KEYS\Pages\InfoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3A7C3A4C9822C9536FAE6D4F940A114C"
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
    
    
    public partial class InfoPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard AIPStart;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle RecTitle;
        
        internal System.Windows.Controls.TextBlock Keys;
        
        internal System.Windows.Controls.TextBlock BaseInfo;
        
        internal System.Windows.Controls.Button But100Keys;
        
        internal System.Windows.Controls.Button ButOtherApps;
        
        internal System.Windows.Controls.Button ButRate;
        
        internal System.Windows.Controls.Button ButContct;
        
        internal System.Windows.Controls.TextBlock PTitle;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/100KEYS;component/Pages/InfoPage.xaml", System.UriKind.Relative));
            this.AIPStart = ((System.Windows.Media.Animation.Storyboard)(this.FindName("AIPStart")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RecTitle = ((System.Windows.Shapes.Rectangle)(this.FindName("RecTitle")));
            this.Keys = ((System.Windows.Controls.TextBlock)(this.FindName("Keys")));
            this.BaseInfo = ((System.Windows.Controls.TextBlock)(this.FindName("BaseInfo")));
            this.But100Keys = ((System.Windows.Controls.Button)(this.FindName("But100Keys")));
            this.ButOtherApps = ((System.Windows.Controls.Button)(this.FindName("ButOtherApps")));
            this.ButRate = ((System.Windows.Controls.Button)(this.FindName("ButRate")));
            this.ButContct = ((System.Windows.Controls.Button)(this.FindName("ButContct")));
            this.PTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PTitle")));
        }
    }
}

