﻿

#pragma checksum "C:\Users\Nathan\Documents\GitHub\FantasyDraftTimer\FantasyDraftTimer\FantasyDraftTimer\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2793E2516EB245508AC9C972C7D83F80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FantasyDraftTimer
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid StartOverlayGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button StartDraftClick; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::FantasyDraftTimer.NumberPicker MinPicker; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::FantasyDraftTimer.NumberPicker SecPicker; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::FantasyDraftTimer.NumberPicker PicksPicker; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::FantasyDraftTimer.NumberPicker RoundsPicker; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::FantasyDraftTimer.Timer Timer; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button TimerButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock CurrentPickText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock CurrentRoundText; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///MainPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            StartOverlayGrid = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("StartOverlayGrid");
            StartDraftClick = (global::Windows.UI.Xaml.Controls.Button)this.FindName("StartDraftClick");
            MinPicker = (global::FantasyDraftTimer.NumberPicker)this.FindName("MinPicker");
            SecPicker = (global::FantasyDraftTimer.NumberPicker)this.FindName("SecPicker");
            PicksPicker = (global::FantasyDraftTimer.NumberPicker)this.FindName("PicksPicker");
            RoundsPicker = (global::FantasyDraftTimer.NumberPicker)this.FindName("RoundsPicker");
            Timer = (global::FantasyDraftTimer.Timer)this.FindName("Timer");
            TimerButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("TimerButton");
            CurrentPickText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("CurrentPickText");
            CurrentRoundText = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("CurrentRoundText");
        }
    }
}



