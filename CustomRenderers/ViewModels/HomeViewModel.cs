using System;
using System.ComponentModel;
using System.Collections.Generic;
using CustomRenderers.Models;
using CustomRenderers.Views;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;

namespace CustomRenderers.ViewModels
{
    public class HomeViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy = false;
        HomeModel homeModel = new HomeModel();
        public List<MyCellModel> masterPageItems = new List<MyCellModel>();

       
        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;
                    MasterPageItems.Clear();
                    await SetMasterPageItem();
                    IsBusy = false;
                });
            }
        }


        public async Task SetMasterPageItem(){
            for (var i = 0; i < 5;i++)
            masterPageItems.Add(new MyCellModel
            {
                Name = "Юля",
                ImageFileName = "circle.png",
                EventFriends = "Прогулка",
                Time = "8-10pm",
                TargetType = typeof(HomeView)
            });


        }
        public List<MyCellModel> MasterPageItems
        {
            get
            {
                return masterPageItems;
            }
            set
            {
                masterPageItems = value;
                OnPropertyChanged(nameof(MasterPageItems));

            }
        }

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged(nameof(IsBusy));

            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


    }
}
