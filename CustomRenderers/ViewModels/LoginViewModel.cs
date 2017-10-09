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

        public LoginModel LoginModel
        {
            get { return loginModel; }
            set
            {
                loginModel = value;
                OnPropertyChanged(nameof(LoginModel));
                //this.Login = value.Login;
                //this.Password = value.Password;
            }
        }
        //public string Login{
        //    get {
        //        return login; 
        //    }
        //    set {
        //        login = value;
        //        OnPropertyChanged(nameof(Login));
        //        SetLoginModel();
        //  }
        //}

        //public string Password
        //{
        //    get { return password; }
        //    set
        //    {
        //        password = value;
        //        OnPropertyChanged(nameof(Password));
        //        SetLoginModel();
        //    }
        //}
        //void SetLoginModel(){
        //    LoginModel = new LoginModel() { Login = login, Password = password };
        //}

        protected void OnPropertyChanged(string propName)
        {
            if(PropertyChanged!=null){
                PropertyChanged(this,new PropertyChangedEventArgs(propName));
            }
        }
    }
}
