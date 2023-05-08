using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WPF_LoginUI_MVVM
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //LoginModel loginModel;
        //LoginViewModel loginVm;
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new LoginViewModel(this);
           // loginVm = new LoginViewModel(this);
           // this.DataContext = loginVm;
            /*
            loginModel = new LoginModel();
            this.DataContext = loginModel;
            */
        }

        /*
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // string userName = txtUserName.Text;
            //string password = txtPassword.Text;
            if (loginVm.UserName == "wpf" && loginVm.Password == "666")
            {
                //弹出新的界面
                Test index = new Test();
                index.Show();

                this.Hide();
            }
            else
            {
                //弹出警告框
                MessageBox.Show("输入的用户名或密码不正确");
                //清空文本框
                loginVm.UserName = "";
                loginVm.Password = "";
                //为了触发set重新赋值，否则界面不清空输入
               // loginVm.LoginM = loginVm.LoginM;
            }

        }*/
    }

    
    /*
    public class LoginModel : INotifyPropertyChanged
    {
        //绑定的变量具备通知功能，需要INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                _UserName = value;
                RaisePropertyChanged("UserName");
            }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                RaisePropertyChanged("Password");
            }
        }
    }
    */
}