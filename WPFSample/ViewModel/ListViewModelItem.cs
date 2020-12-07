using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample.ViewModel
{
    class ListViewModelItem :ObservableCollection<Student>
    {
        public ListViewModelItem()
        {
            Add(new Student("김철수", 78.5f));
            Add(new Student("김영희", 91.2f));
            Add(new Student("홍길동", 77.3f));
            Add(new Student("김길수", 80.8f));
            Add(new Student("김진수", 90.8f));
            Add(new Student("아이유", 60.8f));
            Add(new Student("지드래곤", 50.8f));
            Add(new Student("박명수", 20.8f));
        }
    }
}
