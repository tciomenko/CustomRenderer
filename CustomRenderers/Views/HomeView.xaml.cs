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
        
        private HomeViewModel friendList;


        public HomeView()
		{
			InitializeComponent();
            friendList = new HomeViewModel();
            friendList.SetMasterPageItem();
            this.BindingContext = friendList;


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



        void ButtonCircle_Clicked(object sender, System.EventArgs e)
        {
            ((ButtonCircle)sender).Opacity = 1;
        }
    }
}
