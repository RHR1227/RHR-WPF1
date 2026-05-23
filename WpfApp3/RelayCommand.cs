using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3
{
    internal class RelayCommand:ICommand
    {
        readonly Func<bool> _canExecute;
        readonly Action _execute;

        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute?.Invoke() ?? true;
        }

        // 执行命令时调用
        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
        

        // 通知 WPF 去检查 CanExecute 状态（更新按钮启用/禁用）
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}

