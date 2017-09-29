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
				IconSource = "checkmark.png",
                TargetType = typeof(HomeView)
			});
			masterPageItems.Add(new NavigationPageItem
			{
				Title = "Settings",
				IconSource = "checkmark.png",
				TargetType = typeof(SettingsView)
			});
			masterPageItems.Add(new NavigationPageItem
			{
				Title = "Log Out",
				IconSource = "checkmark.png",
                TargetType = typeof(LoginView)
			});

			listView.ItemsSource = masterPageItems;
        }




    }
}
