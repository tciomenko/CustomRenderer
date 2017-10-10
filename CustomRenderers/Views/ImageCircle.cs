using System;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public class ImageCircle:Image
    {
        
        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create("CornerRadius", typeof(string), typeof(ImageCircle), "");

        public string CornerRadius
        {
            get { return (string)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty ImageNameProperty =
            BindableProperty.Create("ImageName", typeof(string), typeof(ImageCircle), "");

        public string ImageName
        {
            get { return (string)GetValue(ImageNameProperty); }
            set { SetValue(ImageNameProperty, value); }
        }
        
    }
}
