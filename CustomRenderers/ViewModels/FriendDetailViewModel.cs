using System;
using System.ComponentModel;
using CustomRenderers.Models;

namespace CustomRenderers.ViewModels
{
    public class FriendDetailViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private FriendDetailModel friendDetailModel;

        public FriendDetailViewModel()
        {
            friendDetailModel = new FriendDetailModel();
        }

        public FriendDetailModel FriendDetailModel {
            get 
            {
                return friendDetailModel; 
            }
            set
            { 
                friendDetailModel = value; 
                OnPropertyChanged(nameof(FriendDetailModel));

            }
        }
        void OnPropertyChanged(string propName){
            if (PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


    }
}
