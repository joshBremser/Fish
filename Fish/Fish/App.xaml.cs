using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Fish.Services;
using Fish.Views;

namespace Fish
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new WelcomePage();
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
