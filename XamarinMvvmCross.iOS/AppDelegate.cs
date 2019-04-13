using Foundation;
using MvvmCross.Platforms.Ios.Core;
using UIKit;
using XamarinMvvmCross.Core;

namespace XamarinMvvmCross.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            return result;
        }
    }
}

