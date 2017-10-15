using System;
using System.Collections.Generic;
using CustomRenderers.Models;
using CustomRenderers.ViewModels;
using Xamarin.Forms;

namespace CustomRenderers.Views
{
    public partial class ImageCaruselView : ContentPage
    {
        public CaruselViewModel Carusel;
        public ImageCaruselView()
        {
            InitializeComponent();
            Carusel = new CaruselViewModel();
            this.BindingContext = Carusel;
        }
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as ImageCaruselModel;
            if (monkey == null)
                return;


        }
    }
}
