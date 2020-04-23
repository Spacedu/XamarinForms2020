using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.BotaoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Botao : ContentPage
    {
        public Botao()
        {
            InitializeComponent();
        }

        private void Pressionado(object sender, EventArgs e)
        {
            LblPressionado.Text = "Pressionado!!!";
        }

        private void Liberado(object sender, EventArgs e)
        {
            LblLiberado.Text = "Liberado!!!";
        }

        private void Clicado(object sender, EventArgs e)
        {
            LblClicado.Text = "Clicado!!!";
        }
    }
}