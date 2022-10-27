# XamarinForms_Theming
Theme in Xamarin Forms


Setting Status Bar Color:
```C#
public void SetStatusBarColor(bool darkStatusBarTint)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                var activity = Platform.CurrentActivity;
                var window = activity.Window;

                var flags = (Android.Views.StatusBarVisibility)Android.Views.SystemUiFlags.LightStatusBar;
                window.DecorView.SystemUiVisibility = darkStatusBarTint ? flags : 0;
            }
```
