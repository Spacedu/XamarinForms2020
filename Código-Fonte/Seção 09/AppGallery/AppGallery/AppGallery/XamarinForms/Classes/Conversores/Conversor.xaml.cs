using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Classes.Conversores
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conversor : ContentPage
    {
        public Conversor()
        {
            InitializeComponent();

            Lista01.ItemsSource = new List<Veiculo> { 
                new Veiculo { Marca = "FIAT", Modelo = "UNO", Opcionais = "1, 2, 3", Valor = 39900 },
                new Veiculo { Marca = "FORD", Modelo = "KA", Opcionais = "2, 3, 4", Valor = 45900 },
                new Veiculo { Marca = "FORD", Modelo = "Fiesta", Opcionais = "1, 2, 3, 4", Valor = 50900 }
            };
        }
    }

    public class Veiculo {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Opcionais { get; set; }
        public double Valor { get; set; }
    }
}