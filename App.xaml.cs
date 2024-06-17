using JPillajoS3.View;

namespace JPillajoS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new vLogin());

        }
    }
}
