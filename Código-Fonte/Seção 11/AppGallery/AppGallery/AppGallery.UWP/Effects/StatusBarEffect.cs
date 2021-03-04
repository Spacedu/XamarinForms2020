using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.UI.ViewManagement;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(AppGallery.UWP.Effects.StatusBarEffect), "StatusBarEffect")]
namespace AppGallery.UWP.Effects
{
    public class StatusBarEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var statusBarEffect = (AppGallery.Resources.Effetcs.StatusBarEffect)Element.Effects.FirstOrDefault(e => e is AppGallery.Resources.Effetcs.StatusBarEffect);

            if (statusBarEffect != null)
            {
                var backgroundColor = statusBarEffect.BackgroundColor;

                var alpha = backgroundColor.A * 255;
                var red = backgroundColor.R * 255;
                var green = backgroundColor.G * 255;
                var blue = backgroundColor.B * 255;

                var statusBackgroundColor = Windows.UI.Color.FromArgb((byte)alpha, (byte)red, (byte)green, (byte)blue);

                // Desktop Customization
                if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
                {
                    var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                    if (titleBar != null)
                    {
                        titleBar.BackgroundColor = statusBackgroundColor;
                        titleBar.ButtonBackgroundColor = statusBackgroundColor;
                    }
                }

                // Mobile Customization
                if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
                {
                    var statusBar = StatusBar.GetForCurrentView();
                    if (statusBar != null)
                    {
                        statusBar.BackgroundOpacity = 1;
                        statusBar.BackgroundColor = statusBackgroundColor;
                    }
                }
            }
        }

        protected override void OnDetached()
        {

        }
    }
    }
