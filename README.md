# XamarinForms_Theming
Theme in Xamarin Forms


My main problem during writing themes was making Status Bar Text Color adaptive to theme and its background
Solution:
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
