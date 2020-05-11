using MvvmTutorial.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using System.Windows.Input.Manipulations;

namespace MvvmTutorial.Commands
{
    public class ActionCommand : ICommand
    {
        Action _action;
        public ActionCommand(Action action) => _action = action;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action.Invoke();
        }
    }
}
