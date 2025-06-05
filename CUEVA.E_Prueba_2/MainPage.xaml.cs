namespace CUEVA.E_Prueba_2
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }


        private void Chistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Jokes_Api());

        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMe());

        }
    }

}