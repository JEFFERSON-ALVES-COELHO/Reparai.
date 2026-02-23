namespace Reparai
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Registering the route for the Login page
            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(Cadastro), typeof(Cadastro));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}