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
using Plugin.CurrentActivity;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(AppGallery.Droid.Effects.StatusBarEffect), "StatusBarEffect")]
namespace AppGallery.Droid.Effects
{    
    public class StatusBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var statusBarEffect = (AppGallery.Resources.Effetcs.StatusBarEffect)Element.Effects.FirstOrDefault(e => e is AppGallery.Resources.Effetcs.StatusBarEffect);

            if (statusBarEffect != null)
            {
                var backgroundColor = statusBarEffect.BackgroundColor.ToAndroid();
                Window currentWindow = GetCurrentWindow();
                currentWindow.SetStatusBarColor(backgroundColor);
            }
        }

        protected override void OnDetached()
        {

        }

        Window GetCurrentWindow()
        {
            var window = CrossCurrentActivity.Current.Activity.Window;

            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);

            return window;
        }
    }
}