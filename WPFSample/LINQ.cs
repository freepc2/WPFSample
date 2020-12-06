using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample
{
    class Student
    {
        public string Name { get; set; }
        public float Average { get; set; }

        public Student(string _Name, float _Average)
        {
            Name = _Name;
            Average = _Average;
        }

    }
    class LINQ
    {
        List<Student> StudentList = new List<Student>()
        {
            new Student("김철수", 78.5f),
            new Student("김영희", 91.2f),
            new Student("홍길동", 77.3f),
            new Student("김길수", 80.8f),
        };

        public IEnumerable<Student> GetStudentListOfAverage(float Average)
        {
            var queryStudent = from Student in StudentList
                               orderby Student.Average
                               where Student.Average < 80.0
                               select Student;

            return queryStudent;
        }
    }
}
