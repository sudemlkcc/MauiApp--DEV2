namespace MauiApp1deneme6.Pages;
public partial class KrediHesaplamaPage : ContentPage
{
    public KrediHesaplamaPage()
    {
        InitializeComponent();
    }

    private void OnHesaplaClicked(object sender, EventArgs e)
    {
        double miktar = Convert.ToDouble(miktarEntry.Text);
        double faiz = Convert.ToDouble(faizEntry.Text);
        int vade = Convert.ToInt32(vadeEntry.Text);
        double faizOrani = faiz / 100;
        double aylikTaksit = (miktar * faizOrani) / (1 - Math.Pow(1 + faizOrani, -vade));
        sonucLabel.Text = $"Aylık Taksit: {aylikTaksit:C2}";
    }
}
