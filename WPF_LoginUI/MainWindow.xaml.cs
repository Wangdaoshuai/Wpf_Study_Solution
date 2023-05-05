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

namespace WPF_LoginUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = this;
        }
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

        //绑定变量 默认值333 但是界面修改时变量不能动态变化
        //public string UserName { get; set; } = "333";

        //propfull 按tap键自动弹出下面定义
        //绑定变量界面修改时变量能动态变化
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value;
                RaisePropertyChanged("UserName");
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (UserName == "wpf" && password == "666")
            {
                //弹出新的界面
                Index index = new Index();
                index.Show();

                this.Hide();
            }
            else
            {
                //弹出警告框
                MessageBox.Show("输入的用户名或密码不正确");
                //清空文本框
                UserName = "";
                txtPassword.Text = "";
            }

        }
    }
}
