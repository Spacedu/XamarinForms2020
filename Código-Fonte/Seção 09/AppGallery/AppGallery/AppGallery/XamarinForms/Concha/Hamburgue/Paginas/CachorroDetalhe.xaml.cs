using AppGallery.XamarinForms.Concha.Hamburgue.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Concha.Hamburgue.Paginas
{
    [QueryProperty("AnimalID", "animalId")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CachorroDetalhe : ContentPage
    {
        private string _animalId { get; set; }
        public string AnimalID { set
            {
                _animalId = value;
            }
        }
        public CachorroDetalhe()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            int AnimalId = int.Parse(_animalId);
            Animal cachorro = Cachorro.ListaDeCachorros.First(a=>a.Id == AnimalId);
            BindingContext = cachorro;
        }

        private async void Voltar(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}