using Microsoft.UI.Xaml.Controls;

using SoundBoarebet.ViewModels;

namespace SoundBoarebet.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
