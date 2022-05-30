using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HR_Department.db;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HR_Department.views.layouts
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            HR_DepartmentEntities1.GetContext().teams.ToList();
            
        }


        private void dragme(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void CloseLogin(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        private void loginEnter(object sender, RoutedEventArgs e)
        {


            string login = loginBox.Text,
              pass = passwordBox.Password,
              admin = "Админ";


            CompanyListWindow companyWindow = new CompanyListWindow();

            teams authUser = null;

            using (HR_DepartmentEntities1 db = new HR_DepartmentEntities1())
            {
                authUser = db.teams.Where(b => b.login == login && b.password == pass).FirstOrDefault();
            }

            if( authUser.post == admin)
            {
                AdminCreateWindow adminW = new AdminCreateWindow(null);
                adminW.Show();
                companyWindow.Show();
                this.Close();

            }
            else if (authUser.post != admin)
            {
                companyWindow.Show();
                this.Close();
            }
            else if(authUser == null)
            {
                MessageBox.Show("Поле не может быть пустым");
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
