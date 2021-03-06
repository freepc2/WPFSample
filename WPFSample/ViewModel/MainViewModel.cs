﻿namespace WPFSample.ViewModel
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Input;
    using Command;

    public class MainViewModel : User
    {
        /*
         *  UI Timer
         *  Graph, Label이 변경됨을 표시하는 기능을 가지고 있다.
         */
        private readonly ITimerFactory timerFactory;
        private readonly ITimer timer;

        /*  
         *  BackGroundWoker 2종류
         *  Param & History Timer<동작시 제어하며>
         *  Button이 클릭 된 경우 UI Timer가 동작을 멈추며
         *  windows가 제거된 경우 UI Timer가 다시 재개 한다.
         */
        BackgroundWorker _backgroundWorker = new BackgroundWorker();

        public ICommand OnMessageCommand { get; private set; }
        public ICommand OnChangeCommand { get; private set; }
        public ICommand OnListView { get; private set; }
        
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

            OnMessageCommand = new RelayCommand(OnMessage);
            OnChangeCommand = new RelayCommand(OnChange);
            OnListView = new RelayCommand(OnListview);


            // Timer Setting
            this.timerFactory = new TimerFactory();
            this.timer = timerFactory.CreateTimer();
            this.timer.Interval = TimeSpan.FromMilliseconds(1);
            this.timer.Tick += new EventHandler(Timer_Tick);
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time = System.DateTime.Now.ToString("dd-HH-mm-ss.fff");
        }


        public void OnMessage()
        {
            MessageBox.Show(LastName + "," + FirstName);

            this.timer.Start();
        }

        public void OnChange()
        {
            this.timer.Stop();
            (FirstName, LastName) = ("홍","길동");

        }

        public void OnListview()
        {
            this.timer.Stop();
            Window newwindow = new Window();
            newwindow.Content = new View.ListView();
            newwindow.Show();
        }
    }
}
