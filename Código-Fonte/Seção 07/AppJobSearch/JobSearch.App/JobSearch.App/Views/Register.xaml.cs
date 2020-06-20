using JobSearch.App.Models;
using JobSearch.App.Services;
using JobSearch.App.Utility.Load;
using JobSearch.Domain.Models;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobSearch.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        private UserService _service;
        public Register()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void SaveAction(object sender, EventArgs e)
        {
            TxtMessages.Text = String.Empty;

            string name = TxtName.Text;
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

            User user = new User() { Name = name, Email = email, Password = password };

            await Navigation.PushPopupAsync(new Loading());
            ResponseService<User> responseService = await _service.AddUser(user);

            if (responseService.IsSuccess)
            {
                App.Current.Properties.Add("User", JsonConvert.SerializeObject(responseService.Data));
                await App.Current.SavePropertiesAsync();
                App.Current.MainPage = new NavigationPage(new Start());
            }
            else
            {
                if (responseService.StatusCode == 400)
                {
                    StringBuilder sb = new StringBuilder();

                    foreach(var dicKey in responseService.Errors)
                    {
                        foreach(var message in dicKey.Value)
                        {
                            sb.AppendLine(message);
                        }
                    }

                    TxtMessages.Text = sb.ToString();
                }
                else
                {
                    await DisplayAlert("Erro!", "Oops! Ocorreu um erro inesperado! Tente novamente mais tarde.", "OK");
                }

            }
            await Navigation.PopAllPopupAsync();
        }
    }
}