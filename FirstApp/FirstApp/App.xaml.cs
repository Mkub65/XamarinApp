using FirstApp.Services;
using FirstApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstApp
{
    public partial class App : Application
    {
        public static string DateBaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new MainPage());
        }

        public App(string dataBaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DateBaseLocation = dataBaseLocation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
