using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Classes.CentroMensagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina01 : ContentPage
    {
        public ObservableCollection<Pessoa> Pessoas { get; set; }
        public Pagina01()
        {
            InitializeComponent();

            Pessoas = new ObservableCollection<Pessoa>()
            {
                new Pessoa() { Nome = "José" },
                new Pessoa() { Nome = "João" }
            };

            Lista01.ItemsSource = Pessoas;

            MessagingCenter.Subscribe<Pagina02, Pessoa>(this, "CadastroPessoa", (sender, pessoa) => {
                Pessoas.Add(pessoa);
            });
        }

        private void BtnCadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina02());
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
    }
}