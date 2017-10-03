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
        
        public bool isPull = true;
        private FriendListViewModel friendList;


        public HomeView()
		{
			InitializeComponent();
            friendList = new FriendListViewModel();
            friendList.SetMasterPageItem();
            this.BindingContext = this.friendList.masterPageItems;

		}
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            this.friendList.IsBusy = true;

            
            this.friendList.IsBusy = false;
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

        }
    }
}
