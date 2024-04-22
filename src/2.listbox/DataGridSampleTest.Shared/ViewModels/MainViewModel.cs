using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DataGridSampleTest.Shared.Models;
using System.Collections.ObjectModel;

namespace DataGridSampleTest.Shared.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] ObservableCollection<DeviceModel> devices;

    public MainViewModel()
    {
        this.Devices = new ObservableCollection<DeviceModel>();
    }

    [RelayCommand]
    private async void RandomData()
    {
        this.Devices.Clear ();

        await foreach (var deviceModel in GetDevices())
        {
            this.Devices.Add (deviceModel);
        }
    }

    private async IAsyncEnumerable<DeviceModel> GetDevices()
    {
        for (int i = 0; i < 100000; i++)
        {
            await Task.Delay (10);
            yield return new DeviceModel ()
            {
                DeviceId = i.ToString (),
                Text1 = Random.Shared.NextDouble ().ToString (),
                Text2 = Random.Shared.NextDouble ().ToString (),
                Text3 = Random.Shared.NextDouble ().ToString (),
                Text4 = Random.Shared.NextDouble ().ToString (),
                Text5 = Random.Shared.NextDouble ().ToString (),
                Text6 = Random.Shared.NextDouble ().ToString (),
                Text7 = Random.Shared.NextDouble ().ToString (),
                Text8 = Random.Shared.NextDouble ().ToString (),
                Text9 = Random.Shared.NextDouble ().ToString (),
                Text10 = Random.Shared.NextDouble ().ToString (),
                Text11 = Random.Shared.NextDouble ().ToString (),
                Text12 = Random.Shared.NextDouble ().ToString (),
                Text13 = Random.Shared.NextDouble ().ToString (),
                Text14 = Random.Shared.NextDouble ().ToString (),
                Text15 = Random.Shared.NextDouble ().ToString (),
                Text16 = Random.Shared.NextDouble ().ToString (),
                Text17 = Random.Shared.NextDouble ().ToString (),
                Text18 = Random.Shared.NextDouble ().ToString (),
                Text19 = Random.Shared.NextDouble ().ToString (),
                Text20 = Random.Shared.NextDouble ().ToString (),
                Text21 = Random.Shared.NextDouble ().ToString (),
                Text22 = Random.Shared.NextDouble ().ToString (),
                Text23 = Random.Shared.NextDouble ().ToString (),
                Text24 = Random.Shared.NextDouble ().ToString (),
                Text25 = Random.Shared.NextDouble ().ToString (),
                Text26 = Random.Shared.NextDouble ().ToString (),
                Text27 = Random.Shared.NextDouble ().ToString (),
                Text28 = Random.Shared.NextDouble ().ToString (),
                Text29 = Random.Shared.NextDouble ().ToString (),
                Text30 = Random.Shared.NextDouble ().ToString (),
                Text31 = Random.Shared.NextDouble ().ToString (),
                Text32 = Random.Shared.NextDouble ().ToString (),
                Text33 = Random.Shared.NextDouble ().ToString (),
            };
        }
    }
}
