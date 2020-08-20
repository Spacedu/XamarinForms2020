using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.BarraDeProgressoControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarraDeProgresso : ContentPage
    {
        double valorProgressBar = 0.0;
        public BarraDeProgresso()
        {
            InitializeComponent();
        }

        private void ButtonProcessar(object sender, EventArgs e)
        {
            valorProgressBar += 0.1;
            PBBarraDeProgresso.ProgressTo(valorProgressBar, 500, Easing.BounceOut);
        }
    }
}