using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ListaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();

            Lista01.ItemsSource = GetMarcasESeusModelos();
        }

        private List<Marca> GetMarcasESeusModelos()
        {
            Marca fiat = new Marca()
            {
                new Modelo { Nome = "Mobi", Motor = "1.0Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac rutrum nisi, ut venenatis purus. Nullam vitae malesuada lorem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac rutrum nisi, ut venenatis purus. Nullam vitae malesuada lorem. " },
                new Modelo { Nome = "Uno", Motor = "1.0" },
                new Modelo { Nome = "Argo", Motor = "1.4" },
                new Modelo { Nome = "Cronos", Motor = "1.4" },
                new Modelo { Nome = "Toro", Motor = "2.0" },
            };
            fiat.Nome = "FIAT";

            Marca chevrolet = new Marca()
            {
                new Modelo { Nome = "Onix", Motor = "1.0T" },
                new Modelo { Nome = "Onix Plus", Motor = "1.2T" },
                new Modelo { Nome = "Cruze", Motor= "2.0T" },
                new Modelo { Nome = "Cruze Sport6", Motor= "2.0T" },
                new Modelo { Nome = "Spin", Motor= "1.2T" },
                new Modelo { Nome = "Tracker", Motor= "1.2T" },
                new Modelo { Nome = "Equinox", Motor= "2.0T" },
                new Modelo { Nome = "TrailBlazer", Motor= "2.0T" },
            };
            chevrolet.Nome = "CHEVROLET";

            return new List<Marca>() { fiat, chevrolet };
        }

        private void Lista01_Refreshing(object sender, EventArgs e)
        {
            Marca ford = new Marca()
            {
                new Modelo { Nome = "Ka", Motor = "1.5" },
                new Modelo { Nome = "Ka sedan", Motor = "1.5" },
                new Modelo { Nome = "Fusion", Motor= "2.5" },
                new Modelo { Nome = "Ecosport", Motor= "2.0" },
                new Modelo { Nome = "Novo Edget ST", Motor= "2.0T" },
                new Modelo { Nome = "Ranger", Motor= "2.0T" },
                new Modelo { Nome = "Mustang", Motor= "3.0T" },
            };
            ford.Nome = "FORD";

            var lista = GetMarcasESeusModelos();
            lista.Insert(0, ford);

            Lista01.ItemsSource = lista;

            /*
            Lista01.IsRefreshing = false;
            */
            Lista01.EndRefresh();
        }

        private void MaisDetalhes(object sender, EventArgs e)
        {
            var modelo = ((Modelo)((MenuItem)sender).CommandParameter);
            DisplayAlert("+Detalhes", "Mais detalhes sobre o item: " + modelo.Nome + " - " + modelo.Motor, "OK");
        }

        private void Lista01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            LblSelected.Text = $"Selecionado: {((Modelo)e.SelectedItem).Nome} - Data: {DateTime.Now}";
        }

        private void Lista01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            LblTapped.Text = $"Tocado: {((Modelo)e.Item).Nome} - Data: {DateTime.Now}";
        }

        private void Lista01_Scrolled(object sender, ScrolledEventArgs e)
        {
            LblScrolled.Text = $"Scroll: {e.ScrollY}";
        }
    }
}