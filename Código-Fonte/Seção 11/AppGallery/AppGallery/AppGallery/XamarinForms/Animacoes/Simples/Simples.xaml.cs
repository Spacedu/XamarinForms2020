using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Animacoes.Simples
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Simples : ContentPage
    {
        public Simples()
        {
            InitializeComponent();
        }

        private async void BtnTranslate(object sender, EventArgs e)
        {
            await Box.TranslateTo(100, 50, 500, Easing.Linear);
            await Task.Delay(1000);
            await Box.TranslateTo(0, 0, 1000, Easing.BounceOut);
        }

        private async void BtnRotate(object sender, EventArgs e)
        {
            await Box.RotateTo(90, 1000, Easing.SpringOut);
            await Task.Delay(1000);
            await Box.RotateTo(0, 1000, Easing.CubicOut);
        }

        private async void BtnScale(object sender, EventArgs e)
        {
            await Box.ScaleTo(2, 500, Easing.CubicInOut);
            await Task.Delay(1000);
            await Box.ScaleTo(1, 1000, Easing.Linear);
        }

        private async void BtnOpacity(object sender, EventArgs e)
        {
            await Box.FadeTo(0.3, 500, Easing.Linear);
            await Task.Delay(1000);
            await Box.FadeTo(1, 1000, Easing.Linear);
        }

        private async void BtnAnimacaoCombinada(object sender, EventArgs e)
        {
            await Task.WhenAll(
                Box.TranslateTo(0, 150, 1000, Easing.SpringOut),
                Box.ScaleTo(1.5, 1000, Easing.Linear),
                Box.RotateTo(45, 1000, Easing.BounceOut)
            );

            await Task.Delay(1000);

            await Task.WhenAll(
                Box.TranslateTo(0, 0, 1000, Easing.SpringOut),
                Box.ScaleTo(1, 1000, Easing.Linear),
                Box.RotateTo(0, 1000, Easing.BounceOut)
            );
        }

        private async void BtnAnimacaoPersonalizada(object sender, EventArgs e)
        {
            var animacao = new Animation(v => Box.CornerRadius = v, 5, 100, Easing.Linear);
            animacao.Commit(Box, "CornerAnimation", 300, 1000, Easing.Linear, null, () => false);

            await Task.Delay(3000);

            var animacao2 = new Animation(v => Box.CornerRadius = v, 100, 0, Easing.Linear);
            animacao2.Commit(Box, "CornerAnimation", 300, 1000, Easing.Linear, null, () => false);
        }

        private async void BtnColor(object sender, EventArgs e)
        {
            var colorTo = Color.FromHex(TxtColor.Text);
            await Box.ColorTo(Box.BackgroundColor, colorTo, p => Box.BackgroundColor = p, 5000, Easing.Linear);
        }

        private void BtnCancelar(object sender, EventArgs e)
        {
            Box.AbortAnimation("ColorTo");

            //ViewExtensions.CancelAnimation(Box);
        }
    }

    public static class ViewExtensions
    {
        public static Task<bool> ColorTo(this VisualElement self, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing easing = null)
        {
            Func<double, Color> transform = (t) =>
              Color.FromRgba(fromColor.R + t * (toColor.R - fromColor.R),
                             fromColor.G + t * (toColor.G - fromColor.G),
                             fromColor.B + t * (toColor.B - fromColor.B),
                             fromColor.A + t * (toColor.A - fromColor.A));
            return ColorAnimation(self, "ColorTo", transform, callback, length, easing);
        }

        public static void CancelAnimation(this VisualElement self)
        {
            self.AbortAnimation("ColorTo");
        }

        static Task<bool> ColorAnimation(VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing easing)
        {
            easing = easing ?? Easing.Linear;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            element.Animate<Color>(name, transform, callback, 16, length, easing, (v, c) => taskCompletionSource.SetResult(c));
            return taskCompletionSource.Task;
        }
    }
}