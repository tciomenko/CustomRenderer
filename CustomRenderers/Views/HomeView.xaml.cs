using System;
using System.Collections.Generic;
using XamForms.Controls;
using CustomRenderers.Models;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace CustomRenderers.Views
{
    public partial class HomeView : ContentPage
    {
        
        public bool isPull = true;
        public ListView ListView { get { return listView; } }
               public HomeView()
		{
            var masterPageItems = new List<MyCellModel>();
			InitializeComponent();

            for (var i = 0; i < 5;i++){
			masterPageItems.Add(new MyCellModel
			{
                
				Name = "Home",
				ImageFilename = "circle.png",
                EventFriends="Event",
                Time="8-10pm",
				TargetType = typeof(HomeView)
			});
			}

			listView.ItemsSource = masterPageItems;
		}
        void Handle_Refreshing(object sender, System.EventArgs e)
        {

        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
