using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.AtualizaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Atualiza : ContentPage
    {
        public Atualiza()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            LblStatus.Text = $"Atualizado: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";

            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}