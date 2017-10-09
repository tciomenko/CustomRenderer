using System;
using System.Collections.Generic;
using System.ComponentModel;
using CustomRenderers.Models;

namespace CustomRenderers.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private List<SettingsModel> _listSettringsModel;
        public SettingsViewModel()
        {
            _listSettringsModel = new List<SettingsModel>();
            _listSettringsModel.Add(new SettingsModel() 
            {
               On = true,
               Text = "Sound"
             });
            _listSettringsModel.Add(new SettingsModel()
            {
                On = false,
                Text = "Notification"
            });
        }
        public List<SettingsModel> ListSettringsModel { 
            get 
            {
                return _listSettringsModel;
            }
            set
            {
                _listSettringsModel = value;
                OnPropertyChanged(nameof(ListSettringsModel));

            }
        }


        private void OnPropertyChanged(string propName)
        {
            if(PropertyChanged!=null){
                PropertyChanged(this,new PropertyChangedEventArgs(propName));
            }
        }
    }
}
