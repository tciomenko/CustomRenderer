using System;
using System.Collections.Generic;
using System.ComponentModel;
using CustomRenderers.ViewModels;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginViewModel loginViewModel=new LoginViewModel();
        public LoginView()
        {
            InitializeComponent();
            this.BindingContext = loginViewModel;

        }

        void SignUpPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(loginViewModel!=null)
            if (loginViewModel.Login != null && loginViewModel.Password != null)
            if(loginViewModel.Login!=""&&loginViewModel.Password!=""){
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
