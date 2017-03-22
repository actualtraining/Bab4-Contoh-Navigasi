using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Bab4_Contoh_Navigasi
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var myNav = new SampleTab();
            var myNav = new NavigationPage(new FormNavigasi1());
            //myNav.BarBackgroundColor = Color.Black;
            //myNav.BarTextColor = Color.White;
            
            MainPage = myNav;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
