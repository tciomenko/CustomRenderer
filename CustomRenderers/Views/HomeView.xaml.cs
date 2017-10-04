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



		}
        void Handle_Refreshing(object sender, System.EventArgs e)
        {

                //listView.IsRefreshing = true;
                //listView.IsRefreshing = false;
        }


    }
}
