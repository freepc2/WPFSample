namespace WPFSample.Command
{
    using System;
    using System.Windows.Input;

    public class MainCommand : ICommand
    {
        Func<object, bool> canExecute;
        Action<object> executeAction;

        //생성자
        public MainCommand(Action<object> executeAction) : this(executeAction, null)
        {

        }
        public MainCommand(Action<object> executeAction, Func<object, bool> canExecute)
        {
            this.executeAction = executeAction ??
                throw new ArgumentNullException("Execute Action was null for");
            this.canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


        /*
         * CanExecute 메소드는 
         * 1. 명령을 사용하거나 
         * 2. 사용 불가능하게 할때 사용되는 함수
         * WPF에 의해서 호출됨, 예제와 같이 사용자 정의 명령의 경우 
         * CanExecute메소드가 알아서 호출되지 않으므로
         * CanExecuteChanged 이벤트를 CommandManager의 RequerySuggested 이벤트와 열결하면 된다.
         */
        public bool CanExecute(object parameter)
        {
            // 비활성화 조건
            //if (parameter?.ToString().Length == 0) return false;
            // canExecute는 Func 델리게이트이고 NULL로 넘어온다.
            // 그러므로 result는 true가 리턴된다.
            bool result = this.canExecute == null ? true : this.canExecute.Invoke(parameter);
            return result;
        }

        public void Execute(object parameter)
        {
            this.executeAction.Invoke(parameter);
        }


    }
}
