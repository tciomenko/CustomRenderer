using System;
using System.Collections.Generic;
using System.ComponentModel;
using CustomRenderers.Models;

namespace CustomRenderers.ViewModels
{
    public class FriendListViewModel:INotifyPropertyChanged
    {
        private List<FriendListModel> friendList;
        public event PropertyChangedEventHandler PropertyChanged;
        public FriendListViewModel()
        {
            FriendList = new List<FriendListModel>();
            for (int i = 0; i < 10; i++)
                FriendList.Add(new FriendListModel() { ImageFileName = "images1.jpg", EventFriends = "Прогулка", Name = "Марина", Time = "9-12" });
        }

        public List<FriendListModel> FriendList { get
            { return friendList; } 

            set {
                friendList = value;
                OnPropertyChanged(nameof(FriendList));
            } }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }



    }
}
