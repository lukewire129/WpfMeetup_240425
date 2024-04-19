
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] List<string> testData;

    public MainViewModel()
    {
        this.TestData = new List<string>();

        
    }

    [RelayCommand]
    private void Add()
    {
        for (int i = 0; i < 10000; i++)
        {
            this.TestData.Add (i.ToString ());
        }
    }
}
