using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppGallery.Resources.Effetcs
{
    public class StatusBarEffect : RoutingEffect
    {
        public Color BackgroundColor { get; set; }

        public StatusBarEffect() : base("Xamarin.StatusBarEffect")
        {

        }
    }
}
