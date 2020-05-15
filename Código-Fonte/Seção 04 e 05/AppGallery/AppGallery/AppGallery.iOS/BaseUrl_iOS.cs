using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppGallery.XamarinForms.Controles.NavegadorControle;
using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(AppGallery.iOS.BaseUrl_iOS))]
namespace AppGallery.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}