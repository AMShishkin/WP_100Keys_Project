﻿#pragma checksum "C:\Users\Artem Shishkin\Desktop\100KEYS_1.2.0.0\100KEYS\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "067221C39366B26D352330B1A58CF4BC"
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


namespace KEYSAPP {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard AMPStart;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Shapes.Rectangle RecTitle;
        
        internal System.Windows.Controls.TextBlock PTitle;
        
        internal System.Windows.Controls.TextBlock Logo;
        
        internal System.Windows.Controls.TextBlock Keys;
        
        internal System.Windows.Controls.Button ButPlay;
        
        internal System.Windows.Controls.Button ButInfo;
        
        internal System.Windows.Controls.Button ButThem;
        
        internal System.Windows.Controls.Button ButSound;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/100KEYS;component/Pages/MainPage.xaml", System.UriKind.Relative));
            this.AMPStart = ((System.Windows.Media.Animation.Storyboard)(this.FindName("AMPStart")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RecTitle = ((System.Windows.Shapes.Rectangle)(this.FindName("RecTitle")));
            this.PTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PTitle")));
            this.Logo = ((System.Windows.Controls.TextBlock)(this.FindName("Logo")));
            this.Keys = ((System.Windows.Controls.TextBlock)(this.FindName("Keys")));
            this.ButPlay = ((System.Windows.Controls.Button)(this.FindName("ButPlay")));
            this.ButInfo = ((System.Windows.Controls.Button)(this.FindName("ButInfo")));
            this.ButThem = ((System.Windows.Controls.Button)(this.FindName("ButThem")));
            this.ButSound = ((System.Windows.Controls.Button)(this.FindName("ButSound")));
        }
    }
}
