namespace Reparai
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnIniciarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Login");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}