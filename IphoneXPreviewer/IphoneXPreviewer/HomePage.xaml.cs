using System.Windows;

namespace WpfApp5
{
    /// <summary>
    /// Logique d'interaction pour HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
            var desktopWorkingArea = SystemParameters.WorkArea;
            Left = desktopWorkingArea.Right - this.Width - 20;
            Top = desktopWorkingArea.Bottom - this.Height - 100;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(ClientUrl.Text);
            main.Show();
            this.Close();
        }
    }
}
