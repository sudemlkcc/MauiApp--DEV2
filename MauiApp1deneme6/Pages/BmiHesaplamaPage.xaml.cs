using Microsoft.Extensions.Logging.Abstractions;
namespace MauiApp1deneme6.Pages
{
    public partial class NewContent2 : ContentView
    {
        public NewContent2()
        {
            InitializeComponent();
        }

        private void OnHesaplaClicked(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(boyEntry.Text) / 100;
            double kilo = Convert.ToDouble(kiloEntry.Text);
            double bmi = kilo / (boy * boy);
            bmiSonucLabel.Text = $"BMI: {bmi:F2}"; // This line should now work

            if (bmi < 18.5)
            {
                bmiSonucLabel.Text += "\nZayıf";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                bmiSonucLabel.Text += "\nNormal";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                bmiSonucLabel.Text += "\nFazla Kilolu";
            }
            else
            {
                bmiSonucLabel.Text += "\nObez";
            }
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isValidInput = !string.IsNullOrEmpty(boyEntry.Text) && !string.IsNullOrEmpty(kiloEntry.Text);
            hesaplaButton.IsEnabled = isValidInput;
        }
    }
}
