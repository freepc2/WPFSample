using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WPFSample.ViewModel
{
    public interface ITimer
    {
        TimeSpan Interval { get; set; }
        bool IsEnabled { get; set; }
        void Start();
        void Stop();
        event EventHandler Tick;
    }
    public interface ITimerFactory
    {
        ITimer CreateTimer();
    }

    public class Timer : ITimer
    {
        private readonly DispatcherTimer internalTimer;

        public Timer()
        {
            internalTimer = new DispatcherTimer(DispatcherPriority.SystemIdle);
        }

        public bool IsEnabled
        {
            get => internalTimer.IsEnabled;
            set => internalTimer.IsEnabled = value;
        }
        public TimeSpan Interval
        {
            get => internalTimer.Interval;
            set => internalTimer.Interval = value;
        }

        public void Start() => internalTimer.Start();
        public void Stop() => internalTimer.Stop();

        public event EventHandler Tick
        {
            add => internalTimer.Tick += value;
            remove => internalTimer.Tick -= value;
        }
    }

    public class TimerFactory: ITimerFactory
    {
        public ITimer CreateTimer() => new Timer();
    }

}
