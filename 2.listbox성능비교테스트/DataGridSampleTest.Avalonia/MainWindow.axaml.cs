using Avalonia.Controls;
using DataGridSampleTest.Shared.ViewModels;

namespace DataGridSampleTest.Avalonia
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