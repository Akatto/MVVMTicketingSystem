using PracaInżynierska.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PracaInżynierska.MVVM.ViewModel;

namespace PracaInżynierska.Glowny
{
    class LoginCommand : ICommand
    {
        private readonly NavigationState _navigationState;

        public LoginCommand(NavigationState navigationState)
        {
            _navigationState = navigationState;
        }

        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public LoginCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;

        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _navigationState.CurrentViewModel = new GlownaVM();
        }
    }
}
