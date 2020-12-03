using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // 프로그램 시작시 시작되는 화면
            View.MainWindow window = new View.MainWindow();
            Application.Current.MainWindow = window;
            window.InitializeComponent();
            window.Show();
        }
    }
}
