using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Classes.CentroMensagem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina02 : ContentPage
    {
        public Pagina02()
        {
            InitializeComponent();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            var nome = TxtNome.Text;
            var pessoa = new Pessoa() { Nome = nome };

            MessagingCenter.Send<Pagina02, Pessoa>(this, "CadastroPessoa", pessoa);
        }
    }
}