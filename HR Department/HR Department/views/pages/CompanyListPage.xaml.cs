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
using System.Windows.Threading;

namespace HR_Department.views.pages
{
    /// <summary>
    /// Логика взаимодействия для CompanyListPage.xaml
    /// </summary>
    public partial class CompanyListPage : Page
    {
        public CompanyListPage()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

            //Manager.MainFrame.Navigate(new ShowCompanyPage());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
           

            if (Visibility == Visibility.Visible)
                HR_DepartmentEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DBlist.ItemsSource = HR_DepartmentEntities1.GetContext().companyBD.ToList();


        }
      

        private void addCompany_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new CompanyStorePage(null));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();

        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            conentMain.Visibility = Visibility.Visible;
            loading.Visibility = Visibility.Hidden;
        }

        private void DBlist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int ID = (DBlist.SelectedItem as companyBD).id;
           // Manager.MainFrame.Navigate(new ShowCompanyPage((sender as Button).DataContext as companyBD));
            //Manager.MainFrame.Navigate(new ShowCompanyPage(ID));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ShowCompanyPage((sender as Button).DataContext as companyBD));
        }
    }
}
