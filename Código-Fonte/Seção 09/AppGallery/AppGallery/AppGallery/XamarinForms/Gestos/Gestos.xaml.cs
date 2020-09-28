using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Gestos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Gestos : ContentPage
    {
        public Gestos()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            LblTap.Text = $"Label Tocada: {DateTime.Now.ToString("mm:ss")}";
        }

        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            LblPan.Text = $"Label ToqueLongo: X: {e.TotalX} - Y: {e.TotalY}";
        }

        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            LblPinch.Text = $"Label Pinch: Original: {e.ScaleOrigin} - Scale: {e.Scale}";
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            LblSwipe.Text = $"Label Swipe: Direction: {e.Direction}";
        }
    }
}