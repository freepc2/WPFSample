using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample
{
   
    //public class LINQ : ViewModel.ViewModelBase
    //{
    //    private List<Student> _DataList;
    //    public List<Student> DataList
    //    {
    //        get => _DataList;
    //        set => Set(ref _DataList, value);
    //    }

    //    public LINQ()
    //    {
    //        _DataList = new List<Student>()
    //        {
    //            new Student("김철수", 78.5f),
    //            new Student("김영희", 91.2f),
    //            new Student("홍길동", 77.3f),
    //            new Student("김길수", 80.8f),
    //            new Student("김진수", 90.8f),
    //            new Student("아이유", 60.8f),
    //            new Student("지드래곤", 50.8f),
    //            new Student("박명수", 20.8f),
    //        };
    //    }        

    //    public IEnumerable<Student> GetStudentListOfAverage(float Average)
    //    {
    //        // 쿼리 식
    //        var queryStudent = from Student in DataList
    //                           orderby Student.Average
    //                           where Student.Average < Average
    //                           select Student;

    //        return queryStudent;
    //    }

    //    public IEnumerable<Student> GetStudentsOrderby()
    //    {
    //        return DataList.OrderBy(x=> x.Average);
    //    }
    //}
}
