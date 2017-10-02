using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();

        }

        void SignUpPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (login != null && pass != null)
            if(login.Text!=""&&pass.Text!=""){
                signIn.IsEnabled = true;
            }
            else{
                    signIn.IsEnabled = false;
            }


        }
        public void SingInClicked(object sender, EventArgs e)
		{
            Navigation.PushModalAsync(new MainView());
        }
    }
}
