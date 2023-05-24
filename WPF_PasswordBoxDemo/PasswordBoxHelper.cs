using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF_PasswordBoxDemo
{
    public class PasswordBoxHelper
    {


        public static string GetPwb(DependencyObject obj)
        {
            return (string)obj.GetValue(PwbProperty);
        }

        public static void SetPwb(DependencyObject obj, string value)
        {
            obj.SetValue(PwbProperty, value);
        }

        // Using a DependencyProperty as the backing store for Pwb.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PwbProperty =
            DependencyProperty.RegisterAttached("Pwb", typeof(string), typeof(PasswordBoxHelper),new PropertyMetadata(string.Empty,OnPwbPropertyChanged));

        private static void OnPwbPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pwbbox = d as PasswordBox;
            if(pwbbox == null)
            {
                return;
            }

            pwbbox.Password = (string)e.NewValue;
        }

        public static bool GetIsEnablePasswordPropertyChanged(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsEnablePasswordPropertyChangedProperty);
        }

        public static void SetIsEnablePasswordPropertyChanged(DependencyObject obj, bool value)
        {
            obj.SetValue(IsEnablePasswordPropertyChangedProperty, value);
        }

        // Using a DependencyProperty as the backing store for IsEnablePasswordPropertyChanged.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsEnablePasswordPropertyChangedProperty =
            DependencyProperty.RegisterAttached("IsEnablePasswordPropertyChanged", typeof(bool), typeof(PasswordBoxHelper), new PropertyMetadata(false,OnPasswordPropertyChanged));

        private static void OnPasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox pwbbox = d as PasswordBox;
            if (pwbbox == null)
            {
                return;
            }
            if ((bool)e.NewValue)
            {
                pwbbox.PasswordChanged += MyPasswordPropertyChanged;
            }
            else
            {
                pwbbox.PasswordChanged -= MyPasswordPropertyChanged;
            }
        }

        private static void MyPasswordPropertyChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox box =(PasswordBox)sender;
            SetPwb(box, box.Password);
        }
    }
}
