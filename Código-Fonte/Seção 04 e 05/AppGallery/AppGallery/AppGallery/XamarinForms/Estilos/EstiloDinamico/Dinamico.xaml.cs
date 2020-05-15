using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Estilos.EstiloDinamico
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dinamico : ContentPage
    {
        public Dinamico()
        {
            InitializeComponent();
        }

        private void BtnAlterarPrimaryColor(object sender, EventArgs e)
        {
            Resources["PrimaryColor"] = Color.FromHex(LblCorHex.Text);
            Resources["ButtonStyle"] = Resources["ButtonStyleDinamic"];

        }
    }
}