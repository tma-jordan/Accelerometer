using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccelerometerFrontend
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AccelerometerPage();
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
