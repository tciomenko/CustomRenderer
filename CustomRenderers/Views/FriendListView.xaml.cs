using System;
using System.Collections.Generic;
using CustomRenderers.ViewModels;
using Xamarin.Forms;

namespace CustomRenderers.Views
{

    public partial class FriendListView : ContentPage
    {
        public FriendListViewModel FriendList{get;set;}
        public FriendListView()
        {
            InitializeComponent();

            FriendList = new FriendListViewModel();
            this.BindingContext = FriendList;
        }
    }
}
