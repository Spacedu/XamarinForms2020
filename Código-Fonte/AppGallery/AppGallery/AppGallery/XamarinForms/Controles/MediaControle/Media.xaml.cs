using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.MediaControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Media : ContentPage
    {
        private bool ContinuaAtualizando = true;
        public Media()
        {
            InitializeComponent();
        }

        private void ButtonPlay(object sender, EventArgs e)
        {
            VideoControle.Play();

            ContinuaAtualizando = true;
            AtualizarVideoPosicao();
        }
        private void AtualizarVideoPosicao()
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
            {
                LblPosicao.Text = VideoControle.Position.ToString(@"mm\:ss");
                SliderPosicaoVideo.Value = VideoControle.Position.Seconds;
                
                return ContinuaAtualizando;
            });
        }

        private void ButtonPause(object sender, EventArgs e)
        {
            VideoControle.Pause();
            ContinuaAtualizando = false;
            AtualizarVideoPosicao();
        }

        private void ButtonStop(object sender, EventArgs e)
        {
            VideoControle.Stop();
            ContinuaAtualizando = false;
            AtualizarVideoPosicao();
        }

        private void SliderVolume(object sender, ValueChangedEventArgs e)
        {
            VideoControle.Volume = e.NewValue;
            LblVolume.Text = $"Volume({e.NewValue})";
        }

        private void VideoControle_MediaOpened(object sender, EventArgs e)
        {
            LblDuracao.Text = VideoControle.Duration.Value.ToString(@"mm\:ss");
            SliderPosicaoVideo.Maximum = VideoControle.Duration.Value.TotalSeconds;
        }
    }
}