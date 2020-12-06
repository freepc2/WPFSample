using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {

            // 프로그램 시작시 측정 Thread 불러오기 시작

            // Thread가 시작되었는지 확인 후 프로그램을 동작 구조를 설정한다.
            // 프로그램 시작시 시작되는 화면
            Window window = new Window();
            window.MaxHeight = 600;
            window.MaxWidth = 1024;
            
            // Window 내용을 Page로 변경(1,2번 화면 선택)
            // Page의 생성자에 Thread를 연결해서 보내준다. 
            // 
            window.Content = new View.MainWindow();
            
            // 현재의 메인 윈도우를 설정
            Application.Current.MainWindow = window;
            window.Show();


            /*
             * Graph 만들기 
             * 1. Graph는 Oxyplot으로 만들어져 있으며, View에서는 그래프의 설정 및 상태가 있다.
             * 2. GraphViewModel에서는 그래프의 동작에 필요한 내용들이 저장되어 있다.
             * 3. DATA 입력 사항에 따라서 표시되는 기능이 있다.
             * 4. CheckPoint 및 CheckDotPoint 기능이 있다.
             * 
             * 5. xaml 파일 GraphView
             * 6. class 파일 GraphViewModel, GraphData
             */

            /*
             * DATA 박스의 내용물
             * 1. List<double>
             * 2. KEY[TEMP, EMF...]
             * 3. SampleRate[100,10...]
             * 4. Probe Max, Min
             */ 

            /*
             * LINQ 사용하기
             * 
             */

            LINQ linq = new LINQ();
            var listTest = linq.GetStudentListOfAverage(80);

            foreach(var l in listTest)
            {
                Debug.WriteLine("이름:{0}, 평균:{1}", l.Name, l.Average);
            }
            
        }
    }
}
