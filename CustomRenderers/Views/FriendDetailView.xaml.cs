using System;
using System.Collections.Generic;
using CustomRenderers.ViewModels;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class FriendDetailView : ContentPage
    {
        public FriendDetailViewModel friendDetailViewModel;
        public FriendDetailView()
        {
            InitializeComponent();
            friendDetailViewModel = new FriendDetailViewModel();
            this.BindingContext = friendDetailViewModel;
        }

    }
}
