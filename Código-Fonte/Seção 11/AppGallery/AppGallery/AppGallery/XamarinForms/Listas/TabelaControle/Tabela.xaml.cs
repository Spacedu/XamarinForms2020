using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas.TabelaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tabela : ContentPage
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void TextCell_Tapped(object sender, EventArgs e)
        {
            ((TextCell)sender).Text += "(Clicado!)";
        }
    }
}