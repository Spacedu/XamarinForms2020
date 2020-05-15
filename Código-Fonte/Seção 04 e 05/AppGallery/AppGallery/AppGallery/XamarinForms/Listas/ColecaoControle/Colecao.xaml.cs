using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ColecaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Colecao : ContentPage
    {
        private ObservableCollection<Categoria> categorias { get; set; }
        public Colecao()
        {
            InitializeComponent();

            //Colecao01.ItemsSource = new List<FastFood>();
            Colecao01.ItemsSource = GetCategorias();
        }

        private ObservableCollection<Categoria> GetCategorias()
        {
            categorias = new ObservableCollection<Categoria>();

            var sanduiches = new Categoria()
            {
                new FastFood{ Nome = "Subway", QuantidadeDeFranquias = 44834 },
                new FastFood{ Nome = "McDonald’s", QuantidadeDeFranquias = 37000 },
                new FastFood{ Nome = "Burger King", QuantidadeDeFranquias = 15000 },
                new FastFood{ Nome = "Giraffa`s", QuantidadeDeFranquias = 5000 },
            };
            sanduiches.Nome = "Sanduiches";


            var pizzarias = new Categoria()
            {
                new FastFood{ Nome = "Pizza Hut", QuantidadeDeFranquias = 15000 },
                new FastFood{ Nome = "Domino`s", QuantidadeDeFranquias = 15000 },
            };
            pizzarias.Nome = "Pizzarias";


            var variedades = new Categoria()
            {
                new FastFood{ Nome = "Starbucks", QuantidadeDeFranquias = 27000 },
                new FastFood{ Nome = "KFC", QuantidadeDeFranquias = 19000 },
                new FastFood{ Nome = "Baskin-Robbins", QuantidadeDeFranquias = 7500 },
                new FastFood{ Nome = "Taco Bell", QuantidadeDeFranquias = 7000 },
            };
            variedades.Nome = "Variedades";

            categorias.Add(sanduiches);
            categorias.Add(pizzarias);
            categorias.Add(variedades);

            return categorias;
        }

        private void Colecao01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            var restaurantes = new Categoria()
            {
                new FastFood{ Nome = "Marmitex", QuantidadeDeFranquias = 10 },
                new FastFood{ Nome = "Jhon Hamburguers", QuantidadeDeFranquias = 2 },
                new FastFood{ Nome = "Mix", QuantidadeDeFranquias = 2 },
                new FastFood{ Nome = "Marietta", QuantidadeDeFranquias = 2 },
                new FastFood{ Nome = "Churrascaria Brasil", QuantidadeDeFranquias = 2 },
                new FastFood{ Nome = "Churrascaria São Paulo", QuantidadeDeFranquias = 2 },
                new FastFood{ Nome = "Churrascaria Gaucha", QuantidadeDeFranquias = 2 },
                new FastFood{ Nome = "Churrascaria Palmeiras", QuantidadeDeFranquias = 2 },
            };
            restaurantes.Nome = "Restaurantes";

            categorias.Add(restaurantes);

            Colecao01.RemainingItemsThreshold = -1;
        }

        private void Colecao01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (FastFood fastfood in Colecao01.SelectedItems)
            {
                sb.Append(fastfood.Nome + " - ");
            }

            LblSelecao.Text = "Seleção: " + sb.ToString();
        }
    }

    public class FastFood
    {
        public string Nome { get; set; }
        public int QuantidadeDeFranquias { get; set; }
    }

    public class Categoria : List<FastFood>
    {
        public string Nome { get; set; }
    }
}