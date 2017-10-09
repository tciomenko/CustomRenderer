using System;
using CustomRenderers.Views;
using UIKit;
using Xamarin.Forms;

namespace CustomRenderers.iOS.Renderers
{
    public class ButtoniOSCircle:UIButton,INativeElementView
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
