using System;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public class ButtonCircle:Button
    {
        public static readonly BindableProperty NameProperty =
            BindableProperty.Create("BackgroundImage", typeof(string), typeof(ButtonCircle), "");

        public string BackgroundImage
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
    }
}
