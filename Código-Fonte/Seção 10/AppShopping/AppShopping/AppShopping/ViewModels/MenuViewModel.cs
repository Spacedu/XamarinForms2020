using AppShopping.Libraries.Helpers.MVVM;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using MvvmHelpers.Commands;
using System.Threading.Tasks;

namespace AppShopping.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        public ICommand OpenMapCommand { get; set; }
        public MenuViewModel()
        {
            OpenMapCommand = new AsyncCommand(OpenMap);
        }

        private async Task OpenMap()
        {
            var location = new Location(-15.832560908920001, -47.95614058225712);
            var options = new MapLaunchOptions { Name = "App - Shopping", NavigationMode = NavigationMode.Default };

            try
            {
                await Map.OpenAsync(location, options);
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Erro!", "Não conseguimos abrir o mapa do seu celular!", "OK");
            }
            
        }
    }
}
