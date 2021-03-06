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
    public class HomeViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool isBusy = false;
        HomeModel homeModel = new HomeModel();
        //public List<MyCellModel> masterPageItems = new List<MyCellModel>();
        public HomeViewModel(){
            //SetMasterPageItem();
        }
        public ICommand RefreshCommand
        {
            get
            {
                return new Command(() =>
                {
                    IsBusy = true;
                    //MasterPageItems.Clear();
                    //HomeModelProp.ListCell.Clear();
                    //SetMasterPageItem();
                    IsBusy = false;
                });
            }
        }
        public void SetMasterPageItem(){

            for (var i = 0; i < 10;i++){
                if(i%2==0)
                    HomeModelProp.ListCell.Add(new MyCellModel
                    {
                        Name = "Bill Gates",
                        ImageFileName = "BillGates.jpg",
                        EventFriends = "Кронфиренция",
                        Time = "8-10pm",
                        TargetType = typeof(HomeView)
                    });
                else{
                    HomeModelProp.ListCell.Add(new MyCellModel
                    {
                        Name = "Юлия",
                        ImageFileName = "images1.jpg",
                        EventFriends = "Пробежка111111111",
                        Time = "6-7pm",
                        TargetType = typeof(HomeView)
                    });
                }
            }

            HomeModelProp.BackgroundImage = "images1.jpg";
            HomeModelProp.UserImage = "images1.jpg";


        }
        public HomeModel HomeModelProp
        {
            get
            {
                return homeModel;
            }
            set
            {
                homeModel = value;
                OnPropertyChanged(nameof(HomeModelProp));

            }
        }
        public string UserImage
        {
            get
            {
                return homeModel.UserImage;
            }
            set
            {
                homeModel.UserImage = value;
                OnPropertyChanged(nameof(UserImage));

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
