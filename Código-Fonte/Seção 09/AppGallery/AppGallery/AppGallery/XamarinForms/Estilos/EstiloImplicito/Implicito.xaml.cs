using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Estilos.EstiloImplicito
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Implicito : ContentPage
    {
        public Implicito()
        {
            InitializeComponent();
        }
    }

    public class MeuBotao : Button
    {
        public MeuBotao()
        {
            Text = "Meu botão";
        }
    }
}