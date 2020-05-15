using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.ListaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();

            Lista01.ItemsSource = GetMarcas();
        }

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosFIAT(),
                GetListaCarrosFORD()
            };
        }

        private Marca GetListaCarrosFORD()
        {
            var FORD = new Marca()
            {
                new Carro {
                    Nome = "Ka",
                    Motorizacao = "1.0 - 1.3",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma seu Mobi em um auntêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para seu design único.",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Ka Sedan",
                    Motorizacao = "1.0 - 1.3",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Fusion",
                    Motorizacao = "2.0 - 2.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Ecosport",
                    Motorizacao = "1.8 - 2.0",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Novo Edge",
                    Motorizacao = "2.4 - 3.0",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção elétrica, Ar-condicionado"
                },
                new Carro
                {
                    Nome = "Ranger",
                    Motorizacao = "3.2",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Mustang",
                    Motorizacao = "5.0",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
            };

            FORD.Nome = "FORD";

            return FORD;
        }

        private Marca GetListaCarrosFIAT()
        {
            var FIAT = new Marca()
            {
                new Carro { 
                    Nome = "Mobi", 
                    Motorizacao = "1.0", 
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma seu Mobi em um auntêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para seu design único.",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Uno",
                    Motorizacao = "1.0",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Argo",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Cronos",
                    Motorizacao = "1.0 - 1.4",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Toro",
                    Motorizacao = "1.8, 2.4 e 2.0TD",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção elétrica, Ar-condicionado"
                },
                new Carro
                {
                    Nome = "Grand Siena",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Strada",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro
                {
                    Nome = "Dublò",
                    Motorizacao = "1.0 - 1.8",
                    Descricao = "Um carro da FIAT de qualidade",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
            };

            FIAT.Nome = "FIAT";

            return FIAT;
        }

        private Marca GetListaCarrosRenault()
        {
            var RENAULT = new Marca()
            {
                new Carro {
                    Nome = "Kwid",
                    Motorizacao = "1.0",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma seu Mobi em um auntêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para seu design único.",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Sandero",
                    Motorizacao = "1.0 - 1.6",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma seu Mobi em um auntêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para seu design único.",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                },
                new Carro {
                    Nome = "Logan",
                    Motorizacao = "1.6",
                    Descricao = "Agora você pode dar um toque de aventura para o seu Mobi Way. O Kit Cross transforma seu Mobi em um auntêntico desbravador da vida urbana, com detalhes inconfundíveis que traduzem exclusividade para seu design único.",
                    ItemsDeSerie = "Air-bags, Direção hidráulica"
                }
            };

            RENAULT.Nome = "RENAULT";

            return RENAULT;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var parametro = ((MenuItem)sender).CommandParameter;
            var carro = (Carro) parametro;

            DisplayAlert("Clicou no Visualizar", $"Registro: {carro.Nome}", "OK");
        }

        private void Lista01_Refreshing(object sender, EventArgs e)
        {
            var marcas = new List<Marca>()
            {
                GetListaCarrosRenault()
            };

            Lista01.ItemsSource = marcas;
            Lista01.IsRefreshing = false;            
        }

        private void Lista01_Scrolled(object sender, ScrolledEventArgs e)
        {
            LblScroll.Text = $"X: {e.ScrollX} - Y: {e.ScrollY} ";
        }

        private void MoverParaFordKa(object sender, EventArgs e)
        {
            var marcas = (List<Marca>)Lista01.ItemsSource;
            var FORD = marcas[1];
            var KA = FORD[0];

            Lista01.ScrollTo(KA, ScrollToPosition.Center, true);
        }

        private void Lista01_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Selecionado", "Item selecionado", "OK");
        }

        private void Lista01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Tocado", "Item tocado", "OK");
        }
    }

    public class Carro {
        public string Nome { get; set; }
        public string Motorizacao { get; set; }
        public string Descricao { get; set; }
        public string ItemsDeSerie { get; set; }
    }

    public class Marca : List<Carro> {
        public string Nome { get; set; }
    }

}