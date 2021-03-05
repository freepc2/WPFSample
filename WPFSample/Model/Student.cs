using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.Model
{
    public class Student : ViewModel.ViewModelBase
    {
        private string _Name;
        private float _Average;

        public string Name
        {
            get => _Name;
            set => Set(ref _Name, value);
        }
        public float Average
        {
            get => _Average;
            set => Set(ref _Average, value);
        }

        public Student(string _Name, float _Average)
        {
            Name = _Name;
            Average = _Average;
        }

    }
}
