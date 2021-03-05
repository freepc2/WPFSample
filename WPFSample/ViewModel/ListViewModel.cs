using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Data;
using System.ComponentModel;
using WPFSample.Model;
using WPFSample.Command;
using System.Windows.Controls;

namespace WPFSample.ViewModel
{
    public class ListViewModel : Students
    {
        // Command
        public ICommand DClick { get; private set; }
        public ICommand DCChange { get; private set; }
        /// <summary>
        /// List화면을 제어하는 용도
        /// </summary>
        public ListCollectionView MyCollectionView { get; set; }
        public ListViewModel()
        {
            DClick = new RelayCommand<Button>(OnChange);
            DCChange = new RelayCommand<StackPanel>(OnDCChange);
        }

        public void OnDCChange(StackPanel sender)
        {
            MyCollectionView = (ListCollectionView)CollectionViewSource.GetDefaultView(sender.DataContext);
        }
        public void OnChange(Button sender)
        {
            switch(sender.Name)
            {
                case "BtnAverage":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("Average", ListSortDirection.Ascending));
                    break;
                case "BtnName":
                    MyCollectionView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                    break;
                default:
                    break;
            }

        }
    }
}
