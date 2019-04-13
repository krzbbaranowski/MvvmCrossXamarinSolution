using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Views;
using Android.App;
using Android.Content.PM;

[Activity(
        Label = "QR Scanner"
        , MainLauncher = true
        , Icon = "@mipmap/ic_launcher"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
public class SplashScreen : MvxSplashScreenActivity
{
    public SplashScreen()
        : base(XamarinMvvmCross.Android.Resource.Layout.splash)
    {
    }
}