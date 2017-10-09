using System;
using CustomRenderers.iOS.Renderers;
using CustomRenderers.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ButtonCircle), typeof(ButtoniOSCircleRenderer))]
namespace CustomRenderers.iOS.Renderers
{
    public class ButtoniOSCircleRenderer:ButtonRenderer
    {
        ButtonCircle btn;
        


    }
}
