using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles.ImagemControle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Imagem : ContentPage
    {
        public Imagem()
        {
            InitializeComponent();

            //ResourceID = AppGallery.XamarinForms.Controles.ImagemControle.background.png
            //Imagem01.Source = ImageSource.FromResource("AppGallery.XamarinForms.Controles.ImagemControle.background.png");


            //Download -> System.IO (Stream)
            //Imagem01.Source = ImageSource.FromStream(System.IO.Stream);
        }
    }
}