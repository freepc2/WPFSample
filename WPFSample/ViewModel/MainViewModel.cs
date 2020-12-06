namespace WPFSample.ViewModel
{
    using System;
    using System.Diagnostics;
    using System.Windows;

    public class MainViewModel :User
    {
        private readonly ITimerFactory timerFactory;
        private readonly ITimer timer;

        public Command.MainCommand OnMessageCommand { get; set; }
        public Command.MainCommand OnChangeCommand { get; set; }
        private string _Time;
        public string Time 
        {
            get => _Time;
            set => Set(ref _Time, value);
        }
        public MainViewModel()
        {
            FirstName = "KIL-DONG";
            LastName = "KIM";

            OnMessageCommand = new Command.MainCommand(OnMessage);
            OnChangeCommand = new Command.MainCommand(OnChange);


            this.timerFactory = new TimerFactory();
            this.timer = timerFactory.CreateTimer();
            this.timer.Interval = TimeSpan.FromMilliseconds(100);
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time = System.DateTime.Now.ToString("dd-HH-mm-ss.fff");


            Debug.WriteLine(Time);
        }


        public void OnMessage(object param)
        {
            MessageBox.Show(LastName + "," + FirstName);
        }

        public void OnChange(object param)
        {
            (FirstName, LastName) = ("홍","길동");

        }
    }
}
