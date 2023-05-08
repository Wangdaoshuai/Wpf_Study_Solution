using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI_MVVM
{
    internal class LoginViewModel:INotifyPropertyChanged
    {
        private MainWindow _main;
        public LoginViewModel(MainWindow main)
        {
            _main = main;
            
        }
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
        /// <summary>
        /// 登录方法
        /// </summary>
        void LoginFunc()
        {
            if (UserName == "wpf" && Password == "666")
            {
                //弹出新的界面
                Test index = new Test();
                index.Show();

                //this.Hide();
                _main.Hide();
            }
            else
            {
                //弹出警告框
                MessageBox.Show("输入的用户名或密码不正确");
                //清空文本框
                UserName = "";
                Password = "";
                //为了触发set重新赋值，否则界面不清空输入
                // loginVm.LoginM = loginVm.LoginM;
            }
        }

        bool CanLoginExecute()
        {
            return true;
        }
        //命令  可以绑定到登录按钮上
        public ICommand LoginAction
        {
            get
            {
                return new RelayCommond(LoginFunc, CanLoginExecute);
            }
        }

    }
}
