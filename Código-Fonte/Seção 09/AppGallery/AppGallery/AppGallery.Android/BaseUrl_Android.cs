using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppGallery.XamarinForms.Controles.NavegadorControle;

[assembly: Xamarin.Forms.Dependency(typeof(AppGallery.Droid.BaseUrl_Android))]
namespace AppGallery.Droid
{
    public class BaseUrl_Android : IBaseUrl
    {
        public string Get()
        {
            return "file:///android_asset/";
        }
    }
}