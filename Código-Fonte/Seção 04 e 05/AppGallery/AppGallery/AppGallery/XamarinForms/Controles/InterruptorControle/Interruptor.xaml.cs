using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.InterruptorControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Interruptor : ContentPage
    {
        public Interruptor()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            lblInformativo.Text = e.Value ? "Marcado" : "Desmarcado";
        }
    }
}