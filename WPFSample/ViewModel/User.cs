using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.ViewModel
{
    public class User : ViewModelBase
    {
        private string _firstName;
        public string FirstName 
        { 
            get { return _firstName; } 
            set { _firstName = value; OnPropertyChanged(); }
        }


        private string _lastName;
        public string LastName 
        { 
            get { return _lastName; } 
            set { _lastName = value; OnPropertyChanged(); } 
        }
    }
}
