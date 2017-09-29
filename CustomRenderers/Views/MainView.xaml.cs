using System;
using System.Collections.Generic;
using CustomRenderers.Models;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class MainView : MasterDetailPage
    {
        public NavigationView navigationView;
        public MainView()
        {
            
            InitializeComponent();
            navigationView = new NavigationView();

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomeView)));

            IsPresented = false;
            Master = navigationView;
            navigationView.ListView.ItemSelected+= OnItemSelected;
            navigationView.TappedOrClickEvent += Presented;
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
				navigationView.ListView.SelectedItem = null;
				IsPresented = false;
			}
        }

    }
}
