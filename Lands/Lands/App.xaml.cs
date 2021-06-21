using Lands.Views;
using Xamarin.Forms;

namespace Lands
{

    
    public partial class App : Application
    {

        #region "Constructor"
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new LoginPage());
        }
        #endregion

        #region "Methods"
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion
    }
}
