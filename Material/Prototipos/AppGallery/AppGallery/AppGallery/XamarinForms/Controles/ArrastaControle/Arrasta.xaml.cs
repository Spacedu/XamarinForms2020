using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ArrastaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Arrasta : ContentPage
    {
        public Arrasta()
        {
            InitializeComponent();
        }

        private void SwipeEditar(object sender, EventArgs e)
        {
            LblStatus.Text = "Editar..";
        }

        private void SwipeDetalhe(object sender, EventArgs e)
        {
            LblStatus.Text = "Detalhe..";
        }

        private void SwipeExcluir(object sender, EventArgs e)
        {
            LblStatus.Text = "Excluir..";
        }
    }
}