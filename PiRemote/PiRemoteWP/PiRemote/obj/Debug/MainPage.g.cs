﻿

#pragma checksum "C:\Users\Mordonus\documents\visual studio 2013\Projects\PiRemote\PiRemote\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DE4896AEA08C8BDFDEEDE82EA0979C00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PiRemote
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 75 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ButtonPause_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 82 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.PickTrackAtRandom;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 83 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.StartRandoming;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 68 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_1;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 69 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 70 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_2;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 71 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Button_Click_3;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 61 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonFetchLinks_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 29 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.EstablishConnection;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 30 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SendStringClick;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 35 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.DisposeConnection;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


