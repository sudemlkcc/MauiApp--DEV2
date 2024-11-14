namespace MauiApp1deneme6.Pages;

public partial class YapilacaklarListesiPage : ContentPage
{
    private List<string> yapilacaklarListesi;

    public YapilacaklarListesiPage()
    {
        InitializeComponent();
        yapilacaklarListesi = new List<string>();
        yapilacaklarListView.ItemsSource = yapilacaklarListesi;
    }

    private void OnEkleClicked(object sender, EventArgs e)
    {
        var yeniGorev = yapilacakEntry.Text?.Trim();
        if (!string.IsNullOrEmpty(yeniGorev))
        {
            yapilacaklarListesi.Add(yeniGorev);
            yapilacaklarListView.ItemsSource = null; // Update the ListView
            yapilacaklarListView.ItemsSource = yapilacaklarListesi;
            yapilacakEntry.Text = string.Empty; // Clear the entry
        }
    }

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var secilenGorev = e.SelectedItem as string;
        if (secilenGorev != null)
        {
            var cevap = DisplayAlert("Sil", $"{secilenGorev} görevini silmek istiyor musunuz?", "Evet", "Hayýr");
            cevap.ContinueWith(t =>
            {
                if (t.Result)
                {
                    yapilacaklarListesi.Remove(secilenGorev);
                    yapilacaklarListView.ItemsSource = null;
                    yapilacaklarListView.ItemsSource = yapilacaklarListesi;
                }
            });
        }
    }
}