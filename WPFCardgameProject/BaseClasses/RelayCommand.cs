using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WPFCardgameProject.BaseClasses
{
    public class RelayCommand : ICommand
    {
        Action<object> _executeMethod;
        Func<object, bool> _canexecuteMethod;
        public RelayCommand(Action<object> executeMethod, Func<object, bool> canexecuteMethod)
        {
            _executeMethod = executeMethod;
            _canexecuteMethod = canexecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            if (_canexecuteMethod != null)
            {
                return _canexecuteMethod(parameter);
            }
            else
            {
                return false;
            }
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public void Execute(object parameter)
        {
            _executeMethod(parameter);
        }
    }
}

// Sourced from: C# corner
// https://www.c-sharpcorner.com/article/explaing-icommand-in-mvvm-wpf/