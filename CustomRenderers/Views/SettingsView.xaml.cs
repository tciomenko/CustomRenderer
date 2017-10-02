using System;
using System.Collections.Generic;
using CustomRenderers.Models;

using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class SettingsView : ContentPage
    {
        public ListView SettingList { get { return settingList; } }
        public SettingsView()
        {
            
            InitializeComponent();
            NavigationPage.SetTitleIcon(this, "images1.jpg");
            var settingItems=new List<SettingsModel> ();

            settingItems.Add(new SettingsModel(){
                On=true,
                Text="Sound"
            });
			settingItems.Add(new SettingsModel()
			{
				On = false,
				Text = "Notification"
			});
            settingList.ItemsSource = settingItems;
                

        }

    }
}
