using AppShopping.Libraries.Helpers.Connect;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppShopping.iOS.Libraries.Helpers.Connect.WifiConnector))]
namespace AppShopping.iOS.Libraries.Helpers.Connect
{
    public class WifiConnector : IWifiConnector
    {
        public void ConnectToWifi(string ssid, string password)
        {
            throw new NotImplementedException();
        }
    }
}