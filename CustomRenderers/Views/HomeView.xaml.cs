using System;
using System.Collections.Generic;
using XamForms.Controls;
using CustomRenderers.Models;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class HomeView : ContentPage
    {
       
        public ListView ListView { get { return listView; } }
        public HomeView()
		{
			InitializeComponent();

			var masterPageItems = new List<MyCellModel>();

			masterPageItems.Add(new MyCellModel
			{
                
				Name = "Home",
				ImageFilename = "checkmark.png",
                EventFriends="Event",
                Time="8-10pm",
				TargetType = typeof(HomeView)
			});
			masterPageItems.Add(new MyCellModel
			{
				Name = "Home",
				ImageFilename = "checkmark.png",
				EventFriends = "Event",
				Time = "8-10pm",
				TargetType = typeof(HomeView)
			});
			masterPageItems.Add(new MyCellModel
			{
				Name = "Home",
				ImageFilename = "checkmark.png",
				EventFriends = "Event",
				Time = "8-10pm",
				TargetType = typeof(HomeView)
			});
			masterPageItems.Add(new MyCellModel
			{
				Name = "Home",
				ImageFilename = "checkmark.png",
				EventFriends = "Event",
				Time = "8-10pm",
				TargetType = typeof(HomeView)
			});

			listView.ItemsSource = masterPageItems;
		}
            		
		
    }
}
