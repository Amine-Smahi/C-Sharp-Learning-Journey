using CefSharp;
using System.Windows;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public MainWindow(string url)
        {
            InitializeComponent();
            var desktopWorkingArea = SystemParameters.WorkArea;
            Left = desktopWorkingArea.Right - this.Width - 20;
            Top = desktopWorkingArea.Bottom - this.Height + 200;
            Browser.Address = url;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (switcher.Content == "Add border")
            {
                switcher.Content = "Remove border";
                borderimage.Visibility = Visibility.Visible;
            }
            else
            {
                switcher.Content = "Add border";
                borderimage.Visibility = Visibility.Hidden;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Browser.Reload(false);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Browser.Reload(true);
        }
    }
}
