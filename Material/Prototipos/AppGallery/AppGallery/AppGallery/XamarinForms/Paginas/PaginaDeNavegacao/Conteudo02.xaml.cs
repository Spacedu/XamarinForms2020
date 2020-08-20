using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo02 : ContentPage
    {
        public Conteudo02()
        {
            InitializeComponent();
        }

        private void VoltarParaPaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void AbrirPagina03(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conteudo03());
        }
    }
}