using ProyectoIntegrado_VMS.Screens;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrado_VMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new LoginScreen() );
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
