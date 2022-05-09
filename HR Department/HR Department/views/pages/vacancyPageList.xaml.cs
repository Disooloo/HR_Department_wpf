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
using System.Windows.Threading;

namespace HR_Department.views.pages
{
    /// <summary>
    /// Логика взаимодействия для vacancyPageList.xaml
    /// </summary>
    public partial class vacancyPageList : Page
    {
        public vacancyPageList()
        {
            InitializeComponent();

        }

        private void DBlist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void addCompany_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new vacancyStorePage(null));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new vacancyShowPage((sender as Button).DataContext as vacancy));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (Visibility == Visibility.Visible)
                HR_DepartmentEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            DBlist.ItemsSource = HR_DepartmentEntities1.GetContext().vacancy.ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            Count_Base();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            conentMain.Visibility = Visibility.Visible;
            loading.Visibility = Visibility.Hidden;
        }

        private void Count_Base()
        {
            //var purchCount = (from purchase in myBlaContext.purchases select purchase).Count();
            var query = HR_DepartmentEntities1.GetContext().vacancy.Count();

            _Count_Base_title.Text = query.ToString();
        }

        private void Update()
        {
            var currentVacancy = HR_DepartmentEntities1.GetContext().vacancy.ToList();
            var searchTitle = TBox_search.Text.ToString();

            currentVacancy = currentVacancy.Where(p =>
                  p.titleVacancy.ToString().Contains(searchTitle)).ToList();


            DBlist.ItemsSource = currentVacancy.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }
    }
}
