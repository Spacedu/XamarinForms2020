using AppShopping.Libraries.Helpers.Connect;
using AppShopping.Libraries.Helpers.MVVM;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShopping.ViewModels
{
    public class WifiViewModel : BaseViewModel
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }


        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public ICommand ConnectToWifiCommand { get; set; }

        public WifiViewModel()
        {
            ConnectToWifiCommand = new Command(ConnectToWifi);
        }

        private void ConnectToWifi()
        {
            try
            {
                var wifiConnector = Xamarin.Forms.DependencyService.Get<IWifiConnector>();
                wifiConnector.ConnectToWifi("WIFI_SHOPPING", "12345678");

                HttpClient client = new HttpClient();
                client.GetAsync($"http://appshopping.com.br/wifi/liberar?email={Email}");
            }
            catch(Exception e)
            {
                Message = e.Message;
            }
            
        }
    }
}
