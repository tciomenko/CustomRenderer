﻿using System;
using System.Collections.Generic;
using CustomRenderers.Models;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class MainView : MasterDetailPage
    {
        
        public MainView()
        {
            
            InitializeComponent();
            //navigationView = new NavigationView();
            //Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomeView)));
            //IsPresented = false;
            //Master = navigationView;
            NavigationView.ListView.ItemSelected+= OnItemSelected;
            NavigationView.TappedOrClickEvent += Presented;
        }


        public  void Presented(object sender, EventArgs e){
            IsPresented = false;
        }
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
			var item = e.SelectedItem as NavigationPageItem;
			if (item != null)
			{
                
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				NavigationView.ListView.SelectedItem = null;
				IsPresented = false;
			}
        }

    }
}
