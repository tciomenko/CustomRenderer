﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using CustomRenderers.Models;
using CustomRenderers.Views;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;

namespace CustomRenderers.ViewModels
{
    public class FriendListViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy = false;

        public List<MyCellModel> masterPageItems = new List<MyCellModel>();

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsBusy = true;
                    
                    await SetMasterPageItem();
                    IsBusy = false;
                });
            }
        }


        public async Task SetMasterPageItem(){
            for (var i = 0; i < 5;i++)
            masterPageItems.Add(new MyCellModel
            {
                Name = "Home",
                ImageFilename = "circle.png",
                EventFriends = "Event",
                Time = "8-10pm",
                TargetType = typeof(HomeView)
            });


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
                OnPropertyChanged("IsBusy");

            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }


    }
}