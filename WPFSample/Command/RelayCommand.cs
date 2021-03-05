namespace WPFSample.Command
{
    using System;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute)
            : this(execute, null)
        {

        }
        public RelayCommand(Action execute, Func<bool> canExcute)
        {
            if (execute == null)
                throw new ArgumentNullException("excute");
            _execute = execute;
            _canExecute = canExcute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute = null;
        private readonly Predicate<T> _canExecute = null;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<T> execute)
            : this(execute, (Predicate<T>)null)
        {
        }

        public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            //if (execute == null)
            //    throw new ArgumentNullException("execute");
            this._execute = execute ?? throw new ArgumentException("execute");
            this._canExecute = canExecute;// ?? throw new ArgumentNullException("canExecute");

            //this._execute = new Action<T>(execute);
            //this._canExecute = new Predicate<T>(canExecute);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            var handler = this.CanExecuteChanged;
            handler?.Invoke((object)this, EventArgs.Empty);
        }
    }

}
