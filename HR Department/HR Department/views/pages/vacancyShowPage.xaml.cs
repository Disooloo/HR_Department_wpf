using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HR_Department.db;
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
    /// Логика взаимодействия для vacancyShowPage.xaml
    /// </summary>
    public partial class vacancyShowPage : Page
    {
        private vacancy _currentCompany = new vacancy();

        public vacancyShowPage(vacancy selectCompany)
        {
            InitializeComponent();

            if (selectCompany != null)
                _currentCompany = selectCompany;

            DataContext = _currentCompany;

            DBlist.ItemsSource = HR_DepartmentEntities1.GetContext().companyBD.ToList();
        }

        private void editCompany_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new vacancyStorePage((sender as Button).DataContext as vacancy));
        }

        private void showCompany(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ShowCompanyPage((sender as Button).DataContext as companyBD));
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
