using System.Windows;
using System.Windows.Input;

namespace HR_Department.views.layouts
{
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }

        private void CloseHelp_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Content_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}