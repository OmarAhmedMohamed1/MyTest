using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeSystem
{
    /// <summary>
    /// Interaction logic for EmployeesTask.xaml
    /// </summary>
    public partial class EmployeesTask : Window
    {
        public EmployeeSystemEntities7 employeeSystemEntities1 = new EmployeeSystemEntities7();
        public Task task;
        public EmployeesTask()
        {
            InitializeComponent();
            NewLoad();
            load();            
        }
        public void load()
        {
            string e = "completed";
            if (StatusTxt.Text != e)
            {
                DataInfo.ItemsSource = employeeSystemEntities1.Tasks.ToList();
            }

           
        }
        private void DataInfo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            task = (Task)DataInfo.SelectedItem;
           IDtask.Text = task.Task_ID.ToString();
            StatusTxt.Text = task.Task_Stat;
        }
        private void DataInfo_Method(object sender, SelectionChangedEventArgs e)
        {
            task = (Task)DataInfo.SelectedItem;
            IDtask.Text = task.Task_ID.ToString();
            StatusTxt.Text = task.Task_Stat;
        }
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (DataInfoDone.SelectedItem is Task JJ)
            {
                JJ.Task_Stat = StatusTxt.Text;
                employeeSystemEntities1.SaveChanges();
                load();
                NewLoad();
            }
        }
        public void NewLoad()
        {

                DataInfoDone.ItemsSource = employeeSystemEntities1.Tasks.ToList();
                
        }
        private void DataInfo_nEW(object sender, SelectionChangedEventArgs e)
        {
            task = (Task)DataInfoDone.SelectedItem;
            IDtask.Text = task.Task_ID.ToString();
            StatusTxt.Text = task.Task_Stat;

        }
        private void StatDrag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StatDrag.ItemsSource = task.Task_Disc.ToList();
            task = (Task)StatDrag.ItemsSource;
        }

        private void StatusTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
