using System.Windows;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var caption = "Hello Message";
            var button = MessageBoxButton.OK;
            var icon = MessageBoxImage.None;

            MessageBox.Show($"Hello, {NameTextBox.Text}", caption, button, icon, MessageBoxResult.Yes);
        }
    }
}
