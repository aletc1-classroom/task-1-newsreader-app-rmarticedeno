using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using newsreader.Services;
using newsreader.Views;

namespace newsreader
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
