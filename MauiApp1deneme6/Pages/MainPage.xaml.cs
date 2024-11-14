using MauiApp1deneme6.Pages;

namespace MauiApp1deneme6
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnKrediHesaplamaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KrediHesaplamaPage());
        }

        private async void OnBmiHesaplamaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewContent2());
        }

        private async void OnRenkSecimiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RenkSecimiPage());
        }

        private async void OnYapilacaklarListesiClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new YapilacaklarListesiPage());
        }
       
    }

}
