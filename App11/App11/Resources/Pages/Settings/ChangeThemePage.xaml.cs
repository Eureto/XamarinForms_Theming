using App11.Resources.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections;
using System.Reflection;

namespace App11.Resources.Pages.Settings
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangeThemePage : ContentPage
    {
        public ChangeThemePage()
        {
            InitializeComponent();
            checkActiveTheme();
        }
        private void checkActiveTheme()
        {   
            switch(Application.Current.UserAppTheme)
            {
                case OSAppTheme.Light:
                    LightTheme.IsChecked = true;
                    break;
                case OSAppTheme.Dark:
                    DarkTheme.IsChecked = true; 
                    break;
                case OSAppTheme.Unspecified:
                default:
                    SystemTheme.IsChecked = true;
                    break;
            }
        }

        private void RadioButton_ChangeTheme(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;

            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                switch (radioButton.StyleId.ToString())
                {
                    case "DarkTheme":
                        mergedDictionaries.Add(new DarkTheme());
                        Application.Current.UserAppTheme = OSAppTheme.Dark;
                        break;
                    case "LightTheme":
                        mergedDictionaries.Add(new LightTheme());
                        Application.Current.UserAppTheme = OSAppTheme.Light;
                        break;
                    case "SystemTheme":
                        {
                            Application.Current.UserAppTheme = OSAppTheme.Unspecified;
                            switch (Application.Current.RequestedTheme)
                            {
                                case OSAppTheme.Light:
                                    mergedDictionaries.Add(new LightTheme());
                                    break;
                                case OSAppTheme.Dark:
                                    mergedDictionaries.Add(new DarkTheme());
                                    break;
                                case OSAppTheme.Unspecified:
                                    mergedDictionaries.Add(new LightTheme());
                                    break;
                            }

                            break;
                        }
                }

            }
        }
    }
}