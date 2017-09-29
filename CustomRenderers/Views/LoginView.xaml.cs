using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

        }

 

        public void SingInClicked(object sender, EventArgs e)
		{
            Navigation.PushModalAsync(new MainView());
        }
    }
}
