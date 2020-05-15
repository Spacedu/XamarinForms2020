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

        private void SwipeDetalhe(object sender, EventArgs e)
        {
            LblDetalhe.Text = $"Acionado Detalhe: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeEditar(object sender, EventArgs e)
        {
            LblEditar.Text = $"Acionado Editar: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeExcluir(object sender, EventArgs e)
        {
            LblExcluir.Text = $"Acionado Excluir: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
            LblStarted.Text = $"Acionado SwipeStarted: {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}";
        }

        private void SwipeChanging(object sender, SwipeChangingEventArgs e)
        {
            LblChanging.Text = $"Acionado SwipeChanging: {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}:{e.Offset}";
        }

        private void SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            LblEnded.Text = $"Acionado SwipeEnded: {DateTime.Now.ToString("HH:mm:ss")} - {e.SwipeDirection}";
        }

        private void SwipeCloseRequested(object sender, EventArgs e)
        {
            LblClose.Text = $"Acionado Close: {DateTime.Now.ToString("HH:mm:ss")}";
        }

        private void CloseSwipeView(object sender, EventArgs e)
        {
            SwipeViewControle.Close();
        }
    }
}