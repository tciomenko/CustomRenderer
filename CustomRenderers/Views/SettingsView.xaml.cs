using System;
using System.Collections.Generic;
using CustomRenderers.Models;
using CustomRenderers.ViewModels;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class SettingsView : ContentPage
    {
        public SettingsViewModel settingsViewModel;
        public SettingsView()
        {
            
            InitializeComponent();
            settingsViewModel = new SettingsViewModel();
            this.BindingContext = settingsViewModel;
            
        }

    }
}
