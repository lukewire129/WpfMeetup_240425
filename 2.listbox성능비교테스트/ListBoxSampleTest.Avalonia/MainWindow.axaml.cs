using Avalonia.Controls;
using ListBoxSampleTest.Shared;

namespace ListBoxSampleTest.Avalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent ();
            this.DataContext = new MainViewModel ();
        }
    }
}