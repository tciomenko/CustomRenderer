using System;
using System.Collections.Generic;
using XamForms.Controls;
using CustomRenderers.Models;
using CustomRenderers.ViewModels;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace CustomRenderers.Views
{
    public partial class HomeView : ContentPage
    {
        
        private HomeViewModel homeViewModel;


        public HomeView()
		{
			InitializeComponent();
            homeViewModel = new HomeViewModel();
            homeViewModel.SetMasterPageItem();
            this.BindingContext = homeViewModel;

		}

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            
            Navigation.PushModalAsync(new UserImageView(homeViewModel.UserImage), true);
        }

        void Add_Clicked(object sender, System.EventArgs e)
        {
            
        }
        void Edit_Clicked(object sender, System.EventArgs e)
        {

        }
        void Delite_Clicked(object sender, System.EventArgs e)
        {

        }

    }
}
