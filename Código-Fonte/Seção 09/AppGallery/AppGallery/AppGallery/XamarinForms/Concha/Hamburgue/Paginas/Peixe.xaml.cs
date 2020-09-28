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
    public partial class Peixe : ContentPage
    {
        public Peixe()
        {
            InitializeComponent();
        }

        private async void AbrirGato2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///gato2");
        }
    }
}