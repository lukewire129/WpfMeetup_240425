
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListBoxSampleTest.Shared.Models.UI;
using ListBoxSampleTest.Shared.Services;
using System.Collections.ObjectModel;

namespace ListBoxSampleTest.Shared;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] ObservableCollection<LottoModel> lottoModels;
    [ObservableProperty] string result;
    [ObservableProperty] int searchCount;
    public MainViewModel()
    {
        LottoModels = new ();
    }

    [RelayCommand]
    private async void Search()
    {
        int i = 1;
        Result = $"{i} / {SearchCount}";
        LottoModels.Clear ();

        var lottoService = new LottoService ();
        await foreach (var lottoModel in lottoService.GetLottoNumbersAsync (SearchCount))
        {
            LottoModels.Add (lottoModel);
            Result = $"{i++} / {SearchCount}";
        }
    }
}
