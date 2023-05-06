using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI_MVVM
{
    internal class LoginViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private LoginModel _LoginM = new LoginModel();


       

        public string UserName
        {
            get { return _LoginM.UserName; }
            set { _LoginM.UserName = value;
            RaisePropertyChanged("UserName");
            }
        }
        public string Password
        {
            get { return _LoginM.Password; }
            set
            {
                _LoginM.Password = value;
                RaisePropertyChanged("Password");
            }
        }

    }
}
