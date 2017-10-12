using CustomRenderers.Views;
using Xamarin.Forms;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CustomRenderers.Views
{
    public partial class StartView : ContentPage
    {
        
        public StartView()
        {
            InitializeComponent();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Task.Delay(3000).Wait();
            Navigation.PushModalAsync(new LoginView());

        }



    }
}
