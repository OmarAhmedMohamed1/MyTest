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
    /// Interaction logic for ManagingWin.xaml
    /// </summary>
    public partial class ManagingWin : Window
    {
        public EmployeeSystemEntities7 LB = new EmployeeSystemEntities7();
        public UsersEmployee usersEmployee;
        public Task task;
        public ManagingWin()
        {
            InitializeComponent();
            Load();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var Fr = new Task
            {
                Task_ID = int.Parse(TaskIDbox.Text),
                Task_Stat = StatBox.Text,
                Task_Title = TitleBox.Text,
                UsersEmployee_Name = EmpName.Text,
                Task_Disc = DiscBox.Text,
            };
            LB.Tasks.Add(Fr);
            LB.SaveChanges();
            Load();
        }
        public void Load()
        {
            DataManig.ItemsSource = LB.Tasks.ToList();


        }
        
        private void DataManig_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void StatusBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StatusBox.SelectedItem = (Task)StatusBox.SelectedItem;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataManig.SelectedItem is Task ML)
            {


                ML.Task_Stat = StatBox.Text;
                ML.Task_Title = TitleBox.Text;
                ML.Task_Disc = DiscBox.Text;
                LB.SaveChanges();
                Load();
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataManig.SelectedItem is Task JJ)
            {
                LB.Tasks.Remove(JJ);
                LB.SaveChanges();
                Load();
            }
        }
        private void DataManig_New(object sender, SelectionChangedEventArgs e)
        {
            if (DataManig.SelectedItem is Task GG)
            {
                task = (Task)DataManig.SelectedItem;
                TaskIDbox.Text = GG.Task_ID.ToString();
                StatBox.Text = GG.Task_Stat;
                TitleBox.Text = GG.Task_Title;
                EmpName.Text = GG.UsersEmployee_Name;
                DiscBox.Text = GG.Task_Disc;

            }
        }

        private void StatBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
