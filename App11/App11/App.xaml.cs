using App11.Resources.Themes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App11.Resources.Class;


namespace App11
{
    public partial class App : Application
    {   
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            Application.Current.RequestedThemeChanged += (s, a) =>
            {
               Config.LoadTheme(); //Changing theme at runtime
            };
        }

        protected override void OnStart()
        {
            Config.LoadTheme();
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            Config.LoadTheme();
        }
    }
}
