using System.Windows;

namespace PI_Calculator
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //HELP: https://www.youtube.com/watch?v=YoZcAx_0rNM
            mainFrame.NavigationService.Navigate(new MainMenu());
        }
    }
}
