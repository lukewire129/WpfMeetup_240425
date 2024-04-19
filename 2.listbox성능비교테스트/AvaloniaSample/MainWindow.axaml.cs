using Avalonia.Controls;
using CommViewModel;

namespace AvaloniaSample
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