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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EmployeeSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EmployeeSystemEntities7 employeeSystemEntities = new EmployeeSystemEntities7();
        public UsersEmployee usersEmployee;
        public UsersManager usersManager;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            string Manager = "Admin";
            string Pass = "1234";
            var See = employeeSystemEntities.UsersEmployees.FirstOrDefault(f => f.UsersEmployee_Name == UserTXTMain.Text && f.UsersEmployee_Pass == PassUsrMain.Password);
            if (See != usersEmployee)
            {
                MessageBox.Show("Login Success, Welcome To Employess");
                EmployeesTask employeesTask = new EmployeesTask();
                employeesTask.Show();
                this.Close();
            }
            else if (UserTXTMain.Text == Manager && PassUsrMain.Password == Pass)
            {
                MessageBox.Show("Login Success, Welcome To Manager");
                ManagingWin EM = new ManagingWin();
                EM.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Data!");
            }
        }
    }
}
