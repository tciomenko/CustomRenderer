using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class UserImagePage : ContentPage
    {
        public UserImagePage(string fileImageName)
        {
            InitializeComponent();
            Image.ImageName = fileImageName;

        }

        void Close_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
