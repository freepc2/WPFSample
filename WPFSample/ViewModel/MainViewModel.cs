using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFSample.ViewModel
{
    public class MainViewModel :User
    {
        public Command.MainCommand OnMessageCommand { get; set; }
        public Command.MainCommand OnChangeCommand { get; set; }
        public MainViewModel()
        {
            FirstName = "KIL-DONG";
            LastName = "KIM";

            OnMessageCommand = new Command.MainCommand(OnMessage);
            OnChangeCommand = new Command.MainCommand(OnChange);
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
