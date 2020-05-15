using AppGallery.XamarinForms.Controles.NavegadorControle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(AppGallery.UWP.BaseUrl_UWP))]
namespace AppGallery.UWP
{
    public class BaseUrl_UWP : IBaseUrl
    {
        public string Get()
        {
            return "ms-appx-web:///Site/";
        }
    }
}
