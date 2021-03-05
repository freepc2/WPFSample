namespace WPFSample.ViewModel
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            //}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public void Set<T>(ref T field, T newValue = default(T), [CallerMemberName] string propertyName = null)
        {
            // 내용물 수정
            if(!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                // 내용물 수정 알림
                OnPropertyChanged(propertyName);
            }
           
        }

    }
}
