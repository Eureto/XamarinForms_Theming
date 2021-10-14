using App11.Resources.Themes;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App11.Resources.Class
{
     class Config
    {
        public static void LoadTheme()
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                if (Application.Current.UserAppTheme == OSAppTheme.Unspecified)
                {

                    switch (Application.Current.RequestedTheme)
                    {
                        case OSAppTheme.Light:
                        default:
                            mergedDictionaries.Add(new LightTheme());
                            break;
                        case OSAppTheme.Dark:
                            mergedDictionaries.Add(new DarkTheme());
                            break;
                        case OSAppTheme.Unspecified:
                            mergedDictionaries.Add(new LightTheme());
                            break;
                    }
                }else 
                {
                    mergedDictionaries.Clear();
                    switch (Application.Current.UserAppTheme)
                    {
                        case OSAppTheme.Dark:
                            mergedDictionaries.Add(new DarkTheme());
                            break;
                        case OSAppTheme.Light:
                        default:
                            mergedDictionaries.Add(new LightTheme());
                            break;
                    }
                }
                
            }
        }
    }
}
