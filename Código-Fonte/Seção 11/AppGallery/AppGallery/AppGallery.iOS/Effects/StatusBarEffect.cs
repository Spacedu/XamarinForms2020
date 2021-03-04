using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(AppGallery.iOS.Effects.StatusBarEffect), "StatusBarEffect")]
namespace AppGallery.iOS.Effects
{
    public class StatusBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Device.BeginInvokeOnMainThread(() => {
                var statusBarEffect = (AppGallery.Resources.Effetcs.StatusBarEffect)Element.Effects.FirstOrDefault(e => e is AppGallery.Resources.Effetcs.StatusBarEffect);

                if (statusBarEffect != null)
                {
                    if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
                    {
                        // If VS has updated to the latest version , you can use StatusBarManager , else use the first line code
                        // UIView statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
                        UIView statusBar = new UIView(UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame);
                        statusBar.BackgroundColor = statusBarEffect.BackgroundColor.ToUIColor();
                        UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
                    }
                    else
                    {
                        UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                        if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                        {
                            statusBar.BackgroundColor = statusBarEffect.BackgroundColor.ToUIColor();
                            UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.BlackOpaque;
                        }
                    }
                }
            });
        }

        protected override void OnDetached()
        {

        }
    }
}