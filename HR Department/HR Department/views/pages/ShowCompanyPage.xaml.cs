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
    /// Логика взаимодействия для ShowCompanyPage.xaml
    /// </summary>
    public partial class ShowCompanyPage : Page
    {
       
        private companyBD _currentCompany = new companyBD();
        public ShowCompanyPage(companyBD selectCompany)
        {
            //companyBD selectCompany
            InitializeComponent();
            //ID = memberID;

            if (selectCompany != null)
              _currentCompany = selectCompany;

            DataContext = _currentCompany;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void companyStore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void editCompany_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new CompanyStorePage((sender as Button).DataContext as companyBD));
        }
    }
}
