using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinForms.Pim
{
    public partial class App :Application
    {
        public App()
        {
            InitializeComponent();

            Resources = new ResourceDictionary();

            MainPage = new NavigationPage(new View.ChartSample());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //Xuni.Forms.Core.LicenseManager.Key = License.Key;
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
