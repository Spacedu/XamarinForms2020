using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo01 : ContentPage
    {
        public Conteudo01()
        {
            InitializeComponent();
        }

        private void AbrirMenu(object sender, EventArgs e)
        {
            ((FlyoutPage)App.Current.MainPage).IsPresented = true;
        }
    }
}