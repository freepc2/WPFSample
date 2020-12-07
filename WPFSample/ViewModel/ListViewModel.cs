using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.ViewModel
{
    public class ListViewModel : ViewModelBase
    {
        private LINQ _LINQ;

        public LINQ LINQ
        {
            get => _LINQ;
            set => Set(ref _LINQ, value);
        }
        public ListViewModel()
        {
            LINQ = new LINQ();
        }
    }
}
