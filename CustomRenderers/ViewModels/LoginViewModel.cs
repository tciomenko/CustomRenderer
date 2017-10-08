using System;
using System.ComponentModel;
using CustomRenderers.Models;

namespace CustomRenderers.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private LoginModel login;
        public LoginViewModel()
        {
            login = new LoginModel();
        }
        public string Login{
            get { return login.Login; }
            set { login.Login = value;
                OnPropertyChanged("Login");
          }
        }

        public string Password
        {
            get { return login.Password; }
            set
            {
                login.Password = value;
                OnPropertyChanged("Password");
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if(PropertyChanged!=null){
                PropertyChanged(this,new PropertyChangedEventArgs(propName));
            }
        }
    }
}
