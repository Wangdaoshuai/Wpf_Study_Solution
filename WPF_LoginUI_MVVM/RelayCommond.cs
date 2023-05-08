using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

//写法固定 为了让buttonclick方法实现MVVM
namespace WPF_LoginUI_MVVM
{
    public class RelayCommond:ICommand
    {
        //命令是否能够执行
        readonly Func<bool> _canExecute;
        //命令需要执行的方法
        readonly Action _execute;

        //ctor + Tab键
        public RelayCommond(Action action,Func<bool> canexecute)
        {
            _execute = action;
            _canExecute = canexecute;

        }
        public bool CanExecute(object parameter)
        {
            if(_canExecute != null)
            {
                return true;
            }
            return  _canExecute();
        }
        public void Execute(object parameter)
        {
           _execute();
        }
        public event EventHandler CanExecuteChanged
        {
            add {
                if(_canExecute != null)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
                if (_canExecute != null)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

    }
}
