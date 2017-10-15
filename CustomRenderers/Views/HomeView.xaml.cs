using System;
using System.Collections.Generic;
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
            var nav = new NavigationPage(new UserImagePage(homeViewModel.UserImage));
            var toolbar = new ToolbarItem("Close", "Close.png", () => { Navigation.PopModalAsync(); }, ToolbarItemOrder.Default);
            nav.HeightRequest = 300;
            nav.WidthRequest = 300;
            nav.ToolbarItems.Add(toolbar);

            Navigation.PushModalAsync(nav);
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
