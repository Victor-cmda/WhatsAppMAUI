namespace WhatsAppMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            var image = new Image { Source = "picture.png" };
        }
    }
}