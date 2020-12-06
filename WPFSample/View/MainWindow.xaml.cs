using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WPFSample.ViewModel;

namespace WPFSample.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {

        DispatcherTimer MyTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
        }

        // Messagebox 출력
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel v = this.DataContext as MainViewModel;
            MessageBox.Show(v.LastName + "," + v.FirstName);
        }

        // 이름을 홀길등으로 변경, ViewModel 변경
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainViewModel v = this.DataContext as MainViewModel;
            v.LastName = "홍";
            v.FirstName = "길동";

        }


    }
}
