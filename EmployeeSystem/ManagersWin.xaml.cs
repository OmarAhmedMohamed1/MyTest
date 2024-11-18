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
    /// Interaction logic for ManagersWin.xaml
    /// </summary>
    public partial class ManagersWin : Window
    {
        public EmployeeSystemEntities7 EP = new EmployeeSystemEntities7();
        public UsersManager usersManager;
        public ManagersWin()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            var See = EP.UsersManagers.FirstOrDefault(f => f.UsersManager_Name == UserTXT.Text && f.UsersManager_Pass == PassUsr.Password);
            if (See != usersManager)
            {
                MessageBox.Show("Login Success, Welcome To Manager");
                ManagingWin managingWin = new ManagingWin();
                managingWin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong , check your data!");
            }
        }
    }
}
