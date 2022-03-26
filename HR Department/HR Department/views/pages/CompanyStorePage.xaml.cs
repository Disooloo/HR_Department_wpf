using HR_Department.db;
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

namespace HR_Department.views.pages
{
    /// <summary>
    /// Логика взаимодействия для CompanyStorePage.xaml
    /// </summary>
    public partial class CompanyStorePage : Page
    {

        private company _currentCompany = new company();

        
        public CompanyStorePage(company selectCompany)
        {
            InitializeComponent();

            if (selectCompany != null)
                _currentCompany = selectCompany;

            DataContext = _currentCompany;

        }

        private void companyStore_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentCompany.companyName))
                errors.AppendLine("companyName error");
            if (string.IsNullOrWhiteSpace(_currentCompany.CompanyManager))
                errors.AppendLine("CompanyManager error");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if(_currentCompany.id == 0)
                HR_DepartmentEntities.GetContext().company.Add(_currentCompany);
            try
            {
                HR_DepartmentEntities.GetContext().SaveChanges();
                MessageBox.Show("Компания добавлена");
                Manager.MainFrame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
