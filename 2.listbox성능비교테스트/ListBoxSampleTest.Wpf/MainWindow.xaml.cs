using ListBoxSampleTest.Shared;
using System.Windows;

namespace ListBoxSampleTest.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent ();
            this.DataContext = new MainViewModel ();
        }
    }
}