using System;
using System.Collections.Generic;
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

namespace WPF_PasswordBoxDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }
        //依赖属性，是具备自动通知界面的能力


        public string MyPasswordVM
        {
            get { return (string)GetValue(MyPasswordVMProperty); }
            set { SetValue(MyPasswordVMProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyPasswordVM.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPasswordVMProperty =
            DependencyProperty.Register("MyPasswordVM", typeof(string), typeof(MainWindow));

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPasswordVM = DateTime.Now.ToString("HH:mm:ss.ffff");
        }
    }
}
