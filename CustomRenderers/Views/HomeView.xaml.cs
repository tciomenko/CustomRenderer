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
        
        private FriendListViewModel friendList;


        public HomeView()
		{
			InitializeComponent();
            friendList = new FriendListViewModel();
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

        void Handle_Refreshing(object sender, System.EventArgs e)
        {

                //listView.IsRefreshing = true;
                //listView.IsRefreshing = false;
        }


    }
}
