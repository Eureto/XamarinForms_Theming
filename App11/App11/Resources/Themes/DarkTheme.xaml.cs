using App11.Resources.Class;
using Xamarin.Forms;

namespace App11.Resources.Themes
{
    public partial class DarkTheme : ResourceDictionary
    {
        public DarkTheme()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.Android)
            {
                var statusbar = DependencyService.Get<IChangeStatusBarTextColor>();
                statusbar.SetStatusBarColor(false);
            }
        }
    }
}
