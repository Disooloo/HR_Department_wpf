using System;
using HR_Department.db;
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

namespace HR_Department.views.pages
{
    /// <summary>
    /// Логика взаимодействия для vacancyStorePage.xaml
    /// </summary>
    public partial class vacancyStorePage : Page
    {

        private vacancy _currentVacancy = new vacancy();
        public vacancyStorePage(vacancy selectVacancy)
        {
            InitializeComponent();
            if (selectVacancy != null)
                _currentVacancy = selectVacancy;

            DataContext = _currentVacancy;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void vacancyStore_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentVacancy.titleVacancy))
                errors.AppendLine("companyName error");
            if (string.IsNullOrWhiteSpace(_currentVacancy.responsible))
                errors.AppendLine("CompanyManager error");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentVacancy.id == 0)
                HR_DepartmentEntities1.GetContext().vacancy.Add(_currentVacancy);
            try
            {
                HR_DepartmentEntities1.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
