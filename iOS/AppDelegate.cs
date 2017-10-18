using System;
using System.Collections.Generic;
using System.Linq;
using FFImageLoading.Forms.Touch;
using FFImageLoading.Transformations;
using FFImageLoading.Forms;
using FFImageLoading.Helpers;
using FFImageLoading.Views;
using Foundation;
using UIKit;
using Plugin.MediaManager.Forms.iOS;

namespace CustomRenderers.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {   VideoViewRenderer.Init();
            global::Xamarin.Forms.Forms.Init();
            CachedImageRenderer.Init();

            var ignor = new RoundedTransformation();
            //var ignore = typeof(SvgCachedImage);
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);

        }
        
    }
}
