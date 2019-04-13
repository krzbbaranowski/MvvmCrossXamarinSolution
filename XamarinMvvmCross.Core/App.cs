using MvvmCross.IoC;
using MvvmCross.ViewModels;
using XamarinMvvmCross.Core.ViewModels;

namespace XamarinMvvmCross.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();
        }
    }
}
