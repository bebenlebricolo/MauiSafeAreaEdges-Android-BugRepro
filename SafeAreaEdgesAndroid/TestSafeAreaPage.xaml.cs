namespace SafeAreaEdgesAndroid;

public partial class TestSafeAreaPage : ContentPage
{
    public TestSafeAreaPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Simulate a long loading process
        Dispatcher.Dispatch(() => Task.Delay(2));
    }
}
