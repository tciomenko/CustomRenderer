using System;
using System.ComponentModel;
using CustomRenderers.Models;

namespace CustomRenderers.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private LoginModel loginModel;

        public LoginViewModel()
        {
            loginModel = new LoginModel();
        }

        public string Login{
            get { return loginModel.Login; }
            set { loginModel.Login = value;
                OnPropertyChanged("Login");
          }
        }

        public string Password
        {
            get { return loginModel.Password; }
            set
            {
                loginModel.Password = value;
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
