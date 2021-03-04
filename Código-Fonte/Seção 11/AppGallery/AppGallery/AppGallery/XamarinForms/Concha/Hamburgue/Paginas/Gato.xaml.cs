using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Concha.Hamburgue.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gato : ContentPage
    {
        public Gato()
        {
            InitializeComponent();
        }

        private async void AbrirCachorro(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync("../cachorro");
            }
            catch(Exception)
            {
                await DisplayAlert("Página não encontrada!", "Verifique a rota!", "OK");
            }
            
        }
    }
}