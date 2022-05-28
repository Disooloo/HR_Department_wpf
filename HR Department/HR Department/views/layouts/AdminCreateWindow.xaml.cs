using System;
using System.Collections.Generic;
using System.Linq;
using HR_Department.db;
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

namespace HR_Department.views.layouts
{
    /// <summary>
    /// Логика взаимодействия для AdminCreateWindow.xaml
    /// </summary>
    public partial class AdminCreateWindow : Window
    {
        private teams _currentTeams = new teams();

        public AdminCreateWindow(teams selectTeams)
        {
            InitializeComponent();

            if (selectTeams != null)
                _currentTeams = selectTeams;

            DataContext = _currentTeams;

            DBlist.ItemsSource = HR_DepartmentEntities1.GetContext().teams.ToList();
        }

        private void CloseLogin(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow logW = new LoginWindow();
            logW.Show();
            this.Close();
        }

        private void companyStore_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentTeams.firstName))
                errors.AppendLine("firstName error");
            if (string.IsNullOrWhiteSpace(_currentTeams.lastName))
                errors.AppendLine("lastName error");
            if (string.IsNullOrWhiteSpace(_currentTeams.login))
                errors.AppendLine("login error");
            if (string.IsNullOrWhiteSpace(_currentTeams.password))
                errors.AppendLine("password error");
            if (string.IsNullOrWhiteSpace(_currentTeams.post))
                errors.AppendLine("post error");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentTeams.id == 0)
                HR_DepartmentEntities1.GetContext().teams.Add(_currentTeams);
            try
            {
                HR_DepartmentEntities1.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Grid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}