using System;
using System.Windows.Input;

namespace WPF_TreeView
{
    //A basic command that runs an action
    //Purpose: to run different functions with 1 command by passing the function into the constructor
    public class RelayCommand : ICommand
    {
        //The event that is executed when the Can execute object
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        //The action to run
        private Action mAction;

        public RelayCommand(Action action) 
        {
            mAction = action;
        }

        //A relay command can always execute
        public bool CanExecute(object parameter)
        {
            return true;
        }
        //Execute the command actions
        public void Execute(object parameter)
        {
            mAction();
        }
    }
}
