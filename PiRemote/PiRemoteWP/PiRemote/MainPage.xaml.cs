﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Windows.Networking.Sockets;
using Windows.Networking;
using Windows.Storage.Streams;
using System.Text;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace PiRemote
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        StreamSocket clientSocket = new StreamSocket();
        HostName serverHost = new HostName("192.168.1.106");
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void EstablishConnection(object sender, RoutedEventArgs e)
        {
            try
            {
                await clientSocket.ConnectAsync(serverHost, "9875");
                ConnectButton.IsEnabled = false;
                SendStringButton.IsEnabled = true;
            }
            catch(Exception ex)
            {
            }
          

        }

        private async void SendString(string strData)
        {
            try
            {
                byte[] data = Encoding.Unicode.GetBytes(strData);
                IBuffer buffer = data.AsBuffer();

                await clientSocket.OutputStream.WriteAsync(buffer);
            }
            catch (Exception exception)
            {
                if (SocketError.GetStatus(exception.HResult) == SocketErrorStatus.Unknown)
                {
                    throw;
                }

            }
        }

        private void SendStringClick(object sender, RoutedEventArgs e)
        {
            SendString(StringBox.Text);
        }
    }
}
