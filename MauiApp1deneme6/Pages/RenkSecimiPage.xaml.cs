namespace MauiApp1deneme6.Pages;

public class RenkSecimiPage : ContentPage
{
    public RenkSecimiPage()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void OnRenkSecildi(object sender, EventArgs e)
    {
        var button = (Button)sender;
        this.BackgroundColor = button.BackgroundColor;
    }
}