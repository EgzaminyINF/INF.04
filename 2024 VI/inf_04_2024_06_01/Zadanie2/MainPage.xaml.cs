namespace Zadanie2
{
    public partial class MainPage : ContentPage
    {
        private Random losowanie = new Random();
        private int wynikGry = 0;
        private Image[] kosci = new Image[5];
        public MainPage()
        {
            InitializeComponent();
            kosci = new Image[] { kosc1, kosc2, kosc3, kosc4, kosc5 }; ;
        }

        private void rzucKoscmi(object sender, EventArgs e)
        {
            int wynikLosowania = 0;
            for (int i = 0; i < kosci.Length; i++) 
            {
                int wartoscKosci = losowanie.Next(1, 7);
                kosci[i].Source = $"k{wartoscKosci}.jpg";
                wynikLosowania += wartoscKosci;
            }
            wynikGry += wynikLosowania;
            wynikLosowaniaLabel.Text = "Wynik tego losowania: " + wynikLosowania.ToString(); 
            wynikGryLabel.Text = "Wynik gry: " + wynikGry.ToString();
        }
        private void resetWyniku(object sender, EventArgs e)
        {
            foreach (var image in kosci)
            {
                image.Source = "question.jpg";
            }
            wynikGry = 0;
            wynikLosowaniaLabel.Text = "Wynik tego losowania: 0";
            wynikGryLabel.Text = "Wynik gry: 0";
        }
    }

}
