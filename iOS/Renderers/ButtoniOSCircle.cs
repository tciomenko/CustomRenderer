using System;
using CustomRenderers.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace CustomRenderers.iOS.Renderers
{
    public class ButtoniOSCircle:ViewRenderer<ButtonCircle, UIButton>,INativeElementView
    {
        ButtonCircle buttonCircle;
        public ButtoniOSCircle(ButtonCircle button)
        {
            buttonCircle = button;
            buttonCircle.BorderRadius = 30;

        }

        public Element Element => buttonCircle;
        
    }
}
