﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Creditos : ContentPage
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void AbrirNavegador(object sender, EventArgs e)
        {
            var eventArgs = (TappedEventArgs)e;
            var url = eventArgs.Parameter as string;

            Launcher.OpenAsync(new Uri(url));
        }
    }
}