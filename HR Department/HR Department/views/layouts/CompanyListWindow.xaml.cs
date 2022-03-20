using HR_Department.views.pages;
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

namespace HR_Department.views.layouts
{
    /// <summary>
    /// Логика взаимодействия для CompanyListWindow.xaml
    /// </summary>
    public partial class CompanyListWindow : Window
    {
        public CompanyListWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new CompanyListPage());
            Manager.MainFrame = MainFrame;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimase_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized; 
            }
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы точно хотите выйти ?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.No)
                e.Cancel = true;
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
           /* if (MainFrame.CanGoBack)
            {
                
                //bnt_back.Visibility = Visibility.Visible; // на будующее, если нужны будут хлебные крошки
            }
            else
            {
                //bnt_back.Visibility = Visibility.Hidden;
            }*/
        }
    }
}
