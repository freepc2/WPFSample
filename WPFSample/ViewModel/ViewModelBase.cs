
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFSample.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
         //   PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
