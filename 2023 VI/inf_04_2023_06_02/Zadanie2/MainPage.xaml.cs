namespace Zadanie2
{
    public partial class MainPage : ContentPage
    {
        private string[] powitanie = { "Dzień dobry",
        "Good morning", "Buenos dias"};
        private int aktualnyIndex = 0;
        public MainPage()
        {
            InitializeComponent();
            rozmiar.Text = "Rozmiar: " + slider.Value.ToString();
            wynik.Text = powitanie[aktualnyIndex];
        }

        private void OnClicked(object sender, EventArgs e)
        {
            aktualnyIndex = (aktualnyIndex + 1) % powitanie.Length;
            wynik.Text = powitanie[aktualnyIndex];
        }
        private void zmianaSlidera(object sender, ValueChangedEventArgs e)
        {
            rozmiar.Text = "Rozmiar: " + ((int)e.NewValue).ToString();
            wynik.FontSize = (int)e.NewValue;
        }
    }

}
