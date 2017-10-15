﻿using System;
using System.Collections.Generic;
using CustomRenderers.Models;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class NavigationView : ContentPage
    {
        public event EventHandler TappedOrClickEvent;

		public ListView ListView { get { return listView; } }
		public void FireClick(object sender, EventArgs e)
		{
			if (this.TappedOrClickEvent != null)
				this.TappedOrClickEvent(this, e);
		}
		public NavigationView()
        {
			InitializeComponent();
			var masterPageItems = new List<NavigationPageItem>();

			masterPageItems.Add(new NavigationPageItem
			{
				Title = "Home",
				IconSource = "Home.png",
                TargetType = typeof(HomeView)
			});
            masterPageItems.Add(new NavigationPageItem
            {
                Title = "Friend",
                IconSource = "Logout.png",
                TargetType = typeof(FriendListView)
            });
            masterPageItems.Add(new NavigationPageItem
            {
                Title = "Images",
                IconSource = "Logout.png",
                TargetType = typeof(ImageCaruselView)
            });

			masterPageItems.Add(new NavigationPageItem
			{
				Title = "Settings",
                IconSource = "Settings.png",
				TargetType = typeof(SettingsView)
			});
			masterPageItems.Add(new NavigationPageItem
			{
				Title = "Log Out",
				IconSource = "Logout.png",
                TargetType = typeof(LoginView)
			});

			listView.ItemsSource = masterPageItems;
        }




    }
}
