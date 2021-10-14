using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App11.Droid;
using App11.Resources.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using System.Xml.Linq;
using System.IO;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(ChangeStatusBarTextColor))]
namespace App11.Droid
{
    public class ChangeStatusBarTextColor : IChangeStatusBarTextColor
    {
        public ChangeStatusBarTextColor()
        { }
        public void SetStatusBarColor( bool darkStatusBarTint)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                var activity = Platform.CurrentActivity;
                var window = activity.Window;

                
                var flags = (Android.Views.StatusBarVisibility)Android.Views.SystemUiFlags.LightStatusBar;
                window.DecorView.SystemUiVisibility = darkStatusBarTint ? flags : 0;
                

            }
        }
    }
}
