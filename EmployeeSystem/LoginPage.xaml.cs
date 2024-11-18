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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public EmployeeSystemEntities7 ES = new EmployeeSystemEntities7();
        public UsersEmployee usersEmployee;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            string Manager = "Admin";
            string Pass = "1234";
            var See = ES.UsersEmployees.FirstOrDefault(f => f.UsersEmployee_Name == UserTXT.Text && f.UsersEmployee_Pass == PassUsr.Password);
            if (See != usersEmployee)
            {
                MessageBox.Show("Login Success, Welcome To Employess");
                EmployeesTask employeesTask = new EmployeesTask();
                employeesTask.Show();
                this.Close();
            }
            else if (UserTXT.Text == Manager && PassUsr.Password == Pass)
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
