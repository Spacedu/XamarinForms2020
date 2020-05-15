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
    public partial class Conteudo03 : ContentPage
    {
        public Conteudo03()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void VoltarParaPaginaAnterior(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void VoltarParaOInicio(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void InserirPaginaPilha(object sender, EventArgs e)
        {
            /*
            Navigation.InsertPageBefore(
                new Conteudo01(),
                this
            );
            */
            
            Navigation.InsertPageBefore(
                new PaginaInserida(),
                Navigation.NavigationStack[0]
            );

        }

        private void RemoverPaginaPilha(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }
    }
}