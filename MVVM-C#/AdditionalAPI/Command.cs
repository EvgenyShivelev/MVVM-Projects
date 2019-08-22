using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.AdditionalAPI
{
    class Command: ICommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;
        public Command(Action<object> action) : this(action, null)
        { }
        public Command(Action<object> action, Func<object, bool> canExect)
        {
            execute = action;
            canExecute = canExect;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute != null)
                return canExecute(parameter);

            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
