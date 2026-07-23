using System.Reflection;
using System.Text.RegularExpressions;

namespace SafeAreaEdgesAndroid;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        // Decoding MAUI versioning system
        var mauiAssembly = typeof(Microsoft.Maui.IApplication).Assembly;
        var mauiProductVersionRaw = mauiAssembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()!.InformationalVersion.ToString();
        var semVerPattern = "([\\d]+\\.[\\d]+\\.[\\d]+)";
        var mauiProductVersion = Regex.Match(mauiProductVersionRaw, semVerPattern);

        MauiVersionLabel.Text = mauiProductVersion.Value;
    }

    private void OnCounterClicked(object? sender, EventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() => Shell.Current.GoToAsync("//TestSafeAreaPage"));
    }
}
