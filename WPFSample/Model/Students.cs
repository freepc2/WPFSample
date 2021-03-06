﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Data;

namespace WPFSample.Model
{
    public class Students: ObservableCollection<Student>
    {
        public Students()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                // 디자인 모드에서만 표시되는 부분
                Add(new Student("김철수", 78.5f));
                Add(new Student("김영희", 91.2f));
                Add(new Student("홍길동", 77.3f));
                Add(new Student("김길수", 80.8f));
                Add(new Student("김진수", 90.8f));
                Add(new Student("아이유", 60.8f));
                Add(new Student("지드래곤", 50.8f));
                Add(new Student("박명수", 20.8f));
            }
            else
            {
                // 실제 동작시 표시 부분
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
}
