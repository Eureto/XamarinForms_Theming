using App11.Resources.Class;
using System;
using Xamarin.Forms;

namespace App11.Resources.Themes
{
    public partial class LightTheme : ResourceDictionary
    {
        public LightTheme()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                var statusbar = DependencyService.Get<IChangeStatusBarTextColor>();
                statusbar.SetStatusBarColor(true);
            }
        }
    }
}
