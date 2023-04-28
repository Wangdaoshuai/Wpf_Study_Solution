﻿using System;
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

namespace Wpf_Study
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num1 = 200;
            int num2 = 300;
            int total = num1 + num2;
            txtTotal.Text = total.ToString();
            txtTotal.Visibility = Visibility.Visible;
         
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            txtTotal.Text = "你的鼠标进入Button范围";
            txtTotal.Visibility = Visibility.Visible;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            txtTotal.Text = "你的鼠标移出Button范围";
            txtTotal.Visibility = Visibility.Visible;
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {

        }
    }
}
