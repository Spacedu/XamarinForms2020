using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.DeslizanteControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Deslizante : ContentPage
    {
        public Deslizante()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            ValueChanged.Text = "Valor antigo: " + e.OldValue + " - Valor novo: " + e.NewValue;
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {
            DragStarted.Text = "Iniciou o arrasto!";
        }

        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            DragCompleted.Text = "Terminou de arrastar";
        }

        private void Slider_ValueChanged_Step(object sender, ValueChangedEventArgs e)
        {
            int passos = 5;
            double novoPasso = Math.Round(e.NewValue / passos);
            ((Slider)sender).Value = novoPasso * passos;
            ValueChangedStep.Text = ((Slider)sender).Value.ToString();
        }
    }
}