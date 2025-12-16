namespace MauiApp1sseddedd
{
    public partial class MainPage : ContentPage
    {
        int licznik = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        

        private void przycisk_Clicked(object sender, EventArgs e)
        {
            licznik++;
            
            tekst.Text ="Polubień: "+ licznik;

        }
        private void przyciskUn_Clicked(object sender, EventArgs e)
        {
            licznik--;
            if (licznik >= 0)
            {
                tekst.Text = "Polubień: " + licznik;
            }
            else
            {
                licznik = 0;
                tekst.Text = "Polubień: " + licznik;
            }
        }
    }
}
