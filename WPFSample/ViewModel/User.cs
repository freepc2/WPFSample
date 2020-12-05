using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.ViewModel
{
    // MainViewModel에서 사용할 DATA들의 모임
    // ViewModelBase 
    public class User : ViewModelBase
    {
        private string _firstName;
        public string FirstName 
        { 
            get { return _firstName; } 
            set { Set(ref _firstName, value); }
        }


        private string _lastName;
        public string LastName 
        { 
            get { return _lastName; } 
            set { Set(ref _lastName, value); } 
        }
    }
}
